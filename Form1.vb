Imports System.Data.Common
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Form1

    'INITIALIZATION
    Public dataset As New DataSet
    Private dbConnection As New DatabaseConnection
    Private Property TablePointer As Integer
        Get
            Return Integer.Parse(tablePointerTxtBox.Text)
        End Get
        Set(value As Integer)
            tablePointerTxtBox.Text = value
        End Set
    End Property

    Private Property RowPointer As Integer
        Get
            Return Integer.Parse(RowPointerTxt.Text)
        End Get
        Set(value As Integer)
            RowPointerTxt.Text = value
        End Set
    End Property


    '-------------------DATABASE CONNECTION--------------------
    '--------------SLIDE 6 / STORING IN DATA SETS---------------
    Private Sub connectDbBtn_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Using conn = dbConnection.GetConnection()
            Try
                conn.Open()
                Dim query1 = "SELECT * FROM PersonalInfo_TB"

                'Data Adapter to retrieve data
                Dim adapter As New MySqlDataAdapter(query1, conn)
                adapter.Fill(dataset, "PersonalInfo_TB")




                DataSetView.DataSource = dataset.Tables(0)
                MessageBox.Show("Succesfully connected")
                connectionLabel.Text = "Connected"
                ConnectionProgressBar.Value = 100
                addTableTextBox.Enabled = True
                tableNameTxtBox.Enabled = True
                refreshDbBtn.Enabled = True
                addTableBtn.Enabled = True


                btnAdd.Enabled = True
                btnDelete.Enabled = True
                btnEdit.Enabled = True

                btnRowLeft.Enabled = True
                btnRowRight.Enabled = True
                btnTableRight.Enabled = True
                btnTableLeft.Enabled = True

                btnRemoveTable.Enabled = True

                btnConnect.Enabled = False

                TablePointer = 0

                lblTableName.Text = dataset.Tables(TablePointer).TableName
                tablePointerTxtBox.Text = TablePointer

                'Sets the row pointer of the table to 0
                RowPointerTxt.Text = 0
            Catch ex As Exception
                MessageBox.Show("Connection Failed! Try Again!")
            End Try
        End Using
    End Sub
    '----------------------------------------------------------------
    '
    '
    '
    '---------- SLIDE 9 - ACCESSING DATA SETS TABLES    --------------
    Private Sub addTable_Click(sender As Object, e As EventArgs) Handles addTableBtn.Click
        'Checks for existing table in dataset
        For Each table As DataTable In dataset.Tables
            If table.TableName = addTableTextBox.Text Then
                MsgBox("Table Already Exist")
                Return
            End If
        Next

        ' CREATES NEW DATATABLE BASED ON THE INPUT NAME OF THE USER
        Try
            Dim query As String = $"SELECT * FROM {addTableTextBox.Text}"
            Dim dataTable As New DataTable(addTableTextBox.Text)

            Using connection = dbConnection.GetConnection
                Dim adapter As New MySqlDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using

            'THIS WILL ADD THE CREATED DATATABLE TO THE DATA SET
            dataset.Tables.Add(dataTable)

            'Updates the table count to sync with the pointer
            TablePointer = dataset.Tables.Count - 1

            ' Bind the DataTable to the DataGridView
            DataSetView.DataSource = dataset.Tables(TablePointer)

            lblTableName.Text = dataset.Tables(TablePointer).TableName

            'Resets the row pointer
            RowPointer = 0

            addTableTextBox.Clear()
        Catch ex As Exception
            MessageBox.Show($"Table cannot be fetch from Database{ex.Message}")
        End Try
    End Sub
    Private Sub removeTableBtn_Click(sender As Object, e As EventArgs) Handles btnRemoveTable.Click
        If Not dataset.Tables.Count = 0 Then
            MessageBox.Show($"Removed {dataset.Tables(TablePointer).TableName} from this dataset Successfully!")

            'BASED ON THE TABLE NUMBER INDICATED, IT WILL DELETE THAT TABLE
            dataset.Tables.Remove(dataset.Tables(TablePointer).TableName)

            'Refresh the dataset by showing the last datatable
            If dataset.Tables.Count = 0 Then
                DataSetView.DataSource = Nothing
                lblTableName.Text = "-"
            ElseIf TablePointer = 0 Then
                DataSetView.DataSource = dataset.Tables(dataset.Tables.Count - 1)
                lblTableName.Text = dataset.Tables(TablePointer).TableName
            Else
                DataSetView.DataSource = dataset.Tables(TablePointer - 1)
                TablePointer -= 1
                lblTableName.Text = dataset.Tables(TablePointer).TableName
            End If
        Else
            MessageBox.Show("There are no tables on this dataset")
        End If


    End Sub

    '-----------------------------------------------------------------
    '
    '
    '
    '-------------- SLIDE 10 - WORKING WITH ROWS    -------------------
    Private Sub addRowsBtn_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim form As New addForm(Me)
        form.ShowDialog()
    End Sub
    '-----------------------------------------------------------------

    '--- SLIDE 15-16 - ADDING AND DELETING ROWS (connected from SLIDE 10)    ----
    Private Sub deleteRowBtn_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Checks if there is no rows exist on a data table
        If DataSetView.SelectedRows.Count > 0 Then
            Dim currentRow As DataRow = dataset.Tables(TablePointer).Rows(RowPointer)
            ' Mark that row for deletion
            currentRow.Delete()

            DataSetView.DataSource = Nothing
            DataSetView.DataSource = dataset.Tables(TablePointer)
            If Not RowPointer = 0 Then
                RowPointer -= 1
            End If
            updateDatabase()
        Else
            MessageBox.Show("No records to delete.")
            Return
        End If
    End Sub
    '-----------------------------------------------------------------
    '-------------- SLIDE 17 - NAVIGATING THROUGH DATASET    -------------------
    Private Sub btnRowRight_Click(sender As Object, e As EventArgs) Handles btnRowRight.Click
        If Not dataset.Tables.Count = 0 Then
            Dim rowCount = dataset.Tables(TablePointer).Rows.Count

            If RowPointer < rowCount - 1 And Not rowCount = 0 Then
                RowPointer += 1
                DataSetView.Rows(RowPointer).Selected = True
                DataSetView.CurrentCell = DataSetView.Rows(RowPointer).Cells(0)
            End If
        End If

    End Sub
    Private Sub btnRowLeft_Click(sender As Object, e As EventArgs) Handles btnRowLeft.Click
        If Not dataset.Tables.Count = 0 Then
            Dim rowCount = dataset.Tables(TablePointer).Rows.Count
            If RowPointer < rowCount And Not RowPointer <= 0 Then
                RowPointer -= 1
                DataSetView.Rows(RowPointer).Selected = True
                DataSetView.CurrentCell = DataSetView.Rows(RowPointer).Cells(0)
            End If
        End If
    End Sub
    Private Sub btnTableRight_Click(sender As Object, e As EventArgs) Handles btnTableRight.Click
        Dim tableCount = dataset.Tables.Count - 1
        If TablePointer < tableCount Then
            If Not TablePointer = tableCount Then
                TablePointer += 1
            End If
            lblTableName.Text = dataset.Tables(TablePointer).TableName
            tablePointerTxtBox.Text = TablePointer
            DataSetView.DataSource = dataset.Tables(TablePointer)

            RowPointer = 0
            DataSetView.Rows(RowPointer).Selected = True
            DataSetView.CurrentCell = DataSetView.Rows(RowPointer).Cells(0)
        End If
    End Sub
    Private Sub btnTableLeft_Click(sender As Object, e As EventArgs) Handles btnTableLeft.Click
        Dim tableCount = dataset.Tables.Count

        If TablePointer < tableCount Then
            If Not TablePointer = 0 Then
                TablePointer -= 1
            End If
            lblTableName.Text = dataset.Tables(TablePointer).TableName
            tablePointerTxtBox.Text = TablePointer
            DataSetView.DataSource = dataset.Tables(TablePointer)

            RowPointer = 0
            DataSetView.Rows(RowPointer).Selected = True
            DataSetView.CurrentCell = DataSetView.Rows(RowPointer).Cells(0)
        End If
    End Sub


    '-------------- SLIDE 18-19 - UPDATING THE DATABASE WITH THE ADAPTER    -------------------
    Public Sub updateDatabase()
        Using conn = dbConnection.GetConnection()
            Try
                conn.Open()
                Dim query = $"SELECT * FROM {dataset.Tables(TablePointer).TableName}"
                Dim adapter As New MySqlDataAdapter(query, conn)
                updateCommands(adapter, conn)

                adapter.Update(dataset, dataset.Tables(TablePointer).TableName)
                'Refresh()
                MessageBox.Show($"Succesfully updated the dataset")
            Catch ex As Exception
                MessageBox.Show($"Eror {ex}")
            End Try

        End Using
    End Sub


    '-------------- SLIDE 20 - 22   -------------------
    Private Sub updateCommands(adapter As MySqlDataAdapter, conn As MySqlConnection)
        Dim insertCommand As New MySqlCommand("INSERT INTO PersonalInfo_TB (Firstname, Lastname, Contact, Email, Sex) VALUES (@Firstname, @Lastname, @Contact, @Email, @Sex); SELECT LAST_INSERT_ID() AS ID", conn)
        insertCommand.Parameters.Add("@Firstname", MySqlDbType.VarChar, 50, "Firstname")
        insertCommand.Parameters.Add("@Lastname", MySqlDbType.VarChar, 50, "Lastname")
        insertCommand.Parameters.Add("@Contact", MySqlDbType.VarChar, 11, "Contact")
        insertCommand.Parameters.Add("@Email", MySqlDbType.VarChar, 50, "Email")
        insertCommand.Parameters.Add("@Sex", MySqlDbType.VarChar, 1, "Sex")

        '-------------- SLIDE 20 - Using UpdatedRowSource to Map Values to a DataSet   -------------------
        insertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord
        adapter.InsertCommand = insertCommand


        Dim updateCommand As New MySqlCommand("UPDATE PersonalInfo_TB SET Firstname = @Firstname, Lastname = @Lastname, Contact = @Contact, Email = @Email, Sex = @Sex WHERE ID = @ID", conn)
        updateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 0, "ID")
        updateCommand.Parameters.Add("@Firstname", MySqlDbType.VarChar, 50, "Firstname")
        updateCommand.Parameters.Add("@Lastname", MySqlDbType.VarChar, 50, "Lastname")
        updateCommand.Parameters.Add("@Contact", MySqlDbType.VarChar, 11, "Contact")
        updateCommand.Parameters.Add("@Email", MySqlDbType.VarChar, 50, "Email")
        updateCommand.Parameters.Add("@Sex", MySqlDbType.VarChar, 1, "Sex")
        adapter.UpdateCommand = updateCommand

        Dim deleteCommand As New MySqlCommand("DELETE FROM PersonalInfo_TB WHERE ID = @ID", conn)
        deleteCommand.Parameters.Add("@ID", MySqlDbType.Int32, 0, "ID")
        adapter.DeleteCommand = deleteCommand

    End Sub



    '------------------------------------------------------------------------
    Private Sub DataSetView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataSetView.CellClick
        RowPointer = e.RowIndex
    End Sub

    ' Not necessary because we use updaterowsourcemap
    Private Sub refreshDbBtn_Click(sender As Object, e As EventArgs) Handles refreshDbBtn.Click
        Using conn = dbConnection.GetConnection()
            Try
                conn.Open()
                'Clear the datatable
                dataset.Tables(TablePointer).Clear()
                Dim query = $"SELECT * FROM {dataset.Tables(TablePointer)}"
                Dim adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(dataset.Tables(TablePointer))
                RowPointer = 0
                DataSetView.Rows(RowPointer).Selected = True
                DataSetView.CurrentCell = DataSetView.Rows(RowPointer).Cells(0)
            Catch ex As Exception
                MessageBox.Show("There are no tables on this dataset")
            End Try
        End Using
    End Sub
End Class
