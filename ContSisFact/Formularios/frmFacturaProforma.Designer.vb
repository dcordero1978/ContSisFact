<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaProforma
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProforma = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.OK_Precios = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(803, 28)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Asociar Facturas - Proformas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Factura"
        '
        'txtFactura
        '
        Me.txtFactura.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(263, 89)
        Me.txtFactura.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.ReadOnly = True
        Me.txtFactura.Size = New System.Drawing.Size(309, 30)
        Me.txtFactura.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(163, 142)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Proforma"
        '
        'txtProforma
        '
        Me.txtProforma.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtProforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProforma.Location = New System.Drawing.Point(263, 139)
        Me.txtProforma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProforma.Name = "txtProforma"
        Me.txtProforma.ReadOnly = True
        Me.txtProforma.Size = New System.Drawing.Size(309, 30)
        Me.txtProforma.TabIndex = 22
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.Location = New System.Drawing.Point(481, 245)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(123, 87)
        Me.cmdSalir.TabIndex = 24
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'OK_Precios
        '
        Me.OK_Precios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Precios.Image = Global.ContSisFact.My.Resources.Resources.OK
        Me.OK_Precios.Location = New System.Drawing.Point(195, 245)
        Me.OK_Precios.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Precios.Name = "OK_Precios"
        Me.OK_Precios.Size = New System.Drawing.Size(125, 87)
        Me.OK_Precios.TabIndex = 54
        Me.OK_Precios.Text = "&Aceptar"
        Me.OK_Precios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.Image = Global.ContSisFact.My.Resources.Resources.Eliminar
        Me.cmdBorrar.Location = New System.Drawing.Point(337, 245)
        Me.cmdBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(125, 87)
        Me.cmdBorrar.TabIndex = 55
        Me.cmdBorrar.Text = "&Borrar"
        Me.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Image = Global.ContSisFact.My.Resources.Resources.Buscar11
        Me.cmdBuscar.Location = New System.Drawing.Point(602, 115)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(125, 87)
        Me.cmdBuscar.TabIndex = 56
        Me.cmdBuscar.Text = "&Buscar Proforma"
        Me.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmFacturaProforma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.OK_Precios)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProforma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFacturaProforma"
        Me.Text = "frmFacturaProforma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProforma As TextBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents OK_Precios As Button
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents cmdBuscar As Button
End Class
