Public Class PersonaNatural
    Inherits Persona

    Public Property IdPersonaNatural As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Dni As String
    Public Overloads Property Estado As Boolean

    ' Método para leer personas naturales desde el archivo
    Public Shared Function LeerPersonasNaturales() As List(Of PersonaNatural)
        Dim personasNaturales As New List(Of PersonaNatural)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("C:\Users\IK\Desktop\avance paul\proyecto MA\WinFormsApp1\WinFormsApp1\archivos\personaNatural.txt") 'Datos\persona_natural.txt
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i) 'C:\Users\IK\Desktop\avance paul\proyecto MA
                Dim fields() As String = line.Split("|"c)
                Dim personaNatural As New PersonaNatural() With {
                    .IdPersonaNatural = Integer.Parse(fields(0)),
                    .Nombre = fields(1),
                    .Apellido = fields(2),
                    .Dni = fields(3),
                    .IdPersona = Integer.Parse(fields(4)),
                    .Estado = Boolean.Parse(fields(5))
                }
                personasNaturales.Add(personaNatural)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer las personas naturales: {ex.Message}")
        End Try
        Return personasNaturales
    End Function

    Public Shared Function BuscarPersonaNaturalPorId(idPersona As Integer) As PersonaNatural
        Dim personasNaturales As List(Of PersonaNatural) = LeerPersonasNaturales()
        Return personasNaturales.FirstOrDefault(Function(p) p.IdPersona = idPersona)
    End Function

    ' Método para buscar una persona natural por DNI
    Public Shared Function BuscarPersonaNaturalPorDni(dni As String) As PersonaNatural
        Dim personasNaturales As List(Of PersonaNatural) = LeerPersonasNaturales()
        Return personasNaturales.FirstOrDefault(Function(p) p.Dni = dni)
    End Function

End Class