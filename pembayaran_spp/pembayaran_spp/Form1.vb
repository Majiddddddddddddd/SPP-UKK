Imports System.Data.SqlClient

Public Class Form1
    Sub kosong()
        txtusnm.Text = ""
        txtpass.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connect()
        If txtusnm.Text = "" And txtpass.Text = "" Then
            MsgBox("Pastikan Mengisi Semua Field")
        Else
            sql = "SELECT id_petugas, username, password, level FROM petugas WHERE username='" & Trim(txtusnm.Text) & "' and password='" & Trim(txtpass.Text) & "'"
            cmd = New SqlCommand(sql, con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If rd.Item("level").Equals("Admin") Then
                    Admin.Show()
                    Me.Hide()
                ElseIf rd.Item("level").Equals("Petugas") Then
                    Petugas.Show()
                    Me.Hide()
                ElseIf rd.Item("level").Equals("Siswa") Then
                    Siswa.Show()
                    Me.Hide()
                Else
                    MsgBox("Username atau password yang anda masukan tidak sesuai")
                    rd.Close()
                End If
            Else
                MsgBox("Username atau password yang anda masukan tidak sesuai")
                rd.Close()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connect()
        If txtusnm.Text = "" And txtpass.Text = "" Then
            MsgBox("Username dan Password belum di isi")
        Else
            txtusnm.Text = ""
            txtpass.Text = ""
        End If
    End Sub
End Class
