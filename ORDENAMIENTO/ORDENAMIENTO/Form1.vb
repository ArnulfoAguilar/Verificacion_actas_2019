Imports System.Windows.Forms
Imports System.Data.OracleClient
Imports System.Data
Imports System
Imports System.IO
Imports System.Text

Public Class Form1
    Public Sub CargarGrid_ACTAS_FALTANTES()
        Try
            Dim sqlConsult As String = "select FOLIO, JRV from consultar_folio_faltante_view " & _
                                        " where BARCODE=:codigo_BOLSA_ACTA AND EVENTO=:EVENTO"
            Dim comando As New OracleCommand(sqlConsult, conn)
            comando.Parameters.Add(":codigo_BOLSA_ACTA", OracleType.VarChar, 30).Value = txt_bolsa_seguridad.Text.ToUpper
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
                Dim sqlConsulta_actualizar_acta As String = "update ACTA set estado=3, id_catalogo_recibida=2 where barcode =:CODIGO_BARRA"
                Dim comando1 As New OracleCommand(sqlConsulta_actualizar_acta, conn)
                comando1.Parameters.Add(":CODIGO_BARRA", OracleType.VarChar, 30).Value = txt_bolsa_seguridad.Text.ToUpper
                conn.Open()
                comando1.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("FELICIDADES, NINGUN FOLIO FALTA")
                txt_bolsa_seguridad.Enabled = True
                txt_bolsa_seguridad.Clear()
                btn_consultar_bolsa_seguridad.Enabled = True
                txt_acta_faltante.Enabled = False
                boton_ingreso_manual.Enabled = False
                btn_ingresar_acta.Enabled = False
                'DataGViewArticulos.DataSource = null
                DataGridView1.Columns.Clear()
                DataGridView1.Refresh()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conn.Close()
        End Try
    End Sub
    Private Sub btn_consultar_bolsa_seguridad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        buscar_bolsa()

    End Sub
    Private Sub buscar_bolsa()
        conn.Close()
        If txt_bolsa_seguridad.Text = "" Then
            MessageBox.Show("El campo esta vacio, porfavor escanee el codigo de barra de la bolsa de seguridad")

        Else
            Try
                Dim sqlConsulta_BOLSA_EXISTENTE As String = "select * from  ACTA ac  where ac.barcode=:CODIGO_BARRA_BOLSA"
                Dim comando2 As New OracleCommand(sqlConsulta_BOLSA_EXISTENTE, conn)
                comando2.Parameters.Add(":CODIGO_BARRA_BOLSA", OracleType.VarChar, 30).Value = txt_bolsa_seguridad.Text.ToUpper
                Dim lectoras As OracleDataReader = Nothing
                conn.Open()
                lectoras = comando2.ExecuteReader()
                If lectoras.HasRows Then
                    conn.Close()
                    CargarGrid_ACTAS_FALTANTES()
                    txt_bolsa_seguridad.Enabled = False
                    txt_acta_faltante.Enabled = True
                    btn_ingresar_acta.Enabled = True
                    boton_ingreso_manual.Enabled = True
                    txt_acta_faltante.Focus()

                Else
                    conn.Close()
                    MessageBox.Show("Este codigo de barra NO pertenece a la base de datos de Bolsa de seguridad")
                    txt_bolsa_seguridad.Clear()
                    txt_bolsa_seguridad.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btn_ingresar_acta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar_acta.Click
        conn.Close()
        ingresar_folio_faltante()
    End Sub
    Private Sub ingresar_folio_faltante()
        conn.Close()
        If txt_acta_faltante.Text = "" Then
            MessageBox.Show("El campo esta vacio")
        Else
            Try
                Dim sqlConsulta_Seleccionar_bolsas_actas As String = "select * from folio_bolsa_barcode_view where BOLSA_SEGURIDAD_BARCODE=:CODIGO_BARRA_BOLSA and FOLIO_BARCODE=:CODIGO_BARRA_FOLIO"
                Dim comando As New OracleCommand(sqlConsulta_Seleccionar_bolsas_actas, conn)
                comando.Parameters.Add(":CODIGO_BARRA_FOLIO", OracleType.VarChar, 30).Value = txt_acta_faltante.Text.ToUpper
                comando.Parameters.Add(":CODIGO_BARRA_BOLSA", OracleType.VarChar, 30).Value = txt_bolsa_seguridad.Text.ToUpper
                Dim lector2 As OracleDataReader = Nothing
                conn.Open()
                lector2 = comando.ExecuteReader()
                If lector2.HasRows Then
                    conn.Close()
                    isFolioVerificado()

                    If verificado = 0 Then
                        MessageBox.Show("ESTE FOLIO YA ESTA VERIFICADO")
                    Else
                        actualizar_folio()
                    End If

                Else
                    lector2.Read()
                    MessageBox.Show("Esta FOLIO no pertenece a esta JRV")
                    txt_acta_faltante.Clear()
                    txt_acta_faltante.Focus()
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                conn.Close()
            End Try
        End If

    End Sub
    Private Sub actualizar_folio()
        Try

            Dim sqlConsulta_actualizar_acta As String = "update FOLIO set ID_CATALOGO_RECIBIDA=2 where codigo_barra =:CODIGO_BARRA"
            Dim comando1 As New OracleCommand(sqlConsulta_actualizar_acta, conn)
            comando1.Parameters.Add(":CODIGO_BARRA", OracleType.VarChar, 30).Value = txt_acta_faltante.Text.ToUpper
            conn.Open()
            comando1.ExecuteNonQuery()
            conn.Close()
            txt_acta_faltante.Clear()
            'MessageBox.Show("FOLIO FALTANTE actualizado")
            CargarGrid_ACTAS_FALTANTES()
            txt_acta_faltante.Focus()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conn.Close()
        End Try
    End Sub
    Public verificado As Integer
    Private Sub isFolioVerificado()
        Try
            Dim sqlConsulta_BOLSA_EXISTENTE As String = "select * from  folio where CODIGO_BARRA=:CODIGO_BARRA_FOLIO and ID_CATALOGO_RECIBIDA=1"
            Dim comando2 As New OracleCommand(sqlConsulta_BOLSA_EXISTENTE, conn)
            comando2.Parameters.Add(":CODIGO_BARRA_FOLIO", OracleType.VarChar, 30).Value = txt_acta_faltante.Text()
            Dim lectoras As OracleDataReader = Nothing
            conn.Open()
            lectoras = comando2.ExecuteReader()
            If lectoras.HasRows Then
                verificado = 1
                conn.Close()

            Else
                verificado = 0
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conn.Close()
        End Try
        conn.Close()
    End Sub
    Private Sub btn_terminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_terminar.Click
        txt_bolsa_seguridad.Enabled = True
        txt_bolsa_seguridad.Clear()
        btn_consultar_bolsa_seguridad.Enabled = True
        txt_acta_faltante.Clear()
        txt_bolsa_seguridad.Focus()
        boton_ingreso_manual.Enabled = False
        txt_acta_faltante.Enabled = False
        boton_ingreso_manual.Enabled = False
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub boton_ingreso_manual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_ingreso_manual.Click
        Me.Hide()
        ingreso_manual.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_bolsa_seguridad.Focus()
        DataGridView1.Enabled = False
        boton_ingreso_manual.Enabled = True
        txt_acta_faltante.Enabled = False
        btn_ingresar_acta.Enabled = False
        boton_ingreso_manual.Enabled = True
        txt_bolsa_seguridad.Focus()
    End Sub

    Private Sub txt_bolsa_seguridad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_bolsa_seguridad.KeyDown
        If (e.KeyData = Keys.Enter) Then
            If txt_bolsa_seguridad.Text = "" Then
                MessageBox.Show("El campo esta vacio")
            Else
                buscar_bolsa()
            End If
        End If
    End Sub

    Private Sub txt_acta_faltante_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_acta_faltante.KeyDown
        If (e.KeyData = Keys.Enter) Then
            If txt_acta_faltante.Text = "" Then
                MessageBox.Show("El campo esta vacio")
            Else
                ingresar_folio_faltante()

            End If
        End If
    End Sub

    Private Sub btn_consultar_bolsa_seguridad_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_consultar_bolsa_seguridad.Click
        ingresar_folio_faltante()
    End Sub
End Class
