<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPedidosBusqueda
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidosBusqueda))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstLista = New System.Windows.Forms.ListView()
        Me.NoFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaVencimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalVentas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalImpuesto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalNeto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Anulada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Factura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.txtTextoBusqueda = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.optCordobas = New System.Windows.Forms.RadioButton()
        Me.optDolares = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1265, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Listado de Pedidos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstLista
        '
        Me.lstLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NoFactura, Me.FechaFactura, Me.FechaVencimiento, Me.Cliente, Me.TotalVentas, Me.TotalImpuesto, Me.TotalNeto, Me.Anulada, Me.Factura})
        Me.lstLista.FullRowSelect = True
        Me.lstLista.GridLines = True
        Me.lstLista.HideSelection = False
        Me.lstLista.Location = New System.Drawing.Point(33, 91)
        Me.lstLista.Margin = New System.Windows.Forms.Padding(4)
        Me.lstLista.MultiSelect = False
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(1264, 637)
        Me.lstLista.TabIndex = 4
        Me.lstLista.UseCompatibleStateImageBehavior = False
        Me.lstLista.View = System.Windows.Forms.View.Details
        '
        'NoFactura
        '
        Me.NoFactura.Text = "No. Pedido"
        Me.NoFactura.Width = 89
        '
        'FechaFactura
        '
        Me.FechaFactura.Text = "Fecha Pedido"
        Me.FechaFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FechaFactura.Width = 91
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.Text = "Fecha Vencimiento"
        Me.FechaVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FechaVencimiento.Width = 109
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 228
        '
        'TotalVentas
        '
        Me.TotalVentas.Text = "Total Ventas"
        Me.TotalVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalVentas.Width = 94
        '
        'TotalImpuesto
        '
        Me.TotalImpuesto.Text = "Total Impuesto"
        Me.TotalImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalImpuesto.Width = 94
        '
        'TotalNeto
        '
        Me.TotalNeto.Text = "Total Neto"
        Me.TotalNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalNeto.Width = 70
        '
        'Anulada
        '
        Me.Anulada.Text = "Anulada"
        Me.Anulada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Anulada.Width = 54
        '
        'Factura
        '
        Me.Factura.Text = "Factura"
        Me.Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Factura.Width = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Buscar por:"
        '
        'txtTipoBusqueda
        '
        Me.txtTipoBusqueda.FormattingEnabled = True
        Me.txtTipoBusqueda.Items.AddRange(New Object() {"No. Pedido", "Fecha Pedido", "Cliente"})
        Me.txtTipoBusqueda.Location = New System.Drawing.Point(129, 58)
        Me.txtTipoBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoBusqueda.Name = "txtTipoBusqueda"
        Me.txtTipoBusqueda.Size = New System.Drawing.Size(193, 24)
        Me.txtTipoBusqueda.TabIndex = 9
        '
        'txtTextoBusqueda
        '
        Me.txtTextoBusqueda.Location = New System.Drawing.Point(333, 58)
        Me.txtTextoBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTextoBusqueda.Name = "txtTextoBusqueda"
        Me.txtTextoBusqueda.Size = New System.Drawing.Size(132, 22)
        Me.txtTextoBusqueda.TabIndex = 10
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.ContSisFact.My.Resources.Resources.Buscar1
        Me.cmdBuscar.Location = New System.Drawing.Point(476, 38)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(100, 49)
        Me.cmdBuscar.TabIndex = 11
        Me.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.Location = New System.Drawing.Point(1381, 315)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(123, 87)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'optCordobas
        '
        Me.optCordobas.AutoSize = True
        Me.optCordobas.Location = New System.Drawing.Point(881, 59)
        Me.optCordobas.Margin = New System.Windows.Forms.Padding(4)
        Me.optCordobas.Name = "optCordobas"
        Me.optCordobas.Size = New System.Drawing.Size(107, 20)
        Me.optCordobas.TabIndex = 14
        Me.optCordobas.TabStop = True
        Me.optCordobas.Text = "C$ Cordobas"
        Me.optCordobas.UseVisualStyleBackColor = True
        '
        'optDolares
        '
        Me.optDolares.AutoSize = True
        Me.optDolares.Location = New System.Drawing.Point(1024, 59)
        Me.optDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.optDolares.Name = "optDolares"
        Me.optDolares.Size = New System.Drawing.Size(86, 20)
        Me.optDolares.TabIndex = 15
        Me.optDolares.TabStop = True
        Me.optDolares.Text = "$ Dolares"
        Me.optDolares.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(951, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Ver pedido en:"
        '
        'frmPedidosBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1573, 795)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.optDolares)
        Me.Controls.Add(Me.optCordobas)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtTextoBusqueda)
        Me.Controls.Add(Me.txtTipoBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstLista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPedidosBusqueda"
        Me.Text = "Lista de Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstLista As System.Windows.Forms.ListView
    Friend WithEvents NoFactura As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaFactura As System.Windows.Forms.ColumnHeader
    Friend WithEvents FechaVencimiento As System.Windows.Forms.ColumnHeader
    Friend WithEvents Cliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalVentas As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalImpuesto As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalNeto As System.Windows.Forms.ColumnHeader
    Friend WithEvents Anulada As System.Windows.Forms.ColumnHeader
    Friend WithEvents Factura As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTipoBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents txtTextoBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents optCordobas As System.Windows.Forms.RadioButton
    Friend WithEvents optDolares As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
