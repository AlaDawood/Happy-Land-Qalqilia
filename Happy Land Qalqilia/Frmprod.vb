Public Class Frmprod
    Private Sub Frmprod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadprod()

    End Sub
    Dim prod_itm(3) As String
    Dim itm_prod As ListViewItem
    Private Sub Loadprod()
        Dim lvGroup As ListViewGroup
        Dim lvItem As ListViewItem
        lstprod.Columns.Add("")
        lstprod.FullRowSelect = True
        '--------------------------------------------
        Dim SqlCat As String = "SELECT Code,Name from Category"
        Dim CatDs As New DataSet
        FillTable(SqlCat, "Category", CatDs)
        '--------------------------------------------
        lstprod.Items.Clear()
        '---------------------------------------------
        For j = 0 To CatDs.Tables(0).Rows.Count - 1
            lvGroup = lstprod.Groups.Add("g" & j, "مجموعة " & CatDs.Tables(0).Rows(j).Item(1))
            Dim SQLString As String
            Dim Dsprod As New DataSet
            SQLString = "SELECT PName,Code,Price,CCode FROM Product Where CCode =" & CatDs.Tables(0).Rows(j).Item(0)
            FillTable(SQLString, "Product", Dsprod)
            For empNo = 0 To Dsprod.Tables(0).Rows.Count - 1
                If Dsprod.Tables(0).Rows.Count <> 0 Then
                    prod_itm(0) = Dsprod.Tables(0).Rows(empNo).Item(0)
                    prod_itm(1) = Dsprod.Tables(0).Rows(empNo).Item(1)
                    prod_itm(2) = Dsprod.Tables(0).Rows(empNo).Item(2)

                    itm_prod = New ListViewItem(prod_itm, 0)
                    lvItem = lstprod.Items.Add(itm_prod)
                    lvGroup.Items.Add(lvItem)
                End If
            Next
        Next
    End Sub

    Private Sub lstprod_MouseUp(sender As Object, e As MouseEventArgs) Handles lstprod.MouseUp
        If e.Button = MouseButtons.Right Then
            If IsNothing(lstprod.GetItemAt(e.X, e.Y)) Then
                lstprod.ContextMenuStrip = CMS1
            Else
                lstprod.ContextMenuStrip = CMS2
            End If
        End If
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        Dim frm As New frmaddprod
        frm.ShowDialog()
        Loadprod()
    End Sub

    Private Sub lstprod_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstprod.MouseDoubleClick
        If IsNothing(lstprod.GetItemAt(e.X, e.Y)) Then
            Exit Sub
        Else
            If e.Button = MouseButtons.Left Then
                Dim frm As New frmaddprod
                frm.txtcode.Text = lstprod.FocusedItem.SubItems(1).Text
                frm.ShowDialog()
                Loadprod()
            End If
        End If
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        Dim frm As New frmaddprod
        frm.txtcode.Text = lstprod.FocusedItem.SubItems(1).Text
        frm.ShowDialog()
        Loadprod()
    End Sub

    Private Sub Frmprod_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainFrm.PictureBox1.Visible = True
    End Sub
End Class