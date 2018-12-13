Imports System.Data.OracleClient
Imports System.Data
Imports System
Imports System.Windows.Forms
Imports RECEPCION

Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim username As String = UsernameTextBox.Text
            Dim password As String = PasswordTextBox.Text
            Dim sqlConsult As String = "select ID_USUARIO from usuario us " & _
                                        " join rol rl on us.id_rol=rl.id_rol where us.NOMBRE_USUARIO =:username " & _
                                        "  AND us.PASSWORD =:password"
            Dim comando As New OracleCommand(sqlConsult, conn)
            comando.Parameters.Add(":username", OracleType.Char, 20).Value = username
            comando.Parameters.Add(":password", OracleType.Char, 20).Value = password
            Dim lector As OracleDataReader = Nothing
            conn.Open()
            lector = comando.ExecuteReader()
            If lector.HasRows Then
                evento = ComboEvento.SelectedValue.ToString
                conn.Close()
                lector.Close()
                Form1.Show()
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
    Private Sub cargar_combo_evento()
        Try
            Dim sqlConsult As String = "SELECT ID_EVENTO, NOMBRE_EVENTO FROM EVENTO"
            Dim dataAdapter As New OracleDataAdapter(sqlConsult, conn)
            Dim DT As New DataTable
            dataAdapter.Fill(DT)
            Me.ComboEvento.DataSource = DT
            ComboEvento.ValueMember = "ID_EVENTO"
            ComboEvento.DisplayMember = "NOMBRE_EVENTO"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar_combo_evento()
    End Sub
End Class
