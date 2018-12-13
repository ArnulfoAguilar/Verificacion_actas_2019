Imports System.Data.OracleClient
Imports System.Data

Public Class BUSCARJRV

    Dim CADENA As String = "server = localhost/orcl:1521; User id= PRUE_RECEP_CAMBIO; Password= Usi123; Unicode= True"
    Dim conn As New OracleConnection(CADENA)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sql As String = "select * from pasos_recepcion_view where jrv=:jrv"
            Dim comando As New OracleCommand(sql, conn)
            comando.Parameters.Add(":jrv", OracleType.NVarChar, 30).Value = TextBox1.Text
            Dim lector As OracleDataReader = Nothing
            conn.Open()
            lector = comando.ExecuteReader
            If lector.HasRows Then
                Dim dataAdapter As New OracleDataAdapter(comando)
                Dim dataSet As New DataSet
                dataAdapter.Fill(dataSet, "bolsas")
                Me.DataGridView1.DataSource = dataSet.Tables("bolsas")
                conn.Close()
            Else
                MessageBox.Show("No se encuentra esta JRV en la base de datos, intente de nuevo")
                TextBox1.Clear()
                TextBox1.Focus()
                conn.Close()
            End If
        Catch ex As Exception

        End Try
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dt As New DataTable
        With dt
            .Columns.Add("JRV")
            .Columns.Add("ID_ESTADO")
            .Columns.Add("NOMBRE_CENTRO_VOTACION")
            .Columns.Add("NOMBRE_MUNICIPIO")
            .Columns.Add("NOMBRE_DEPARTAMENTO")
            .Columns.Add("NOMBRE_TIPO_FOLIO")


        End With


        For Each dr As DataGridViewRow In DataGridView1.Rows
            dt.Rows.Add(dr.Cells("JRV").Value, dr.Cells("ID_ESTADO").Value, _
             dr.Cells("NOMBRE_CENTRO_VOTACION").Value, _
            dr.Cells("NOMBRE_MUNICIPIO").Value, dr.Cells("NOMBRE_DEPARTAMENTO").Value, _
            dr.Cells("NOMBRE_TIPO_FOLIO").Value)

        Next
        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New CrystalReport2
        rptdoc.SetDataSource(dt)
        reporte.CrystalReportViewer1.ReportSource = rptdoc
        reporte.ShowDialog()
        reporte.Dispose()
        DataGridView1.Columns.Clear()
        DataGridView1.Refresh()
    End Sub


    Private Sub RECIBIDASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECIBIDASToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub PROCESOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PROCESOSToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BUSCARJRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        DataGridView1.Enabled = False
    End Sub
End Class