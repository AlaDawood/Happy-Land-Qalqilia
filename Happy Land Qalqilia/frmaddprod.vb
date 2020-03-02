Public Class frmaddprod
    Private Sub frmaddprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtcode.Text <> "" Then Loadprod()
        Dim DScat As New DataSet
        FillTable("SELECT Name,Code FROM Category", "Category", DScat)
        txtcat.DataSource = DScat.Tables(0)
        txtcat.DisplayMember = DScat.Tables(0).Columns(0).ToString()
        txtcat.ValueMember = DScat.Tables(0).Columns(1).ToString()
    End Sub
    Private Sub Loadprod()
        Dim SQLString As String
        Dim Dsprod As New DataSet
        SQLString = "SELECT * FROM product WHERE CODE=" & Int(txtcode.Text)
        FillTable(SQLString, "product", Dsprod)
        For empNo = 0 To Dsprod.Tables(0).Rows.Count - 1
            If Dsprod.Tables(0).Rows.Count <> 0 Then
                txtfname.Text = Dsprod.Tables(0).Rows(0).Item(2)
                txtprice.Text = Dsprod.Tables(0).Rows(0).Item(3)
                txtcat.ValueMember = Dsprod.Tables(0).Rows(0).Item(4)
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
            SQLSTRING = "UPDATE Product SET PNAME = '" & txtfname.Text & "', Price =" & Val(txtprice.Text) & "," &
               "CCode =" & Val(txtcat.SelectedValue.ToString) & " WHERE CODE =" & Val(txtcode.Text)
            ExecuteSQLStmt(SQLSTRING)
            MsgBox("تم تعديل البيانات بنجاح")
            Close()
        Else
            SQLSTRING = "INSERT INTO Product (Code, PName, Price, CCode) VALUES (" & Int(Strings.Right(Now.Year, 2) & (Frmprod.lstprod.Items.Count + 3)) & ",'" & txtfname.Text & "'," & txtprice.Text & "," &
                Int(txtcat.SelectedValue.ToString) & ")"
            ExecuteSQLStmt(SQLSTRING)
            MsgBox("تم اضافة بيانات السلعة بنجاح..")
            Close()
        End If
    End Sub

End Class