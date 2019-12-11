Public Class Parametros
    Private Sub BtbCerrar_Click(sender As Object, e As EventArgs) Handles BtbCerrar.Click
        Dim frm As BatallaNaval = CType(Owner, BatallaNaval)
        frm.TxtColumnas.Text = Me.TxtColumnas.Text
        frm.TxtFilas.Text = Me.TxtFilas.Text
        frm.cantColumnas = CInt(Me.TxtColumnas.Text)
        frm.cantFilas = CInt(Me.TxtFilas.Text)
        frm.cantBarcos1 = CInt(Me.TxtB1.Text)
        frm.cantBarcos2 = CInt(Me.TxtB2.Text)
        frm.cantBarcos3 = CInt(Me.TxtB3.Text)
        frm.cantBarcos4 = CInt(Me.TxtB4.Text)
        'GenerarDatos(frm)
        Me.Close()
    End Sub

    Private Sub TxtFilas_TextChanged(sender As Object, e As EventArgs) Handles TxtFilas.TextChanged
        Me.TxtColumnas.Text = Me.TxtFilas.Text
    End Sub
End Class