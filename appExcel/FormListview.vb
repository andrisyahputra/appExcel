Public Class FormListview
    Private Sub BTNBROWSE_Click(sender As Object, e As EventArgs) Handles BTNBROWSE.Click
        Dim ofd As New OpenFileDialog
        Dim con As OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim da As New OleDb.OleDbDataAdapter
        'Dim dt As New DataTable

        Try
            With ofd
                .Filter = "Excel Files(*.xlsx)|*.xlsx| All files(*.*)|*.*"
                .FilterIndex = 1
                .Title = "Import data from excel file"
            End With
            If ofd.ShowDialog() = DialogResult.OK Then
                ProgressBar1.Value = 0
                counter = 0
                TXTLOCATION.Text = ofd.FileName

                con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TXTLOCATION.Text + ";Extended Properties=Excel 12.0;")
                con.Open()
                ComboBox1.DataSource = con.GetOleDbSchemaTable(OleDb.OleDbSchemaGuid.Tables, Nothing)
                ComboBox1.DisplayMember = "Table_Name"
                ComboBox1.ValueMember = "Table_Name"

                'With cmd
                '    .Connection = con
                '    .CommandText = "SELECT * FROM [Sheet1$]"
                'End With
                'da.SelectCommand = cmd
                'da.Fill(dt)
                'DataGridView1.DataSource = dt
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PosisiList()
        With ListView1.Columns
            .Add("No. Urute", 100)
            .Add("KODE RFID", 100)
            .Add("Nomor Polisi", 100)
            .Add("KETERANGAN BLOKIR", 100)
            .Add("Title", 100)
            .Add("Nama Perusahaan", 100)
            .Add("Status", 100)
            .Add("Merk / Type", 100)
            .Add("Model", 100)
            .Add("Thn Pembuatan", 100)
            .Add("Kapasitas", 100)
            .Add("Kompartemen", 100)
            .Add("Produk", 100)
            .Add("Nomor Mesin", 100)
            .Add("Nomor Rangka", 100)
            .Add("Hasil Uji Emisi %", 100)
            .Add("Pas Masuk", 100)
            .Add("STNK", 100)
            .Add("KEUR", 100)
            .Add("TERA", 100)
            .Add("IJIN BARANG KHUSUS", 100)
            .Add("SKT", 100)
            .Add("No Pas", 100)
            .Add("STATUS", 100)
            .Add("keterangan", 100)
            .Add("TANGGAL PENERIMAAN", 100)
            .Add("NOMOR SURAT TERA", 100)
            .Add("T1", 100)
            .Add("T2", 100)
            .Add("T3", 100)
            .Add("Ruang kosong(ltr)", 100)
            .Add("Kl (mm/ltr)", 100)
            .Add("T1", 100)
            .Add("T2", 100)
            .Add("T3", 100)
            .Add("Ruang kosong(ltr)", 100)
            .Add("Kl (mm/ltr)", 100)
            .Add("TERA", 100)
            .Add("Th. Pembuatan", 100)
            .Add("No. STNK", 100)
            .Add("Masa Berlaku STNK", 100)
            .Add("No. Keur", 100)
            .Add("Masa Berlaku Kier", 100)
            .Add("No. Dok. Uji Emisi", 100)
            .Add("Hasil Uji Emisi", 100)
            .Add("Masa Berlaku Uji Emisi", 100)
            .Add("No. SPB/SKT", 100)
            .Add("Masa Berlaku SPB/SKT", 100)
            .Add("No. Izin Prinsip Masuk Terminal BBM", 100)
            .Add("No. Izin Masuk", 100)
            .Add("Kode Area", 100)
            .Add("Area", 100)
            .Add("Kode Lokasi", 100)
            .Add("Lokasi", 100)
            .Add("Kode Kategori", 100)
            .Add("Kategori", 100)
            .Add("DELIVERY POINT", 100)
            .Add("SEWA", 100)
            .Add("TARIF", 100)
            .Add("AGEN", 100)
            .Add("INDUSTRI", 100)
            .Add("ANGKUTAN SENDIRI", 100)
            .Add("UMUR", 100)
            .Add("KAT", 100)
            .Add("PRODUK", 100)
            .Add("(ENGKEL/TRONTON/SEMI TRAILER)", 100)
            .Add("PABRIKAN TANGKI", 100)
            .Add("MATERIAL TANGKI", 100)
            .Add("MS/CARBON/AL", 100)
            .Add("PEMBUATAN TANGKI TGL/BLN/TH", 100)
            .Add("STATUS ARMADA", 100)
            .Add("Plat", 100)
            .Add("ASURANSI", 100)
            .Add("ALAMAT", 100)
            .Add("TELEPON", 100)
            .Add("EMAIL", 100)
            .Add("NPWP", 100)
            .Add("PENANGGUNG JAWAB", 100)
            .Add("JABATAN", 100)
            .Add("Data Umur MT", 100)

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If Button1.Text = "Start" Then
        '    If Not BackgroundWorker1.IsBusy = True Then
        '        BackgroundWorker1.RunWorkerAsync()
        '        Button1.Text = "Cencel"
        '    End If
        'ElseIf Button1.Text = "Cencel" Then
        '    If BackgroundWorker1.WorkerReportsProgress Then
        '        If BackgroundWorker1.WorkerSupportsCancellation = True Then
        '            BackgroundWorker1.CancelAsync()
        '            Button1.Text = "Start"
        '        End If
        '    End If
        'End If




        'Try
        '    'Dim filepath As String = TXTLOCATION.Text
        '    'Dim connstring As String = String.Empty
        '    Dim con As OleDb.OleDbConnection

        '    con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TXTLOCATION.Text + ";Extended Properties=Excel 12.0;")
        '    'If filepath.EndsWith(".xls") Then
        '    '    connstring =
        '    'End If
        '    Dim cmd As New OleDb.OleDbDataAdapter("Select * from [" & ComboBox1.Text & "]", con)
        '    'Dim cmd As New OleDb.OleDbDataAdapter("Select * from [Sheet1$A3:D500]", con)
        '    'Dim cmd As New OleDb.OleDbDataAdapter("Select * from [Sheet1$A3]", con)
        '    'cmd.TableMappings.Add("Table", "Table")



        '    Dim dt As New DataSet
        '    cmd.Fill(dt)
        '    'DataGridView1.DataSource = dt.Tables(0)
        '    ListView1.Items.Clear()
        '    For a = 0 To dt.Tables(0).Rows.Count - 1
        '        With ListView1
        '            .Items.Add(dt.Tables(0).Rows(a).Item(0))
        '            .Items(a).SubItems.Add(dt.Tables(0).Rows(a).Item(1))
        '            '.Items(a).SubItems.Add(dt.Tables(0).Rows(a).Item(2))
        '            '.Items(a).SubItems.Add(dt.Tables(0).Rows(a).Item(3))
        '            '.Items(a).SubItems.Add(dt.Tables(0).Rows(a).Item(4))
        '            '.Items(a).SubItems.Add(dt.Tables(0).Rows(a).Item(5))
        '            LBLLOADER.Visible = True
        '        End With

        '    Next

        '    LBLLOADER.Visible = False



        '    'Dim a As Integer
        '    'Try
        '    '    QUERY = "SELECT * FROM relasinilai2 ORDER BY nim"
        '    '    daData = New MySqlDataAdapter(QUERY, CONN)
        '    '    dsData = New DataSet
        '    '    daData.Fill(dsData)
        '    '    ListView1.Items.Clear()
        '    '    For a = 0 To dsData.Tables(0).Rows.Count - 1
        '    '        With ListView1
        '    '            .Items.Add(dsData.Tables(0).Rows(a).Item(0))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(14))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(15))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(18))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(19))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(20))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(21))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(22))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(23))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(24))
        '    '            .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(25))
        '    '        End With
        '    '    Next







        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Dim counter As Integer = 0

    Private Sub FormListview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PosisiList()
        'LBLLOADER.Visible = False
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'For x = 0 To 100
        '    If BackgroundWorker1.CancellationPending = True Then
        '        e.Cancel = True
        '        Exit For
        '    Else
        '        BackgroundWorker1.ReportProgress(x)
        '        System.Threading.Thread.Sleep(300)
        '        Label1.Refresh()
        '    End If
        'Next




        Try
            'Dim filepath As String = TXTLOCATION.Text
            'Dim connstring As String = String.Empty
            Dim con As OleDb.OleDbConnection

            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TXTLOCATION.Text + ";Extended Properties=Excel 12.0;")
            'If filepath.EndsWith(".xls") Then
            '    connstring =
            'End If
            'Dim cmd As New OleDb.OleDbDataAdapter("Select * from [" & ComboBox1.Text & "a3:cb]", con)
            Dim cmd As New OleDb.OleDbDataAdapter("Select * from [" & ComboBox1.Text & "]", con)
            'Dim cmd As New OleDb.OleDbDataAdapter("Select * from [Sheet1$A3:D500]", con)
            'Dim cmd As New OleDb.OleDbDataAdapter("Select * from [Sheet1$A3]", con)
            'cmd.TableMappings.Add("Table", "Table")



            Dim dt As New DataSet
            cmd.Fill(dt)
            'DataGridView1.DataSource = dt.Tables(0)
            ListView1.Items.Clear()
            'ProgressBar1.Minimum = 0
            'ProgressBar1.Maximum = dt.Tables(0).Rows.Count

            For a = 0 To dt.Tables(0).Rows.Count - 1
                With ListView1

                    .Items.Add(DS.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(1))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(2))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(3))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(4))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(5))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(6))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(7))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(8))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(9))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(10))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(11))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(12))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(13))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(14))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(15))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(16))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(17))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(18))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(19))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(20))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(21))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(22))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(23))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(24))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(25))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(26))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(27))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(28))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(29))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(30))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(31))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(32))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(33))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(34))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(35))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(36))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(37))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(38))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(39))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(40))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(41))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(42))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(43))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(44))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(45))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(46))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(47))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(48))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(49))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(50))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(51))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(52))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(53))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(54))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(55))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(56))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(57))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(58))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(59))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(60))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(61))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(62))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(63))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(64))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(65))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(66))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(67))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(68))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(69))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(70))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(71))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(72))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(73))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(74))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(75))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(76))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(77))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(78))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(79))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(80))
                    '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(81))

                End With
                counter = counter + 1
                BackgroundWorker1.ReportProgress(counter)
                ProgressBar1.Value = ProgressBar1.Value + 1
                System.Threading.Thread.Sleep(1)
                Label1.Refresh()




            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'If e.Cancelled = True Then
        '    'Label1.Text = "Cenceled"
        '    ProgressBar1.Value = 0
        'ElseIf e.Error IsNot Nothing Then
        '    MsgBox(e.Error.Message)
        'Else
        '    'ini jika semua selesai
        '    Label2.Text = "selesai"
        '    Button1.Text = "Start"
        'End If

        'ProgressBar1.Value = 0
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'ProgressBar1.Value = e.ProgressPercentage
        'ProgressBar1.Value = e.ProgressPercentage
        'Label2.Text = e.ProgressPercentage.ToString + " %" 'karrena double
        Label1.Text = "Imported    " & e.ProgressPercentage.ToString() & "    of    "

    End Sub


End Class