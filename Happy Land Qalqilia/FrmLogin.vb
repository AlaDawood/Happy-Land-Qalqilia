Imports System.IO
Public Class FrmLogin

    Dim loginds As New DataSet

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If loginds.Tables(0).Rows.Count <> 0 Then
            If loginds.Tables(0).Rows(0).Item(1) = txtPass.Text Then
                MainFrm.lblCode.Text = loginds.Tables(0).Rows(0).Item(0)
                MainFrm.lblDeleg.Text = loginds.Tables(0).Rows(0).Item(2)
                MainFrm.lblName.Text = loginds.Tables(0).Rows(0).Item(3) & " " & loginds.Tables(0).Rows(0).Item(4)
                MainFrm.ToolStrip1.Enabled = True
                MainFrm.BtnCRest.Enabled = True
                MainFrm.BtnCLand.Enabled = True
                MainFrm.BtnOrd.Enabled = True
                MainFrm.BtnReport.Enabled = True
                MainFrm.BtnSet.Enabled = True
                MainFrm.BtnChange.Enabled = True
                MainFrm.Btnlogout.Text = "تسجيل الخروج"
                txtPass.Clear()
                txtUser.Clear()
                txtUser.Focus()
                Close()
            Else
                MsgBox("كلمة المرور خاطئة")
            End If
        ElseIf txtUser.Text = "Admin" And txtPass.Text = 107 Then
            MainFrm.lblCode.Text = "Admin"
            MainFrm.lblDeleg.Text = "Admin"
            MainFrm.lblName.Text = "Admin"
            MainFrm.ToolStrip1.Enabled = True
            MainFrm.BtnCRest.Enabled = False
            MainFrm.BtnCLand.Enabled = False
            MainFrm.BtnOrd.Enabled = False
            MainFrm.BtnReport.Enabled = False
            MainFrm.BtnSet.Enabled = False
            MainFrm.BtnChange.Enabled = False
            MainFrm.Btnlogout.Text = "تسجيل الخروج"
            txtPass.Clear()
            txtUser.Clear()
            txtUser.Focus()
            txtName.Clear()
            Close()
            Dispose()
        Else
            MsgBox("اسم المستخدم أو كلمة المرور خاطئة")
            txtPass.Clear()
            txtUser.Clear()
            txtUser.Focus()
            txtName.Clear()
        End If
        txtName.Clear()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainFrm.Btnlogout.Text = "تسجيل الدخول"
        Dim PathFile As String = Application.StartupPath & "\Conn.txt"
        If File.Exists(PathFile) Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(PathFile)
            ServerSTR = fileReader
        Else
            MsgBox("File Not found")
        End If
    End Sub

    Private Sub txtUser_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUser.KeyUp
        If e.KeyCode = Keys.F1 Then
            FrmConn.Show()
        End If
    End Sub

    Private Sub txtUser_LostFocus(sender As Object, e As EventArgs) Handles txtUser.LostFocus
        Dim sqllogin As String = "SELECT Code,Password,Deleg,FName,LName,SName,TName FROM Emplo WHERE Code ="
        sqllogin &= Val(txtUser.Text)
        DataNo = 2
        FillTable(sqllogin, "Emplo", loginds)
        If loginds.Tables(0).Rows.Count <> 0 Then
            txtName.Text = loginds.Tables(0).Rows(0).Item(3) & " " & loginds.Tables(0).Rows(0).Item(5) & " " & loginds.Tables(0).Rows(0).Item(6) & " " & loginds.Tables(0).Rows(0).Item(4)
        End If
    End Sub

End Class