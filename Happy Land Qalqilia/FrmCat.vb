Public Class FrmCat
    Private Sub FrmCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadcat()
    End Sub
    Dim cat_itm(2) As String
    Dim itm_cat As ListViewItem
    Private Sub Loadcat()
        Dim SQLString As String
        Dim Dscat As New DataSet
        SQLString = "SELECT Name, Code FROM category"
        FillTable(SQLString, "category", Dscat)
        lstcat.Items.Clear()
        For empNo = 0 To Dscat.Tables(0).Rows.Count - 1
            If Dscat.Tables(0).Rows.Count <> 0 Then
                cat_itm(0) = Dscat.Tables(0).Rows(empNo).Item(0)
                cat_itm(1) = Dscat.Tables(0).Rows(empNo).Item(1)
                itm_cat = New ListViewItem(cat_itm, 0)
                lstcat.Items.Add(itm_cat)
            End If
        Next
    End Sub

    Private Sub lstcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstcat.SelectedIndexChanged

    End Sub

    Private Sub lstcat_MouseUp(sender As Object, e As MouseEventArgs) Handles lstcat.MouseUp
        If e.Button = MouseButtons.Right Then
            If IsNothing(lstcat.GetItemAt(e.X, e.Y)) Then
                lstcat.ContextMenuStrip = cms1
            Else
                lstcat.ContextMenuStrip = cms2
            End If
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New frmaddcat
        frm.ShowDialog()
        Loadcat()
    End Sub

    Private Sub lstcat_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstcat.MouseDoubleClick
        If IsNothing(lstcat.GetItemAt(e.X, e.Y)) Then
            Exit Sub
        Else
            If e.Button = MouseButtons.Left Then
                Dim frm As New frmaddcat
                frm.txtcode.Text = lstcat.FocusedItem.SubItems(1).Text
                frm.ShowDialog()
                Loadcat()
            End If
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim frm As New frmaddcat
        frm.txtcode.Text = lstcat.FocusedItem.SubItems(1).Text
        frm.ShowDialog()
        Loadcat()
    End Sub

    Private Sub FrmCat_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainFrm.PictureBox1.Visible = True
    End Sub
End Class