<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserSettngs = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnML = New System.Windows.Forms.Button()
        Me.btnMN = New System.Windows.Forms.Button()
        Me.btnMP = New System.Windows.Forms.Button()
        Me.lblRecPointer = New System.Windows.Forms.Label()
        Me.btnMF = New System.Windows.Forms.Button()
        Me.gbProductInfo = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProdDes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdCode = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgRecords = New System.Windows.Forms.DataGridView()
        Me.pbProductPic = New System.Windows.Forms.PictureBox()
        Me.pbExit = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbProductInfo.SuspendLayout()
        CType(Me.dgRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProductPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuSave, Me.mnuCancel, Me.mnuEdit, Me.mnuDelete, Me.mnuUserSettngs})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuAdd
        '
        Me.mnuAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(180, 22)
        Me.mnuAdd.Text = "Add"
        '
        'mnuSave
        '
        Me.mnuSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(180, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuCancel
        '
        Me.mnuCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(180, 22)
        Me.mnuCancel.Text = "Cancel"
        '
        'mnuEdit
        '
        Me.mnuEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(180, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuDelete
        '
        Me.mnuDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(180, 22)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuUserSettngs
        '
        Me.mnuUserSettngs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.mnuUserSettngs.Name = "mnuUserSettngs"
        Me.mnuUserSettngs.Size = New System.Drawing.Size(180, 22)
        Me.mnuUserSettngs.Text = "User Settings"
        '
        'btnML
        '
        Me.btnML.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnML.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnML.Location = New System.Drawing.Point(726, 280)
        Me.btnML.Name = "btnML"
        Me.btnML.Size = New System.Drawing.Size(54, 27)
        Me.btnML.TabIndex = 13
        Me.btnML.Text = ">|"
        Me.btnML.UseVisualStyleBackColor = False
        '
        'btnMN
        '
        Me.btnMN.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMN.Location = New System.Drawing.Point(666, 280)
        Me.btnMN.Name = "btnMN"
        Me.btnMN.Size = New System.Drawing.Size(54, 27)
        Me.btnMN.TabIndex = 12
        Me.btnMN.Text = ">>"
        Me.btnMN.UseVisualStyleBackColor = False
        '
        'btnMP
        '
        Me.btnMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMP.Location = New System.Drawing.Point(423, 280)
        Me.btnMP.Name = "btnMP"
        Me.btnMP.Size = New System.Drawing.Size(54, 27)
        Me.btnMP.TabIndex = 11
        Me.btnMP.Text = "<<"
        Me.btnMP.UseVisualStyleBackColor = False
        '
        'lblRecPointer
        '
        Me.lblRecPointer.AutoSize = True
        Me.lblRecPointer.Location = New System.Drawing.Point(545, 287)
        Me.lblRecPointer.Name = "lblRecPointer"
        Me.lblRecPointer.Size = New System.Drawing.Size(42, 13)
        Me.lblRecPointer.TabIndex = 10
        Me.lblRecPointer.Text = "Record"
        '
        'btnMF
        '
        Me.btnMF.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMF.Location = New System.Drawing.Point(363, 280)
        Me.btnMF.Name = "btnMF"
        Me.btnMF.Size = New System.Drawing.Size(54, 27)
        Me.btnMF.TabIndex = 9
        Me.btnMF.Text = "|<"
        Me.btnMF.UseVisualStyleBackColor = False
        '
        'gbProductInfo
        '
        Me.gbProductInfo.Controls.Add(Me.Label7)
        Me.gbProductInfo.Controls.Add(Me.txtSellingPrice)
        Me.gbProductInfo.Controls.Add(Me.Label6)
        Me.gbProductInfo.Controls.Add(Me.txtUnitPrice)
        Me.gbProductInfo.Controls.Add(Me.Label5)
        Me.gbProductInfo.Controls.Add(Me.txtProdDes)
        Me.gbProductInfo.Controls.Add(Me.Label4)
        Me.gbProductInfo.Controls.Add(Me.txtProdName)
        Me.gbProductInfo.Controls.Add(Me.Label3)
        Me.gbProductInfo.Controls.Add(Me.txtQuantity)
        Me.gbProductInfo.Controls.Add(Me.Label1)
        Me.gbProductInfo.Controls.Add(Me.txtProdCode)
        Me.gbProductInfo.Location = New System.Drawing.Point(363, 313)
        Me.gbProductInfo.Name = "gbProductInfo"
        Me.gbProductInfo.Size = New System.Drawing.Size(417, 169)
        Me.gbProductInfo.TabIndex = 8
        Me.gbProductInfo.TabStop = False
        Me.gbProductInfo.Text = "Product Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Selling Price:"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Location = New System.Drawing.Point(285, 134)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtSellingPrice.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Unit Price:"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(72, 134)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitPrice.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Product Descriptrion:"
        '
        'txtProdDes
        '
        Me.txtProdDes.Location = New System.Drawing.Point(119, 97)
        Me.txtProdDes.Name = "txtProdDes"
        Me.txtProdDes.Size = New System.Drawing.Size(266, 20)
        Me.txtProdDes.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product Name:"
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(89, 60)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(296, 20)
        Me.txtProdName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(285, 26)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Code:"
        '
        'txtProdCode
        '
        Me.txtProdCode.Location = New System.Drawing.Point(89, 26)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.Size = New System.Drawing.Size(100, 20)
        Me.txtProdCode.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(12, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(223, 20)
        Me.txtSearch.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Product Name Search"
        '
        'dgRecords
        '
        Me.dgRecords.AllowUserToAddRows = False
        Me.dgRecords.AllowUserToDeleteRows = False
        Me.dgRecords.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgRecords.Location = New System.Drawing.Point(12, 55)
        Me.dgRecords.Name = "dgRecords"
        Me.dgRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRecords.Size = New System.Drawing.Size(335, 427)
        Me.dgRecords.TabIndex = 26
        '
        'pbProductPic
        '
        Me.pbProductPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.pbProductPic.Location = New System.Drawing.Point(423, 49)
        Me.pbProductPic.Name = "pbProductPic"
        Me.pbProductPic.Size = New System.Drawing.Size(297, 215)
        Me.pbProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProductPic.TabIndex = 27
        Me.pbProductPic.TabStop = False
        '
        'pbExit
        '
        Me.pbExit.Image = Global.POS_FinalProject_.My.Resources.Resources.Untitled_design
        Me.pbExit.Location = New System.Drawing.Point(749, 0)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(39, 24)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbExit.TabIndex = 15
        Me.pbExit.TabStop = False
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(788, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbProductPic)
        Me.Controls.Add(Me.dgRecords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.pbExit)
        Me.Controls.Add(Me.btnML)
        Me.Controls.Add(Me.btnMN)
        Me.Controls.Add(Me.btnMP)
        Me.Controls.Add(Me.lblRecPointer)
        Me.Controls.Add(Me.btnMF)
        Me.Controls.Add(Me.gbProductInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbProductInfo.ResumeLayout(False)
        Me.gbProductInfo.PerformLayout()
        CType(Me.dgRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProductPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAdd As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuCancel As ToolStripMenuItem
    Friend WithEvents btnML As Button
    Friend WithEvents btnMN As Button
    Friend WithEvents btnMP As Button
    Friend WithEvents lblRecPointer As Label
    Friend WithEvents btnMF As Button
    Friend WithEvents gbProductInfo As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSellingPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProdDes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProdCode As TextBox
    Friend WithEvents pbExit As PictureBox
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuUserSettngs As ToolStripMenuItem
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgRecords As DataGridView
    Friend WithEvents pbProductPic As PictureBox
End Class
