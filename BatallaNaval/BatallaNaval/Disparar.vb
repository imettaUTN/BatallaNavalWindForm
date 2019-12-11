Imports System.Text.RegularExpressions
Public Class Disparar
    Public cantColumnas As Integer
    Public cantFilas As Integer
    Public SegundoJugadorPC As Boolean
    Public DataGridView As DataGridView
    Private Sub BtDisparar_Click(sender As Object, e As EventArgs) Handles BtDisparar.Click

        If String.IsNullOrEmpty(Me.TxtFila.Text) OrElse String.IsNullOrEmpty(Me.TxtColumnas.Text) Then
            MessageBox.Show("Debe ingresar una coordenadas.")
        End If
        Dim pattern As String = "\d{1," & cantColumnas.ToString() & "}"
        Dim valido As Boolean = True
        If Not Regex.IsMatch(TxtColumnas.Text, pattern) Then
            MessageBox.Show("Las coordenadas de la columna deben ser numerica de 0 a" + cantColumnas.ToString() + ".")
            valido = False
        End If

        pattern = "\d{1," & cantFilas.ToString() & "}"

        If Not Regex.IsMatch(TxtColumnas.Text, pattern) Then
            MessageBox.Show("Las coordenadas de la fila deben ser numerica de 0 a" + cantFilas.ToString() + ".")
            valido = False
        End If
        Dim numAleatorio As New Random()
        Dim sAleaF As Integer = numAleatorio.Next(0, Me.cantFilas - 1)
        Dim sAleaC As Integer = numAleatorio.Next(0, Me.cantColumnas - 1)


        If valido Then
            If Me.CHJ1.Checked Then
                Dim frm As New Jugador1
                frm.Disparar(CInt(Me.TxtFila.Text), CInt(Me.TxtColumnas.Text), DataGridView)
            End If
            If Me.SegundoJugadorPC Then
                Dim frm As New Jugador2

                frm.Disparar(sAleaF, sAleaC, Me.DataGridView)
            End If
            If Me.CHJ2.Checked Then
                Dim frm As New Jugador2
                frm.Disparar(CInt(Me.TxtFila.Text), CInt(Me.TxtColumnas.Text), Me.DataGridView)
            End If
        End If
    End Sub
End Class