Public Class frmHabilitarPrecios
    Private Sub frmHabilitarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim habilitarPrecios As Boolean
        Dim habilitarClientes As Boolean
        Dim permitirStockNegativo As String

        habilitarPrecios = DameCampoSQL("select [enabled] from dsc.HabilitarCambiarPrecio where id = 1", "enabled", CN)
        habilitarClientes = DameCampoSQL("select [enabled_clientes] from dsc.HabilitarCambiarPrecio where id = 1", "enabled_clientes", CN)
        permitirStockNegativo = DameCampoSQL("select [Valor] from [dsc].[Parametros_Sistema] where [Parametro] = 'PERMITIR_STOCK_NEGATIVO'", "Valor", CN)

        rbYes.Checked = habilitarPrecios
        rbNo.Checked = Not habilitarPrecios

        rbClientesYes.Checked = habilitarClientes
        rbClientesNo.Checked = Not habilitarClientes

        rbStockYes.Checked = (permitirStockNegativo = "SI")
        rbStockNo.Checked = (permitirStockNegativo = "NO")

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub OK_Precios_Click(sender As Object, e As EventArgs) Handles OK_Precios.Click
        ExecuteSQL("update dsc.HabilitarCambiarPrecio set [enabled] = " & CInt(rbYes.Checked), CN)

        MsgBox("Datos actualizados con éxito")
    End Sub

    Private Sub OK_Clientes_Click_1(sender As Object, e As EventArgs) Handles OK_Clientes.Click
        ExecuteSQL("update dsc.HabilitarCambiarPrecio set [enabled_clientes] = " & CInt(rbClientesYes.Checked), CN)

        MsgBox("Datos actualizados con éxito")
    End Sub

    Private Sub OK_Stock_Click(sender As Object, e As EventArgs) Handles OK_Stock.Click
        Dim valor As String = IIf(rbStockYes.Checked, "SI", "NO")
        ExecuteSQL("update [dsc].[Parametros_Sistema] set [Valor] = '" & valor & "' where [Parametro] = 'PERMITIR_STOCK_NEGATIVO'", CN)

        MsgBox("Datos actualizados con éxito")
    End Sub
End Class