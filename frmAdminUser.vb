Public Class frmAdminUser
    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        frmInventory.Show()
        Me.Close()
    End Sub

    Private Sub frmAdminUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database_Connection()
        Call User_List()
        Call lock_textbox()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        dbCon.Close()
    End Sub

    Sub User_List()
        Try
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblUser"
            dbDS = New DataSet
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbDS, "tblUser")
            dgDisplay.DataSource = dbDS.Tables("tblUser")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgDisplay_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDisplay.CellClick
        txtUsername.Text = dgDisplay.Rows(e.RowIndex).Cells(0).Value.ToString
        txtPassword.Text = dgDisplay.Rows(e.RowIndex).Cells(1).Value.ToString
        txtContact.Text = dgDisplay.Rows(e.RowIndex).Cells(6).Value.ToString
        txtFullName.Text = dgDisplay.Rows(e.RowIndex).Cells(2).Value.ToString
        txtIDNo.Text = dgDisplay.Rows(e.RowIndex).Cells(3).Value.ToString
        txtBirthday.Text = dgDisplay.Rows(e.RowIndex).Cells(5).Value.ToString
        txtPostiton.Text = dgDisplay.Rows(e.RowIndex).Cells(4).Value.ToString
    End Sub

    Sub lock_textbox()
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtFullName.Enabled = False
        txtContact.Enabled = False
        txtIDNo.Enabled = False
        txtBirthday.Enabled = False
        txtPostiton.Enabled = False
    End Sub

    Sub unlock_textbox()
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtFullName.Enabled = True
        txtContact.Enabled = True
        txtIDNo.Enabled = True
        txtBirthday.Enabled = True
        txtPostiton.Enabled = True
    End Sub

    Sub clear_textbox()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtFullName.Text = ""
        txtContact.Text = ""
        txtIDNo.Text = ""
        txtBirthday.Text = ""
        txtPostiton.Text = ""
    End Sub

    Private Sub mnuAddUser_Click(sender As Object, e As EventArgs) Handles mnuAddUser.Click
        Call unlock_textbox()
        Call clear_textbox()
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub mnuEditUser_Click(sender As Object, e As EventArgs) Handles mnuEditUser.Click
        Call unlock_textbox()
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dbCon.Open()
        dbCmd.Connection = dbCon

        If MsgBox("Do you really want to save this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Saving...") = MsgBoxResult.Yes Then
            dbCmd.CommandText = "insert into tblUser([UserName], [Password], [FullName], [Contact No], [Employee ID], [Date of Birth], [Position])values('" & txtUsername.Text & "','" & txtPassword.Text & "','" & txtFullName.Text & "','" & txtContact.Text & "','" & txtIDNo.Text & "','" & txtBirthday.Text & "','" & txtPostiton.Text & "')"
            dbCmd.ExecuteNonQuery()

            MsgBox("Record Successfully Saved!")

        End If
        Call lock_textbox()
        Call User_List()

        dbCon.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you really want to cancel?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
            Call clear_textbox()
            Call lock_textbox()
        End If
    End Sub

    Private Sub mnuDeleteUser_Click(sender As Object, e As EventArgs) Handles mnuDeleteUser.Click
        dbCon.Open()
        dbCmd.Connection = dbCon
        Try
            If MsgBox("Do you really want to Delete this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
                dbCmd.CommandText = "delete from tblUser where [UserName]= '" & txtUsername.Text & "'"
                dbCmd.ExecuteNonQuery()

                MsgBox("Record Successfully Deleted!")
                RecPointer = 0
                Call User_List()
                Call clear_textbox()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbCon.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim FN As Integer
        Try
            dbCon.Open()
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblUser where [FullName] = '" & txtSearch.Text & "'"
            dbCmd.ExecuteNonQuery()
            dbTable = New DataTable
            dbAdap = New OleDb.OleDbDataAdapter
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbTable)
            FN = Convert.ToInt32(dbTable.Rows.Count.ToString())
            dgDisplay.DataSource = dbTable
            dbCon.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class