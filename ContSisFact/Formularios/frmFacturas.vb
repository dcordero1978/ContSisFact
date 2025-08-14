Public Class frmFacturas
    Dim MFormato(0 To 9) As PropLista

    Private Sub frmFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        optCordobas.Checked = True

        MFormato(2).Formato = "dd-MMM-yyyy"
        MFormato(3).Formato = "dd-MMM-yyyy"


        LLenar_List_View("select F.Numero_de_Documento, case F.tipo when 1 then 'Contado' when 2 then 'Crédito' else 'No Definida' end AS TipoFactura, F.Fecha, F.FechaVencimiento, F.Nombre_del_Cliente, F.Total_en_Ventas, F.Total_en_Impuesto, F.Total_Neto, case when F.Anulada = 0 then 'No' else 'Si' end as Anulada, FP.no_proforma from Facturas F left join dsc.FacturasProformas FP ON F.Numero_de_Documento = FP.no_factura order by cast(F.Numero_de_Documento as int) desc", lstLista, CN, MFormato, False, True, True)
    End Sub

    Private Sub cmdVerCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerCotizacion.Click
        Dim ReporteVer As New rptFactura
        Dim DS_Reporte1 As New MyDs
        Dim MyForm As New frmVerPedidos

        If lstLista.SelectedItems.Count > 0 Then
            'frmVerPedidos.cod_factura = lstLista.Items(lstLista.SelectedItems(0).Index).SubItems(0).Text
            'frmVerPedidos.Moneda = IIf(optCordobas.Checked, 1, 2)
            MyForm.SQL = "exec sp_d_rptFactura '" & lstLista.Items(lstLista.SelectedItems(0).Index).SubItems(0).Text & "', " & IIf(optCordobas.Checked, 1, 2)
            MyForm.Tabla = "sp_d_rptFactura"
            MyForm.Reporte = ReporteVer
            MyForm.DS_Reporte = DS_Reporte1
            MyForm.ShowDialog()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If Vacio(txtTextoBusqueda.Text) Then
            LLenar_List_View("select F.Numero_de_Documento, case F.tipo when 1 then 'Contado' when 2 then 'Crédito' else 'No Definida' end AS TipoFactura, F.Fecha, F.FechaVencimiento, F.Nombre_del_Cliente, F.Total_en_Ventas, F.Total_en_Impuesto, F.Total_Neto, case when F.Anulada = 0 then 'No' else 'Si' end as Anulada, FP.no_proforma from Facturas F left join dsc.FacturasProformas FP ON F.Numero_de_Documento = FP.no_factura order by cast(Numero_de_Documento as int) desc", lstLista, CN, MFormato, False, True, True)
        Else
            If txtTipoBusqueda.SelectedIndex = 0 Then
                LLenar_List_View("select F.Numero_de_Documento, case F.tipo when 1 then 'Contado' when 2 then 'Crédito' else 'No Definida' end AS TipoFactura, F.Fecha, F.FechaVencimiento, F.Nombre_del_Cliente, F.Total_en_Ventas, F.Total_en_Impuesto, F.Total_Neto, case when F.Anulada = 0 then 'No' else 'Si' end as Anulada, FP.no_proforma from Facturas F left join dsc.FacturasProformas FP ON F.Numero_de_Documento = FP.no_factura where Numero_de_Documento like '%" & txtTextoBusqueda.Text & "%' order by cast(Numero_de_Documento as int) desc", lstLista, CN, MFormato, False, True, True)
            End If
            If txtTipoBusqueda.SelectedIndex = 1 Then
                If IsDate(txtTextoBusqueda.Text) Then
                    LLenar_List_View("select F.Numero_de_Documento, case F.tipo when 1 then 'Contado' when 2 then 'Crédito' else 'No Definida' end AS TipoFactura, F.Fecha, F.FechaVencimiento, F.Nombre_del_Cliente, F.Total_en_Ventas, F.Total_en_Impuesto, F.Total_Neto, case when F.Anulada = 0 then 'No' else 'Si' end as Anulada, FP.no_proforma from Facturas F left join dsc.FacturasProformas FP ON F.Numero_de_Documento = FP.no_factura where Fecha = '" & Format(CDate(txtTextoBusqueda.Text), "yyyy-MM-dd") & "' order by cast(Numero_de_Documento as int) desc", lstLista, CN, MFormato, False, True, True)
                Else
                    MsgBox("Sr. Usuario: Por favor digite una fecha válida")
                    Exit Sub
                End If
            End If

            If txtTipoBusqueda.SelectedIndex = 2 Then
                LLenar_List_View("select F.Numero_de_Documento, case F.tipo when 1 then 'Contado' when 2 then 'Crédito' else 'No Definida' end AS TipoFactura, F.Fecha, F.FechaVencimiento, F.Nombre_del_Cliente, F.Total_en_Ventas, F.Total_en_Impuesto, F.Total_Neto, case when F.Anulada = 0 then 'No' else 'Si' end as Anulada, FP.no_proforma from Facturas F left join dsc.FacturasProformas FP ON F.Numero_de_Documento = FP.no_factura where Nombre_del_Cliente like '%" & txtTextoBusqueda.Text & "%' order by cast(Numero_de_Documento as int) desc", lstLista, CN, MFormato, False, True, True)
            End If
        End If
    End Sub

    Private Sub txtTextoBusqueda_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextoBusqueda.Enter
        Enfoque(sender)
    End Sub

    Private Sub txtTextoBusqueda_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTextoBusqueda.KeyUp
        MoverFoco(Me, sender, e)
    End Sub

    Private Sub txtTextoBusqueda_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextoBusqueda.Leave
        DesEnfoque(sender)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        LLenar_List_View("select F.Numero_de_Documento, case F.tipo when 1 then 'Contado' when 2 then 'Crédito' else 'No Definida' end AS TipoFactura, F.Fecha, F.FechaVencimiento, F.Nombre_del_Cliente, F.Total_en_Ventas, F.Total_en_Impuesto, F.Total_Neto, case when F.Anulada = 0 then 'No' else 'Si' end as Anulada, FP.no_proforma from Facturas F left join dsc.FacturasProformas FP ON F.Numero_de_Documento = FP.no_factura order by cast(Numero_de_Documento as int)", lstLista, CN, MFormato, False, True, True)
    End Sub

    Private Sub lstLista_DoubleClick(sender As Object, e As EventArgs) Handles lstLista.DoubleClick
        If lstLista.SelectedItems.Count > 0 Then
            Dim myForm As New frmFacturaProforma
            myForm.txtFactura.Text = lstLista.SelectedItems(0).SubItems(0).Text
            myForm.txtProforma.Text = lstLista.SelectedItems(0).SubItems(9).Text
            myForm.ShowDialog()
            If myForm.bSalidaDblClik Then
                LLenar_List_View("select F.Numero_de_Documento, case F.tipo when 1 then 'Contado' when 2 then 'Crédito' else 'No Definida' end AS TipoFactura, F.Fecha, F.FechaVencimiento, F.Nombre_del_Cliente, F.Total_en_Ventas, F.Total_en_Impuesto, F.Total_Neto, case when F.Anulada = 0 then 'No' else 'Si' end as Anulada, FP.no_proforma from Facturas F left join dsc.FacturasProformas FP ON F.Numero_de_Documento = FP.no_factura order by cast(Numero_de_Documento as int) desc", lstLista, CN, MFormato, False, True, True)
            End If
        End If
    End Sub
End Class