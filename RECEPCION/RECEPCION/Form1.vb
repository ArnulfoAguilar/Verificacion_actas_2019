Imports System.Windows.Forms
Imports System.Data.OracleClient
Imports System.Data
Imports System
Imports System.IO
Imports System.Text

Public Class Form1
#Region "CARGAR GRID"
    Public Sub CargarGrid_BOLSAS_SEGURIDAD(ByVal RUTA As String, ByVal SEDE As String)
        Try
            Dim sqlConsult As String = " select nombre_departamento, nombre_sede, nombre_municipio, codigo_barra " & _
                                    " from cargar_bolsas_seguridad_view where ruta=:RUTA" & _
                                    " and sede=:SEDE and EVENTO=:EVENTO"
            Dim comando As New OracleCommand(sqlConsult, conn)
            comando.Parameters.Add(":RUTA", OracleType.VarChar, 30).Value = RUTA
            comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = SEDE
            comando.Parameters.Add(":EVENTO", OracleType.VarChar, 30).Value = evento
            Dim lector As OracleDataReader = Nothing
            conn.Open()
            lector = comando.ExecuteReader()
            If lector.HasRows Then
                DataGridView1.Refresh()
                Dim dataAdapter As New OracleDataAdapter(comando)
                Dim dataSet As New DataSet
                dataAdapter.Fill(dataSet, "bolsas")
                Me.DataGridView1.DataSource = dataSet.Tables("bolsas")
                conn.Close()
            Else
                conn.Close()
                MessageBox.Show("TODAS LAS BOLSAS DE SEGURIDAD DE ESTA RUTA HAN SIDO RECIBIDAS.")
                'DataGViewArticulos.DataSource = null
                DataGridView1.Columns.Clear()
                DataGridView1.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region
#Region "Actualizar bolsa de seguridad"
    Private Sub Actualizar_bolsa_seguridad()
        Try
            Dim sqlConsult As String = "SELECT BOL.ID_BOLSA_SEGURIDAD FROM BOLSA_SEGURIDAD BOL JOIN CENTRO_VOTACION CV on BOL.ID_CENTRO_VOTACION=CV.ID_CENTRO_VOTACION where BOL.CODIGO_BARRA=:CODIGO_BARRA and CV.ID_SEDE=:SEDE and CV.ID_RUTA=:RUTA"
            Dim comando As New OracleCommand(sqlConsult, conn)
            comando.Parameters.Add(":CODIGO_BARRA", OracleType.VarChar, 30).Value = codigo_barra_txt.Text.ToUpper
            comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = ComboBox1.SelectedValue.ToString
            comando.Parameters.Add(":RUTA", OracleType.VarChar, 30).Value = ComboBox2.SelectedValue.ToString
            Dim lector As OracleDataReader = Nothing
            conn.Open()
            lector = comando.ExecuteReader()
            If lector.HasRows Then
                Do While lector.Read
                    id_bolsa = lector.GetInt32(0)
                Loop

                conn.Close()
                isVerificada()
                If verificado = 0 Then
                    actualizar()
                Else
                    MessageBox.Show("Esta bolsa ya fue RECIBIDA")
                    conn.Close()
                End If

            Else
                lector.Read()
                MessageBox.Show("No se encontro esta bolsa de seguridad. Intente de nuevo o verifique que la RUTA y la SEDE sean las indicadas")
                conn.Close()
                codigo_barra_txt.Text = ""

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub actualizar()
        conn.Close()
        Try
            'Actualizo la bolsa de seguridad que ya fue recibida 
            Dim sqlConsulta As String = "update BOLSA_SEGURIDAD set ID_CATALOGO_RECIBIDA= 2 where codigo_barra =:CODIGO_BARRA"
            Dim comando1 As New OracleCommand(sqlConsulta, conn)
            comando1.Parameters.Add(":CODIGO_BARRA", OracleType.VarChar, 30).Value = codigo_barra_txt.Text.ToUpper
            conn.Open()
            comando1.ExecuteNonQuery()
            conn.Close()
            'Aqui Actualizo la JRV que ya paso por recepcion
            Dim sqlConsultaACTA As String = "update ACTA set ESTADO= 1 where id_bolsa_seguridad =:Bolsa_Seguridad"
            Dim comandoACTA As New OracleCommand(sqlConsultaACTA, conn)
            comandoACTA.Parameters.Add(":Bolsa_Seguridad", OracleType.VarChar, 30).Value = id_bolsa
            conn.Open()
            comandoACTA.ExecuteNonQuery()
            conn.Close()
            codigo_barra_txt.Clear()
            CargarGrid_BOLSAS_SEGURIDAD(ComboBox2.SelectedValue.ToString, ComboBox1.SelectedValue.ToString)
            codigo_barra_txt.Focus()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conn.Close()
        End Try
    End Sub
