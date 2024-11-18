Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    'FOR CONNECTION OF DATABASE TO THIS PROGRAM
    Dim server As String = "localhost"
    Dim user As String = "root"
    Dim database As String = "sample"
    Dim port As Integer = 3306

    'String Interpolation
    Dim connectionString As String = $"server={server}; user={user}; database={database};port={port}"

    'FUNCTION USED TO CALL CONNECTION TO DATABASE
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Class
