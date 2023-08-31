<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogIn
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
        Me.pbCloseApp = New System.Windows.Forms.PictureBox()
        Me.pbLogIn = New System.Windows.Forms.PictureBox()
        Me.pbUsername = New System.Windows.Forms.PictureBox()
        Me.pbPassword = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblShowPassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        CType(Me.pbCloseApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbCloseApp
        '
        Me.pbCloseApp.Image = Global.POS_FinalProject_.My.Resources.Resources.Untitled_design
        Me.pbCloseApp.Location = New System.Drawing.Point(763, -2)
        Me.pbCloseApp.Name = "pbCloseApp"
        Me.pbCloseApp.Size = New System.Drawing.Size(39, 24)
        Me.pbCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCloseApp.TabIndex = 16
        Me.pbCloseApp.TabStop = False
        '
        'pbLogIn
        '
        Me.pbLogIn.BackColor = System.Drawing.Color.Transparent
        Me.pbLogIn.Location = New System.Drawing.Point(288, 364)
        Me.pbLogIn.Name = "pbLogIn"
        Me.pbLogIn.Size = New System.Drawing.Size(230, 39)
        Me.pbLogIn.TabIndex = 17
        Me.pbLogIn.TabStop = False
        '
        'pbUsername
        '
        Me.pbUsername.BackColor = System.Drawing.Color.Transparent
        Me.pbUsername.Location = New System.Drawing.Point(304, 202)
        Me.pbUsername.Name = "pbUsername"
        Me.pbUsername.Size = New System.Drawing.Size(230, 28)
        Me.pbUsername.TabIndex = 18
        Me.pbUsername.TabStop = False
        '
        'pbPassword
        '
        Me.pbPassword.BackColor = System.Drawing.Color.Transparent
        Me.pbPassword.Location = New System.Drawing.Point(304, 267)
        Me.pbPassword.Name = "pbPassword"
        Me.pbPassword.Size = New System.Drawing.Size(230, 28)
        Me.pbPassword.TabIndex = 19
        Me.pbPassword.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.MistyRose
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(304, 267)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(199, 28)
        Me.txtPassword.TabIndex = 21
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblShowPassword
        '
        Me.lblShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblShowPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowPassword.Location = New System.Drawing.Point(498, 267)
        Me.lblShowPassword.Name = "lblShowPassword"
        Me.lblShowPassword.Size = New System.Drawing.Size(36, 34)
        Me.lblShowPassword.TabIndex = 22
        Me.lblShowPassword.Text = "Show"
        Me.lblShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.MistyRose
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(304, 202)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(199, 28)
        Me.txtUserName.TabIndex = 23
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.POS_FinalProject_.My.Resources.Resources.login_ui
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblShowPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.pbPassword)
        Me.Controls.Add(Me.pbUsername)
        Me.Controls.Add(Me.pbLogIn)
        Me.Controls.Add(Me.pbCloseApp)
        Me.DoubleBuffered = True
        Me.Name = "frmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pbCloseApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbCloseApp As PictureBox
    Friend WithEvents pbLogIn As PictureBox
    Friend WithEvents pbUsername As PictureBox
    Friend WithEvents pbPassword As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblShowPassword As Label
    Friend WithEvents txtUserName As TextBox
End Class
