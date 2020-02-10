Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmVerPedidos
    Public SQL As String
    Public Tabla As String
    Public DS_Reporte As Object
    Public Reporte As Object

    Private Sub frmVerPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vReport.ReportSource = CargarReporte(SQL, Tabla, CN, DS_Reporte, Reporte)

        vReport.Refresh()
    End Sub
End Class