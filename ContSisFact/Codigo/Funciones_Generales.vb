Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel.XlRangeAutoFormat

Module Funciones_Generales
    Public strConexion As String
    Public CN As New Data.SqlClient.SqlConnection
    Public strServerSQL As String
    Public strBaseDatosSQL As String
    Public strUserSQL As String
    Public strPasswordSQL As String
    Public strTrustedConnectionSQL As String

    Public Function CargarConexionSQL() As Boolean
        Dim NombrePrograma As String
        NombrePrograma = "ContSisFact"
        Try
            Dim RegistroContSis As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\" & NombrePrograma, True)
            Dim R_ConexionBD As Microsoft.Win32.RegistryKey
            If RegistroContSis Is Nothing Then
                RegistroContSis = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", True).CreateSubKey(NombrePrograma)
                R_ConexionBD = RegistroContSis.CreateSubKey("ConexionBD")
                R_ConexionBD.SetValue("SERVER", "(local)") 'R_ConexionBD.SetValue("SERVER", "192.168.1.12")
                R_ConexionBD.SetValue("USER", "sa") 'R_ConexionBD.SetValue("USER", "ecsesa")
                R_ConexionBD.SetValue("PWD", "sa123+") 'R_ConexionBD.SetValue("PWD", "prueba123")
                R_ConexionBD.SetValue("BASEDATOS", "ECSESA") 'R_ConexionBD.SetValue("BASEDATOS", "Ecsesa")
            Else
                R_ConexionBD = RegistroContSis.OpenSubKey("ConexionBD", True)
                If R_ConexionBD Is Nothing Then
                    R_ConexionBD = RegistroContSis.CreateSubKey("ConexionBD")
                    R_ConexionBD.SetValue("SERVER", "(local)") 'R_ConexionBD.SetValue("SERVER", "192.168.1.12")
                    R_ConexionBD.SetValue("USER", "sa") 'R_ConexionBD.SetValue("USER", "ecsesa")
                    R_ConexionBD.SetValue("PWD", "sa123+") 'R_ConexionBD.SetValue("PWD", "prueba123")
                    R_ConexionBD.SetValue("BASEDATOS", "ECSESA") 'R_ConexionBD.SetValue("BASEDATOS", "Ecsesa")
                End If
            End If

            strServerSQL = R_ConexionBD.GetValue("SERVER", "(local)")
            strUserSQL = R_ConexionBD.GetValue("USER", "sa")
            strPasswordSQL = R_ConexionBD.GetValue("PWD", "sa123+")
            strBaseDatosSQL = R_ConexionBD.GetValue("BASEDATOS", "ECSESA")
            strConexion = "Data Source=" + strServerSQL + ";Initial Catalog=" + strBaseDatosSQL + ";Persist Security Info=True;User ID=" + strUserSQL + ";Password=" & strPasswordSQL & ";Connection Timeout=0"
            CN.ConnectionString = strConexion
            'CN.ConnectionString = "Dsn=Abacus;sourcedb=\\192.168.1.108\tpm\Aalfs\Abacus\dbfs\;sourcetype=DBF;exclusive=No;backgroundfetch=Yes;collate=Machine" 'strConexion
            CN.Open()

            CargarConexionSQL = True
            FondoEnfoque = Color.Aquamarine
        Catch ex As Exception
            CargarConexionSQL = False
            MensageError(ex)
        End Try
    End Function

    Public Sub LLenar_List_View(ByVal SQL As String, ByVal Lista As ListView, ByVal sqlConn As SqlClient.SqlConnection, ByVal Formato() As PropLista, Optional ByVal LimpiarColumnas As Boolean = True, Optional ByVal LimpiarDatos As Boolean = True, Optional ByVal TieneFormato As Boolean = False)
        Dim ds As DataSet
        Dim SqlDA As New SqlClient.SqlDataAdapter
        Dim cmd As New SqlClient.SqlCommand(SQL, sqlConn)
        Dim rst As DataRow
        Dim Col As DataColumn
        Dim Item As ListViewItem

        If Not cmd.Connection.State = ConnectionState.Open Then
            cmd.Connection.Open()
        End If
        Try
            SqlDA.SelectCommand = cmd
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 0
            ds = New DataSet
            SqlDA.Fill(ds)

            If LimpiarDatos Then
                Lista.Items.Clear()
            End If

            If LimpiarColumnas Then
                Lista.Columns.Clear()
                For Each Col In ds.Tables(0).Columns
                    If TieneFormato Then
                        Lista.Columns.Add(Formato(Col.Ordinal).Titulo, Formato(Col.Ordinal).Tamano, Formato(Col.Ordinal).Alineacion)
                    Else
                        Lista.Columns.Add(Col.ColumnName, 100, HorizontalAlignment.Left)
                    End If
                Next Col
            End If

            For Each rst In ds.Tables(0).Rows
                Item = New ListViewItem
                For Each Col In ds.Tables(0).Columns
                    If Col.Ordinal = 0 Then
                        If TieneFormato Then
                            If Vacio(IIf(IsDBNull(rst(Col.ColumnName)), "", rst(Col.ColumnName))) Then
                                Item.Text = ""
                            Else
                                Item.Text = Microsoft.VisualBasic.Format(IIf(IsDBNull(rst(Col.ColumnName)), "", rst(Col.ColumnName)), Formato(Col.Ordinal).Formato)
                            End If
                        Else
                            Item.Text = IIf(IsDBNull(rst(Col.ColumnName)), "", rst(Col.ColumnName))
                        End If
                    Else
                        If TieneFormato Then
                            If Vacio(IIf(IsDBNull(rst(Col.ColumnName)), "", rst(Col.ColumnName))) Then
                                Item.SubItems.Add("")
                            Else
                                Item.SubItems.Add(Microsoft.VisualBasic.Format(IIf(IsDBNull(rst(Col.ColumnName)), "", rst(Col.ColumnName)), Formato(Col.Ordinal).Formato))
                            End If

                        Else
                            Item.SubItems.Add(IIf(IsDBNull(rst(Col.ColumnName)), "", rst(Col.ColumnName)))
                        End If
                    End If
                Next Col
                Lista.Items.Add(Item)
            Next rst
        Catch ex As Exception
            MensageError(ex)
        Finally
        End Try
    End Sub

    Public Function DameValorLista(ByVal Lista As ListView, ByVal Fila As Integer, ByVal Columna As Integer) As String
        DameValorLista = ""
        Try
            If Fila >= 0 And Columna >= 0 Then
                If Columna = 0 Then
                    DameValorLista = Lista.Items(Fila).Text 'Lista.ListItems(Fila).Text
                Else
                    DameValorLista = Lista.Items(Fila).SubItems(Columna).Text   'Lista.ListItems(Fila).SubItems(Columna)
                End If
            End If
            Exit Function
        Catch ex As Exception
            MensageError(ex)
        End Try
    End Function


    'Public Sub Llenar_UltraGrid(ByVal MyGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal SQL As String, ByVal MyCon As SqlClient.SqlConnection)
    '    Dim ds As DataSet
    '    'Dim dt As New DataTable
    '    Try
    '        ds = DameDataSet(SQL, MyCon)
    '        If Not ds.HasErrors Then
    '            MyGrid.DataSource = ds
    '            'MyGrid.DataMember = "Grid"
    '            'dt = ds.Tables("Grid")

    '        Else
    '            MyGrid.DataSource = Nothing
    '            MyGrid.DataMember = ""
    '        End If
    '        MyGrid.DisplayLayout.Bands(0).AddButtonCaption = "  "
    '    Catch ex As Exception
    '        MensageError(ex)
    '    End Try
    'End Sub

    'Public Sub AutoAjustarColumnas(ByVal MyGrid As Infragistics.Win.UltraWinGrid.UltraGrid)
    '    Dim i As Integer

    '    For i = 0 To MyGrid.DisplayLayout.Bands(0).Columns.Count - 1 Step 1
    '        MyGrid.DisplayLayout.Bands(0).Columns(i).AutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
    '        MyGrid.DisplayLayout.Bands(0).Columns(i).Width = MyGrid.DisplayLayout.Bands(0).Columns(i).CalculateAutoResizeWidth(Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, True)
    '    Next
    'End Sub
    Public Sub LlenarCombo(ByVal cCombo As Object, ByVal Campo As String, ByVal Codigo As String, ByVal SQL As String, ByVal MyCon As SqlClient.SqlConnection, Optional ByVal LimpiarCombo As Boolean = True) 'Infragistics.Win.UltraWinEditors.UltraComboEditor
        Dim i As Integer = 0
        Dim ds As New DataSet
        Dim Elemento As String = cCombo.Text
        Dim rst As DataRow



        Try
            ds = DameDataSet(SQL, CN)
            If LimpiarCombo Then
                cCombo.Items.Clear()
            End If

            For Each rst In ds.Tables(0).Rows

                cCombo.Items.Add(New Cls_Lista(NZ(rst(Campo), ""), NZ(rst(Codigo), 0)))
                'cCombo.Items.Add(NZ(rst(Codigo), 0), NZ(rst(Campo), ""))
            Next
        Catch ex As Exception
            MensageError(ex)
            MsgBox(ex.TargetSite.Module.Name)
        End Try
    End Sub

    'Public Sub LlenarUltraCombo(ByVal cCombo As Infragistics.Win.UltraWinGrid.UltraCombo, ByVal Campo As String, ByVal Codigo As String, ByVal SQL As String, ByVal MyCon As SqlClient.SqlConnection) 'Infragistics.Win.UltraWinEditors.UltraComboEditor
    '    Dim i As Integer = 0
    '    Dim ds As New DataSet
    '    Try
    '        ds = DameDataSet(SQL, CN)
    '        cCombo.SetDataBinding(ds, "")
    '        cCombo.ValueMember = Codigo
    '        cCombo.DisplayMember = Campo
    '    Catch ex As Exception
    '        MensageError(ex)
    '        MsgBox(ex.TargetSite.Module.Name)
    '    End Try
    'End Sub


    'Public Sub LlenarCombo_UltraGrid(ByVal MyGrid As Infragistics.Win.UltraWinGrid.UltraGrid, ByVal Col As Integer, ByVal Campo As String, ByVal Codigo As String, ByVal SQL As String, ByVal MyCon As SqlClient.SqlConnection)
    '    Dim i As Integer = 0
    '    Dim ds As New DataSet
    '    Dim rst As DataRow

    '    Dim Val As New Infragistics.Win.ValueList
    '    Try

    '        ds = DameDataSet(SQL, CN)

    '        For Each rst In ds.Tables(0).Rows
    '            Val.ValueListItems.Add(NZ(rst(Codigo), 0), NZ(rst(Campo), ""))
    '        Next

    '        MyGrid.DisplayLayout.Bands(0).Columns(Col).ValueList = Val
    '    Catch ex As Exception
    '        MensageError(ex)
    '    End Try
    'End Sub

    Public Function NZ(ByVal Valor As Object, ByVal ValorDef As Object)
        Try
            If IsDBNull(Valor) Then
                NZ = ValorDef
                Exit Function
            End If
            If Valor.ToString.Trim() = "" Then
                NZ = ValorDef
                Exit Function
            End If

        Catch ex As Exception
            MensageError(ex)
        End Try
        NZ = Valor
    End Function

    Public Function DameDataSet(ByVal strSQL As String, ByVal MyCon As SqlClient.SqlConnection) As DataSet

        Dim strTableName As String = "MiTabla"

        Dim adapter As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(strSQL, MyCon)
        Dim Busqueda As DataSet = New DataSet

        Try
            adapter.SelectCommand.CommandTimeout = 0
            adapter.Fill(Busqueda, strTableName)
        Catch ex As Exception
            MensageError(ex)
            'MessageBox.Show("Error encontrado: " + ex.InnerException.ToString + " " + ex.Message.ToString)
        End Try
        DameDataSet = Busqueda


    End Function

    Public Function DameCampoSQL(ByVal SQL As String, ByVal Campo As String, ByVal Con As System.Data.SqlClient.SqlConnection) As Object
        Dim ds As New System.Data.DataSet
        Try
            ds = DameDataSet(SQL, Con)
            If ds.Tables.Count = 0 Then
                DameCampoSQL = Nothing
                Exit Function
            End If

            If ds.Tables(0).Rows.Count > 0 Then
                DameCampoSQL = NZ(ds.Tables(0).Rows(0).Item(Campo), "")
            Else
                DameCampoSQL = ""
            End If
            ds = Nothing
            Exit Function
        Catch ex As Exception
            MensageError(ex)
        End Try
        ds = Nothing
        DameCampoSQL = ""
    End Function

    Public Function ExecuteSQL(ByVal SQL As String, ByVal MyCon As System.Data.SqlClient.SqlConnection, Optional ByVal MiTrans As SqlClient.SqlTransaction = Nothing, Optional ByVal MostrarError As Boolean = True) As Integer
        Dim MyCommand As New SqlClient.SqlCommand
        ExecuteSQL = 0
        Try
            MyCommand.CommandText = SQL
            MyCommand.Connection = MyCon
            If Not MiTrans Is Nothing Then
                MyCommand.Transaction = MiTrans
            End If
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            ExecuteSQL = 1
            If MostrarError Then
                MensageError(ex, SQL)
            End If
        End Try
    End Function

    Public Function CargaUsuario(ByVal USUARIO As String, ByVal Pass As String) As Integer
        CargaUsuario = 0
        Try
            CargaUsuario = False
            If CInt(NZ(DameCampoSQL("select count(*) as total from SEG_Usuarios where login = '" & USUARIO & "' and activo = 1", "total", CN), 0)) > 0 Then
                If InStr(1, NZ(DameCampoSQL("select login  from SEG_Usuarios where login = '" & USUARIO & "' and activo = 1", "login", CN), ""), USUARIO, CompareMethod.Binary) > 0 Then
                    If InStr(1, NZ(DameCampoSQL("select cast(password as nvarchar) as password from SEG_Usuarios where login = '" & USUARIO & "' and activo = 1", "password", CN), ""), Pass, CompareMethod.Binary) > 0 Then
                        CargaUsuario = 0
                    Else
                        CargaUsuario = 1
                    End If
                Else
                    CargaUsuario = 2
                End If
            Else
                CargaUsuario = 2
            End If
            Exit Function
        Catch ex As Exception
            MensageError(ex)
        End Try
    End Function

    Public Sub MensageError(ByVal MiError As Exception)
        MsgBox("Descripcion del Error: " & MiError.Message & vbCr & MiError.StackTrace, MsgBoxStyle.Critical, "Error en la Aplicacion SGC")
    End Sub

    Public Sub MensageError(ByVal MiError As Exception, ByVal SQL As String)
        MsgBox("Descripcion del Error: " & MiError.Message & vbCr & MiError.StackTrace, MsgBoxStyle.Critical, "Error en la Aplicacion SGC")
        MsgBox(SQL)
    End Sub

    Public Sub MoverFoco(ByVal Contenedor As Object, ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Verifica la tecla presionada y obtiene el control siguiente o el anterior, segun la tecla
        'If sender.TextLength() = sender.SelectionLength() And sender.SelectionStart() = 0 Then
        If Not TabAutomatico Then
            TabAutomatico = True
            Exit Sub
        End If
        If sender.GetType.Name = "TextBox" Then
            If sender.multiline = True Then
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.Left Then
            DameNextControlTab(Contenedor, sender, False).Focus()
        ElseIf e.KeyCode = Keys.Right Then
            DameNextControlTab(Contenedor, sender, True).Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            DameNextControlTab(Contenedor, sender, True).Focus()
        End If
        'End If
        TabAutomatico = True
    End Sub

    Public Function DameNextControlTab(ByVal Contenedor As Object, ByVal MyCtl As System.Windows.Forms.Control, Optional ByVal Forward As Boolean = True) As System.Windows.Forms.Control
        Dim ctl As System.Windows.Forms.Control
        Dim ctl2 As New System.Windows.Forms.Control


        'MyForm = Contenedor


        ctl2 = Nothing
        If Forward Then
            For Each ctl In Contenedor.Controls
                If ctl.CanSelect And ctl.CanFocus And ctl.TabStop And ctl.Visible And ctl.Enabled And ctl.TabIndex > MyCtl.TabIndex Then
                    If ctl2 Is Nothing Then
                        ctl2 = ctl
                    ElseIf ctl.TabIndex < ctl2.TabIndex Then
                        ctl2 = ctl
                    End If

                End If
            Next

            If ctl2 Is Nothing Then
                For Each ctl In Contenedor.Controls
                    If ctl.CanSelect And ctl.CanFocus And ctl.TabStop And ctl.Visible And ctl.Enabled And ctl.TabIndex < MyCtl.TabIndex Then
                        If ctl2 Is Nothing Then
                            ctl2 = ctl
                        ElseIf ctl.TabIndex < ctl2.TabIndex Then
                            ctl2 = ctl
                        End If

                    End If
                Next
            End If
        Else
            For Each ctl In Contenedor.Controls
                If ctl.CanSelect And ctl.CanFocus And ctl.TabStop And ctl.Visible And ctl.Enabled And ctl.TabIndex < MyCtl.TabIndex Then
                    If ctl2 Is Nothing Then
                        ctl2 = ctl
                    ElseIf ctl.TabIndex > ctl2.TabIndex Then
                        ctl2 = ctl
                    End If

                End If
            Next

            If ctl2 Is Nothing Then
                For Each ctl In Contenedor.Controls
                    If ctl.CanSelect And ctl.CanFocus And ctl.TabStop And ctl.Visible And ctl.Enabled And ctl.TabIndex > MyCtl.TabIndex Then
                        If ctl2 Is Nothing Then
                            ctl2 = ctl
                        ElseIf ctl.TabIndex > ctl2.TabIndex Then
                            ctl2 = ctl
                        End If

                    End If
                Next
            End If
        End If
        If ctl2 Is Nothing Then ctl2 = MyCtl
        DameNextControlTab = ctl2

    End Function


    Public Function Vacio(ByVal Obj As Object) As Boolean
        If Obj Is Nothing Then
            Vacio = True
            Exit Function
        End If

        If Obj.GetType.Name = "TextBox" Then
            If Trim(Obj.text) = "" Then
                Vacio = True
                Exit Function
            End If
        End If

        If Obj.GetType.Name = "String" Then
            If Trim(Obj) = "" Then
                Vacio = True
                Exit Function
            End If
        End If
        Vacio = False
    End Function

    Public Function ValidaParaNULL(ByVal Valor As String, ByVal Tipo As Integer) As String
        If Valor.Trim.Length = 0 Then
            ValidaParaNULL = "NULL"
            Exit Function
        End If
        If Tipo = 1 Then
            ValidaParaNULL = "'" & Valor & "'"
            Exit Function
        End If
        If Tipo = 2 Then
            ValidaParaNULL = Valor
            Exit Function
        End If
        ValidaParaNULL = ""
    End Function

    Public Sub Enfoque(ByVal MyControl As Object)
        Select Case MyControl.GetType.Name
            Case "TextBox"
                Dim a As TextBox
                a = MyControl
                FondoActual = a.BackColor
                a.BackColor = FondoEnfoque
                a.SelectAll()
            Case "ComboBox"
                Dim a As ComboBox
                a = MyControl
                FondoActual = a.BackColor
                a.BackColor = FondoEnfoque
                a.SelectAll()
                'Case "UltraComboEditor"
                '    Dim a As Infragistics.Win.UltraWinEditors.UltraComboEditor
                '    a = MyControl
                '    FondoActual = a.BackColor
                '    a.BackColor = FondoEnfoque
                '    a.SelectAll()
                'Case "UltraDateTimeEditor"
                '    Dim a As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
                '    a = MyControl
                '    FondoActual = a.BackColor
                '    a.BackColor = FondoEnfoque
                '    a.SelectAll()
        End Select
    End Sub

    Public Sub DesEnfoque(ByVal MyControl As Object)
        Select Case MyControl.GetType.Name
            Case "TextBox"
                Dim a As TextBox
                a = MyControl
                a.BackColor = FondoActual
            Case "ComboBox"
                Dim a As ComboBox
                a = MyControl
                a.BackColor = FondoActual
                'Case "UltraComboEditor"
                '    Dim a As Infragistics.Win.UltraWinEditors.UltraComboEditor
                '    a = MyControl
                '    a.BackColor = FondoActual
                'Case "UltraDateTimeEditor"
                '    Dim a As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
                '    a = MyControl
                '    a.BackColor = FondoActual
        End Select
    End Sub

    Public Sub SeleccionarEnCombo(ByVal Combo As Object, ByVal Codigo As Integer) 'ComboBox
        Dim i As Integer
        Dim MyItem As Cls_Lista
        Try

            Combo.SelectedIndex = -1
            For i = 0 To Combo.Items.Count - 1 Step 1
                MyItem = CType(Combo.Items(i), Cls_Lista)
                If Codigo = MyItem.ItemData Then ' Combo.ItemData(i) Then
                    Combo.Text = MyItem.Name  'Combo.List(i)

                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MensageError(ex)
        End Try
    End Sub

    Public Function DameCodigoCombo(ByVal MiCombo As Object) As Integer
        Dim MyItem As Cls_Lista
        DameCodigoCombo = 0
        Try

            If MiCombo.SelectedIndex > -1 Then
                MyItem = CType(MiCombo.Items(MiCombo.SelectedIndex), Cls_Lista)
                DameCodigoCombo = MyItem.ItemData '   MiCombo.ItemData(MiCombo.ListIndex)
            End If
            Exit Function
        Catch ex As Exception
            MensageError(ex)
        End Try

    End Function

    Public Function ValidarTexto(ByVal Cad As String, ByVal CarValidos As String) As Boolean
        Dim i As Integer
        ValidarTexto = False
        Try


            'CarValidos = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ 1234567890-"
            For i = 1 To Len(Cad) Step 1
                If InStr(1, CarValidos, Mid(Cad, i, 1), vbTextCompare) = 0 Then
                    Exit Function
                End If
            Next
            ValidarTexto = True
            Exit Function
        Catch ex As Exception
            MensageError(ex)
        End Try

    End Function

    Public Function PrimeraMayuscula(ByVal Cadena As String) As String
        Dim CR$
        Dim t$
        Dim i As Integer
        PrimeraMayuscula = ""
        Try
            CR$ = Chr(13) + Chr(10)
            t$ = Cadena  'the string
            If t$ <> "" Then
                Mid$(t$, 1, 1) = UCase$(Mid$(t$, 1, 1))
                For i = 1 To Len(t$) - 1
                    If Mid$(t$, i, 2) = CR$ Then
                        Mid$(t$, i + 2, 1) = UCase$(Mid$(t$, i + 2, 1))
                    Else
                        If i + 2 < Len(t$) Then
                            Mid$(t$, i + 2, 1) = LCase$(Mid$(t$, i + 2, 1))
                        End If
                    End If
                    If Mid$(t$, i, 1) = " " Then
                        Mid$(t$, i + 1, 1) = UCase$(Mid$(t$, i + 1, 1))
                    Else
                        Mid$(t$, i + 1, 1) = LCase$(Mid$(t$, i + 1, 1))
                    End If
                Next
                Cadena = t$
            End If
            PrimeraMayuscula = Cadena
            Exit Function
        Catch ex As Exception
            MensageError(ex)
        End Try

    End Function

    Public Function ValidaBoton(ByVal Tag As String) As Integer
        Dim idusuario As Integer
        ValidaBoton = 0
        Try
            If Not Vacio(Tag) Then
                idusuario = NZ(DameCampoSQL("select idusuario from SEG_Usuarios where login = '" & oUsuario.Usuario & "' and activo = 1", "idusuario", CN), 0)
                ValidaBoton = CargarPerfil(idusuario, CInt(Tag))
            Else
                ValidaBoton = 1
            End If
            Exit Function
        Catch ex As Exception
            MensageError(ex)
        End Try
    End Function
    Public Function CargarPerfil(ByVal USUARIO As Integer, ByVal Perfil As Integer) As Integer
        Dim RAutentificacion As Integer
        CargarPerfil = 0
        Try
            RAutentificacion = CInt(NZ(DameCampoSQL("select rautentificacion from SEG_Usuario_Perfil where idusuario = " & USUARIO & " and cdperfil = " & Perfil, "rautentificacion", CN), -1))
            Select Case RAutentificacion
                Case -1
                    CargarPerfil = 0
                Case 0
                    CargarPerfil = 1
                    USUARIO_AUTORIZA = VariablesGlobales.oUsuario.Usuario
                Case 1
                    frmDesbloquear.Perfil = Perfil
                    frmDesbloquear.ShowDialog()
                    CargarPerfil = IIf(frmDesbloquear.Correcto = False, 0, 1)
                    frmDesbloquear.Close()
            End Select
            Exit Function
        Catch ex As Exception
            MensageError(ex)
        End Try
    End Function

    Public Function Exportar_Excel(ByVal sFileName As String, ByVal ListView As ListView, Optional ByVal Progressbar As ProgressBar = Nothing, Optional ByVal SheetIndex As Integer = 1) As Boolean

        On Error GoTo error_Handler

        'Dim obj_Excel As Object               ' -- CREAR EL OBJETO (INSTANCIAR)CON EL OBJETO APLICACION (obj_Excel)  
        Dim obj_Libro As Microsoft.Office.Interop.Excel.Worksheet    'Object


        Dim iCol As Integer              ' -- Variables para las columnas y filas  
        Dim iRow As Integer



        ' --  Nueva referencia a Excel y nuevo referencia al Libro  
        'obj_Excel = CreateObject("Excel.Application")
        Dim obj_Excel As New Microsoft.Office.Interop.Excel.Application
        obj_Excel.Workbooks.Open(sFileName)

        obj_Libro = obj_Excel.Workbooks(1).Sheets(1)

        With obj_Excel
            ' -- Abrir el libro  

            obj_Libro = .Workbooks.Open(sFileName).Sheets(1)
        End With



        With obj_Libro

            ' -- Asignamos El valor Maximo del Progress teniendo  
            ' -- como dato la cantidad de items en el ListView  
            If Not Progressbar Is Nothing Then
                Progressbar.Maximum = ListView.Items.Count
                If Not Progressbar.Visible Then Progressbar.Visible = True
            End If

            ' -- Referencia a la hoja con índice 1  

            'With .Item(SheetIndex)
            ' -- Recorremos la cantidad de items del ListView  
            For i = 0 To ListView.Columns.Count - 1
                .Cells.Item(1, i + 1).value() = ListView.Columns(i).Text
            Next
            For iRow = 0 To ListView.Items.Count - 1
                iCol = 0
                ' -- Asignamos el item actual en la celda  

                '.Cells(iRow, iCol) = ListView.Items.Item(iRow).SubItems(iCol - 1).Text

                ' -- Asignamos el subitem actual en la celda    

                For iCol = 0 To ListView.Columns.Count - 1
                    .Cells.Item(iRow + 2, iCol + 1).value = ListView.Items(iRow).SubItems(iCol).Text
                Next

                If Not Progressbar Is Nothing Then
                    ' -- Aumentamos en 1 la propiedad value  
                    Progressbar.Value = Progressbar.Value + 1
                End If
            Next
            'End With

        End With

        ' -- Destruimos las variables de objeto  
        obj_Excel.Visible = True
        obj_Libro = Nothing
        obj_Excel = Nothing
        ' -- Ok  
        Exportar_Excel = True

        If Not Progressbar Is Nothing Then
            Progressbar.Value = 0
            Progressbar.Visible = False
        End If


        ' -- Errores  
        Exit Function
error_Handler:
        Resume
        Exportar_Excel = False
        MsgBox(Err.Description, vbCritical)

        On Error Resume Next
        obj_Libro = Nothing
        obj_Excel = Nothing
        If Not Progressbar Is Nothing Then
            Progressbar.Value = 0
        End If
    End Function

    Public Function Exportar_Excel2(ByVal Lista As ListView, Optional ByVal Barra As ProgressBar = Nothing) As Integer
        Dim m_Excel As Excel.Application

        Exportar_Excel2 = 0

        '' Creamos un objeto WorkBook
        If Not Barra Is Nothing Then
            Barra.Visible = True
        End If

        Dim objLibroExcel As Excel.Workbook



        '' Creamos un objeto WorkSheet

        Dim objHojaExcel As Excel.Worksheet



        '' Iniciamos una conexión a la base de datos NorthWind y seleccionamos

        '' varios registros desde las tablas Products,Categories

        'Dim objSQLConnect As New System.Data.OleDb.OleDbConnection("Data Source=Northwind.mdb;Password=;Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin")

        'Dim objSQLAdapter As New OleDb.OleDbDataAdapter("select CategoryName,ProductID,ProductName,UnitPrice from Products,Categories Where Products.CategoryID = Categories.CategoryID order by Categories.CategoryID", objSQLConnect)

        'Dim objDataSet As New DataSet("ExcelTest")



        'objSQLAdapter.Fill(objDataSet, "Categories")



        '' Iniciamos una instancia a Excel

        m_Excel = New Excel.Application

        m_Excel.Visible = False



        '' Creamos una variable para guardar la cultura actual

        Dim OldCultureInfo As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture



        'Crear una cultura standard (en-US) inglés estados unidos

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-NI")



        '' Creamos una instancia del Workbooks de Excel

        '' Creamos una instancia de la primera hoja de trabajo de Excel

        objLibroExcel = m_Excel.Workbooks.Add()

        objHojaExcel = objLibroExcel.Worksheets(1)

        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible



        '' Hacemos esta hoja la visible en pantalla

        '' (como seleccionamos la primera esto no es necesario

        '' si seleccionamos una diferente a la primera si lo

        '' necesitaríamos).

        objHojaExcel.Activate()



        '' Crear el encabezado de nuestro informe

        'objHojaExcel.Range("A1:D1").Merge()

        'objHojaExcel.Range("A1:D1").Value = "MAÑON FOOT SHOP, S. A."

        'objHojaExcel.Range("A1:D1").Font.Bold = True

        'objHojaExcel.Range("A1:D1").Font.Size = 15



        '' Crear el subencabezado de nuestro informe
        'objHojaExcel.Range("A2:D2").Merge()
        'objHojaExcel.Range("A2:D2").Value = "Ingredient List by Category"
        'objHojaExcel.Range("A2:D2").Font.Italic = True
        'objHojaExcel.Range("A2:D2").Font.Size = 13


        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        k = 0
        For i = 0 To Lista.Columns.Count - 1 Step 1
            objHojaExcel.Cells(1, i + 1) = Lista.Columns(i).Text

            'objCelda.Value = "Categoría"
            'objCelda = objHojaExcel.Range("B1", Type.Missing)
            'objCelda.Value = "Código"
            'objCelda = objHojaExcel.Range("C1", Type.Missing)
            'objCelda.Value = "Nombre"
            'objCelda = objHojaExcel.Range("D1", Type.Missing)
            'objCelda.Value = "Precio RD$"
            'objCelda.EntireColumn.NumberFormat = "###,###,###.00"
        Next
        m_Excel.Visible = True
        Dim objCelda As Excel.Range
        Dim mColorIndex As Integer
        objCelda = objHojaExcel.Range("A1:" & objHojaExcel.Cells(1, i).Address, Type.Missing)
        objCelda.Font.Bold = True
        For i = 0 To 56
            objHojaExcel.Cells(i + 3, 1) = i
            objHojaExcel.Cells(i + 3, 1).interior.colorindex = i
            objHojaExcel.Cells(i + 3, 1).interior.PatternColor = 12419407
            mColorIndex = objHojaExcel.Cells(3, 2).interior.Gradient
            'objCelda.Interior.Gradient(PatternColorIndex)
        Next
        objCelda.Font.Size = 11

        Exit Function
        k = 0
        For i = 0 To Lista.Items.Count - 1 Step 1
            For j = 0 To Lista.Columns.Count - 1 Step 1
                objHojaExcel.Cells(i + 2, j + 1) = Lista.Items(i).SubItems(j).Text
                If Not Barra Is Nothing Then
                    k = k + 1
                    Barra.Value = (k / (Lista.Items.Count * Lista.Columns.Count)) * 100
                    'Application.DoEvents()
                End If
            Next




            '' Si Ya se ha impreso una categorías y la próxima categorías

            '' es diferente a la categorías a imprimir, imprimir los totales

            'If CategoryName.Length > 0 AndAlso CategoryName <> objRow.Item(0) Then

            '    objHojaExcel.Cells(i, 1) = "Total Category " & CategoryName.Trim

            '    objHojaExcel.Cells(i, 2) = "=count(D" & (j + 2).ToString & ":D" & (i - 1).ToString & ")"



            '    objHojaExcel.Cells(i, 3) = "Subtotal Precio:"

            '    objHojaExcel.Cells(i, 4) = "=sum(D" & (j + 2).ToString & ":D" & (i - 1).ToString & ")"

            '    objHojaExcel.Range("A" & i.ToString & ":D" & i.ToString).Font.Bold = True



            '    j = i

            '    i += 2

            'End If



            '' Asignar la categoría impresa

            'CategoryName = objRow.Item(0)



            '' Asignar los valores de los registros a las celdas

            'objHojaExcel.Cells(i, "A") = objRow.Item(0) 'CategoryName'

            'objHojaExcel.Cells(i, "B") = objRow.Item(1) 'ProductID'

            'objHojaExcel.Cells(i, "C") = objRow.Item(2) 'ProductName'

            'objHojaExcel.Cells(i, "D") = objRow.Item(3) 'UnitPrice'



            '' Avanzamos una fila

            'i += 1

        Next



        '* El Ultimo subtotal

        'objHojaExcel.Cells(i, "A") = "Total Category " & CategoryName.Trim

        'objHojaExcel.Cells(i, "B") = "=count(D" & (j + 2).ToString & ":D" & (i - 1).ToString & ")"



        'objHojaExcel.Cells(i, "C") = "Subtotal Precio:"

        'objHojaExcel.Cells(i, "D") = "=sum(D" & (j + 2).ToString & ":D" & (i - 1).ToString & ")"

        'objHojaExcel.Range("A" & i.ToString & ":D" & i.ToString).Font.Bold = True



        '' Avanzamos una fila

        'i += 1



        '' Seleccionar todo el bloque desde A1 hasta D #de filas

        Dim objRango As Excel.Range = objHojaExcel.Range("A1:" & objHojaExcel.Cells(i + 1, j).ADDRESS)


        '' Seleccionamos todo el rango especificado

        objRango.Select()



        '' Ajustamos el ancho de las columnas al ancho máximo del

        '' contenido de sus celdas

        objRango.Columns.AutoFit()



        '' Asignar filtro por columna

        objRango.AutoFilter(1, , VisibleDropDown:=True)



        '' Asignar un formato automático
        'xlRangeAutoFormatList2
        'objRango.AutoFormat(xlRangeAutoFormatTable8, Alignment:=False)
        'objRango.Style = "Neutral"
        objRango.AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatTable5)


        '' Seleccionamos el total general del reporte y asignamos

        '' font a negrita e itálica

        'objRango = objHojaExcel.Range("A" & i.ToString & ":D" & i.ToString)

        'objRango.Select()

        'objRango.Font.Bold = True

        'objRango.Font.Italic = True



        '' Crear un total general

        'objHojaExcel.Cells(i, 1) = "Total "

        'objHojaExcel.Cells(i, 2) = "=count(A3:D" & (i - 1).ToString & ")"



        'objHojaExcel.Cells(i, 3) = "Total Precio:"

        'objHojaExcel.Cells(i, 4) = "=sum(A3:D" & (i - 1).ToString & ")"

        'objLibroExcel.PrintPreview()
        If Not Barra Is Nothing Then
            Barra.Visible = False
        End If
        m_Excel.Visible = True
    End Function

    Public Function FormularioActivo(ByVal NmbFormulario As String) As Boolean
        Dim Formulario As Form
        For Each Formulario In Application.OpenForms
            If (UCase(Formulario.Name) = UCase(NmbFormulario)) Then
                FormularioActivo = True
                Exit Function
            End If
        Next
        FormularioActivo = False
    End Function

    Public Function CargarReporte(ByVal SQL As String, ByVal TablaDS As String, ByVal ConnLocal As SqlClient.SqlConnection, ByVal DSFijo As Object, ByVal varReporte As Object) As Object
        Dim Tabla1 As SqlClient.SqlDataAdapter

        Tabla1 = New SqlClient.SqlDataAdapter(SQL, ConnLocal)
        Tabla1.Fill(DSFijo, TablaDS)


        'AA = DameDataSet("exec sp_TablaAmortizacion 2015, 2", CN)
        'MsgBox(AA.Tables(0).Rows.Count)

        varReporte.SetDataSource(DSFijo)

        Return varReporte
    End Function
End Module
