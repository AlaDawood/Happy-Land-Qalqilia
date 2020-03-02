<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddOut
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
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.Btnok = New System.Windows.Forms.Button()
        Me.Btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الكود"
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(56, 6)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.ReadOnly = True
        Me.txtcode.Size = New System.Drawing.Size(100, 20)
        Me.txtcode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "التاريخ"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(56, 58)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(200, 20)
        Me.txtdesc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "الوصف"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(56, 84)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(124, 20)
        Me.txtprice.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "السعر"
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(56, 32)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(200, 20)
        Me.txtdate.TabIndex = 8
        '
        'Btnok
        '
        Me.Btnok.Location = New System.Drawing.Point(56, 135)
        Me.Btnok.Name = "Btnok"
        Me.Btnok.Size = New System.Drawing.Size(75, 23)
        Me.Btnok.TabIndex = 9
        Me.Btnok.Text = "موافق"
        Me.Btnok.UseVisualStyleBackColor = True
        '
        'Btncancel
        '
        Me.Btncancel.Location = New System.Drawing.Point(137, 135)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(75, 23)
        Me.Btncancel.TabIndex = 10
        Me.Btncancel.Text = "اغلاق"
        Me.Btncancel.UseVisualStyleBackColor = True
        '
        'FrmAddOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 169)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Btnok)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddOut"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "أضافة بند مصروفات"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdate As DateTimePicker
    Friend WithEvents Btnok As Button
    Friend WithEvents Btncancel As Button
End Class
