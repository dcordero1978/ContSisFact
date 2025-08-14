Public Class frmPedidosBusqueda
    Dim MFormato(0 To 9) As PropLista
    Public strProforma As String = String.Empty

    Public bSalidaDblClik As Boolean = False

    Private Sub frmPedidosBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bSalidaDblClik = False
        optCordobas.Checked = True

        MFormato(1).Formato = "dd-MMM-yyyy"
        MFormato(2).Formato = "dd-MMM-yyyy"

        LLenar_List_View("SELECT P.Numero_de_Documento, P.Fecha, P.FechaVencimiento, P.Nombre_del_Cliente, P.Total_en_Ventas, P.Total_en_Impuesto, P.Total_Neto, case when P.Anulada = 0 then 'No' else 'Si' end as Anulada, no_factura from Pedidos P LEFT JOIN dsc.FacturasProformas FP ON P.Numero_de_Documento = FP.no_proforma where P.TipoDoc = 4 /*and tipo = 2*/ order by P.Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If Vacio(txtTextoBusqueda.Text) Then
            LLenar_List_View("SELECT P.Numero_de_Documento, P.Fecha, P.FechaVencimiento, P.Nombre_del_Cliente, P.Total_en_Ventas, P.Total_en_Impuesto, P.Total_Neto, case when P.Anulada = 0 then 'No' else 'Si' end as Anulada, no_factura from Pedidos P LEFT JOIN dsc.FacturasProformas FP ON P.Numero_de_Documento = FP.no_proforma where P.TipoDoc = 4 order by P.Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
        Else
            If txtTipoBusqueda.SelectedIndex = 0 Then
                LLenar_List_View("SELECT P.Numero_de_Documento, P.Fecha, P.FechaVencimiento, P.Nombre_del_Cliente, P.Total_en_Ventas, P.Total_en_Impuesto, P.Total_Neto, case when P.Anulada = 0 then 'No' else 'Si' end as Anulada, no_factura from Pedidos P LEFT JOIN dsc.FacturasProformas FP ON P.Numero_de_Documento = FP.no_proforma where P.TipoDoc = 4 and P.Numero_de_Documento like '%" & txtTextoBusqueda.Text & "%' order by P.Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
            End If
            If txtTipoBusqueda.SelectedIndex = 1 Then
                If IsDate(txtTextoBusqueda.Text) Then
                    LLenar_List_View("SELECT P.Numero_de_Documento, P.Fecha, P.FechaVencimiento, P.Nombre_del_Cliente, P.Total_en_Ventas, P.Total_en_Impuesto, P.Total_Neto, case when P.Anulada = 0 then 'No' else 'Si' end as Anulada, no_factura from Pedidos P LEFT JOIN dsc.FacturasProformas FP ON P.Numero_de_Documento = FP.no_proforma where P.TipoDoc = 4 and P.Fecha = '" & Format(CDate(txtTextoBusqueda.Text), "yyyy-MM-dd") & "' order by P.Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
                Else
                    MsgBox("Sr. Usuario: Por favor digite una fecha válida")
                    Exit Sub
                End If
            End If

            If txtTipoBusqueda.SelectedIndex = 2 Then
                LLenar_List_View("SELECT P.Numero_de_Documento, P.Fecha, P.FechaVencimiento, P.Nombre_del_Cliente, P.Total_en_Ventas, P.Total_en_Impuesto, P.Total_Neto, case when P.Anulada = 0 then 'No' else 'Si' end as Anulada, no_factura from Pedidos P LEFT JOIN dsc.FacturasProformas FP ON P.Numero_de_Documento = FP.no_proforma where P.TipoDoc = 4 /*and tipo = 2*/ and P.Nombre_del_Cliente like '%" & txtTextoBusqueda.Text & "%' order by P.Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
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


    Private Sub lstLista_DoubleClick(sender As Object, e As EventArgs) Handles lstLista.DoubleClick
        If lstLista.SelectedItems.Count > 0 Then
            strProforma = lstLista.Items(lstLista.SelectedItems(0).Index).SubItems(0).Text
            bSalidaDblClik = True
            Close()
        End If
    End Sub
End Class