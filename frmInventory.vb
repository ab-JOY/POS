Public Class frmInventory
    Public Shared Inventory
    Dim RecPointer As Integer
    Dim PCode As String
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database_Connection()
        Call Display_Records()
        ' Call Admin_Info()
        RecPointer = 0
        mnuSave.Visible = False
        mnuCancel.Visible = False
        mnuAdd.Visible = True
        mnuEdit.Visible = True
        mnuDelete.Visible = True
        ' txtName.Enabled = False
        '  txtPosition.Enabled = False
        ' txtUserName.Text = Inventory
    End Sub

    ' Sub Admin_Info()
    'Try
    '     dbCmd.Connection = dbCon
    '      dbCmd.CommandText = "select *from tblUser where [FullName] = '" & txtName.Text & "'"
    '      dbDS = New DataSet
    '     dbAdap.SelectCommand = dbCmd
    '     dbAdap.Fill(dbDS, "tblUser")

    'Dim read As System.Data.OleDb.OleDbDataReader = dbCmd.ExecuteReader()
    'If read.HasRows Then
    'While read.Read()
    '              txtName.Text = (read("FullName"))
    '              txtPosition.Text = (read("Position"))
    'End While

    'End If
    'Catch ex As Exception
    '     MsgBox(ex.Message)

    'Finally
    '     dbCon.Close()
    'End Try
    ' End Sub
    Sub Picture()
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
    Sub Display_Records()
        Try
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblInventory"

            dbDS = New DataSet
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbDS, "tblInventory")

            dgRecords.DataSource = dbDS.Tables("tblInventory")
            txtProdCode.Text = dbDS.Tables("tblInventory").Rows(RecPointer).Item("Product Code")
            txtProdDes.Text = dbDS.Tables("tblInventory").Rows(RecPointer).Item("Product Description")
            txtProdName.Text = dbDS.Tables("tblInventory").Rows(RecPointer).Item("Product Name")
            txtQuantity.Text = dbDS.Tables("tblInventory").Rows(RecPointer).Item("Quantity")
            txtSellingPrice.Text = dbDS.Tables("tblInventory").Rows(RecPointer).Item("Selling Price")
            txtUnitPrice.Text = dbDS.Tables("tblInventory").Rows(RecPointer).Item("Unit Price")
            Call lock_textboxes()

            lblRecPointer.Text = "Record " & RecPointer + 1 & " of " & dbDS.Tables("tblInventory").Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub lock_textboxes()
        txtProdCode.Enabled = False
        txtProdDes.Enabled = False
        txtProdName.Enabled = False
        txtQuantity.Enabled = False
        txtSellingPrice.Enabled = False
        txtUnitPrice.Enabled = False
    End Sub

    Sub clear_textboxes()
        txtProdCode.Clear()
        txtProdDes.Clear()
        txtProdName.Clear()
        txtQuantity.Clear()
        txtSellingPrice.Clear()
        txtUnitPrice.Clear()
    End Sub

    Sub unlock_textboxes()
        txtProdCode.Enabled = True
        txtProdDes.Enabled = True
        txtProdName.Enabled = True
        txtQuantity.Enabled = True
        txtSellingPrice.Enabled = True
        txtUnitPrice.Enabled = True
    End Sub

    Private Sub btnMF_Click(sender As Object, e As EventArgs) Handles btnMF.Click
        RecPointer = 0
        Call Display_Records()
        Call Picture()
    End Sub

    Private Sub btnMP_Click(sender As Object, e As EventArgs) Handles btnMP.Click
        RecPointer = RecPointer - 1
        Call Display_Records()
        Call Picture()
        If RecPointer = 0 Then
            btnMP.Enabled = False

        End If

    End Sub

    Private Sub btnMN_Click(sender As Object, e As EventArgs) Handles btnMN.Click
        RecPointer = RecPointer + 1
        Call Display_Records()
        Call Picture()
        If RecPointer = dbDS.Tables("tblInventory").Rows.Count - 1 Then
            btnMN.Enabled = False

        End If
    End Sub

    Private Sub btnML_Click(sender As Object, e As EventArgs) Handles btnML.Click
        RecPointer = dbDS.Tables("tblInventory").Rows.Count - 1
        Call Display_Records()
        Call Picture()
    End Sub

    Private Sub mnuAdd_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        Call unlock_textboxes()
        Call clear_textboxes()
        dgRecords.Enabled = False
        mnuSave.Visible = True
        mnuCancel.Visible = True
        mnuAdd.Visible = False
        mnuDelete.Visible = False
        mnuEdit.Visible = False
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        dbCon.Open()
        dbCmd.Connection = dbCon

        If mnuSave.Text = "Save" Then
            If MsgBox("Do you really want to save this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Saving...") = MsgBoxResult.Yes Then
                dbCmd.CommandText = "insert into tblInventory([Product Code], [Product Name], [Product Description], [Quantity], [Unit Price], [Selling Price])values('" & txtProdCode.Text & "','" & txtProdName.Text & "','" & txtProdDes.Text & "','" & txtQuantity.Text & "','" & txtSellingPrice.Text & "','" & txtUnitPrice.Text & "')"
                dbCmd.ExecuteNonQuery()

                MsgBox("Record Successfully Saved!")

            End If
        ElseIf mnuSave.Text = "Update" Then
            If MsgBox("Do you really want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "UPDATE") = MsgBoxResult.Yes Then
                dbCmd.CommandText = "update tblInventory set [Product Code] = '" & txtProdCode.Text & "', [Product Name]= '" & txtProdName.Text & "' ,[Product Description] ='" & txtProdDes.Text & "', [Quantity]= '" & txtQuantity.Text & "',[Unit Price] = '" & txtUnitPrice.Text & "',[Seling Price] = '" & txtSellingPrice.Text & "' where [Product Code] = '" & PCode & "'"
                dbCmd.ExecuteNonQuery()

                MsgBox("Record Successfully Updated!")
                RecPointer = RecPointer + 1
            End If

        End If

        mnuAdd.Visible = False
        mnuSave.Visible = False
        mnuCancel.Visible = True
        mnuDelete.Visible = False
        mnuEdit.Visible = True

        Call Display_Records()
        Call lock_textboxes()
    End Sub

    Private Sub mnuCancel_Click(sender As Object, e As EventArgs) Handles mnuCancel.Click
        Call Display_Records()
        dgRecords.Enabled = True
        mnuAdd.Visible = False
        mnuSave.Visible = False
        mnuCancel.Visible = False
        mnuDelete.Visible = False
        mnuEdit.Visible = True

    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        If MsgBox("Do you really want to exit?", MsgBoxStyle.Question & MsgBoxStyle.YesNo, "EXIT") = MsgBoxResult.Yes Then
            Me.Hide()
            frmLogIn.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        PCode = txtProdCode.Text
        mnuSave.Text = "Update"
        Call unlock_textboxes()
        dgRecords.Enabled = False
        mnuSave.Visible = True
        mnuCancel.Visible = True
        mnuAdd.Visible = False
        mnuDelete.Visible = False
        mnuEdit.Visible = False

    End Sub
    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click

        dbCon.Open()
        dbCmd.Connection = dbCon
        Try
            If MsgBox("Do you really want to Delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
                dbCmd.CommandText = "delete from tblInventory where [Product Code]= '" & txtProdCode.Text & "'"
                dbCmd.ExecuteNonQuery()

                MsgBox("Record Successfully Deleted!")
                RecPointer = 0
                Call Display_Records()
                mnuAdd.Visible = False
                mnuSave.Visible = False
                mnuCancel.Visible = False

                mnuDelete.Visible = False
                mnuEdit.Visible = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            dbCon.Close()
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim PC As Integer
        Try
            dbCon.Open()
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblInventory where [Product Name] = '" & txtSearch.Text & "'"
            dbCmd.ExecuteNonQuery()
            dbTable = New DataTable
            dbAdap = New OleDb.OleDbDataAdapter
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbTable)
            PC = Convert.ToInt32(dbTable.Rows.Count.ToString())
            dgRecords.DataSource = dbTable
            dbCon.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRecords.CellClick
        RecPointer = e.RowIndex
        'Call Display_Records()

        txtProdCode.Text = dgRecords.Rows(e.RowIndex).Cells(0).Value.ToString
        txtProdName.Text = dgRecords.Rows(e.RowIndex).Cells(1).Value.ToString
        txtProdDes.Text = dgRecords.Rows(e.RowIndex).Cells(2).Value.ToString
        txtQuantity.Text = dgRecords.Rows(e.RowIndex).Cells(3).Value.ToString
        txtUnitPrice.Text = dgRecords.Rows(e.RowIndex).Cells(4).Value.ToString
        txtSellingPrice.Text = dgRecords.Rows(e.RowIndex).Cells(5).Value.ToString

        lblRecPointer.Text = "Record " & RecPointer + 1 & " of " & dgRecords.Rows.Count

        Call Picture()
    End Sub

    Private Sub mnuUserSettngs_Click(sender As Object, e As EventArgs) Handles mnuUserSettngs.Click
        frmAdminUser.Show()
        Me.Hide()
    End Sub


End Class
