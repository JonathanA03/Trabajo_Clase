Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim cadena As String
        cadena = txtCadenas.Text
        'Length, retorna las posiciones de una cadena incluyendo los espacios
        txtLongitud.Text = cadena.Length
        txtUltimo.Text = cadena.Substring(cadena.Length - 1, 1)
        txtPrimero.Text = cadena.Substring(0, 1)
        txtTercero.Text = cadena.Substring(2, 7)
        txtPosicion.Text = cadena.IndexOf("B", 0) + 1
        txtMayuscula.Text = cadena.ToUpper
        txtMinuscula.Text = cadena.ToLower
        txtBorrar.Text = cadena.Replace(" ", "")
    End Sub
End Class
