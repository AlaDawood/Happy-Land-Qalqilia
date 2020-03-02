<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billfrm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TicketsKidBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillDS = New Happy_Land_Qalqilia.BillDS()
        Me.RvBillReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TicketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtABill = New Happy_Land_Qalqilia.BillDSTableAdapters.DtABill()
        Me.EmploBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmploTableAdapter = New Happy_Land_Qalqilia.BillDSTableAdapters.EmploTableAdapter()
        Me.TicTableAdapter = New Happy_Land_Qalqilia.BillDSTableAdapters.TicTableAdapter()
        Me.TicKidTableAdapter = New Happy_Land_Qalqilia.BillDSTableAdapters.TicKidTableAdapter()
        Me.PrintWithoutDialogToolStripMenuItem = New System.Windows.Forms.Button()
        Me.SchedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
        CType(Me.TicketsKidBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmploBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TicketsKidBindingSource
        '
        Me.TicketsKidBindingSource.DataMember = "TicketsKid"
        Me.TicketsKidBindingSource.DataSource = Me.BillDS
        '
        'BillDS
        '
        Me.BillDS.DataSetName = "BillDS"
        Me.BillDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvBillReport
        '
        Me.RvBillReport.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TicKid"
        ReportDataSource1.Value = Me.TicketsKidBindingSource
        Me.RvBillReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvBillReport.LocalReport.ReportEmbeddedResource = "Happy_Land_Qalqilia.Report5.rdlc"
        Me.RvBillReport.Location = New System.Drawing.Point(0, 0)
        Me.RvBillReport.Name = "RvBillReport"
        Me.RvBillReport.ServerReport.BearerToken = Nothing
        Me.RvBillReport.Size = New System.Drawing.Size(1012, 595)
        Me.RvBillReport.TabIndex = 0
        '
        'TicketsBindingSource
        '
        Me.TicketsBindingSource.DataMember = "Tickets"
        Me.TicketsBindingSource.DataSource = Me.BillDS
        '
        'DtBillBindingSource
        '
        Me.DtBillBindingSource.DataMember = "DtBill"
        Me.DtBillBindingSource.DataSource = Me.BillDS
        '
        'DtABill
        '
        Me.DtABill.ClearBeforeFill = True
        '
        'EmploBindingSource
        '
        Me.EmploBindingSource.DataMember = "Emplo"
        Me.EmploBindingSource.DataSource = Me.BillDS
        '
        'EmploTableAdapter
        '
        Me.EmploTableAdapter.ClearBeforeFill = True
        '
        'TicTableAdapter
        '
        Me.TicTableAdapter.ClearBeforeFill = True
        '
        'TicKidTableAdapter
        '
        Me.TicKidTableAdapter.ClearBeforeFill = True
        '
        'PrintWithoutDialogToolStripMenuItem
        '
        Me.PrintWithoutDialogToolStripMenuItem.Enabled = False
        Me.PrintWithoutDialogToolStripMenuItem.Location = New System.Drawing.Point(0, 0)
        Me.PrintWithoutDialogToolStripMenuItem.Name = "PrintWithoutDialogToolStripMenuItem"
        Me.PrintWithoutDialogToolStripMenuItem.Size = New System.Drawing.Size(75, 23)
        Me.PrintWithoutDialogToolStripMenuItem.TabIndex = 1
        Me.PrintWithoutDialogToolStripMenuItem.Text = "Button1"
        Me.PrintWithoutDialogToolStripMenuItem.UseVisualStyleBackColor = True
        '
        'SchedulerDataStorage1
        '
        Me.SchedulerDataStorage1.AppointmentDependencies.AutoReload = False
        Me.SchedulerDataStorage1.Labels.ColorSaving = DevExpress.XtraScheduler.DXColorSavingType.ArgbColor
        '
        'Billfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1012, 595)
        Me.Controls.Add(Me.RvBillReport)
        Me.Controls.Add(Me.PrintWithoutDialogToolStripMenuItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Billfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Bill"
        CType(Me.TicketsKidBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmploBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvBillReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DtBillBindingSource As BindingSource
    Friend WithEvents BillDS As BillDS
    Friend WithEvents DtABill As BillDSTableAdapters.DtABill
    Friend WithEvents EmploBindingSource As BindingSource
    Friend WithEvents EmploTableAdapter As BillDSTableAdapters.EmploTableAdapter
    Friend WithEvents TicketsBindingSource As BindingSource
    Friend WithEvents TicTableAdapter As BillDSTableAdapters.TicTableAdapter
    Friend WithEvents TicketsKidBindingSource As BindingSource
    Friend WithEvents TicKidTableAdapter As BillDSTableAdapters.TicKidTableAdapter
    Friend WithEvents PrintWithoutDialogToolStripMenuItem As Button
    Friend WithEvents SchedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage
End Class
