<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidos
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidos))
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
        Me.TasaCambio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.txtTextoBusqueda = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdVerCotizacion = New System.Windows.Forms.Button()
        Me.optCordobas = New System.Windows.Forms.RadioButton()
        Me.optDolares = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(949, 23)
        Me.Label1.TabIndex = 5
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
        Me.lstLista.Location = New System.Drawing.Point(25, 74)
        Me.lstLista.MultiSelect = False
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(949, 518)
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
        'TasaCambio
        '
        Me.TasaCambio.Text = "Tasa de Cambio"
        Me.TasaCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TasaCambio.Width = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Buscar por:"
        '
        'txtTipoBusqueda
        '
        Me.txtTipoBusqueda.FormattingEnabled = True
        Me.txtTipoBusqueda.Items.AddRange(New Object() {"No. Pedido", "Fecha Pedido", "Cliente"})
        Me.txtTipoBusqueda.Location = New System.Drawing.Point(97, 47)
        Me.txtTipoBusqueda.Name = "txtTipoBusqueda"
        Me.txtTipoBusqueda.Size = New System.Drawing.Size(146, 21)
        Me.txtTipoBusqueda.TabIndex = 9
        '
        'txtTextoBusqueda
        '
        Me.txtTextoBusqueda.Location = New System.Drawing.Point(250, 47)
        Me.txtTextoBusqueda.Name = "txtTextoBusqueda"
        Me.txtTextoBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.txtTextoBusqueda.TabIndex = 10
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.ContSisFact.My.Resources.Resources.Buscar1
        Me.cmdBuscar.Location = New System.Drawing.Point(357, 31)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 40)
        Me.cmdBuscar.TabIndex = 11
        Me.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.Location = New System.Drawing.Point(1036, 256)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(92, 71)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdVerCotizacion
        '
        Me.cmdVerCotizacion.Image = Global.ContSisFact.My.Resources.Resources.Imprimir2
        Me.cmdVerCotizacion.Location = New System.Drawing.Point(1036, 101)
        Me.cmdVerCotizacion.Name = "cmdVerCotizacion"
        Me.cmdVerCotizacion.Size = New System.Drawing.Size(92, 71)
        Me.cmdVerCotizacion.TabIndex = 6
        Me.cmdVerCotizacion.Text = "Ver Cotizacion"
        Me.cmdVerCotizacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdVerCotizacion.UseVisualStyleBackColor = True
        '
        'optCordobas
        '
        Me.optCordobas.AutoSize = True
        Me.optCordobas.Location = New System.Drawing.Point(661, 48)
        Me.optCordobas.Name = "optCordobas"
        Me.optCordobas.Size = New System.Drawing.Size(86, 17)
        Me.optCordobas.TabIndex = 14
        Me.optCordobas.TabStop = True
        Me.optCordobas.Text = "C$ Cordobas"
        Me.optCordobas.UseVisualStyleBackColor = True
        '
        'optDolares
        '
        Me.optDolares.AutoSize = True
        Me.optDolares.Location = New System.Drawing.Point(768, 48)
        Me.optDolares.Name = "optDolares"
        Me.optDolares.Size = New System.Drawing.Size(70, 17)
        Me.optDolares.TabIndex = 15
        Me.optDolares.TabStop = True
        Me.optDolares.Text = "$ Dolares"
        Me.optDolares.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(713, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Ver pedido en:"
        '
        'frmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 646)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.optDolares)
        Me.Controls.Add(Me.optCordobas)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtTextoBusqueda)
        Me.Controls.Add(Me.txtTipoBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdVerCotizacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstLista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedidos"
        Me.Text = "Lista de Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdVerCotizacion As System.Windows.Forms.Button
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
    Friend WithEvents TasaCambio As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTipoBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents txtTextoBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents optCordobas As System.Windows.Forms.RadioButton
    Friend WithEvents optDolares As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
