Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.ServiceProcess

Module DBConnection
    Public SiNo As Integer
    Public OrCode As Integer
    Public EmCode As Integer
    Public TicCode As Integer
    Public KidsName As Integer
    Public KidsCode As Integer = 0
    Public TicType As Integer
    Public TicPrice As Double
    Public HtmlBill As String
    Public TicNo, TicDiscount As Integer
    Public line As String = Nothing
    Public DataBasePath As String = Nothing
    Public BackUpPath As String = Nothing
    Public reader As SqlDataReader = Nothing
    Public MyCn As New SqlConnection
    Public cmd As SqlCommand = Nothing
    Public DS As New DataSet
    Public TCNo As Integer = 0
    Public ServerSTR As String
    'Public ConnectionString As String = "Data Source=DESKTOP-65SC2T1;Initial Catalog=MarinaDB;Integrated Security=True"
    'Public ConnectionString As String = "Data Source=" & ServerSTR & ";Initial Catalog=MarinaDB;Integrated Security=True;Network Library=dbnmpntw"
    'Public ConnectionString As String = "Data Source=172.18.0.44,1433;Initial Catalog=MarinaDB;Persist Security Info=False;User ID=saa;Password=12345;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Network Library=dbmssocn"
    Public con As New OleDbConnection
    Public cmd1 As New OleDbCommand
    Public DataNo As Integer
    Public TicNom As Integer
    Public Con_string As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MarinaDB.mdb.mdb;Jet OLEDB:Database Password=10716602;"


    Public Sub ExecuteSQLStmt(ByVal SQLStatment As String)
        ' Open the connection
        If con.ConnectionString = "" Then
            con.ConnectionString = Con_string
        End If
        If DataNo = 1 Then
            If MyCn.State = ConnectionState.Open Then
                MyCn.Close()
            End If
            Try
                'MyCn.ConnectionString = ConnectionString
                MyCn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = SQLStatment
            cmd.Connection = MyCn
            Try
                cmd.ExecuteNonQuery()
                MyCn.Close()
            Catch ae As Exception
                MessageBox.Show(ae.Message.ToString())
            End Try
        Else
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            Try
                cmd1.Connection = con
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                cmd1.CommandType = CommandType.Text
                cmd1.CommandText = SQLStatment
                cmd1.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        con.Close()
        MyCn.Close()
    End Sub   'ExecuteSQLStmt 

    Public Sub FillTable(ByVal SQLStatment As String, ByVal TableNo As String, ByVal _DataSet As DataSet)
        If con.ConnectionString = "" Then
            con.ConnectionString = Con_string
        End If

        If DataNo = 1 Then
            ' Open the connection
            If MyCn.State = ConnectionState.Open Then
                MyCn.Close()
            End If
            Try
                'MyCn.ConnectionString = ConnectionString
                MyCn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ' Create a data adapter
            Dim Adp As New SqlDataAdapter(SQLStatment, MyCn)
            _DataSet.Clear()
            ' Create DataSet, fill it and view in data grid
            Adp.Fill(_DataSet, TableNo)
        Else
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            Try
                cmd1.Connection = con
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ' Create a data adapter
            Dim Adp As New OleDbDataAdapter(SQLStatment, con.ConnectionString)
            _DataSet.Clear()
            ' Create DataSet, fill it and view in data grid
            Adp.Fill(_DataSet, TableNo)

        End If
        con.Close()
        MyCn.Close()
    End Sub
    Public Sub FillTable2(ByVal SQLStatment As String, ByVal TableNo As Boolean, ByVal DG As Object, ByVal _DataSet As DataSet)
        If con.ConnectionString = "" Then
            con.ConnectionString = Con_string
        End If
        If DataNo = 1 Then
            ' Open the connection
            If MyCn.State = ConnectionState.Open Then
                MyCn.Close()
            End If
            Try
                'MyCn.ConnectionString = ConnectionString
                MyCn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ' Create a data adapter
            Dim Adp As New SqlDataAdapter(SQLStatment, MyCn)
            ' Create DataSet, fill it and view in data grid
            If TableNo = 0 Then
                Adp.Fill(_DataSet)
            End If
        Else
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            Try
                cmd1.Connection = con
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ' Create a data adapter
            Dim Adp As New OleDbDataAdapter(SQLStatment, con.ConnectionString)
            ' Create DataSet, fill it and view in data grid
            If TableNo = 0 Then
                Adp.Fill(_DataSet)
            End If
        End If
        con.Close()
        MyCn.Close()
    End Sub

    Public Sub FillTable3(ByVal SQLStatment As String, ByVal _DataSet As DataSet)
        If con.ConnectionString = "" Then
            con.ConnectionString = Con_string
        End If
        If DataNo = 1 Then
            ' Open the connection
            If MyCn.State = ConnectionState.Open Then
                MyCn.Close()
            End If
            Try
                'MyCn.ConnectionString = ConnectionString
                MyCn.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ' Create a data adapter
            Dim Adp As New SqlDataAdapter(SQLStatment, MyCn)
            _DataSet.Clear()
            ' Create DataSet, fill it and view in data grid
            Adp.Fill(_DataSet)
        Else
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            Try
                cmd1.Connection = con
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ' Create a data adapter
            Dim Adp As New OleDbDataAdapter(SQLStatment, con.ConnectionString)
            _DataSet.Clear()
            ' Create DataSet, fill it and view in data grid
            Adp.Fill(_DataSet)

        End If
        con.Close()
        MyCn.Close()
    End Sub

    Public Sub CheckInstance()
        Dim myServiceName As String = "SQL Server (MSSQLSERVER)" 'service name of SQL Server Express
        Dim status As String  'service status (For example, Running or Stopped)
        Dim mySC As ServiceController

        MsgBox("Service: " & myServiceName)

        'display service status: For example, Running, Stopped, or Paused
        mySC = New ServiceController(myServiceName)
        Try
            status = mySC.Status.ToString
        Catch ex As Exception
            MsgBox("Service not found. It is probably not installed. [exception=" & ex.Message & "]")
            End
        End Try
        MsgBox("Service status : " & status)

        'if service is Stopped or StopPending, you can run it with the following code.
        If mySC.Status.Equals(ServiceControllerStatus.Stopped) Or mySC.Status.Equals(ServiceControllerStatus.StopPending) Then
            Try
                MsgBox("Starting the service...")
                mySC.Start()
                mySC.WaitForStatus(ServiceControllerStatus.Running)
                MsgBox("The service is now " & mySC.Status.ToString)

            Catch ex As Exception
                MsgBox("Error in starting the service: " & ex.Message)
            End Try
        ElseIf mySC.Status.Equals(ServiceControllerStatus.Paused) Or mySC.Status.Equals(ServiceControllerStatus.PausePending) Then
            Try
                MsgBox("Resuming the service...")
                mySC.Continue()
                mySC.WaitForStatus(ServiceControllerStatus.Running)
                MsgBox("The service is now " & mySC.Status.ToString)

            Catch ex As Exception
                MsgBox("Error in starting the service: " & ex.Message)
            End Try
        End If
    End Sub
End Module
