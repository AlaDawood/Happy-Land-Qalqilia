Public Class FrmTicket
    Private Sub FrmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTickets()
    End Sub
    Dim tic_itm(3) As String
    Dim itm_tic As ListViewItem
    Private Sub LoadTickets()
        Dim SQLString As String
        Dim Dstic As New DataSet
        SQLString = "SELECT TName,TPrice,TCode FROM Tickets"
        FillTable(SQLString, "Tickets", Dstic)
        LstTic.Items.Clear()
        For empNo = 0 To Dstic.Tables(0).Rows.Count - 1
            If Dstic.Tables(0).Rows.Count <> 0 Then
                tic_itm(0) = Dstic.Tables(0).Rows(empNo).Item(0)
                tic_itm(1) = Dstic.Tables(0).Rows(empNo).Item(1)
                tic_itm(2) = Dstic.Tables(0).Rows(empNo).Item(2)
                itm_tic = New ListViewItem(tic_itm, 0)
                LstTic.Items.Add(itm_tic)
            End If
        Next
    End Sub

    Private Sub LstTic_MouseUp(sender As Object, e As MouseEventArgs) Handles LstTic.MouseUp
        If e.Button = MouseButtons.Right Then
            If IsNothing(LstTic.GetItemAt(e.X, e.Y)) Then
                LstTic.ContextMenuStrip = cms1
            Else
                LstTic.ContextMenuStrip = cms2
            End If
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New FrmAddTic
        frm.ShowDialog()
        LoadTickets()
    End Sub

    Private Sub LstTic_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LstTic.MouseDoubleClick
        If IsNothing(LstTic.GetItemAt(e.X, e.Y)) Then
            Exit Sub
        Else
            If e.Button = MouseButtons.Left Then
                Dim frm As New FrmAddTic
                frm.txtcode.Text = LstTic.FocusedItem.SubItems(2).Text
                frm.ShowDialog()
                LoadTickets()
            End If
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim frm As New FrmAddTic
        frm.txtcode.Text = LstTic.FocusedItem.SubItems(2).Text
        frm.ShowDialog()
        LoadTickets()
    End Sub

    Private Sub FrmTicket_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainFrm.PictureBox1.Visible = True
    End Sub
End Class