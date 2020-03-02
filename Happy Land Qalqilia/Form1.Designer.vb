<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTable = New System.Windows.Forms.TextBox()
        Me.CHKOrd = New System.Windows.Forms.CheckBox()
        Me.CHKOUT = New System.Windows.Forms.CheckBox()
        Me.CHKTickets = New System.Windows.Forms.CheckBox()
        Me.BTNok = New System.Windows.Forms.Button()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.txtTic = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "عدد الطاولات"
        '
        'txtTable
        '
        Me.txtTable.Location = New System.Drawing.Point(84, 6)
        Me.txtTable.MaxLength = 2
        Me.txtTable.Name = "txtTable"
        Me.txtTable.Size = New System.Drawing.Size(90, 20)
        Me.txtTable.TabIndex = 1
        '
        'CHKOrd
        '
        Me.CHKOrd.AutoSize = True
        Me.CHKOrd.Location = New System.Drawing.Point(15, 53)
        Me.CHKOrd.Name = "CHKOrd"
        Me.CHKOrd.Size = New System.Drawing.Size(120, 17)
        Me.CHKOrd.TabIndex = 3
        Me.CHKOrd.Text = "إفراغ مبيعات المقهى"
        Me.CHKOrd.UseVisualStyleBackColor = True
        '
        'CHKOUT
        '
        Me.CHKOUT.AutoSize = True
        Me.CHKOUT.Location = New System.Drawing.Point(15, 76)
        Me.CHKOUT.Name = "CHKOUT"
        Me.CHKOUT.Size = New System.Drawing.Size(103, 17)
        Me.CHKOUT.TabIndex = 4
        Me.CHKOUT.Text = "إفراغ المصروفات"
        Me.CHKOUT.UseVisualStyleBackColor = True
        '
        'CHKTickets
        '
        Me.CHKTickets.AutoSize = True
        Me.CHKTickets.Location = New System.Drawing.Point(15, 99)
        Me.CHKTickets.Name = "CHKTickets"
        Me.CHKTickets.Size = New System.Drawing.Size(118, 17)
        Me.CHKTickets.TabIndex = 5
        Me.CHKTickets.Text = "إفراغ مبيعات التذاكر"
        Me.CHKTickets.UseVisualStyleBackColor = True
        '
        'BTNok
        '
        Me.BTNok.Location = New System.Drawing.Point(15, 138)
        Me.BTNok.Name = "BTNok"
        Me.BTNok.Size = New System.Drawing.Size(75, 23)
        Me.BTNok.TabIndex = 6
        Me.BTNok.Text = "موافق"
        Me.BTNok.UseVisualStyleBackColor = True
        '
        'BTNCancel
        '
        Me.BTNCancel.Location = New System.Drawing.Point(96, 138)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(75, 23)
        Me.BTNCancel.TabIndex = 7
        Me.BTNCancel.Text = "إغلاق"
        Me.BTNCancel.UseVisualStyleBackColor = True
        '
        'txtTic
        '
        Me.txtTic.Location = New System.Drawing.Point(84, 32)
        Me.txtTic.MaxLength = 2
        Me.txtTic.Name = "txtTic"
        Me.txtTic.Size = New System.Drawing.Size(90, 20)
        Me.txtTic.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "عدد التذاكر"
        '
        'FrmSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(179, 168)
        Me.Controls.Add(Me.txtTic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNok)
        Me.Controls.Add(Me.CHKTickets)
        Me.Controls.Add(Me.CHKOUT)
        Me.Controls.Add(Me.CHKOrd)
        Me.Controls.Add(Me.txtTable)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSet"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إعدادات"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTable As TextBox
    Friend WithEvents CHKOrd As CheckBox
    Friend WithEvents CHKOUT As CheckBox
    Friend WithEvents CHKTickets As CheckBox
    Friend WithEvents BTNok As Button
    Friend WithEvents BTNCancel As Button
    Friend WithEvents txtTic As TextBox
    Friend WithEvents Label2 As Label
End Class
