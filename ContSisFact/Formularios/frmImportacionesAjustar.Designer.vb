<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportacionesAjustar
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
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.TotalNeto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalImpuesto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TotalVentas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Proveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstLista = New System.Windows.Forms.ListView()
        Me.NoFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FechaFactura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NoPoliza = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtTextoBusqueda = New System.Windows.Forms.TextBox()
        Me.txtTipoBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IVA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IngresoSinIVA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = Global.ContSisFact.My.Resources.Resources.Actualizar1
        Me.cmdActualizar.Location = New System.Drawing.Point(1393, 502)
        Me.cmdActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(123, 87)
        Me.cmdActualizar.TabIndex = 40
        Me.cmdActualizar.Text = "Actualizar Datos"
        Me.cmdActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdActualizar.UseVisualStyleBackColor = True
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
        'Proveedor
        '
        Me.Proveedor.Text = "Proveedor"
        Me.Proveedor.Width = 228
        '
        'lstLista
        '
        Me.lstLista.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstLista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NoFactura, Me.FechaFactura, Me.Proveedor, Me.TotalVentas, Me.TotalImpuesto, Me.TotalNeto, Me.NoPoliza, Me.IVA, Me.IngresoSinIVA})
        Me.lstLista.FullRowSelect = True
        Me.lstLista.GridLines = True
        Me.lstLista.HideSelection = False
        Me.lstLista.Location = New System.Drawing.Point(40, 116)
        Me.lstLista.Margin = New System.Windows.Forms.Padding(4)
        Me.lstLista.MultiSelect = False
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(1339, 637)
        Me.lstLista.TabIndex = 29
        Me.lstLista.UseCompatibleStateImageBehavior = False
        Me.lstLista.View = System.Windows.Forms.View.Details
        '
        'NoFactura
        '
        Me.NoFactura.Text = "No. Factura"
        Me.NoFactura.Width = 89
        '
        'FechaFactura
        '
        Me.FechaFactura.Text = "Fecha"
        Me.FechaFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FechaFactura.Width = 161
        '
        'NoPoliza
        '
        Me.NoPoliza.Text = "NoPoliza"
        Me.NoPoliza.Width = 95
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.Location = New System.Drawing.Point(1393, 212)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(123, 87)
        Me.cmdSalir.TabIndex = 32
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1265, 28)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Listado de Importaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.ContSisFact.My.Resources.Resources.Buscar1
        Me.cmdBuscar.Location = New System.Drawing.Point(483, 63)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(100, 49)
        Me.cmdBuscar.TabIndex = 36
        Me.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtTextoBusqueda
        '
        Me.txtTextoBusqueda.Location = New System.Drawing.Point(340, 83)
        Me.txtTextoBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTextoBusqueda.Name = "txtTextoBusqueda"
        Me.txtTextoBusqueda.Size = New System.Drawing.Size(132, 22)
        Me.txtTextoBusqueda.TabIndex = 35
        '
        'txtTipoBusqueda
        '
        Me.txtTipoBusqueda.FormattingEnabled = True
        Me.txtTipoBusqueda.Items.AddRange(New Object() {"No. Factura", "Fecha Factura", "Cliente"})
        Me.txtTipoBusqueda.Location = New System.Drawing.Point(136, 83)
        Me.txtTipoBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoBusqueda.Name = "txtTipoBusqueda"
        Me.txtTipoBusqueda.Size = New System.Drawing.Size(193, 24)
        Me.txtTipoBusqueda.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Buscar por:"
        '
        'IVA
        '
        Me.IVA.Text = "IVA"
        Me.IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IVA.Width = 118
        '
        'IngresoSinIVA
        '
        Me.IngresoSinIVA.Text = "Ingreso Sin IVA"
        Me.IngresoSinIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.IngresoSinIVA.Width = 135
        '
        'frmImportacionesAjustar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1586, 830)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.lstLista)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.txtTextoBusqueda)
        Me.Controls.Add(Me.txtTipoBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmImportacionesAjustar"
        Me.Text = "frmImportacionesAjustar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdActualizar As Button
    Friend WithEvents TotalNeto As ColumnHeader
    Friend WithEvents TotalImpuesto As ColumnHeader
    Friend WithEvents TotalVentas As ColumnHeader
    Friend WithEvents Proveedor As ColumnHeader
    Friend WithEvents lstLista As ListView
    Friend WithEvents NoFactura As ColumnHeader
    Friend WithEvents FechaFactura As ColumnHeader
    Friend WithEvents NoPoliza As ColumnHeader
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents txtTextoBusqueda As TextBox
    Friend WithEvents txtTipoBusqueda As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IVA As ColumnHeader
    Friend WithEvents IngresoSinIVA As ColumnHeader
End Class
