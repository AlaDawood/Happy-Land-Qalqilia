Public Class FrmSet
    Dim XX As Integer
    Private Sub FrmSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NoTable As String
        NoTable = "SELECT TableN, TicketsN FROM Settings"
        Dim TableDs As New DataSet
        FillTable(NoTable, 0, TableDs)
        XX = Val(TableDs.Tables(0).Rows(0).Item(0))
        txtTable.Text = XX
        txtTic.Text = Val(TableDs.Tables(0).Rows(0).Item(1))
    End Sub

    Private Sub BTNCancel_Click(sender As Object, e As EventArgs) Handles BTNCancel.Click
        Close()
    End Sub

    Private Sub BTNok_Click(sender As Object, e As EventArgs) Handles BTNok.Click
        Dim SQLStmt As String
        If XX <> Val(txtTable.Text) Then
            SQLStmt = "Update Settings Set TableN =" & Val(txtTable.Text)
            XX = Val(txtTable.Text)
            ExecuteSQLStmt(SQLStmt)
        End If
        SQLStmt = "Update Settings Set TicketsN =" & Val(txtTic.Text)
        ExecuteSQLStmt(SQLStmt)
        TicNom = Val(txtTic.Text)
        If CHKOrd.Checked = True Then
            SQLStmt = "DELETE From Orders"
            ExecuteSQLStmt(SQLStmt)
            SQLStmt = "DELETE from Trans"
            ExecuteSQLStmt(SQLStmt)
            MsgBox("تم " & CHKOrd.Text)
        End If
        If CHKOUT.Checked = True Then
            SQLStmt = "DELETE from OutCome"
            ExecuteSQLStmt(SQLStmt)
            MsgBox("تم " & CHKOUT.Text)
        End If
        If CHKTickets.Checked = True Then
            SQLStmt = "DELETE from ticketpaid"
            ExecuteSQLStmt(SQLStmt)
            MsgBox("تم " & CHKTickets.Text)
        End If
        Close()
    End Sub

End Class
