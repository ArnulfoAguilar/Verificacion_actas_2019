Imports System.Data.OracleClient
Imports System.Data
Public Class Form2
    Dim CADENA As String = "server = localhost/orcl:1521; User id= PRUE_RECEP_CAMBIO; Password= Usi123; Unicode= True"
    Dim conn As New OracleConnection(CADENA)
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Button2.Enabled = False
        DataGridView1.Enabled = False

    End Sub

    Private Sub BUSCARRECIBIDASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles BUSCARRECIBIDASToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()


    End Sub

    Private Sub BUSCARJRVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles BUSCARJRVToolStripMenuItem.Click
        BUSCARJRV.Show()
        Me.Hide()


    End Sub

    Private Sub BUSCARPROCESOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles BUSCARPROCESOSToolStripMenuItem.Click


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Dim sql As String = "Select * from pasos_recepcion_view where id_estado=1"
            llenar_grid(sql)
        ElseIf RadioButton2.Checked Then
            Dim sql As String = "Select * from pasos_recepcion_view where ID_estado=2"
            llenar_grid(sql)
        ElseIf RadioButton3.Checked Then
            Dim sql As String = "Select * from pasos_recepcion_view where id_estado=3"
            llenar_grid(sql)
        ElseIf RadioButton4.Checked Then
            Dim sql As String = "Select * from pasos_recepcion_view where id_estado=4"
            llenar_grid(sql)
        ElseIf RadioButton5.Checked Then
            Dim sql As String = "Select * from pasos_recepcion_view where id_estado=0"
            llenar_grid(sql)
        End If
        Button2.Enabled = True
    End Sub
    Private Sub llenar_grid(ByVal sql As String)
        Try
            Dim comando As New OracleCommand(sql, conn)
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
                MessageBox.Show("No se encuentra ninguna JRV en este proceso")
                conn.Close()
            End If
        Catch ex As Exception

        End Try
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
        If RadioButton1.Checked Then
            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReportRECEPCION
            rptdoc.SetDataSource(dt)
            reporte.CrystalReportViewer1.ReportSource = rptdoc
            reporte.ShowDialog()
            reporte.Dispose()
            DataGridView1.Columns.Clear()
            DataGridView1.Refresh()
            Button2.Enabled = False

        ElseIf RadioButton2.Checked Then
            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReportESCANEO
            rptdoc.SetDataSource(dt)
            reporte.CrystalReportViewer1.ReportSource = rptdoc
            reporte.ShowDialog()
            reporte.Dispose()
            DataGridView1.Columns.Clear()
            DataGridView1.Refresh()
            Button2.Enabled = False

        ElseIf RadioButton3.Checked Then
            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReportORDENAMIENTO
            rptdoc.SetDataSource(dt)
            reporte.CrystalReportViewer1.ReportSource = rptdoc
            reporte.ShowDialog()
            reporte.Dispose()
            DataGridView1.Columns.Clear()
            DataGridView1.Refresh()
            Button2.Enabled = False

        ElseIf RadioButton4.Checked Then
            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReportARCHIVO
            rptdoc.SetDataSource(dt)
            reporte.CrystalReportViewer1.ReportSource = rptdoc
            reporte.ShowDialog()
            reporte.Dispose()
            DataGridView1.Columns.Clear()
            DataGridView1.Refresh()
            Button2.Enabled = False

        ElseIf RadioButton5.Checked Then
            Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            rptdoc = New CrystalReportFALTANTES
            rptdoc.SetDataSource(dt)
            reporte.CrystalReportViewer1.ReportSource = rptdoc
            reporte.ShowDialog()
            reporte.Dispose()
            DataGridView1.Columns.Clear()
            DataGridView1.Refresh()
            Button2.Enabled = False

        End If
        'Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptdoc = New CrystalReport2
        'rptdoc.SetDataSource(dt)
        'reporte.CrystalReportViewer1.ReportSource = rptdoc
        'reporte.ShowDialog()
        'reporte.Dispose()
        'DataGridView1.Columns.Clear()
        'DataGridView1.Refresh()
        'Button2.Enabled = False
    End Sub

    Private Sub JRVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JRVToolStripMenuItem.Click
        BUSCARJRV.Show()
        Me.Hide()

    End Sub

    Private Sub RECIBIDASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECIBIDASToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class