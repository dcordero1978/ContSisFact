Public Class frmPedidosAConsignacion
    Dim MFormato(0 To 9) As PropLista

    Private Sub frmPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        MFormato(1).Formato = "dd-MMM-yyyy"
        MFormato(2).Formato = "dd-MMM-yyyy"

        LLenar_List_View("select Pedidos.Numero_de_Documento, Pedidos.Fecha, Pedidos.FechaVencimiento, Pedidos.Nombre_del_Cliente, Pedidos.Total_en_Ventas, Pedidos.Total_en_Impuesto, Pedidos.Total_Neto, case when Pedidos.Anulada = 0 then 'No' else 'Si' end as Anulada, Pedidos.Tipo_de_Cambio from Pedidos left join Facturas on Pedidos.Numero_de_DocumentoF = Facturas.Numero_de_Documento where Pedidos.TipoDoc = 4 and Facturas.Numero_de_Documento is null /*and Pedidos.tipo = 2*/ order by Pedidos.Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If Vacio(txtTextoBusqueda.Text) Then
            LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 order by Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
        Else
            If txtTipoBusqueda.SelectedIndex = 0 Then
                LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 and Numero_de_Documento like '%" & txtTextoBusqueda.Text & "%' order by Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
            End If
            If txtTipoBusqueda.SelectedIndex = 1 Then
                If IsDate(txtTextoBusqueda.Text) Then
                    LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 and Fecha = '" & Format(CDate(txtTextoBusqueda.Text), "yyyy-MM-dd") & "' order by Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
                Else
                    MsgBox("Sr. Usuario: Por favor digite una fecha válida")
                    Exit Sub
                End If
            End If

            If txtTipoBusqueda.SelectedIndex = 2 Then
                LLenar_List_View("select Numero_de_Documento, Fecha, FechaVencimiento, Nombre_del_Cliente, Total_en_Ventas, Total_en_Impuesto, Total_Neto, case when Anulada = 0 then 'No' else 'Si' end as Anulada, Tipo_de_Cambio from Pedidos where TipoDoc = 4 /*and tipo = 2*/ and Nombre_del_Cliente like '%" & txtTextoBusqueda.Text & "%' order by Numero_de_Documento desc", lstLista, CN, MFormato, False, True, True)
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

    Private Sub HacerFacturaConsignacion_Click(sender As Object, e As EventArgs) Handles HacerFacturaConsignacion.Click
        Dim MyForm As Form

        If lstLista.SelectedItems.Count > 0 Then
            MyForm = frmConsignacion
            frmConsignacion.codPedido = lstLista.SelectedItems.Item(0).Text
            MyForm.MdiParent = MenuPrincipal
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show()
        End If
    End Sub
End Class