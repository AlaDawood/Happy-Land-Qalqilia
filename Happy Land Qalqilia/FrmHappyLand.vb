Public Class FrmHappyLand
    Private Sub FrmHappyLand_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainFrm.PictureBox1.Visible = True
    End Sub

    Private Sub FrmHappyLand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ViewChild.PerformClick()

        If TCNo = 0 Then
            LoadTickets()
        Else
            LoadKids()
        End If
        Dim SQLTic As String = "Select TicketsN From Settings"
        Dim TicDS As New DataSet
        FillTable(SQLTic, "Settings", TicDS)
        TicNom = Val(TicDS.Tables(0).Rows(0).Item(0))
    End Sub

    Dim Kids_itm(3) As String
    Dim itm_Kids As ListViewItem
    Private Sub LoadKids1(KNam As String)
        Dim SQLString As String
        Dim DsKids As New DataSet
        SQLString = "SELECT KName,TicketsN,KCode FROM Kids Where KName Like '%" & KNam & "%'"
        FillTable(SQLString, "Kids", DsKids)
        lstLand.Items.Clear()
        For empNo = 0 To DsKids.Tables(0).Rows.Count - 1
            If DsKids.Tables(0).Rows.Count <> 0 Then
                Kids_itm(0) = DsKids.Tables(0).Rows(empNo).Item(0)
                Kids_itm(1) = "عدد التذاكر: " & DsKids.Tables(0).Rows(empNo).Item(1)
                Kids_itm(2) = DsKids.Tables(0).Rows(empNo).Item(2)
                itm_Kids = New ListViewItem(Kids_itm, 1)
                lstLand.Items.Add(itm_Kids)
            End If
        Next
    End Sub
    Public Sub LoadKids()
        Dim SQLString As String
        Dim DsKids As New DataSet
        SQLString = "SELECT KName,TicketsN,KCode FROM Kids"
        FillTable(SQLString, "Kids", DsKids)
        lstLand.Items.Clear()
        For empNo = 0 To DsKids.Tables(0).Rows.Count - 1
            If DsKids.Tables(0).Rows.Count <> 0 Then
                Kids_itm(0) = DsKids.Tables(0).Rows(empNo).Item(0)
                Kids_itm(1) = "عدد التذاكر: " & DsKids.Tables(0).Rows(empNo).Item(1)
                Kids_itm(2) = DsKids.Tables(0).Rows(empNo).Item(2)
                itm_Kids = New ListViewItem(Kids_itm, 1)
                lstLand.Items.Add(itm_Kids)
            End If
        Next
    End Sub

    Dim tic_itm(3) As String
    Dim itm_tic As ListViewItem

    Public Sub LoadTickets()
        Dim SQLString As String
        Dim Dstic As New DataSet
        SQLString = "SELECT TName,TPrice,TCode FROM Tickets"
        FillTable(SQLString, "Tickets", Dstic)
        lstLand.Items.Clear()
        For empNo = 0 To Dstic.Tables(0).Rows.Count - 1
            If Dstic.Tables(0).Rows.Count <> 0 Then
                tic_itm(0) = Dstic.Tables(0).Rows(empNo).Item(0)
                tic_itm(1) = Dstic.Tables(0).Rows(empNo).Item(1)
                tic_itm(2) = Dstic.Tables(0).Rows(empNo).Item(2)
                itm_tic = New ListViewItem(tic_itm, 0)
                lstLand.Items.Add(itm_tic)
            End If
        Next
    End Sub

    Private Sub lstLand_MouseUp(sender As Object, e As MouseEventArgs) Handles lstLand.MouseUp
        If e.Button = MouseButtons.Right Then
            If IsNothing(lstLand.GetItemAt(e.X, e.Y)) Then
                lstLand.ContextMenuStrip = cms2
            Else
                lstLand.ContextMenuStrip = cms1
            End If
        End If
    End Sub

    Private Sub Printtic()
        Dim MaxSql As String = "SELECT MAX(ID) FROM TicketPaid"
        Dim MaxDs As New DataSet
        Dim MMAX As Integer
        FillTable(MaxSql, "TicketPaid", MaxDs)
        If IsDBNull(MaxDs.Tables(0).Rows(0).Item(0)) Then
            MMAX = 0
        Else
            MMAX = MaxDs.Tables(0).Rows(0).Item(0)
        End If
        Dim Printsql As String
        TicCode = (Val(Strings.Right(Now.Year, 2)) & MMAX + 3)
        If TCNo = 0 Then
            Printsql = "Insert INTO TicketPaid (TRCode, TCode, TPrice, TDate, TEmp, Status, TDiscount) Values (" & TicCode & "," & Val(lstLand.FocusedItem.SubItems(2).Text) & "," & (Val(lstLand.FocusedItem.SubItems(1).Text) * TicNo) & ",'" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "'," & Val(MainFrm.lblCode.Text) & ",0," & ((Val(lstLand.FocusedItem.SubItems(1).Text) * TicNo) * Val(TicDiscount)) / 100 & ")"
            ExecuteSQLStmt(Printsql)
        Else
            Printsql = "Insert INTO TicketPaid (TRCode, TCode, TPrice, TDate, TEmp, Status, TDiscount) Values (" & TicCode & "," & Val(TicType) & "," & TicPrice * TicNo & ",'" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "'," & Val(MainFrm.lblCode.Text) & ", 0," & ((TicPrice * TicNo) * Val(TicDiscount)) / 100 & ")"
            ExecuteSQLStmt(Printsql)
        End If
        SumTotal()
    End Sub

    Private Sub SumTotal()
        Dim TotalDay As Double
        Dim SqlSum As String
        Dim SumDs As New DataSet
        SqlSum = "Select Sum(price - Discount) AS Total From Orders Where Status = 0 And EmpCode =" & Val(MainFrm.lblCode.Text) & " And format(OrDate, 'dd/MM/yyyy') = @OrDate "
        Dim dadapter As New OleDb.OleDbDataAdapter
        dadapter = New OleDb.OleDbDataAdapter
        dadapter.SelectCommand = New OleDb.OleDbCommand(SqlSum, con)
        dadapter.SelectCommand.Parameters.AddWithValue("@OrDate", Date.Now.ToString("dd/MM/yyyy"))
        dadapter.Fill(SumDs)
        If IsDBNull(SumDs.Tables(0).Rows(0).Item(0)) Then
        Else
            TotalDay = Val(SumDs.Tables(0).Rows(0).Item(0))
        End If
        Dim SQLTicSum As String
        Dim ticSumDs As New DataSet
        SQLTicSum = "Select sum(TPrice - TDiscount) AS Total From TicketPaid Where Status = 0 And TEmp =" & Val(MainFrm.lblCode.Text) & " And format(TDate, 'dd/MM/yyyy') = @TDate"
        dadapter.SelectCommand = New OleDb.OleDbCommand(SQLTicSum, con)
        dadapter.SelectCommand.Parameters.AddWithValue("@TDate", Date.Now.ToString("dd/MM/yyyy"))
        dadapter.Fill(ticSumDs)
        If IsDBNull(ticSumDs.Tables(0).Rows(0).Item(0)) Then
        Else
            TotalDay = TotalDay + Val(ticSumDs.Tables(0).Rows(0).Item(0))
        End If
        MainFrm.txtEnd.Text = TotalDay
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If TCNo = 0 Then
            Dim frm As New FrmTicNo
            frm.ShowDialog()
            If TicNo = 0 Then
                Exit Sub
            Else
                Printtic()
                SiNo = 2
                Billfrm.ShowDialog()
            End If
        Else
            Dim frm As New FrmTicNo2
            frm.ShowDialog()
            If TicNo = 0 Then
                Exit Sub
            Else
                Printtic()
                SiNo = 3
                Billfrm.ShowDialog()
            End If
            LoadKids()
        End If

    End Sub

    Private Sub lstLand_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstLand.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If IsNothing(lstLand.GetItemAt(e.X, e.Y)) Then
                Exit Sub
            Else
                btnPrint.PerformClick()
            End If
        End If
    End Sub

    Private Sub addchild_Click(sender As Object, e As EventArgs) Handles addchild.Click
        TCNo = 1
        lstLand.Items.Clear()
        LoadKids()
        Dim frm As New FrmaddChild
        frm.ShowDialog()
    End Sub

    Private Sub ViewChild_Click(sender As Object, e As EventArgs) Handles ViewChild.Click
        If TCNo = 0 Then
            TCNo = 1
            ViewChild.Text = "عرض التذاكر"
            lstLand.Items.Clear()
            LoadKids()
        Else
            TCNo = 0
            ViewChild.Text = "عرض اسماء الاطفال"
            lstLand.Items.Clear()
            LoadTickets()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If TCNo <> 0 Then
            lstLand.Items.Clear()
            LoadKids1(txtSearch.Text)
        End If
    End Sub

    Private Sub BtnEditKids_Click(sender As Object, e As EventArgs) Handles BtnEditKids.Click
        If TCNo <> 0 Then
            KidsCode = 1
            Dim frm As New FrmaddChild
            frm.ShowDialog()
        End If
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If TCNo <> 0 Then
            Dim SQLDel As String = "Delete From Kids Where KCode = " & Val(lstLand.FocusedItem.SubItems(2).Text)
            Dim DelMsg = MsgBox("هل تريد ان تحذف اسم الطفل؟", MsgBoxStyle.OkCancel)
            If DelMsg = MsgBoxResult.Ok Then
                ExecuteSQLStmt(SQLDel)
                LoadKids()
            End If
        End If
    End Sub

End Class