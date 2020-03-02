<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddemp
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
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.ComboBox()
        Me.txtdeleg = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.txttname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.CHKSHOW = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(122, 12)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.ReadOnly = True
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 100
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(122, 38)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(56, 20)
        Me.txtfname.TabIndex = 0
        '
        'txtmobile
        '
        Me.txtmobile.Location = New System.Drawing.Point(122, 64)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(242, 20)
        Me.txtmobile.TabIndex = 4
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(122, 90)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(242, 20)
        Me.txtpass.TabIndex = 5
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtsex
        '
        Me.txtsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtsex.FormattingEnabled = True
        Me.txtsex.Items.AddRange(New Object() {"أنثى", "ذكر"})
        Me.txtsex.Location = New System.Drawing.Point(122, 116)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.Size = New System.Drawing.Size(242, 21)
        Me.txtsex.TabIndex = 6
        '
        'txtdeleg
        '
        Me.txtdeleg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtdeleg.FormattingEnabled = True
        Me.txtdeleg.Items.AddRange(New Object() {"مدير", "كاشير", "المطبخ", "كاشير عام"})
        Me.txtdeleg.Location = New System.Drawing.Point(122, 143)
        Me.txtdeleg.Name = "txtdeleg"
        Me.txtdeleg.Size = New System.Drawing.Size(242, 21)
        Me.txtdeleg.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "الكود"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "الاسم"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "الجوال"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "كلمة المرور"
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(184, 38)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(56, 20)
        Me.txtsname.TabIndex = 1
        '
        'txttname
        '
        Me.txttname.Location = New System.Drawing.Point(246, 38)
        Me.txttname.Name = "txttname"
        Me.txttname.Size = New System.Drawing.Size(56, 20)
        Me.txttname.TabIndex = 2
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(308, 38)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(56, 20)
        Me.txtlname.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "الجنس"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "الصلاحية"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(122, 185)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 101
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(203, 185)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 102
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'CHKSHOW
        '
        Me.CHKSHOW.AutoSize = True
        Me.CHKSHOW.Checked = True
        Me.CHKSHOW.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKSHOW.Location = New System.Drawing.Point(101, 93)
        Me.CHKSHOW.Name = "CHKSHOW"
        Me.CHKSHOW.Size = New System.Drawing.Size(15, 14)
        Me.CHKSHOW.TabIndex = 103
        Me.CHKSHOW.UseVisualStyleBackColor = True
        '
        'frmaddemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 229)
        Me.Controls.Add(Me.CHKSHOW)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txttname)
        Me.Controls.Add(Me.txtsname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdeleg)
        Me.Controls.Add(Me.txtsex)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtmobile)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmaddemp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيانات الموظف"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcode As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtsex As ComboBox
    Friend WithEvents txtdeleg As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsname As TextBox
    Friend WithEvents txttname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents CHKSHOW As CheckBox
End Class
