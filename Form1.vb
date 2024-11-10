Imports System.Data.Common
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Form1
    Dim server As String = "localhost"
    Dim user As String = "root"
    Dim database As String = "sample"
    Dim port As Integer = 3306

    Dim dataset As New DataSet

    'String Interpoaltion
    Dim connectionString As String = $"server={server}; user={user}; database={database};port={port}"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    Private Sub connectDbBtn_Click(sender As Object, e As EventArgs) Handles connectDbBtn.Click
        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()


                Dim query As String = "SELECT * FROM PersonalInfo_TB"
                Dim adapter As New MySqlDataAdapter(query, conn)

                Dim dataTable As New DataTable

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

    Private Sub storeBtn_Click(sender As Object, e As EventArgs) Handles storeBtn.Click
        Using conn As MySqlConnection = GetConnection()
            If Not String.IsNullOrWhiteSpace(tableNameTxtBox.Text) Then
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM PersonalInfo_TB"
                    Dim adapter As New MySqlDataAdapter(query, conn)
                    'adapter.AcceptChangesDuringFill = False

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
                    leftArrowBtn_Click(sender, e)
                Catch ex As Exception
                End Try
            Else
                MessageBox.Show("Input Table Name")
            End If




        End Using
    End Sub

    Private Sub addTable_Click(sender As Object, e As EventArgs) Handles addTableBtn.Click
        Dim dataTable As New DataTable(addTableTextBox.Text)
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
        Dim dataTable = dataset.Tables(num).TableName
        MessageBox.Show($"Removed Table {dataset.Tables(num).TableName} Successfully!")
        dataset.Tables.Remove(dataTable)

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

    Private Sub addRowsBtn_Click(sender As Object, e As EventArgs) Handles addRowsBtn.Click
        Dim newRow As DataRow = dataset.Tables(num).NewRow()
        dataset.Tables(num).Rows.Add(newRow)
        MessageBox.Show("Added Successfully")
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

    Private Sub deleteRowBtn_Click(sender As Object, e As EventArgs) Handles deleteRowBtn.Click
        If dataset.Tables(num).Rows.Count = 0 Then
            MessageBox.Show("No records to delete.")
            Return
        End If

        Using conn As MySqlConnection = GetConnection()

            Try
                conn.Open()
                Dim query As String = "SELECT * FROM PersonalInfo_TB"
                Dim adapter As New MySqlDataAdapter(query, conn)
                updateCommands(adapter, conn)

                Dim currentRow As DataRow = dataset.Tables(num).Rows(deleteRow)
                currentRow.Delete()
                deleteRow = dataset.Tables(num).Rows.Count - 1
                deleteRowTxtBox.Text = deleteRow + 1
                DataSetView.Rows(deleteRow).DefaultCellStyle.BackColor = Color.Yellow
                adapter.Update(dataset, dataset.Tables(num).TableName)
                MessageBox.Show($"Succesfully updated the dataset")
            Catch ex As Exception
                MessageBox.Show($"Error {ex}")
            End Try

        End Using

    End Sub
    Dim deleteRow As Integer = 0

    Private Sub rightBtnDelete_Click(sender As Object, e As EventArgs) Handles rightBtnDelete.Click
        Dim rowCount As Integer = dataset.Tables(num).Rows.Count - 1
        If deleteRow < rowCount Then
            DataSetView.Rows(deleteRow).DefaultCellStyle.BackColor = Color.White
            deleteRow += 1
            deleteRowTxtBox.Text = deleteRow + 1
            DataSetView.Rows(deleteRow).DefaultCellStyle.BackColor = Color.Yellow
        End If

    End Sub

    Private Sub leftDeleteBtn_Click(sender As Object, e As EventArgs) Handles leftDeleteBtn.Click
        Dim rowCount As Integer = dataset.Tables(num).Rows.Count - 1
        If deleteRow = 0 Then
            deleteRowTxtBox.Text = deleteRow + 1
            DataSetView.Rows(deleteRow).DefaultCellStyle.BackColor = Color.Yellow
        ElseIf deleteRow <= rowCount Then
            DataSetView.Rows(deleteRow).DefaultCellStyle.BackColor = Color.White
            deleteRow -= 1
            deleteRowTxtBox.Text = deleteRow + 1
            DataSetView.Rows(deleteRow).DefaultCellStyle.BackColor = Color.Yellow
        End If
    End Sub
End Class
