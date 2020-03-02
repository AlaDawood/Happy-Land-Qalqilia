Public Class frmtrans
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub frmtrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comto.Items.Clear()
        comfrom.Items.Clear()
        For c = 0 To FrmCRest.lstTable.Items.Count - 1
            comfrom.Items.Add(FrmCRest.lstTable.Items(c).SubItems(0).Text)
            comto.Items.Add(FrmCRest.lstTable.Items(c).SubItems(0).Text)
        Next
        comfrom.Text = FrmCRest.lstTable.FocusedItem.SubItems(0).Text
        If comfrom.SelectedIndex = comfrom.Items.Count - 1 Then
            comto.SelectedIndex = comfrom.SelectedIndex - 1
        Else
            comto.SelectedIndex = comfrom.SelectedIndex + 1
        End If
        comfrom.Enabled = False
        For v = 0 To comto.Items.Count - 1
            If comto.Items(v).ToString = comfrom.SelectedItem.ToString Then
                comto.Items.RemoveAt(v)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub btntrans_Click(sender As Object, e As EventArgs) Handles btntrans.Click
        Dim sqltrans As String
        sqltrans = "Update trans Set TableN=" & Val(comto.Text) & " Where TableN=" & Val(comfrom.Text) & " AND (Status=0 OR Status=1)"
        ExecuteSQLStmt(sqltrans)
        MsgBox("تم نقل الطلبات بنجاح")
        Close()
    End Sub
End Class