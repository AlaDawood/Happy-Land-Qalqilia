Public Class frmReport
    Dim SData(7) As String
    Dim DataS As ListViewItem
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim SSql As String
        Dim SDs As New DataSet
        DTTo.Value = DTTo.Value.AddDays(1)
        SSql = "SELECT Orders.Code,Orders.OrDate,Orders.TableN,Orders.price,Orders.Discount,emplo.Fname,emplo.lname From (Orders INNER Join emplo ON Orders.empcode=emplo.code) Where Orders.OrDate >= #" & DTFrom.Value.Year & "/" & DTFrom.Value.Month & "/" & DTFrom.Value.Day & "# AND Orders.OrDate <= #" & DTTo.Value.Year & "/" & DTTo.Value.Month & "/" & DTTo.Value.Day & "# Order By Orders.OrDate"
        Dim dadapter As New OleDb.OleDbDataAdapter
        dadapter = New OleDb.OleDbDataAdapter
        dadapter.SelectCommand = New OleDb.OleDbCommand(SSql, con)
        'dadapter.SelectCommand.Parameters.AddWithValue("@OrDate1", DTFrom.Value.ToString("dd/MM/yyyy"))
        'dadapter.SelectCommand.Parameters.AddWithValue("@OrDate2", DTTo.Value.ToString("dd/MM/yyyy"))
        dadapter.Fill(SDs)
        'FillTable(SSql, "Orders", SDs)
        lstCofee.Items.Clear()
        lstItems.Items.Clear()
        For b = 0 To SDs.Tables(0).Rows.Count - 1
            SData(0) = SDs.Tables(0).Rows(b).Item(0)
            SData(1) = SDs.Tables(0).Rows(b).Item(1)
            SData(2) = SDs.Tables(0).Rows(b).Item(2)
            SData(3) = Math.Round(SDs.Tables(0).Rows(b).Item(3), 2)
            SData(4) = SDs.Tables(0).Rows(b).Item(4)
            SData(5) = SDs.Tables(0).Rows(b).Item(5) & " " & SDs.Tables(0).Rows(b).Item(6)
            DataS = New ListViewItem(SData)
            lstCofee.Items.Add(DataS)
        Next
        Calc()
        DTTo.Value = DTTo.Value.AddDays(-1)
    End Sub
    Private Sub Calc()
        lblSum.Text = 0
        lblDiscount.Text = 0
        lblAll.Text = 0
        For y = 0 To lstCofee.Items.Count - 1
            lblSum.Text = Val(lblSum.Text) + Val(lstCofee.Items(y).SubItems(3).Text)
            lblDiscount.Text = Val(lblDiscount.Text) + Val(lstCofee.Items(y).SubItems(4).Text)
            lblAll.Text = Val(lblSum.Text) - Val(lblDiscount.Text)
        Next
    End Sub
    Dim ITData(7) As String
    Dim DataIT As ListViewItem
    Private Sub lstCofee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCofee.SelectedIndexChanged
        If lstCofee.SelectedItems.Count <> 0 Then
            Dim ITSql As String
            Dim ITDs As New DataSet
            ITSql = "Select Trans.TCode, Product.PName,Trans.Quantity,Trans.price,Trans.Cost,Category.Name,Trans.TableN From ((Trans Inner Join Product On Trans.PCode=Product.Code)Inner Join Category On Trans.CCode=Category.Code) Where Trans.OCode = " & Val(lstCofee.FocusedItem.SubItems(0).Text)
            FillTable(ITSql, "Trans", ITDs)
            lstItems.Items.Clear()
            For m = 0 To ITDs.Tables(0).Rows.Count - 1
                ITData(0) = ITDs.Tables(0).Rows(m).Item(0)
                ITData(1) = ITDs.Tables(0).Rows(m).Item(1)
                ITData(2) = ITDs.Tables(0).Rows(m).Item(2)
                ITData(3) = Math.Round(ITDs.Tables(0).Rows(m).Item(3), 2)
                ITData(4) = Math.Round(ITDs.Tables(0).Rows(m).Item(4), 2)
                ITData(5) = ITDs.Tables(0).Rows(m).Item(5)
                ITData(6) = ITDs.Tables(0).Rows(m).Item(6)
                DataIT = New ListViewItem(ITData)
                lstItems.Items.Add(DataIT)
            Next
        Else
            lstItems.Items.Clear()
        End If
    End Sub

    Private Sub lstCofee_KeyUp(sender As Object, e As KeyEventArgs) Handles lstCofee.KeyUp
        If e.KeyCode = Keys.Delete Then
            If lstCofee.SelectedItems.Count <> 0 Then
                Dim Amsg = MsgBox("هل أنت متأكد من أنك تريد حذف الفاتورة حقاً", MsgBoxStyle.OkCancel)
                If Amsg = MsgBoxResult.Ok Then
                    Dim DelSql As String
                    DelSql = "Delete from Trans Where OCode = " & Val(lstCofee.FocusedItem.SubItems(0).Text)
                    ExecuteSQLStmt(DelSql)
                    DelSql = "Delete From Orders Where Code = " & Val(lstCofee.FocusedItem.SubItems(0).Text)
                    ExecuteSQLStmt(DelSql)
                    lstItems.Items.Clear()
                    lstCofee.FocusedItem.Remove()
                    Calc()
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub lstItems_KeyUp(sender As Object, e As KeyEventArgs) Handles lstItems.KeyUp
        Dim PPRice As Double = 0
        If e.KeyCode = Keys.Delete Then
            If lstItems.SelectedItems.Count <> 0 Then
                Dim Amsg = MsgBox("هل أنت متأكد من أنك تريد حذف هذا البند من الفاتورة حقاً", MsgBoxStyle.OkCancel)
                If Amsg = MsgBoxResult.Ok Then
                    Dim DelSql As String

                    If Val(lstItems.FocusedItem.SubItems(2).Text) > 1 Then
                        lstItems.FocusedItem.SubItems(2).Text = Val(lstItems.FocusedItem.SubItems(2).Text) - 1
                        DelSql = "Update Trans Set Quantity = Quantity-1,Cost = " & Val(lstItems.FocusedItem.SubItems(2).Text) * Val(lstItems.FocusedItem.SubItems(3).Text) & " Where TCode = " & Val(lstItems.FocusedItem.SubItems(0).Text)
                        ExecuteSQLStmt(DelSql)
                    Else
                        DelSql = "Delete from Trans Where TCode = " & Val(lstItems.FocusedItem.SubItems(0).Text)
                        ExecuteSQLStmt(DelSql)
                        lstItems.FocusedItem.Remove()
                    End If
                    For k = 0 To lstItems.Items.Count - 1
                        PPRice = PPRice + (Val(lstItems.Items(k).SubItems(2).Text) * Val(lstItems.Items(k).SubItems(3).Text))
                    Next
                    lstCofee.FocusedItem.SubItems(3).Text = PPRice
                    Dim Updateprice As String
                    If Val(lstCofee.FocusedItem.SubItems(4).Text) <> 0 Then
                        Dim DisMsg = InputBox("هناك خصم على قيمة الفاتورة هل تريد تغييره؟", "الخصم %", Val(lstCofee.FocusedItem.SubItems(4).Text))
                        Updateprice = "Update Orders Set Price = " & Val(PPRice) & ", Discount = " & (Val(PPRice * DisMsg) / 100) & " Where Code = " & Val(lstCofee.FocusedItem.SubItems(0).Text)
                        ExecuteSQLStmt(Updateprice)
                        lstCofee.FocusedItem.SubItems(4).Text = DisMsg
                    Else
                        Updateprice = "Update Orders Set Price = " & Val(PPRice) & " Where Code = " & Val(lstCofee.FocusedItem.SubItems(0).Text)
                        ExecuteSQLStmt(Updateprice)
                    End If

                    Calc()
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Dim TicData(6) As String
    Dim DataTic As ListViewItem
    Private Sub BtnSearch1_Click(sender As Object, e As EventArgs) Handles BtnSearch1.Click
        Dim TicSql As String
        DTTo1.Value = DTTo1.Value.AddDays(1)
        TicSql = "Select TicketPaid.TRCode,Tickets.TName,TicketPaid.TDate,TicketPaid.TPrice,TDiscount,Emplo.Fname,Emplo.LName From ((TicketPaid INNER JOIN Tickets ON TicketPaid.TCode=Tickets.TCode)INNER JOIN Emplo ON TicketPaid.TEmp=Emplo.Code) Where TicketPaid.TDate >= #" & DTFrom1.Value.Year & "/" & DTFrom1.Value.Month & "/" & DTFrom1.Value.Day & "# AND TicketPaid.TDate <= #" & DTTo1.Value.Year & "/" & DTTo1.Value.Month & "/" & DTTo1.Value.Day & "# Order By TicketPaid.TDate"
        Dim TicDs As New DataSet
        Dim dadapter As New OleDb.OleDbDataAdapter
        dadapter = New OleDb.OleDbDataAdapter
        dadapter.SelectCommand = New OleDb.OleDbCommand(TicSql, con)
        'dadapter.SelectCommand.Parameters.AddWithValue("@TDate1", DTFrom1.Value.ToString("dd/MM/yyyy"))
        'dadapter.SelectCommand.Parameters.AddWithValue("@TDate2", DTTo1.Value.ToString("dd/MM/yyyy"))
        dadapter.Fill(TicDs)
        'FillTable(TicSql, "TicketPaid", TicDs)
        lstTic.Items.Clear()
        lblSum1.Text = 0
        txtDiscount.Text = 0
        txtTotal.Text = 0
        For h = 0 To TicDs.Tables(0).Rows.Count - 1
            TicData(0) = TicDs.Tables(0).Rows(h).Item(0)
            TicData(1) = TicDs.Tables(0).Rows(h).Item(1)
            TicData(2) = TicDs.Tables(0).Rows(h).Item(2)
            TicData(3) = Math.Round(TicDs.Tables(0).Rows(h).Item(3), 2)
            TicData(4) = Math.Round(TicDs.Tables(0).Rows(h).Item(4), 2)
            TicData(5) = TicDs.Tables(0).Rows(h).Item(5) & " " & TicDs.Tables(0).Rows(h).Item(6)
            lblSum1.Text = Val(lblSum1.Text) + TicDs.Tables(0).Rows(h).Item(3)
            txtDiscount.Text = Val(txtDiscount.Text) + TicDs.Tables(0).Rows(h).Item(4)
            DataTic = New ListViewItem(TicData)
            lstTic.Items.Add(DataTic)
        Next
        txtTotal.Text = Val(lblSum1.Text) - Val(txtDiscount.Text)
        DTTo1.Value = DTTo1.Value.AddDays(-1)
    End Sub

    Private Sub lstTic_KeyUp(sender As Object, e As KeyEventArgs) Handles lstTic.KeyUp
        If e.KeyCode = Keys.Delete Then
            If lstTic.SelectedItems.Count <> 0 Then
                Dim Amsg = MsgBox("هل أنت متأكد من أنك تريد حذف التذكرة حقاً", MsgBoxStyle.OkCancel)
                If Amsg = MsgBoxResult.Ok Then
                    Dim DelSql As String
                    DelSql = "Delete from TicketPaid Where TRCode = " & Val(lstTic.FocusedItem.SubItems(0).Text)
                    ExecuteSQLStmt(DelSql)
                    lstTic.FocusedItem.Remove()
                    lblSum1.Text = 0
                    For t = 0 To lstTic.Items.Count - 1
                        lblSum1.Text = Val(lblSum1.Text) + lstTic.Items(t).SubItems(3).Text
                    Next
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub frmReport_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainFrm.PictureBox1.Visible = True
    End Sub
    Dim outitm(4) As String
    Dim itmout As ListViewItem
    Private Sub BtnSearch2_Click(sender As Object, e As EventArgs) Handles BtnSearch2.Click
        Dim SqlSearch As String
        DTTo2.Value = DTTo2.Value.AddDays(1)
        SqlSearch = "Select * From OutCome Where OutCome.ODate >= #" & DTFrom2.Value.Year & "/" & DTFrom2.Value.Month & "/" & DTFrom2.Value.Day & "# And OutCome.ODate <= #" & DTTo2.Value.Year & "/" & DTTo2.Value.Month & "/" & DTTo2.Value.Day & "# Order By OutCome.ODate"
        Dim SDS As New DataSet
        LstOut.Items.Clear()
        Dim dadapter As New OleDb.OleDbDataAdapter
        dadapter = New OleDb.OleDbDataAdapter
        dadapter.SelectCommand = New OleDb.OleDbCommand(SqlSearch, con)
        dadapter.Fill(SDS)
        'FillTable(SqlSearch, 0, SDS)
        TxtAll2.Text = 0
        For x = 0 To SDS.Tables(0).Rows.Count - 1
            outitm(0) = SDS.Tables(0).Rows(x).Item(1)
            outitm(1) = SDS.Tables(0).Rows(x).Item(2)
            outitm(2) = SDS.Tables(0).Rows(x).Item(4)
            outitm(3) = Math.Round(SDS.Tables(0).Rows(x).Item(3), 2)
            TxtAll2.Text = Val(TxtAll2.Text) + Val(SDS.Tables(0).Rows(x).Item(3))
            itmout = New ListViewItem(outitm)
            LstOut.Items.Add(itmout)
        Next
        DTTo2.Value = DTTo2.Value.AddDays(-1)
    End Sub

    Private Sub LstOut_KeyUp(sender As Object, e As KeyEventArgs) Handles LstOut.KeyUp
        If e.KeyCode = Keys.Delete Then
            If LstOut.SelectedItems.Count <> 0 Then
                Dim SQLSTR As String
                SQLSTR = "Delete from OutCome Where Code = " & Val(LstOut.FocusedItem.SubItems(0).Text)
                ExecuteSQLStmt(SQLSTR)
                TxtAll2.Text = Val(TxtAll2.Text) - Val(LstOut.FocusedItem.SubItems(3).Text)
                LstOut.FocusedItem.Remove()
            End If
        End If
    End Sub

    Private Sub LstOut_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LstOut.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If IsNothing(LstOut.GetItemAt(e.X, e.Y)) Then
                Exit Sub
            Else
                FrmAddOut.txtcode.Text = LstOut.FocusedItem.SubItems(0).Text
                FrmAddOut.ShowDialog()

            End If
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FrmAddOut.txtcode.Clear()
        FrmAddOut.txtdesc.Clear()
        FrmAddOut.txtprice.Clear()
        FrmAddOut.ShowDialog()
    End Sub
    Dim BoxData(4) As String
    Dim DataBox As ListViewItem
    Private Sub BtnSearch3_Click(sender As Object, e As EventArgs) Handles BtnSearch3.Click
        Dim BoxSql As String
        BoxSql = "Select Shifting.Code,Shifting.ShDate,Shifting.Price,Emplo.Fname,Emplo.LName From (Shifting INNER JOIN Emplo ON Shifting.EmpCode=Emplo.Code) Where format(Shifting.ShDate,'dd/MM/yyyy') = @ShDate"
        Dim BoxDs As New DataSet
        Dim BoxDs1 As New DataSet
        Dim dadapter As New OleDb.OleDbDataAdapter
        dadapter = New OleDb.OleDbDataAdapter
        dadapter.SelectCommand = New OleDb.OleDbCommand(BoxSql, con)
        dadapter.SelectCommand.Parameters.AddWithValue("@ShDate", DTP.Value.ToString("dd/MM/yyyy"))
        dadapter.Fill(BoxDs)
        'FillTable(BoxSql, 0, BoxDs)
        LstBox.Items.Clear()
        For h = 0 To BoxDs.Tables(0).Rows.Count - 1
            BoxData(0) = BoxDs.Tables(0).Rows(h).Item(0)
            BoxData(1) = BoxDs.Tables(0).Rows(h).Item(1)
            BoxData(2) = Math.Round(BoxDs.Tables(0).Rows(h).Item(2), 2)
            BoxData(3) = BoxDs.Tables(0).Rows(h).Item(3) & " " & BoxDs.Tables(0).Rows(h).Item(4)
            DataBox = New ListViewItem(BoxData)
            LstBox.Items.Add(DataBox)
        Next
        BoxSql = "SELECT SUM(Price) FROM Shifting  Where format(Shifting.ShDate,'dd/MM/yyyy') = @ShDate1"
        dadapter = New OleDb.OleDbDataAdapter
        dadapter.SelectCommand = New OleDb.OleDbCommand(BoxSql, con)
        dadapter.SelectCommand.Parameters.AddWithValue("@ShDate1", DTP.Value.ToString("dd/MM/yyyy"))
        dadapter.Fill(BoxDs1)
        'FillTable(BoxSql, 0, BoxDs1)
        If BoxDs1.Tables(0).Rows.Count > 0 Then
            If IsDBNull(BoxDs1.Tables(0).Rows(0).Item(0)) Then
                TxtTotalBox.Text = 0
            Else
                TxtTotalBox.Text = Math.Round(BoxDs1.Tables(0).Rows(0).Item(0), 2)
            End If
        End If
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        FrmSelect.ShowDialog()
    End Sub

    Private Sub LstBox_KeyUp(sender As Object, e As KeyEventArgs) Handles LstBox.KeyUp
        If e.KeyCode = Keys.Delete Then
            If LstBox.SelectedItems.Count <> 0 Then
                Dim Amsg = MsgBox("هل أنت متأكد من أنك تريد حذف البند حقاً", MsgBoxStyle.OkCancel)
                If Amsg = MsgBoxResult.Ok Then
                    Dim SQLSTR As String
                    SQLSTR = "Delete from Shifting Where Code = " & Val(LstBox.FocusedItem.SubItems(0).Text)
                    ExecuteSQLStmt(SQLSTR)
                    TxtTotalBox.Text = Val(TxtTotalBox.Text) - Val(LstBox.FocusedItem.SubItems(2).Text)
                    LstBox.FocusedItem.Remove()
                End If
            End If
        End If
    End Sub

    Dim CountData(3) As String
    Dim DataCount As ListViewItem
    Dim ProCountDS As New DataSet
    Dim ProDS As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSearch4.Click
        Dim ProCountSQL As String

        Dim ProSQL As String = " SELECT * From Product"

        Dim Proadapter As New OleDb.OleDbDataAdapter
        Proadapter = New OleDb.OleDbDataAdapter
        Proadapter.SelectCommand = New OleDb.OleDbCommand(ProSQL, con)
        Proadapter.Fill(ProDS)
        lstCount.Items.Clear()
        ProCountDS.Clear()
        ProCountDS.Tables.Clear()
        DTTo3.Value = DTTo3.Value.AddDays(1)
        'Select [Product].[Code], [Product].[PName], (Select Count([Trans].[PCode]) From [Trans] INNER JOIN [Orders] ON [Trans].[OCode] = [Orders].[Code] Where [Trans].[PCode] = [Product].[Code] AND [Orders].[OrDate] = Now()) As [PCount] From [Product] Order By [Product].[PName]
        ProCountSQL =
            "Select 
            Product.Code, 
            Product.PName, 
            SUM(Trans.Quantity) As PCount
            From Trans 
            INNER JOIN Product ON Trans.PCode = Product.Code 
            Where PCount <> 0 AND Format(Orders.OrDate,'yyyy-mm-dd') >= Format(#" & DTFrom3.Value & "#,'yyyy-mm-dd') And Format(Orders.OrDate,'yyyy-mm-dd') <= Format(#" & DTTo3.Value & "#,'yyyy-mm-dd')  Group By Product.PName, Product.Code" ' Where Product.Code = " & Val(ProDS.Tables(0).Rows(x).Item(0))
        Dim dadapter As New OleDb.OleDbDataAdapter
        dadapter = New OleDb.OleDbDataAdapter
        dadapter.SelectCommand = New OleDb.OleDbCommand(ProCountSQL, con)
        dadapter.Fill(ProCountDS)
        For x = 0 To ProCountDS.Tables(0).Rows.Count - 1
            If Not IsDBNull(ProCountDS.Tables(0).Rows(x).Item(2)) Then
                CountData(0) = ProCountDS.Tables(0).Rows(x).Item(0)
                CountData(1) = ProCountDS.Tables(0).Rows(x).Item(1)
                CountData(2) = ProCountDS.Tables(0).Rows(x).Item(2)
            End If

            If CountData(2) <> "0" Then
                DataCount = New ListViewItem(CountData)
                lstCount.Items.Add(DataCount)
            End If
        Next
        Chart1.Titles.Clear()
        'Chart1.Titles(0).Text = (" عدد كل سلعة تم بيعها من تاريخ " & DTFrom3.Text & " الى تاريخ " & DTTo3.Text).ToString
        With Chart1.Series(0)
            .Name = "السلع"
            .DataSource = ProCountDS.Tables(0).DefaultView
            .SetDataMembers("PName", "PCount")
        End With
        DTTo3.Value = DTTo3.Value.AddDays(-1)
    End Sub

    Private Sub BtnToXl_Click(sender As Object, e As EventArgs) Handles BtnToXl.Click
        If lstCount.Items.Count <> 0 Then
            'Export to Excel process
            Dim Excel As Object = CreateObject("Excel.Application")
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()
                Dim i As Integer = 1
                For col = 0 To ProCountDS.Tables(0).Columns.Count - 1
                    .Cells(1, i).value = ProCountDS.Tables(0).Columns(col).ColumnName
                    .Cells(1, i).EntireRow.Font.Bold = True
                    i += 1
                Next
                i = 2
                Dim j As Integer = 1
                For col = 0 To ProCountDS.Tables(0).Columns.Count - 1
                    i = 2
                    For row = 0 To ProCountDS.Tables(0).Rows.Count - 1
                        If Not IsDBNull(ProCountDS.Tables(0).Rows(row).Item(2)) Then
                            .Cells(i, j).Value = ProCountDS.Tables(0).Rows(row).ItemArray(col)
                        End If
                        i += 1
                    Next
                    j += 1
                Next
                .Application.DisplayAlerts = False
                Dim SavePath As New SaveFileDialog
                SavePath.Filter = "Excel Files (*.xls*)|*.xls"
                If SavePath.ShowDialog = DialogResult.OK Then
                    .ActiveCell.Worksheet.SaveAs(SavePath.FileName)
                End If

                .Workbooks.Close()
            End With
        Else
            MsgBox("لا يوجد بيانات لتصديرها!!")
        End If
    End Sub

End Class