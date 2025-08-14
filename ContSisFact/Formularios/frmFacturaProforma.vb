Public Class frmFacturaProforma
    Public bSalidaDblClik As Boolean = False

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        bSalidaDblClik = False
        Close()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim myForm As New frmPedidosBusqueda

        myForm.ShowDialog()
        If myForm.bSalidaDblClik Then
            txtProforma.Text = myForm.strProforma
        End If
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If MessageBox.Show("Esta seguro que quiere borrar este registro?", "ContSis", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If Not Vacio(txtProforma.Text) And Not Vacio(txtFactura.Text) Then
                Dim sql As String = "EXEC dsc.SP_Guardar_facturaProforma '" & txtFactura.Text & "', '" & txtProforma.Text & "', 2"
                ExecuteSQL(sql, CN)
                txtProforma.Text = String.Empty
                MessageBox.Show("Registro borrado exitosamente.")
                bSalidaDblClik = True
                Me.Close()
            Else
                MessageBox.Show("Por favor, ingrese un número de proforma válido.")
            End If
        End If
    End Sub

    Private Sub OK_Precios_Click(sender As Object, e As EventArgs) Handles OK_Precios.Click
        If Not Vacio(txtProforma.Text) And Not Vacio(txtFactura.Text) Then
            Dim sql As String = "EXEC dsc.SP_Guardar_facturaProforma '" & txtFactura.Text & "', '" & txtProforma.Text & "', 1"
            ExecuteSQL(sql, CN)
            txtProforma.Text = String.Empty
            MessageBox.Show("Registro guardado exitosamente.")
            bSalidaDblClik = True
            Close()
        Else
            MessageBox.Show("Por favor, ingrese un número de proforma o factura válido.")
        End If
    End Sub

    Private Sub frmFacturaProforma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bSalidaDblClik = False
    End Sub
End Class