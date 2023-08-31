<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCashier
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pbSettings = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbProductInfo = New System.Windows.Forms.GroupBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnRemovecrt = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddQty = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProdDes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProdCode = New System.Windows.Forms.TextBox()
        Me.pbProductPic = New System.Windows.Forms.PictureBox()
        Me.dgOrders = New System.Windows.Forms.DataGridView()
        Me.gbTransactionInfo = New System.Windows.Forms.GroupBox()
        Me.lblbCurrentTime = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCurrentDate = New System.Windows.Forms.TextBox()
        Me.gbCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.rbMember = New System.Windows.Forms.RadioButton()
        Me.rbGeneral = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboPayMethod = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgDisplay = New System.Windows.Forms.DataGridView()
        Me.tmrCurrentDate = New System.Windows.Forms.Timer(Me.components)
        Me.btnAddProd = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.pbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProductInfo.SuspendLayout()
        CType(Me.pbProductPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTransactionInfo.SuspendLayout()
        Me.gbCustomerInfo.SuspendLayout()
        CType(Me.dgDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.pbSettings)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 66)
        Me.Panel1.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Location = New System.Drawing.Point(0, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 15)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "SETTINGS"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSearch.Location = New System.Drawing.Point(697, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(92, 38)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "Search Product"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(495, 21)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 20)
        Me.txtSearch.TabIndex = 21
        '
        'pbSettings
        '
        Me.pbSettings.BackColor = System.Drawing.Color.Transparent
        Me.pbSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbSettings.Image = Global.POS_FinalProject_.My.Resources.Resources.settings_4_64
        Me.pbSettings.Location = New System.Drawing.Point(0, 0)
        Me.pbSettings.Name = "pbSettings"
        Me.pbSettings.Size = New System.Drawing.Size(63, 54)
        Me.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSettings.TabIndex = 23
        Me.pbSettings.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Location = New System.Drawing.Point(181, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "The House of Carbs"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(138, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome!"
        '
        'gbProductInfo
        '
        Me.gbProductInfo.Controls.Add(Me.lblStock)
        Me.gbProductInfo.Controls.Add(Me.lblPrice)
        Me.gbProductInfo.Controls.Add(Me.lblSellingPrice)
        Me.gbProductInfo.Controls.Add(Me.lblQuantity)
        Me.gbProductInfo.Controls.Add(Me.Label27)
        Me.gbProductInfo.Controls.Add(Me.btnRemovecrt)
        Me.gbProductInfo.Controls.Add(Me.Label9)
        Me.gbProductInfo.Controls.Add(Me.btnAddQty)
        Me.gbProductInfo.Controls.Add(Me.Label8)
        Me.gbProductInfo.Controls.Add(Me.Label5)
        Me.gbProductInfo.Controls.Add(Me.txtProdDes)
        Me.gbProductInfo.Controls.Add(Me.Label4)
        Me.gbProductInfo.Controls.Add(Me.txtProdName)
        Me.gbProductInfo.Controls.Add(Me.Label6)
        Me.gbProductInfo.Controls.Add(Me.Label7)
        Me.gbProductInfo.Controls.Add(Me.txtProdCode)
        Me.gbProductInfo.Controls.Add(Me.pbProductPic)
        Me.gbProductInfo.Location = New System.Drawing.Point(9, 235)
        Me.gbProductInfo.Name = "gbProductInfo"
        Me.gbProductInfo.Size = New System.Drawing.Size(597, 150)
        Me.gbProductInfo.TabIndex = 1
        Me.gbProductInfo.TabStop = False
        Me.gbProductInfo.Text = "Product Information"
        '
        'lblStock
        '
        Me.lblStock.BackColor = System.Drawing.Color.White
        Me.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStock.Location = New System.Drawing.Point(472, 101)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(76, 23)
        Me.lblStock.TabIndex = 27
        Me.lblStock.Text = "0"
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.White
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(472, 76)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(76, 23)
        Me.lblPrice.TabIndex = 26
        Me.lblPrice.Text = "0"
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.BackColor = System.Drawing.Color.White
        Me.lblSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSellingPrice.Location = New System.Drawing.Point(472, 47)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(76, 23)
        Me.lblSellingPrice.TabIndex = 25
        Me.lblSellingPrice.Text = "0"
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.White
        Me.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuantity.Location = New System.Drawing.Point(473, 20)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(53, 23)
        Me.lblQuantity.TabIndex = 24
        Me.lblQuantity.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(406, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 13)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Total Price:"
        '
        'btnRemovecrt
        '
        Me.btnRemovecrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnRemovecrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemovecrt.Location = New System.Drawing.Point(560, 20)
        Me.btnRemovecrt.Name = "btnRemovecrt"
        Me.btnRemovecrt.Size = New System.Drawing.Size(22, 22)
        Me.btnRemovecrt.TabIndex = 21
        Me.btnRemovecrt.Text = "-"
        Me.btnRemovecrt.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(418, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Stock:"
        '
        'btnAddQty
        '
        Me.btnAddQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAddQty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddQty.Location = New System.Drawing.Point(532, 20)
        Me.btnAddQty.Name = "btnAddQty"
        Me.btnAddQty.Size = New System.Drawing.Size(22, 22)
        Me.btnAddQty.TabIndex = 18
        Me.btnAddQty.Text = "+"
        Me.btnAddQty.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(399, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Selling Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 26)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Descriptrion:"
        '
        'txtProdDes
        '
        Me.txtProdDes.Location = New System.Drawing.Point(220, 99)
        Me.txtProdDes.Name = "txtProdDes"
        Me.txtProdDes.Size = New System.Drawing.Size(168, 20)
        Me.txtProdDes.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Product Name:"
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(220, 62)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(168, 20)
        Me.txtProdName.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(418, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(141, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Product Code:"
        '
        'txtProdCode
        '
        Me.txtProdCode.Location = New System.Drawing.Point(220, 28)
        Me.txtProdCode.Name = "txtProdCode"
        Me.txtProdCode.Size = New System.Drawing.Size(168, 20)
        Me.txtProdCode.TabIndex = 8
        '
        'pbProductPic
        '
        Me.pbProductPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.pbProductPic.Location = New System.Drawing.Point(7, 20)
        Me.pbProductPic.Name = "pbProductPic"
        Me.pbProductPic.Size = New System.Drawing.Size(126, 124)
        Me.pbProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProductPic.TabIndex = 0
        Me.pbProductPic.TabStop = False
        '
        'dgOrders
        '
        Me.dgOrders.AllowUserToAddRows = False
        Me.dgOrders.AllowUserToDeleteRows = False
        Me.dgOrders.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgOrders.Location = New System.Drawing.Point(9, 404)
        Me.dgOrders.Name = "dgOrders"
        Me.dgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrders.Size = New System.Drawing.Size(346, 157)
        Me.dgOrders.TabIndex = 2
        '
        'gbTransactionInfo
        '
        Me.gbTransactionInfo.Controls.Add(Me.lblbCurrentTime)
        Me.gbTransactionInfo.Controls.Add(Me.Label20)
        Me.gbTransactionInfo.Controls.Add(Me.txtPosition)
        Me.gbTransactionInfo.Controls.Add(Me.Label19)
        Me.gbTransactionInfo.Controls.Add(Me.txtEmployeeName)
        Me.gbTransactionInfo.Controls.Add(Me.Label18)
        Me.gbTransactionInfo.Controls.Add(Me.txtEmployeeID)
        Me.gbTransactionInfo.Controls.Add(Me.Label15)
        Me.gbTransactionInfo.Controls.Add(Me.txtRefNo)
        Me.gbTransactionInfo.Controls.Add(Me.Label16)
        Me.gbTransactionInfo.Controls.Add(Me.txtTransactionID)
        Me.gbTransactionInfo.Controls.Add(Me.Label17)
        Me.gbTransactionInfo.Controls.Add(Me.txtCurrentDate)
        Me.gbTransactionInfo.Location = New System.Drawing.Point(9, 79)
        Me.gbTransactionInfo.Name = "gbTransactionInfo"
        Me.gbTransactionInfo.Size = New System.Drawing.Size(479, 150)
        Me.gbTransactionInfo.TabIndex = 3
        Me.gbTransactionInfo.TabStop = False
        Me.gbTransactionInfo.Text = "Transaction Information"
        '
        'lblbCurrentTime
        '
        Me.lblbCurrentTime.Location = New System.Drawing.Point(162, 97)
        Me.lblbCurrentTime.Name = "lblbCurrentTime"
        Me.lblbCurrentTime.Size = New System.Drawing.Size(69, 20)
        Me.lblbCurrentTime.TabIndex = 28
        Me.lblbCurrentTime.Text = "Time"
        Me.lblbCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(252, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Position:"
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(305, 97)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.ReadOnly = True
        Me.txtPosition.Size = New System.Drawing.Size(107, 20)
        Me.txtPosition.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(246, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 26)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Employee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name:"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Location = New System.Drawing.Point(305, 58)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.ReadOnly = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(168, 20)
        Me.txtEmployeeName.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(229, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Employee ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(305, 19)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(168, 20)
        Me.txtEmployeeID.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Refference No:"
        '
        'txtRefNo
        '
        Me.txtRefNo.Location = New System.Drawing.Point(97, 97)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(59, 20)
        Me.txtRefNo.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Transaction ID:"
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Location = New System.Drawing.Point(97, 58)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(128, 20)
        Me.txtTransactionID.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Current Date:"
        '
        'txtCurrentDate
        '
        Me.txtCurrentDate.Location = New System.Drawing.Point(97, 19)
        Me.txtCurrentDate.Name = "txtCurrentDate"
        Me.txtCurrentDate.ReadOnly = True
        Me.txtCurrentDate.Size = New System.Drawing.Size(128, 20)
        Me.txtCurrentDate.TabIndex = 16
        '
        'gbCustomerInfo
        '
        Me.gbCustomerInfo.Controls.Add(Me.Label23)
        Me.gbCustomerInfo.Controls.Add(Me.txtMemberID)
        Me.gbCustomerInfo.Controls.Add(Me.Label22)
        Me.gbCustomerInfo.Controls.Add(Me.txtMemberName)
        Me.gbCustomerInfo.Controls.Add(Me.rbMember)
        Me.gbCustomerInfo.Controls.Add(Me.rbGeneral)
        Me.gbCustomerInfo.Controls.Add(Me.Label21)
        Me.gbCustomerInfo.Location = New System.Drawing.Point(494, 79)
        Me.gbCustomerInfo.Name = "gbCustomerInfo"
        Me.gbCustomerInfo.Size = New System.Drawing.Size(280, 150)
        Me.gbCustomerInfo.TabIndex = 4
        Me.gbCustomerInfo.TabStop = False
        Me.gbCustomerInfo.Text = "Customer Information"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 54)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "Member ID:"
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(74, 51)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(168, 20)
        Me.txtMemberID.TabIndex = 33
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 100)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Full Name:"
        '
        'txtMemberName
        '
        Me.txtMemberName.Location = New System.Drawing.Point(74, 93)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(168, 20)
        Me.txtMemberName.TabIndex = 31
        '
        'rbMember
        '
        Me.rbMember.AutoSize = True
        Me.rbMember.Location = New System.Drawing.Point(143, 22)
        Me.rbMember.Name = "rbMember"
        Me.rbMember.Size = New System.Drawing.Size(63, 17)
        Me.rbMember.TabIndex = 30
        Me.rbMember.TabStop = True
        Me.rbMember.Text = "Member"
        Me.rbMember.UseVisualStyleBackColor = True
        '
        'rbGeneral
        '
        Me.rbGeneral.AutoSize = True
        Me.rbGeneral.Location = New System.Drawing.Point(47, 22)
        Me.rbGeneral.Name = "rbGeneral"
        Me.rbGeneral.Size = New System.Drawing.Size(62, 17)
        Me.rbGeneral.TabIndex = 29
        Me.rbGeneral.TabStop = True
        Me.rbGeneral.Text = "General"
        Me.rbGeneral.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Type:"
        '
        'cboPayMethod
        '
        Me.cboPayMethod.FormattingEnabled = True
        Me.cboPayMethod.Location = New System.Drawing.Point(678, 242)
        Me.cboPayMethod.Name = "cboPayMethod"
        Me.cboPayMethod.Size = New System.Drawing.Size(96, 21)
        Me.cboPayMethod.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(624, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Payment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Method:"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.Location = New System.Drawing.Point(627, 300)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(147, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClose.Location = New System.Drawing.Point(697, 358)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(77, 23)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(624, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "SubTotal:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(624, 417)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Discount:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(624, 443)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Total:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(624, 469)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Recieve:"
        '
        'txtReceive
        '
        Me.txtReceive.Location = New System.Drawing.Point(678, 469)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.Size = New System.Drawing.Size(96, 20)
        Me.txtReceive.TabIndex = 27
        Me.txtReceive.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(624, 495)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Change:"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Location = New System.Drawing.Point(627, 518)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(147, 37)
        Me.btnPrint.TabIndex = 31
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'dgDisplay
        '
        Me.dgDisplay.AllowUserToAddRows = False
        Me.dgDisplay.AllowUserToDeleteRows = False
        Me.dgDisplay.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.dgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDisplay.Location = New System.Drawing.Point(361, 404)
        Me.dgDisplay.Name = "dgDisplay"
        Me.dgDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDisplay.Size = New System.Drawing.Size(242, 157)
        Me.dgDisplay.TabIndex = 32
        '
        'tmrCurrentDate
        '
        Me.tmrCurrentDate.Enabled = True
        Me.tmrCurrentDate.Interval = 1000
        '
        'btnAddProd
        '
        Me.btnAddProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddProd.Location = New System.Drawing.Point(627, 271)
        Me.btnAddProd.Name = "btnAddProd"
        Me.btnAddProd.Size = New System.Drawing.Size(147, 23)
        Me.btnAddProd.TabIndex = 33
        Me.btnAddProd.Text = "ADD"
        Me.btnAddProd.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 388)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 13)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "TRANSACTION"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(358, 388)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 13)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "PRODUCTS"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.White
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.Location = New System.Drawing.Point(678, 390)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(96, 23)
        Me.lblSubTotal.TabIndex = 36
        Me.lblSubTotal.Text = "0"
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.White
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(678, 416)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(96, 23)
        Me.lblDiscount.TabIndex = 37
        Me.lblDiscount.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(678, 442)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(96, 23)
        Me.lblTotal.TabIndex = 38
        Me.lblTotal.Text = "0"
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.White
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Location = New System.Drawing.Point(678, 492)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(96, 23)
        Me.lblChange.TabIndex = 39
        Me.lblChange.Text = "0"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Location = New System.Drawing.Point(627, 329)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(147, 23)
        Me.btnCalculate.TabIndex = 40
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Location = New System.Drawing.Point(627, 358)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(64, 23)
        Me.btnNew.TabIndex = 41
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'frmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.btnAddProd)
        Me.Controls.Add(Me.dgDisplay)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPayMethod)
        Me.Controls.Add(Me.gbCustomerInfo)
        Me.Controls.Add(Me.gbTransactionInfo)
        Me.Controls.Add(Me.dgOrders)
        Me.Controls.Add(Me.gbProductInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProductInfo.ResumeLayout(False)
        Me.gbProductInfo.PerformLayout()
        CType(Me.pbProductPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTransactionInfo.ResumeLayout(False)
        Me.gbTransactionInfo.PerformLayout()
        Me.gbCustomerInfo.ResumeLayout(False)
        Me.gbCustomerInfo.PerformLayout()
        CType(Me.dgDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents gbProductInfo As GroupBox
    Friend WithEvents dgOrders As DataGridView
    Friend WithEvents pbProductPic As PictureBox
    Friend WithEvents gbTransactionInfo As GroupBox
    Friend WithEvents gbCustomerInfo As GroupBox
    Friend WithEvents cboPayMethod As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProdDes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProdCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddQty As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTransactionID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCurrentDate As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtMemberName As TextBox
    Friend WithEvents rbMember As RadioButton
    Friend WithEvents rbGeneral As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtReceive As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents dgDisplay As DataGridView
    Friend WithEvents tmrCurrentDate As Timer
    Friend WithEvents lblbCurrentTime As Label
    Friend WithEvents btnRemovecrt As Button
    Friend WithEvents btnAddProd As Button
    Friend WithEvents pbSettings As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblSellingPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
