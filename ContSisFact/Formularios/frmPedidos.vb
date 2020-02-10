Public Class frmPedidos
    Dim MFormato(0 To 9) As PropLista

    Private Sub frmPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        optCordobas.Checked = True

        MFormato(1).Formato = "dd-MMM-yyyy"
        MFormato(2).Formato = "dd-MMM-yyyy"

        LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 and tipo = 2 order by Numero_de_Documento", lstLista, CN, MFormato, False, True, True)
    End Sub

    Private Sub cmdVerCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerCotizacion.Click
        Dim ReporteVer As New rptFacturaPedido
        Dim DS_Reporte1 As New MyDs
        Dim MyForm As New frmVerPedidos

        If lstLista.SelectedItems.Count > 0 Then
            'frmVerPedidos.cod_factura = lstLista.Items(lstLista.SelectedItems(0).Index).SubItems(0).Text
            'frmVerPedidos.Moneda = IIf(optCordobas.Checked, 1, 2)
            MyForm.SQL = "exec sp_d_FacturaPedidod '" & lstLista.Items(lstLista.SelectedItems(0).Index).SubItems(0).Text & "', 4, 2, " & IIf(optCordobas.Checked, 1, 2)
            MyForm.Tabla = "sp_d_FacturaPedidod"
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
            LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 order by Numero_de_Documento", lstLista, CN, MFormato, False, True, True)
        Else
            If txtTipoBusqueda.SelectedIndex = 0 Then
                LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 and Numero_de_Documento like '%" & txtTextoBusqueda.Text & "%' order by Numero_de_Documento", lstLista, CN, MFormato, False, True, True)
            End If
            If txtTipoBusqueda.SelectedIndex = 1 Then
                If IsDate(txtTextoBusqueda.Text) Then
                    LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 and Fecha = '" & Format(CDate(txtTextoBusqueda.Text), "yyyy-MM-dd") & "' order by Numero_de_Documento", lstLista, CN, MFormato, False, True, True)
                Else
                    MsgBox("Sr. Usuario: Por favor digite una fecha válida")
                    Exit Sub
                End If
            End If

            If txtTipoBusqueda.SelectedIndex = 2 Then
                LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 and tipo = 2 and Nombre_del_Cliente like '%" & txtTextoBusqueda.Text & "%' order by Numero_de_Documento", lstLista, CN, MFormato, False, True, True)
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
End Class