<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsignacion
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
        Me.txtCodPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lstDetallePedido = New System.Windows.Forms.ListView()
        Me.CodProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cantidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Precio_US = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Precio_C = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdVerRemision = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.optDolares = New System.Windows.Forms.RadioButton()
        Me.optCordobas = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtCodPedido
        '
        Me.txtCodPedido.Enabled = False
        Me.txtCodPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPedido.Location = New System.Drawing.Point(255, 57)
        Me.txtCodPedido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodPedido.Name = "txtCodPedido"
        Me.txtCodPedido.Size = New System.Drawing.Size(148, 26)
        Me.txtCodPedido.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Enabled = False
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(255, 93)
        Me.txtCodCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(68, 26)
        Me.txtCodCliente.TabIndex = 2
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Enabled = False
        Me.txtNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(324, 93)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(301, 26)
        Me.txtNombreCliente.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Vendedor"
        '
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedor.Location = New System.Drawing.Point(255, 129)
        Me.txtVendedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(148, 26)
        Me.txtVendedor.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(639, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(745, 49)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(148, 26)
        Me.txtFecha.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(642, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "No. RUC"
        '
        'txtRUC
        '
        Me.txtRUC.Enabled = False
        Me.txtRUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.Location = New System.Drawing.Point(745, 96)
        Me.txtRUC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(148, 26)
        Me.txtRUC.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(130, 175)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(255, 172)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(638, 72)
        Me.txtObservaciones.TabIndex = 11
        '
        'lstDetallePedido
        '
        Me.lstDetallePedido.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstDetallePedido.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodProducto, Me.Descripcion, Me.Cantidad, Me.Precio_US, Me.Precio_C, Me.SubTotal})
        Me.lstDetallePedido.FullRowSelect = True
        Me.lstDetallePedido.GridLines = True
        Me.lstDetallePedido.HideSelection = False
        Me.lstDetallePedido.Location = New System.Drawing.Point(13, 303)
        Me.lstDetallePedido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstDetallePedido.MultiSelect = False
        Me.lstDetallePedido.Name = "lstDetallePedido"
        Me.lstDetallePedido.Size = New System.Drawing.Size(1159, 335)
        Me.lstDetallePedido.TabIndex = 18
        Me.lstDetallePedido.UseCompatibleStateImageBehavior = False
        Me.lstDetallePedido.View = System.Windows.Forms.View.Details
        '
        'CodProducto
        '
        Me.CodProducto.Text = "Codigo"
        Me.CodProducto.Width = 74
        '
        'Descripcion
        '
        Me.Descripcion.Text = "Descripcion"
        Me.Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Descripcion.Width = 591
        '
        'Cantidad
        '
        Me.Cantidad.Text = "Cantidad"
        Me.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Cantidad.Width = 91
        '
        'Precio_US
        '
        Me.Precio_US.Text = "Precio USD"
        Me.Precio_US.Width = 130
        '
        'Precio_C
        '
        Me.Precio_C.Text = "Precio C$"
        Me.Precio_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Precio_C.Width = 129
        '
        'SubTotal
        '
        Me.SubTotal.Text = "Sub Total"
        Me.SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubTotal.Width = 134
        '
        'cmdVerRemision
        '
        Me.cmdVerRemision.Image = Global.ContSisFact.My.Resources.Resources.Imprimir2
        Me.cmdVerRemision.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdVerRemision.Location = New System.Drawing.Point(909, 29)
        Me.cmdVerRemision.Name = "cmdVerRemision"
        Me.cmdVerRemision.Size = New System.Drawing.Size(115, 82)
        Me.cmdVerRemision.TabIndex = 20
        Me.cmdVerRemision.Text = "Ver Remision"
        Me.cmdVerRemision.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdVerRemision.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.ContSisFact.My.Resources.Resources.Imprimir2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(909, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 82)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Hacer Salida a Bodega"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalir.Location = New System.Drawing.Point(1043, 113)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(115, 82)
        Me.cmdSalir.TabIndex = 22
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(553, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Ver Remisión en:"
        '
        'optDolares
        '
        Me.optDolares.AutoSize = True
        Me.optDolares.Location = New System.Drawing.Point(643, 270)
        Me.optDolares.Name = "optDolares"
        Me.optDolares.Size = New System.Drawing.Size(95, 24)
        Me.optDolares.TabIndex = 24
        Me.optDolares.Text = "$ Dolares"
        Me.optDolares.UseVisualStyleBackColor = True
        '
        'optCordobas
        '
        Me.optCordobas.AutoSize = True
        Me.optCordobas.Checked = True
        Me.optCordobas.Location = New System.Drawing.Point(501, 270)
        Me.optCordobas.Name = "optCordobas"
        Me.optCordobas.Size = New System.Drawing.Size(120, 24)
        Me.optCordobas.TabIndex = 23
        Me.optCordobas.TabStop = True
        Me.optCordobas.Text = "C$ Cordobas"
        Me.optCordobas.UseVisualStyleBackColor = True
        '
        'frmConsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.optDolares)
        Me.Controls.Add(Me.optCordobas)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdVerRemision)
        Me.Controls.Add(Me.lstDetallePedido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRUC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodPedido)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmConsignacion"
        Me.Text = "frmConsignacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodPedido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtVendedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRUC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents lstDetallePedido As ListView
    Friend WithEvents CodProducto As ColumnHeader
    Friend WithEvents Descripcion As ColumnHeader
    Friend WithEvents Cantidad As ColumnHeader
    Friend WithEvents Precio_US As ColumnHeader
    Friend WithEvents Precio_C As ColumnHeader
    Friend WithEvents SubTotal As ColumnHeader
    Friend WithEvents cmdVerRemision As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents optDolares As RadioButton
    Friend WithEvents optCordobas As RadioButton
End Class