#End Region
    Private Sub isVerificada()
        Try
            Dim sqlConsult As String = "SELECT * FROM BOLSA_SEGURIDAD WHERE CODIGO_BARRA=:CODIGO_BARRA and ID_CATALOGO_RECIBIDA=2"
            Dim comando As New OracleCommand(sqlConsult, conn)
            comando.Parameters.Add(":CODIGO_BARRA", OracleType.VarChar, 30).Value = codigo_barra_txt.Text.ToUpper
            Dim lector As OracleDataReader = Nothing
            conn.Open()
            lector = comando.ExecuteReader()
            If lector.HasRows Then
                verificado = 1
            Else
                verificado = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#Region "COMBOBOX"
    Private Sub CargarCombobox_sede()
        Try

            Dim sqlConsult As String = "select ID_SEDE, NOMBRE_SEDE from SEDE_LOGISTICA"
            Dim dataAdapter As New OracleDataAdapter(sqlConsult, conn)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboBox1.DataSource = DT
            ComboBox1.ValueMember = "ID_SEDE"
            bandera = 1
            ComboBox1.DisplayMember = "NOMBRE_SEDE"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'Dim bandera As String = 0
    Private Sub CargarCombobox_rutas()
        If bandera = 1 Then
            Try
                Dim sqlConsult As String = "SELECT ID_RUTA, NOMBRE_RUTA FROM RUTA_SEDES WHERE ID_SEDE=:ID_SEDE "
                Dim comando As New OracleCommand(sqlConsult, conn)
                comando.Parameters.Add(":ID_SEDE", OracleType.VarChar, 30).Value = ComboBox1.SelectedValue.ToString
                Dim dataAdapter As New OracleDataAdapter(comando)
                Dim DT As New DataTable
                dataAdapter.Fill(DT)
                Me.ComboBox2.DataSource = DT
                ComboBox2.ValueMember = "ID_RUTA"
                ComboBox2.DisplayMember = "NOMBRE_RUTA"
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If bandera = 1 Then
            CargarCombobox_rutas()
        End If
    End Sub
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombobox_sede()
        DataGridView1.Enabled = False
        codigo_barra_txt.Enabled = False
        buscar_codigo_barra_btn.Enabled = False
        Button1.Enabled = False
        Aceptar_ruta_btn.Enabled = False
    End Sub

    
