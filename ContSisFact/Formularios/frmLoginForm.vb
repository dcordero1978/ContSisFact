Imports System.Data
Public Class frmLoginForm

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ds As DataSet

        ds = DameDataSet("select * from seguridad.Usuarios where usuario = '" & txtUser.Text & "' and password = HASHBYTES('MD5', '" & txtPassword.Text & "')", CN)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Sr. Usuario: El usuario o contraseña no son correctos. Por favor vuelva a intentarlo o consulte al administrador del sistema.", MsgBoxStyle.OkOnly, TituloMensages)
        Else
            oUsuario = New Usuario()
            oUsuario.Id = ds.Tables(0).Rows(0).Item("id").ToString()
            oUsuario.Usuario = ds.Tables(0).Rows(0).Item("usuario").ToString()
            oUsuario.Nombre = ds.Tables(0).Rows(0).Item("nombre").ToString()
            oUsuario.Perfil = ds.Tables(0).Rows(0).Item("id_perfil").ToString()
            MenuPrincipal.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        Enfoque(sender)
    End Sub

    Private Sub txtUser_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUser.KeyUp
        MoverFoco(Me.Grupo, sender, e)
    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        DesEnfoque(sender)
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        Enfoque(sender)
    End Sub

    Private Sub txtPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyUp
        MoverFoco(Me.Grupo, sender, e)
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        DesEnfoque(sender)
    End Sub
End Class
