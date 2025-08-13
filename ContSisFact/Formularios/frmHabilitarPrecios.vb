Public Class frmHabilitarPrecios
    Private Sub frmHabilitarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim habilitarPrecios As Boolean
        Dim habilitarClientes As Boolean

        habilitarPrecios = DameCampoSQL("select [enabled] from dsc.HabilitarCambiarPrecio where id = 1", "enabled", CN)
        habilitarClientes = DameCampoSQL("select [enabled_clientes] from dsc.HabilitarCambiarPrecio where id = 1", "enabled_clientes", CN)

        rbYes.Checked = habilitarPrecios
        rbNo.Checked = Not habilitarPrecios

        rbClientesYes.Checked = habilitarClientes
        rbClientesNo.Checked = Not habilitarClientes

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
End Class