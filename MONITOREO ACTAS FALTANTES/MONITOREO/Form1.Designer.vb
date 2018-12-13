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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBoxTipo_eleccion = New System.Windows.Forms.ComboBox()
        Me.ComboBoxDepartamento = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSede = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMunicipio = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCentro_Votacion = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButtonDEPARTAMENTO = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSEDE = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMUNICIPIO = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCENTRO_VOTACION = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonGenerarReporte = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tipoeleccion = New System.Windows.Forms.Label()
        Me.SEDE = New System.Windows.Forms.Label()
        Me.MUNICIPIO = New System.Windows.Forms.Label()
        Me.CENTROVOTACION = New System.Windows.Forms.Label()
        Me.BUSCARRECIBIDASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCARJRVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUSCARPROCESOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxTipo_eleccion
        '
        Me.ComboBoxTipo_eleccion.FormattingEnabled = True
        Me.ComboBoxTipo_eleccion.Location = New System.Drawing.Point(29, 162)
        Me.ComboBoxTipo_eleccion.Name = "ComboBoxTipo_eleccion"
        Me.ComboBoxTipo_eleccion.Size = New System.Drawing.Size(217, 21)
        Me.ComboBoxTipo_eleccion.TabIndex = 0
        '
        'ComboBoxDepartamento
        '
        Me.ComboBoxDepartamento.FormattingEnabled = True
        Me.ComboBoxDepartamento.Location = New System.Drawing.Point(267, 162)
        Me.ComboBoxDepartamento.Name = "ComboBoxDepartamento"
        Me.ComboBoxDepartamento.Size = New System.Drawing.Size(122, 21)
        Me.ComboBoxDepartamento.TabIndex = 1
        '
        'ComboBoxSede
        '
        Me.ComboBoxSede.FormattingEnabled = True
        Me.ComboBoxSede.Location = New System.Drawing.Point(406, 162)
        Me.ComboBoxSede.Name = "ComboBoxSede"
        Me.ComboBoxSede.Size = New System.Drawing.Size(127, 21)
        Me.ComboBoxSede.TabIndex = 2
        '
        'ComboBoxMunicipio
        '
        Me.ComboBoxMunicipio.FormattingEnabled = True
        Me.ComboBoxMunicipio.Location = New System.Drawing.Point(551, 162)
        Me.ComboBoxMunicipio.Name = "ComboBoxMunicipio"
        Me.ComboBoxMunicipio.Size = New System.Drawing.Size(167, 21)
        Me.ComboBoxMunicipio.TabIndex = 3
        '
        'ComboBoxCentro_Votacion
        '
        Me.ComboBoxCentro_Votacion.FormattingEnabled = True
        Me.ComboBoxCentro_Votacion.Location = New System.Drawing.Point(743, 164)
        Me.ComboBoxCentro_Votacion.Name = "ComboBoxCentro_Votacion"
        Me.ComboBoxCentro_Votacion.Size = New System.Drawing.Size(444, 21)
        Me.ComboBoxCentro_Votacion.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'RadioButtonDEPARTAMENTO
        '
        Me.RadioButtonDEPARTAMENTO.AutoSize = True
        Me.RadioButtonDEPARTAMENTO.Checked = True
        Me.RadioButtonDEPARTAMENTO.Location = New System.Drawing.Point(414, 72)
        Me.RadioButtonDEPARTAMENTO.Name = "RadioButtonDEPARTAMENTO"
        Me.RadioButtonDEPARTAMENTO.Size = New System.Drawing.Size(115, 17)
        Me.RadioButtonDEPARTAMENTO.TabIndex = 6
        Me.RadioButtonDEPARTAMENTO.TabStop = True
        Me.RadioButtonDEPARTAMENTO.Text = "DEPARTAMENTO"
        Me.RadioButtonDEPARTAMENTO.UseVisualStyleBackColor = True
        '
        'RadioButtonSEDE
        '
        Me.RadioButtonSEDE.AutoSize = True
        Me.RadioButtonSEDE.Location = New System.Drawing.Point(560, 72)
        Me.RadioButtonSEDE.Name = "RadioButtonSEDE"
        Me.RadioButtonSEDE.Size = New System.Drawing.Size(113, 17)
        Me.RadioButtonSEDE.TabIndex = 7
        Me.RadioButtonSEDE.Text = "SEDE LOGISTICA"
        Me.RadioButtonSEDE.UseVisualStyleBackColor = True
        '
        'RadioButtonMUNICIPIO
        '
        Me.RadioButtonMUNICIPIO.AutoSize = True
        Me.RadioButtonMUNICIPIO.Location = New System.Drawing.Point(704, 72)
        Me.RadioButtonMUNICIPIO.Name = "RadioButtonMUNICIPIO"
        Me.RadioButtonMUNICIPIO.Size = New System.Drawing.Size(81, 17)
        Me.RadioButtonMUNICIPIO.TabIndex = 8
        Me.RadioButtonMUNICIPIO.Text = "MUNICIPIO"
        Me.RadioButtonMUNICIPIO.UseVisualStyleBackColor = True
        '
        'RadioButtonCENTRO_VOTACION
        '
        Me.RadioButtonCENTRO_VOTACION.AutoSize = True
        Me.RadioButtonCENTRO_VOTACION.Location = New System.Drawing.Point(840, 72)
        Me.RadioButtonCENTRO_VOTACION.Name = "RadioButtonCENTRO_VOTACION"
        Me.RadioButtonCENTRO_VOTACION.Size = New System.Drawing.Size(128, 17)
        Me.RadioButtonCENTRO_VOTACION.TabIndex = 9
        Me.RadioButtonCENTRO_VOTACION.Text = "CENTRO VOTACION"
        Me.RadioButtonCENTRO_VOTACION.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1239, 211)
        Me.DataGridView1.TabIndex = 10
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(1193, 162)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 11
        Me.ButtonAceptar.Text = "ACEPTAR"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'ButtonGenerarReporte
        '
        Me.ButtonGenerarReporte.Location = New System.Drawing.Point(974, 429)
        Me.ButtonGenerarReporte.Name = "ButtonGenerarReporte"
        Me.ButtonGenerarReporte.Size = New System.Drawing.Size(183, 23)
        Me.ButtonGenerarReporte.TabIndex = 12
        Me.ButtonGenerarReporte.Text = "GENERAR REPORTE"
        Me.ButtonGenerarReporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "DEPARTAMENTO"
        '
        'tipoeleccion
        '
        Me.tipoeleccion.AutoSize = True
        Me.tipoeleccion.Location = New System.Drawing.Point(26, 148)
        Me.tipoeleccion.Name = "tipoeleccion"
        Me.tipoeleccion.Size = New System.Drawing.Size(51, 13)
        Me.tipoeleccion.TabIndex = 14
        Me.tipoeleccion.Text = "ESTADO"
        '
        'SEDE
        '
        Me.SEDE.AutoSize = True
        Me.SEDE.Location = New System.Drawing.Point(403, 148)
        Me.SEDE.Name = "SEDE"
        Me.SEDE.Size = New System.Drawing.Size(36, 13)
        Me.SEDE.TabIndex = 15
        Me.SEDE.Text = "SEDE"
        '
        'MUNICIPIO
        '
        Me.MUNICIPIO.AutoSize = True
        Me.MUNICIPIO.Location = New System.Drawing.Point(548, 148)
        Me.MUNICIPIO.Name = "MUNICIPIO"
        Me.MUNICIPIO.Size = New System.Drawing.Size(63, 13)
        Me.MUNICIPIO.TabIndex = 16
        Me.MUNICIPIO.Text = "MUNICIPIO"
        '
        'CENTROVOTACION
        '
        Me.CENTROVOTACION.AutoSize = True
        Me.CENTROVOTACION.Location = New System.Drawing.Point(740, 148)
        Me.CENTROVOTACION.Name = "CENTROVOTACION"
        Me.CENTROVOTACION.Size = New System.Drawing.Size(128, 13)
        Me.CENTROVOTACION.TabIndex = 17
        Me.CENTROVOTACION.Text = "CENTRO DE VOTACION"
        '
        'BUSCARRECIBIDASToolStripMenuItem
        '
        Me.BUSCARRECIBIDASToolStripMenuItem.Name = "BUSCARRECIBIDASToolStripMenuItem"
        Me.BUSCARRECIBIDASToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BUSCARRECIBIDASToolStripMenuItem.Text = "RECIBIDAS"
        '
        'BUSCARJRVToolStripMenuItem
        '
        Me.BUSCARJRVToolStripMenuItem.Name = "BUSCARJRVToolStripMenuItem"
        Me.BUSCARJRVToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.BUSCARJRVToolStripMenuItem.Text = "JRV"
        '
        'BUSCARPROCESOSToolStripMenuItem
        '
        Me.BUSCARPROCESOSToolStripMenuItem.Name = "BUSCARPROCESOSToolStripMenuItem"
        Me.BUSCARPROCESOSToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.BUSCARPROCESOSToolStripMenuItem.Text = "PROCESOS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BUSCARRECIBIDASToolStripMenuItem, Me.BUSCARJRVToolStripMenuItem, Me.BUSCARPROCESOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 460)
        Me.Controls.Add(Me.CENTROVOTACION)
        Me.Controls.Add(Me.MUNICIPIO)
        Me.Controls.Add(Me.SEDE)
        Me.Controls.Add(Me.tipoeleccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGenerarReporte)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RadioButtonCENTRO_VOTACION)
        Me.Controls.Add(Me.RadioButtonMUNICIPIO)
        Me.Controls.Add(Me.RadioButtonSEDE)
        Me.Controls.Add(Me.RadioButtonDEPARTAMENTO)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBoxCentro_Votacion)
        Me.Controls.Add(Me.ComboBoxMunicipio)
        Me.Controls.Add(Me.ComboBoxSede)
        Me.Controls.Add(Me.ComboBoxDepartamento)
        Me.Controls.Add(Me.ComboBoxTipo_eleccion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "REPORTES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxTipo_eleccion As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxSede As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCentro_Votacion As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButtonDEPARTAMENTO As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonSEDE As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMUNICIPIO As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCENTRO_VOTACION As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents ButtonGenerarReporte As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tipoeleccion As System.Windows.Forms.Label
    Friend WithEvents SEDE As System.Windows.Forms.Label
    Friend WithEvents MUNICIPIO As System.Windows.Forms.Label
    Friend WithEvents CENTROVOTACION As System.Windows.Forms.Label
    Friend WithEvents BUSCARRECIBIDASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BUSCARJRVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BUSCARPROCESOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip

End Class
