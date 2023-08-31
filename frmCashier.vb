Imports System.Drawing.Printing

Public Class frmCashier

    Public Shared Cashier
    Dim Ref As Integer
    Dim quantity, Price, SubTotal, Discount, Total, SellingPrice, Recieve, Change, stock As Double
    Dim Receipt As New DataTable("Table")

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database_Connection()
        Call Display()
        Call Employee_Info()
        Call Transactions()
        'Call Reference()
        cboPayMethod.Items.Add("Cash")
        cboPayMethod.Items.Add("Credit Card")
        cboPayMethod.Items.Add("Debit Card")
        Ref = 0
        SellingPrice = 0
        Price = 0
        SubTotal = 0
        Discount = 0
        Total = 0
        quantity = 0
        Change = 0
        Recieve = 0
        stock = 0
        txtRefNo.Text = Ref + 1
        txtTransactionID.Text = txtRefNo.Text & "-" & txtCurrentDate.Text
    End Sub

    Sub Reference()
        Try
            dbCon.Open()
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblSales"
            dbDS = New DataSet
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbDS, "tblSales")

            Dim reader As System.Data.OleDb.OleDbDataReader = dbCmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    txtRefNo.Text = (reader("Reference Number"))
                End While

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            dbCon.Close()
        End Try
    End Sub
    Sub Transactions()
        Receipt.Columns.Add("Product Code", Type.GetType("System.String"))
        Receipt.Columns.Add("Product Name", Type.GetType("System.String"))
        Receipt.Columns.Add("Quantity", Type.GetType("System.String"))
        Receipt.Columns.Add("Selling Price", Type.GetType("System.String"))
        Receipt.Columns.Add("Price", Type.GetType("System.String"))
        dgOrders.DataSource = Receipt
    End Sub
    Sub Display()
        Try
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblInventory"
            dbDS = New DataSet
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbDS, "tblInventory")
            dgDisplay.DataSource = dbDS.Tables("tblInventory")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Employee_Info()
        Try
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblUser"
            dbDS = New DataSet
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbDS, "tblUser")

            Dim reader As System.Data.OleDb.OleDbDataReader = dbCmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    txtEmployeeID.Text = (reader("Employee ID"))
                    txtEmployeeName.Text = (reader("FullName"))
                    txtPosition.Text = (reader("Position"))
                End While

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            dbCon.Close()
        End Try
    End Sub


    Private Sub tmrCurrentDate_Tick(sender As Object, e As EventArgs) Handles tmrCurrentDate.Tick
        txtCurrentDate.Text = Format(Date.Now, "MM- dd- yyyy")
        lblbCurrentTime.Text = Format(Date.Now, "hh:mm:ss tt")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim checker As Integer
        Try
            ' dbCon.Open()
            Call Database_Connection()
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblInventory where [Product Name] = '" & txtSearch.Text & "'"
            dbCmd.ExecuteNonQuery()
            dbTable = New DataTable
            dbAdap = New OleDb.OleDbDataAdapter
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbTable)
            checker = Convert.ToInt32(dbTable.Rows.Count.ToString())
            dgDisplay.DataSource = dbTable

            If checker = 0 Then
                txtSearch.Text = ""
            End If

            ' dbCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Search button")
            '  Finally
            ' dbCon.Close()
        End Try


    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If MsgBox("Do you really want to exit?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "EXIT") = MsgBoxResult.Yes Then
            Me.Hide()
            frmLogIn.Show()
        Else
            Me.Show()
        End If
    End Sub
    Private Sub rbGeneral_CheckedChanged(sender As Object, e As EventArgs) Handles rbGeneral.CheckedChanged
        If rbGeneral.Checked = True Then
            txtMemberName.Enabled = False
            txtMemberID.Enabled = False
        ElseIf rbMember.Checked = True Then
            txtMemberName.Enabled = True
            txtMemberID.Enabled = True
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If cboPayMethod.Text = "" Then
            MsgBox("Field Required!", MsgBoxStyle.Exclamation, "PLEASE SELECT PAYMENT METHOD")
        End If

        If cboPayMethod.Text = "Cash" Then
            If txtReceive.Text = "0" Then
                MsgBox("Field Required!", MsgBoxStyle.Exclamation, "ENTER AMOUNT RECEIVED")
                txtReceive.Focus()
            End If

        Else
            txtReceive.Enabled = False
            lblChange.Enabled = False
        End If

        If rbMember.Checked Then
            Discount = Total * 0.015
            lblDiscount.Text = Discount
        End If
        Recieve = txtReceive.Text
        Total = SubTotal - Discount
        lblTotal.Text = Total
        Change = Recieve - Total
        lblChange.Text = Change

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtProdCode.Clear()
        txtProdDes.Clear()
        txtProdName.Clear()
        lblSellingPrice.Text = "0"
        lblPrice.Text = "0"
        lblSubTotal.Text = "0"
        lblTotal.Text = "0"
        lblDiscount.Text = "0"
        txtReceive.Text = "0"
        lblChange.Text = "0"
        lblStock.Text = "0"
        lblQuantity.Text = "0"
        cboPayMethod.Text = ""
        txtSearch.Text = ""
        txtMemberID.Text = ""
        txtMemberName.Text = ""
        rbGeneral.Checked = False
        rbMember.Checked = False
        pbProductPic.Image = Nothing
        Receipt.Clear()

    End Sub

    Private Sub pbSettings_Click(sender As Object, e As EventArgs) Handles pbSettings.Click
        Me.Hide()
        frmUser.Show()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgOrders.SelectedRows.Count > 0 Then
            dgOrders.Rows.RemoveAt(dgOrders.CurrentRow.Index)
            lblSubTotal.Text = SubTotal - Price
        End If
    End Sub

    Private Sub dgOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrders.CellContentClick
        txtProdName.Text = dgOrders.Rows(e.RowIndex).Cells(1).Value.ToString
        txtProdCode.Text = dgOrders.Rows(e.RowIndex).Cells(0).Value.ToString
        lblSellingPrice.Text = dgOrders.Rows(e.RowIndex).Cells(2).Value.ToString
        lblQuantity.Text = dgOrders.Rows(e.RowIndex).Cells(3).Value.ToString
        lblPrice.Text = dgOrders.Rows(e.RowIndex).Cells(4).Value.ToString
        Call Pic()

    End Sub

    Private Sub btnAddtoCart_Click(sender As Object, e As EventArgs) Handles btnAddQty.Click
        lblQuantity.Text = lblQuantity.Text + 1
    End Sub

    Private Sub btnRemovecrt_Click(sender As Object, e As EventArgs) Handles btnRemovecrt.Click
        lblQuantity.Text = lblQuantity.Text - 1
        If lblQuantity.Text = 0 Then
            btnRemovecrt.Enabled = False
        End If
    End Sub

    Private Sub dgDisplay_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDisplay.CellClick
        lblQuantity.Text = "0"
        txtProdName.Text = dgDisplay.Rows(e.RowIndex).Cells(1).Value.ToString
        txtProdCode.Text = dgDisplay.Rows(e.RowIndex).Cells(0).Value.ToString
        txtProdDes.Text = dgDisplay.Rows(e.RowIndex).Cells(2).Value.ToString
        lblSellingPrice.Text = dgDisplay.Rows(e.RowIndex).Cells(5).Value.ToString
        lblStock.Text = dgDisplay.Rows(e.RowIndex).Cells(3).Value.ToString
        Call Pic()

    End Sub

    Sub Pic()
        If txtProdName.Text = "Lasagne" Then
            pbProductPic.Image = My.Resources.Lasagna_Transparent_Background
        ElseIf txtProdName.Text = "Mac and Cheese" Then
            pbProductPic.Image = My.Resources.mac_and_cheese_clipart
        ElseIf txtProdName.Text = "Fettuccine Alfredo" Then
            pbProductPic.Image = My.Resources.Fettuccine_Alfredo
        ElseIf txtProdName.Text = "Carbonara" Then
            pbProductPic.Image = My.Resources.Carbonara_clipart
        ElseIf txtProdName.Text = "Beef Ravioli" Then
            pbProductPic.Image = My.Resources.Beef_Ravioli_clipart
        ElseIf txtProdName.Text = "Pesto Penne" Then
            pbProductPic.Image = My.Resources.pesto_penne
        ElseIf txtProdName.Text = "Mascarpone Pesto" Then
            pbProductPic.Image = My.Resources.Mascarpone
        ElseIf txtProdName.Text = "Spaghetti Bolognese" Then
            pbProductPic.Image = My.Resources.spaghettibolognese
        ElseIf txtProdName.Text = "Beef Straganof" Then
            pbProductPic.Image = My.Resources.beef_stroganoff_
        ElseIf txtProdName.Text = "Classic Brioche" Then
            pbProductPic.Image = My.Resources.brioche
        ElseIf txtProdName.Text = "Hokkaido Loaf" Then
            pbProductPic.Image = My.Resources.hokkaido_loaf
        ElseIf txtProdName.Text = "Classic Baguette" Then
            pbProductPic.Image = My.Resources.baguette
        ElseIf txtProdName.Text = "Scallion Buns" Then
            pbProductPic.Image = My.Resources.Scallion_Bread
        ElseIf txtProdName.Text = "French Ciabatta" Then
            pbProductPic.Image = My.Resources.ciabatta
        ElseIf txtProdName.Text = "Challah Bread" Then
            pbProductPic.Image = My.Resources.Challah
        ElseIf txtProdName.Text = "Cinnamon Rolls" Then
            pbProductPic.Image = My.Resources.fluffy_cinnamon_rolls
        ElseIf txtProdName.Text = "Focaccia" Then
            pbProductPic.Image = My.Resources.Focaccia_Bread_
        ElseIf txtProdName.Text = "Espresso" Then
            pbProductPic.Image = My.Resources.espresso
        ElseIf txtProdName.Text = "Latte" Then
            pbProductPic.Image = My.Resources.Latte
        ElseIf txtProdName.Text = "Black Coffee" Then
            pbProductPic.Image = My.Resources.Black_coffee
        ElseIf txtProdName.Text = "Iced Americano" Then
            pbProductPic.Image = My.Resources.Iced_Americano
        ElseIf txtProdName.Text = "Cappuccino" Then
            pbProductPic.Image = My.Resources.Cappucino
        ElseIf txtProdName.Text = "Caramel Machiato" Then
            pbProductPic.Image = My.Resources.Caramel_Machiatto
        ElseIf txtProdName.Text = "Affogato" Then
            pbProductPic.Image = My.Resources.Affogato
        ElseIf txtProdName.Text = "Irish Coffee" Then
            pbProductPic.Image = My.Resources.Irish_Coffee
        ElseIf txtProdName.Text = "Classic Frappe" Then
            pbProductPic.Image = My.Resources.Classic_Frappe
        ElseIf txtProdName.Text = "Peppermint" Then
            pbProductPic.Image = My.Resources.peppermint
        ElseIf txtProdName.Text = "Ginger" Then
            pbProductPic.Image = My.Resources.ginger
        ElseIf txtProdName.Text = "Hibiscus" Then
            pbProductPic.Image = My.Resources.hibiscus
        ElseIf txtProdName.Text = "Jade Oolong" Then
            pbProductPic.Image = My.Resources.jade_oolong
        ElseIf txtProdName.Text = "Himalayan Green" Then
            pbProductPic.Image = My.Resources.himalayan_green
        ElseIf txtProdName.Text = "Sweet Orange Chai" Then
            pbProductPic.Image = My.Resources.sweet_orange_chai
        ElseIf txtProdName.Text = "Vanilla Rose Chai" Then
            pbProductPic.Image = My.Resources.vanilla_rose_chai
        ElseIf txtProdName.Text = "Ginger Pu-her" Then
            pbProductPic.Image = My.Resources.ginger_puehr
        ElseIf txtProdName.Text = "Coca-Cola" Then
            pbProductPic.Image = My.Resources.cocacola
        ElseIf txtProdName.Text = "Diet Coke" Then
            pbProductPic.Image = My.Resources.diet_coke
        ElseIf txtProdName.Text = "Coke Zero" Then
            pbProductPic.Image = My.Resources.coke_zero
        ElseIf txtProdName.Text = "Diet Pepsi" Then
            pbProductPic.Image = My.Resources.diet_pepsi
        ElseIf txtProdName.Text = "Sprite" Then
            pbProductPic.Image = My.Resources.sprite
        ElseIf txtProdName.Text = "Mountain Dew" Then
            pbProductPic.Image = My.Resources.mountain_dew
        ElseIf txtProdName.Text = "Royal" Then
            pbProductPic.Image = My.Resources.royal
        ElseIf txtProdName.Text = "Tropicana Sparkling" Then
            pbProductPic.Image = My.Resources.tropicana
        End If

    End Sub
    Sub Save_Transaction()
        Try
            dbCon.Open()
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "insert into tblSales([Product Code], [Product Name], [Quantity], [Price], [Total Price])values('" & txtProdCode.Text & "','" & txtProdName.Text & "','" & lblQuantity.Text & "','" & lblSellingPrice.Text & "','" & lblPrice.Text & "')"
            dbCmd.ExecuteNonQuery()
            dbDS = New DataSet
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbDS, "tblSales")


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            dbCon.Close()
        End Try
    End Sub

    Sub Stocks_Update()
        Try
            dbCon.Open()
            dbCmd = New OleDb.OleDbCommand
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "insert into tblInventory([Quantity])values('" & lblStock.Text & "')"
            dbCmd.ExecuteNonQuery()
            dbTable = New DataTable
            dbAdap = New OleDb.OleDbDataAdapter
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbTable)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAddProd_Click(sender As Object, e As EventArgs) Handles btnAddProd.Click
        Price = Convert.ToDouble(lblSellingPrice.Text) * Convert.ToDouble(lblQuantity.Text)
        lblPrice.Text = Price
        SubTotal = Convert.ToDouble(lblSubTotal.Text) + Convert.ToDouble(lblPrice.Text)
        lblSubTotal.Text = SubTotal
        Total = Convert.ToDouble(lblSubTotal.Text) - Convert.ToDouble(lblDiscount.Text)
        lblTotal.Text = Total

        Receipt.Rows.Add(txtProdCode.Text, txtProdName.Text, lblQuantity.Text, lblSellingPrice.Text, lblPrice.Text)
        dgOrders.DataSource = Receipt
        stock = Convert.ToDouble(lblStock.Text) - Convert.ToDouble(lblQuantity.Text)
        lblStock.Text = stock
        ' Call Save_Transaction()
        Call Stocks_Update()
    End Sub

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        ' pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = dgOrders.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()  'Direct Print
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "**********************************************************************************"

        e.Graphics.DrawString("The House of Carbs", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Iba, Zambales", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Tel +639123456789", f10, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString(txtTransactionID.Text, f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
        e.Graphics.DrawString(txtEmployeeName.Text, f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString(txtCurrentDate.Text & " " & lblbCurrentTime.Text, f8, Brushes.Black, 0, 95)
        'DetailHeader
        e.Graphics.DrawString("Code", f8, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Item", f8, Brushes.Black, 100, 110)
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 200, 110, right)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 300, 110, right)
        e.Graphics.DrawString("Total Price", f8, Brushes.Black, 400, 110, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        Dim height As Integer 'DGV Position
        Dim i As Long
        'If dgOrders.CurrentCell.Value Is Nothing Then
        '    Exit Sub
        'Else
        For row As Integer = 0 To dgOrders.RowCount - 1
            height += 15
            e.Graphics.DrawString(dgOrders.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 0, 115 + height)
            e.Graphics.DrawString(dgOrders.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 100, 115 + height)
            e.Graphics.DrawString(dgOrders.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 200, 115 + height)
            e.Graphics.DrawString(dgOrders.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 300, 115 + height)
            i = dgOrders.Rows(row).Cells(4).Value
            dgOrders.Rows(row).Cells(4).Value = Format(i, "##,##0")
            e.Graphics.DrawString(dgOrders.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 400, 115 + height, right)
        Next
        'End If

        Dim height2 As Integer
        height2 = 145 + height
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Sub Total: " & lblSubTotal.Text, f10b, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString("Discount: " & lblDiscount.Text, f10b, Brushes.Black, rightmargin, 30 + height2, right)
        e.Graphics.DrawString("Total: " & lblTotal.Text, f10b, Brushes.Black, rightmargin, 50 + height2, right)
        e.Graphics.DrawString("Received: " & txtReceive.Text, f10b, Brushes.Black, rightmargin, 70 + height2, right)
        e.Graphics.DrawString("Change: " & lblChange.Text, f10b, Brushes.Black, rightmargin, 90 + height2, right)

        e.Graphics.DrawString("~ Thanks for Shopping ~", f10, Brushes.Black, centermargin, 150 + height2, center)
        e.Graphics.DrawString("~ The House of Carbs ~", f10, Brushes.Black, centermargin, 165 + height2, center)
    End Sub


End Class