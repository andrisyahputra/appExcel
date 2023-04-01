Imports MySql.Data.MySqlClient
Public Class FORMTOEXCEL
    Private Sub FORMTOEXCEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function saveData(sql As String)
        Dim CONN As MySqlConnection = New MySqlConnection("server=localhost;User Id=root;password=;Persist Security Info=True;database=coba_import;Convert Zero Datetime=True")
        Dim mysqlcmd As MySqlCommand
        Dim mysqlresult As Boolean

        Try
            CONN.Open()
            mysqlcmd = New MySqlCommand
            With mysqlcmd
                .Connection = CONN
                .CommandText = sql
                mysqlresult = .ExecuteNonQuery
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
        Return mysqlresult

    End Function

    Private Sub BTNBROWSE_Click(sender As Object, e As EventArgs) Handles BTNBROWSE.Click
        Dim ofd As New OpenFileDialog
        Dim con As OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        Try
            With ofd
                .Filter = "Excel Files(*.xlsx)|*.xlsx| All files(*.*)|*.*"
                .FilterIndex = 1
                .Title = "Import data from excel file"
            End With
            If ofd.ShowDialog() = DialogResult.OK Then
                TXTLOCATION.Text = ofd.FileName

                con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TXTLOCATION.Text + ";Extended Properties=Excel 12.0;")
                con.Open()

                With cmd
                    .Connection = con
                    .CommandText = "SELECT * FROM [Sheet1$]"
                End With

                da.SelectCommand = cmd
                da.Fill(dt)
                DataGridView1.DataSource = dt



                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTNUPLOUD_Click(sender As Object, e As EventArgs) Handles BTNUPLOUD.Click
        Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TXTLOCATION.Text + ";Extended Properties=Excel 12.0;")
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim dt As New DataTable
        Dim result As Boolean
        Dim sql As String

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = "SELECT * FROM [Sheet1$]"
            End With
            da.SelectCommand = cmd
            da.Fill(dt)

            For Each r As DataRow In dt.Rows
                sql = "INSERT INTO tbl_employee (fname,lname) VALUES ('" & r(0).ToString & "','" & r(1).ToString & "')"
                result = saveData(sql)
                If result Then
                    Timer1.Start()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Sucessfully imported", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 1
        End If
    End Sub
End Class
