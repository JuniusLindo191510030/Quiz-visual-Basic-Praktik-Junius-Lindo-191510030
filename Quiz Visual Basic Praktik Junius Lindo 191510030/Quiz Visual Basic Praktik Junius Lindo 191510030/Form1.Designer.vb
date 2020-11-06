<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nik = New System.Windows.Forms.ComboBox()
        Me.nama = New System.Windows.Forms.ComboBox()
        Me.golongan = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.gaji = New System.Windows.Forms.TextBox()
        Me.tkeluarga = New System.Windows.Forms.TextBox()
        Me.tgaji = New System.Windows.Forms.TextBox()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Golongan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gaji"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tunj. Kel"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TOTAL GAJI"
        '
        'nik
        '
        Me.nik.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.nik.FormattingEnabled = True
        Me.nik.Location = New System.Drawing.Point(112, 75)
        Me.nik.Name = "nik"
        Me.nik.Size = New System.Drawing.Size(190, 21)
        Me.nik.TabIndex = 8
        '
        'nama
        '
        Me.nama.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.nama.FormattingEnabled = True
        Me.nama.Location = New System.Drawing.Point(113, 115)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(190, 21)
        Me.nama.TabIndex = 9
        '
        'golongan
        '
        Me.golongan.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.golongan.FormattingEnabled = True
        Me.golongan.Location = New System.Drawing.Point(113, 155)
        Me.golongan.Name = "golongan"
        Me.golongan.Size = New System.Drawing.Size(190, 21)
        Me.golongan.TabIndex = 10
        '
        'status
        '
        Me.status.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.status.FormattingEnabled = True
        Me.status.Location = New System.Drawing.Point(111, 203)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(191, 21)
        Me.status.TabIndex = 11
        '
        'gaji
        '
        Me.gaji.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gaji.Location = New System.Drawing.Point(111, 245)
        Me.gaji.Name = "gaji"
        Me.gaji.Size = New System.Drawing.Size(190, 20)
        Me.gaji.TabIndex = 12
        '
        'tkeluarga
        '
        Me.tkeluarga.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tkeluarga.Location = New System.Drawing.Point(113, 293)
        Me.tkeluarga.Name = "tkeluarga"
        Me.tkeluarga.Size = New System.Drawing.Size(191, 20)
        Me.tkeluarga.TabIndex = 13
        '
        'tgaji
        '
        Me.tgaji.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tgaji.Location = New System.Drawing.Point(113, 357)
        Me.tgaji.Name = "tgaji"
        Me.tgaji.Size = New System.Drawing.Size(191, 20)
        Me.tgaji.TabIndex = 14
        '
        'btnproses
        '
        Me.btnproses.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnproses.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproses.Location = New System.Drawing.Point(33, 401)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(96, 28)
        Me.btnproses.TabIndex = 15
        Me.btnproses.Text = "Process"
        Me.btnproses.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnhapus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(168, 401)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(96, 28)
        Me.btnhapus.TabIndex = 16
        Me.btnhapus.Text = "Clear"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnkeluar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(294, 401)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(96, 28)
        Me.btnkeluar.TabIndex = 17
        Me.btnkeluar.Text = "Exit"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 518)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.tgaji)
        Me.Controls.Add(Me.tkeluarga)
        Me.Controls.Add(Me.gaji)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.golongan)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.nik)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Gaji Karyawan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nik As ComboBox
    Friend WithEvents nama As ComboBox
    Friend WithEvents golongan As ComboBox
    Friend WithEvents status As ComboBox
    Friend WithEvents gaji As TextBox
    Friend WithEvents tkeluarga As TextBox
    Friend WithEvents tgaji As TextBox
    Friend WithEvents btnproses As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
End Class
