Imports System.Data
Imports System.Data.OracleClient

Public Class ARCHIVO
    Dim CADENA As String = "server = ORCL; User id =prue_recep_cambio; Password = usi123; Unicode =True"
    Dim conn As New OracleConnection(CADENA)
    Dim departamento As String
    Dim sede As String
    Dim municipio As String
    Dim centro As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        empezar()
    End Sub

    Private Sub empezar()
        Try
            Dim sql As String
            If RadioButton1.Checked = True Then
                sql = "select * from bolsas_jrv where barcode=:barcode"
            ElseIf RadioButton2.Checked Then
                sql = "select * from bolsas_jrv where id_acta=:barcode"
            End If
            Dim comando As New OracleCommand(sql, conn)
            comando.Parameters.Add(":barcode", OracleType.VarChar, 30).Value = TextBox1.Text.ToUpper
            Dim lector As OracleDataReader = Nothing
            conn.Open()
            lector = comando.ExecuteReader
            If lector.HasRows Then
                Do While lector.Read
                    departamento = lector.GetString(0)
                    sede = lector.GetString(1)
                    municipio = lector.GetString(2)
                    centro = lector.GetString(3)
                Loop

                LabelDEPARTAMENTO.Text = departamento
                LabelSEDE.Text = sede
                LabelMUNICIPIO.Text = municipio
                LabelCENTRO.Text = centro
                conn.Close()
                actualizar_estado_bolsa()
                MessageBox.Show("ARCHIVADA CORRECTAMENTE")
                TextBox1.Clear()
                TextBox1.Focus()
            Else
                conn.Close()
                MessageBox.Show("ESTA CODIGO DE BOLSA DE SEGURIDAD NO SE ENCUENTRA EN LA BASE DE DATOS")
            End If
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ARCHIVO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelDEPARTAMENTO.Text = Nothing
        LabelCENTRO.Text = Nothing
        LabelMUNICIPIO.Text = Nothing
        LabelSEDE.Text = Nothing
        labelARCHIVADA.Text = ""
        RadioButton1.Checked = True
    End Sub

    Private Sub PrestamoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrestamoToolStripMenuItem.Click
        Me.Hide()
        Prestamo.Show()
    End Sub
    Private Sub actualizar_estado_bolsa()
        Dim sql As String
        Try
            If RadioButton1.Checked Then
                sql = "update acta set estado=4 where barcode=:barcode"
            Else
                sql = "update acta set estado=4 where id_acta=:barcode"
            End If

            Dim comando As New OracleCommand(Sql, conn)
            comando.Parameters.Add(":barcode", OracleType.VarChar, 30).Value = TextBox1.Text.ToUpper
            conn.Open()
            comando.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            If TextBox1.Text = "" Then
                MessageBox.Show("EL CAMPO ESTA VACIO")
            Else
                empezar()
            End If
        End If
    End Sub

End Class