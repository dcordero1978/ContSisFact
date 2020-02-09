Public Class frmDesbloquear
    Public HabilitaTabEnter As Boolean
    Public Correcto As Boolean
    Public Perfil As Integer

    Private Sub frmDesbloquear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Titulo As String
        HabilitaTabEnter = True
        Titulo = NZ(DameCampoSQL("select dsperfil from CAT_PerfilesUsuario WHERE cdperfil = " & Perfil, "dsperfil", CN), "")
        Me.Text = Titulo & " - Sistema de Gestion de Compras"
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        If HabilitaTabEnter Then
            Correcto = False
            Me.Visible = False
        Else
            HabilitaTabEnter = True
        End If
    End Sub

    Private Sub cmdEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEntrar.Click
        Dim idusuario As Integer
        If Vacio(txtUsuario.Text) Then
            MsgBox("Sr.Usuario: debe de escribir un nombre de usuario valido", vbCritical, TituloMensages)
            HabilitaTabEnter = False
            txtUsuario.Focus()
            Exit Sub
        End If
        If Vacio(txtPassword.Text) Then
            MsgBox("Sr.Usuario: la contraseña no puede estar en blanco", vbCritical, TituloMensages)
            HabilitaTabEnter = False
            txtPassword.Focus()
            Exit Sub
        End If
        idusuario = NZ(DameCampoSQL("select idusuario from SEG_Usuarios where login = '" & NZ(txtUsuario.Text, "") & "' and activo = 1", "idusuario", CN), 0)
        If idusuario = 0 Then
            MsgBox("Sr.Usuario: debe de escribir un nombre de usuario valido", vbCritical, TituloMensages)
            HabilitaTabEnter = False
            txtUsuario.Focus()
            Exit Sub
        End If
        Select Case CargaUsuario(NZ(txtUsuario.Text, ""), NZ(txtPassword.Text, ""))
            Case 0
                If CInt(DameCampoSQL("select count(*) as total from SEG_Perfil_Autorizados where idusuario = " & idusuario & " and cdperfil = " & Perfil, "total", CN)) = 1 Then
                    USUARIO_AUTORIZA = txtUsuario.Text
                    Correcto = True
                    Me.Visible = False
                Else
                    MsgBox("No tiene permiso para realizar esta tarea")
                    HabilitaTabEnter = False
                    Correcto = False
                End If
            Case 1
                MsgBox("La contraseña es incorrecta. Vuelva a intentar")
                HabilitaTabEnter = False
                txtPassword.Focus()
            Case 2
                MsgBox("El usuario no existe en el sistema. Por favor verifique o contacte al administrador del sistema")
                HabilitaTabEnter = False
                txtUsuario.Focus()
        End Select
    End Sub
End Class