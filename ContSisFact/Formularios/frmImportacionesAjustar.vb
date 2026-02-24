Public Class frmImportacionesAjustar
    Dim MFormato(0 To 9) As PropLista

    ' Panel y controles para mostrar los datos de la fila seleccionada
    Private pnlModal As Panel
    Private lblNoFactura As Label
    Private lblNoPoliza As Label
    Private lblIVA As Label
    Private txtNoFactura As TextBox
    Private txtNoPoliza As TextBox
    Private txtIVA As TextBox
    Private btnCerrarModal As Button
    Private btnGuardarModal As Button
    Private btnBorrarModal As Button
    Private selectedListViewItem As ListViewItem = Nothing

    Private Sub frmImportacionesAjustar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MFormato(1).Formato = "dd-MMM-yyyy"
        MFormato(3).Formato = "#,##0.00"
        MFormato(4).Formato = "#,##0.00"
        MFormato(5).Formato = "#,##0.00"
        MFormato(7).Formato = "#,##0.00"
        MFormato(8).Formato = "#,##0.00"

        MFormato(0).Tamano = 86
        MFormato(1).Tamano = 86
        MFormato(2).Tamano = 200
        MFormato(3).Tamano = 86
        MFormato(4).Tamano = 86
        MFormato(5).Tamano = 86
        MFormato(6).Tamano = 86
        MFormato(7).Tamano = 120
        MFormato(8).Tamano = 120

        MFormato(0).Alineacion = HorizontalAlignment.Left
        MFormato(1).Alineacion = HorizontalAlignment.Left
        MFormato(2).Alineacion = HorizontalAlignment.Left
        MFormato(3).Alineacion = HorizontalAlignment.Right
        MFormato(4).Alineacion = HorizontalAlignment.Right
        MFormato(5).Alineacion = HorizontalAlignment.Right
        MFormato(6).Alineacion = HorizontalAlignment.Left
        MFormato(7).Alineacion = HorizontalAlignment.Right
        MFormato(8).Alineacion = HorizontalAlignment.Right

        MFormato(0).Titulo = "Factura"
        MFormato(1).Titulo = "Fecha"
        MFormato(2).Titulo = "Proveedor"
        MFormato(3).Titulo = "Total Ventas"
        MFormato(4).Titulo = "Total Impuesto"
        MFormato(5).Titulo = "Total Neto"
        MFormato(6).Titulo = "No Poliza"
        MFormato(7).Titulo = "IVA"
        MFormato(8).Titulo = "Ingreso Sin Iva"


        LLenar_List_View("select C.Numero_de_Documento, C.Fecha, P.Nombre, 	C.Total_en_Ventas, C.Total_en_Impuesto, C.Total_Neto, ID.no_factura, ID.iva , round(id.iva / 0.15, 2) as Ingreso_Sin_Iva from Compras C left join dsc.Importaciones_Datos ID ON C.Numero_de_Documento = ID.Numero_de_Documento left join proveedores P ON P.codigo_proveedor = c.codigo_proveedor WHERE C.TipoCompra = 2 and c.Anulada = 0 order by C.Fecha  desc", lstLista, CN, MFormato, True, True, True)

        ' Inicializar panel modal (oculto por defecto)
        InicializarPanelModal()
    End Sub

    Private Sub InicializarPanelModal()
        pnlModal = New Panel()
        pnlModal.Size = New Size(350, 210)
        pnlModal.Location = New Point((Me.Width - pnlModal.Width) \ 2, (Me.Height - pnlModal.Height) \ 2)
        pnlModal.BorderStyle = BorderStyle.FixedSingle
        pnlModal.BackColor = Color.WhiteSmoke
        pnlModal.Visible = False
        pnlModal.BringToFront()
        pnlModal.Anchor = AnchorStyles.None

        lblNoFactura = New Label() With {.Text = "No. Factura:", .Location = New Point(20, 20), .AutoSize = True}
        txtNoFactura = New TextBox() With {.Location = New Point(140, 18), .Width = 170, .ReadOnly = True}
        lblNoPoliza = New Label() With {.Text = "No. Poliza:", .Location = New Point(20, 60), .AutoSize = True}
        txtNoPoliza = New TextBox() With {.Location = New Point(140, 58), .Width = 170, .ReadOnly = False}
        lblIVA = New Label() With {.Text = "IVA:", .Location = New Point(20, 100), .AutoSize = True}
        txtIVA = New TextBox() With {.Location = New Point(140, 98), .Width = 170, .ReadOnly = False}
        btnGuardarModal = New Button() With {.Text = "Guardar", .Location = New Point(30, 150), .Width = 90, .Height = 50}
        btnCerrarModal = New Button() With {.Text = "Cerrar", .Location = New Point(130, 150), .Width = 90, .Height = 50}
        btnBorrarModal = New Button() With {.Text = "Borrar", .Location = New Point(230, 150), .Width = 90, .Height = 50, .Visible = False, .Enabled = False}
        ' Asignar iconos a los botones
        btnGuardarModal.Image = Global.ContSisFact.My.Resources.Resources.Disco2.ToBitmap() 'New Icon("Resources/Disco2.ico").ToBitmap()
        btnCerrarModal.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C 'New Icon("Resources/EXIT00C.ico").ToBitmap()
        btnBorrarModal.Image = Global.ContSisFact.My.Resources.Resources.Eliminar 'New Icon("Resources/Eliminar.ico").ToBitmap()
        btnGuardarModal.ImageAlign = ContentAlignment.MiddleLeft
        btnCerrarModal.ImageAlign = ContentAlignment.MiddleLeft
        btnBorrarModal.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardarModal.TextAlign = ContentAlignment.MiddleRight
        btnCerrarModal.TextAlign = ContentAlignment.MiddleRight
        btnBorrarModal.TextAlign = ContentAlignment.MiddleRight
        ' ToolTips
        Dim toolTip As New ToolTip()
        toolTip.SetToolTip(btnGuardarModal, "Guardar cambios (Ctrl+G)")
        toolTip.SetToolTip(btnCerrarModal, "Cerrar el panel (Esc)")
        toolTip.SetToolTip(btnBorrarModal, "Eliminar registro")
        AddHandler btnCerrarModal.Click, AddressOf CerrarPanelModal
        AddHandler btnGuardarModal.Click, AddressOf GuardarPanelModal
        AddHandler btnBorrarModal.Click, AddressOf BorrarPanelModal

        pnlModal.Controls.Add(lblNoFactura)
        pnlModal.Controls.Add(txtNoFactura)
        pnlModal.Controls.Add(lblNoPoliza)
        pnlModal.Controls.Add(txtNoPoliza)
        pnlModal.Controls.Add(lblIVA)
        pnlModal.Controls.Add(txtIVA)
        pnlModal.Controls.Add(btnGuardarModal)
        pnlModal.Controls.Add(btnCerrarModal)
        pnlModal.Controls.Add(btnBorrarModal)
        Me.Controls.Add(pnlModal)
    End Sub

    Private Sub MostrarPanelModal(noFactura As String, noPoliza As String, iva As String, Optional item As ListViewItem = Nothing)
        txtNoFactura.Text = noFactura
        txtNoPoliza.Text = noPoliza
        txtIVA.Text = iva
        pnlModal.Visible = True
        pnlModal.BringToFront()
        pnlModal.Focus()
        selectedListViewItem = item
        ' Habilitar botón borrar solo si hay datos en NoPoliza e IVA
        If Not String.IsNullOrWhiteSpace(noPoliza) AndAlso Not String.IsNullOrWhiteSpace(iva) Then
            btnBorrarModal.Visible = True
            btnBorrarModal.Enabled = True
        Else
            btnBorrarModal.Visible = False
            btnBorrarModal.Enabled = False
        End If
    End Sub

    Private Sub CerrarPanelModal(sender As Object, e As EventArgs)
        pnlModal.Visible = False
    End Sub

    ' Llamar explícitamente la versión con parámetros para evitar ambigüedad
    Private Sub GuardarPanelModal(sender As Object, e As EventArgs)
        ' Validaciones
        If String.IsNullOrWhiteSpace(txtNoPoliza.Text) OrElse String.IsNullOrWhiteSpace(txtIVA.Text) Then
            MsgBox("Todos los campos deben estar completos.", MsgBoxStyle.Exclamation)
            Return
        End If
        If txtNoPoliza.Text.Length <= 3 Then
            MsgBox("No Poliza debe tener más de 3 caracteres.", MsgBoxStyle.Exclamation)
            Return
        End If
        Dim valorIVA As Decimal
        If Not Decimal.TryParse(txtIVA.Text, valorIVA) OrElse valorIVA <= 0 Then
            MsgBox("IVA debe ser un número mayor que cero.", MsgBoxStyle.Exclamation)
            Return
        End If
        ' Actualizar ListView
        If selectedListViewItem IsNot Nothing Then
            selectedListViewItem.SubItems(6).Text = txtNoPoliza.Text
            selectedListViewItem.SubItems(7).Text = txtIVA.Text
            ' Ingreso sin IVA es calculado, no editable ni guardado
            selectedListViewItem.SubItems(8).Text = Math.Round(valorIVA / 0.15, 2).ToString("N2")
        End If
        ' Actualizar base de datos con ExecuteSQL seguro
        Dim sql As String = "IF EXISTS (SELECT 1 FROM dsc.Importaciones_Datos WHERE Numero_de_Documento = @NoFactura) " &
                            "BEGIN " &
                            "UPDATE dsc.Importaciones_Datos SET no_factura = @NoPoliza, iva = @IVA WHERE Numero_de_Documento = @NoFactura " &
                            "END " &
                            "ELSE " &
                            "BEGIN " &
                            "INSERT INTO dsc.Importaciones_Datos (Numero_de_Documento, no_factura, iva) VALUES (@NoFactura, @NoPoliza, @IVA) " &
                            "END"
        Dim parametros As SqlClient.SqlParameter() = {
            New SqlClient.SqlParameter("@NoFactura", txtNoFactura.Text),
            New SqlClient.SqlParameter("@NoPoliza", txtNoPoliza.Text),
            New SqlClient.SqlParameter("@IVA", valorIVA)
        }
        Dim res = ExecuteSQL(sql, CN, Nothing, True, parametros)
        If res >= 0 Then
            MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information)
        Else
            MsgBox("Error al guardar los datos.", MsgBoxStyle.Critical)
        End If
        pnlModal.Visible = False
        LLenar_List_View("select C.Numero_de_Documento, C.Fecha, P.Nombre, C.Total_en_Ventas, C.Total_en_Impuesto, C.Total_Neto, ID.no_factura, ID.iva , round(id.iva / 0.15, 2) as Ingreso_Sin_Iva from Compras C left join dsc.Importaciones_Datos ID ON C.Numero_de_Documento = ID.Numero_de_Documento left join proveedores P ON P.codigo_proveedor = c.codigo_proveedor WHERE C.TipoCompra = 2 and c.Anulada = 0 order by C.Fecha  desc", lstLista, CN, MFormato, True, True, True)
    End Sub

    Private Sub BorrarPanelModal(sender As Object, e As EventArgs)
        If MsgBox("¿Está seguro que desea borrar este registro?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Dim sql As String = "DELETE FROM dsc.Importaciones_Datos WHERE Numero_de_Documento = @NoFactura"
            Dim parametros As SqlClient.SqlParameter() = {
                New SqlClient.SqlParameter("@NoFactura", txtNoFactura.Text)
            }
            Dim res = ExecuteSQL(sql, CN, Nothing, True, parametros)
            If res >= 0 Then
                MsgBox("Registro borrado correctamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Error al borrar el registro.", MsgBoxStyle.Critical)
            End If
            pnlModal.Visible = False
            LLenar_List_View("select C.Numero_de_Documento, C.Fecha, P.Nombre, C.Total_en_Ventas, C.Total_en_Impuesto, C.Total_Neto, ID.no_factura, ID.iva , round(id.iva / 0.15, 2) as Ingreso_Sin_Iva from Compras C left join dsc.Importaciones_Datos ID ON C.Numero_de_Documento = ID.Numero_de_Documento left join proveedores P ON P.codigo_proveedor = c.codigo_proveedor WHERE C.TipoCompra = 2 and c.Anulada = 0 order by C.Fecha  desc", lstLista, CN, MFormato, True, True, True)
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If Vacio(txtTextoBusqueda.Text) Then
            LLenar_List_View("select C.Numero_de_Documento, C.Fecha, P.Nombre, 	C.Total_en_Ventas, C.Total_en_Impuesto, C.Total_Neto, ID.no_factura, ID.iva , round(id.iva / 0.15, 2) as Ingreso_Sin_Iva from Compras C left join dsc.Importaciones_Datos ID ON C.Numero_de_Documento = ID.Numero_de_Documento left join proveedores P ON P.codigo_proveedor = c.codigo_proveedor WHERE C.TipoCompra = 2 and c.Anulada = 0 order by C.Fecha  desc", lstLista, CN, MFormato, False, True, True)
        Else
            If txtTipoBusqueda.SelectedIndex = 0 Then
                LLenar_List_View("select C.Numero_de_Documento, C.Fecha, P.Nombre, 	C.Total_en_Ventas, C.Total_en_Impuesto, C.Total_Neto, ID.no_factura, ID.iva , round(id.iva / 0.15, 2) as Ingreso_Sin_Iva from Compras C left join dsc.Importaciones_Datos ID ON C.Numero_de_Documento = ID.Numero_de_Documento left join proveedores P ON P.codigo_proveedor = c.codigo_proveedor WHERE C.TipoCompra = 2 and c.Anulada = 0  and Numero_de_Documento like '%" & txtTextoBusqueda.Text & "%' order by C.Fecha  desc", lstLista, CN, MFormato, False, True, True)
            End If
            If txtTipoBusqueda.SelectedIndex = 1 Then
                If IsDate(txtTextoBusqueda.Text) Then
                    LLenar_List_View("select C.Numero_de_Documento, C.Fecha, P.Nombre, 	C.Total_en_Ventas, C.Total_en_Impuesto, C.Total_Neto, ID.no_factura, ID.iva , round(id.iva / 0.15, 2) as Ingreso_Sin_Iva from Compras C left join dsc.Importaciones_Datos ID ON C.Numero_de_Documento = ID.Numero_de_Documento left join proveedores P ON P.codigo_proveedor = c.codigo_proveedor WHERE C.TipoCompra = 2 and c.Anulada = 0 and Fecha = '" & Format(CDate(txtTextoBusqueda.Text), "yyyy-MM-dd") & "' order by C.Fecha  desc", lstLista, CN, MFormato, False, True, True)
                Else
                    MsgBox("Sr. Usuario: Por favor digite una fecha válida")
                    Exit Sub
                End If
            End If

            If txtTipoBusqueda.SelectedIndex = 2 Then
                LLenar_List_View("select C.Numero_de_Documento, C.Fecha, P.Nombre, 	C.Total_en_Ventas, C.Total_en_Impuesto, C.Total_Neto, ID.no_factura, ID.iva , round(id.iva / 0.15, 2) as Ingreso_Sin_Iva from Compras C left join dsc.Importaciones_Datos ID ON C.Numero_de_Documento = ID.Numero_de_Documento left join proveedores P ON P.codigo_proveedor = c.codigo_proveedor WHERE C.TipoCompra = 2 and c.Anulada = 0 and Nombre_del_Cliente like '%" & txtTextoBusqueda.Text & "%' order by C.Fecha  desc", lstLista, CN, MFormato, False, True, True)
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

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        LLenar_List_View("select C.Numero_de_Documento, C.Fecha, P.Nombre, 	C.Total_en_Ventas, C.Total_en_Impuesto, C.Total_Neto, ID.no_factura, ID.iva , round(id.iva / 0.15, 2) as Ingreso_Sin_Iva from Compras C left join dsc.Importaciones_Datos ID ON C.Numero_de_Documento = ID.Numero_de_Documento left join proveedores P ON P.codigo_proveedor = c.codigo_proveedor WHERE C.TipoCompra = 2 and c.Anulada = 0 order by C.Fecha  desc", lstLista, CN, MFormato, False, True, True)
    End Sub

    Private Sub lstLista_DoubleClick(sender As Object, e As EventArgs) Handles lstLista.DoubleClick
        If lstLista.SelectedItems.Count > 0 Then
            Dim item = lstLista.SelectedItems(0)
            MostrarPanelModal(item.SubItems(0).Text, item.SubItems(6).Text, item.SubItems(7).Text, item)
        End If
    End Sub
End Class