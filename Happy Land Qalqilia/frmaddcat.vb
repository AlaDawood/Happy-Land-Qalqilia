Public Class frmaddcat

    Private Sub Loadcat()
        Dim SQLString1 As String
        Dim Dscat As New DataSet

        SQLString1 = "SELECT * FROM Category WHERE Code =" & Int(txtcode.Text)
        FillTable(SQLString1, "Category", Dscat)
        For empNo = 0 To Dscat.Tables(0).Rows.Count - 1
            If Dscat.Tables(0).Rows.Count <> 0 Then
                txtcode.Text = Dscat.Tables(0).Rows(0).Item(1)
                txtfname.Text = Dscat.Tables(0).Rows(0).Item(2)
            End If
        Next
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim SQLSTRING As String = ""
        Dim emptyTextBoxes =
    From txt In Me.Controls.OfType(Of TextBox)()
    Where txt.Text.Length = 0 And txt.Name <> "txtcode"
    Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("الرجاء ملئ الفراغات: {0}",
                    String.Join(",", emptyTextBoxes)))
            Exit Sub
        End If
        If txtcode.Text <> "" Then
            SQLSTRING = "UPDATE Category SET Name = '" & txtfname.Text & "'" & " WHERE Code =" & Int(txtcode.Text)
            ExecuteSQLStmt(SQLSTRING)
            MsgBox("تم تعديل البيانات بنجاح")
            Close()
        Else
            SQLSTRING = "INSERT INTO Category (Code, Name) VALUES (" & ((FrmCat.lstcat.Items.Count + 1) & Int(Strings.Right(Now.Year, 2) & Int(Strings.Left(Now.Second, 1)))) & ",'" & txtfname.Text & "')"
            ExecuteSQLStmt(SQLSTRING)
            MsgBox("تم اضافة بيانات المجموعة بنجاح..")
            Close()
        End If
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged
        Loadcat()
    End Sub

End Class