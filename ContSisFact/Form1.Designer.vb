<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim UltraExplorerBarGroup1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup()
        Me.UltraExplorerBar1 = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraExplorerBar1
        '
        UltraExplorerBarGroup1.Text = "New Group"
        Me.UltraExplorerBar1.Groups.AddRange(New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup() {UltraExplorerBarGroup1})
        Me.UltraExplorerBar1.Location = New System.Drawing.Point(364, 94)
        Me.UltraExplorerBar1.Name = "UltraExplorerBar1"
        Me.UltraExplorerBar1.Size = New System.Drawing.Size(175, 268)
        Me.UltraExplorerBar1.TabIndex = 0
        Me.UltraExplorerBar1.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.VisualStudio2005
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UltraExplorerBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UltraExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UltraExplorerBar1 As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
End Class
