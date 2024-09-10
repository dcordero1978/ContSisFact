Public Class frmHabilitarPrecios
    Private Sub EventLog1_EntryWritten(sender As Object, e As EntryWrittenEventArgs) Handles EventLog1.EntryWritten

    End Sub

    Private Sub frmHabilitarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim HabilitarPrecios As Boolean
        HabilitarPrecios = DameCampoSQL("select [enabled] from dsc.HabilitarCambiarPrecio where id = 1", "enabled", CN)

        rbYes.Checked = HabilitarPrecios
        rbNo.Checked = Not HabilitarPrecios
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        ExecuteSQL("update dsc.HabilitarCambiarPrecio set [enabled] = " & CInt(rbYes.Checked), CN)

        MsgBox("Datos actualizados con éxito")
    End Sub
End Class