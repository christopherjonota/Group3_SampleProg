﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        addBtn = New Button()
        Button2 = New Button()
        cancelBtn = New Button()
        firstnameTxt = New TextBox()
        lastnameTxt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        contactTxt = New TextBox()
        emailTxt = New TextBox()
        contactCb = New ComboBox()
        Label5 = New Label()
        sexCb = New ComboBox()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' addBtn
        ' 
        addBtn.Location = New Point(132, 355)
        addBtn.Margin = New Padding(4)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(108, 36)
        addBtn.TabIndex = 0
        addBtn.Text = "Add"
        addBtn.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(457, 378)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(11, 13)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' cancelBtn
        ' 
        cancelBtn.Location = New Point(420, 355)
        cancelBtn.Margin = New Padding(4)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(108, 36)
        cancelBtn.TabIndex = 2
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = True
        ' 
        ' firstnameTxt
        ' 
        firstnameTxt.Location = New Point(60, 17)
        firstnameTxt.Margin = New Padding(4)
        firstnameTxt.Name = "firstnameTxt"
        firstnameTxt.Size = New Size(198, 30)
        firstnameTxt.TabIndex = 4
        ' 
        ' lastnameTxt
        ' 
        lastnameTxt.Location = New Point(60, 85)
        lastnameTxt.Margin = New Padding(4)
        lastnameTxt.Name = "lastnameTxt"
        lastnameTxt.Size = New Size(198, 30)
        lastnameTxt.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(132, 45)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 23)
        Label1.TabIndex = 6
        Label1.Text = "Firstname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(132, 113)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 23)
        Label2.TabIndex = 7
        Label2.Text = "Lastname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(132, 176)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 23)
        Label3.TabIndex = 8
        Label3.Text = "Contact"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(132, 237)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 23)
        Label4.TabIndex = 9
        Label4.Text = "Email"
        ' 
        ' contactTxt
        ' 
        contactTxt.Location = New Point(116, 145)
        contactTxt.Margin = New Padding(4)
        contactTxt.Name = "contactTxt"
        contactTxt.Size = New Size(142, 30)
        contactTxt.TabIndex = 10
        ' 
        ' emailTxt
        ' 
        emailTxt.Location = New Point(60, 209)
        emailTxt.Margin = New Padding(4)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(198, 30)
        emailTxt.TabIndex = 11
        ' 
        ' contactCb
        ' 
        contactCb.Enabled = False
        contactCb.FormattingEnabled = True
        contactCb.Items.AddRange(New Object() {"+63"})
        contactCb.Location = New Point(60, 145)
        contactCb.Name = "contactCb"
        contactCb.Size = New Size(49, 31)
        contactCb.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(132, 292)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 23)
        Label5.TabIndex = 13
        Label5.Text = "Sex"
        ' 
        ' sexCb
        ' 
        sexCb.FormattingEnabled = True
        sexCb.Items.AddRange(New Object() {"Male", "Female"})
        sexCb.Location = New Point(60, 261)
        sexCb.Name = "sexCb"
        sexCb.Size = New Size(121, 31)
        sexCb.TabIndex = 14
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(firstnameTxt)
        Panel1.Controls.Add(sexCb)
        Panel1.Controls.Add(lastnameTxt)
        Panel1.Controls.Add(contactTxt)
        Panel1.Controls.Add(contactCb)
        Panel1.Controls.Add(emailTxt)
        Panel1.Location = New Point(234, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(329, 327)
        Panel1.TabIndex = 15
        ' 
        ' addForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(670, 423)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cancelBtn)
        Controls.Add(Button2)
        Controls.Add(addBtn)
        Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "addForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents firstnameTxt As TextBox
    Friend WithEvents lastnameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents contactTxt As TextBox
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents contactCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sexCb As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
