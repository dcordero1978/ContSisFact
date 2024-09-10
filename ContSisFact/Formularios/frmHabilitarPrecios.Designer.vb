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
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbYes.Location = New System.Drawing.Point(366, 169)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(72, 46)
        Me.rbYes.TabIndex = 0
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Si"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.Location = New System.Drawing.Point(366, 219)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(87, 46)
        Me.rbNo.TabIndex = 1
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(749, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Habilitar Cambio de Precio en los Productos"
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.Location = New System.Drawing.Point(488, 288)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(152, 84)
        Me.cmdSalir.TabIndex = 48
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Image = Global.ContSisFact.My.Resources.Resources.OK
        Me.OK.Location = New System.Drawing.Point(218, 288)
        Me.OK.Margin = New System.Windows.Forms.Padding(4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(125, 81)
        Me.OK.TabIndex = 49
        Me.OK.Text = "&Aceptar"
        Me.OK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmHabilitarPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbNo)
        Me.Controls.Add(Me.rbYes)
        Me.Name = "frmHabilitarPrecios"
        Me.Text = "frmHabilitarPrecios"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents OK As Button
End Class
