Imports System.Text
Imports Happy_Land_Qalqilia

Public Class FrmSelect
    Dim SqlSelect As String
    Dim SelectDS As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RndSelect()
        If SelectDS.Tables(0).Rows.Count <= 0 Then
            Timer2.Stop()
            Timer3.Stop()
            Button1.Enabled = True
            Label4.Text = ""
        Else
            ListBox1.DataSource = SelectDS.Tables(0)
            ListBox1.ValueMember = "Code"
            Timer2.Start()
            Timer3.Start()
            Button1.Enabled = False
            Label4.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
        Button1.Enabled = True
        Label1.Text = "000000"
        Close()
    End Sub

    Private Sub RndSelect()
        If CheckBox1.Checked = True Then
            SqlSelect = "SELECT Code FROM Orders Where Format(OrDate,'dd/MM/yyyy') >= @OrDate1 AND Format(OrDate,'dd/MM/yyyy') <= @OrDate2 union select TRCode from TicketPaid Where Format(TDate,'dd/MM/yyyy') >= @OrDate1 AND Format(TDate,'dd/MM/yyyy') <= @OrDate2"
            Dim dadapter As New OleDb.OleDbDataAdapter
            dadapter = New OleDb.OleDbDataAdapter
            dadapter.SelectCommand = New OleDb.OleDbCommand(SqlSelect, con)
            dadapter.SelectCommand.Parameters.AddWithValue("@OrDate1", DateTimePicker1.Value.ToString("dd/MM/yyyy"))
            dadapter.SelectCommand.Parameters.AddWithValue("@OrDate2", DateTimePicker2.Value.ToString("dd/MM/yyyy"))
            dadapter.Fill(SelectDS)
            'FillTable(SqlSelect, "Orders", SelectDS)
        Else
            SqlSelect = "SELECT Code FROM Orders union select TRCode from TicketPaid"
            FillTable(SqlSelect, "Orders", SelectDS)
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim rnd As New Random
        Dim randomIndex As Integer = rnd.Next(0, SelectDS.Tables(0).Rows.Count - 1)
        Label1.Text = Val(SelectDS.Tables(0).Rows(randomIndex).Item(0))
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        P1.Value = P1.Value + 1
        If P1.Value = 20 Then
            Timer2.Stop()
            Button1.Enabled = True
            P1.Value = 0
            Label4.Text = "ألف مبروك للفائز معنا"
            Timer3.Stop()
        End If
    End Sub
End Class