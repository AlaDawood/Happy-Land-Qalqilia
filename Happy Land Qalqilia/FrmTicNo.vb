Public Class FrmTicNo
    Private Sub FrmTicNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TicNo = 1
        TicDiscount = 0
        txtTicNo.Text = TicNo
        txtDiscount.Text = TicDiscount
        txtTicNo.SelectAll()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If txtTicNo.Text <> "" Then
            If IsNumeric(txtTicNo.Text) Then
                TicNo = Val(txtTicNo.Text)
                TicDiscount = Val(txtDiscount.Text)
                Close()
            Else
                MsgBox("الرجاء ادخال ارقام فقط")
            End If
        Else
            MsgBox("الرجاء ادخال عدد التذاكر")
        End If

    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TicNo = 0
        TicDiscount = 0
        Close()
    End Sub
End Class