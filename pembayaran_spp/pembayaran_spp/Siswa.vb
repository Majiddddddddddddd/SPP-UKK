Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Siswa
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Sub aturdgv()
        sql = "SELECT nisn, jumlah_bayar, tgl_bayar FROM pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgvadmin.DataSource = ds.Tables("pembayaran")
    End Sub
    Private Sub Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "SELECT * from pembayaran WHERE tgl_bayar='" & dtadmin.Value.Date.ToString("MM/dd/yyyy") & "'"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        dgvadmin.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 80)
        e.Graphics.DrawString("nisn", f10, Brushes.Black, 20, 95)
        e.Graphics.DrawString("harga", f10, Brushes.Black, 60, 95)
        e.Graphics.DrawString("tanggal bayar", f10, Brushes.Black, 150, 95)
        dgvadmin.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To dgvadmin.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(dgvadmin.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 20, 100 + tinggi)
            e.Graphics.DrawString(dgvadmin.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 60, 100 + tinggi)
            e.Graphics.DrawString(dgvadmin.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 150, 100 + tinggi)


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
End Class