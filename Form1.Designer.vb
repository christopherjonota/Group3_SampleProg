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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        addTableBtn = New Button()
        addTableTextBox = New TextBox()
        Label3 = New Label()
        btnRemoveTable = New Button()
        ImageList1 = New ImageList(components)
        btnAdd = New Button()
        btnTableLeft = New Button()
        refreshDbBtn = New Button()
        btnTableRight = New Button()
        tablePointerTxtBox = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        tableNameTxtBox = New TextBox()
        lblTableName = New Label()
        Label1 = New Label()
        Label7 = New Label()
        btnDelete = New Button()
        Label9 = New Label()
        RowPointerTxt = New TextBox()
        btnRowLeft = New Button()
        btnRowRight = New Button()
        Panel1 = New Panel()
        Label4 = New Label()
        Panel3 = New Panel()
        GroupBox1 = New GroupBox()
        btnConnect = New Button()
        ConnectionProgressBar = New ProgressBar()
        Label2 = New Label()
        connectionLabel = New Label()
        DataEntryPanel = New Panel()
        btnEdit = New Button()
        DataSetView = New DataGridView()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox1.SuspendLayout()
        DataEntryPanel.SuspendLayout()
        CType(DataSetView, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' addTableBtn
        ' 
        addTableBtn.BackColor = Color.FromArgb(CByte(137), CByte(176), CByte(174))
        addTableBtn.Enabled = False
        addTableBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addTableBtn.Location = New Point(28, 21)
        addTableBtn.Name = "addTableBtn"
        addTableBtn.Size = New Size(140, 39)
        addTableBtn.TabIndex = 6
        addTableBtn.Text = "Add Table"
        addTableBtn.UseVisualStyleBackColor = False
        ' 
        ' addTableTextBox
        ' 
        addTableTextBox.Enabled = False
        addTableTextBox.Location = New Point(199, 37)
        addTableTextBox.Name = "addTableTextBox"
        addTableTextBox.Size = New Size(100, 23)
        addTableTextBox.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(389, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 18)
        Label3.TabIndex = 8
        Label3.Text = "Table Name:"
        ' 
        ' btnRemoveTable
        ' 
        btnRemoveTable.BackColor = Color.Transparent
        btnRemoveTable.Enabled = False
        btnRemoveTable.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRemoveTable.ImageIndex = 5
        btnRemoveTable.ImageList = ImageList1
        btnRemoveTable.Location = New Point(931, 10)
        btnRemoveTable.Name = "btnRemoveTable"
        btnRemoveTable.Size = New Size(152, 37)
        btnRemoveTable.TabIndex = 9
        btnRemoveTable.Text = "Remove Table"
        btnRemoveTable.TextAlign = ContentAlignment.MiddleRight
        btnRemoveTable.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRemoveTable.UseVisualStyleBackColor = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "no-connection.png")
        ImageList1.Images.SetKeyName(1, "")
        ImageList1.Images.SetKeyName(2, "save.png")
        ImageList1.Images.SetKeyName(3, "edit.png")
        ImageList1.Images.SetKeyName(4, "add-file.png")
        ImageList1.Images.SetKeyName(5, "trash.png")
        ImageList1.Images.SetKeyName(6, "close.png")
        ImageList1.Images.SetKeyName(7, "refresh (1).png")
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Transparent
        btnAdd.Enabled = False
        btnAdd.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.ImageAlign = ContentAlignment.MiddleRight
        btnAdd.ImageIndex = 4
        btnAdd.ImageList = ImageList1
        btnAdd.Location = New Point(42, 11)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(100, 35)
        btnAdd.TabIndex = 13
        btnAdd.Text = "Add"
        btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnTableLeft
        ' 
        btnTableLeft.Enabled = False
        btnTableLeft.Location = New Point(292, 20)
        btnTableLeft.Name = "btnTableLeft"
        btnTableLeft.Size = New Size(21, 23)
        btnTableLeft.TabIndex = 14
        btnTableLeft.Text = "<"
        btnTableLeft.UseVisualStyleBackColor = True
        ' 
        ' refreshDbBtn
        ' 
        refreshDbBtn.BackColor = Color.Transparent
        refreshDbBtn.Enabled = False
        refreshDbBtn.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        refreshDbBtn.ImageIndex = 7
        refreshDbBtn.ImageList = ImageList1
        refreshDbBtn.Location = New Point(831, 9)
        refreshDbBtn.Name = "refreshDbBtn"
        refreshDbBtn.Size = New Size(94, 40)
        refreshDbBtn.TabIndex = 15
        refreshDbBtn.Text = "Refresh"
        refreshDbBtn.TextAlign = ContentAlignment.MiddleRight
        refreshDbBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        refreshDbBtn.UseVisualStyleBackColor = False
        ' 
        ' btnTableRight
        ' 
        btnTableRight.Enabled = False
        btnTableRight.Location = New Point(351, 19)
        btnTableRight.Name = "btnTableRight"
        btnTableRight.Size = New Size(19, 23)
        btnTableRight.TabIndex = 16
        btnTableRight.Text = ">"
        btnTableRight.UseVisualStyleBackColor = True
        ' 
        ' tablePointerTxtBox
        ' 
        tablePointerTxtBox.Enabled = False
        tablePointerTxtBox.Location = New Point(319, 20)
        tablePointerTxtBox.Name = "tablePointerTxtBox"
        tablePointerTxtBox.ReadOnly = True
        tablePointerTxtBox.Size = New Size(26, 23)
        tablePointerTxtBox.TabIndex = 17
        tablePointerTxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(228, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 18)
        Label5.TabIndex = 18
        Label5.Text = "Table #"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(205, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 18)
        Label6.TabIndex = 19
        Label6.Text = "Table Name:"
        ' 
        ' tableNameTxtBox
        ' 
        tableNameTxtBox.Enabled = False
        tableNameTxtBox.Location = New Point(998, 467)
        tableNameTxtBox.Name = "tableNameTxtBox"
        tableNameTxtBox.Size = New Size(125, 23)
        tableNameTxtBox.TabIndex = 21
        ' 
        ' lblTableName
        ' 
        lblTableName.AutoSize = True
        lblTableName.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTableName.Location = New Point(479, 20)
        lblTableName.Name = "lblTableName"
        lblTableName.Size = New Size(13, 18)
        lblTableName.TabIndex = 23
        lblTableName.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(330, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(579, 45)
        Label1.TabIndex = 24
        Label1.Text = "STUDENT MANAGEMENT SYSTEM"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(1023, 435)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 18)
        Label7.TabIndex = 29
        Label7.Text = "Data Table Name:"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Transparent
        btnDelete.Enabled = False
        btnDelete.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.ImageIndex = 5
        btnDelete.ImageList = ImageList1
        btnDelete.Location = New Point(168, 11)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 35)
        btnDelete.TabIndex = 31
        btnDelete.Text = "Delete"
        btnDelete.TextAlign = ContentAlignment.MiddleRight
        btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(19, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(48, 18)
        Label9.TabIndex = 32
        Label9.Text = "Row #"
        ' 
        ' RowPointerTxt
        ' 
        RowPointerTxt.Enabled = False
        RowPointerTxt.Location = New Point(104, 17)
        RowPointerTxt.Name = "RowPointerTxt"
        RowPointerTxt.ReadOnly = True
        RowPointerTxt.Size = New Size(26, 23)
        RowPointerTxt.TabIndex = 35
        RowPointerTxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnRowLeft
        ' 
        btnRowLeft.Enabled = False
        btnRowLeft.Location = New Point(77, 17)
        btnRowLeft.Name = "btnRowLeft"
        btnRowLeft.Size = New Size(21, 23)
        btnRowLeft.TabIndex = 33
        btnRowLeft.TabStop = False
        btnRowLeft.Text = "<"
        btnRowLeft.UseVisualStyleBackColor = True
        ' 
        ' btnRowRight
        ' 
        btnRowRight.Enabled = False
        btnRowRight.Location = New Point(136, 18)
        btnRowRight.Name = "btnRowRight"
        btnRowRight.Size = New Size(19, 23)
        btnRowRight.TabIndex = 36
        btnRowRight.TabStop = False
        btnRowRight.Text = ">"
        btnRowRight.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1095, 59)
        Panel1.TabIndex = 37
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(479, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 23)
        Label4.TabIndex = 30
        Label4.Text = "DATABASE VIEW"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightBlue
        Panel3.Controls.Add(GroupBox1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 494)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1095, 80)
        Panel3.TabIndex = 37
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnConnect)
        GroupBox1.Controls.Add(ConnectionProgressBar)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(connectionLabel)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(0)
        GroupBox1.Size = New Size(1095, 80)
        GroupBox1.TabIndex = 30
        GroupBox1.TabStop = False
        GroupBox1.Text = "Database Connection"
        ' 
        ' btnConnect
        ' 
        btnConnect.BackColor = Color.FromArgb(CByte(170), CByte(213), CByte(118))
        btnConnect.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnConnect.ImageIndex = 1
        btnConnect.ImageList = ImageList1
        btnConnect.Location = New Point(42, 25)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(111, 50)
        btnConnect.TabIndex = 0
        btnConnect.Text = "Connect"
        btnConnect.TextAlign = ContentAlignment.MiddleRight
        btnConnect.TextImageRelation = TextImageRelation.ImageBeforeText
        btnConnect.UseVisualStyleBackColor = False
        ' 
        ' ConnectionProgressBar
        ' 
        ConnectionProgressBar.Location = New Point(285, 30)
        ConnectionProgressBar.Name = "ConnectionProgressBar"
        ConnectionProgressBar.Size = New Size(100, 23)
        ConnectionProgressBar.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(192, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 18)
        Label2.TabIndex = 25
        Label2.Text = "Status:"
        ' 
        ' connectionLabel
        ' 
        connectionLabel.AutoSize = True
        connectionLabel.Font = New Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        connectionLabel.Location = New Point(297, 56)
        connectionLabel.Name = "connectionLabel"
        connectionLabel.Size = New Size(70, 15)
        connectionLabel.TabIndex = 2
        connectionLabel.Text = "Disconneted"
        ' 
        ' DataEntryPanel
        ' 
        DataEntryPanel.BackColor = Color.LightSteelBlue
        DataEntryPanel.BackgroundImageLayout = ImageLayout.None
        DataEntryPanel.Controls.Add(btnEdit)
        DataEntryPanel.Controls.Add(btnAdd)
        DataEntryPanel.Controls.Add(btnDelete)
        DataEntryPanel.Dock = DockStyle.Bottom
        DataEntryPanel.Location = New Point(0, 442)
        DataEntryPanel.Name = "DataEntryPanel"
        DataEntryPanel.Size = New Size(1095, 52)
        DataEntryPanel.TabIndex = 38
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Transparent
        btnEdit.Enabled = False
        btnEdit.Font = New Font("Comic Sans MS", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.ImageIndex = 3
        btnEdit.ImageList = ImageList1
        btnEdit.Location = New Point(297, 11)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(100, 35)
        btnEdit.TabIndex = 32
        btnEdit.Text = "Edit"
        btnEdit.TextAlign = ContentAlignment.MiddleRight
        btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' DataSetView
        ' 
        DataSetView.AllowUserToAddRows = False
        DataSetView.AllowUserToDeleteRows = False
        DataSetView.AllowUserToResizeColumns = False
        DataSetView.AllowUserToResizeRows = False
        DataSetView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataSetView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataSetView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataSetView.Dock = DockStyle.Bottom
        DataSetView.EditMode = DataGridViewEditMode.EditProgrammatically
        DataSetView.Location = New Point(0, 220)
        DataSetView.MultiSelect = False
        DataSetView.Name = "DataSetView"
        DataSetView.ReadOnly = True
        DataSetView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataSetView.Size = New Size(1095, 222)
        DataSetView.TabIndex = 39
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(btnRowLeft)
        Panel2.Controls.Add(RowPointerTxt)
        Panel2.Controls.Add(btnRowRight)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(btnTableLeft)
        Panel2.Controls.Add(btnTableRight)
        Panel2.Controls.Add(tablePointerTxtBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(lblTableName)
        Panel2.Controls.Add(refreshDbBtn)
        Panel2.Controls.Add(btnRemoveTable)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 157)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1095, 63)
        Panel2.TabIndex = 40
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(addTableTextBox)
        Panel4.Controls.Add(addTableBtn)
        Panel4.Controls.Add(Label6)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 85)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1095, 72)
        Panel4.TabIndex = 41
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(249))
        ClientSize = New Size(1095, 574)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(DataSetView)
        Controls.Add(DataEntryPanel)
        Controls.Add(Panel3)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Controls.Add(tableNameTxtBox)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        DataEntryPanel.ResumeLayout(False)
        CType(DataSetView, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents addTableBtn As Button
    Friend WithEvents addTableTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemoveTable As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnTableLeft As Button
    Friend WithEvents refreshDbBtn As Button
    Friend WithEvents btnTableRight As Button
    Friend WithEvents tablePointerTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tableNameTxtBox As TextBox
    Friend WithEvents lblTableName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents RowPointerTxt As TextBox

    Friend WithEvents btnRowLeft As Button
    Friend WithEvents btnRowRight As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnConnect As Button
    Friend WithEvents ConnectionProgressBar As ProgressBar
    Friend WithEvents connectionLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataEntryPanel As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnEdit As Button
    Friend WithEvents DataSetView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel

End Class
