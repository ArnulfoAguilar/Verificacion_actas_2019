<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingreso_manual
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
        Me.btn_ingresar = New System.Windows.Forms.Button
        Me.JRV = New System.Windows.Forms.Label
        Me.FOLIO = New System.Windows.Forms.Label
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.ComboBox_JRV = New System.Windows.Forms.ComboBox
        Me.ComboBox_FOLIO = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(227, 453)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingresar.TabIndex = 0
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'JRV
        '
        Me.JRV.AutoSize = True
        Me.JRV.Location = New System.Drawing.Point(11, 25)
        Me.JRV.Name = "JRV"
        Me.JRV.Size = New System.Drawing.Size(27, 13)
        Me.JRV.TabIndex = 3
        Me.JRV.Text = "JRV"
        '
        'FOLIO
        '
        Me.FOLIO.AutoSize = True
        Me.FOLIO.Location = New System.Drawing.Point(228, 25)
        Me.FOLIO.Name = "FOLIO"
        Me.FOLIO.Size = New System.Drawing.Size(38, 13)
        Me.FOLIO.TabIndex = 4
        Me.FOLIO.Text = "FOLIO"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(326, 453)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 5
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'ComboBox_JRV
        '
        Me.ComboBox_JRV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_JRV.FormattingEnabled = True
        Me.ComboBox_JRV.Location = New System.Drawing.Point(14, 41)
        Me.ComboBox_JRV.Name = "ComboBox_JRV"
        Me.ComboBox_JRV.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_JRV.TabIndex = 6
        '
        'ComboBox_FOLIO
        '
        Me.ComboBox_FOLIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_FOLIO.FormattingEnabled = True
        Me.ComboBox_FOLIO.Location = New System.Drawing.Point(231, 41)
        Me.ComboBox_FOLIO.Name = "ComboBox_FOLIO"
        Me.ComboBox_FOLIO.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_FOLIO.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(378, 255)
        Me.DataGridView1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_JRV)
        Me.GroupBox1.Controls.Add(Me.ComboBox_FOLIO)
        Me.GroupBox1.Controls.Add(Me.FOLIO)
        Me.GroupBox1.Controls.Add(Me.JRV)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 71)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingreso Manual"
        '
        'ingreso_manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(430, 488)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ingreso_manual"
        Me.Text = "ingreso_manual"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents JRV As System.Windows.Forms.Label
    Friend WithEvents FOLIO As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents ComboBox_JRV As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_FOLIO As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
