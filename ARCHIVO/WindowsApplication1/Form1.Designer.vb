<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestamo
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Btnconsulta = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Txtacta = New System.Windows.Forms.TextBox
        Me.Btncontinuar = New System.Windows.Forms.Button
        Me.Btnsalir = New System.Windows.Forms.Button
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.rbmanual = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_jrv = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_nombre_responsable = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.rbDevolucion = New System.Windows.Forms.RadioButton
        Me.rbPrestamo = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ARCHIVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRESTAMOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Préstamo de Actas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(244, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ACTA"
        '
        'Btnconsulta
        '
        Me.Btnconsulta.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconsulta.Location = New System.Drawing.Point(590, 310)
        Me.Btnconsulta.Name = "Btnconsulta"
        Me.Btnconsulta.Size = New System.Drawing.Size(153, 32)
        Me.Btnconsulta.TabIndex = 4
        Me.Btnconsulta.Text = "PRESTAR"
        Me.Btnconsulta.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(72, 348)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(768, 334)
        Me.DataGridView1.TabIndex = 5
        '
        'Txtacta
        '
        Me.Txtacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtacta.Location = New System.Drawing.Point(304, 319)
        Me.Txtacta.Name = "Txtacta"
        Me.Txtacta.Size = New System.Drawing.Size(156, 26)
        Me.Txtacta.TabIndex = 7
        '
        'Btncontinuar
        '
        Me.Btncontinuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncontinuar.Location = New System.Drawing.Point(114, 688)
        Me.Btncontinuar.Name = "Btncontinuar"
        Me.Btncontinuar.Size = New System.Drawing.Size(114, 33)
        Me.Btncontinuar.TabIndex = 8
        Me.Btncontinuar.Text = "Continuar"
        Me.Btncontinuar.UseVisualStyleBackColor = True
        '
        'Btnsalir
        '
        Me.Btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsalir.Location = New System.Drawing.Point(725, 688)
        Me.Btnsalir.Name = "Btnsalir"
        Me.Btnsalir.Size = New System.Drawing.Size(115, 33)
        Me.Btnsalir.TabIndex = 10
        Me.Btnsalir.Text = "salir"
        Me.Btnsalir.UseVisualStyleBackColor = True
        '
        'rbcodigo
        '
        Me.rbcodigo.AutoSize = True
        Me.rbcodigo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(21, 19)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(205, 25)
        Me.rbcodigo.TabIndex = 13
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Lectura Código de Barra"
        Me.rbcodigo.UseVisualStyleBackColor = True
        '
        'rbmanual
        '
        Me.rbmanual.AutoSize = True
        Me.rbmanual.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbmanual.Location = New System.Drawing.Point(322, 19)
        Me.rbmanual.Name = "rbmanual"
        Me.rbmanual.Size = New System.Drawing.Size(144, 25)
        Me.rbmanual.TabIndex = 14
        Me.rbmanual.TabStop = True
        Me.rbmanual.Text = "Ingreso Manual"
        Me.rbmanual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "JRV"
        '
        'txt_jrv
        '
        Me.txt_jrv.Location = New System.Drawing.Point(304, 293)
        Me.txt_jrv.Name = "txt_jrv"
        Me.txt_jrv.Size = New System.Drawing.Size(156, 20)
        Me.txt_jrv.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "NOMBRE DE RESPONSABLE"
        '
        'txt_nombre_responsable
        '
        Me.txt_nombre_responsable.Location = New System.Drawing.Point(304, 258)
        Me.txt_nombre_responsable.Name = "txt_nombre_responsable"
        Me.txt_nombre_responsable.Size = New System.Drawing.Size(256, 20)
        Me.txt_nombre_responsable.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.tse_logo2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'rbDevolucion
        '
        Me.rbDevolucion.AutoSize = True
        Me.rbDevolucion.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDevolucion.Location = New System.Drawing.Point(6, 50)
        Me.rbDevolucion.Name = "rbDevolucion"
        Me.rbDevolucion.Size = New System.Drawing.Size(142, 25)
        Me.rbDevolucion.TabIndex = 21
        Me.rbDevolucion.TabStop = True
        Me.rbDevolucion.Text = "DEVOLUCION"
        Me.rbDevolucion.UseVisualStyleBackColor = True
        '
        'rbPrestamo
        '
        Me.rbPrestamo.AutoSize = True
        Me.rbPrestamo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrestamo.Location = New System.Drawing.Point(6, 19)
        Me.rbPrestamo.Name = "rbPrestamo"
        Me.rbPrestamo.Size = New System.Drawing.Size(122, 25)
        Me.rbPrestamo.TabIndex = 20
        Me.rbPrestamo.TabStop = True
        Me.rbPrestamo.Text = "PRESTAMO"
        Me.rbPrestamo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbPrestamo)
        Me.GroupBox1.Controls.Add(Me.rbDevolucion)
        Me.GroupBox1.Location = New System.Drawing.Point(650, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 91)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACCION"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbmanual)
        Me.GroupBox2.Controls.Add(Me.rbcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 52)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ELEGIR TIPO DE INGRESO"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ARCHIVOToolStripMenuItem, Me.PRESTAMOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ARCHIVOToolStripMenuItem
        '
        Me.ARCHIVOToolStripMenuItem.Name = "ARCHIVOToolStripMenuItem"
        Me.ARCHIVOToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ARCHIVOToolStripMenuItem.Text = "Archivo"
        '
        'PRESTAMOToolStripMenuItem
        '
        Me.PRESTAMOToolStripMenuItem.Name = "PRESTAMOToolStripMenuItem"
        Me.PRESTAMOToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.PRESTAMOToolStripMenuItem.Text = "Prestamo"
        '
        'Prestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(892, 742)
        Me.Controls.Add(Me.txt_nombre_responsable)
        Me.Controls.Add(Me.Btnconsulta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_jrv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btnsalir)
        Me.Controls.Add(Me.Btncontinuar)
        Me.Controls.Add(Me.Txtacta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Prestamo"
        Me.Text = "Prestamo de actas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btnconsulta As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txtacta As System.Windows.Forms.TextBox
    Friend WithEvents Btncontinuar As System.Windows.Forms.Button
    Friend WithEvents Btnsalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbmanual As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_jrv As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_responsable As System.Windows.Forms.TextBox
    Friend WithEvents rbDevolucion As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ARCHIVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRESTAMOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
