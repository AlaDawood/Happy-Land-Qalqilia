<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChange
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNew1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "كلمة المرور القديمة"
        '
        'txtOld
        '
        Me.txtOld.Location = New System.Drawing.Point(143, 6)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.Size = New System.Drawing.Size(162, 20)
        Me.txtOld.TabIndex = 1
        Me.txtOld.UseSystemPasswordChar = True
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(143, 32)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(162, 20)
        Me.txtNew.TabIndex = 3
        Me.txtNew.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "كلمة المرور الجديدة"
        '
        'txtNew1
        '
        Me.txtNew1.Location = New System.Drawing.Point(143, 58)
        Me.txtNew1.Name = "txtNew1"
        Me.txtNew1.Size = New System.Drawing.Size(162, 20)
        Me.txtNew1.TabIndex = 5
        Me.txtNew1.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "اعادة كلمة المرور الجديدة"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(143, 93)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(230, 93)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "إغلاق"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FrmChange
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(315, 133)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.txtNew1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOld)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmChange"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تغيير كلمة المرور"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtOld As TextBox
    Friend WithEvents txtNew As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNew1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
End Class
