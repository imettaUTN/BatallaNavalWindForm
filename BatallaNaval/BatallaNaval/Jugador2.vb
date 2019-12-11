Imports BatallaNaval

Public Class Jugador2
    Public cantBarcos1 As Int32 = 0
    Public cantBarcos2 As Int32 = 0
    Public cantBarcos3 As Int32 = 0
    Public cantBarcos4 As Int32 = 0
    Public cantBarcos5 As Int32 = 0
    Public cantBarcos6 As Int32 = 0
    Public CoordenadasB1 As String = String.Empty
    Public CoordenadasB2 As String = String.Empty
    Public CoordenadasB3 As String = String.Empty
    Public CoordenadasB4 As String = String.Empty
    Public cantColumnas As Integer
    Public cantFilas As Integer
    Public soyPc As Boolean
    Public partidaGuardada As Boolean
    Private _BarquitoSingleton As Barquito
    Public Property BarquitoSingleton As Barquito
        Get
            Return _BarquitoSingleton
        End Get
        Set(value As Barquito)
            If Not Me.UniqueInstanse Then

                _BarquitoSingleton = value
                _uniqueInstanse = True

            End If
        End Set
    End Property
    Private _uniqueInstanse As Boolean = False
    Public Property UniqueInstanse As Boolean
        Get
            Return _uniqueInstanse
        End Get
        Set(value As Boolean)
            _uniqueInstanse = value
        End Set
    End Property
    Private Sub SetupDataGridView()
        Me.DataGridJ1.ColumnCount = cantColumnas
        Me.DataGridJ1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        Me.DataGridJ1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        'Me.DataGridJ1.Location = New Point(8, 8)
        'Me.DataGridJ1.ColumnHeadersBorderStyle =
        '        DataGridViewHeaderBorderStyle.Single
        'Me.DataGridJ1.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Me.DataGridJ1.GridColor = Color.Black
        Me.DataGridJ1.RowHeadersVisible = False
        'Me.DataGridJ1.SelectionMode =
        '        DataGridViewSelectionMode.FullRowSelect
        Me.DataGridJ1.MultiSelect = False
        'Me.DataGridJ1.Dock = DockStyle.Fill
        'Me.DataGridJ1.Size = New Size(500, 500)
        Me.DataGridJ1.AutoSize = True
    End Sub
    Private Sub Jugador2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        GenerarDatos()
        If Me.soyPc Then
            CargarDatosDummy()
        End If
        If Me.partidaGuardada Then
            Me.CargarDatosArchivo()
        End If
    End Sub
    'Emula los datos de la pc
    Public Sub CargarDatosDummy()
        'Dammys para 4 barcos de cada uno matrix minima de 11 x 11
        Me.DataGridJ1.Rows(0).Cells(1).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(0).Cells(1).Value = "X"
        Me.DataGridJ1.Rows(0).Cells(3).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(0).Cells(3).Value = "X"
        Me.DataGridJ1.Rows(0).Cells(5).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(0).Cells(5).Value = "X"

        Me.DataGridJ1.Rows(1).Cells(0).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(1).Cells(0).Value = "X"
        Me.DataGridJ1.Rows(1).Cells(1).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(1).Cells(1).Value = "X"
        Me.DataGridJ1.Rows(1).Cells(3).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(1).Cells(3).Value = "X"
        Me.DataGridJ1.Rows(1).Cells(4).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(1).Cells(4).Value = "X"
        Me.DataGridJ1.Rows(1).Cells(6).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(1).Cells(6).Value = "X"
        Me.DataGridJ1.Rows(1).Cells(7).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(1).Cells(7).Value = "X"

        Me.DataGridJ1.Rows(2).Cells(0).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(0).Value = "X"
        Me.DataGridJ1.Rows(2).Cells(1).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(1).Value = "X"
        Me.DataGridJ1.Rows(2).Cells(2).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(2).Value = "X"
        Me.DataGridJ1.Rows(2).Cells(4).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(4).Value = "X"
        Me.DataGridJ1.Rows(2).Cells(5).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(5).Value = "X"
        Me.DataGridJ1.Rows(2).Cells(6).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(6).Value = "X"
        Me.DataGridJ1.Rows(2).Cells(8).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(8).Value = "X"
        Me.DataGridJ1.Rows(2).Cells(9).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(9).Value = "X"
        Me.DataGridJ1.Rows(2).Cells(10).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(2).Cells(10).Value = "X"


        Me.DataGridJ1.Rows(3).Cells(0).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(3).Cells(0).Value = "X"
        Me.DataGridJ1.Rows(3).Cells(1).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(3).Cells(1).Value = "X"
        Me.DataGridJ1.Rows(3).Cells(2).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(3).Cells(2).Value = "X"
        Me.DataGridJ1.Rows(3).Cells(3).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(3).Cells(3).Value = "X"

        Me.DataGridJ1.Rows(4).Cells(1).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(4).Cells(1).Value = "X"
        Me.DataGridJ1.Rows(4).Cells(2).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(4).Cells(2).Value = "X"
        Me.DataGridJ1.Rows(4).Cells(3).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(4).Cells(3).Value = "X"
        Me.DataGridJ1.Rows(4).Cells(4).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(4).Cells(4).Value = "X"

        Me.DataGridJ1.Rows(5).Cells(5).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(5).Cells(5).Value = "X"
        Me.DataGridJ1.Rows(5).Cells(6).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(5).Cells(6).Value = "X"
        Me.DataGridJ1.Rows(5).Cells(7).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(5).Cells(7).Value = "X"
        Me.DataGridJ1.Rows(5).Cells(8).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(5).Cells(8).Value = "X"

        Me.DataGridJ1.Rows(6).Cells(1).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(6).Cells(1).Value = "X"
        Me.DataGridJ1.Rows(6).Cells(3).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(6).Cells(3).Value = "X"
        Me.DataGridJ1.Rows(6).Cells(4).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(6).Cells(4).Value = "X"

        Me.DataGridJ1.Rows(7).Cells(1).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(7).Cells(1).Value = "X"
        Me.DataGridJ1.Rows(7).Cells(2).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(7).Cells(2).Value = "X"
        Me.DataGridJ1.Rows(7).Cells(3).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(7).Cells(3).Value = "X"
        Me.DataGridJ1.Rows(7).Cells(4).Style.BackColor = Color.Black
        Me.DataGridJ1.Rows(7).Cells(4).Value = "X"
    End Sub
    Private Sub GenerarDatos()
        Dim matrixDat(Me.cantFilas, Me.cantColumnas) As Integer
        Dim sFilaString(Me.cantFilas) As String
        Dim sI As Integer = 0
        For sFila As Int32 = 0 To Me.cantFilas
            sFilaString(sFila) = "A"
            sI = sI + 1
        Next

        For index As Integer = 0 To Me.cantColumnas - 1
            Me.DataGridJ1.Rows.Add(sFilaString)
        Next

        For Each row As DataGridViewRow In Me.DataGridJ1.Rows
            row.DefaultCellStyle.ForeColor = Color.White
        Next

        For sCol As Integer = 0 To Me.cantColumnas - 1
            Me.DataGridJ1.Columns(sCol).Width = 60
        Next



    End Sub
    Private Sub DataGridJ1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If Validar(e.RowIndex, e.ColumnIndex) Then
            If Me.ChCargaDatos.Checked AndAlso Me.DataGridJ1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "X" Then
                Me.DataGridJ1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Black
                Me.DataGridJ1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "X"
            End If
        End If
    End Sub
    Private Function Validar(ByVal x As Integer, ByVal y As Integer) As Boolean
        Dim aux As Integer = 0

        If Me.ChB1.Checked Then
            If Me.cantBarcos1 <= 0 Then
                aux = 0
                MessageBox.Show("Cantidad maxima de barcos 1 cargados")
                Return False
            End If
        End If
        If Me.ChB2.Checked Then
            aux = 1
            If Me.cantBarcos1 <= 0 Then
                MessageBox.Show("Cantidad maxima de barcos 2 cargados")
                Return False
            End If
        End If
        If Me.ChB3.Checked Then
            aux = 2
            If Me.cantBarcos1 <= 0 Then
                MessageBox.Show("Cantidad maxima de barcos 3 cargados")
                Return False
            End If
        End If
        If Me.ChB4.Checked Then
            aux = 3
            If Me.cantBarcos1 <= 0 Then
                MessageBox.Show("Cantidad maxima de barcos 4 cargados")
                Return False
            End If
        End If
        If Me.DataGridJ1.Rows(x).Cells(y).Value <> "A" Then
            MessageBox.Show("Casillero ya usado")
            Return False
        End If

        If (x > 4) Then
            For index As Integer = x To aux + 1
                If Me.DataGridJ1.Rows(index).Cells(y).Value <> "A" Then
                    MessageBox.Show("Espacio insuficiente")
                    Return False
                End If
            Next
            For index As Integer = y To aux + 1
                If Me.DataGridJ1.Rows(x).Cells(index).Value <> "A" Then
                    MessageBox.Show("Espacio insuficiente")
                    Return False
                End If
            Next
        Else
            For index As Integer = x To aux + 1
                If Me.DataGridJ1.Rows(index).Cells(y).Value <> "A" Then
                    MessageBox.Show("Espacio insuficiente")
                    Return False
                End If
            Next
            For index As Integer = y To aux + 1
                If Me.DataGridJ1.Rows(x).Cells(index).Value <> "A" Then
                    MessageBox.Show("Espacio insuficiente")
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Sub Disparar(ByVal x As Integer, ByVal y As Integer, ByVal xDataGrid As DataGridView)
        Me.DataGridJ1 = xDataGrid
        If (Me.DataGridJ1.Rows(x).Cells(y).Value = "D" OrElse Me.DataGridJ1.Rows(x).Cells(y).Value = "AX") Then
            MessageBox.Show("Coordenadas ya usadas")
        End If
        If (Me.DataGridJ1.Rows(x).Cells(y).Value = "D") Then
            Me.DataGridJ1.Rows(x).Cells(y).Value = "AX"
            MessageBox.Show("Agua")
        End If
        If (Me.DataGridJ1.Rows(x).Cells(y).Value <> "D") Then
            Me.DataGridJ1.Rows(x).Cells(y).Style.BackColor = Color.Red
            Me.DataGridJ1.Rows(x).Cells(y).Value = "D"
            ControlarHundido(x, y)
        End If
    End Sub
    Public Sub CargarDatosArchivo()
        Dim xDatos As Barquito.BatallaNavalGuardada = Me.BarquitoSingleton.LeerArchivo("Jugador 2")
        Dim sFilaString(Me.cantFilas) As String
        Dim sI As Integer = 0

        '0 es Agua, 1 coordenada con barcos sin tocar, 2 posicion barco tocado, 3 agua pero coordenada ya usada
        For sFila As Int32 = 0 To xDatos.filas - 1
            For scolumna As Integer = 0 To xDatos.columnas
                If xDatos.MatrizDatos(sFila)(scolumna) = 3 Then
                    sFilaString(sFila) = "AX"
                End If
                If xDatos.MatrizDatos(sFila)(scolumna) = 2 Then
                    sFilaString(sFila) = "D"
                End If
                If xDatos.MatrizDatos(sFila)(scolumna) = 1 Then
                    sFilaString(sFila) = "X"
                End If
                If xDatos.MatrizDatos(sFila)(scolumna) = 0 Then
                    sFilaString(sFila) = "X"
                End If
            Next


            Me.DataGridJ1.Rows.Add(sFilaString)

            sI = sI + 1
        Next
        For x As Integer = 0 To Me.DataGridJ1.Rows.Count() - 1
            For y As Integer = 0 To Me.DataGridJ1.Rows(x).Cells.Count() - 1
                If (Me.DataGridJ1.Rows(x).Cells(y).Value = "D") Then
                    Me.DataGridJ1.Rows(x).Cells(y).Style.BackColor = Color.Red
                End If
                If (Me.DataGridJ1.Rows(x).Cells(y).Value = "A" OrElse Me.DataGridJ1.Rows(x).Cells(y).Value = "AX") Then
                    Me.DataGridJ1.Rows(x).Cells(y).Style.BackColor = Color.Blue
                End If
                If (Me.DataGridJ1.Rows(x).Cells(y).Value = "X") Then
                    Me.DataGridJ1.Rows(x).Cells(y).Style.BackColor = Color.Black
                End If
            Next
        Next

    End Sub
    Private Sub ControlarHundido(ByVal x As Integer, ByVal y As Integer)
        Dim hundidoB1 As Boolean = False
        Dim hundidoB2 As Boolean = False
        Dim hundidoB3 As Boolean = False
        Dim hundidoB4 As Boolean = False


        If (x > 4) Then
            For index As Integer = x To x + 3
                If (Me.DataGridJ1.Rows(index).Cells(y).Value = "D") Then
                    MessageBox.Show("Tocado")
                    hundidoB1 = True
                    '2
                    If (index = x + 1) Then
                        If hundidoB1 Then
                            hundidoB2 = True
                        End If
                    End If
                    '3
                    If (index = x + 2) Then
                        If hundidoB2 Then
                            hundidoB3 = True
                        End If
                    End If
                    '3
                    If (index = x + 3) Then
                        If hundidoB3 Then
                            hundidoB4 = True
                        End If
                    End If
                End If
            Next

            For index As Integer = y To y + 3
                If (Me.DataGridJ1.Rows(x).Cells(index).Value = "D") Then
                    hundidoB1 = True
                    '2
                    If (index = y + 1) Then
                        If hundidoB1 Then
                            hundidoB2 = True
                        End If
                    End If
                    '3
                    If (index = y + 2) Then
                        If hundidoB2 Then
                            hundidoB3 = True
                        End If
                    End If
                    '3
                    If (index = y + 3) Then
                        If hundidoB3 Then
                            hundidoB4 = True
                        End If
                    End If
                End If
            Next

        Else
            For index As Integer = x To 0 Step -1
                If (Me.DataGridJ1.Rows(index).Cells(y).Value = "D") Then
                    hundidoB1 = True
                    '2
                    If (index = x - 1) Then
                        If hundidoB1 Then
                            hundidoB2 = True
                        End If
                    End If
                    '3
                    If (index = x - 2) Then
                        If hundidoB2 Then
                            hundidoB3 = True
                        End If
                    End If
                    '3
                    If (index = x - 3) Then
                        If hundidoB3 Then
                            hundidoB4 = True
                        End If
                    End If
                End If
            Next
            For index As Integer = y To 0 Step -1
                If (Me.DataGridJ1.Rows(x).Cells(index).Value = "D") Then
                    hundidoB1 = True
                    '2
                    If (index = y - 1) Then
                        If hundidoB1 Then
                            hundidoB2 = True
                        End If
                    End If
                    '3
                    If (index = y - 2) Then
                        If hundidoB2 Then
                            hundidoB3 = True
                        End If
                    End If
                    '3
                    If (index = y - 3) Then
                        If hundidoB3 Then
                            hundidoB4 = True
                        End If
                    End If
                End If
            Next
            If hundidoB1 Then
                Me.cantBarcos1 -= 1
            End If
            If hundidoB2 Then
                Me.cantBarcos2 -= 1
            End If
            If hundidoB3 Then
                Me.cantBarcos3 -= 1
            End If
            If hundidoB4 Then
                Me.cantBarcos4 -= 1
            End If
            If hundidoB1 OrElse hundidoB2 OrElse hundidoB3 OrElse hundidoB4 Then
                MessageBox.Show("Hundido.")

            End If
            If Me.cantBarcos1 = 0 AndAlso Me.cantBarcos2 = 0 AndAlso Me.cantBarcos3 = 0 AndAlso Me.cantBarcos4 = 0 Then
                Dim frm As New Disparar
                AddOwnedForm(frm)
                frm.Close()
                MessageBox.Show("Fin de la partida. Jugador 2 ganador")
            End If
        End If
    End Sub
    Private Sub ChCargaDatos_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChCargaDatos.CheckedChanged
        If Not Me.ChCargaDatos.Checked Then
            Dim frm As New Disparar
            AddOwnedForm(frm)
            frm.cantColumnas = Me.cantColumnas
            frm.cantFilas = Me.cantFilas
            frm.DataGridView = Me.DataGridJ1
            frm.ShowDialog()
        End If
    End Sub

    Private Sub DataGridJ1_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJ1.CellDoubleClick
        If Validar(e.RowIndex, e.ColumnIndex) Then
            If Me.ChCargaDatos.Checked AndAlso Me.DataGridJ1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "X" Then
                Me.DataGridJ1.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Black
                Me.DataGridJ1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "X"
            End If
        End If
    End Sub
    Private Sub chGuardarPartida_CheckedChanged(sender As Object, e As EventArgs) Handles chGuardarPartida.CheckedChanged
        Dim matrixDat(Me.cantFilas, Me.cantColumnas) As Integer

        '0 es Agua, 1 coordenada con barcos sin tocar, 2 posicion barco tocado, 3 agua pero coordenada ya usada
        Dim sValor As Integer = 0
        For x As Integer = 0 To Me.DataGridJ1.Rows.Count() - 1
            For y As Integer = 0 To Me.DataGridJ1.Rows(x).Cells.Count() - 1
                'Me.DataGridJ1.Rows(x).Cells(y).Style.BackColor = Color.Red
                If Me.DataGridJ1.Rows(x).Cells(y).Value = "A" Then
                    sValor = 0
                End If
                If Me.DataGridJ1.Rows(x).Cells(y).Value = "AX" Then
                    sValor = 3
                End If
                If Me.DataGridJ1.Rows(x).Cells(y).Value = "X" Then
                    sValor = 1
                End If
                If Me.DataGridJ1.Rows(x).Cells(y).Value = "D" Then
                    sValor = 2
                End If
                matrixDat(x, y) = sValor
            Next
        Next
        Me.BarquitoSingleton.GrabarArchivoJuego(matrixDat, Me.cantFilas, Me.cantColumnas, "Jugador 2")
    End Sub
End Class