Imports System.ComponentModel

Public Class FrmaddChild
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Dim SQLSTRING As String
        If txtTic.Text = "" Then
            txtTic.Text = 0
        End If
        Dim emptyTextBoxes =
    From txt In Me.Controls.OfType(Of TextBox)()
    Where txt.Text.Length = 0 And txt.Name <> "txtcode"
    Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("الرجاء ملئ الفراغات: {0}",
                    String.Join(",", emptyTextBoxes)))
            Exit Sub
        End If
        If txtcode.Text <> "" Then
            SQLSTRING = "Update Kids SET KNAME = @e1 WHERE KCODE = " & Int(txtcode.Text) & ";"
            Dim dadapter As New OleDb.OleDbDataAdapter
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            dadapter = New OleDb.OleDbDataAdapter With {
                .UpdateCommand = New OleDb.OleDbCommand(SQLSTRING, con)
            }
            dadapter.UpdateCommand.Parameters.AddWithValue("@e1", txtName.Text)
            dadapter.UpdateCommand.ExecuteNonQuery()
            con.Close()
            'ExecuteSQLStmt(SQLSTRING)
            FrmHappyLand.LoadKids()
            MsgBox("تم تعديل البيانات بنجاح")
            KidsCode = 0
            Close()
        Else
            Dim SQLSTRING1 As String = "INSERT INTO Kids(KName,KCode,TicketsN) VALUES(@e1,@e2,0)"
            Dim dadapter As New OleDb.OleDbDataAdapter
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dadapter = New OleDb.OleDbDataAdapter With {
                .InsertCommand = New OleDb.OleDbCommand(SQLSTRING1, con)
            }
            dadapter.InsertCommand.Parameters.AddWithValue("@e1", txtName.Text.ToString)
            dadapter.InsertCommand.Parameters.AddWithValue("@e2", Int(Strings.Right(Now.Year, 2) & (FrmHappyLand.lstLand.Items.Count + 1)))
            dadapter.InsertCommand.ExecuteNonQuery()
            con.Close()
            'ExecuteSQLStmt(SQLSTRING)
            FrmHappyLand.LoadKids()
            MsgBox("تم اضافة بيانات الموظف بنجاح..")
            KidsCode = 0
            Close()
        End If
    End Sub

    Private Sub FrmaddChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If KidsCode <> 0 Then
            txtcode.Text = FrmHappyLand.lstLand.FocusedItem.SubItems(2).Text
        End If
        If txtcode.Text <> "" Then LoadKids()
    End Sub
    Private Sub LoadKids()
        Dim SQLString As String
        Dim DsKids As New DataSet
        SQLString = "SELECT * FROM Kids WHERE KCODE =" & Int(txtcode.Text)
        FillTable(SQLString, "Kids", DsKids)
        For empNo = 0 To DsKids.Tables(0).Rows.Count - 1
            If DsKids.Tables(0).Rows.Count <> 0 Then
                txtcode.Text = DsKids.Tables(0).Rows(0).Item(2)
                txtName.Text = DsKids.Tables(0).Rows(0).Item(1)
                txtTic.Text = DsKids.Tables(0).Rows(0).Item(3)
            End If
        Next
    End Sub

    Private Sub FrmaddChild_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        KidsCode = 0
    End Sub
End Class