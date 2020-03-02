Public Class frmaddemp
    Private Sub frmaddemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdeleg.SelectedIndex = 0
        txtsex.SelectedIndex = 0
        If txtcode.Text <> "" Then Loademp()

    End Sub
    Private Sub Loademp()
        Dim SQLString As String
        Dim Dsemp As New DataSet
        SQLString = "SELECT * FROM Emplo WHERE CODE =" & Int(txtcode.Text)
        FillTable(SQLString, "Emplo", Dsemp)
        For empNo = 0 To Dsemp.Tables(0).Rows.Count - 1
            If Dsemp.Tables(0).Rows.Count <> 0 Then
                txtcode.Text = Dsemp.Tables(0).Rows(0).Item(5)
                txtfname.Text = Dsemp.Tables(0).Rows(0).Item(1)
                txtsname.Text = Dsemp.Tables(0).Rows(0).Item(2)
                txttname.Text = Dsemp.Tables(0).Rows(0).Item(3)
                txtlname.Text = Dsemp.Tables(0).Rows(0).Item(4)
                txtpass.Text = Dsemp.Tables(0).Rows(0).Item(6)
                txtmobile.Text = Dsemp.Tables(0).Rows(0).Item(8)
                txtsex.SelectedIndex = Dsemp.Tables(0).Rows(0).Item(7)
                txtdeleg.SelectedIndex = Dsemp.Tables(0).Rows(0).Item(9)
            End If
        Next
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub CHKSHOW_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSHOW.CheckedChanged
        txtpass.UseSystemPasswordChar = CHKSHOW.CheckState
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim SQLSTRING As String
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
            SQLSTRING = "Update Emplo SET FNAME = @e1, SNAME = @e2, TNAME = @e3, LNAME = @e4, [PASSWORD] = @e5, SEX = @e6, MOBILE = @e7, DELEG = @e8 WHERE CODE = " & Int(txtcode.Text) & ";"
            Dim dadapter As New OleDb.OleDbDataAdapter
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            dadapter = New OleDb.OleDbDataAdapter With {
                .UpdateCommand = New OleDb.OleDbCommand(SQLSTRING, con)
            }
            dadapter.UpdateCommand.Parameters.AddWithValue("@e1", txtfname.Text)
            dadapter.UpdateCommand.Parameters.AddWithValue("@e2", txtsname.Text)
            dadapter.UpdateCommand.Parameters.AddWithValue("@e3", txttname.Text)
            dadapter.UpdateCommand.Parameters.AddWithValue("@e4", txtlname.Text)
            dadapter.UpdateCommand.Parameters.AddWithValue("@e5", txtpass.Text)
            dadapter.UpdateCommand.Parameters.AddWithValue("@e6", txtsex.SelectedIndex)
            dadapter.UpdateCommand.Parameters.AddWithValue("@e7", txtmobile.Text)
            dadapter.UpdateCommand.Parameters.AddWithValue("@e8", txtdeleg.SelectedIndex)
            dadapter.UpdateCommand.ExecuteNonQuery()
            con.Close()
            'ExecuteSQLStmt(SQLSTRING)
            MsgBox("تم تعديل البيانات بنجاح")
            Close()
        Else
            Dim SQLSTRING1 As String = "INSERT INTO Emplo(FName,SName,TName,LName,Code,[Password],Sex,Mobile,Deleg) VALUES(@e1,@e2,@e3,@e4,@e9,@e5,@e6,@e7,@e8)"
            Dim dadapter As New OleDb.OleDbDataAdapter
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            dadapter = New OleDb.OleDbDataAdapter With {
                .InsertCommand = New OleDb.OleDbCommand(SQLSTRING1, con)
            }
            dadapter.InsertCommand.Parameters.AddWithValue("@e1", txtfname.Text.ToString)
            dadapter.InsertCommand.Parameters.AddWithValue("@e2", txtsname.Text.ToString)
            dadapter.InsertCommand.Parameters.AddWithValue("@e3", txttname.Text.ToString)
            dadapter.InsertCommand.Parameters.AddWithValue("@e4", txtlname.Text.ToString)
            dadapter.InsertCommand.Parameters.AddWithValue("@e9", Int(Strings.Right(Now.Year, 2) & (FrmEmp.lstemp.Items.Count + 1)))
            dadapter.InsertCommand.Parameters.AddWithValue("@e5", txtpass.Text.ToString)
            dadapter.InsertCommand.Parameters.AddWithValue("@e6", Val(txtsex.SelectedIndex))
            dadapter.InsertCommand.Parameters.AddWithValue("@e7", txtmobile.Text.ToString)
            dadapter.InsertCommand.Parameters.AddWithValue("@e8", Val(txtdeleg.SelectedIndex))
            dadapter.InsertCommand.ExecuteNonQuery()
            con.Close()
            'ExecuteSQLStmt(SQLSTRING)
            MsgBox("تم اضافة بيانات الموظف بنجاح..")
            Close()
        End If
    End Sub
End Class