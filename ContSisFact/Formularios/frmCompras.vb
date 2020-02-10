Public Class frmCompras
    Private Sub frmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstLista.DataSource = DameDataSet("exec sp_d_Compras", CN)
    End Sub

    Private Sub lstLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles lstLista.InitializeLayout
        e.Layout.Bands(0).Columns("fecha").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        e.Layout.Bands(0).Columns("mesanio").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        e.Layout.Bands(0).Columns("observaciones").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        e.Layout.Bands(0).Columns("numero_de_documento").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        e.Layout.Bands(0).Columns("nombre").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
        e.Layout.Bands(0).Columns("monto_dolares").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True

        e.Layout.Bands(0).Columns("fecha").Header.Caption = "Fecha"
        e.Layout.Bands(0).Columns("observaciones").Header.Caption = "Numero de Fac. Compra"
        e.Layout.Bands(0).Columns("numero_de_documento").Header.Caption = "Consecutivo Sitema"
        e.Layout.Bands(0).Columns("nombre").Header.Caption = "Proveedor"
        e.Layout.Bands(0).Columns("monto_dolares").Header.Caption = "Dolares"
        e.Layout.Bands(0).Columns("subtotal").Header.Caption = "Sub Total"
        e.Layout.Bands(0).Columns("total_en_impuesto").Header.Caption = "Impuesto"
        e.Layout.Bands(0).Columns("total_neto").Header.Caption = "Total"
        e.Layout.Bands(0).Columns("abonos").Header.Caption = "Abono"
        e.Layout.Bands(0).Columns("saldo").Header.Caption = "Saldo"
        e.Layout.Bands(0).Columns("tasa_cambio").Header.Caption = "Tasa Cambio"
        e.Layout.Bands(0).Columns("abonos").Hidden = True
        e.Layout.Bands(0).Columns("saldo").Hidden = True


        e.Layout.Bands(0).Columns("fecha").Format = "dd-MMM-yyyy"
        e.Layout.Bands(0).Columns("mesanio").Format = "MMM-yyyy"
        e.Layout.Bands(0).Columns("fechavencimiento").Format = "dd-MMM-yyyy"

        e.Layout.Bands(0).Columns("monto_dolares").Format = "#,##0.00"
        e.Layout.Bands(0).Columns("subtotal").Format = "#,##0.00"
        e.Layout.Bands(0).Columns("total_en_impuesto").Format = "#,##0.00"
        e.Layout.Bands(0).Columns("total_neto").Format = "#,##0.00"

        e.Layout.Bands(0).Columns("tasa_cambio").Format = "#,##0.0000"
        'Dim NombrePrograma As String
        'Dim Formulario As String
        'NombrePrograma = "ContSisFact"
        'Formulario = "Compras"

        'Dim RegistroContSis As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\" & NombrePrograma, True)
        'Dim R_ConexionBD As Microsoft.Win32.RegistryKey
        'R_ConexionBD = RegistroContSis.OpenSubKey(Formulario)


        'If Not R_ConexionBD Is Nothing Then
        '    Dim a As New Infragistics.Win.UltraWinGrid.FilterCondition
        '    a.CompareValue = R_ConexionBD.GetValue("FiltroVendedor", "")
        '    e.Layout.Bands(0).ColumnFilters(4).FilterConditions.Add(a)
        'End If

        'e.Layout.Bands(0).ColumnFilters(4).FilterConditions(0).CompareValue = R_ConexionBD.GetValue("FiltroVendedor", "")
    End Sub

    Private Sub cmdExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportXLS.Click
        Try
            Excel.Export(lstLista, "Compras.xls")
        Catch ex As Exception
            MsgBox("Sr. Usuario: el Archivo esta en uso. Por favor cierre el archvo para que el sistema pueda funcionar")
        Finally
            System.Diagnostics.Process.Start("Compras.xls")
        End Try
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Dim NombrePrograma As String
        Dim Formulario As String
        NombrePrograma = "ContSisFact"
        Formulario = "Compras"

        'Try
        '    Dim RegistroContSis As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\" & NombrePrograma, True)
        '    Dim R_ConexionBD As Microsoft.Win32.RegistryKey

        '    R_ConexionBD = RegistroContSis.OpenSubKey(Formulario)
        '    If R_ConexionBD Is Nothing Then
        '        R_ConexionBD = RegistroContSis.CreateSubKey(Formulario)
        '    Else
        '        RegistroContSis.DeleteSubKey(Formulario)
        '        R_ConexionBD = RegistroContSis.CreateSubKey(Formulario)
        '    End If
        '    If lstLista.DisplayLayout.Bands(0).ColumnFilters(4).FilterConditions.Count > 0 Then
        '        R_ConexionBD.SetValue("FiltroProveedor", lstLista.DisplayLayout.Bands(0).ColumnFilters(4).FilterConditions(0).CompareValue)
        '    End If
        '    R_ConexionBD.Close()
        'Catch ex As Exception
        '    MensageError(ex)
        'End Try



        Me.Close()
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        lstLista.DataSource = Nothing
        lstLista.DataSource = DameDataSet("exec sp_d_Compras", CN)
    End Sub
End Class