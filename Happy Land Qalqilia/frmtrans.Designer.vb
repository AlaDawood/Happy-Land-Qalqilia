<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtrans
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
        Me.comfrom = New System.Windows.Forms.ComboBox()
        Me.comto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btntrans = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'comfrom
        '
        Me.comfrom.FormattingEnabled = True
        Me.comfrom.Location = New System.Drawing.Point(50, 12)
        Me.comfrom.Name = "comfrom"
        Me.comfrom.Size = New System.Drawing.Size(219, 21)
        Me.comfrom.TabIndex = 0
        '
        'comto
        '
        Me.comto.FormattingEnabled = True
        Me.comto.Location = New System.Drawing.Point(50, 39)
        Me.comto.Name = "comto"
        Me.comto.Size = New System.Drawing.Size(219, 21)
        Me.comto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "من"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "الى"
        '
        'btntrans
        '
        Me.btntrans.Location = New System.Drawing.Point(50, 82)
        Me.btntrans.Name = "btntrans"
        Me.btntrans.Size = New System.Drawing.Size(75, 23)
        Me.btntrans.TabIndex = 4
        Me.btntrans.Text = "نقل"
        Me.btntrans.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(131, 82)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "اغلاق"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'frmtrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 125)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btntrans)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comto)
        Me.Controls.Add(Me.comfrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmtrans"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نقل الطاولة"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comfrom As ComboBox
    Friend WithEvents comto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btntrans As Button
    Friend WithEvents btnclose As Button
End Class
