<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHabilitarPrecios
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
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OK_Precios = New System.Windows.Forms.Button()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OK_Clientes = New System.Windows.Forms.Button()
        Me.rbClientesNo = New System.Windows.Forms.RadioButton()
        Me.rbClientesYes = New System.Windows.Forms.RadioButton()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.Location = New System.Drawing.Point(750, 582)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(125, 84)
        Me.cmdSalir.TabIndex = 48
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OK_Precios)
        Me.GroupBox1.Controls.Add(Me.rbNo)
        Me.GroupBox1.Controls.Add(Me.rbYes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(187, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 234)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habilitar Cambio de Precio en los Productos"
        '
        'OK_Precios
        '
        Me.OK_Precios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Precios.Image = Global.ContSisFact.My.Resources.Resources.OK
        Me.OK_Precios.Location = New System.Drawing.Point(563, 77)
        Me.OK_Precios.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Precios.Name = "OK_Precios"
        Me.OK_Precios.Size = New System.Drawing.Size(125, 81)
        Me.OK_Precios.TabIndex = 53
        Me.OK_Precios.Text = "&Aceptar"
        Me.OK_Precios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.Location = New System.Drawing.Point(313, 127)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(87, 46)
        Me.rbNo.TabIndex = 51
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.Location = New System.Drawing.Point(313, 77)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(72, 46)
        Me.rbYes.TabIndex = 50
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Si"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OK_Clientes)
        Me.GroupBox2.Controls.Add(Me.rbClientesNo)
        Me.GroupBox2.Controls.Add(Me.rbClientesYes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(184, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(836, 234)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Habilitar Cambio de Clientes"
        '
        'OK_Clientes
        '
        Me.OK_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Clientes.Image = Global.ContSisFact.My.Resources.Resources.OK
        Me.OK_Clientes.Location = New System.Drawing.Point(566, 97)
        Me.OK_Clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Clientes.Name = "OK_Clientes"
        Me.OK_Clientes.Size = New System.Drawing.Size(125, 81)
        Me.OK_Clientes.TabIndex = 57
        Me.OK_Clientes.Text = "&Aceptar"
        Me.OK_Clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'rbClientesNo
        '
        Me.rbClientesNo.AutoSize = True
        Me.rbClientesNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClientesNo.Location = New System.Drawing.Point(347, 108)
        Me.rbClientesNo.Name = "rbClientesNo"
        Me.rbClientesNo.Size = New System.Drawing.Size(87, 46)
        Me.rbClientesNo.TabIndex = 55
        Me.rbClientesNo.TabStop = True
        Me.rbClientesNo.Text = "No"
        Me.rbClientesNo.UseVisualStyleBackColor = True
        '
        'rbClientesYes
        '
        Me.rbClientesYes.AutoSize = True
        Me.rbClientesYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClientesYes.Location = New System.Drawing.Point(347, 58)
        Me.rbClientesYes.Name = "rbClientesYes"
        Me.rbClientesYes.Size = New System.Drawing.Size(72, 46)
        Me.rbClientesYes.TabIndex = 54
        Me.rbClientesYes.TabStop = True
        Me.rbClientesYes.Text = "Si"
        Me.rbClientesYes.UseVisualStyleBackColor = True
        '
        'frmHabilitarPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 690)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Name = "frmHabilitarPrecios"
        Me.Text = "frmHabilitarPrecios"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents cmdSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OK_Clientes As Button
    Friend WithEvents rbClientesNo As RadioButton
    Friend WithEvents rbClientesYes As RadioButton
    Friend WithEvents OK_Precios As Button
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbYes As RadioButton
End Class
