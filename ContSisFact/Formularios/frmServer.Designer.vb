<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServer
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.lstLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cmbReportes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdExportXLS = New System.Windows.Forms.Button()
        Me.Excel = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        CType(Me.lstLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstLista
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Me.lstLista.DisplayLayout.Appearance = Appearance1
        Appearance2.BackColor = System.Drawing.Color.Aquamarine
        Appearance2.BackColor2 = System.Drawing.Color.RoyalBlue
        Appearance2.BackColorAlpha = Infragistics.Win.Alpha.Transparent
        Appearance2.BorderColor = System.Drawing.Color.Red
        Me.lstLista.DisplayLayout.CaptionAppearance = Appearance2
        Me.lstLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.lstLista.DisplayLayout.GroupByBox.Prompt = "Arrastre un encabezado de columna aqui, para agrupar por esa columna"
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.None
        Appearance3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lstLista.DisplayLayout.Override.ActiveRowAppearance = Appearance3
        Me.lstLista.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.lstLista.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.lstLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.lstLista.DisplayLayout.Override.CardAreaAppearance = Appearance4
        Me.lstLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.lstLista.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(150, Byte), Integer))
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.FontData.BoldAsString = "True"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 10.0!
        Appearance5.ForeColor = System.Drawing.Color.White
        Appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.lstLista.DisplayLayout.Override.HeaderAppearance = Appearance5
        Me.lstLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer))
        Appearance6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(150, Byte), Integer))
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.lstLista.DisplayLayout.Override.RowSelectorAppearance = Appearance6
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.lstLista.DisplayLayout.Override.SelectedRowAppearance = Appearance7
        Me.lstLista.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.lstLista.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.lstLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.lstLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.lstLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.lstLista.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.lstLista.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.lstLista.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.lstLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLista.Location = New System.Drawing.Point(12, 55)
        Me.lstLista.Name = "lstLista"
        Me.lstLista.Size = New System.Drawing.Size(1062, 411)
        Me.lstLista.TabIndex = 33
        Me.lstLista.Text = "UltraGrid1"
        '
        'cmbReportes
        '
        Me.cmbReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportes.FormattingEnabled = True
        Me.cmbReportes.Items.AddRange(New Object() {"Ninguno", "Existencia en Inventario", "Ventas", "Comisiones", "Comisiones - Recuperacion", "Inventario", "Compras General", "Compras Cordobas", "Compras Dolares", "Movimiento por Mes", "Frecuencia de Clientes"})
        Me.cmbReportes.Location = New System.Drawing.Point(87, 28)
        Me.cmbReportes.Name = "cmbReportes"
        Me.cmbReportes.Size = New System.Drawing.Size(146, 21)
        Me.cmbReportes.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Reporte:"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = Global.ContSisFact.My.Resources.Resources.Actualizar1
        Me.cmdActualizar.Location = New System.Drawing.Point(455, 472)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(92, 71)
        Me.cmdActualizar.TabIndex = 46
        Me.cmdActualizar.Text = "Actualizar Datos"
        Me.cmdActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = Global.ContSisFact.My.Resources.Resources.EXIT00C
        Me.cmdSalir.Location = New System.Drawing.Point(696, 472)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(114, 68)
        Me.cmdSalir.TabIndex = 45
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdExportXLS
        '
        Me.cmdExportXLS.Image = Global.ContSisFact.My.Resources.Resources.EXCEL0D
        Me.cmdExportXLS.Location = New System.Drawing.Point(214, 472)
        Me.cmdExportXLS.Name = "cmdExportXLS"
        Me.cmdExportXLS.Size = New System.Drawing.Size(114, 68)
        Me.cmdExportXLS.TabIndex = 44
        Me.cmdExportXLS.Text = "Exportar a Excel"
        Me.cmdExportXLS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExportXLS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExportXLS.UseVisualStyleBackColor = True
        '
        'frmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 564)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdExportXLS)
        Me.Controls.Add(Me.cmbReportes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstLista)
        Me.Name = "frmServer"
        Me.Text = "frmServer"
        CType(Me.lstLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmbReportes As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdExportXLS As System.Windows.Forms.Button
    Friend WithEvents Excel As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
End Class
