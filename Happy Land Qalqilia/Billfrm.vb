Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports Happy_Land_Qalqilia.BillDSTableAdapters
Imports Microsoft.Reporting.WinForms

Public Class Billfrm
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    Private reportData As New DataTable
    Private Sub Billfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BillDS.DtBill' table. You can move, or remove it, as needed.

        If SiNo = 0 Then
            If DtABill.Connection.State = ConnectionState.Open Then
                DtABill.Connection.Close()
            End If
            Try
                DtABill.Connection = con
                DtABill.Connection.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.DtABill.FillBy(Me.BillDS.DtBill, OrCode)
            reportData = Me.BillDS.DtBill
            RvBillReport.LocalReport.ReportPath = "Report1.rdlc"
            Dim CurrentReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource With {
                .Name = "BillDS",
                .Value = DtBillBindingSource
            }

            RvBillReport.LocalReport.DataSources.Add(CurrentReportDataSource)
        ElseIf SiNo = 1 Then
            If EmploTableAdapter.Connection.State = ConnectionState.Open Then
                EmploTableAdapter.Connection.Close()
            End If
            Try
                EmploTableAdapter.Connection = con
                EmploTableAdapter.Connection.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.EmploTableAdapter.FillBy(Me.BillDS.Emplo, EmCode)
            reportData = Me.BillDS.Emplo
            RvBillReport.LocalReport.ReportPath = "Report2.rdlc"
            Dim CurrentReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource With {
                .Name = "EmploDS",
                .Value = EmploBindingSource
            }
            RvBillReport.LocalReport.DataSources.Add(CurrentReportDataSource)
        ElseIf SiNo = 2 Then
            If TicTableAdapter.Connection.State = ConnectionState.Open Then
                TicTableAdapter.Connection.Close()
            End If
            Try
                TicTableAdapter.Connection = con
                TicTableAdapter.Connection.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.TicTableAdapter.FillBy(Me.BillDS.Tickets, TicCode)
            reportData = Me.BillDS.Tickets
            RvBillReport.LocalReport.ReportPath = "Report3.rdlc"
            Dim CurrentReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource With {
                .Name = "TicDS",
                .Value = TicketsBindingSource
            }
            RvBillReport.LocalReport.DataSources.Add(CurrentReportDataSource)
        ElseIf SiNo = 3 Then
            If TicKidTableAdapter.Connection.State = ConnectionState.Open Then
                TicKidTableAdapter.Connection.Close()
            End If
            Try
                TicKidTableAdapter.Connection = con
                TicKidTableAdapter.Connection.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.TicKidTableAdapter.FillBy(Me.BillDS.TicketsKid, TicCode, KidsName)
            reportData = Me.BillDS.TicketsKid
            RvBillReport.LocalReport.ReportPath = "Report5.rdlc"
            CurrentReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource With {
                .Name = "TicKid",
                .Value = TicketsKidBindingSource
            }
            RvBillReport.LocalReport.DataSources.Add(CurrentReportDataSource)
        End If
        Me.RvBillReport.RefreshReport()

    End Sub
    Public Sub Print()
        'First we export the report and set current page to 0
        Export(RvBillReport.LocalReport)
        m_currentPageIndex = 0

        If m_streams Is Nothing Or m_streams.Count = 0 Then
            Return
        End If
        'We declare our PrintDocument, and then we can set printer name or other stuff for our print document class
        Dim printDoc As New PrintDocument()
        'Register event for Page printing
        AddHandler printDoc.PrintPage, AddressOf PrintPage

        With printDoc.DefaultPageSettings.Margins
            .Top = 0.1
            .Bottom = 0.1
            .Left = 0.1
            .Right = 0.1
        End With
        printDoc.DocumentName = "Report"
        If Not printDoc.PrinterSettings.IsValid Then
            Dim msg As String = "Can't find printer"
            Return
        End If
        printDoc.Print()

    End Sub
    Private Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String =
"<DeviceInfo>" +
" <OutputFormat>EMF</OutputFormat>" +
" <PageWidth>3in</PageWidth>" +
" <PageHeight>6in</PageHeight>" +
" <MarginTop>0.1in</MarginTop>" +
" <MarginLeft>0.1in</MarginLeft>" +
" <MarginRight>0.1in</MarginRight>" +
" <MarginBottom>0.1in</MarginBottom>" +
"</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)

        Dim stream As Stream

        For Each stream In m_streams
            stream.Position = 0
        Next
    End Sub
    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New FileStream(Application.StartupPath & "\Bills\" & Now.Ticks.ToString & ".emf", FileMode.Create)
        m_streams.Add(stream)
        Return stream
    End Function
    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        ev.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
        ev.Graphics.DrawImage(pageImage, ev.PageBounds)

        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub Billfrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Print()
        'Close()
    End Sub

    Private Sub RvBillReport_Print(sender As Object, e As ReportPrintEventArgs) Handles RvBillReport.Print
        Close()
    End Sub

    Dim CurrentReportDataSource As ReportDataSource
End Class