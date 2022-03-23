Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim base, altura As Double
        If (txtBase.Text < 0 Or txtAltura.Text < 0) Then
            MsgBox("El valor ingresado es Erroneo")
        Else
            base = txtBase.Text
            altura = txtAltura.Text
            AreaTriangulo(base, altura)
            txtResp2.Text = AreaTriangulo2(base, altura)
        End If

    End Sub

    Sub AreaTriangulo(parametro1 As Double, parametro2 As Double)
        ' MsgBox("El Area del Triangulo es: " & ((parametro1 * parametro2) / 2))
        txtRespuesta.Text = ((parametro1 * parametro2) / 2)
    End Sub

    Function AreaTriangulo2(parametro1 As Double, parametro2 As Double)
        Return ((parametro1 * parametro2) / 2)
    End Function

    Private Sub chkColorFondo_CheckedChanged(sender As Object, e As EventArgs) Handles chkColorFondo.CheckedChanged
        'If (chkColorFondo.Checked = True) Then
        '    txtBase.BackColor = Color.Red
        'Else
        '    txtBase.BackColor = Color.White
        'End If

    End Sub

    Private Sub txtAltura_Leave(sender As Object, e As EventArgs) Handles txtAltura.Leave
        If (txtAltura.Text < 0) Then
            MsgBox("Valor Erroneo")
            txtAltura.Focus()
        Else
            If (txtBase.Text > 0) Then
                btnMostrar.Enabled = True
            End If

        End If
    End Sub

    Private Sub txtBase_Leave(sender As Object, e As EventArgs) Handles txtBase.Leave
        If (txtBase.Text < 0) Then
            MsgBox("Valor Erroneo")
            txtBase.Focus()


        End If
    End Sub


End Class
