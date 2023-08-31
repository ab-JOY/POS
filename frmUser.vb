Public Class frmUser
    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        frmCashier.Show()
        Me.Close()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Database_Connection()
        Call lock_textbox()
        Call Info()
        btnSave.Enabled = False
        btnCancel.Enabled = False
        dbCon.Close()
    End Sub

    Sub Info()
        Try
            dbCmd.Connection = dbCon
            dbCmd.CommandText = "select *from tblUser"
            dbDS = New DataSet
            dbAdap.SelectCommand = dbCmd
            dbAdap.Fill(dbDS, "tblUser")

            Dim reader As System.Data.OleDb.OleDbDataReader = dbCmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    txtUsername.Text = (reader("UserName"))
                    txtPassword.Text = (reader("Password"))
                    txtFullName.Text = (reader("FullName"))
                    txtContact.Text = (reader("Contact No"))
                    txtIDNo.Text = (reader("Employee ID"))
                    txtBirthday.Text = (reader("Date of Birth"))
                    txtPostiton.Text = (reader("Position"))
                End While

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            dbCon.Close()
        End Try
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

        dbCon.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Do you really want to cancel?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancel") = MsgBoxResult.Yes Then
            frmCashier.Show()
            Me.Close()
        End If
    End Sub
End Class