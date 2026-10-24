' Formulario de configuración de la conexión a SQL Server.
' Captura Servidor, Base de Datos, Usuario y Contraseña, permite probar la conexión
' y persiste los datos en HKCU\Software\ContSisFact\ConexionBD.
' La contraseña se guarda cifrada con DPAPI (ver CifrarPassword en Funciones_Generales).
Public Class frmConfigConexion

    ' Nombre de la clave de registro donde se guardan las credenciales.
    Private Const RutaRegistro As String = "Software\ContSisFact\ConexionBD"

    Private Sub frmConfigConexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Botones por defecto del diálogo.
        Me.AcceptButton = cmdGuardar
        Me.CancelButton = cmdCancelar

        ' Precargar los valores actuales del registro si existen.
        ' SERVER/USER/BASEDATOS se muestran en claro; la contraseña se deja en blanco por seguridad.
        Try
            Dim R_ConexionBD As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RutaRegistro, False)
            If R_ConexionBD IsNot Nothing Then
                txtServidor.Text = CStr(If(R_ConexionBD.GetValue("SERVER", ""), ""))
                txtBaseDatos.Text = CStr(If(R_ConexionBD.GetValue("BASEDATOS", ""), ""))
                txtUsuario.Text = CStr(If(R_ConexionBD.GetValue("USER", ""), ""))
                R_ConexionBD.Close()
            End If
        Catch ex As Exception
            MensageError(ex)
        End Try
    End Sub

    ' Arma el connection string a partir de los valores capturados en el formulario.
    Private Function ArmarConexion() As String
        Return "Data Source=" & txtServidor.Text.Trim() &
               ";Initial Catalog=" & txtBaseDatos.Text.Trim() &
               ";Persist Security Info=True;User ID=" & txtUsuario.Text.Trim() &
               ";Password=" & txtContrasena.Text & ";Connection Timeout=0"
    End Function

    ' Valida que todos los campos estén completos.
    Private Function ValidarCampos() As Boolean
        If txtServidor.Text.Trim().Length = 0 Then
            MsgBox("Debe indicar el servidor.", MsgBoxStyle.Exclamation, "ContSisFact")
            txtServidor.Focus()
            Return False
        End If
        If txtBaseDatos.Text.Trim().Length = 0 Then
            MsgBox("Debe indicar la base de datos.", MsgBoxStyle.Exclamation, "ContSisFact")
            txtBaseDatos.Focus()
            Return False
        End If
        If txtUsuario.Text.Trim().Length = 0 Then
            MsgBox("Debe indicar el usuario.", MsgBoxStyle.Exclamation, "ContSisFact")
            txtUsuario.Focus()
            Return False
        End If
        If txtContrasena.Text.Length = 0 Then
            MsgBox("Debe indicar la contraseña.", MsgBoxStyle.Exclamation, "ContSisFact")
            txtContrasena.Focus()
            Return False
        End If
        Return True
    End Function

    ' Intenta abrir una conexión con los datos capturados y reporta el resultado.
    Private Sub cmdProbar_Click(sender As Object, e As EventArgs) Handles cmdProbar.Click
        If Not ValidarCampos() Then Return
        Try
            Using cn As New Data.SqlClient.SqlConnection(ArmarConexion())
                cn.Open()
            End Using
            MsgBox("Conexión exitosa.", MsgBoxStyle.Information, "ContSisFact")
        Catch ex As Exception
            MsgBox("No se pudo conectar: " & ex.Message, MsgBoxStyle.Critical, "ContSisFact")
        End Try
    End Sub

    ' Valida y persiste las credenciales en el registro (PWD cifrado) y cierra con OK.
    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If Not ValidarCampos() Then Return
        Try
            Dim R_ConexionBD As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RutaRegistro)
            R_ConexionBD.SetValue("SERVER", txtServidor.Text.Trim())
            R_ConexionBD.SetValue("BASEDATOS", txtBaseDatos.Text.Trim())
            R_ConexionBD.SetValue("USER", txtUsuario.Text.Trim())
            R_ConexionBD.SetValue("PWD", CifrarPassword(txtContrasena.Text))
            R_ConexionBD.Close()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MensageError(ex)
        End Try
    End Sub

    ' Cierra sin guardar nada.
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
