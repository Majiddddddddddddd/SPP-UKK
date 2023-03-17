Imports System.Data.SqlClient
Public Class KelolaSpp
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        KelolaPetugas.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KelolaLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TransaksiPembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub KelolaSpp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub
    Sub aturdgv()
        sql = "SELECT * FROM spp"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "spp")
        dgv_user.DataSource = ds.Tables("spp")
    End Sub

    Sub kosong()
        txtid.Text = ""
        txtthn.Text = ""
        txtnomi.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If txtid.Text = "" Or txtthn.Text = "" Or txtnomi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
                sql = "Insert into spp(id_spp, tahun, nominal) VALUES ('" & txtid.Text & "', '" & txtthn.Text & "', '" & txtnomi.Text & "')"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Berhasil Tambah Data")
                aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connect()
        If txtid.Text = "" Or txtthn.Text = "" Or txtnomi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE spp set tahun='" & txtthn.Text & "', nominal='" & txtnomi.Text & "' WHERE id_spp='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        connect()
        If txtid.Text = "" Or txtthn.Text = "" Or txtnomi.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM spp WHERE id_spp='" & txtid.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * FROM spp Where(tahun like '%" & txtcari.Text & "%') "
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "spp")
        dgv_user.DataSource = ds.Tables("spp")
    End Sub
    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub dgv_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_user.CellContentClick
        txtid.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtthn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnomi.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub txtthn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtthn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtnomi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomi.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka yang di inputkan")
            e.Handled = True
        End If
    End Sub
End Class