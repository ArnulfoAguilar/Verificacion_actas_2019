Imports System.Data
Imports System.Data.OracleClient
Public Class Prestamo
    Dim CADENA As String = "server = ORCL; User id= prue_recep_cambio; Password= usi123; Unicode= True"
    Dim conn As New OracleConnection(CADENA)

    'METODO QUE SE LLAMA AL CARGAR EL FORM
    Private Sub Prestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbcodigo.Checked = True
        rbPrestamo.Checked = True
    End Sub
    'METODO PARA APARECER LOS CAMPOS A LLENAR DEPENDIENDO SI SE HARA POR CODIGO DE BARRA O DIGITADO MANUALMENTE
    Private Sub rbcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcodigo.CheckedChanged
        If rbcodigo.Checked = True Then
            Txtacta.Show()
            Label3.Show()
            txt_jrv.Hide()
            txt_jrv.Clear()
            Label4.Hide()
        Else
            Label3.Hide()
            Txtacta.Hide()
            Txtacta.Clear()
            txt_jrv.Show()
            Label4.Show()
        End If
    End Sub
    'METODO QUE SE EJECUTA AL HACER CLIC EN EL BOTON DE CONSULTA
    Private Sub Btnconsula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnconsulta.Click
        If rbPrestamo.Checked Then

            If rbcodigo.Checked = True Then
                consultar_Codigo()
            Else
                consultar_manual()
            End If

        Else
            If rbcodigo.Checked = True Then
                devolver_Codigo()
            Else
                devolver_manual()
            End If

        End If
    End Sub
   
    'METODO QUE ALTERNA LOS CAMPOS SOLICITADOS DEPENDIENDO SI ES UN PRESTAMO O UNA DEVOLUCION
    Private Sub rbPrestamo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPrestamo.CheckedChanged
        If rbDevolucion.Checked = True Then
            Btnconsulta.Text = "DEVOLVER"
            If rbcodigo.Checked Then
                Txtacta.Show()
                Label3.Show()
                Txtacta.Clear()
                txt_jrv.Hide()
                txt_jrv.Clear()
                Label4.Hide()
                Label5.Show()
                txt_nombre_responsable.Show()
            Else

                Txtacta.Hide()
                Label3.Hide()
                Txtacta.Clear()
                txt_jrv.Show()
                txt_jrv.Clear()
                Label4.Show()
                Label5.Show()
                txt_nombre_responsable.Show()
            End If

        Else
            Btnconsulta.Text = "PRESTAR"
            If rbcodigo.Checked Then
                Txtacta.Show()
                Label3.Show()
                txt_jrv.Hide()
                txt_jrv.Clear()
                Label4.Hide()
                Label5.Show()
                txt_nombre_responsable.Show()
            Else
                Txtacta.Hide()
                Label3.Hide()
                Txtacta.Clear()
                txt_jrv.Show()
                txt_jrv.Clear()
                Label4.Show()
                Label5.Show()
                txt_nombre_responsable.Show()
            End If
        End If
    End Sub
    ' METODO QUE SE LLAMA CUANDO SE APRETA UN ENTER EN el TEXTBOX DE CODIGO DE BARRA DEL ACTA
    Private Sub Txtacta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtacta.KeyDown  
        If e.KeyData = Keys.Enter Then
            If rbPrestamo.Checked Then
                consultar_Codigo()
            Else
                devolver_codigo()
            End If
        End If
    End Sub

    '******************************************************
    '****INICIO DE METODOS PARA LA CONSULTA DE LA JRV******
    '******************************************************

    'VARIABLE QUE GUARDARA EL ID DE LA ACTA 
    Dim ID_ACTA As String = Nothing

    'METODO PARA CONSULTAR SI EL CODIGO DE BARRA DE LA JRV EXISTE Y ACTUALIZAR EL ESTADO A PRESTADO
    Private Sub consultar_Codigo()
        If Txtacta.Text = "" Then
            MessageBox.Show("DIGITE EL CODIGO DEL ACTA")
        Else
            If txt_nombre_responsable.Text = "" Then
                MessageBox.Show("Digite el nombre de la persona a la que se prestara el acta")
            Else
                Try
                    Dim sqlConsult As String = "select folio, jrv, tipo_eleccion, centro_votacion,municipio,departamento from CODIGO_PRESTAMO_VIEW where CODIGO_BARRA=:CODIGO_BARRA_ACTA"
                    Dim comando As New OracleCommand(sqlConsult, conn)
                    comando.Parameters.Add(":CODIGO_BARRA_ACTA", OracleType.VarChar, 30).Value = Txtacta.Text.ToUpper
                    Dim lectorGRID As OracleDataReader = Nothing
                    conn.Open()
                    lectorGRID = comando.ExecuteReader()
                    If lectorGRID.HasRows Then
                        Do While lectorGRID.Read
                            ID_ACTA = lectorGRID.GetString(1)
                        Loop
                        conn.Close()
                        isArchivo()

                       
                    Else
                        conn.Close()
                        MessageBox.Show("NO SE ENCONTRO ESTA ACTA EN NUESTRA BASE DE DATOS")
                        DataGridView1.Columns.Clear()
                        DataGridView1.Refresh()

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    conn.Close()
                End Try
            End If
            conn.Close()
        End If
    End Sub
    'METODO PARA CONSULTAR SI LA JRV DIGITADA EXISTE y ACTUALIZAR EL ESTADO A PRESTADA
    Private Sub consultar_manual()
        If txt_jrv.Text = "" Then
            MessageBox.Show("DIGITE EL NUMERO DEL ACTA")
        Else
            If txt_nombre_responsable.Text = "" Then
                MessageBox.Show("Digite el nombre de la persona a la que se prestara el acta")
            Else
                Try
                    Dim sqlConsult As String = "select folio, jrv, tipo_eleccion, " & _
                    "centro_votacion,municipio,departamento from CODIGO_PRESTAMO_VIEW where ACTA=:ID_ACTA"
                    Dim comando As New OracleCommand(sqlConsult, conn)
                    comando.Parameters.Add(":ID_ACTA", OracleType.VarChar, 30).Value = txt_jrv.Text
                    Dim lectorGRID As OracleDataReader = Nothing
                    conn.Open()
                    lectorGRID = comando.ExecuteReader()
                    If lectorGRID.HasRows Then
                        Do While lectorGRID.Read
                            ID_ACTA = lectorGRID.GetString(1)
                        Loop
                        conn.Close()
                        isArchivo()

                    Else
                        conn.Close()
                        MessageBox.Show("NO SE ENCONTRO ESTA ACTA EN NUESTRA BASE DE DATOS")
                        DataGridView1.Columns.Clear()
                        DataGridView1.Refresh()

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    conn.Close()
                End Try
            End If
            conn.Close()
        End If
    End Sub


    'METODO PARA VERIFICAR SI EL ACTA YA ESTA EN ARCHIVO
    Private Sub isArchivo()
        Try
            Dim sqlConsulta_ACTA_RECIBIDA As String = "select * from acta ac where ID_ACTA=:JRV and ESTADO=4"
            Dim comando1 As New OracleCommand(sqlConsulta_ACTA_RECIBIDA, conn)
            comando1.Parameters.Add(":JRV", OracleType.VarChar, 30).Value = ID_ACTA
            Dim lectorGRIDA As OracleDataReader = Nothing
            conn.Open()
            lectorGRIDA = comando1.ExecuteReader()

            If lectorGRIDA.HasRows Then
                conn.Close()
                isprestada("select id_prestada from acta  where  ID_ACTA=:ID_ACTA and ID_PRESTADA=1")
                If PRESTADA = 0 Then
                    If rbcodigo.Checked Then
                        llenar_grid("select folio, jrv, tipo_eleccion, centro_votacion,municipio,departamento " & _
                                " from CODIGO_PRESTAMO_VIEW where ACTA=:ACTA")
                    ElseIf rbmanual.Checked Then
                        llenar_grid("select folio, jrv, tipo_eleccion, centro_votacion,municipio,departamento " & _
                                " from CODIGO_PRESTAMO_VIEW where ACTA=:ACTA")
                    End If
                  
                    prestar_acta_por_codigo(ID_ACTA)
                    Txtacta.Clear()
                    Txtacta.Focus()
                Else
                    MessageBox.Show("ESTA ACTA, ACTUALMENTE ESTA PRESTADA")
                End If
            Else
                MessageBox.Show("ESTA ACTA AUN NO HA SIDO RECIBIDA EN ARCHIVO")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'VARIABLE PARA DEFINIR UNA BANDERA SI EL ACTA ESTA PRESTADA O NO
    Dim PRESTADA As Integer

    'METODO PARA VERIFICAR SI EL ACTA ESTA PRESTADA
    Private Sub isprestada(ByVal sqlConsulta_ACTA_RECIBIDA As String)
        Try
            'Dim sqlConsulta_ACTA_RECIBIDA As String = "select id_prestada from acta  where  ID_ACTA=:ID_ACTA and ID_PRESTADA=1"
            Dim comando1 As New OracleCommand(sqlConsulta_ACTA_RECIBIDA, conn)
            comando1.Parameters.Add(":ID_ACTA", OracleType.VarChar, 30).Value = ID_ACTA
            Dim lectorGRIDA As OracleDataReader = Nothing
            conn.Open()
            lectorGRIDA = comando1.ExecuteReader()
            If lectorGRIDA.HasRows Then
                PRESTADA = 0
            Else
                PRESTADA = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'METODO PARA LLENAR GRID
    Private Sub llenar_grid(ByVal sqlConsult As String)
        conn.Close()
        conn.Open()
        Dim comando As New OracleCommand(sqlConsult, conn)
        comando.Parameters.Add(":ACTA", OracleType.VarChar, 30).Value = ID_ACTA
        Dim dataAdapter As New OracleDataAdapter(comando)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "ACTA")
        Me.DataGridView1.DataSource = dataSet.Tables("ACTA")
        conn.Close()
    End Sub
    Dim sqlbitacora As String
    'METODO PARA HACER EL UPDATE AL ACTA Y MARCARLA COMO PRESTADA
    Private Sub prestar_acta_por_codigo(ByVal JRV As String)
        conn.Close()
        Try
            Dim sqlConsulta_prestar_acta As String = "update ACTA set ID_PRESTADA=2 where ID_ACTA=:ID_ACTA" ', nombre_persona_prestada=:PERSONA where ID_ACTA =:ID_ACTA"
            Dim comando1 As New OracleCommand(sqlConsulta_prestar_acta, conn)
            comando1.Parameters.Add(":ID_ACTA", OracleType.VarChar, 30).Value = JRV
            'comando1.Parameters.Add(":PERSONA", OracleType.VarChar, 30).Value = txt_nombre_responsable.Text
            conn.Open()
            comando1.ExecuteNonQuery()
            If rbDevolucion.Checked Then
                sqlbitacora = "insert into bitacora_prestamo values (:ID_ACTA,:NOMBRE_PERSONA,3, to_char(sysdate, 'dd-mm-yyyy'),to_char(sysdate, 'HH24:MI'))"
            Else
                sqlbitacora = "insert into bitacora_prestamo values (:ID_ACTA,:NOMBRE_PERSONA,2, to_char(sysdate, 'dd-mm-yyyy'),to_char(sysdate, 'HH24:MI'))"
            End If
            Dim comandobitacora As New OracleCommand(sqlbitacora, conn)
            comandobitacora.Parameters.Add(":ID_ACTA", OracleType.VarChar, 30).Value = ID_ACTA
            comandobitacora.Parameters.Add(":NOMBRE_PERSONA", OracleType.VarChar, 255).Value = txt_nombre_responsable.Text
            comandobitacora.ExecuteNonQuery()
            conn.Close()
            If rbDevolucion.Checked Then
                MessageBox.Show("Devuelta")
            Else
                MessageBox.Show("PRESTADA")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            conn.Close()
        End Try
    End Sub
    'METODO PARA DEVOLVER LA JRV PRESTADA Y ACTUALIZAR EL ESTADO A DEVUELTA POR CODIGO DE BARRA
    Private Sub devolver_codigo()
        If Txtacta.Text = "" Then
            MessageBox.Show("DIGITE EL CODIGO DEL ACTA")
        Else
            Try
                Dim sqlConsult As String = "select folio, jrv, tipo_eleccion, centro_votacion,municipio,departamento from CODIGO_PRESTAMO_VIEW where CODIGO_BARRA=:CODIGO_BARRA_ACTA"
                Dim comando As New OracleCommand(sqlConsult, conn)
                comando.Parameters.Add(":CODIGO_BARRA_ACTA", OracleType.VarChar, 30).Value = Txtacta.Text.ToUpper
                Dim lectorGRID As OracleDataReader = Nothing
                conn.Open()
                lectorGRID = comando.ExecuteReader()
                If lectorGRID.HasRows Then
                    Do While lectorGRID.Read
                        ID_ACTA = lectorGRID.GetString(0)
                    Loop
                    conn.Close()
                    isArchivo_devuelta()

                Else
                    conn.Close()
                    MessageBox.Show("NO SE ENCONTRO ESTA ACTA EN NUESTRA BASE DE DATOS")
                    DataGridView1.Columns.Clear()
                    DataGridView1.Refresh()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                conn.Close()
            End Try
        End If
        conn.Close()

    End Sub
    'METODO PARA COMPROBAR QUE LA JRV YA ESTE EN ARCHIVO DESPUES DE DEVOLVERLA
    Private Sub isArchivo_devuelta()
        Try
            Dim sqlConsulta_ACTA_RECIBIDA As String = "select * from acta ac where ID_ACTA=:JRV and ESTADO=4"
            Dim comando1 As New OracleCommand(sqlConsulta_ACTA_RECIBIDA, conn)
            comando1.Parameters.Add(":JRV", OracleType.VarChar, 30).Value = ID_ACTA
            Dim lectorGRIDA As OracleDataReader = Nothing
            conn.Open()
            lectorGRIDA = comando1.ExecuteReader()

            If lectorGRIDA.HasRows Then
                conn.Close()
                isprestada("select id_prestada from acta  where  ID_ACTA=:ID_ACTA and ID_PRESTADA=2") 'PREGUNTA SI EL ACTA TIENE EL ESTADO DE "PRESTADA"
                If PRESTADA = 0 Then
                    If rbcodigo.Checked Then
                        llenar_grid("select folio, jrv, tipo_eleccion, centro_votacion,municipio,departamento " & _
                                    " from CODIGO_PRESTAMO_VIEW where JRV=:ACTA")
                    Else
                        llenar_grid("select folio, jrv, tipo_eleccion, centro_votacion,municipio,departamento " & _
                                    " from CODIGO_PRESTAMO_VIEW where JRV=:ACTA")
                    End If
                    prestar_acta_por_codigo(ID_ACTA)
                    Txtacta.Clear()
                    Txtacta.Focus()
                Else
                    MessageBox.Show("ESTA ACTA NO DEBERIA DE ESTAR PRESTADA, JUSTIFIQUE SU OBTENCION")
                End If
                Else
                    MessageBox.Show("ESTA ACTA AUN NO HA SIDO RECIBIDA EN ARCHIVO")
                End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'METODO PARA DEVOLVER EL ACTA INGRESADA MANUALMENTE
    Private Sub devolver_manual()
        If txt_jrv.Text = "" Then
            MessageBox.Show("DIGITE EL NUMERO DE LA JRV")
       
        Else
            Try
                Dim sqlConsult As String = "select folio, jrv, tipo_eleccion, centro_votacion,municipio,departamento from CODIGO_PRESTAMO_VIEW where ACTA=:JRV"
                Dim comando As New OracleCommand(sqlConsult, conn)
                comando.Parameters.Add(":JRV", OracleType.VarChar, 30).Value = txt_jrv.Text
                Dim lectorGRID As OracleDataReader = Nothing
                conn.Open()
                lectorGRID = comando.ExecuteReader()
                If lectorGRID.HasRows Then
                    Do While lectorGRID.Read
                        ID_ACTA = lectorGRID.GetString(1)
                    Loop
                    conn.Close()
                    isArchivo_devuelta()

                Else
                    conn.Close()
                    MessageBox.Show("NO SE ENCONTRO ESTA ACTA EN NUESTRA BASE DE DATOS")
                    DataGridView1.Columns.Clear()
                    DataGridView1.Refresh()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                conn.Close()
            End Try
        End If
        conn.Close()
    End Sub
    
    Private Sub ARCHIVOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCHIVOToolStripMenuItem.Click
        Me.Hide()
        ARCHIVO.Show()
    End Sub
End Class
