<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerPedidos
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
        Me.vReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rptFacturaPedido1 = New ContSisFact.rptFacturaPedido
        Me.SuspendLayout()
        '
        'vReport
        '
        Me.vReport.ActiveViewIndex = -1
        Me.vReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        'Me.vReport.DisplayGroupTree = False
        Me.vReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vReport.Location = New System.Drawing.Point(0, 0)
        Me.vReport.Name = "vReport"
        Me.vReport.Size = New System.Drawing.Size(527, 261)
        Me.vReport.TabIndex = 0
        '
        'frmVerPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 261)
        Me.Controls.Add(Me.vReport)
        Me.Name = "frmVerPedidos"
        Me.Text = "Cotizacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents vReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptFacturaPedido1 As ContSisFact.rptFacturaPedido
End Class
