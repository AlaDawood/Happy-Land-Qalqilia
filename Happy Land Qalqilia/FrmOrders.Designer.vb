<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrders))
        Me.LstOrd = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilord = New System.Windows.Forms.ImageList(Me.components)
        Me.CMS1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CMS1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstOrd
        '
        Me.LstOrd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LstOrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstOrd.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LstOrd.LargeImageList = Me.ilord
        Me.LstOrd.Location = New System.Drawing.Point(0, 0)
        Me.LstOrd.MultiSelect = False
        Me.LstOrd.Name = "LstOrd"
        Me.LstOrd.RightToLeftLayout = True
        Me.LstOrd.Size = New System.Drawing.Size(811, 484)
        Me.LstOrd.TabIndex = 0
        Me.LstOrd.TileSize = New System.Drawing.Size(230, 55)
        Me.LstOrd.UseCompatibleStateImageBehavior = False
        Me.LstOrd.View = System.Windows.Forms.View.Tile
        '
        'ilord
        '
        Me.ilord.ImageStream = CType(resources.GetObject("ilord.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilord.TransparentColor = System.Drawing.Color.Transparent
        Me.ilord.Images.SetKeyName(0, "fast-food-icon.png")
        '
        'CMS1
        '
        Me.CMS1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CMS1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDone, Me.ToolStripSeparator1, Me.BtnCancel})
        Me.CMS1.Name = "CMS1"
        Me.CMS1.Size = New System.Drawing.Size(174, 62)
        '
        'BtnDone
        '
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(173, 26)
        Me.BtnDone.Text = "تم انجاز الطلب"
        '
        'BtnCancel
        '
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(173, 26)
        Me.BtnCancel.Text = "الغاء الطلب"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'FrmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(811, 484)
        Me.Controls.Add(Me.LstOrd)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrders"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الطلبات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CMS1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstOrd As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ilord As ImageList
    Friend WithEvents CMS1 As ContextMenuStrip
    Friend WithEvents BtnDone As ToolStripMenuItem
    Friend WithEvents BtnCancel As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Timer1 As Timer
End Class
