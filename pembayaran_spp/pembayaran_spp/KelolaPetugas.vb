Imports System.Data.SqlClient
Public Class KelolaPetugas
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        KelolaSiswa.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KelolaKelas.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        KelolaSpp.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KelolaLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TransaksiPembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtid.Text = "" Or txtus.Text = "" Or txtpass.Text = "" Or txtnama.Text = "" Or cblevel.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into petugas(id_petugas, username, password, nama_petugas, level) VALUES ('" & txtid.Text & "', '" & txtus.Text & "', '" & txtpass.Text & "', '" & txtnama.Text & "', '" & cblevel.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub
    Sub aturdgv()
        sql = "SELECT * FROM petugas"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "petugas")
        dgv_user.DataSource = ds.Tables("petugas")
    End Sub

    Sub kosong()
        txtid.Text = ""
        txtus.Text = ""
        txtpass.Text = ""
        txtnama.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub KelolaPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connect()
        If txtid.Text = "" Or txtus.Text = "" Or txtpass.Text = "" Or txtnama.Text = "" Or cblevel.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE petugas set username='" & txtus.Text & "', password='" & txtpass.Text & "', nama_petugas='" & txtnama.Text & "', level='" & cblevel.Text & "' WHERE id_petugas='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        connect()
        If txtid.Text = "" Or txtus.Text = "" Or txtpass.Text = "" Or txtnama.Text = "" Or cblevel.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM petugas WHERE id_petugas='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * FROM petugas Where(username like '%" & txtcari.Text & "%') "
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "petugas")
        dgv_user.DataSource = ds.Tables("petugas")
    End Sub
    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub dgv_user_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_user.MouseClick
        txtid.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtus.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtpass.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
        txtnama.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(3).Value
        cblevel.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(4).Value
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class