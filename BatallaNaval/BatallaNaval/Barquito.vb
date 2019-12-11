Imports System
Imports System.Configuration
Imports System.IO

Public Class Barquito
    Private fileName As String


    Public ReadOnly Property Path1 As String
        Get
            Return "C:\Work"
        End Get
    End Property

    Public Property FileName1 As String
        Get
            Return fileName
        End Get
        Set(value As String)
            fileName = value
        End Set
    End Property

    Public Structure BatallaNavalGuardada
        Public MatrizDatos()() As Integer
        Public filas As Integer
        Public columnas As Integer
    End Structure
    Public Sub GrabarArchivoJuego(ByVal xMatriz(,) As Integer, ByVal xFilas As Integer, ByVal xColumnas As Integer, ByVal xJugador As String)

        Dim objStreamWriter As StreamWriter
        Me.fileName = "BatallaNaval." + xFilas + "." + xColumnas + "." + xJugador
        objStreamWriter = New StreamWriter(Path1 + "\" + FileName1 + ".txt")
        Dim sLinea As String = String.Empty
        For sFila As Integer = 0 To xFilas
            For sColumna As Integer = 0 To xColumnas
                sLinea = sLinea & IIf(sLinea Is String.Empty, xMatriz(sFila, sColumna).ToString(), "|" & xMatriz(sFila, sColumna).ToString())
                objStreamWriter.WriteLine(sLinea)

            Next
        Next
        objStreamWriter.Close()
        objStreamWriter.Flush()
    End Sub
    Public Function LeerArchivo(ByVal xJugador As String) As BatallaNavalGuardada
        Dim objStreamReader As StreamReader
        Dim strLine As String = String.Empty

        Dim sBatallaNavalGuardada As BatallaNavalGuardada = New BatallaNavalGuardada

        Dim folder As New DirectoryInfo(Path1)

        Dim file() As FileInfo = folder.GetFiles(xJugador)

        objStreamReader = New StreamReader(file.First().FullName)

        strLine = objStreamReader.ReadLine

        sBatallaNavalGuardada.filas = file.First().FullName.Split(".")(1)

        sBatallaNavalGuardada.columnas = file.First().FullName.Split(".")(2)

        Dim sFila = 0, sColumna As Integer = 0
        Dim sMatrix(sBatallaNavalGuardada.filas)() As Integer
        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing
            For Each svalor As String In strLine.Split("|")
                sMatrix(sFila)(sColumna) = CInt(svalor)
                sColumna += 1
            Next
            sFila += 1
            'Read the next line.
            strLine = objStreamReader.ReadLine
        Loop
        sBatallaNavalGuardada.MatrizDatos = sMatrix
        'Close the file.
        objStreamReader.Close()

        Console.ReadLine()

        Return sBatallaNavalGuardada
    End Function
End Class
