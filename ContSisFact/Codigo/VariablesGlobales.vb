Public Module VariablesGlobales
    Public Const TituloMensages = "SGC :: Sistema Auxiliar de Bonos"
    Public Const MensageSalir = "Sr. Usuario: Al hacer click en 'Si' se perderan todos los datos que no haya guardado. Desea Salir?"

    Public oUsuario As Usuario
    Public USUARIO_AUTORIZA As String
    Public NombreUsuario As String
    Public bSuperAdmin As Integer
    Public FondoEnfoque As Color
    Public FondoActual As Color

    Public TabAutomatico As Boolean
    Public OLDValueText As String
    Public OLDValueItem As Integer
    Public UltimoItem As Integer

    Public Enum tTipoOper
        Agregar = 1
        Modificar = 2
    End Enum

    Public Structure PropLista
        Dim Tamano As Integer
        Dim Formato As String
        Dim Alineacion As System.Windows.Forms.HorizontalAlignment
        Dim Titulo As String
    End Structure
End Module
