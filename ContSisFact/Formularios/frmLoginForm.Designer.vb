<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmLoginForm
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
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Grupo = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtPassword = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtUser = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.Grupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo.SuspendLayout()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grupo
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.BackColor2 = System.Drawing.Color.Transparent
        Appearance3.BackColorDisabled = System.Drawing.Color.White
        Appearance3.BackColorDisabled2 = System.Drawing.Color.White
        Appearance3.BackGradientAlignment = Infragistics.Win.GradientAlignment.Form
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance3.BackHatchStyle = Infragistics.Win.BackHatchStyle.ForwardDiagonal
        Me.Grupo.Appearance = Appearance3
        Me.Grupo.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.HeaderSolid
        Me.Grupo.Controls.Add(Me.txtPassword)
        Me.Grupo.Controls.Add(Me.txtUser)
        Me.Grupo.Controls.Add(Me.Cancel)
        Me.Grupo.Controls.Add(Me.OK)
        Me.Grupo.Controls.Add(Me.ShapeContainer1)
        Me.Grupo.Location = New System.Drawing.Point(81, 26)
        Me.Grupo.Name = "Grupo"
        Me.Grupo.Size = New System.Drawing.Size(347, 240)
        Me.Grupo.TabIndex = 7
        Me.Grupo.Text = "Inicio de Sesion"
        Me.Grupo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtPassword
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Me.txtPassword.Appearance = Appearance1
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtPassword.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.VisualStudio2005
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(66, 86)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.NullText = "Contrasena"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 23)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.txtPassword.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        '
        'txtUser
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance2.BackColorAlpha = Infragistics.Win.Alpha.Opaque
        Appearance2.BackColorDisabled = System.Drawing.Color.Lime
        Appearance2.BackColorDisabled2 = System.Drawing.Color.Lime
        Appearance2.BorderAlpha = Infragistics.Win.Alpha.Transparent
        Me.txtUser.Appearance = Appearance2
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtUser.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.VisualStudio2005
        Me.txtUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(62, 42)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.NullText = "Usuario"
        Me.txtUser.Size = New System.Drawing.Size(220, 23)
        Me.txtUser.TabIndex = 0
        Me.txtUser.UseFlatMode = Infragistics.Win.DefaultableBoolean.[True]
        Me.txtUser.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.Cancel.Location = New System.Drawing.Point(189, 145)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 66)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'OK
        '
        Me.OK.Image = Global.ContSisFact.My.Resources.Resources.OK
        Me.OK.Location = New System.Drawing.Point(89, 145)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 66)
        Me.OK.TabIndex = 2
        Me.OK.Text = "&Aceptar"
        Me.OK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(1, 18)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(345, 221)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 63
        Me.LineShape3.X2 = 292
        Me.LineShape3.Y1 = 94
        Me.LineShape3.Y2 = 94
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 63
        Me.LineShape1.X2 = 289
        Me.LineShape1.Y1 = 49
        Me.LineShape1.Y2 = 49
        '
        'frmLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(515, 301)
        Me.Controls.Add(Me.Grupo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Reportes de Facturación e Inventario"
        CType(Me.Grupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo.ResumeLayout(False)
        Me.Grupo.PerformLayout()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Grupo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtPassword As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtUser As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
