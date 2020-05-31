Public Class Form1
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valor As Integer
        valor = InputBox("Ingrese un numero", "Ingreso")
        txtIngresar.Text = valor
        btnCalcular.Focus()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim OPC As DialogResult
        OPC = MessageBox.Show("¿Desea Seguir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OPC = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma, resta, multi, valor As Integer
        Dim div As Double
        valor = Val(txtIngresar.Text)
        For i = 1 To 10 Step 1
            suma = valor + i
            resta = valor - i
            multi = valor * i
            div = Format((valor / i).ToString)
            ComboSuma.Items.Add(valor & "+" & i & "= " & suma)
            ComboResta.Items.Add(valor & "-" & i & "= " & resta)
            ComboMulti.Items.Add(valor & "x" & i & "= " & multi)
            ComboDiv.Items.Add(valor & "/" & i & "= " & div)
        Next
    End Sub

End Class
