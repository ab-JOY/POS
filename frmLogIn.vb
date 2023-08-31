Public Class frmLogIn
    Private Sub pbLogIn_Click(sender As Object, e As EventArgs) Handles pbLogIn.Click
        Try
            If txtUserName.Text = "" And txtPassword.Text = "" Then
                MsgBox("FIELDS REQUIRED", MsgBoxStyle.Exclamation, "LOGIN FAILED ")
            Else
                Call Database_Connection()
                dbCmd = New OleDb.OleDbCommand("Select * from tblUser where UserName ='" & txtUserName.Text & "' and Password ='" & txtPassword.Text & "'", dbCon)
                dbCmd.Parameters.AddWithValue("@UserName", OleDb.OleDbType.VarChar).Value = txtUserName.Text.Trim
                dbCmd.Parameters.AddWithValue("@Password", OleDb.OleDbType.VarChar).Value = txtPassword.Text.Trim
                dbDS = New DataSet
                dbAdap.SelectCommand = dbCmd
                dbAdap.Fill(dbDS, "tblUser")

                Dim reader As System.Data.OleDb.OleDbDataReader = dbCmd.ExecuteReader()

                If dbDS.Tables("tblUser").Rows(0)("Position") = "Admin" Then
                    Dim Inventory As New frmInventory
                    frmInventory.Inventory = txtUserName.Text
                    frmInventory.Show()
                    Me.Hide()

                ElseIf dbDS.Tables("tblUser").Rows(0)("Position") = "Cashier" Then
                    Dim Cashier As New frmCashier
                    frmCashier.Cashier = txtUserName.Text
                    frmCashier.Show()
                    Me.Hide()
                Else
                    MsgBox("User Does Not Exist", MsgBoxStyle.Exclamation, "LOGIN FAILED")
                    txtUserName.Text = ""
                    txtPassword.Text = ""
                End If

                dbCon.Close()

                End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "LOGIN")
        End Try
        txtUserName.Visible = False
        txtPassword.Visible = False
        lblShowPassword.Visible = False
        txtUserName.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database_Connection()
        txtUserName.Visible = False
        txtPassword.Visible = False
        lblShowPassword.Visible = False
        txtUserName.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub pbUsername_Click(sender As Object, e As EventArgs) Handles pbUsername.Click
        txtUserName.Visible = True
    End Sub

    Private Sub pbPassword_Click(sender As Object, e As EventArgs) Handles pbPassword.Click
        txtPassword.Visible = True
        lblShowPassword.Visible = True
        txtPassword.UseSystemPasswordChar = True
    End Sub
    Private Sub pbCloseApp_Click(sender As Object, e As EventArgs) Handles pbCloseApp.Click
        End
    End Sub

    Private Sub lblShowPassword_Click(sender As Object, e As EventArgs) Handles lblShowPassword.Click

        If lblShowPassword.Text = "Show" Then
            txtPassword.UseSystemPasswordChar = False
            lblShowPassword.Text = "Hide"

        ElseIf lblShowPassword.Text = "Hide" Then
            txtPassword.UseSystemPasswordChar = True
            lblShowPassword.Text = "Show"
        End If


    End Sub
End Class