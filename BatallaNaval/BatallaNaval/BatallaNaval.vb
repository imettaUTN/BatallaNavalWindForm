Public Class BatallaNaval
    Public cantBarcos1 As Integer = 0
    Public cantBarcos2 As Integer = 0
    Public cantBarcos3 As Integer = 0
    Public cantBarcos4 As Integer = 0
    Public cantFilas As Integer = 0
    Public cantColumnas As Integer = 0
    Public Jugador2Pc As Boolean = False
    <STAThread()>
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New BatallaNaval())
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Parametros
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
    Private Sub BtJugado1_Click(sender As Object, e As EventArgs) Handles BtJugado1.Click
        Dim frm As New Jugador1
        AddOwnedForm(frm)
        frm.cantBarcos1 = Me.cantBarcos1
        frm.cantBarcos2 = Me.cantBarcos2
        frm.cantBarcos3 = Me.cantBarcos3
        frm.cantBarcos4 = Me.cantBarcos4
        frm.cantColumnas = Me.cantColumnas
        frm.cantFilas = Me.cantFilas
        frm.partidaGuardada = Me.chPartidaGuardada.Checked
        frm.ShowDialog()
    End Sub

    Private Sub BtJugado2_Click(sender As Object, e As EventArgs) Handles BtJugado2.Click
        Dim frm As New Jugador2
        AddOwnedForm(frm)
        frm.cantBarcos1 = Me.cantBarcos1
        frm.cantBarcos2 = Me.cantBarcos2
        frm.cantBarcos3 = Me.cantBarcos3
        frm.cantBarcos4 = Me.cantBarcos4
        frm.cantColumnas = Me.cantColumnas
        frm.cantFilas = Me.cantFilas
        frm.soyPc = Me.Jugador2Pc
        frm.ShowDialog()
    End Sub
    Private Sub LoadPartidaGuardada()
        Dim sBarquito As Barquito = New Barquito()
        Dim sDatosJ1 As Barquito.BatallaNavalGuardada
        Dim sDatosJ2 As Barquito.BatallaNavalGuardada

        sDatosJ1 = sBarquito.LeerArchivo("Jugador1")
        sDatosJ2 = sBarquito.LeerArchivo("Jugador2")
    End Sub
    Private Sub CHJugarPc_CheckedChanged(sender As Object, e As EventArgs) Handles CHJugarPc.CheckedChanged
        Me.Jugador2Pc = CHJugarPc.Checked
    End Sub
End Class