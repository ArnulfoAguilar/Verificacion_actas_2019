Imports System.Data.OracleClient
Imports System.Data
Imports System
Imports System.Windows.Forms
Imports VB_RFID3_Host_Sample1

Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            conn.Close()
            Dim username As String = UsernameTextBox.Text
            Dim password As String = PasswordTextBox.Text
            Dim sqlConsult As String = "select id_usuario from usuario us join rol rl on us.id_rol=rl.id_rol where us.NOMBRE_USUARIO =:username   AND us.PASSWORD =:password"
            Dim comando As New OracleCommand(sqlConsult, conn)
            comando.Parameters.Add(":username", OracleType.Char, 20).Value = username
            comando.Parameters.Add(":password", OracleType.Char, 20).Value = password
            Dim lector As OracleDataReader = Nothing
            conn.Open()
            lector = comando.ExecuteReader()
            If lector.HasRows Then
                lector.Read()
                Ipreader = Combo_Ubicacion.SelectedValue.ToString
                evento = Comboevento.SelectedValue.ToString
                conn.Close()
                lector.Close()
                AppForm.Show()
                Me.Close()
            Else
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS")
                conn.Close()
                lector.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub cargar_combo_ubicacion()
        Try
            Dim sqlConsult As String = "select NOMBRE_UBICACION,IP_UBICACION from UBICACIONES"
            Dim dataAdapter As New OracleDataAdapter(sqlConsult, conn)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.Combo_Ubicacion.DataSource = DT
            Combo_Ubicacion.ValueMember = "IP_UBICACION"
            Combo_Ubicacion.DisplayMember = "NOMBRE_UBICACION"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub cargar_combo_evento()
        Try
            Dim sqlConsult As String = "select ID_EVENTO, NOMBRE_EVENTO from Evento"
            Dim dataAdapter As New OracleDataAdapter(sqlConsult, conn)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.Comboevento.DataSource = DT
            Comboevento.ValueMember = "ID_EVENTO"
            Comboevento.DisplayMember = "NOMBRE_EVENTO"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar_combo_ubicacion()
        cargar_combo_evento()
    End Sub
End Class
