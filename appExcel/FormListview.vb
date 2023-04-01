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
            .Add("ID NILAI", 60) '0
            .Add("TAHUN AKADEMIK", 100) '1
            '.Add("TAHUN AKADEMIK", 100) '1
            '.Add("TAHUN AKADEMIK", 100) '1
            '.Add("TAHUN AKADEMIK", 100) '1
            '.Add("TAHUN AKADEMIK", 100) '1
            '.Add("TAHUN AKADEMIK", 100) '1
            '.Add("SEMESTER", 70) '2
            '.Add("NIM", 70) '3
            '.Add("NAMA MAHASISWA", 130) '4
            '.Add("NIDN", 70) '14
            '.Add("NAMA DOSEN", 130) '15
            '.Add("KODE MTK", 70) '18
            '.Add("NAMA MATA KULIAH", 130) '19
            '.Add("SKS", 70) '20
            '.Add("NILAI AKHIR", 70)
            '.Add("NILAI HURUF", 70)
            '.Add("BOBOT", 70)
            '.Add("JUMLAH", 70)
            '.Add("KETERANGAN", 120) '25

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
            Dim cmd As New OleDb.OleDbDataAdapter("Select * from [" & ComboBox1.Text & "]", con)
            'Dim cmd As New OleDb.OleDbDataAdapter("Select * from [Sheet1$A3:D500]", con)
            'Dim cmd As New OleDb.OleDbDataAdapter("Select * from [Sheet1$A3]", con)
            'cmd.TableMappings.Add("Table", "Table")



            Dim dt As New DataSet
            cmd.Fill(dt)
            'DataGridView1.DataSource = dt.Tables(0)
            ListView1.Items.Clear()
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = dt.Tables(0).Rows.Count

            For a = 0 To dt.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dt.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dt.Tables(0).Rows(a).Item(1))

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