Imports Google.Protobuf.WellKnownTypes

Public Class addForm

    Private _form As Form1

    ' Constructor to accept an instance of ClassA

    Public Sub New(instance As Form1)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _form = instance
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contactCb.SelectedItem = contactCb.Items(0)
        sexCb.SelectedItem = sexCb.Items()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub


    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim controller As New addFormController(_form)
        For Each obj In Panel1.Controls
            If TypeOf obj Is TextBox Then
                If String.IsNullOrEmpty(obj.Text) Then
                    MessageBox.Show("Please Fill out all Fields")
                    Return
                End If
            End If
        Next
        controller.AddStudent(_form.dataset, _form.dataset.Tables(0), firstnameTxt.Text, lastnameTxt.Text, contactTxt.Text, emailTxt.Text, sexCb.SelectedValue)
            MessageBox.Show("Added Successfully")
        Me.Close()
    End Sub
End Class