#Region "REPORTE"
    Private Sub Aceptar_ruta_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar_ruta_btn.Click

        Try
            Dim sqlConsult As String = "select * from reportes_recepcion_view where sede=:sede and trim(ruta)=:ruta and id_catalogo_recibida=2"
            'Dim sqlConsult As String = "select * from reporte_recepcion_view where trim(RUTA) = '" & ComboBox2.SelectedValue.ToString.Trim & _
            '    "' AND SEDE = " & ComboBox1.SelectedValue.ToString & " and id_catalogo_recibida=2"
            conn.Open()

            Dim comando As New OracleCommand(sqlConsult, conn)
            comando.Parameters.Add(":RUTA", OracleType.VarChar, 30).Value = ComboBox2.SelectedValue.ToString.Trim
            comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = ComboBox1.SelectedValue.ToString
            Dim lector As OracleDataReader = Nothing

            lector = comando.ExecuteReader()
            If lector.HasRows Then
                DataGridView1.Refresh()
                Dim dataAdapter As New OracleDataAdapter(comando)
                Dim dataSet As New DataSet
                dataAdapter.Fill(dataSet, "bolsas")
                Me.DataGridView1.DataSource = dataSet.Tables("bolsas")
                conn.Close()

                Dim dt As New DataTable
                With dt
                    .Columns.Add("NOMBRE_DEPARTAMENTO")
                    .Columns.Add("NOMBRE_SEDE")
                    .Columns.Add("NOMBRE_MUNICIPIO")
                    .Columns.Add("NOMBRE_CENTRO_VOTACION")
                    .Columns.Add("NOMBRE_RUTA")
                    .Columns.Add("RUTA")
                    .Columns.Add("SEDE")
                    .Columns.Add("ID_BOLSA_SEGURIDAD")
                    .Columns.Add("CODIGO_BARRA")
                    '' .Columns.Add("ID_CATALOGO_RECIBIDA")
                End With


                For Each dr As DataGridViewRow In DataGridView1.Rows
                    dt.Rows.Add(dr.Cells("NOMBRE_DEPARTAMENTO").Value, _
                                dr.Cells("NOMBRE_SEDE").Value, _
                    dr.Cells("NOMBRE_MUNICIPIO").Value, _
                    dr.Cells("NOMBRE_CENTRO_VOTACION").Value, _
                    dr.Cells("NOMBRE_RUTA").Value, dr.Cells("RUTA").Value, dr.Cells("SEDE").Value, _
                    dr.Cells("ID_BOLSA_SEGURIDAD").Value, dr.Cells("CODIGO_BARRA").Value)
                    ''   ,             dr.Cells("ID_CATALOGO_RECIBIDA").Value)

                Next
                Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                rptdoc = New ReporteRecepcion
                rptdoc.SetDataSource(dt)
                reporte.CrystalReportViewer1.ReportSource = rptdoc
                reporte.ShowDialog()
                reporte.Dispose()
                DataGridView1.Columns.Clear()
                DataGridView1.Refresh()

                buscar_codigo_barra_btn.Enabled = False
                codigo_barra_txt.Enabled = False
                Button1.Enabled = False
                Aceptar_ruta_btn.Enabled = False
                ComboBox1.Enabled = True
                ComboBox2.Enabled = True
                btn_consultar_Ruta_sede.Enabled = True
            Else
                conn.Close()
                MessageBox.Show("No se tienen registros de bolsas recibidas de esta ruta")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
#Region "Botones"
    Private Sub codigo_barra_txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles codigo_barra_txt.KeyDown
        If (e.KeyData = Keys.Enter) Then
            If codigo_barra_txt.Text = "" Then
                MessageBox.Show("El campo esta vacio")
            Else

                Actualizar_bolsa_seguridad()
            End If
        End If
    End Sub
    Private Sub buscar_codigo_barra_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscar_codigo_barra_btn.Click

        If codigo_barra_txt.Text = "" Then
            MessageBox.Show("El campo esta vacio")
        Else
            Actualizar_bolsa_seguridad()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar_Ruta_sede.Click
        conn.Close()
        CargarGrid_BOLSAS_SEGURIDAD(ComboBox2.SelectedValue.ToString, ComboBox1.SelectedValue.ToString)
        buscar_codigo_barra_btn.Enabled = True
        codigo_barra_txt.Enabled = True
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        btn_consultar_Ruta_sede.Enabled = False
        Button1.Enabled = True
        Aceptar_ruta_btn.Enabled = True

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        codigo_barra_txt.Text = ""
        buscar_codigo_barra_btn.Enabled = False
        codigo_barra_txt.Enabled = False
        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        btn_consultar_Ruta_sede.Enabled = True
        DataGridView1.DataSource = Nothing
        Button1.Enabled = False
        Aceptar_ruta_btn.Enabled = False
        conn.Close()
    End Sub
#End Region
End Class
