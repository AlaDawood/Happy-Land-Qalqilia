Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Public Class Demo
    Implements IDisposable
    Public Shared m_currentPageIndex As Integer
    Public Shared m_streams As IList(Of Stream)
    ' Routine to provide to the report renderer, in order to
    ' save an image for each page of the report.
    Public Shared Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        m_streams.Add(stream)
        Return stream
    End Function

    ' Export the given report as an EMF (Enhanced Metafile) file.
    Public Shared Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String = "<DeviceInfo>" &
            "<OutputFormat>EMF</OutputFormat>" &
            "<PageWidth>8.5in</PageWidth>" &
            "<PageHeight>11in</PageHeight>" &
            "<MarginTop>0.25in</MarginTop>" &
            "<MarginLeft>0.25in</MarginLeft>" &
            "<MarginRight>0.25in</MarginRight>" &
            "<MarginBottom>0.25in</MarginBottom>" &
            "</DeviceInfo>"
        Dim warnings As Warning()
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        For Each stream As Stream In m_streams
            stream.Position = 0
        Next
    End Sub

    ' Handler for PrintPageEvents
    Public Shared Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

        ' Adjust rectangular area with printer margins.
        Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX),
                                          ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY),
                                          ev.PageBounds.Width,
                                          ev.PageBounds.Height)

        ' Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

        ' Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect)

        ' Prepare for the next page. Make sure we haven't hit the end.
        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Public Shared Sub Print()
        If m_streams Is Nothing OrElse m_streams.Count = 0 Then
            Throw New Exception("Error: no stream to print.")
        End If
        Dim printDoc As New PrintDocument()
        If Not printDoc.PrinterSettings.IsValid Then
            Throw New Exception("Error: cannot find the default printer.")
        Else
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            m_currentPageIndex = 0
            printDoc.Print()
        End If
    End Sub

    ' Create a local report for Report.rdlc, load the data,
    ' export the report to an .emf file, and print it.
    Public Shared Sub Run(ByVal path As String, ByVal Dtbl As DataTable)
        Dim report As New LocalReport()
        report.ReportPath = path
        report.DataSources.Add(New ReportDataSource("Bill", Dtbl))
        Export(report)
        Print()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If m_streams IsNot Nothing Then
            For Each stream As Stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub

End Class
