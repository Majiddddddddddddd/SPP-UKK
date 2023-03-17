Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class KelolaSiswa
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        KelolaPetugas.Show()
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

    Private Sub KelolaSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub
    Sub aturdgv()
        sql = "SELECT * FROM siswa"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "siswa")
        dgv_user.DataSource = ds.Tables("siswa")
    End Sub

    Sub kosong()
        txtnisn.Text = ""
        txtnis.Text = ""
        txtnama.Text = ""
        txtid_kelas.Text = ""
        txtalamat.Text = ""
        txtnotelp.Text = ""
        txtidspp.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtnama.Text = "" Or txtid_kelas.Text = "" Or txtalamat.Text = "" Or txtnotelp.Text = "" Or txtidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into siswa(nisn, nis, nama, id_kelas, alamat, no_telp, id_spp) VALUES ('" & txtnisn.Text & "', '" & txtnis.Text & "', '" & txtnama.Text & "', '" & txtid_kelas.Text & "', '" & txtalamat.Text & "' , '" & txtnotelp.Text & "', '" & txtidspp.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connect()
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtnama.Text = "" Or txtid_kelas.Text = "" Or txtalamat.Text = "" Or txtnotelp.Text = "" Or txtidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE siswa set nis='" & txtnis.Text & "', nama='" & txtnama.Text & "', id_kelas='" & txtid_kelas.Text & "', alamat='" & txtalamat.Text & "' , no_telp='" & txtnotelp.Text & "', id_spp='" & txtidspp.Text & "' WHERE nisn='" & txtnisn.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        connect()
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtnama.Text = "" Or txtid_kelas.Text = "" Or txtalamat.Text = "" Or txtnotelp.Text = "" Or txtidspp.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM siswa WHERE nisn='" & txtnisn.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * FROM siswa Where(nama like '%" & txtcari.Text & "%') "
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "siswa")
        dgv_user.DataSource = ds.Tables("siswa")
    End Sub
    Private Sub txtnisn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnisn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub txtnis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnis.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub txtid_kelas_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub txtnotelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnotelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub txtidspp_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub dgv_user_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_user.MouseClick
        txtnisn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtnis.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnama.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
        txtid_kelas.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(3).Value
        txtalamat.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(4).Value
        txtnotelp.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(5).Value
        txtidspp.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(6).Value
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class