Imports System.Data.Common
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Form1

    'FOR CONNECTION OF DATABASE TO THIS PROGRAM
    Dim server As String = "localhost"
    Dim user As String = "root"
    Dim database As String = "sample"
    Dim port As Integer = 3306
    'String Interpoaltion
    Dim connectionString As String = $"server={server}; user={user}; database={database};port={port}"

    ' FUNCTION USED TO CALL CONNECTION TO DATABASE
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    'INITIALIZATION OF DATASET
    Dim dataset As New DataSet



    ' FOR DISPLAYING THE CONNECTION OF DATABASE TO THE PROGRAM
    ' BUTTON FOR CONNECTING TO THE DATABASE
    Private Sub connectDbBtn_Click(sender As Object, e As EventArgs) Handles connectDbBtn.Click
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM PersonalInfo_TB"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dataTable As New DataTable

                ' THIS WILL ONLY DISPLAY THE DATABASE TO THE DATABASE VIEW (DATAGRIDVIEW)
                adapter.Fill(dataTable)
                DatabaseView.DataSource = dataTable

                MessageBox.Show("Succesfully connected")
                connectionLabel.Text = "Connected"
                ConnectionProgressBar.Value = 100
                storeBtn.Enabled = True
                tableNameTxtBox.Enabled = True
                refreshDbBtn.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Connection Failed! Try Again!")
            End Try
        End Using
    End Sub


    '---------- SLIDE 6 - STORING DATA IN DATA SETS ------------------
    Private Sub storeBtn_Click(sender As Object, e As EventArgs) Handles storeBtn.Click
        Using conn As MySqlConnection = GetConnection()

            ' THIS WILL GET THE INPUT OF THE USER FOR THE NAME OF THE DATA TABLE
            ' String.IsNullOrWhiteSpace - Indicates whether a specified string is null
            If Not String.IsNullOrWhiteSpace(tableNameTxtBox.Text) Then
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM PersonalInfo_TB"
                    Dim adapter As New MySqlDataAdapter(query, conn)
                    'adapter.AcceptChangesDuringFill = False

                    ' (Name of Dataset, Identifying name for the data table)
                    adapter.Fill(dataset, tableNameTxtBox.Text)


                    DataSetView.DataSource = dataset.Tables(0)
                    MessageBox.Show($"Succesfully stored in dataset in {tableNameTxtBox.Text}")
                    tableNameTxtBox.Clear()
                    addTableBtn.Enabled = True
                    showTableBtn.Enabled = True
                    addRowsBtn.Enabled = True
                    addTableTextBox.Enabled = True
                    leftArrowBtn.Enabled = True
                    rightArrowBtn.Enabled = True
                    tableNoTextBox.Enabled = True
                    removeTableBtn.Enabled = True
                    updateDbBtn.Enabled = True
                    deleteRowBtn.Enabled = True
                    leftDeleteBtn.Enabled = True
                    deleteRowTxtBox.Enabled = True
                    rightBtnDelete.Enabled = True
                    leftArrowBtn_Click(sender, e)
                Catch ex As Exception
                End Try
            Else
                MessageBox.Show("Input Table Name")
            End If




        End Using
    End Sub
    ' ----------------------------------------------------------------

    '---------- SLIDE 9 - ACCESSING DATA SETS TABLES    --------------
    Private Sub addTable_Click(sender As Object, e As EventArgs) Handles addTableBtn.Click
        ' CREATES NEW DATATABLE BASED ON THE INPUT NAME OF THE USER
        Dim dataTable As New DataTable(addTableTextBox.Text)

        'THIS WILL ADD THE CREATED DATATABLE TO THE DATA SET
        dataset.Tables.Add(dataTable)


        MessageBox.Show($"Added Table {addTableTextBox.Text} Successfully!")
        addTableTextBox.Clear()
        dataTable.Columns.Add("ID", GetType(Integer))
        dataTable.Columns.Add("Firstname", GetType(String))
        dataTable.Columns.Add("Lastname", GetType(String))
        dataTable.Columns.Add("Contact", GetType(String))
        dataTable.Columns.Add("Email", GetType(String))
        dataTable.Columns.Add("Sex", GetType(Char))
    End Sub
    Private Sub removeTableBtn_Click(sender As Object, e As EventArgs) Handles removeTableBtn.Click
        MessageBox.Show($"Removed {dataset.Tables(num).TableName} Successfully!")

        'BASED ON THE TABLE NUMBER INDICATED, IT WILL DELETE THAT TABLE
        dataset.Tables.Remove(dataset.Tables(num).TableName)
    End Sub

    '-----------------------------------------------------------------

    '-------------- SLIDE 10 - WORKING WITH ROWS    -------------------
    Private Sub addRowsBtn_Click(sender As Object, e As EventArgs) Handles addRowsBtn.Click
        ' This will initially create an empty data row
        Dim newRow As DataRow = dataset.Tables(num).NewRow()
        ' This will add the empty datarow into the datatable
        dataset.Tables(num).Rows.Add(newRow)

        ' AcceptChanges() is not called because it will not be reflected to the database
        'newRow.AcceptChanges()

        MessageBox.Show("Added Successfully")
    End Sub
    '-----------------------------------------------------------------

    '--- SLIDE 15-16 - ADDING AND DELETING ROWS (connected from SLIDE 10)    ----
    Private Sub deleteRowBtn_Click(sender As Object, e As EventArgs) Handles deleteRowBtn.Click
        'Checks if there is no rows exist on a data table
        If dataset.Tables(num).Rows.Count = 0 Then
            MessageBox.Show("No records to delete.")
            Return
        End If

        ' If there is an existing rows, this will run
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()

                'Select the data from the table in the database
                Dim query As String = "SELECT * FROM PersonalInfo_TB"
                Dim adapter As New MySqlDataAdapter(query, conn)

                ' Selects the selected row number to delete
                Dim currentRow As DataRow = dataset.Tables(num).Rows(RowNumber)
                ' Mark that row for deletion
                currentRow.Delete()

                ' AcceptChanges() is not called because it will not be reflected to the database
                'currentRow.AcceptChanges()

                RowNumber = dataset.Tables(num).Rows.Count - 1
                deleteRowTxtBox.Text = RowNumber + 1
                DataSetView.Rows(RowNumber).DefaultCellStyle.BackColor = Color.Yellow
            Catch ex As Exception
                MessageBox.Show($"Error {ex}")
            End Try
        End Using

    End Sub
    '-----------------------------------------------------------------

    '-------------- SLIDE 17 - NAVIGATING THROUGH DATASET    -------------------
    Dim RowNumber As Integer = 0
    Private Sub rightBtnDelete_Click(sender As Object, e As EventArgs) Handles rightBtnDelete.Click

        Dim rowCount As Integer = dataset.Tables(num).Rows.Count - 1
        If RowNumber < rowCount Then
            DataSetView.Rows(RowNumber).DefaultCellStyle.BackColor = Color.White
            RowNumber += 1
            deleteRowTxtBox.Text = RowNumber + 1
            DataSetView.Rows(RowNumber).DefaultCellStyle.BackColor = Color.Yellow
        End If

    End Sub

    Private Sub leftDeleteBtn_Click(sender As Object, e As EventArgs) Handles leftDeleteBtn.Click
        Dim rowCount As Integer = dataset.Tables(num).Rows.Count - 1
        If RowNumber = 0 Then
            deleteRowTxtBox.Text = RowNumber + 1
            DataSetView.Rows(RowNumber).DefaultCellStyle.BackColor = Color.Yellow
        ElseIf RowNumber <= rowCount Then
            DataSetView.Rows(RowNumber).DefaultCellStyle.BackColor = Color.White
            RowNumber -= 1
            deleteRowTxtBox.Text = RowNumber + 1
            DataSetView.Rows(RowNumber).DefaultCellStyle.BackColor = Color.Yellow
        End If
    End Sub
    Private Sub showTableBtn_Click(sender As Object, e As EventArgs) Handles showTableBtn.Click
        Dim tableNames As String = "Table names in the DataSet: " & Environment.NewLine & Environment.NewLine

        For Each table As DataTable In dataset.Tables
            tableNames &= table.TableName & Environment.NewLine
        Next

        MessageBox.Show(tableNames)
    End Sub



    Private Sub leftArrowBtn_Click(sender As Object, e As EventArgs) Handles leftArrowBtn.Click
        If num = 0 Then
            Dim tableName = dataset.Tables(num).TableName
            tableNameTxt.Text = tableName
            tableNoTextBox.Text = num
            DataSetView.DataSource = dataset.Tables(num)
        Else
            num -= 1
            Dim tableName = dataset.Tables(num).TableName
            tableNameTxt.Text = tableName
            tableNoTextBox.Text = num
            DataSetView.DataSource = dataset.Tables(num)
        End If
    End Sub
    Dim num As Integer = 0
    Private Sub rightArrowBtn_Click(sender As Object, e As EventArgs) Handles rightArrowBtn.Click
        Dim tableCount = dataset.Tables.Count - 1
        If tableCount = 0 Then
            Dim tableName = dataset.Tables(num).TableName
            tableNameTxt.Text = tableName
            tableNoTextBox.Text = num
            DataSetView.DataSource = dataset.Tables(num)

        ElseIf num < tableCount Then
            num += 1
            Dim tableName = dataset.Tables(num).TableName
            tableNameTxt.Text = tableName
            tableNoTextBox.Text = num
            DataSetView.DataSource = dataset.Tables(num)
        End If
    End Sub


    Private Sub updateCommands(adapter As MySqlDataAdapter, conn As MySqlConnection)
        Dim insertCommand As New MySqlCommand("INSERT INTO PersonalInfo_TB (Firstname, Lastname, Contact, Email, Sex) VALUES (@Firstname, @Lastname, @Contact, @Email, @Sex)", conn)
        insertCommand.Parameters.Add("@Firstname", MySqlDbType.VarChar, 50, "Firstname")
        insertCommand.Parameters.Add("@Lastname", MySqlDbType.VarChar, 50, "Lastname")
        insertCommand.Parameters.Add("@Contact", MySqlDbType.VarChar, 11, "Contact")
        insertCommand.Parameters.Add("@Email", MySqlDbType.VarChar, 50, "Email")
        insertCommand.Parameters.Add("@Sex", MySqlDbType.VarChar, 1, "Sex")
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
    Private Sub updateDbBtn_Click(sender As Object, e As EventArgs) Handles updateDbBtn.Click
        Using conn As MySqlConnection = GetConnection()

            Try
                conn.Open()
                Dim query As String = $"SELECT * FROM PersonalInfo_TB"
                Dim adapter As New MySqlDataAdapter(query, conn)
                updateCommands(adapter, conn)



                'adapter.InsertCommand = New MySqlCommand($"INSERT INTO PersonalInfo_TB (firstname, lastname, contact) VALUES (Null, Null, Null)", conn)
                adapter.Update(dataset, dataset.Tables(num).TableName)
                MessageBox.Show($"Succesfully updated the dataset")
            Catch ex As Exception
                MessageBox.Show($"Eror {ex}")
            End Try

        End Using
    End Sub

    Private Sub refreshDbBtn_Click(sender As Object, e As EventArgs) Handles refreshDbBtn.Click
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM PersonalInfo_TB"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dataTable As New DataTable
                adapter.Fill(dataTable)
                DatabaseView.DataSource = dataTable
            Catch ex As Exception
            End Try
        End Using
    End Sub


End Class
