Public Class frmFactSaldoXVendedor
    Private Sub frmFactSaldoXVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim MyDs As DataSet

        'MyDs = DameDataSet("exec sp_DSC_CostoPromedio", CN)
        lstLista.DataSource = DameDataSet("exec sp_d_Facturas 0, -1", CN)

    End Sub

    Private Sub lstLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles lstLista.InitializeLayout
        e.Layout.Bands(0).Columns("Nombre_Vendedor").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        e.Layout.Bands(0).Columns("Beneficiario").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True

        e.Layout.Bands(0).Columns("Numero_de_documento").Header.Caption = "No. Factura"
        e.Layout.Bands(0).Columns("Nombre_Vendedor").Header.Caption = "Vendedor"
        e.Layout.Bands(0).Columns("Total_Neto_Calculado").Header.Caption = "Neto"
        e.Layout.Bands(0).Columns("Saldo").Header.Caption = "Saldo"
        e.Layout.Bands(0).Columns("Cod_Beneficiario").Header.Caption = "Codigo"
        e.Layout.Bands(0).Columns("fecha_vencimiento").Header.Caption = "F-V"
        e.Layout.Bands(0).Columns("dias_vencidos").Header.Caption = "D-V"
        e.Layout.Bands(0).Columns("Plazo").Header.Caption = "D-C"

        e.Layout.Bands(0).Columns("anulada").Hidden = True
        e.Layout.Bands(0).Columns("cancelada").Hidden = True

        e.Layout.Bands(0).Columns("fecha").Format = "dd-MMM-yyyy"
        e.Layout.Bands(0).Columns("Fecha_Vencimiento").Format = "dd-MMM-yyyy"

        Dim NombrePrograma As String
        Dim Formulario As String
        NombrePrograma = "ContSisFact"
        Formulario = "FormFactSaldoxVend"

        Dim RegistroContSis As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\" & NombrePrograma, True)
        Dim R_ConexionBD As Microsoft.Win32.RegistryKey
        R_ConexionBD = RegistroContSis.OpenSubKey(Formulario)


        If Not R_ConexionBD Is Nothing Then
            Dim a As New Infragistics.Win.UltraWinGrid.FilterCondition
            a.CompareValue = R_ConexionBD.GetValue("FiltroVendedor", "")
            e.Layout.Bands(0).ColumnFilters("Nombre_Vendedor").FilterConditions.Add(a)
        End If

        'e.Layout.Bands(0).ColumnFilters(4).FilterConditions(0).CompareValue = R_ConexionBD.GetValue("FiltroVendedor", "")
    End Sub

    Private Sub cmdExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportXLS.Click
        Try
            Excel.Export(lstLista, "FacturasConSaldo.xls")
        Catch ex As Exception
            MsgBox("Sr. Usuario: el Archivo esta en uso. Por favor cierre el archvo para que el sistema pueda fucnionar")
        Finally
            System.Diagnostics.Process.Start("FacturasConSaldo.xls")
        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Dim NombrePrograma As String
        Dim Formulario As String
        NombrePrograma = "ContSisFact"
        Formulario = "FormFactSaldoxVend"

        Try
            Dim RegistroContSis As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\" & NombrePrograma, True)
            Dim R_ConexionBD As Microsoft.Win32.RegistryKey

            R_ConexionBD = RegistroContSis.OpenSubKey(Formulario)
            If R_ConexionBD Is Nothing Then
                R_ConexionBD = RegistroContSis.CreateSubKey(Formulario)
            Else
                RegistroContSis.DeleteSubKey(Formulario)
                R_ConexionBD = RegistroContSis.CreateSubKey(Formulario)
            End If
            If lstLista.DisplayLayout.Bands(0).ColumnFilters(4).FilterConditions.Count > 0 Then
                R_ConexionBD.SetValue("FiltroVendedor", lstLista.DisplayLayout.Bands(0).ColumnFilters(4).FilterConditions(0).CompareValue)
            End If
            R_ConexionBD.Close()
        Catch ex As Exception
            MensageError(ex)
        End Try



        Me.Close()
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        lstLista.DataSource = Nothing
        lstLista.DataSource = DameDataSet("exec sp_d_Facturas 0, -1", CN)
    End Sub
End Class