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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_bolsa_seguridad = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btn_ingresar_acta = New System.Windows.Forms.Button
        Me.btn_terminar = New System.Windows.Forms.Button
        Me.txt_acta_faltante = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.boton_ingreso_manual = New System.Windows.Forms.Button
        Me.btn_consultar_bolsa_seguridad = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_bolsa_seguridad
        '
        Me.txt_bolsa_seguridad.Location = New System.Drawing.Point(310, 86)
        Me.txt_bolsa_seguridad.Name = "txt_bolsa_seguridad"
        Me.txt_bolsa_seguridad.Size = New System.Drawing.Size(196, 20)
        Me.txt_bolsa_seguridad.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 112)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(594, 167)
        Me.DataGridView1.TabIndex = 2
        '
        'btn_ingresar_acta
        '
        Me.btn_ingresar_acta.Location = New System.Drawing.Point(512, 296)
        Me.btn_ingresar_acta.Name = "btn_ingresar_acta"
        Me.btn_ingresar_acta.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingresar_acta.TabIndex = 4
        Me.btn_ingresar_acta.Text = "Agregar"
        Me.btn_ingresar_acta.UseVisualStyleBackColor = True
        '
        'btn_terminar
        '
        Me.btn_terminar.Location = New System.Drawing.Point(463, 361)
        Me.btn_terminar.Name = "btn_terminar"
        Me.btn_terminar.Size = New System.Drawing.Size(143, 24)
        Me.btn_terminar.TabIndex = 5
        Me.btn_terminar.Text = "Terminar"
        Me.btn_terminar.UseVisualStyleBackColor = True
        '
        'txt_acta_faltante
        '
        Me.txt_acta_faltante.Location = New System.Drawing.Point(336, 299)
        Me.txt_acta_faltante.Name = "txt_acta_faltante"
        Me.txt_acta_faltante.Size = New System.Drawing.Size(170, 20)
        Me.txt_acta_faltante.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CODIGO DE BARRA DE JRV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CODIGO DE BARRA DE FOLIO FALTANTE"
        '
        'boton_ingreso_manual
        '
        Me.boton_ingreso_manual.Location = New System.Drawing.Point(260, 361)
        Me.boton_ingreso_manual.Name = "boton_ingreso_manual"
        Me.boton_ingreso_manual.Size = New System.Drawing.Size(114, 24)
        Me.boton_ingreso_manual.TabIndex = 9
        Me.boton_ingreso_manual.Text = "Ingreso Manual"
        Me.boton_ingreso_manual.UseVisualStyleBackColor = True
        '
        'btn_consultar_bolsa_seguridad
        '
        Me.btn_consultar_bolsa_seguridad.Location = New System.Drawing.Point(531, 86)
        Me.btn_consultar_bolsa_seguridad.Name = "btn_consultar_bolsa_seguridad"
        Me.btn_consultar_bolsa_seguridad.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar_bolsa_seguridad.TabIndex = 10
        Me.btn_consultar_bolsa_seguridad.Text = "Consultar"
        Me.btn_consultar_bolsa_seguridad.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(669, 397)
        Me.Controls.Add(Me.btn_consultar_bolsa_seguridad)
        Me.Controls.Add(Me.boton_ingreso_manual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_terminar)
        Me.Controls.Add(Me.txt_acta_faltante)
        Me.Controls.Add(Me.btn_ingresar_acta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_bolsa_seguridad)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_bolsa_seguridad As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_ingresar_acta As System.Windows.Forms.Button
    Friend WithEvents btn_terminar As System.Windows.Forms.Button
    Friend WithEvents txt_acta_faltante As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boton_ingreso_manual As System.Windows.Forms.Button
    Friend WithEvents btn_consultar_bolsa_seguridad As System.Windows.Forms.Button

End Class
