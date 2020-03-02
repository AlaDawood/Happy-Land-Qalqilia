Public Class FrmOrders
    Private Sub FrmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrder()
    End Sub
    Dim Ord_itm(3) As String
    Dim itm_Ord As ListViewItem
    Private Sub LoadOrder()
        Dim lvGroup As ListViewGroup
        Dim lvItem As ListViewItem
        LstOrd.Columns.Add("")
        LstOrd.FullRowSelect = True
        '--------------------------------------------
        Dim Sqlta As String = "SELECT TableN from Settings"
        Dim taDs As New DataSet
        FillTable(Sqlta, "Settings", taDs)
        '--------------------------------------------
        LstOrd.Items.Clear()
        '---------------------------------------------
        For j = 0 To Val(taDs.Tables(0).Rows(0).Item(0)) - 1
            lvGroup = LstOrd.Groups.Add("g" & j, "طاولة " & j)
            Dim SQLString As String
            Dim Dsprod As New DataSet
            SQLString = "SELECT Trans.TCode,Product.PName,Trans.Quantity,Trans.TableN From (Trans INNER JOIN Product ON Trans.Pcode = Product.Code) Where Status = 0"
            FillTable(SQLString, "Trans", Dsprod)
            For empNo = 0 To Dsprod.Tables(0).Rows.Count - 1
                If Dsprod.Tables(0).Rows.Count <> 0 Then
                    If j = Val(Dsprod.Tables(0).Rows(empNo).Item(3)) Then
                        Ord_itm(0) = Dsprod.Tables(0).Rows(empNo).Item(1)
                        Ord_itm(1) = "الكمية: " & Dsprod.Tables(0).Rows(empNo).Item(2)
                        Ord_itm(2) = Dsprod.Tables(0).Rows(empNo).Item(0)

                        itm_Ord = New ListViewItem(Ord_itm, 0)
                        lvItem = LstOrd.Items.Add(itm_Ord)
                        lvGroup.Items.Add(lvItem)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub LstOrd_MouseUp(sender As Object, e As MouseEventArgs) Handles LstOrd.MouseUp
        If e.Button = MouseButtons.Right Then
            If IsNothing(LstOrd.GetItemAt(e.X, e.Y)) Then
                LstOrd.ContextMenuStrip = Nothing
            Else
                LstOrd.ContextMenuStrip = CMS1
            End If
        End If
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        Dim doneSql As String
        doneSql = "Update Trans Set Status = 1 Where TCode =" & Val(LstOrd.FocusedItem.SubItems(2).Text)
        ExecuteSQLStmt(doneSql)
        LoadOrder()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Dim CancelSql As String
        CancelSql = "DELETE From Trans Where TCode =" & Val(LstOrd.FocusedItem.SubItems(2).Text)
        ExecuteSQLStmt(CancelSql)
        LoadOrder()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LoadOrder()
    End Sub

    Private Sub FrmOrders_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainFrm.PictureBox1.Visible = True
    End Sub
End Class