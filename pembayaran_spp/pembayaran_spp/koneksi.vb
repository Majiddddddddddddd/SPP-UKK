Imports System.Data.SqlClient
Module koneksi
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public rd As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public sql As String

    Public Sub connect()
        sql = "Data Source=DESKTOP-ILHBF70; Initial Catalog=db_spp;Integrated Security=True"
        con = New SqlConnection(sql)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
