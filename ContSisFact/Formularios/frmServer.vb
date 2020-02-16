Imports Infragistics.Win
Public Class frmServer
    Private Sub frmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbReportes.SelectedIndex = 0
        'lstLista.ShowColumnChooser()
    End Sub

    Private Sub cmbReportes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReportes.SelectedIndexChanged
        lstLista.DataSource = Nothing
        Actualizar()
        lstLista.Select()
    End Sub

    Private Sub Actualizar()
        If cmbReportes.SelectedIndex = 0 Then
            lstLista.DataSource = Nothing
        End If

        If cmbReportes.SelectedIndex = 1 Then
            lstLista.DataSource = DameDataSet("exec sp_d_ExistenciaInventario2", CN)
        End If

        If cmbReportes.SelectedIndex = 2 Then
            lstLista.DataSource = DameDataSet("exec sp_d_Facturas", CN)
        End If

        If cmbReportes.SelectedIndex = 3 Then
            lstLista.DataSource = DameDataSet("exec sp_d_comisiones", CN)
        End If

        If cmbReportes.SelectedIndex = 4 Then
            lstLista.DataSource = DameDataSet("exec sp_d_comisiones 1", CN)
        End If

        If cmbReportes.SelectedIndex = 5 Then
            lstLista.DataSource = DameDataSet("exec sp_d_ExistenciaInventario", CN)
        End If

        If cmbReportes.SelectedIndex = 6 Or cmbReportes.SelectedIndex = 6 Or cmbReportes.SelectedIndex = 7 Then
            lstLista.DataSource = DameDataSet("exec sp_d_Compras", CN)
        End If

        If cmbReportes.SelectedIndex = 7 Then
            lstLista.DataSource = DameDataSet("exec sp_d_TablaDinamica", CN)
        End If

        If cmbReportes.SelectedIndex = 8 Then
            lstLista.DataSource = DameDataSet("exec sp_D_FrecuenciaClientes", CN)
        End If
    End Sub

    Private Sub lstLista_BeforeRowFilterDropDown(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowFilterDropDownEventArgs) Handles lstLista.BeforeRowFilterDropDown
        Dim vl As ValueList = e.ValueList
        Dim count As Integer = vl.ValueListItems.Count
        If cmbReportes.SelectedIndex = 2 Or cmbReportes.SelectedIndex = 3 Or cmbReportes.SelectedIndex = 5 Or cmbReportes.SelectedIndex = 6 Or cmbReportes.SelectedIndex = 7 Then 'Ventas
            If e.Column.Header.Caption = "Mes-Año" Or e.Column.Header.Caption = "Mes" Or e.Column.Header.Caption = "MesAnio" Then
                Dim items As New List(Of ValueListItem)
                For i = count - 1 To 0 Step -1
                    Dim item As ValueListItem = vl.ValueListItems(i)
                    If item.DataValue.GetType.Name = "DateTime" Then
                        items.Add(item)
                        vl.ValueListItems.RemoveAt(i)
                    End If
                Next

                For Each item In items
                    e.ValueList.ValueListItems.Add(item)
                Next


            End If
        End If
    End Sub
    Private Sub lstLista_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles lstLista.InitializeLayout
        Dim calcManager As Infragistics.Win.UltraWinCalcManager.UltraCalcManager
        calcManager = New Infragistics.Win.UltraWinCalcManager.UltraCalcManager(Me.Container)
        e.Layout.Grid.CalcManager = calcManager

        e.Layout.Bands(0).Columns.ClearUnbound()
        If (cmbReportes.SelectedIndex = 1) Then 'Existencia en Inventario
            e.Layout.Bands(0).Columns("precio_costo").Hidden = True
            e.Layout.Bands(0).Columns("precio1").Hidden = True
            e.Layout.Bands(0).Columns("precio2").Hidden = True
            e.Layout.Bands(0).Columns("precio3").Hidden = True
            e.Layout.Bands(0).Columns("precio4").Hidden = True
            e.Layout.Bands(0).Columns("precio5").Hidden = True


            'Ordernar por codigo
            'Ampliar Columna de NombreProducto
            e.Layout.Bands(0).Columns("NombreProducto").Width = 700
        End If

        If cmbReportes.SelectedIndex = 2 Then 'Ventas
            e.Layout.Bands(0).Columns("MesAnio").Header.Caption = "Mes-Año"
            e.Layout.Bands(0).Columns("MesAnio").Format = "MMM-yyyy"
            e.Layout.Bands(0).Columns("MesAnio").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True

            'Ordenar por MesAno de mas actual a mas viejo
            'Priemro MesAno y luego fecha
            'Eliminar Saldo
            e.Layout.Bands(0).Columns("Saldo").Hidden = True
            'Elimar cancelada
            e.Layout.Bands(0).Columns("Cancelada").Hidden = True
            'Eliminar Vendedor
            e.Layout.Bands(0).Columns("Vendedor").Hidden = True

        End If

        If cmbReportes.SelectedIndex = 3 Or cmbReportes.SelectedIndex = 4 Then 'Comisiones
            e.Layout.Bands(0).Columns.Add("Comision_Dolares_Real", "Comision Dolares Real")
            e.Layout.Bands(0).Columns.Add("Comision_Cordobas_Real", "Comision Cordobas Real")

            e.Layout.Bands(0).Columns("Comision_Dolares_Real").Formula = "[cant.]*[p_venta]*[ComisionReal]/100"
            e.Layout.Bands(0).Columns("Comision_Cordobas_Real").Formula = "[Comision_Dolares_Real]*[T.C]"
            e.Layout.Bands(0).Columns("Comision_Dolares_Real").Format = "#,##0.00"
            e.Layout.Bands(0).Columns("Comision_Cordobas_Real").Format = "#,##0.00"
            e.Layout.Bands(0).Columns("Mes").Format = "MMM-yyyy"
            e.Layout.Bands(0).Columns("Comision_Dolares_Real").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
            e.Layout.Bands(0).Columns("Comision_Cordobas_Real").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right

            e.Layout.Bands(0).Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True
            e.Layout.Bands(0).Columns("ComisionReal").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
            e.Layout.Bands(0).Columns("ComisionReal").CellActivation = Infragistics.Win.UltraWinGrid.Activation.AllowEdit

            e.Layout.Bands(0).Columns("Mes").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
            e.Layout.Bands(0).Columns("Vendedor").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
            e.Layout.Bands(0).Columns("SubTotal").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True

            'Ordenar MesAno de mas Actual a mas Viejo
            'Ocultar fecha de factura
            e.Layout.Bands(0).Columns("F. Fact").Hidden = True
            'ocultar Tasa de cambio 
            e.Layout.Bands(0).Columns("T.C").Hidden = True
            'Ocultar Fecha de tasa
            e.Layout.Bands(0).Columns("F. Tasa").Hidden = True
            'Ocultar %Com
            e.Layout.Bands(0).Columns("% Com").Hidden = True
            'Ocultar Com $
            e.Layout.Bands(0).Columns("Com $").Hidden = True
            'Ocultar Com C$
            e.Layout.Bands(0).Columns("Com C$").Hidden = True
            'Revisar formulas
            'Cambiar formato de [%] en porcentaje
            e.Layout.Bands(0).Columns("%").Format = "P"
            'Permitir filtrar por cliente
            e.Layout.Bands(0).Columns("NombreCliente").AllowRowFiltering = DefaultableBoolean.True
        End If

        If cmbReportes.SelectedIndex = 5 Then 'Compras General
            e.Layout.Bands(0).Columns("NombreProducto").Width = 600
            ''''''''''''''''''''''''''''''''''''''
            'Ordenar por codigo

        End If

        If cmbReportes.SelectedIndex = 6 Then 'Inventario
            e.Layout.Bands(0).Columns("MesAnio").Format = "MMM-yyyy"
            e.Layout.Bands(0).Columns("MesAnio").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
            e.Layout.Bands(0).Columns("Monto_Dolares").Hidden = False

            'Dim a As New Infragistics.Win.UltraWinGrid.FilterCondition
            'a.CompareValue = "0"
            'a.ComparisionOperator = Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Match

            e.Layout.Bands(0).ColumnFilters("Monto_Dolares").FilterConditions.Clear()
            e.Layout.Bands(0).ColumnFilters("Saldo").FilterConditions.Clear()

            'e.Layout.Bands(0).ColumnFilters("Saldo").FilterConditions.Add(a)

            'Ordenar MesAno
            'Ordenar por numero de documento
            e.Layout.Bands(0).SortedColumns.Clear()
            e.Layout.Bands(0).SortedColumns.Add("Numero_De_Documento", False, False)

            'Invertir MesAnio y Fecha

            'Ocultar Saldo
            e.Layout.Bands(0).Columns("Saldo").Hidden = True
            'Ocultar Abono
            e.Layout.Bands(0).Columns("Abonos").Hidden = True
            'Ocultar Tasa de Cambio
            e.Layout.Bands(0).Columns("Tasa_Cambio").Hidden = True
            'Ocultar Fecha Vencimiento
            e.Layout.Bands(0).Columns("FechaVencimiento").Hidden = True

        End If

        If cmbReportes.SelectedIndex = 7 Then 'Compras Cordobas
            'e.Layout.Bands(0).Columns("MesAnio").Format = "MMM-yyyy"
            'e.Layout.Bands(0).Columns("MesAnio").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
            'e.Layout.Bands(0).Columns("Monto_Dolares").Hidden = True

            Dim a As New Infragistics.Win.UltraWinGrid.FilterCondition
            Dim b As New Infragistics.Win.UltraWinGrid.FilterCondition
            a.CompareValue = "0"
            a.ComparisionOperator = Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Match
            b.CompareValue = "0"
            b.ComparisionOperator = Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThan


            'e.Layout.Bands(0).ColumnFilters("Monto_Dolares").FilterConditions.Clear()
            'e.Layout.Bands(0).ColumnFilters("Monto_Dolares").FilterConditions.Add(a)

            'e.Layout.Bands(0).ColumnFilters("Saldo").FilterConditions.Clear()
            'e.Layout.Bands(0).ColumnFilters("Saldo").FilterConditions.Add(b)
            ''''''''''''''''''''''''''''''''''''''''''''
            'Ordenar por numero de documento
            'Intercambiar MesAnio por Fecha
            'Ordenar por fecha
            'e.Layout.Bands(0).Columns("Fecha").SortIndicator = UltraWinGrid.SortIndicator.Ascending
            'e.Layout.Bands(0).SortedColumns.Clear()
            ' e.Layout.Bands(0).SortedColumns.Add("Fecha", False, False)
            'Ocultar Tipo de Cambio
            'e.Layout.Bands(0).Columns("Tasa_Cambio").Hidden = True


        End If

        If cmbReportes.SelectedIndex = 8 Then 'Compras Dolares
            'e.Layout.Bands(0).Columns("MesAnio").Format = "MMM-yyyy"
            'e.Layout.Bands(0).Columns("MesAnio").AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True
            'e.Layout.Bands(0).Columns("Monto_Dolares").Hidden = False


            Dim a As New Infragistics.Win.UltraWinGrid.FilterCondition
            Dim b As New Infragistics.Win.UltraWinGrid.FilterCondition
            a.CompareValue = "0"
            a.ComparisionOperator = Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThan
            b.CompareValue = "0"
            b.ComparisionOperator = Infragistics.Win.UltraWinGrid.FilterComparisionOperator.GreaterThan

            'e.Layout.Bands(0).ColumnFilters("Monto_Dolares").FilterConditions.Clear()
            'e.Layout.Bands(0).ColumnFilters("Monto_Dolares").FilterConditions.Add(a)


            'e.Layout.Bands(0).ColumnFilters("Saldo").FilterConditions.Clear()
            'e.Layout.Bands(0).ColumnFilters("Saldo").FilterConditions.Add(b)

            'Ordenar por numero de documento
            'Intercambiar MesAnio por Fecha
            'Ordenar por fecha
            e.Layout.Bands(0).SortedColumns.Clear()
            'e.Layout.Bands(0).SortedColumns.Add("Fecha", False, False)
            'Ocultar Tipo de Cambio
            'e.Layout.Bands(0).Columns("Tasa_Cambio").Hidden = True
        End If

        If cmbReportes.SelectedIndex = 9 Then
            For i = 2 To e.Layout.Bands(0).Columns.Count - 1 Step 1
                e.Layout.Bands(0).Columns(i).Header.Caption = Format(CDate(e.Layout.Bands(0).Columns(i).Header.Caption), "MMM-yyyy")
            Next
        End If
        If cmbReportes.SelectedIndex = 10 Then
            e.Layout.Bands(0).Columns("NombreCliente").AllowRowFiltering = DefaultableBoolean.True
            For i = 3 To e.Layout.Bands(0).Columns.Count - 1 Step 1
                e.Layout.Bands(0).Columns(i).Header.Caption = Format(CDate(e.Layout.Bands(0).Columns(i).Header.Caption), "MMM-yyyy")
            Next

        End If
    End Sub

    Private Sub cmdExportXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportXLS.Click
        Dim NombreArchivo As String

        NombreArchivo = ""
        Try
            If (cmbReportes.SelectedIndex = 1) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ExistenciaInventario.xlsx"
            End If

            If (cmbReportes.SelectedIndex = 2) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Ventas.xlsx"
            End If

            If (cmbReportes.SelectedIndex = 3) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Comisiones.xlsx"
            End If
            If (cmbReportes.SelectedIndex = 5) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Inventario.xlsx"
            End If

            If (cmbReportes.SelectedIndex = 6) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ComprasGeneral.xlsx"
            End If

            If (cmbReportes.SelectedIndex = 7) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ComprasCordobas.xlsx"
            End If

            If (cmbReportes.SelectedIndex = 8) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ComprasDolares.xlsx"
            End If

            If (cmbReportes.SelectedIndex = 9) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\MoviminetoPorMes.xlsx"
            End If
            If (cmbReportes.SelectedIndex = 10) Then
                NombreArchivo = My.Computer.FileSystem.SpecialDirectories.Desktop & "\FrecuenciaClientes.xlsx"
            End If
            Excel.Export(lstLista, NombreArchivo)
        Catch ex As Exception
            MsgBox("Sr. Usuario: el Archivo esta en uso. Por favor cierre el archvo para que el sistema pueda fucnionar")
        Finally
            System.Diagnostics.Process.Start(NombreArchivo)
        End Try
    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        Actualizar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class