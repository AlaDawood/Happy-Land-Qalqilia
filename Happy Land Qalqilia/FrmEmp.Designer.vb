<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmp))
        Me.lstemp = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilemp = New System.Windows.Forms.ImageList(Me.components)
        Me.CMS1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BTNADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BTNEDIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNPRINT = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS1.SuspendLayout()
        Me.CMS2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstemp
        '
        Me.lstemp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstemp.FullRowSelect = True
        Me.lstemp.GridLines = True
        Me.lstemp.LargeImageList = Me.ilemp
        Me.lstemp.Location = New System.Drawing.Point(0, 0)
        Me.lstemp.MultiSelect = False
        Me.lstemp.Name = "lstemp"
        Me.lstemp.RightToLeftLayout = True
        Me.lstemp.Size = New System.Drawing.Size(872, 494)
        Me.lstemp.TabIndex = 0
        Me.lstemp.TileSize = New System.Drawing.Size(150, 65)
        Me.lstemp.UseCompatibleStateImageBehavior = False
        Me.lstemp.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "الاسم:"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "الكود:"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "الصلاحية:"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ilemp
        '
        Me.ilemp.ImageStream = CType(resources.GetObject("ilemp.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilemp.TransparentColor = System.Drawing.Color.Transparent
        Me.ilemp.Images.SetKeyName(0, "432606.png")
        Me.ilemp.Images.SetKeyName(1, "251105.png")
        '
        'CMS1
        '
        Me.CMS1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNADD})
        Me.CMS1.Name = "CMS1"
        Me.CMS1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CMS1.Size = New System.Drawing.Size(105, 26)
        '
        'BTNADD
        '
        Me.BTNADD.Name = "BTNADD"
        Me.BTNADD.Size = New System.Drawing.Size(104, 22)
        Me.BTNADD.Text = "اضافة"
        '
        'CMS2
        '
        Me.CMS2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNEDIT, Me.BTNPRINT})
        Me.CMS2.Name = "CMS1"
        Me.CMS2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CMS2.Size = New System.Drawing.Size(134, 48)
        '
        'BTNEDIT
        '
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(133, 22)
        Me.BTNEDIT.Text = "تعديل"
        '
        'BTNPRINT
        '
        Me.BTNPRINT.Name = "BTNPRINT"
        Me.BTNPRINT.Size = New System.Drawing.Size(133, 22)
        Me.BTNPRINT.Text = "طباعة تذكرة"
        '
        'FrmEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 494)
        Me.Controls.Add(Me.lstemp)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الموظفين"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CMS1.ResumeLayout(False)
        Me.CMS2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstemp As ListView
    Friend WithEvents ilemp As ImageList
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents CMS1 As ContextMenuStrip
    Friend WithEvents BTNADD As ToolStripMenuItem
    Friend WithEvents CMS2 As ContextMenuStrip
    Friend WithEvents BTNEDIT As ToolStripMenuItem
    Friend WithEvents BTNPRINT As ToolStripMenuItem
End Class
