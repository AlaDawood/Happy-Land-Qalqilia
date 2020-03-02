<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHappyLand
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHappyLand))
        Me.lstLand = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.illand = New System.Windows.Forms.ImageList(Me.components)
        Me.cms1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnEditKids = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.addchild = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewChild = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BtnDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms1.SuspendLayout()
        Me.cms2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstLand
        '
        Me.lstLand.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstLand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstLand.FullRowSelect = True
        Me.lstLand.LargeImageList = Me.illand
        Me.lstLand.Location = New System.Drawing.Point(0, 20)
        Me.lstLand.MultiSelect = False
        Me.lstLand.Name = "lstLand"
        Me.lstLand.RightToLeftLayout = True
        Me.lstLand.Size = New System.Drawing.Size(881, 453)
        Me.lstLand.TabIndex = 0
        Me.lstLand.TileSize = New System.Drawing.Size(230, 65)
        Me.lstLand.UseCompatibleStateImageBehavior = False
        Me.lstLand.View = System.Windows.Forms.View.Tile
        '
        'illand
        '
        Me.illand.ImageStream = CType(resources.GetObject("illand.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.illand.TransparentColor = System.Drawing.Color.Transparent
        Me.illand.Images.SetKeyName(0, "ticket.png")
        Me.illand.Images.SetKeyName(1, "kid-icon.png")
        '
        'cms1
        '
        Me.cms1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.BtnEditKids, Me.BtnDel})
        Me.cms1.Name = "cms1"
        Me.cms1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cms1.Size = New System.Drawing.Size(181, 92)
        '
        'btnPrint
        '
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(180, 22)
        Me.btnPrint.Text = "طباعة تذكرة"
        '
        'BtnEditKids
        '
        Me.BtnEditKids.Name = "BtnEditKids"
        Me.BtnEditKids.Size = New System.Drawing.Size(180, 22)
        Me.BtnEditKids.Text = "تعديل اسم الطفل"
        '
        'cms2
        '
        Me.cms2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addchild, Me.ViewChild})
        Me.cms2.Name = "cms1"
        Me.cms2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cms2.Size = New System.Drawing.Size(173, 48)
        '
        'addchild
        '
        Me.addchild.Name = "addchild"
        Me.addchild.Size = New System.Drawing.Size(172, 22)
        Me.addchild.Text = "إضافة اسم طفل"
        '
        'ViewChild
        '
        Me.ViewChild.Name = "ViewChild"
        Me.ViewChild.Size = New System.Drawing.Size(172, 22)
        Me.ViewChild.Text = "عرض اسماء الاطفال"
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSearch.Location = New System.Drawing.Point(0, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(881, 20)
        Me.txtSearch.TabIndex = 2
        '
        'BtnDel
        '
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(180, 22)
        Me.BtnDel.Text = "حذف الطفل"
        '
        'FrmHappyLand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(881, 473)
        Me.Controls.Add(Me.lstLand)
        Me.Controls.Add(Me.txtSearch)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHappyLand"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "كاشير الملاهي"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cms1.ResumeLayout(False)
        Me.cms2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLand As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents illand As ImageList
    Friend WithEvents cms1 As ContextMenuStrip
    Friend WithEvents btnPrint As ToolStripMenuItem
    Friend WithEvents cms2 As ContextMenuStrip
    Friend WithEvents addchild As ToolStripMenuItem
    Friend WithEvents ViewChild As ToolStripMenuItem
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents BtnEditKids As ToolStripMenuItem
    Friend WithEvents BtnDel As ToolStripMenuItem
End Class
