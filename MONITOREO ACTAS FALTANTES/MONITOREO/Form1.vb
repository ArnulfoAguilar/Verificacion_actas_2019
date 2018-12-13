Imports System.Data
Imports System.Data.OracleClient

Public Class Form1
    Dim CADENA As String = "server = localhost/orcl:1521; User id= PRUE_RECEP_CAMBIO; Password= Usi123; Unicode= True"
    Dim conn As New OracleConnection(CADENA)
    Public bandera1 As Integer = 0
    Public bandera2 As Integer = 0
    Public bandera3 As Integer = 0
    Public bandera4 As Integer = 0
    Private Sub RadioButtonDEPARTAMENTO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDEPARTAMENTO.CheckedChanged
        checked()
    End Sub

    Private Sub checked()
        If RadioButtonDEPARTAMENTO.Checked Then
            'SI EL RADIOBUTTON DEL DEPARTAMENTO ESTA SELECCIONADO SE OCULTAN LOS DEMAS COMBOBOX
            ComboBoxDepartamento.Show()
            ComboBoxSede.Hide()
            SEDE.Hide()
            ComboBoxMunicipio.Hide()
            MUNICIPIO.Hide()
            ComboBoxCentro_Votacion.Hide()
            CENTROVOTACION.Hide()
        ElseIf RadioButtonSEDE.Checked Then
            'SI EL RADIOBUTTON DEL SEDE ESTA SELECCIONADO SE OCULTAN LOS DEMAS COMBOBOX
            ComboBoxDepartamento.Show()
            ComboBoxSede.Show()
            SEDE.Show()
            ComboBoxMunicipio.Hide()
            MUNICIPIO.Hide()
            ComboBoxCentro_Votacion.Hide()
            CENTROVOTACION.Hide()
        ElseIf RadioButtonMUNICIPIO.Checked Then
            'SI EL RADIOBUTTON DEL MUNICIPIO ESTA SELECCIONADO SE OCULTAN LOS DEMAS COMBOBOX
            ComboBoxDepartamento.Show()
            ComboBoxSede.Show()
            SEDE.Show()
            ComboBoxMunicipio.Show()
            MUNICIPIO.Show()
            ComboBoxCentro_Votacion.Hide()
            CENTROVOTACION.Hide()
        ElseIf RadioButtonCENTRO_VOTACION.Checked Then
            'SI EL RADIOBUTTON DEL CENTRO DE VOTACION ESTA SELECCIONADO SE OCULTAN LOS DEMAS COMBOBOX
            ComboBoxDepartamento.Show()
            ComboBoxSede.Show()
            SEDE.Show()
            ComboBoxMunicipio.Show()
            MUNICIPIO.Show()
            ComboBoxCentro_Votacion.Show()
            CENTROVOTACION.Show()
        End If
    End Sub

    Private Sub RadioButtonSEDE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonSEDE.CheckedChanged
        checked()

    End Sub

    Private Sub RadioButtonMUNICIPIO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMUNICIPIO.CheckedChanged
        checked()
    End Sub

    Private Sub RadioButtonCENTRO_VOTACION_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonCENTRO_VOTACION.CheckedChanged
        checked()
    End Sub
    'METODO PARA CARGAR COMBOBOX DEL DEPARTAMENTO

    Private Sub cargar_comboboxDEPARTAMENTO(ByVal sqlConsult As String)
        Try
            Dim comando1 As New OracleCommand(sqlConsult, conn)
            Dim dataAdapter As New OracleDataAdapter(comando1)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboBoxDepartamento.DataSource = DT
            ComboBoxDepartamento.ValueMember = "ID_DEPARTAMENTO"
            bandera1 = 1
            ComboBoxDepartamento.DisplayMember = "NOMBRE_DEPARTAMENTO"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'METODO PARA CARGAR EL COMBOBOX DE LA SEDE
    Private Sub cargar_comboboxSEDE(ByVal sqlConsult As String)
        Try
            sqlConsult += " where id_departamento=:ID_DEPARTAMENTO order by id_sede"
            Dim comando1 As New OracleCommand(sqlConsult, conn)
            comando1.Parameters.Add(":ID_DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
            Dim dataAdapter As New OracleDataAdapter(comando1)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboBoxSede.DataSource = DT
            ComboBoxSede.ValueMember = "ID_SEDE"
            bandera2 = 1
            ComboBoxSede.DisplayMember = "NOMBRE_SEDE"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'METODO PARA CCARGAR EL COMBOBOX DE LOS MUNICIPIOS
    Private Sub cargar_comboboxMunicipio(ByVal sqlConsult As String)
        Try
            sqlConsult += " where id_departamento=:ID_DEPARTAMENTO and ID_SEDE=:ID_SEDE order by id_municipio"
            Dim comando1 As New OracleCommand(sqlConsult, conn)
            comando1.Parameters.Add(":ID_DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
            comando1.Parameters.Add(":ID_SEDE", OracleType.VarChar, 30).Value = ComboBoxSede.SelectedValue.ToString
            Dim dataAdapter As New OracleDataAdapter(comando1)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboBoxMunicipio.DataSource = DT
            ComboBoxMunicipio.ValueMember = "ID_Municipio"
            bandera3 = 1
            ComboBoxMunicipio.DisplayMember = "NOMBRE_Municipio"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'METODO PARA CARGAR EL COMBOBOX DE LOS CENTROS DE VOTACION
    Private Sub cargar_comboboxCentroVotacion(ByVal sqlConsult As String)
        Try
            sqlConsult += " where id_departamento=:ID_DEPARTAMENTO and ID_SEDE=:ID_SEDE and ID_MUNICIPIO=:ID_MUNICIPIO order by id_centro_votacion "
            Dim comando1 As New OracleCommand(sqlConsult, conn)
            comando1.Parameters.Add(":ID_DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
            comando1.Parameters.Add(":ID_SEDE", OracleType.VarChar, 30).Value = ComboBoxSede.SelectedValue.ToString
            comando1.Parameters.Add(":ID_MUNICIPIO", OracleType.VarChar, 30).Value = ComboBoxMunicipio.SelectedValue.ToString
            Dim dataAdapter As New OracleDataAdapter(comando1)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboBoxCentro_Votacion.DataSource = DT
            ComboBoxCentro_Votacion.ValueMember = "ID_Centro_votacion"
            bandera4 = 1
            ComboBoxCentro_Votacion.DisplayMember = "NOMBRE_centro_votacion"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'METODO PARA CARGAR EL COMBOBOX DE TIPO DE ELECCION
    Private Sub cargar_tipo_eleccion()
        Try
            Dim sqlConsult As String = "Select  * from catalogo_recibida"
            Dim comando1 As New OracleCommand(sqlConsult, conn)
            Dim dataAdapter As New OracleDataAdapter(comando1)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboBoxTipo_eleccion.DataSource = DT
            ComboBoxTipo_eleccion.ValueMember = "ID_catalogo_recibida"
            ComboBoxTipo_eleccion.DisplayMember = "NOMBRE_recibida"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ComboBoxSede_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxSede.SelectedIndexChanged
        If bandera2 = 1 Then
            cargar_comboboxMunicipio("Select distinct id_municipio, nombre_municipio, id_DEPARTAMENTO, ID_SEDE from combobox_monitoreo_view")
            bandera3 = 1
        End If

    End Sub

    Private Sub ComboBoxDepartamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxDepartamento.SelectedIndexChanged
        If bandera1 = 1 Then
            cargar_comboboxSEDE("Select distinct id_sede, nombre_sede from combobox_monitoreo_view")
            bandera2 = 1
            cargar_comboboxMunicipio("Select distinct id_municipio, nombre_municipio, id_DEPARTAMENTO, ID_SEDE from combobox_monitoreo_view")
            bandera3 = 1
            cargar_comboboxCentroVotacion("Select distinct id_centro_VOTACION, NOMBRE_CENTRO_VOTACION, id_municipio, id_DEPARTAMENTO, ID_SEDE from combobox_monitoreo_view ")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButtonGenerarReporte.Enabled = False
        DataGridView1.Enabled = False
        cargar_tipo_eleccion()
        cargar_comboboxDEPARTAMENTO("Select distinct id_departamento, nombre_departamento from combobox_monitoreo_view order by id_departamento")
        bandera1 = 1
        cargar_comboboxSEDE("Select distinct id_sede, nombre_sede from combobox_monitoreo_view")
        bandera2 = 1
        cargar_comboboxMunicipio("Select distinct id_municipio, nombre_municipio, id_DEPARTAMENTO, ID_SEDE from combobox_monitoreo_view")
        bandera3 = 1
        cargar_comboboxCentroVotacion("Select distinct id_centro_VOTACION, NOMBRE_CENTRO_VOTACION, id_municipio, id_DEPARTAMENTO, ID_SEDE from combobox_monitoreo_view ")
    End Sub

    Private Sub ComboBoxMunicipio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxMunicipio.SelectedIndexChanged
        If bandera3 = 1 Then
            cargar_comboboxCentroVotacion("Select distinct id_centro_VOTACION, NOMBRE_CENTRO_VOTACION, id_municipio, id_DEPARTAMENTO, ID_SEDE from combobox_monitoreo_view ")

        End If
    End Sub

    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click

        consulta("SELECT nombre_tipo_eleccion, " & _
        " nombre_tipo_folio, " & _
       " jrv, " & _
        " nombre_centro_votacion, " & _
       " nombre_municipio, " & _
        " NOMBRE_DEPARTAMENTO,NOMBRE_RECIBIDA from reportes_faltantes_view ")
        ButtonGenerarReporte.Enabled = True

    End Sub
    Public Sub consulta(ByVal sqlconsult As String)
        If ComboBoxTipo_eleccion.SelectedValue.ToString <> 3 Then
            Try

                If RadioButtonDEPARTAMENTO.Checked Then
                    sqlconsult += " where id_catalogo_recibida=:CATALOGO_RECIBIDA and  ID_DEPARTAMENTO=:DEPARTAMENTO "
                    Dim comando As New OracleCommand(sqlconsult, conn)
                    comando.Parameters.Add(":CATALOGO_RECIBIDA", OracleType.Int32, 30).Value = ComboBoxTipo_eleccion.SelectedValue.ToString
                    comando.Parameters.Add(":DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
                    EjecutarConsulta(comando) ' Aqui se ejecuta la consulta con el comando ya armado
                ElseIf RadioButtonSEDE.Checked Then
                    sqlconsult += " where id_catalogo_recibida=:CATALOGO_RECIBIDA and  ID_DEPARTAMENTO=:DEPARTAMENTO and ID_SEDE=:SEDE"
                    Dim comando As New OracleCommand(sqlconsult, conn)
                    comando.Parameters.Add(":CATALOGO_RECIBIDA", OracleType.VarChar, 30).Value = ComboBoxTipo_eleccion.SelectedValue.ToString
                    comando.Parameters.Add(":DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
                    comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = ComboBoxSede.SelectedValue.ToString
                    EjecutarConsulta(comando) ' Aqui se ejecuta la consulta con el comando ya armado
                ElseIf RadioButtonMUNICIPIO.Checked Then
                    sqlconsult += " where id_catalogo_recibida=:CATALOGO_RECIBIDA and  ID_DEPARTAMENTO=:DEPARTAMENTO and ID_SEDE=:SEDE and ID_MUNICIPIO=MUNICIPIO"
                    Dim comando As New OracleCommand(sqlconsult, conn)
                    comando.Parameters.Add(":CATALOGO_RECIBIDA", OracleType.VarChar, 30).Value = ComboBoxTipo_eleccion.SelectedValue.ToString
                    comando.Parameters.Add(":DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
                    comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = ComboBoxSede.SelectedValue.ToString
                    comando.Parameters.Add(":MUNICIPIO", OracleType.VarChar, 30).Value = ComboBoxMunicipio.SelectedValue.ToString
                    EjecutarConsulta(comando) ' Aqui se ejecuta la consulta con el comando ya armado

                ElseIf RadioButtonCENTRO_VOTACION.Checked Then
                    sqlconsult += " where id_catalogo_recibida=:CATALOGO_RECIBIDA and  ID_DEPARTAMENTO=:DEPARTAMENTO and ID_SEDE=:SEDE and ID_MUNICIPIO=:MUNICIPIO and ID_CENTRO_VOTACION=:CENTRO_VOTACION"
                    Dim comando As New OracleCommand(sqlconsult, conn)
                    comando.Parameters.Add(":CATALOGO_RECIBIDA", OracleType.VarChar, 30).Value = ComboBoxTipo_eleccion.SelectedValue.ToString
                    comando.Parameters.Add(":DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
                    comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = ComboBoxSede.SelectedValue.ToString
                    comando.Parameters.Add(":MUNICIPIO", OracleType.VarChar, 30).Value = ComboBoxMunicipio.SelectedValue.ToString
                    comando.Parameters.Add(":CENTRO_VOTACION", OracleType.VarChar, 30).Value = ComboBoxCentro_Votacion.SelectedValue.ToString
                    EjecutarConsulta(comando) ' Aqui se ejecuta la consulta con el comando ya armado
                End If


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            Try
              
                If RadioButtonDEPARTAMENTO.Checked Then
                    sqlconsult += " where ID_CATALOGO_RECIBIDA=1 AND ACTA_RECIBIDA=:CATALOGO_RECIBIDA and  ID_DEPARTAMENTO=:DEPARTAMENTO "
                    Dim comando As New OracleCommand(sqlconsult, conn)
                    comando.Parameters.Add(":CATALOGO_RECIBIDA", OracleType.Int32, 30).Value = ComboBoxTipo_eleccion.SelectedValue.ToString
                    comando.Parameters.Add(":DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
                    EjecutarConsulta(comando) ' Aqui se ejecuta la consulta con el comando ya armado
                ElseIf RadioButtonSEDE.Checked Then
                    sqlconsult += " where ID_CATALOGO_RECIBIDA=1 AND ACTA_RECIBIDA=:CATALOGO_RECIBIDA and  ID_DEPARTAMENTO=:DEPARTAMENTO and ID_SEDE=:SEDE"
                    Dim comando As New OracleCommand(sqlconsult, conn)
                    comando.Parameters.Add(":CATALOGO_RECIBIDA", OracleType.VarChar, 30).Value = ComboBoxTipo_eleccion.SelectedValue.ToString
                    comando.Parameters.Add(":DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
                    comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = ComboBoxSede.SelectedValue.ToString
                    EjecutarConsulta(comando) ' Aqui se ejecuta la consulta con el comando ya armado
                ElseIf RadioButtonMUNICIPIO.Checked Then
                    sqlconsult += " where ID_CATALOGO_RECIBIDA=1 AND ACTA_RECIBIDA=:CATALOGO_RECIBIDA and  ID_DEPARTAMENTO=:DEPARTAMENTO and ID_SEDE=:SEDE and ID_MUNICIPIO=MUNICIPIO"
                    Dim comando As New OracleCommand(sqlconsult, conn)
                    comando.Parameters.Add(":CATALOGO_RECIBIDA", OracleType.VarChar, 30).Value = ComboBoxTipo_eleccion.SelectedValue.ToString
                    comando.Parameters.Add(":DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
                    comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = ComboBoxSede.SelectedValue.ToString
                    comando.Parameters.Add(":MUNICIPIO", OracleType.VarChar, 30).Value = ComboBoxMunicipio.SelectedValue.ToString
                    EjecutarConsulta(comando) ' Aqui se ejecuta la consulta con el comando ya armado

                ElseIf RadioButtonCENTRO_VOTACION.Checked Then
                    sqlconsult += " where ID_CATALOGO_RECIBIDA=1 AND ACTA_RECIBIDA=:CATALOGO_RECIBIDA and  ID_DEPARTAMENTO=:DEPARTAMENTO and ID_SEDE=:SEDE and ID_MUNICIPIO=:MUNICIPIO and ID_CENTRO_VOTACION=:CENTRO_VOTACION"
                    Dim comando As New OracleCommand(sqlconsult, conn)
                    comando.Parameters.Add(":CATALOGO_RECIBIDA", OracleType.VarChar, 30).Value = ComboBoxTipo_eleccion.SelectedValue.ToString
                    comando.Parameters.Add(":DEPARTAMENTO", OracleType.VarChar, 30).Value = ComboBoxDepartamento.SelectedValue.ToString
                    comando.Parameters.Add(":SEDE", OracleType.VarChar, 30).Value = ComboBoxSede.SelectedValue.ToString
                    comando.Parameters.Add(":MUNICIPIO", OracleType.VarChar, 30).Value = ComboBoxMunicipio.SelectedValue.ToString
                    comando.Parameters.Add(":CENTRO_VOTACION", OracleType.VarChar, 30).Value = ComboBoxCentro_Votacion.SelectedValue.ToString
                    EjecutarConsulta(comando) ' Aqui se ejecuta la consulta con el comando ya armado
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    ' metodo para ejecutar la consulta
    Private Sub EjecutarConsulta(ByVal comando As OracleCommand)
        Try
        DataGridView1.DataSource = Nothing
        Dim lectorGRID As OracleDataReader = Nothing
        conn.Open()
        lectorGRID = comando.ExecuteReader()
        If lectorGRID.HasRows Then
            Dim dataAdapter As New OracleDataAdapter(comando)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet, "bolsas")
            Me.DataGridView1.DataSource = dataSet.Tables("bolsas")
            conn.Close()

        Else
            MessageBox.Show("No se tienen registros de Folios con este ESTADO en la Ubicacion especificada")
            conn.Close()
        End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conn.Close()
        End Try
       
    End Sub

    Private Sub ButtonGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGenerarReporte.Click

        If ComboBoxTipo_eleccion.SelectedValue.ToString <> 3 Then
            Dim dt As New DataTable
            With dt
                .Columns.Add("NOMBRE_TIPO_ELECCION")
                .Columns.Add("NOMBRE_TIPO_FOLIO")
                .Columns.Add("JRV")
                .Columns.Add("NOMBRE_CENTRO_VOTACION")
                .Columns.Add("NOMBRE_MUNICIPIO")
                .Columns.Add("NOMBRE_DEPARTAMENTO")
                .Columns.Add("NOMBRE_RECIBIDA")

            End With


            For Each dr As DataGridViewRow In DataGridView1.Rows
                dt.Rows.Add(dr.Cells("NOMBRE_TIPO_ELECCION").Value, dr.Cells("NOMBRE_TIPO_FOLIO").Value, _
                dr.Cells("JRV").Value, dr.Cells("NOMBRE_CENTRO_VOTACION").Value, _
                dr.Cells("NOMBRE_MUNICIPIO").Value, dr.Cells("NOMBRE_DEPARTAMENTO").Value, dr.Cells("NOMBRE_RECIBIDA").Value)

            Next
            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReport1
            rptdoc.SetDataSource(dt)
            reporte.CrystalReportViewer1.ReportSource = rptdoc
            reporte.ShowDialog()
            reporte.Dispose()
            DataGridView1.Columns.Clear()
            DataGridView1.Refresh()
        Else

            Dim dt As New DataTable
            With dt
                .Columns.Add("NOMBRE_TIPO_ELECCION")
                .Columns.Add("NOMBRE_TIPO_FOLIO")
                .Columns.Add("JRV")
                .Columns.Add("NOMBRE_CENTRO_VOTACION")
                .Columns.Add("NOMBRE_MUNICIPIO")
                .Columns.Add("NOMBRE_DEPARTAMENTO")
                .Columns.Add("NOMBRE_RECIBIDA")


            End With


            For Each dr As DataGridViewRow In DataGridView1.Rows
                dt.Rows.Add(dr.Cells("NOMBRE_TIPO_ELECCION").Value, dr.Cells("NOMBRE_TIPO_FOLIO").Value, _
                dr.Cells("JRV").Value, dr.Cells("NOMBRE_CENTRO_VOTACION").Value, _
                dr.Cells("NOMBRE_MUNICIPIO").Value, dr.Cells("NOMBRE_DEPARTAMENTO").Value, dr.Cells("NOMBRE_RECIBIDA").Value)

            Next
            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReport1
            rptdoc.SetDataSource(dt)
            reporte.CrystalReportViewer1.ReportSource = rptdoc
            reporte.ShowDialog()
            reporte.Dispose()
            DataGridView1.Columns.Clear()
            DataGridView1.Refresh()

        End If
    End Sub

    Private Sub BUSCARRECIBIDASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUSCARRECIBIDASToolStripMenuItem.Click

    End Sub

    Private Sub BUSCARJRVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUSCARJRVToolStripMenuItem.Click
        BUSCARJRV.Show()
        Me.Hide()


    End Sub

    Private Sub BUSCARPROCESOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUSCARPROCESOSToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()


    End Sub


End Class
