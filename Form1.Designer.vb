<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        connectDbBtn = New Button()
        ConnectionProgressBar = New ProgressBar()
        connectionLabel = New Label()
        storeBtn = New Button()
        addTableBtn = New Button()
        addTableTextBox = New TextBox()
        Label3 = New Label()
        removeTableBtn = New Button()
        showTableBtn = New Button()
        addRowsBtn = New Button()
        leftArrowBtn = New Button()
        refreshDbBtn = New Button()
        rightArrowBtn = New Button()
        tableNoTextBox = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        updateDbBtn = New Button()
        tableNameTxtBox = New TextBox()
        tableNameTxt = New Label()
        Label1 = New Label()
        Label2 = New Label()
        DataSetView = New DataGridView()
        Label8 = New Label()
        DatabaseView = New DataGridView()
        Label7 = New Label()
        Label4 = New Label()
        deleteRowBtn = New Button()
        Label9 = New Label()
        deleteRowTxtBox = New TextBox()
        leftDeleteBtn = New Button()
        rightBtnDelete = New Button()
        CType(DataSetView, ComponentModel.ISupportInitialize).BeginInit()
        CType(DatabaseView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' connectDbBtn
        ' 
        connectDbBtn.BackColor = Color.FromArgb(CByte(170), CByte(213), CByte(118))
        connectDbBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        connectDbBtn.Location = New Point(39, 81)
        connectDbBtn.Name = "connectDbBtn"
        connectDbBtn.Size = New Size(199, 50)
        connectDbBtn.TabIndex = 0
        connectDbBtn.Text = "Connect to Database"
        connectDbBtn.UseVisualStyleBackColor = False
        ' 
        ' ConnectionProgressBar
        ' 
        ConnectionProgressBar.Location = New Point(310, 94)
        ConnectionProgressBar.Name = "ConnectionProgressBar"
        ConnectionProgressBar.Size = New Size(100, 23)
        ConnectionProgressBar.TabIndex = 1
        ' 
        ' connectionLabel
        ' 
        connectionLabel.AutoSize = True
        connectionLabel.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        connectionLabel.Location = New Point(327, 120)
        connectionLabel.Name = "connectionLabel"
        connectionLabel.Size = New Size(70, 15)
        connectionLabel.TabIndex = 2
        connectionLabel.Text = "Disconneted"
        ' 
        ' storeBtn
        ' 
        storeBtn.BackColor = Color.FromArgb(CByte(137), CByte(176), CByte(174))
        storeBtn.Enabled = False
        storeBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        storeBtn.Location = New Point(504, 81)
        storeBtn.Name = "storeBtn"
        storeBtn.Size = New Size(236, 50)
        storeBtn.TabIndex = 3
        storeBtn.Text = "Store Data in Data Set"
        storeBtn.UseVisualStyleBackColor = False
        ' 
        ' addTableBtn
        ' 
        addTableBtn.BackColor = Color.FromArgb(CByte(137), CByte(176), CByte(174))
        addTableBtn.Enabled = False
        addTableBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addTableBtn.Location = New Point(51, 204)
        addTableBtn.Name = "addTableBtn"
        addTableBtn.Size = New Size(140, 39)
        addTableBtn.TabIndex = 6
        addTableBtn.Text = "Add Table"
        addTableBtn.UseVisualStyleBackColor = False
        ' 
        ' addTableTextBox
        ' 
        addTableTextBox.Enabled = False
        addTableTextBox.Location = New Point(107, 249)
        addTableTextBox.Name = "addTableTextBox"
        addTableTextBox.Size = New Size(100, 23)
        addTableTextBox.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(585, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 18)
        Label3.TabIndex = 8
        Label3.Text = "Table Name:"
        ' 
        ' removeTableBtn
        ' 
        removeTableBtn.BackColor = Color.FromArgb(CByte(255), CByte(107), CByte(107))
        removeTableBtn.Enabled = False
        removeTableBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        removeTableBtn.Location = New Point(303, 375)
        removeTableBtn.Name = "removeTableBtn"
        removeTableBtn.Size = New Size(189, 37)
        removeTableBtn.TabIndex = 9
        removeTableBtn.Text = "Remove Table"
        removeTableBtn.UseVisualStyleBackColor = False
        ' 
        ' showTableBtn
        ' 
        showTableBtn.BackColor = Color.FromArgb(CByte(137), CByte(176), CByte(174))
        showTableBtn.Enabled = False
        showTableBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        showTableBtn.Location = New Point(782, 164)
        showTableBtn.Name = "showTableBtn"
        showTableBtn.Size = New Size(189, 34)
        showTableBtn.TabIndex = 12
        showTableBtn.Text = "Show Tubols"
        showTableBtn.UseVisualStyleBackColor = False
        ' 
        ' addRowsBtn
        ' 
        addRowsBtn.BackColor = Color.FromArgb(CByte(190), CByte(227), CByte(219))
        addRowsBtn.Enabled = False
        addRowsBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addRowsBtn.Location = New Point(69, 289)
        addRowsBtn.Name = "addRowsBtn"
        addRowsBtn.Size = New Size(105, 35)
        addRowsBtn.TabIndex = 13
        addRowsBtn.Text = "Add Rows"
        addRowsBtn.UseVisualStyleBackColor = False
        ' 
        ' leftArrowBtn
        ' 
        leftArrowBtn.Enabled = False
        leftArrowBtn.Location = New Point(330, 170)
        leftArrowBtn.Name = "leftArrowBtn"
        leftArrowBtn.Size = New Size(21, 23)
        leftArrowBtn.TabIndex = 14
        leftArrowBtn.Text = "<"
        leftArrowBtn.UseVisualStyleBackColor = True
        ' 
        ' refreshDbBtn
        ' 
        refreshDbBtn.BackColor = Color.FromArgb(CByte(190), CByte(227), CByte(219))
        refreshDbBtn.Enabled = False
        refreshDbBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        refreshDbBtn.Location = New Point(34, 496)
        refreshDbBtn.Name = "refreshDbBtn"
        refreshDbBtn.Size = New Size(175, 40)
        refreshDbBtn.TabIndex = 15
        refreshDbBtn.Text = "Refresh Database"
        refreshDbBtn.UseVisualStyleBackColor = False
        ' 
        ' rightArrowBtn
        ' 
        rightArrowBtn.Enabled = False
        rightArrowBtn.Location = New Point(389, 169)
        rightArrowBtn.Name = "rightArrowBtn"
        rightArrowBtn.Size = New Size(19, 23)
        rightArrowBtn.TabIndex = 16
        rightArrowBtn.Text = ">"
        rightArrowBtn.UseVisualStyleBackColor = True
        ' 
        ' tableNoTextBox
        ' 
        tableNoTextBox.Enabled = False
        tableNoTextBox.Location = New Point(357, 170)
        tableNoTextBox.Name = "tableNoTextBox"
        tableNoTextBox.Size = New Size(26, 23)
        tableNoTextBox.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(266, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 18)
        Label5.TabIndex = 18
        Label5.Text = "Table #"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(17, 254)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 18)
        Label6.TabIndex = 19
        Label6.Text = "Table Name:"
        ' 
        ' updateDbBtn
        ' 
        updateDbBtn.BackColor = Color.FromArgb(CByte(170), CByte(213), CByte(118))
        updateDbBtn.Enabled = False
        updateDbBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        updateDbBtn.Location = New Point(613, 370)
        updateDbBtn.Name = "updateDbBtn"
        updateDbBtn.Size = New Size(219, 47)
        updateDbBtn.TabIndex = 20
        updateDbBtn.Text = "Save Changes to Database"
        updateDbBtn.UseVisualStyleBackColor = False
        ' 
        ' tableNameTxtBox
        ' 
        tableNameTxtBox.Enabled = False
        tableNameTxtBox.Location = New Point(771, 108)
        tableNameTxtBox.Name = "tableNameTxtBox"
        tableNameTxtBox.Size = New Size(125, 23)
        tableNameTxtBox.TabIndex = 21
        ' 
        ' tableNameTxt
        ' 
        tableNameTxt.AutoSize = True
        tableNameTxt.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tableNameTxt.Location = New Point(675, 173)
        tableNameTxt.Name = "tableNameTxt"
        tableNameTxt.Size = New Size(13, 18)
        tableNameTxt.TabIndex = 23
        tableNameTxt.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(253, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(579, 45)
        Label1.TabIndex = 24
        Label1.Text = "STUDENT MANAGEMENT SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(253, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 18)
        Label2.TabIndex = 25
        Label2.Text = "Status:"
        ' 
        ' DataSetView
        ' 
        DataSetView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataSetView.Location = New Point(230, 204)
        DataSetView.Name = "DataSetView"
        DataSetView.Size = New Size(762, 150)
        DataSetView.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(504, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(150, 23)
        Label8.TabIndex = 27
        Label8.Text = "DATA SET VIEW"
        ' 
        ' DatabaseView
        ' 
        DatabaseView.AllowUserToAddRows = False
        DatabaseView.AllowUserToDeleteRows = False
        DatabaseView.AllowUserToResizeColumns = False
        DatabaseView.AllowUserToResizeRows = False
        DatabaseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DatabaseView.EditMode = DataGridViewEditMode.EditProgrammatically
        DatabaseView.Location = New Point(266, 496)
        DatabaseView.Name = "DatabaseView"
        DatabaseView.Size = New Size(709, 150)
        DatabaseView.TabIndex = 28
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(771, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 18)
        Label7.TabIndex = 29
        Label7.Text = "Data Table Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(534, 456)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 23)
        Label4.TabIndex = 30
        Label4.Text = "DATABASE VIEW"
        ' 
        ' deleteRowBtn
        ' 
        deleteRowBtn.BackColor = Color.FromArgb(CByte(255), CByte(107), CByte(107))
        deleteRowBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        deleteRowBtn.Location = New Point(51, 370)
        deleteRowBtn.Name = "deleteRowBtn"
        deleteRowBtn.Size = New Size(136, 37)
        deleteRowBtn.TabIndex = 31
        deleteRowBtn.Text = "Delete Row"
        deleteRowBtn.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(42, 416)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 18)
        Label9.TabIndex = 32
        Label9.Text = "Row #"
        ' 
        ' deleteRowTxtBox
        ' 
        deleteRowTxtBox.Location = New Point(127, 413)
        deleteRowTxtBox.Name = "deleteRowTxtBox"
        deleteRowTxtBox.Size = New Size(26, 23)
        deleteRowTxtBox.TabIndex = 35
        ' 
        ' leftDeleteBtn
        ' 
        leftDeleteBtn.Location = New Point(100, 413)
        leftDeleteBtn.Name = "leftDeleteBtn"
        leftDeleteBtn.Size = New Size(21, 23)
        leftDeleteBtn.TabIndex = 33
        leftDeleteBtn.Text = "<"
        leftDeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' rightBtnDelete
        ' 
        rightBtnDelete.Location = New Point(168, 414)
        rightBtnDelete.Name = "rightBtnDelete"
        rightBtnDelete.Size = New Size(19, 23)
        rightBtnDelete.TabIndex = 36
        rightBtnDelete.Text = ">"
        rightBtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(249))
        ClientSize = New Size(1095, 672)
        Controls.Add(rightBtnDelete)
        Controls.Add(deleteRowTxtBox)
        Controls.Add(leftDeleteBtn)
        Controls.Add(Label9)
        Controls.Add(deleteRowBtn)
        Controls.Add(Label4)
        Controls.Add(Label7)
        Controls.Add(DatabaseView)
        Controls.Add(Label8)
        Controls.Add(DataSetView)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tableNameTxt)
        Controls.Add(tableNameTxtBox)
        Controls.Add(updateDbBtn)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(tableNoTextBox)
        Controls.Add(rightArrowBtn)
        Controls.Add(refreshDbBtn)
        Controls.Add(leftArrowBtn)
        Controls.Add(addRowsBtn)
        Controls.Add(showTableBtn)
        Controls.Add(removeTableBtn)
        Controls.Add(Label3)
        Controls.Add(addTableTextBox)
        Controls.Add(addTableBtn)
        Controls.Add(storeBtn)
        Controls.Add(connectionLabel)
        Controls.Add(ConnectionProgressBar)
        Controls.Add(connectDbBtn)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataSetView, ComponentModel.ISupportInitialize).EndInit()
        CType(DatabaseView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents connectDbBtn As Button
    Friend WithEvents ConnectionProgressBar As ProgressBar
    Friend WithEvents connectionLabel As Label
    Friend WithEvents storeBtn As Button
    Friend WithEvents addTableBtn As Button
    Friend WithEvents addTableTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents removeTableBtn As Button
    Friend WithEvents showTableBtn As Button
    Friend WithEvents addRowsBtn As Button
    Friend WithEvents leftArrowBtn As Button
    Friend WithEvents refreshDbBtn As Button
    Friend WithEvents rightArrowBtn As Button
    Friend WithEvents tableNoTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents updateDbBtn As Button
    Friend WithEvents tableNameTxtBox As TextBox
    Friend WithEvents tableNameTxt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataSetView As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents DatabaseView As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents deleteRowBtn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents deleteRowTxtBox As TextBox

    Friend WithEvents leftDeleteBtn As Button
    Friend WithEvents rightBtnDelete As Button

End Class
