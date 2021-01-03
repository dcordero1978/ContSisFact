Imports System.Windows.Forms
Public Class MenuPrincipal
    'Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Create a new instance of the child form.
    '    Dim ChildForm As New System.Windows.Forms.Form
    '    ' Make it a child of this MDI form before showing it.
    '    ChildForm.MdiParent = Me

    '    m_ChildFormNumber += 1
    '    ChildForm.Text = "Window " & m_ChildFormNumber

    '    ChildForm.Show()
    'End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    'Private m_ChildFormNumber As Integer

    Private Sub MiBarra_ItemClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles MiBarra.ItemClick
        If e.Item.Key = "ListadoPedidos" And e.Item.Group.Key = "Facturacion" Then
            Dim MyForm As Form

            MyForm = frmPedidos
            MyForm.MdiParent = Me
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show()
        End If

        If e.Item.Key = "ListadoFacturas" And e.Item.Group.Key = "Facturacion" Then
            Dim MyForm As Form

            MyForm = frmFacturas
            MyForm.MdiParent = Me
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show()
        End If

        If e.Item.Key = "RepFactConSaldoxVend" And e.Item.Group.Key = "Facturacion" Then
            Dim MyForm As Form

            MyForm = frmFactSaldoXVendedor
            MyForm.MdiParent = Me
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show()
        End If

        If e.Item.Key = "Consignacion" And e.Item.Group.Key = "Facturacion" Then
            Dim MyForm As Form

            MyForm = frmPedidosAConsignacion

            MyForm.MdiParent = Me
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show()
        End If

        If e.Item.Key = "RepCompras" And e.Item.Group.Key = "Compras" Then
            Dim MyForm As Form

            MyForm = frmCompras
            MyForm.MdiParent = Me
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show()
        End If

        If e.Item.Key = "Server" And e.Item.Group.Key = "ReportesJulio" Then
            Dim MyForm As Form

            MyForm = frmServer
            MyForm.MdiParent = Me
            MyForm.WindowState = FormWindowState.Maximized
            MyForm.Show()
        End If

        If e.Item.Key = "Salir" And e.Item.Group.Key = "Sistema" Then
            Application.Exit()
        End If
    End Sub

    Private Sub MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.BackgroundImage = My.Resources.soluciones_empresas

        Select Case oUsuario.Perfil
            Case 2
                MiBarra.Groups("ReportesJulio").Visible = True
                MiBarra.Groups("Compras").Visible = False
            Case 1
                MiBarra.Groups("ReportesJulio").Visible = True
                MiBarra.Groups("Compras").Visible = True
            Case 3
                MiBarra.Groups("ReportesJulio").Visible = False
                MiBarra.Groups("Compras").Visible = True
            Case 4
                MiBarra.Groups("ReportesJulio").Visible = False
                MiBarra.Groups("Compras").Visible = False
        End Select

        MiBarra.Groups("Facturacion").Items("ListadoPedidos").Settings.AppearancesLarge.Appearance.Image = My.Resources.listado1
        MiBarra.Groups("Facturacion").Items("ListadoFacturas").Settings.AppearancesLarge.Appearance.Image = My.Resources.Listado3
        MiBarra.Groups("Facturacion").Items("RepFactConSaldoxVend").Settings.AppearancesLarge.Appearance.Image = My.Resources.descarga

        MiBarra.Groups("Compras").Items("RepCompras").Settings.AppearancesLarge.Appearance.Image = My.Resources.tangogestioncashflow1

        MiBarra.Groups("Sistema").Items("Salir").Settings.AppearancesLarge.Appearance.Image = My.Resources.EXIT00C

        Me.Icon = My.Resources.mini_software_erp



    End Sub

    Private Sub MenuPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmLoginForm.Close()
    End Sub
End Class