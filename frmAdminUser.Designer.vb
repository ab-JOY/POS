<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminUser
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
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDNo = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPostiton = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.dgDisplay = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbExit = New System.Windows.Forms.PictureBox()
        Me.pbProfile = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuSettings
        '
        Me.mnuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddUser, Me.mnuEditUser, Me.mnuDeleteUser})
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnuSettings.Text = "Settings"
        '
        'mnuAddUser
        '
        Me.mnuAddUser.Name = "mnuAddUser"
        Me.mnuAddUser.Size = New System.Drawing.Size(149, 22)
        Me.mnuAddUser.Text = "Add New User"
        '
        'mnuEditUser
        '
        Me.mnuEditUser.Name = "mnuEditUser"
        Me.mnuEditUser.Size = New System.Drawing.Size(149, 22)
        Me.mnuEditUser.Text = "Edit"
        '
        'mnuDeleteUser
        '
        Me.mnuDeleteUser.Name = "mnuDeleteUser"
        Me.mnuDeleteUser.Size = New System.Drawing.Size(149, 22)
        Me.mnuDeleteUser.Text = "Delete User"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSettings})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Number:"
        '
        'txtIDNo
        '
        Me.txtIDNo.Location = New System.Drawing.Point(120, 205)
        Me.txtIDNo.Name = "txtIDNo"
        Me.txtIDNo.Size = New System.Drawing.Size(215, 20)
        Me.txtIDNo.TabIndex = 2
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(120, 242)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(215, 20)
        Me.txtFullName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FullName:"
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(120, 283)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(215, 20)
        Me.txtBirthday.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Date of Birth:"
        '
        'txtPostiton
        '
        Me.txtPostiton.Location = New System.Drawing.Point(120, 323)
        Me.txtPostiton.Name = "txtPostiton"
        Me.txtPostiton.Size = New System.Drawing.Size(215, 20)
        Me.txtPostiton.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Position:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(120, 116)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(215, 20)
        Me.txtUsername.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Username:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Contact No:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(120, 172)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(215, 20)
        Me.txtContact.TabIndex = 13
        '
        'dgDisplay
        '
        Me.dgDisplay.AllowUserToAddRows = False
        Me.dgDisplay.AllowUserToDeleteRows = False
        Me.dgDisplay.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDisplay.Location = New System.Drawing.Point(350, 60)
        Me.dgDisplay.Name = "dgDisplay"
        Me.dgDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDisplay.Size = New System.Drawing.Size(319, 293)
        Me.dgDisplay.TabIndex = 33
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(350, 367)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(147, 23)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(522, 367)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 23)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(435, 34)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(234, 20)
        Me.txtSearch.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(347, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 23)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Search"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(120, 142)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(215, 20)
        Me.txtPassword.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 23)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Password:"
        '
        'pbExit
        '
        Me.pbExit.Image = Global.POS_FinalProject_.My.Resources.Resources.Untitled_design
        Me.pbExit.Location = New System.Drawing.Point(667, -3)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(35, 27)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbExit.TabIndex = 43
        Me.pbExit.TabStop = False
        '
        'pbProfile
        '
        Me.pbProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.pbProfile.Image = Global.POS_FinalProject_.My.Resources.Resources.user_64__1_
        Me.pbProfile.Location = New System.Drawing.Point(159, 27)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(64, 64)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbProfile.TabIndex = 3
        Me.pbProfile.TabStop = False
        '
        'frmAdminUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(702, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pbExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgDisplay)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPostiton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbProfile)
        Me.Controls.Add(Me.txtIDNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdminUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuSettings As ToolStripMenuItem
    Friend WithEvents mnuAddUser As ToolStripMenuItem
    Friend WithEvents mnuEditUser As ToolStripMenuItem
    Friend WithEvents mnuDeleteUser As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDNo As TextBox
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPostiton As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents dgDisplay As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents pbExit As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label8 As Label
End Class
