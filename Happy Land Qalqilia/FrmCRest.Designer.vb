<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCRest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCRest))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstTable = New System.Windows.Forms.ListView()
        Me.iltable = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstcat = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilcat = New System.Windows.Forms.ImageList(Me.components)
        Me.lstprod = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilprod = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstord = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn = New System.Windows.Forms.Button()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.btnto = New System.Windows.Forms.Button()
        Me.BtnOrd = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.chkdiscount = New System.Windows.Forms.CheckBox()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.96625!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.03374!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1009, 565)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lstTable, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(923, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.534303!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.4657!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(83, 559)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lstTable
        '
        Me.lstTable.BackColor = System.Drawing.Color.White
        Me.lstTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTable.FullRowSelect = True
        Me.lstTable.HideSelection = False
        Me.lstTable.LargeImageList = Me.iltable
        Me.lstTable.Location = New System.Drawing.Point(3, 22)
        Me.lstTable.MultiSelect = False
        Me.lstTable.Name = "lstTable"
        Me.lstTable.Size = New System.Drawing.Size(77, 534)
        Me.lstTable.TabIndex = 0
        Me.lstTable.TileSize = New System.Drawing.Size(100, 65)
        Me.lstTable.UseCompatibleStateImageBehavior = False
        Me.lstTable.View = System.Windows.Forms.View.Tile
        '
        'iltable
        '
        Me.iltable.ImageStream = CType(resources.GetObject("iltable.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iltable.TransparentColor = System.Drawing.Color.Transparent
        Me.iltable.Images.SetKeyName(0, "1_circle1600.png")
        Me.iltable.Images.SetKeyName(1, "2_circle1600.png")
        Me.iltable.Images.SetKeyName(2, "figure-3-icon-63220.png")
        Me.iltable.Images.SetKeyName(3, "4_circle1600.png")
        Me.iltable.Images.SetKeyName(4, "5_circle1600.png")
        Me.iltable.Images.SetKeyName(5, "بدون عنوان.png")
        Me.iltable.Images.SetKeyName(6, "figure-7-icon-63224.png")
        Me.iltable.Images.SetKeyName(7, "8_circle1600.png")
        Me.iltable.Images.SetKeyName(8, "9NumberNineInCircle.png")
        Me.iltable.Images.SetKeyName(9, "10NumberTenInCircle.png")
        Me.iltable.Images.SetKeyName(10, "11NumberElevenInCircle.png")
        Me.iltable.Images.SetKeyName(11, "12NumberTwelveInCircle.png")
        Me.iltable.Images.SetKeyName(12, "13-24.png")
        Me.iltable.Images.SetKeyName(13, "14NumberFourteenInCircle.png")
        Me.iltable.Images.SetKeyName(14, "15NumberFifteenInCircle.png")
        Me.iltable.Images.SetKeyName(15, "16NumberSixteenInCircle.png")
        Me.iltable.Images.SetKeyName(16, "17numberseventeenincircle.png")
        Me.iltable.Images.SetKeyName(17, "18-13.png")
        Me.iltable.Images.SetKeyName(18, "19-18.png")
        Me.iltable.Images.SetKeyName(19, "20.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "رقم الطاولة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lstcat, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lstprod, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(320, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.534303!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.04782!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.534303!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.29938!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(597, 559)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(591, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "المجموعات"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(3, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(591, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "السلع"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstcat
        '
        Me.lstcat.BackColor = System.Drawing.Color.White
        Me.lstcat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstcat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstcat.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lstcat.FullRowSelect = True
        Me.lstcat.HideSelection = False
        Me.lstcat.LargeImageList = Me.ilcat
        Me.lstcat.Location = New System.Drawing.Point(3, 22)
        Me.lstcat.MultiSelect = False
        Me.lstcat.Name = "lstcat"
        Me.lstcat.RightToLeftLayout = True
        Me.lstcat.Size = New System.Drawing.Size(591, 88)
        Me.lstcat.TabIndex = 2
        Me.lstcat.TileSize = New System.Drawing.Size(100, 36)
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
        Me.ilcat.Images.SetKeyName(0, "food.png")
        '
        'lstprod
        '
        Me.lstprod.BackColor = System.Drawing.Color.White
        Me.lstprod.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lstprod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstprod.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lstprod.FullRowSelect = True
        Me.lstprod.HideSelection = False
        Me.lstprod.LargeImageList = Me.ilprod
        Me.lstprod.Location = New System.Drawing.Point(3, 135)
        Me.lstprod.MultiSelect = False
        Me.lstprod.Name = "lstprod"
        Me.lstprod.RightToLeftLayout = True
        Me.lstprod.Size = New System.Drawing.Size(591, 421)
        Me.lstprod.TabIndex = 3
        Me.lstprod.TileSize = New System.Drawing.Size(170, 65)
        Me.lstprod.UseCompatibleStateImageBehavior = False
        Me.lstprod.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "السلعة"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "الكود"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "السعر"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ilprod
        '
        Me.ilprod.ImageStream = CType(resources.GetObject("ilprod.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilprod.TransparentColor = System.Drawing.Color.Transparent
        Me.ilprod.Images.SetKeyName(0, "fast-food-icon.png")
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lstord, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.51975!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.48025!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(311, 559)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'lstord
        '
        Me.lstord.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader12, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader13})
        Me.lstord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstord.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lstord.FullRowSelect = True
        Me.lstord.GridLines = True
        Me.lstord.Location = New System.Drawing.Point(3, 3)
        Me.lstord.MultiSelect = False
        Me.lstord.Name = "lstord"
        Me.lstord.Size = New System.Drawing.Size(305, 276)
        Me.lstord.TabIndex = 0
        Me.lstord.UseCompatibleStateImageBehavior = False
        Me.lstord.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "#"
        Me.ColumnHeader6.Width = 30
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "كود السلعة"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 5
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "السلعة"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "الكمية"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 40
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "السعر"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 45
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "كود المجموعة"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "رقم الطاولة"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 55
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "التكلفة"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 55
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.btnTrans, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.btnto, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnOrd, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.BtnAdd, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.chkdiscount, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.txtdiscount, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel7, 1, 3)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 285)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(305, 271)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Btn, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(156, 115)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(146, 153)
        Me.TableLayoutPanel6.TabIndex = 10
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.Color.Transparent
        Me.Btn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Btn.ForeColor = System.Drawing.Color.Yellow
        Me.Btn.Location = New System.Drawing.Point(3, 3)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(140, 70)
        Me.Btn.TabIndex = 8
        Me.Btn.Text = "تسليم الصندوق"
        Me.Btn.UseVisualStyleBackColor = False
        '
        'btnTrans
        '
        Me.btnTrans.BackColor = System.Drawing.Color.Transparent
        Me.btnTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTrans.Enabled = False
        Me.btnTrans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTrans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrans.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnTrans.ForeColor = System.Drawing.Color.Yellow
        Me.btnTrans.Location = New System.Drawing.Point(3, 43)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(147, 34)
        Me.btnTrans.TabIndex = 7
        Me.btnTrans.Text = "نقل الطاولة"
        Me.btnTrans.UseVisualStyleBackColor = False
        '
        'btnto
        '
        Me.btnto.BackColor = System.Drawing.Color.Transparent
        Me.btnto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnto.Enabled = False
        Me.btnto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnto.ForeColor = System.Drawing.Color.Yellow
        Me.btnto.Location = New System.Drawing.Point(156, 43)
        Me.btnto.Name = "btnto"
        Me.btnto.Size = New System.Drawing.Size(146, 34)
        Me.btnto.TabIndex = 6
        Me.btnto.Text = "قفل الطاولة"
        Me.btnto.UseVisualStyleBackColor = False
        '
        'BtnOrd
        '
        Me.BtnOrd.BackColor = System.Drawing.Color.Transparent
        Me.BtnOrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnOrd.Enabled = False
        Me.BtnOrd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOrd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnOrd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BtnOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOrd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnOrd.ForeColor = System.Drawing.Color.Yellow
        Me.BtnOrd.Location = New System.Drawing.Point(3, 3)
        Me.BtnOrd.Name = "BtnOrd"
        Me.BtnOrd.Size = New System.Drawing.Size(147, 34)
        Me.BtnOrd.TabIndex = 5
        Me.BtnOrd.Text = "الطلبات"
        Me.BtnOrd.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Yellow
        Me.BtnAdd.Location = New System.Drawing.Point(156, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(146, 34)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'chkdiscount
        '
        Me.chkdiscount.AutoSize = True
        Me.chkdiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkdiscount.Enabled = False
        Me.chkdiscount.Location = New System.Drawing.Point(156, 83)
        Me.chkdiscount.Name = "chkdiscount"
        Me.chkdiscount.Size = New System.Drawing.Size(146, 26)
        Me.chkdiscount.TabIndex = 4
        Me.chkdiscount.Text = "الخصم %"
        Me.chkdiscount.UseVisualStyleBackColor = True
        '
        'txtdiscount
        '
        Me.txtdiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdiscount.Enabled = False
        Me.txtdiscount.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txtdiscount.Location = New System.Drawing.Point(3, 83)
        Me.txtdiscount.Multiline = True
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(147, 26)
        Me.txtdiscount.TabIndex = 3
        Me.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.BtnPrint, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 115)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(147, 153)
        Me.TableLayoutPanel7.TabIndex = 11
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPrint.Enabled = False
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPrint.Location = New System.Drawing.Point(3, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(141, 70)
        Me.BtnPrint.TabIndex = 9
        Me.BtnPrint.Text = "طباعة فاتورة"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'FrmCRest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1009, 565)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmCRest"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "كاشير المطعم"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lstTable As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents iltable As ImageList
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstcat As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ilcat As ImageList
    Friend WithEvents lstprod As ListView
    Friend WithEvents ilprod As ImageList
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lstord As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents btnTrans As Button
    Friend WithEvents BtnOrd As Button
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents btnto As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents chkdiscount As CheckBox
    Friend WithEvents Btn As Button
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents BtnPrint As Button
End Class
