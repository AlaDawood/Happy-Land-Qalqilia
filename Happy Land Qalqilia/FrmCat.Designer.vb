<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCat))
        Me.lstcat = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilcat = New System.Windows.Forms.ImageList(Me.components)
        Me.cms1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnadd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnedit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms1.SuspendLayout()
        Me.cms2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstcat
        '
        Me.lstcat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstcat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstcat.FullRowSelect = True
        Me.lstcat.LargeImageList = Me.ilcat
        Me.lstcat.Location = New System.Drawing.Point(0, 0)
        Me.lstcat.MultiSelect = False
        Me.lstcat.Name = "lstcat"
        Me.lstcat.RightToLeftLayout = True
        Me.lstcat.Size = New System.Drawing.Size(711, 297)
        Me.lstcat.TabIndex = 0
        Me.lstcat.TileSize = New System.Drawing.Size(150, 65)
        Me.lstcat.UseCompatibleStateImageBehavior = False
        Me.lstcat.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ilcat
        '
        Me.ilcat.ImageStream = CType(resources.GetObject("ilcat.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilcat.TransparentColor = System.Drawing.Color.Transparent
        Me.ilcat.Images.SetKeyName(0, "boxes.png")
        '
        'cms1
        '
        Me.cms1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnadd})
        Me.cms1.Name = "cms1"
        Me.cms1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cms1.Size = New System.Drawing.Size(105, 26)
        '
        'btnadd
        '
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(104, 22)
        Me.btnadd.Text = "اضافة"
        '
        'cms2
        '
        Me.cms2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnedit})
        Me.cms2.Name = "ContextMenuStrip1"
        Me.cms2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cms2.Size = New System.Drawing.Size(104, 26)
        '
        'btnedit
        '
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(103, 22)
        Me.btnedit.Text = "تعديل"
        '
        'FrmCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 297)
        Me.Controls.Add(Me.lstcat)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCat"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "المجموعات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cms1.ResumeLayout(False)
        Me.cms2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstcat As ListView
    Friend WithEvents ilcat As ImageList
    Friend WithEvents cms1 As ContextMenuStrip
    Friend WithEvents cms2 As ContextMenuStrip
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnadd As ToolStripMenuItem
    Friend WithEvents btnedit As ToolStripMenuItem
End Class
