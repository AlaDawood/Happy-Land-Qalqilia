Imports System.ComponentModel
Imports System.Data.OleDb

Public Class FrmCRest
    Private Sub FrmCRest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtable()
        SumTotal()
        BtnPrint.Visible = False
    End Sub
    Private Sub TCallBack()
        Dim SqlClose As String
        Dim CloseDs As New DataSet
        Dim Maxi As Integer
        SqlClose = "Select Max(ID) From Shifting"
        FillTable(SqlClose, "Shifting", CloseDs)
        If IsDBNull(CloseDs.Tables(0).Rows(0).Item(0)) Then
            Maxi = 0
        Else
            Maxi = Val(CloseDs.Tables(0).Rows(0).Item(0)) + 1
        End If
        SqlClose = "Insert into Shifting (ShDate, EmpCode, Price, Code) Values ('" & Date.Now.ToString("yyyy/MM/dd HH:mm:ss") & "'," & Val(MainFrm.lblCode.Text) & "," & Val(MainFrm.txtEnd.Text) & "," & (Val(Strings.Right(Now.Year, 2)) & Maxi) & ")"
        ExecuteSQLStmt(SqlClose)
        Dim Sql1 As String
        Sql1 = "Update Orders Set Status = 1 Where Status = 0 And EmpCode = " & Val(MainFrm.lblCode.Text) & " And Format(OrDate, 'dd/MM/yyyy') = @p1"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Using cmd1 = New OleDbCommand(Sql1, con)
            cmd1.Parameters.AddWithValue("@p1", Date.Now.ToString("dd/MM/yyyy"))
            cmd1.ExecuteNonQuery()
        End Using
        con.Close()
        'ExecuteSQLStmt(Sql1)
        Dim Sql2 As String
        Sql2 = "Update TicketPaid Set status = 1 Where status = 0 And TEmp =" & Val(MainFrm.lblCode.Text) & " And Format(TDate, 'dd/MM/yyyy') = @p2"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Using cmd1 = New OleDbCommand(Sql2, con)
            cmd1.Parameters.AddWithValue("@p2", Date.Now.ToString("dd/MM/yyyy"))
            cmd1.ExecuteNonQuery()
        End Using
        con.Close()
        'ExecuteSQLStmt(Sql2)
        MsgBox("تم اغلاق الجلسة للموظف  " & MainFrm.lblName.Text)
        MainFrm.txtEnd.Text = 0
        CloseDs.Clear()
        CloseDs.Dispose()
    End Sub
    'Programmed By Ala' Khalid Dawood
    'Programmar & Nurse
    Private Sub loadtable()
        Dim sqltable As String = "Select * from Settings"
        Dim setds As New DataSet
        FillTable(sqltable, "Settings", setds)
        lstTable.Items.Clear()
        Dim tableno As Integer = setds.Tables(0).Rows(0).Item(1)
        For x = 1 To tableno
            Dim lstv As ListViewItem
            lstv = New ListViewItem(Str(x), x - 1)
            lstTable.Items.Add(lstv)
        Next
    End Sub
    Dim cat_itm(2) As String
    Dim itm_cat As ListViewItem
    Private Sub Loadcat()
        Dim SQLString As String
        Dim Dscat As New DataSet
        SQLString = "SELECT Name,Code FROM Category"
        FillTable(SQLString, "Category", Dscat)
        lstcat.Items.Clear()
        For empNo = 0 To Dscat.Tables(0).Rows.Count - 1
            If Dscat.Tables(0).Rows.Count <> 0 Then
                cat_itm(0) = Dscat.Tables(0).Rows(empNo).Item(0)
                cat_itm(1) = Dscat.Tables(0).Rows(empNo).Item(1)
                itm_cat = New ListViewItem(cat_itm, 0)
                lstcat.Items.Add(itm_cat)
            End If
        Next
        Dscat.Clear()
        Dscat.Dispose()
    End Sub
    Dim prod_itm(3) As String
    Dim itm_prod As ListViewItem
    Private Sub Loadprod()
        lstprod.Items.Clear()
        '---------------------------------------------
        Dim SQLString As String
        Dim Dsprod As New DataSet
        SQLString = "SELECT PName,Code,Price,CCode FROM Product Where CCode = " & Int(lstcat.FocusedItem.SubItems(1).Text)
        FillTable(SQLString, "Product", Dsprod)
        For prodNo = 0 To Dsprod.Tables(0).Rows.Count - 1
            If Dsprod.Tables(0).Rows.Count <> 0 Then
                prod_itm(0) = Dsprod.Tables(0).Rows(prodNo).Item(0)
                prod_itm(1) = Dsprod.Tables(0).Rows(prodNo).Item(1)
                prod_itm(2) = Dsprod.Tables(0).Rows(prodNo).Item(2)
                itm_prod = New ListViewItem(prod_itm, 0)
                lstprod.Items.Add(itm_prod)
            End If
        Next
        Dsprod.Clear()
        Dsprod.Dispose()
    End Sub
    Private Sub lstcat_MouseUp(sender As Object, e As MouseEventArgs) Handles lstcat.MouseUp
        If e.Button = MouseButtons.Left Then
            If IsNothing(lstcat.GetItemAt(e.X, e.Y)) Then
                lstprod.Items.Clear()

            Else
                Loadprod()

            End If
        End If
    End Sub

    Private Sub lstTable_MouseUp(sender As Object, e As MouseEventArgs) Handles lstTable.MouseUp
        If e.Button = MouseButtons.Left Then
            If IsNothing(lstTable.GetItemAt(e.X, e.Y)) Then
                lstcat.Items.Clear()
                lstprod.Items.Clear()
                BtnOrd.Enabled = False
            Else
                Loadcat()
                BtnOrd.Enabled = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkdiscount.CheckedChanged
        txtdiscount.Enabled = chkdiscount.CheckState
        If txtdiscount.Enabled = True Then
            txtdiscount.Focus()
        End If
    End Sub
    Private Sub Calculate()
        Dim PriceAfterDiscount As Double
        Dim DiscountCost As Double
        If chkdiscount.CheckState = True Then
            DiscountCost = Val(MainFrm.txtp.Text) * Val(txtdiscount.Text)
            PriceAfterDiscount = Val(MainFrm.txtp.Text) - DiscountCost
        End If
        MainFrm.txtp.Clear()
        For c = 0 To lstord.Items.Count - 1
            lstord.Items(c).SubItems(7).Text = Val(lstord.Items(c).SubItems(3).Text) * Val(lstord.Items(c).SubItems(4).Text)
            If chkdiscount.CheckState = False Then
                MainFrm.txtp.Text = Val(MainFrm.txtp.Text) + Val(lstord.Items(c).SubItems(7).Text)
            Else
                Dim x As Double = Val(MainFrm.txtp.Text) + Val(lstord.Items(c).SubItems(7).Text)
                MainFrm.txtp.Text = x
            End If
        Next
        If chkdiscount.CheckState = True Then
            MainFrm.txtp.Text = Math.Round(Val(MainFrm.txtp.Text) - PriceAfterDiscount, 1)
        End If
    End Sub
    Private Sub lstprod_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstprod.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            If IsNothing(lstprod.GetItemAt(e.X, e.Y)) Then
                Exit Sub
            Else
                If lstord.Items.Count <> 0 Then
                    For s = 0 To lstord.Items.Count - 1
                        If (lstord.Items(s).SubItems(1).Text = lstprod.FocusedItem.SubItems(1).Text) And (lstord.Items(s).SubItems(6).Text = lstTable.FocusedItem.SubItems(0).Text) Then
                            lstord.Items(s).SubItems(3).Text = Int(lstord.Items(s).SubItems(3).Text) + 1
                            Calculate()
                            Exit Sub
                        End If
                    Next

                    Dim arr As String() = New String(7) {}
                    Dim itm As ListViewItem
                    'add items to ListView
                    arr(0) = ""
                    arr(1) = lstprod.FocusedItem.SubItems(1).Text
                    arr(2) = lstprod.FocusedItem.SubItems(0).Text
                    arr(3) = 1
                    arr(4) = lstprod.FocusedItem.SubItems(2).Text
                    arr(5) = lstcat.FocusedItem.SubItems(1).Text
                    arr(6) = lstTable.FocusedItem.SubItems(0).Text
                    itm = New ListViewItem(arr)
                    lstord.Items.Add(itm)
                Else
                    Dim arr As String() = New String(7) {}
                    Dim itm As ListViewItem
                    'add items to ListView
                    arr(0) = ""
                    arr(1) = lstprod.FocusedItem.SubItems(1).Text
                    arr(2) = lstprod.FocusedItem.SubItems(0).Text
                    arr(3) = 1
                    arr(4) = lstprod.FocusedItem.SubItems(2).Text
                    arr(5) = lstcat.FocusedItem.SubItems(1).Text
                    arr(6) = lstTable.FocusedItem.SubItems(0).Text
                    itm = New ListViewItem(arr)
                    lstord.Items.Add(itm)
                End If

            End If
        End If
        Calculate()
    End Sub

    Private Sub lstord_KeyUp(sender As Object, e As KeyEventArgs) Handles lstord.KeyUp
        If e.KeyCode = Keys.Delete Then
            If lstord.SelectedItems.Count <> 0 Then
                If lstord.FocusedItem.SubItems(0).Text = "" Then
                    If lstord.FocusedItem.SubItems(3).Text <> 1 Then
                        lstord.FocusedItem.SubItems(3).Text = Val(lstord.FocusedItem.SubItems(3).Text) - 1
                    Else
                        lstord.FocusedItem.Remove()
                    End If
                Else
                    If lstord.FocusedItem.SubItems(3).Text <> 1 Then
                        lstord.FocusedItem.SubItems(3).Text = Val(lstord.FocusedItem.SubItems(3).Text) - 1
                        Dim DelSql As String = "Update Trans SET Quantity =" & Val(lstord.FocusedItem.SubItems(3).Text) & " Where TCode = " & Int(lstord.FocusedItem.SubItems(0).Text)
                        ExecuteSQLStmt(DelSql)
                    Else
                        Dim DelSql As String = "Delete From Trans Where TCode = " & Val(lstord.FocusedItem.SubItems(0).Text)
                        ExecuteSQLStmt(DelSql)
                        lstord.FocusedItem.Remove()
                    End If
                End If
            End If
            Calculate()
        ElseIf e.KeyCode = Keys.Escape Then
            If lstord.SelectedItems.Count <> 0 Then
                If lstord.FocusedItem.SubItems(0).Text <> "" Then
                    Dim DelSql As String = "Delete From Trans Where TCode = " & Val(lstord.FocusedItem.SubItems(0).Text)
                    ExecuteSQLStmt(DelSql)
                    lstord.FocusedItem.Remove()
                Else
                    lstord.FocusedItem.Remove()
                End If
            End If
            Calculate()
        End If

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If lstord.Items.Count <> 0 Then
            Dim maxsql As String = "Select Max(ID) As MID From Trans"
            Dim maxds As New DataSet
            FillTable(maxsql, "Trans", maxds)
            Dim arr(8) As Double
            Dim AddSql As String

            For i = 0 To lstord.Items.Count - 1
                If lstord.Items(i).SubItems(0).Text = "" Then
                    FillTable(maxsql, "Trans", maxds)
                    If IsDBNull(maxds.Tables(0).Rows(0).Item(0)) Then
                        arr(0) = Val(Strings.Right(Now.Year, 2) & 0)
                    Else
                        arr(0) = Val(Strings.Right(Now.Year, 2)) & Val(maxds.Tables(0).Rows(0).Item(0) + 1)
                    End If
                    arr(1) = Val(lstord.Items(i).SubItems(1).Text)
                    arr(2) = Val(lstord.Items(i).SubItems(5).Text)
                    arr(3) = Val(lstord.Items(i).SubItems(6).Text)
                    arr(4) = Math.Round(Val(lstord.Items(i).SubItems(3).Text), 2)
                    arr(5) = Val(lstord.Items(i).SubItems(4).Text)
                    arr(6) = Val(lstord.Items(i).SubItems(7).Text)
                    arr(7) = 1
                    AddSql = "INSERT INTO Trans ( TCode , PCode , CCode , TableN , Quantity , Price , Cost , Status , OCode ) VALUES (" & arr(0) & "," & arr(1) & "," & Val(arr(2)) & "," & arr(3) & "," & arr(4) & "," & arr(5) & "," & arr(6) & "," & arr(7) & ",0)"
                    ExecuteSQLStmt(AddSql)
                Else
                    AddSql = "Update Trans SET Quantity = " & Val(lstord.Items(i).SubItems(3).Text) & ", Price = " & Val(lstord.Items(i).SubItems(4).Text) & ", Cost = " & Val(lstord.Items(i).SubItems(7).Text) & " Where TCode = " & Val(lstord.Items(i).SubItems(0).Text)
                    ExecuteSQLStmt(AddSql)
                End If
            Next
            lstprod.Items.Clear()
            lstcat.Items.Clear()
            lstord.Items.Clear()
            MainFrm.txtp.Text = 0
            Calculate()
            btnTrans.Enabled = False
            btnto.Enabled = False
            chkdiscount.Enabled = False
            maxds.Clear()
            maxds.Dispose()
        Else
            MsgBox("لا يوجد طلبات لاضافتها")
        End If

    End Sub
    Private Sub loadord()
        lstord.Items.Clear()
        Dim Sqlord As String
        Dim ordDs As New DataSet
        Sqlord = "Select Trans.TCode,Trans.PCode,Product.PName,Trans.CCode,Trans.TableN,Trans.Quantity,Trans.Price,Trans.Cost From Trans, Product Where Trans.PCode = Product.Code And Trans.status = 1 And Trans.TableN = " & Int(lstTable.FocusedItem.SubItems(0).Text)
        FillTable(Sqlord, "Trans", ordDs)
        Dim arr As String() = New String(8) {}
        Dim itm As ListViewItem
        For x = 0 To ordDs.Tables(0).Rows.Count - 1
            arr(0) = ordDs.Tables(0).Rows(x).Item(0)
            arr(1) = ordDs.Tables(0).Rows(x).Item(1)
            arr(2) = ordDs.Tables(0).Rows(x).Item(2)
            arr(5) = ordDs.Tables(0).Rows(x).Item(3)
            arr(6) = ordDs.Tables(0).Rows(x).Item(4)
            arr(3) = ordDs.Tables(0).Rows(x).Item(5)
            arr(4) = Math.Round(ordDs.Tables(0).Rows(x).Item(6), 2)
            arr(7) = ordDs.Tables(0).Rows(x).Item(7)
            itm = New ListViewItem(arr)
            lstord.Items.Add(itm)
        Next
        ordDs.Clear()
        ordDs.Dispose()
    End Sub

    Private Sub BtnOrd_Click(sender As Object, e As EventArgs) Handles BtnOrd.Click
        loadord()
        Calculate()
        If lstord.Items.Count <> 0 Then
            btnto.Enabled = True
            chkdiscount.Enabled = True
            btnTrans.Enabled = True
            BtnPrint.Enabled = True
        End If
    End Sub
    '*******************************************************************************

    Dim TrCode As Integer
    Dim PPrice As Double
    Dim DDiscount As Double
    Private DDDS As New DataSet
    Private Sub loadbill()
        Dim DSQL As String
        DSQL = "SELECT Trans.TableN , Orders.OrDate , Product.PName , Trans.Quantity , Trans.Price , Trans.Cost FROM ( Trans INNER JOIN Orders ON Trans.OCode = Orders.Code ) INNER JOIN Product ON Trans.PCode = Product.Code WHERE Trans.OCode = " & OrCode & " And Trans.Status = 2 AND Trans.TableN = " & Val(lstTable.FocusedItem.SubItems(0).Text)
        FillTable(DSQL, "Trans", DDDS)
    End Sub
    Private Sub btnto_Click(sender As Object, e As EventArgs) Handles btnto.Click
        Print_Bill()
    End Sub

    Private Sub Print_Bill()
        Dim ordsql As String
        Dim maxsql As String
        Dim maxds As New DataSet
        maxsql = "SELECT MAX(ID) FROM Orders"
        FillTable(maxsql, "Orders", maxds)
        If IsDBNull(maxds.Tables(0).Rows(0).Item(0)) Then
            OrCode = Val(Strings.Right(Now.Year, 2)) & Val(Now.Month) & 0
        Else
            OrCode = Val(Strings.Right(Now.Year, 2)) & Val(Now.Month) & (Val(maxds.Tables(0).Rows(0).Item(0)) + 1)
        End If
        If lstTable.SelectedItems.Count <> 0 Then
            PPrice = Val(MainFrm.txtp.Text)
            DDiscount = Val(txtdiscount.Text)
            ordsql = "Insert Into Orders ( OrDate , price , Code , Discount , empCode , TableN , Status ) Values ('" & Date.Now.ToString("yyyy/MM/dd HH:mm:ss") & "'," & PPrice & "," & OrCode & "," & (PPrice * DDiscount) / 100 & "," & Val(MainFrm.lblCode.Text) & "," & Val(lstTable.FocusedItem.SubItems(0).Text) & ",0)"
            ExecuteSQLStmt(ordsql)
            ordsql = "Update trans Set Status = 2 , OCode =" & Val(OrCode) & " Where Status = 1 And TableN = " & Val(lstTable.FocusedItem.SubItems(0).Text)
            ExecuteSQLStmt(ordsql)
            ordsql = "Delete From Trans Where Status = 0 And TableN = " & Val(lstTable.FocusedItem.SubItems(0).Text)
            ExecuteSQLStmt(ordsql)
            loadbill()
            lstord.Items.Clear()
            MainFrm.txtp.Text = 0
            txtdiscount.Clear()
            chkdiscount.Checked = False
            chkdiscount.Enabled = False
            btnto.Enabled = False
            btnTrans.Enabled = False
            SumTotal()
            SiNo = 0
            Billfrm.ShowDialog()
        Else
            MsgBox("الرجاء قم باختيار الطاولة التي تود اقفالها")
        End If
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
        SQLTicSum = "Select sum(TPrice - TDiscount) AS Total From TicketPaid Where Status = 0 And TEmp = " & Val(MainFrm.lblCode.Text) & " And format(TDate, 'dd/MM/yyyy') = @TDate"
        dadapter.SelectCommand = New OleDb.OleDbCommand(SQLTicSum, con)
        dadapter.SelectCommand.Parameters.AddWithValue("@TDate", Date.Now.ToString("dd/MM/yyyy"))
        dadapter.Fill(ticSumDs)
        If IsDBNull(ticSumDs.Tables(0).Rows(0).Item(0)) Then
        Else
            TotalDay = TotalDay + Val(ticSumDs.Tables(0).Rows(0).Item(0))
        End If
        MainFrm.txtEnd.Text = TotalDay
    End Sub
    Private Sub lstTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTable.SelectedIndexChanged
        lstprod.Items.Clear()
        lstord.Items.Clear()
        btnto.Enabled = False
        btnTrans.Enabled = False
        chkdiscount.Enabled = False
        BtnPrint.Enabled = False
        MainFrm.txtp.Text = 0
    End Sub

    Private Sub FrmCRest_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainFrm.txtp.Text = 0
        MainFrm.PictureBox1.Visible = True
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        frmtrans.ShowDialog()

    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        TCallBack()
    End Sub


End Class