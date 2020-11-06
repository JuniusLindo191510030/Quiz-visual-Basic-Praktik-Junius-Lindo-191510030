Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        golongan.Items.Add("Manager")
        golongan.Items.Add("Chef")
        golongan.Items.Add("Pelayan & Kasir")

        status.Items.Add("Sudah Menikah")
        status.Items.Add("Belum Menikah")

        nik.Items.Add("001")
        nik.Items.Add("002")
        nik.Items.Add("003")
        nik.Items.Add("004")
        nik.Items.Add("005")
        nik.Items.Add("006")
        nik.Items.Add("007")
        nik.Items.Add("008")
        nik.Items.Add("009")
        nik.Items.Add("009")
        nik.Items.Add("010")
    End Sub

    Private Sub golongan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles golongan.SelectedIndexChanged
        If golongan.Text = "Manager" Then
            gaji.Text = 5000000
        ElseIf golongan.Text = "Chef" Then
            gaji.Text = 4000000
        ElseIf golongan.Text = "Pelayan & Kasir" Then
            gaji.Text = 3000000
        Else
            gaji.Text = 0
        End If
    End Sub

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        tgaji.Text = Val(tkeluarga.Text) + Val(gaji.Text)
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles status.SelectedIndexChanged
        If status.Text = "Sudah Menikah" Then
            tkeluarga.Text = 0.15 * gaji.Text
        ElseIf status.Text = "Belum Menikah" Then
            tkeluarga.Text = 0.25 * gaji.Text
        Else
            tkeluarga.Text = 0
        End If
    End Sub

    Private Sub nama_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nama.SelectedIndexChanged

    End Sub

    Private Sub nik_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nik.SelectedIndexChanged
        If nik.Text = "001" Then
            nama.Text = "Junius Lindo"
        ElseIf nik.Text = "002" Then
            nama.Text = "Budi Setiawan"
        ElseIf nik.Text = "003" Then
            nama.Text = "Budy"
        ElseIf nik.Text = "004" Then
            nama.Text = "Andi Sanjaya"
        ElseIf nik.Text = "005" Then
            nama.Text = "Rudiwan"
        ElseIf nik.Text = "006" Then
            nama.Text = "Hendri lie"
        ElseIf nik.Text = "007" Then
            nama.Text = "Hanjaya"
        ElseIf nik.Text = "008" Then
            nama.Text = "Yanto"
        ElseIf nik.Text = "009" Then
            nama.Text = "Hendrawan"
        ElseIf nik.Text = "010" Then
            nama.Text = "Tomie"
        Else
            nama.Text = 0

        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        nik.Text = ""
        nama.Text = ""
        golongan.Text = ""
        gaji.Text = ""
        status.Text = ""
        tkeluarga.Text = ""
        tgaji.Text = ""
    End Sub

    Private Sub tkeluarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tkeluarga.TextChanged

    End Sub
End Class
