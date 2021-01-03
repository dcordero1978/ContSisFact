Public Class frmConsignacion
    Public codPedido As String
    Private Sub frmConsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsPedidos As New DataSet

        optCordobas.Checked = True

        dsPedidos = DameDataSet("select Pedidos.Numero_de_Documento, Pedidos.Codigo_Cliente, Pedidos.Nombre_del_Cliente, Vendedores.Nombre_Vendedor, Pedidos.Observaciones1 as Observaciones, Pedidos.Fecha, Clientes.Cedula from Pedidos inner join Vendedores on Pedidos.Vendedor = Vendedores.codigo left join Clientes on Pedidos.Codigo_Cliente = Clientes.Codigo_Cliente where Numero_de_Documento = '" & codPedido & "'", CN)
        Me.txtCodPedido.Text = codPedido
        Me.txtCodCliente.Text = dsPedidos.Tables(0).Rows(0).Item("Codigo_Cliente").ToString
        Me.txtNombreCliente.Text = dsPedidos.Tables(0).Rows(0).Item("Nombre_del_Cliente").ToString
        Me.txtVendedor.Text = dsPedidos.Tables(0).Rows(0).Item("Nombre_Vendedor").ToString
        Me.txtObservaciones.Text = dsPedidos.Tables(0).Rows(0).Item("Observaciones").ToString
        Me.txtFecha.Text = Format(dsPedidos.Tables(0).Rows(0).Item("Fecha"), "dd-MMM-yy")
        Me.txtRUC.Text = dsPedidos.Tables(0).Rows(0).Item("Cedula").ToString

        LLenar_List_View("select Codigo_Producto, Descripcion, Cantidad, cast(Precio_en_Dolares as numeric(18,2)) as Precio_en_Dolares, cast(Precio_Unitario as numeric(18,2)) as Precio_Unitario, cast(Cantidad * Precio_Unitario as numeric(18,2)) as SubTotal from Detalle_Pedidos where Codigo_Factura = '" & codPedido & "'", lstDetallePedido, CN, Nothing, False, True, False)
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdVerRemision_Click(sender As Object, e As EventArgs) Handles cmdVerRemision.Click
        Dim ReporteVer As New rptConsignacion
        Dim DS_Reporte1 As New MyDs
        Dim MyForm As New frmVerPedidos
        Dim noSalida As String

        noSalida = DameCampoSQL("select coalesce(Observaciones5, '') as noSalida from Pedidos where Numero_de_Documento = '" & txtCodPedido.Text & "'", "noSalida", CN)

        If noSalida.Length = 0 Then
            MessageBox.Show("Este pedido no tiene remision de salida")
            Exit Sub
        End If
        'If lstLista.SelectedItems.Count > 0 Then
        'frmVerPedidos.cod_factura = lstLista.Items(lstLista.SelectedItems(0).Index).SubItems(0).Text
        'frmVerPedidos.Moneda = IIf(optCordobas.Checked, 1, 2)
        MyForm.SQL = "exec sp_d_FacturaPedidod '" & txtCodPedido.Text & "', 4, 2, " & IIf(optCordobas.Checked, 1, 2)
        MyForm.Tabla = "sp_d_FacturaPedidod"
        MyForm.Reporte = ReporteVer
        MyForm.DS_Reporte = DS_Reporte1
        MyForm.ShowDialog()
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim noSalida As String

        noSalida = DameCampoSQL("select coalesce(Observaciones5, '') as noSalida from Pedidos where Numero_de_Documento = '" & txtCodPedido.Text & "'", "noSalida", CN)

        If noSalida.Length > 0 Then
            MessageBox.Show("Este pedido ya tiene una salida por lo tanto no puede hacerce otra salida")
            Exit Sub
        End If
        ExecuteSQL("exec dsc.crearSalidaBodegaConsignacion '" & txtCodPedido.Text & "'", CN, Nothing, True)
        MessageBox.Show("Salida creada con exito")
    End Sub
End Class