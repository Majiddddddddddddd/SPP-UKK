<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgv_laporan = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dtsampai = New System.Windows.Forms.DateTimePicker()
        Me.dtdari = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChartLaporan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Back = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgv_laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_laporan
        '
        Me.dgv_laporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_laporan.Location = New System.Drawing.Point(249, 113)
        Me.dgv_laporan.Name = "dgv_laporan"
        Me.dgv_laporan.Size = New System.Drawing.Size(505, 117)
        Me.dgv_laporan.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(679, 70)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Load"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dtsampai
        '
        Me.dtsampai.Location = New System.Drawing.Point(504, 70)
        Me.dtsampai.Name = "dtsampai"
        Me.dtsampai.Size = New System.Drawing.Size(147, 20)
        Me.dtsampai.TabIndex = 19
        '
        'dtdari
        '
        Me.dtdari.Location = New System.Drawing.Point(296, 70)
        Me.dtdari.Name = "dtdari"
        Me.dtdari.Size = New System.Drawing.Size(136, 20)
        Me.dtdari.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(438, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Sampai Tgl"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Dari Tgl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(414, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Laporan Pembayaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Kelola Laporan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 452)
        Me.Panel1.TabIndex = 104
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button8.Location = New System.Drawing.Point(0, 113)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(176, 48)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Kelola Petugas"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Kelola Laporan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 48)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Kelola Kelas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 409)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(176, 40)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 360)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 47)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Transaksi Pembayaran"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(0, 266)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(176, 39)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = "Kelola Spp"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button10.Location = New System.Drawing.Point(0, 164)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(176, 48)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Kelola Siswa"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pembayaran_spp.My.Resources.Resources.admin1
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ChartLaporan
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartLaporan.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartLaporan.Legends.Add(Legend1)
        Me.ChartLaporan.Location = New System.Drawing.Point(249, 252)
        Me.ChartLaporan.Name = "ChartLaporan"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "omset"
        Me.ChartLaporan.Series.Add(Series1)
        Me.ChartLaporan.Size = New System.Drawing.Size(249, 155)
        Me.ChartLaporan.TabIndex = 105
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(713, 419)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 20)
        Me.Back.TabIndex = 106
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(695, 236)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(59, 20)
        Me.Button11.TabIndex = 134
        Me.Button11.Text = "Print"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'KelolaLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.ChartLaporan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_laporan)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.dtsampai)
        Me.Controls.Add(Me.dtdari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KelolaLaporan"
        Me.Text = "KelolaLaporan"
        CType(Me.dgv_laporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_laporan As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents dtsampai As DateTimePicker
    Friend WithEvents dtdari As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ChartLaporan As DataVisualization.Charting.Chart
    Friend WithEvents Back As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
