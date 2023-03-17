<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransaksiPetugas
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
        Me.Dttglbayar = New System.Windows.Forms.DateTimePicker()
        Me.txtnisn = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtjml = New System.Windows.Forms.TextBox()
        Me.txtid_pet = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtthn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_user = New System.Windows.Forms.DataGridView()
        Me.txtid_pem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbln = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtidspp = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dttglbayar
        '
        Me.Dttglbayar.Location = New System.Drawing.Point(241, 201)
        Me.Dttglbayar.Name = "Dttglbayar"
        Me.Dttglbayar.Size = New System.Drawing.Size(189, 20)
        Me.Dttglbayar.TabIndex = 153
        '
        'txtnisn
        '
        Me.txtnisn.FormattingEnabled = True
        Me.txtnisn.Items.AddRange(New Object() {"123", "234", "345", "456", "567", "678"})
        Me.txtnisn.Location = New System.Drawing.Point(241, 161)
        Me.txtnisn.Name = "txtnisn"
        Me.txtnisn.Size = New System.Drawing.Size(190, 21)
        Me.txtnisn.TabIndex = 152
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(530, 187)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Jumlah Bayar"
        '
        'txtjml
        '
        Me.txtjml.Location = New System.Drawing.Point(532, 201)
        Me.txtjml.Name = "txtjml"
        Me.txtjml.Size = New System.Drawing.Size(187, 20)
        Me.txtjml.TabIndex = 150
        '
        'txtid_pet
        '
        Me.txtid_pet.FormattingEnabled = True
        Me.txtid_pet.Items.AddRange(New Object() {"1", "2"})
        Me.txtid_pet.Location = New System.Drawing.Point(241, 119)
        Me.txtid_pet.Name = "txtid_pet"
        Me.txtid_pet.Size = New System.Drawing.Size(190, 21)
        Me.txtid_pet.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(533, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Id Spp"
        '
        'txtthn
        '
        Me.txtthn.Location = New System.Drawing.Point(532, 119)
        Me.txtthn.Name = "txtthn"
        Me.txtthn.Size = New System.Drawing.Size(187, 20)
        Me.txtthn.TabIndex = 146
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Nisn"
        '
        'dgv_user
        '
        Me.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user.Location = New System.Drawing.Point(242, 265)
        Me.dgv_user.Name = "dgv_user"
        Me.dgv_user.Size = New System.Drawing.Size(504, 167)
        Me.dgv_user.TabIndex = 144
        '
        'txtid_pem
        '
        Me.txtid_pem.Location = New System.Drawing.Point(242, 74)
        Me.txtid_pem.Name = "txtid_pem"
        Me.txtid_pem.Size = New System.Drawing.Size(189, 20)
        Me.txtid_pem.TabIndex = 143
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(529, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Tahun Bayar"
        '
        'txtbln
        '
        Me.txtbln.Location = New System.Drawing.Point(532, 74)
        Me.txtbln.Name = "txtbln"
        Me.txtbln.Size = New System.Drawing.Size(187, 20)
        Me.txtbln.TabIndex = 142
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(403, 237)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 141
        Me.Button7.Text = "Hapus"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(322, 237)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 140
        Me.Button6.Text = "Edit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(529, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Bulan Bayar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Tgl Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Id Petugas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "Id Pembayaran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(399, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 20)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Transaksi Pembayaran"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(241, 237)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 133
        Me.Button5.Text = "Tambah"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 470)
        Me.Panel1.TabIndex = 154
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(0, 232)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(176, 40)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(0, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 47)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Transaksi Pembayaran"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pembayaran_spp.My.Resources.Resources.ceo
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(687, 438)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(59, 20)
        Me.Back.TabIndex = 155
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(687, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 20)
        Me.Button1.TabIndex = 156
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(590, 242)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 20)
        Me.TextBox1.TabIndex = 157
        '
        'txtidspp
        '
        Me.txtidspp.FormattingEnabled = True
        Me.txtidspp.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.txtidspp.Location = New System.Drawing.Point(532, 164)
        Me.txtidspp.Name = "txtidspp"
        Me.txtidspp.Size = New System.Drawing.Size(187, 21)
        Me.txtidspp.TabIndex = 158
        '
        'TransaksiPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.txtidspp)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dttglbayar)
        Me.Controls.Add(Me.txtnisn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtjml)
        Me.Controls.Add(Me.txtid_pet)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtthn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_user)
        Me.Controls.Add(Me.txtid_pem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbln)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransaksiPetugas"
        Me.Text = "TransaksiPetugas"
        CType(Me.dgv_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dttglbayar As DateTimePicker
    Friend WithEvents txtnisn As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtjml As TextBox
    Friend WithEvents txtid_pet As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtthn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_user As DataGridView
    Friend WithEvents txtid_pem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbln As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Back As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtidspp As ComboBox
End Class
