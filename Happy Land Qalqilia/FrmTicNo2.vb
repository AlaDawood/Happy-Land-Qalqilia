Public Class FrmTicNo2
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If txtTicNo.Text <> "" Then
            If IsNumeric(txtTicNo.Text) Then
                TicNo = Val(txtTicNo.Text)
                TicDiscount = Val(txtDiscount.Text)
                If TicNom <= Val(Strings.Mid(FrmHappyLand.lstLand.FocusedItem.SubItems(1).Text, 13)) Then
                    Dim SQLPlus As String = "Update Kids Set TicketsN = 0 Where KCode =" & Val(FrmHappyLand.lstLand.FocusedItem.SubItems(2).Text)
                    ExecuteSQLStmt(SQLPlus)
                Else
                    Dim SQLPlus As String = "Update Kids Set TicketsN = TicketsN + 1 Where KCode =" & Val(FrmHappyLand.lstLand.FocusedItem.SubItems(2).Text)
                    ExecuteSQLStmt(SQLPlus)
                End If
                KidsName = Val(FrmHappyLand.lstLand.FocusedItem.SubItems(2).Text)
                TicType = Val(txtType.SelectedValue.ToString)
                TicPrice = Val(txtPrice.Text)
                Close()
            Else
                MsgBox("الرجاء ادخال ارقام فقط")
            End If
        Else
            MsgBox("الرجاء ادخال عدد التذاكر")
        End If
    End Sub
    Dim DSTic As New DataSet
    Private Sub FrmTicNo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TicNo = 1
        TicDiscount = 0
        txtTicNo.Text = TicNo
        txtDiscount.Text = TicDiscount
        txtTicNo.SelectAll()
        Dim SQLStr As String = "SELECT TName, TCode, TPrice From Tickets"
        FillTable(SQLStr, "Tickets", DSTic)
        txtType.DisplayMember = "TName"
        txtType.ValueMember = "TCode"
        txtType.DataSource = DSTic.Tables(0)
        If TicNom <= Val(Strings.Mid(FrmHappyLand.lstLand.FocusedItem.SubItems(1).Text, 13)) Then
            txtPrice.Text = "تذكرة مجانية"
            txtDiscount.ReadOnly = True
            txtTicNo.ReadOnly = True
        End If
    End Sub

    Private Sub txtType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtType.SelectedIndexChanged
        If TicNom = Val(Strings.Mid(FrmHappyLand.lstLand.FocusedItem.SubItems(1).Text, 13)) Then
            txtPrice.Text = "تذكرة مجانية"
        Else
            txtPrice.Text = DSTic.Tables(0).Rows(txtType.SelectedIndex).Item(2).ToString()
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TicNo = 0
        TicDiscount = 0
        Close()
    End Sub
End Class