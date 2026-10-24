<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigConexion
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
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.lblBaseDatos = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.txtBaseDatos = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.cmdProbar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblServidor
        '
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Location = New System.Drawing.Point(24, 27)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(55, 17)
        Me.lblServidor.TabIndex = 0
        Me.lblServidor.Text = "Servidor"
        '
        'lblBaseDatos
        '
        Me.lblBaseDatos.AutoSize = True
        Me.lblBaseDatos.Location = New System.Drawing.Point(24, 67)
        Me.lblBaseDatos.Name = "lblBaseDatos"
        Me.lblBaseDatos.Size = New System.Drawing.Size(93, 17)
        Me.lblBaseDatos.TabIndex = 2
        Me.lblBaseDatos.Text = "Base de Datos"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(24, 107)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 17)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(24, 147)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(80, 17)
        Me.lblContrasena.TabIndex = 6
        Me.lblContrasena.Text = "Contraseña"
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(140, 24)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(260, 22)
        Me.txtServidor.TabIndex = 1
        '
        'txtBaseDatos
        '
        Me.txtBaseDatos.Location = New System.Drawing.Point(140, 64)
        Me.txtBaseDatos.Name = "txtBaseDatos"
        Me.txtBaseDatos.Size = New System.Drawing.Size(260, 22)
        Me.txtBaseDatos.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(140, 104)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(260, 22)
        Me.txtUsuario.TabIndex = 5
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(140, 144)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(260, 22)
        Me.txtContrasena.TabIndex = 7
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'cmdProbar
        '
        Me.cmdProbar.Location = New System.Drawing.Point(27, 195)
        Me.cmdProbar.Name = "cmdProbar"
        Me.cmdProbar.Size = New System.Drawing.Size(130, 32)
        Me.cmdProbar.TabIndex = 8
        Me.cmdProbar.Text = "Probar conexión"
        Me.cmdProbar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(218, 195)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(85, 32)
        Me.cmdGuardar.TabIndex = 9
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(315, 195)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(85, 32)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'frmConfigConexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 251)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdProbar)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtBaseDatos)
        Me.Controls.Add(Me.txtServidor)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblBaseDatos)
        Me.Controls.Add(Me.lblServidor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigConexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de conexión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblServidor As System.Windows.Forms.Label
    Friend WithEvents lblBaseDatos As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContrasena As System.Windows.Forms.Label
    Friend WithEvents txtServidor As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseDatos As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents cmdProbar As System.Windows.Forms.Button
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
End Class
