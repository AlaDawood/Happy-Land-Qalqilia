Imports System.IO
Public Class FrmConn

    Private Sub FrmConn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PathFile As String = Application.StartupPath & "\Conn.txt"
        If File.Exists(PathFile) Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(PathFile)
            txtServer.Text = fileReader
        Else
            MsgBox("File Not found")
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        System.IO.File.WriteAllText(Application.StartupPath & "\Conn.txt", txtServer.Text)

        Dim ZeroingSql As String
        ZeroingSql = "Alter Table TicketPaid ADD TDiscount Money"
        ExecuteSQLStmt(ZeroingSql)
        ZeroingSql = "Update TicketPaid Set TDiscount = 0 Where TDiscount IS NULL"
        If chkZeroing.Checked = True Then ExecuteSQLStmt(ZeroingSql)
        MsgBox("Done...Saved")
        Close()
    End Sub
End Class