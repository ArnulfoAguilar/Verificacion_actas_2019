Imports System.Windows.Forms
Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.OracleClient
Imports WindowsApplication1.Form1
Public Class ingreso_manual
    Public cadena As String = "server = ORCL; User id = prue_recep_cambio; Password =usi123; Unicode =True"
    Public conn As New OracleConnection(cadena)

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
       
        Try
            Dim sqlConsulta_acta_existente As String = "SELECT * FROM tipo_folio tpfol join FOLIO fol on tpfol.id_tipo_folio=fol.id_tipo_folio join ACTA ac on fol.ID_ACTA=ac.ID_ACTA  where ac.JRV=:JRV and tpfol.id_tipo_folio=:FOLIO and fol.id_catalogo_recibida=1"
            Dim comando2 As New OracleCommand(sqlConsulta_acta_existente, conn)
            comando2.Parameters.Add(":JRV", OracleType.VarChar, 30).Value = ComboBox_JRV.SelectedValue.ToString
            comando2.Parameters.Add(":FOLIO", OracleType.VarChar, 30).Value = ComboBox_FOLIO.SelectedValue.ToString
            'comando2.Parameters.Add(":BOLSA", OracleType.VarChar, 30).Value = Form1.txt_bolsa_seguridad.Text()
            Dim lectorGRID As OracleDataReader = Nothing
            conn.Open()
            lectorGRID = comando2.ExecuteReader()
            If lectorGRID.HasRows Then
                conn.Close()
                Dim sqlConsulta_actualizar_acta As String = "update FOLIO set ID_CATALOGO_RECIBIDA=2 where ID_TIPO_FOLIO=:folio and id_acta=:JRV"
                Dim comando1 As New OracleCommand(sqlConsulta_actualizar_acta, conn)
                comando1.Parameters.Add(":JRV", OracleType.VarChar, 30).Value = ComboBox_JRV.SelectedValue.ToString
                comando1.Parameters.Add(":folio", OracleType.VarChar, 30).Value = ComboBox_FOLIO.SelectedValue.ToString
                conn.Open()
                comando1.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("FOLIO FALTANTE actualizado")
                'conn.Close()
            Else
                MessageBox.Show("No se encontro el FOLIO especificado en esta BOLSA DE SEGURIDAD, revise que la JRV y el folio sean los correctos, O ESTE FOLIO YA SE ENTREGO")
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conn.Close()
        End Try
        conn.Close()
    End Sub

    
    Private Sub CargarCombobox_JRV()
        Try

            Dim sqlConsult As String = "select distinct id_acta from acta"
            Dim comando1 As New OracleCommand(sqlConsult, conn)
            'comando1.Parameters.Add(":BOLSA", OracleType.VarChar, 30).Value = Form1.txt_bolsa_seguridad.Text()
            Dim dataAdapter As New OracleDataAdapter(comando1)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboBox_JRV.DataSource = DT
            ComboBox_JRV.ValueMember = "id_acta"
            bandera = 1
            ComboBox_JRV.DisplayMember = "id_acta"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Dim bandera As Integer
    Private Sub CargarCombobox_FOLIO()
        Try

            Dim sqlConsult As String = "select * from TIPO_FOLIO tpfol " & _
                                        " join folio fol on tpfol.ID_TIPO_FOLIO=fol.ID_TIPO_FOLIO " & _
                                        " join acta ac on fol.ID_ACTA=ac.ID_ACTA  where AC.ID_ACTA=:id_acta AND AC.ID_EVENTO=:EVENTO"
            Dim comando1 As New OracleCommand(sqlConsult, conn)
            comando1.Parameters.Add(":id_acta", OracleType.VarChar, 30).Value = ComboBox_JRV.SelectedValue.ToString
            comando1.Parameters.Add(":EVENTO", OracleType.VarChar, 30).Value = evento
            Dim dataAdapter As New OracleDataAdapter(comando1)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboBox_FOLIO.DataSource = DT
            ComboBox_FOLIO.ValueMember = "ID_TIPO_FOLIO"
            ComboBox_FOLIO.DisplayMember = "NOMBRE_TIPO_FOLIO"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub ingreso_manual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombobox_JRV()
        CargarCombobox_FOLIO()

    End Sub

    Private Sub ComboBox_JRV_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_JRV.SelectedIndexChanged
        If bandera = 1 Then
            Try

                Dim sqlConsult As String = "select * from TIPO_FOLIO tpfol " & _
                                            " join folio fol on tpfol.ID_TIPO_FOLIO=fol.ID_TIPO_FOLIO " & _
                                            " join acta ac on fol.ID_ACTA=ac.ID_ACTA " & _
                                            "  where AC.ID_ACTA=:id_acta AND AC.ID_EVENTO=EVENTO"
                Dim comando1 As New OracleCommand(sqlConsult, conn)
                comando1.Parameters.Add(":id_acta", OracleType.VarChar, 30).Value = ComboBox_JRV.SelectedValue.ToString
                comando1.Parameters.Add(":id_acta", OracleType.VarChar, 30).Value = evento
                Dim dataAdapter As New OracleDataAdapter(comando1)
                Dim DT As New DataTable
                dataAdapter.Fill(DT)
                Me.ComboBox_FOLIO.DataSource = DT
                ComboBox_FOLIO.ValueMember = "ID_TIPO_FOLIO"
                ComboBox_FOLIO.DisplayMember = "NOMBRE_TIPO_FOLIO"
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try


            'llenar grid

            Try
                Dim sqlConsult As String = "select FOLIO, JRV from consultar_folio_faltante_view where JRV=:JRV AND EVENTO=:EVENTO"
                Dim comando As New OracleCommand(sqlConsult, conn)
                comando.Parameters.Add(":JRV", OracleType.VarChar, 30).Value = ComboBox_JRV.SelectedValue.ToString
                comando.Parameters.Add(":EVENTO", OracleType.VarChar, 30).Value = evento
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
                    conn.Close()
                    Dim sqlConsulta_actualizar_acta As String = "update ACTA set estado=3, id_catalogo_recibida=2 where JRV=:JRV"
                    Dim comando1 As New OracleCommand(sqlConsulta_actualizar_acta, conn)
                    comando.Parameters.Add(":JRV", OracleType.VarChar, 30).Value = ComboBox_JRV.SelectedValue.ToString
                    conn.Open()
                    comando.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("FELICIDADES, NINGUN FOLIO FALTA")
                End If
                       Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

End Class