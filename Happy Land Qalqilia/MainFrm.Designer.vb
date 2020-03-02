<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblDeleg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnCRest = New System.Windows.Forms.ToolStripButton()
        Me.BtnCLand = New System.Windows.Forms.ToolStripButton()
        Me.BtnOrd = New System.Windows.Forms.ToolStripButton()
        Me.EmpBtn = New System.Windows.Forms.ToolStripButton()
        Me.BtnCat = New System.Windows.Forms.ToolStripButton()
        Me.btnprod = New System.Windows.Forms.ToolStripButton()
        Me.BtnTicket = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtp = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnReport = New System.Windows.Forms.ToolStripButton()
        Me.BtnSet = New System.Windows.Forms.ToolStripButton()
        Me.BtnChange = New System.Windows.Forms.ToolStripButton()
        Me.Btnlogout = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtEnd = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDeleg, Me.lblCode, Me.lblName})
        resources.ApplyResources(Me.StatusStrip, "StatusStrip")
        Me.StatusStrip.Name = "StatusStrip"
        '
        'lblDeleg
        '
        Me.lblDeleg.Name = "lblDeleg"
        resources.ApplyResources(Me.lblDeleg, "lblDeleg")
        '
        'lblCode
        '
        Me.lblCode.Name = "lblCode"
        resources.ApplyResources(Me.lblCode, "lblCode")
        '
        'lblName
        '
        Me.lblName.Name = "lblName"
        resources.ApplyResources(Me.lblName, "lblName")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnCRest, Me.BtnCLand, Me.BtnOrd, Me.EmpBtn, Me.BtnCat, Me.btnprod, Me.BtnTicket, Me.ToolStripSeparator1, Me.txtp, Me.ToolStripSeparator2, Me.BtnReport, Me.BtnSet, Me.BtnChange, Me.Btnlogout, Me.txtEnd, Me.ToolStripSeparator3})
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'BtnCRest
        '
        Me.BtnCRest.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCRest.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.machine
        Me.BtnCRest.Name = "BtnCRest"
        resources.ApplyResources(Me.BtnCRest, "BtnCRest")
        '
        'BtnCLand
        '
        Me.BtnCLand.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCLand.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources._26994341_352903345184422_8984049607032399088_n
        resources.ApplyResources(Me.BtnCLand, "BtnCLand")
        Me.BtnCLand.Name = "BtnCLand"
        '
        'BtnOrd
        '
        Me.BtnOrd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnOrd.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.approved_clipboard_icon_512
        Me.BtnOrd.Name = "BtnOrd"
        resources.ApplyResources(Me.BtnOrd, "BtnOrd")
        '
        'EmpBtn
        '
        Me.EmpBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EmpBtn.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.our_story_icon_03_2x
        Me.EmpBtn.Name = "EmpBtn"
        resources.ApplyResources(Me.EmpBtn, "EmpBtn")
        '
        'BtnCat
        '
        Me.BtnCat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCat.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.free_vector_icon_project_clip_art_117078_Icon_Project_clip_art_medium
        Me.BtnCat.Name = "BtnCat"
        resources.ApplyResources(Me.BtnCat, "BtnCat")
        '
        'btnprod
        '
        Me.btnprod.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnprod.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources._40223862
        Me.btnprod.Name = "btnprod"
        resources.ApplyResources(Me.btnprod, "btnprod")
        '
        'BtnTicket
        '
        Me.BtnTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnTicket.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.Tickets_icon
        Me.BtnTicket.Name = "BtnTicket"
        resources.ApplyResources(Me.BtnTicket, "BtnTicket")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'txtp
        '
        Me.txtp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtp.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtp, "txtp")
        Me.txtp.ForeColor = System.Drawing.Color.Lime
        Me.txtp.Name = "txtp"
        Me.txtp.ReadOnly = True
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'BtnReport
        '
        Me.BtnReport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnReport.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.task_report_hot
        resources.ApplyResources(Me.BtnReport, "BtnReport")
        Me.BtnReport.Name = "BtnReport"
        '
        'BtnSet
        '
        Me.BtnSet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSet.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.Settings_Folder
        resources.ApplyResources(Me.BtnSet, "BtnSet")
        Me.BtnSet.Name = "BtnSet"
        '
        'BtnChange
        '
        Me.BtnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnChange.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.change_password
        resources.ApplyResources(Me.BtnChange, "BtnChange")
        Me.BtnChange.Name = "BtnChange"
        '
        'Btnlogout
        '
        Me.Btnlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnlogout.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources.logout
        resources.ApplyResources(Me.Btnlogout, "Btnlogout")
        Me.Btnlogout.Name = "Btnlogout"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Image = Global.Happy_Land_Qalqilia.My.Resources.Resources._26994341_352903345184422_8984049607032399088_n
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'txtEnd
        '
        Me.txtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtEnd, "txtEnd")
        Me.txtEnd.ForeColor = System.Drawing.Color.Lime
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.ReadOnly = True
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'MainFrm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "MainFrm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents EmpBtn As ToolStripButton
    Friend WithEvents BtnCat As ToolStripButton
    Friend WithEvents btnprod As ToolStripButton
    Friend WithEvents BtnCRest As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents txtp As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents lblDeleg As ToolStripStatusLabel
    Friend WithEvents lblCode As ToolStripStatusLabel
    Friend WithEvents lblName As ToolStripStatusLabel
    Friend WithEvents BtnOrd As ToolStripButton
    Friend WithEvents BtnCLand As ToolStripButton
    Friend WithEvents BtnTicket As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnReport As ToolStripButton
    Friend WithEvents BtnSet As ToolStripButton
    Friend WithEvents BtnChange As ToolStripButton
    Friend WithEvents Btnlogout As ToolStripButton
    Friend WithEvents txtEnd As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
