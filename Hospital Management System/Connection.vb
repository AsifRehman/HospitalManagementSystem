Imports MySql.Data.MySqlClient
Module Connection
    Public conn As New MySqlConnection
    Public sql As String
    Public constring As String
    Public COMMAND As MySqlCommand
    Public cmd As MySqlCommand
    Public cmd1 As MySqlCommand
    Public READER As MySqlDataReader
    Public dr As MySqlDataReader


 
    Public Sub connectDB()

        Try
            'conn = New MySqlConnection("Server = 169.254.143.32; port=3306; username=med; password=med1234; database=general_hospital;")
            'conn = New MySqlConnection("Server = 192.168.0.108; port=3306; username=med; password=med1234; database=general_hospital;")
            conn = New MySqlConnection("Server = 127.0.0.1; port=3306; username=root; password=; database=general_hospital;")

            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "connection error")
            Application.ExitThread()
        End Try

    End Sub
    Public Sub disconnect()
        conn.Close()
        conn.Dispose()
    End Sub
    Public Sub RefreshDB()
        Try
            conn.Close()
            conn.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "connection error")
            Application.ExitThread()
        End Try

    End Sub
End Module