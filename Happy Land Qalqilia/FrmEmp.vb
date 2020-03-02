Imports Microsoft.Office.Interop

Public Class FrmEmp
    Dim emp_itm(3) As String
    Dim itm_emp As ListViewItem
    Private Sub FrmEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loademp()
    End Sub
    Private Sub Loademp()
        Dim SQLString As String
        Dim Dsemp As New DataSet
        SQLString = "SELECT FName,LName,Code,Sex,Deleg FROM Emplo"
        FillTable(SQLString, "Emplo", Dsemp)
        lstemp.Items.Clear()
        For empNo = 0 To Dsemp.Tables(0).Rows.Count - 1
            If Dsemp.Tables(0).Rows.Count <> 0 Then
                emp_itm(0) = Dsemp.Tables(0).Rows(empNo).Item(0) & " " & Dsemp.Tables(0).Rows(empNo).Item(1)
                emp_itm(1) = Dsemp.Tables(0).Rows(empNo).Item(2)
                emp_itm(2) = Dsemp.Tables(0).Rows(empNo).Item(4)
                Dim im As Integer = Dsemp.Tables(0).Rows(empNo).Item(3)
                itm_emp = New ListViewItem(emp_itm, im)
                lstemp.Items.Add(itm_emp)
            End If
        Next
    End Sub

    Private Sub lstemp_MouseUp(sender As Object, e As MouseEventArgs) Handles lstemp.MouseUp
        If e.Button = MouseButtons.Right Then
            If IsNothing(lstemp.GetItemAt(e.X, e.Y)) Then
                lstemp.ContextMenuStrip = CMS1
            Else
                lstemp.ContextMenuStrip = CMS2
            End If
        End If
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        Dim frm As New frmaddemp
        frm.ShowDialog()
        Loademp()
    End Sub

    Private Sub lstemp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstemp.MouseDoubleClick
        If IsNothing(lstemp.GetItemAt(e.X, e.Y)) Then
            Exit Sub
        Else
            If e.Button = MouseButtons.Left Then
                Dim frm As New frmaddemp
                frm.txtcode.Text = lstemp.FocusedItem.SubItems(1).Text
                frm.ShowDialog()
                Loademp()
            End If
        End If
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        Dim frm As New frmaddemp
        frm.txtcode.Text = lstemp.FocusedItem.SubItems(1).Text
        frm.ShowDialog()
        Loademp()
    End Sub

    Private Sub BTNPRINT_Click(sender As Object, e As EventArgs) Handles BTNPRINT.Click
        'Dim oWord As Word.Application = CreateObject("Word.Application")
        'Dim oDoc As Word.Document
        'Dim oTable As Word.Table
        'Dim oPara1 As Word.Paragraph
        'oWord.Visible = False
        'oDoc = oWord.Documents.Add(Application.StartupPath & "\Emp Ticket.doc")
        '--------------------------------------------------------
        Dim DataDs As New DataSet
        Dim sqls As String
        EmCode = Val(lstemp.FocusedItem.SubItems(1).Text)
        sqls = "select fname,sname,tname,lname,password from emplo where code =" & EmCode
        FillTable(sqls, "Emplo", DataDs)
        SiNo = 1
        Billfrm.ShowDialog()
        '  oTable = oWord.ActiveDocument.Tables(1)
        '  oTable.Cell(1, 1).Range.Text = "الاسم: " & DataDs.Tables(0).Rows(0).Item(0) & " " & DataDs.Tables(0).Rows(0).Item(1) & " " & DataDs.Tables(0).Rows(0).Item(2) & " " & DataDs.Tables(0).Rows(0).Item(3)
        '  oTable.Cell(2, 1).Range.Text = "الكود: " & lstemp.FocusedItem.SubItems(1).Text
        '  oTable.Cell(3, 1).Range.Text = "كلمة المرور: " & DataDs.Tables(0).Rows(0).Item(4)
        '  oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        '  oPara1.Range.Font.Size = 5
        '  oPara1.Range.Text = "برمجة علاء داود---0569865185"
        '  oPara1.Format.SpaceAfter = 6
        '  oPara1.Range.InsertParagraphAfter()
        '  '-------------------------------------------------------
        '  oDoc.PrintOut(Background:=True,
        'Append:=False,
        'Range:=Word.WdPrintOutRange.wdPrintCurrentPage,
        'Item:=Word.WdPrintOutItem.wdPrintDocumentContent,
        'Copies:="1",
        'Pages:="1",
        'PageType:=Word.WdPrintOutPages.wdPrintAllPages,
        'PrintToFile:=False,
        'Collate:=True,
        'ManualDuplexPrint:=False)
        '  oDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
        '  oWord.Quit()
    End Sub

    Private Sub FrmEmp_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MainFrm.PictureBox1.Visible = True
    End Sub
End Class
