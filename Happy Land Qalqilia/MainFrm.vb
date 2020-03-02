Imports System.IO

Public Class MainFrm
    Private Sub EmpBtn_Click(sender As Object, e As EventArgs) Handles EmpBtn.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        PictureBox1.Visible = False
        FrmEmp.MdiParent = Me
        FrmEmp.Show()
    End Sub

    Private Sub BtnCat_Click(sender As Object, e As EventArgs) Handles BtnCat.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        PictureBox1.Visible = False
        FrmCat.MdiParent = Me
        FrmCat.Show()
    End Sub

    Private Sub btnprod_Click(sender As Object, e As EventArgs) Handles btnprod.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        PictureBox1.Visible = False
        Frmprod.MdiParent = Me
        Frmprod.Show()
    End Sub

    Private Sub BtnCRest_Click(sender As Object, e As EventArgs) Handles BtnCRest.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        PictureBox1.Visible = False
        FrmCRest.MdiParent = Me
        FrmCRest.Show()
    End Sub

    Private Sub BtnOrd_Click(sender As Object, e As EventArgs) Handles BtnOrd.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        PictureBox1.Visible = False
        FrmOrders.MdiParent = Me
        FrmOrders.Show()
    End Sub

    Private Sub BtnCLand_Click(sender As Object, e As EventArgs) Handles BtnCLand.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        TCNo = 0
        PictureBox1.Visible = False
        FrmHappyLand.MdiParent = Me
        FrmHappyLand.Show()
    End Sub

    Private Sub BtnTicket_Click(sender As Object, e As EventArgs) Handles BtnTicket.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        PictureBox1.Visible = False
        FrmTicket.MdiParent = Me
        FrmTicket.Show()
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        PictureBox1.Visible = False
        frmReport.MdiParent = Me
        frmReport.Show()
    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs) Handles BtnSet.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        FrmSet.ShowDialog()
    End Sub

    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles BtnChange.Click
        If lblCode.Text <> "" Then
            FrmChange.ShowDialog()
        Else
            MsgBox("أنت في الحساب الرئيسي لا يمكنك تغيير كلمة المرور")
        End If
    End Sub

    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click
        For i = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).Close()
        Next
        ToolStrip1.Enabled = False
        FrmLogin.ShowDialog()
    End Sub

    Private Sub lblDeleg_TextChanged(sender As Object, e As EventArgs) Handles lblDeleg.TextChanged
        If lblDeleg.Text = "0" Then
            BtnCRest.Visible = True
            BtnCLand.Visible = True
            BtnChange.Visible = True
            Btnlogout.Visible = True
            EmpBtn.Visible = True
            BtnReport.Visible = True
            BtnSet.Visible = True
            btnprod.Visible = True
            BtnTicket.Visible = True
            BtnOrd.Visible = False
            BtnCat.Visible = True
        ElseIf lblDeleg.Text = "1" Then
            BtnCRest.Visible = True
            BtnCLand.Visible = True
            BtnChange.Visible = True
            Btnlogout.Visible = True
            EmpBtn.Visible = False
            BtnReport.Visible = False
            BtnSet.Visible = False
            btnprod.Visible = False
            BtnTicket.Visible = False
            BtnOrd.Visible = False
            BtnCat.Visible = False
        ElseIf lblDeleg.Text = "2" Then
            BtnOrd.Visible = False
            BtnChange.Visible = True
            Btnlogout.Visible = True
            EmpBtn.Visible = False
            BtnReport.Visible = False
            BtnSet.Visible = False
            btnprod.Visible = False
            BtnTicket.Visible = False
            BtnCRest.Visible = False
            BtnCat.Visible = False
            BtnCLand.Visible = False
        ElseIf lblDeleg.Text = "3" Then
            BtnCRest.Visible = True
            BtnCLand.Visible = True
            BtnChange.Visible = True
            Btnlogout.Visible = True
            EmpBtn.Visible = False
            BtnReport.Visible = False
            BtnSet.Visible = False
            btnprod.Visible = False
            BtnTicket.Visible = False
            BtnOrd.Visible = False
            BtnCat.Visible = False
        End If
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim directoryName As String = Application.StartupPath & "\Bills"
        If Directory.Exists(directoryName) Then
            For Each deleteFile In Directory.GetFiles(directoryName, "*.emf", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next
        Else
            Directory.CreateDirectory(directoryName)
        End If
        DataNo = 2
        FrmLogin.ShowDialog()
    End Sub

    Private Sub MainFrm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmLogin.Close()
    End Sub
End Class
