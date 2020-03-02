Public Class FrmChange
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim PassSql As String
        Dim PassDs As New DataSet
        PassSql = "Select Password From Emplo Where Code =" & Val(MainFrm.lblCode.Text)
        FillTable(PassSql, "Emplo", PassDs)
        If Val(PassDs.Tables(0).Rows(0).Item(0)) = Val(txtOld.Text) Then
            If txtNew.Text = txtNew1.Text Then
                Dim Changsql As String
                Changsql = "Update Emplo Set Password = '" & txtNew1.Text & "' Where Code =" & Val(MainFrm.lblCode.Text)
                ExecuteSQLStmt(Changsql)
                MsgBox("تم تغيير كلمة المرور بنجاح")
                Close()
            Else
                MsgBox("كلمة المرور الجديدة لا تتطابق مع التأكيد")
            End If
        Else
            MsgBox("كلمة المرور القديمة غير صحيحة")
        End If
        txtNew.Clear()
        txtNew1.Clear()
        txtOld.Clear()
    End Sub
End Class