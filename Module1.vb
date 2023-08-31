Module Module1
    Public dbCon As New OleDb.OleDbConnection
    Public dbAdap As New OleDb.OleDbDataAdapter
    Public dbCmd As New OleDb.OleDbCommand
    Public dbDS As New DataSet
    Public RecPointer As Integer
    Public dbTable As New DataTable



    Sub Database_Connection()
        Try
            dbCon = New OleDb.OleDbConnection
            dbCon.ConnectionString = "provider = microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\Database\dbPOS.mdb"
            dbCon.Open()
        Catch ex As Exception
            MsgBox(ex.Message, "connection")
        End Try
    End Sub
End Module
