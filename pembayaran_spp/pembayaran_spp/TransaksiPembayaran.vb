Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Reflection.Emit

Public Class TransaksiPembayaran
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog

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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        KelolaSpp.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KelolaLaporan.Show()
        Me.Hide()
    End Sub
    Sub aturdgv()
        sql = "SELECT nisn, tgl_bayar, bulan_dibayar, jumlah_bayar FROM pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgv_user.DataSource = ds.Tables("pembayaran")
    End Sub

    Sub kosong()
        txtid_pem.Text = ""
        txtid_pet.Text = ""
        txtnisn.Text = ""
        txtbln.Text = ""
        txtthn.Text = ""
        txtidspp.Text = ""
        txtjml.Text = ""
    End Sub

    Private Sub TransaksiPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connect()
        If  txtid_pet.Text = "" Or txtnisn.Text = "" Or txtbln.Text = "" Or txtthn.Text = "" Or txtidspp.Text = "" Or txtjml.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "Insert into pembayaran(id_pembayaran, id_petugas, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, id_spp, jumlah_bayar) VALUES ('" & txtid_pem.Text & "', '" & txtid_pet.Text & "', '" & txtnisn.Text & "', '" & Format(Dttglbayar.Value, "yyyy-MM-dd") & "', '" & txtbln.Text & "' , '" & txtthn.Text & "', '" & txtidspp.Text & "' , '" & txtjml.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Tambah Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        connect()
        If txtid_pem.Text = "" And txtid_pet.Text = "" Or txtnisn.Text = "" Or txtbln.Text = "" Or txtthn.Text = "" Or txtidspp.Text = "" Or txtjml.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = "UPDATE pembayaran set id_petugas='" & txtid_pet.Text & "', nisn='" & txtnisn.Text & "', tgl_bayar='" & Format(Dttglbayar.Value, "yyyy-MM-dd") & "', bulan_dibayar='" & txtbln.Text & "' , tahun_dibayar='" & txtthn.Text & "', id_spp='" & txtidspp.Text & "' , jumlah_bayar='" & txtidspp.Text & "' WHERE id_pembayaran='" & txtid_pem.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Edit Data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        connect()
        If txtid_pem.Text = "" Or txtid_pet.Text = "" Or txtnisn.Text = "" Or txtbln.Text = "" Or txtthn.Text = "" Or txtidspp.Text = "" Or txtjml.Text = "" Then
            MsgBox("Pastikan mengisi semua field")
        Else
            sql = " DELETE FROM pembayaran WHERE id_pembayaran='" & txtid_pem.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Hapus Data")
            aturdgv()
            kosong()
        End If
    End Sub
    Private Sub dgv_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_user.CellContentClick
        txtid_pem.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(0).Value
        txtid_pet.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(1).Value
        txtnisn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(2).Value
        Dttglbayar.Value = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(3).Value
        txtbln.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(4).Value
        txtthn.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(5).Value
        txtidspp.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(6).Value
        txtjml.Text = dgv_user.Rows(dgv_user.CurrentRow.Index).Cells(7).Value

    End Sub

    Private Sub txtidspp_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'printPD()
        PDD.Document = PD
        PDD.ShowDialog()
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "--------------------------------------------------------------------------------------"

        e.Graphics.DrawString("SPP SMK Negeri 2 Kuningan", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl.Sukamulya No.77", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("No Tlp: 0812", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Petugas", f10, Brushes.Black, 0, 65)
        e.Graphics.DrawString(":", f10, Brushes.Black, 60, 65)
        e.Graphics.DrawString("Majid", f10, Brushes.Black, 80, 65)

        e.Graphics.DrawString("Siswa", f10, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f10, Brushes.Black, 60, 85)
        e.Graphics.DrawString("____________", f10, Brushes.Black, 80, 85)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString("nisn", f10, Brushes.Black, 10, 115)
        e.Graphics.DrawString("jumlah bayar", f10, Brushes.Black, 60, 115)
        e.Graphics.DrawString("tanggal bayar", f10, Brushes.Black, 150, 115)
        dgv_user.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To dgv_user.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 10, 120 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(7).Value.ToString, f10, Brushes.Black, 60, 120 + tinggi)
            e.Graphics.DrawString(dgv_user.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 150, 120 + tinggi)


        Next
        tinggi = 110 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 400)
        e.Graphics.DrawString("Terimakasih !!!!!", f10, Brushes.Black, centermargin, 450, tengah)


    End Sub

    Sub printPD()
        PrintDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PrintDocument1.Print()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 350, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        sql = "SELECT * From pembayaran Where (id_pembayaran like '%" & TextBox1.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        dgv_user.DataSource = ds.Tables("kelas")
    End Sub
    Private Sub txtbln_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbln.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka sesuai format bulan yang di inputkan")
            e.Handled = True
        End If
    End Sub

    Private Sub txtthn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtthn.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("pastikan angka sesuai format tahun yang di inputkan")
            e.Handled = True
        End If
    End Sub
    Private Sub txtidspp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidspp.KeyPress
        connect()
        sql = "SELECT nominal FROM spp WHERE id_spp = '" & Trim(txtidspp.Text) & "' "
        cmd = New SqlCommand(sql, con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtjml.Text = rd.Item("nominal")
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Label12.Text = 1000000
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Text = 1000000
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        connect()
        If TextBox2.Text = 2000000 Then
            MsgBox("Uang anda lebih!!!")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class