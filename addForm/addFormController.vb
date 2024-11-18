Public Class addFormController
    Public view As addForm
    Private _form As Form1

    ' Constructor to accept an instance of Form1
    Public Sub New(instance As Form1)
        _form = instance
    End Sub


    Public Sub AddStudent(ds As DataSet,
                          dt As DataTable,
                          firstname As String,
                          lastname As String,
                          contact As Integer,
                          email As String,
                          sex As String)
        Dim model As New AddFormModel(_form) With {
            .firstname = firstname,
            .lastname = lastname,
            .email = email,
            .contact = contact,
            .sex = sex
        }
        model.addStudent(ds, dt)
    End Sub
End Class
