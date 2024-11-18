Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class AddFormModel
    Private _form As Form1

    ' Constructor to accept an instance of ClassA
    Public Sub New(instance As Form)
        _form = instance
    End Sub
    Public Property firstname As String
    Public Property lastname As String
    Public Property email As String
    Public Property contact As Integer
    Public Property sex As String

    Private dbConnection As DatabaseConnection

    Public Sub addStudent(ds As DataSet, tb As DataTable)
        ' Create a new row
        Dim newRow As DataRow = tb.NewRow()

        ' Populate row using column indexes
        newRow(1) = firstname    ' Column index 1 corresponds to "FirstName"
        newRow(2) = lastname     ' Column index 2 corresponds to "LastName"
        newRow(3) = contact
        newRow(4) = email
        newRow(5) = sex

        ' Add the row to the DataTable
        tb.Rows.Add(newRow)

        ' ----------------- SLIDE 10 ----------------------
        ' AcceptChanges() is not called because it will not be reflected to the database
        'newRow.AcceptChanges()

        _form.updateDatabase()
    End Sub
End Class
