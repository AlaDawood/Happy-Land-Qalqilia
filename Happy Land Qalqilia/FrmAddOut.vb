Public Class FrmAddOut
    Private Sub Btnok_Click(sender As Object, e As EventArgs) Handles Btnok.Click
        Dim SQLAdd As String
        Dim SQLmAX As String
        Dim maxds As New DataSet
        Dim MaxCode As Integer
        SQLmAX = "SELECT max(ID) from OutCome"
        FillTable(SQLmAX, "OutCome", maxds)
        If IsDBNull(maxds.Tables(0).Rows(0).Item(0)) Then
            MaxCode = (Val(Strings.Right(Now.Year, 2)) & Val(Now.Month) & 0)
        Else
            MaxCode = (Val(Strings.Right(Now.Year, 2)) & Val(Now.Month) & (Val(maxds.Tables(0).Rows(0).Item(0)) + 1))
        End If
        If txtcode.Text <> "" Then
            SQLAdd = "Update OutCome Set Description='" & txtdesc.Text & "',Price=" & Val(txtprice.Text) & ",ODate='" & txtdate.Value.ToString("yyyy/MM/dd HH:mm:ss") & "' Where Code =" & Val(txtcode.Text)
            ExecuteSQLStmt(SQLAdd)
            frmReport.BtnSearch2.PerformClick()
        Else
            SQLAdd = "INSERT INTO OutCome (Code, Description, Price, ODate) VALUES (" & MaxCode & ",'" & txtdesc.Text & "'," & Val(txtprice.Text) & ",'" & txtdate.Value.ToString("yyyy/MM/dd HH:mm:ss") & "')"
            ExecuteSQLStmt(SQLAdd)
            frmReport.BtnSearch2.PerformClick()
        End If
        Close()
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged
        If txtcode.Text <> "" Then
            Dim SQLEdit As String
            Dim EditDs As New DataSet
            SQLEdit = "Select * from OutCome Where Code =" & Val(txtcode.Text)
            FillTable(SQLEdit, "OutCome", EditDs)
            txtdesc.Text = EditDs.Tables(0).Rows(0).Item(2)
            txtprice.Text = EditDs.Tables(0).Rows(0).Item(3)
            txtdate.Text = FormatDateTime(EditDs.Tables(0).Rows(0).Item(4), DateFormat.GeneralDate)
        End If
    End Sub

    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Close()
    End Sub
End Class