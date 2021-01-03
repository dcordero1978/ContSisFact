<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidosAConsignacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtTextoBusqueda = New System.Windows.Forms.TextBox()
        Me.txtTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.TasaCambio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Anulada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalNeto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalImpuesto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalVentas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaVencimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NoFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstLista = New System.Windows.Forms.ListView()
        Me.HacerFacturaConsignacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.ContSisFact.My.Resources.Resources.Buscar1
        Me.cmdBuscar.Location = New System.Drawing.Point(356, 34)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 40)
        Me.cmdBuscar.TabIndex = 24
        Me.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtTextoBusqueda
        '
        Me.txtTextoBusqueda.Location = New System.Drawing.Point(249, 50)
        Me.txtTextoBusqueda.Name = "txtTextoBusqueda"
        Me.txtTextoBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.txtTextoBusqueda.TabIndex = 23
        '
        'txtTipoBusqueda
        '
        Me.txtTipoBusqueda.FormattingEnabled = True
        Me.txtTipoBusqueda.Items.AddRange(New Object() {"No. Pedido", "Fecha Pedido", "Cliente"})
        Me.txtTipoBusqueda.Location = New System.Drawing.Point(96, 50)
        Me.txtTipoBusqueda.Name = "txtTipoBusqueda"
        Me.txtTipoBusqueda.Size = New System.Drawing.Size(146, 21)
        Me.txtTipoBusqueda.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Buscar por:"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.Location = New System.Drawing.Point(1045, 237)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(92, 71)
        Me.cmdSalir.TabIndex = 20
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'TasaCambio
        '
        Me.TasaCambio.Text = "Tasa de Cambio"
        Me.TasaCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TasaCambio.Width = 95
        '
        'Anulada
        '
        Me.Anulada.Text = "Anulada"
        Me.Anulada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Anulada.Width = 54
        '
        'TotalNeto
        '
        Me.TotalNeto.Text = "Total Neto"
        Me.TotalNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalNeto.Width = 70
        '
        'TotalImpuesto
        '
        Me.TotalImpuesto.Text = "Total Impuesto"
        Me.TotalImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalImpuesto.Width = 94
        '
        'TotalVentas
        '
        Me.TotalVentas.Text = "Total Ventas"
        Me.TotalVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalVentas.Width = 94
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 228
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.Text = "Fecha Vencimiento"
        Me.FechaVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FechaVencimiento.Width = 109
        '
        'FechaFactura
        '
        Me.FechaFactura.Text = "Fecha Pedido"
        Me.FechaFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FechaFactura.Width = 91
        '
        'NoFactura
        '
        Me.NoFactura.Text = "No. Pedido"
        Me.NoFactura.Width = 89
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(949, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Listado de Pedidos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstLista
        '
        Me.lstLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NoFactura, Me.FechaFactura, Me.FechaVencimiento, Me.Cliente, Me.TotalVentas, Me.TotalImpuesto, Me.TotalNeto, Me.Anulada, Me.TasaCambio})
        Me.lstLista.FullRowSelect = True
        Me.lstLista.GridLines = True
        Me.lstLista.HideSelection = False
        Me.lstLista.Location = New System.Drawing.Point(24, 77)
        Me.lstLista.MultiSelect = False
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(949, 518)
        Me.lstLista.TabIndex = 17
        Me.lstLista.UseCompatibleStateImageBehavior = False
        Me.lstLista.View = System.Windows.Forms.View.Details
        '
        'HacerFacturaConsignacion
        '
        Me.HacerFacturaConsignacion.Location = New System.Drawing.Point(1045, 116)
        Me.HacerFacturaConsignacion.Name = "HacerFacturaConsignacion"
        Me.HacerFacturaConsignacion.Size = New System.Drawing.Size(92, 71)
        Me.HacerFacturaConsignacion.TabIndex = 28
        Me.HacerFacturaConsignacion.Text = "Convertir en Remisión"
        Me.HacerFacturaConsignacion.UseVisualStyleBackColor = True
        '
        'frmPedidosAConsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 646)
        Me.Controls.Add(Me.HacerFacturaConsignacion)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtTextoBusqueda)
        Me.Controls.Add(Me.txtTipoBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstLista)
        Me.Name = "frmPedidosAConsignacion"
        Me.Text = "frmPedidosAConsignacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txtTextoBusqueda As TextBox
    Friend WithEvents txtTipoBusqueda As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents TasaCambio As ColumnHeader
    Friend WithEvents Anulada As ColumnHeader
    Friend WithEvents TotalNeto As ColumnHeader
    Friend WithEvents TotalImpuesto As ColumnHeader
    Friend WithEvents TotalVentas As ColumnHeader
    Friend WithEvents Cliente As ColumnHeader
    Friend WithEvents FechaVencimiento As ColumnHeader
    Friend WithEvents FechaFactura As ColumnHeader
    Friend WithEvents NoFactura As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents lstLista As ListView
    Friend WithEvents HacerFacturaConsignacion As Button
End Class
