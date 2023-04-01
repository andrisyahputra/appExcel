<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListview
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNUPLOUD = New System.Windows.Forms.Button()
        Me.BTNBROWSE = New System.Windows.Forms.Button()
        Me.TXTLOCATION = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, -8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "IMPORT DATA EXCEL FILE"
        '
        'BTNUPLOUD
        '
        Me.BTNUPLOUD.Location = New System.Drawing.Point(493, 120)
        Me.BTNUPLOUD.Name = "BTNUPLOUD"
        Me.BTNUPLOUD.Size = New System.Drawing.Size(75, 23)
        Me.BTNUPLOUD.TabIndex = 22
        Me.BTNUPLOUD.Text = "UPLOUD"
        Me.BTNUPLOUD.UseVisualStyleBackColor = True
        '
        'BTNBROWSE
        '
        Me.BTNBROWSE.Location = New System.Drawing.Point(493, 25)
        Me.BTNBROWSE.Name = "BTNBROWSE"
        Me.BTNBROWSE.Size = New System.Drawing.Size(75, 23)
        Me.BTNBROWSE.TabIndex = 23
        Me.BTNBROWSE.Text = "BROWSE"
        Me.BTNBROWSE.UseVisualStyleBackColor = True
        '
        'TXTLOCATION
        '
        Me.TXTLOCATION.Location = New System.Drawing.Point(63, 25)
        Me.TXTLOCATION.Name = "TXTLOCATION"
        Me.TXTLOCATION.Size = New System.Drawing.Size(414, 20)
        Me.TXTLOCATION.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(65, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(413, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(65, 149)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(440, 194)
        Me.ListView1.TabIndex = 45
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "-"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(63, 115)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(414, 28)
        Me.ProgressBar1.TabIndex = 21
        '
        'FormListview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 412)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNUPLOUD)
        Me.Controls.Add(Me.BTNBROWSE)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TXTLOCATION)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FormListview"
        Me.Text = "FormListview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTNUPLOUD As Button
    Friend WithEvents BTNBROWSE As Button
    Friend WithEvents TXTLOCATION As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
