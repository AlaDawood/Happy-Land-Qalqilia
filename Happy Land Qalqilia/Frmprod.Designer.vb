<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmprod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmprod))
        Me.lstprod = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilprod = New System.Windows.Forms.ImageList(Me.components)
        Me.CMS2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BTNEDIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BTNADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS2.SuspendLayout()
        Me.CMS1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstprod
        '
        Me.lstprod.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstprod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstprod.LargeImageList = Me.ilprod
        Me.lstprod.Location = New System.Drawing.Point(0, 0)
        Me.lstprod.MultiSelect = False
        Me.lstprod.Name = "lstprod"
        Me.lstprod.RightToLeftLayout = True
        Me.lstprod.Size = New System.Drawing.Size(755, 278)
        Me.lstprod.TabIndex = 0
        Me.lstprod.TileSize = New System.Drawing.Size(150, 65)
        Me.lstprod.UseCompatibleStateImageBehavior = False
        Me.lstprod.View = System.Windows.Forms.View.Tile
        '
        'ilprod
        '
        Me.ilprod.ImageStream = CType(resources.GetObject("ilprod.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilprod.TransparentColor = System.Drawing.Color.Transparent
        Me.ilprod.Images.SetKeyName(0, "86a0ba353df88.png")
        '
        'CMS2
        '
        Me.CMS2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNEDIT})
        Me.CMS2.Name = "CMS1"
        Me.CMS2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CMS2.Size = New System.Drawing.Size(153, 48)
        '
        'BTNEDIT
        '
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(152, 22)
        Me.BTNEDIT.Text = "تعديل"
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
        'Frmprod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 278)
        Me.Controls.Add(Me.lstprod)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frmprod"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "السلع"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CMS2.ResumeLayout(False)
        Me.CMS1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstprod As ListView
    Friend WithEvents ilprod As ImageList
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents CMS2 As ContextMenuStrip
    Friend WithEvents BTNEDIT As ToolStripMenuItem
    Friend WithEvents CMS1 As ContextMenuStrip
    Friend WithEvents BTNADD As ToolStripMenuItem
End Class
