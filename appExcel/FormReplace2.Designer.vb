<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReplace2
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TXTLOCATION = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnUReplace = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "IMPORT DATA EXCEL FILE"
        '
        'BTNUPLOUD
        '
        Me.BTNUPLOUD.Location = New System.Drawing.Point(617, 86)
        Me.BTNUPLOUD.Name = "BTNUPLOUD"
        Me.BTNUPLOUD.Size = New System.Drawing.Size(75, 23)
        Me.BTNUPLOUD.TabIndex = 22
        Me.BTNUPLOUD.Text = "UPLOUD"
        Me.BTNUPLOUD.UseVisualStyleBackColor = True
        '
        'BTNBROWSE
        '
        Me.BTNBROWSE.Location = New System.Drawing.Point(617, 12)
        Me.BTNBROWSE.Name = "BTNBROWSE"
        Me.BTNBROWSE.Size = New System.Drawing.Size(75, 23)
        Me.BTNBROWSE.TabIndex = 23
        Me.BTNBROWSE.Text = "BROWSE"
        Me.BTNBROWSE.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(187, 117)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(414, 28)
        Me.ProgressBar1.TabIndex = 21
        '
        'TXTLOCATION
        '
        Me.TXTLOCATION.Location = New System.Drawing.Point(186, 49)
        Me.TXTLOCATION.Name = "TXTLOCATION"
        Me.TXTLOCATION.Size = New System.Drawing.Size(414, 20)
        Me.TXTLOCATION.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(186, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(516, 209)
        Me.DataGridView1.TabIndex = 19
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(618, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "TAMPIL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(188, 86)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(413, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'btnUReplace
        '
        Me.btnUReplace.Location = New System.Drawing.Point(617, 122)
        Me.btnUReplace.Name = "btnUReplace"
        Me.btnUReplace.Size = New System.Drawing.Size(128, 23)
        Me.btnUReplace.TabIndex = 22
        Me.btnUReplace.Text = "UPLOUD REPLACE"
        Me.btnUReplace.UseVisualStyleBackColor = True
        '
        'FormReplace2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUReplace)
        Me.Controls.Add(Me.BTNUPLOUD)
        Me.Controls.Add(Me.BTNBROWSE)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TXTLOCATION)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FormReplace2"
        Me.Text = "FormReplace2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTNUPLOUD As Button
    Friend WithEvents BTNBROWSE As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TXTLOCATION As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnUReplace As Button
End Class
