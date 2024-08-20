Public Class PersonaNatural
    Inherits Persona

    Public Property IdPersonaNatural As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Dni As String
    Public Overloads Property Estado As Boolean
            
    Public Shared ReadOnly RutaArchivo As String = "C:\Users\IK\Desktop\avance paul\proyecto MA\WinFormsApp1\WinFormsApp1\archivos\personaNatural.txt"

    ' Método para leer personas naturales desde el archivo
    Public Shared Function LeerPersonasNaturales() As List(Of PersonaNatural)
        Dim personasNaturales As New List(Of PersonaNatural)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines(RutaArchivo) 'Datos\persona_natural.txt
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

    '''<<<<<<<<<<<<<<<<<<<<<<<
    Public Shared Sub ModificarPersonaNatural(personaNaturalModificada As PersonaNatural)
        Dim personasNaturales As List(Of PersonaNatural) = LeerPersonasNaturales()

        ' Encuentra el índice de la persona natural a modificar
        Dim indice As Integer = personasNaturales.FindIndex(Function(p) p.IdPersonaNatural = personaNaturalModificada.IdPersonaNatural)

        If indice <> -1 Then
            ' Actualiza los datos de la persona natural en la lista
            personasNaturales(indice) = personaNaturalModificada

            ' Guarda los cambios en el archivo
            GuardarPersonasNaturales(personasNaturales)
        Else
            MessageBox.Show("La persona natural no fue encontrada para modificar.")
        End If
    End Sub

    Private Shared Sub GuardarPersonasNaturales(personasNaturales As List(Of PersonaNatural))
        Try
            ' Escribe los encabezados y luego las personas naturales en el archivo
            Dim lines As New List(Of String)
            lines.Add("IdPersonaNatural|Nombre|Apellido|Dni|IdPersona|Estado")
            For Each personaNatural As PersonaNatural In personasNaturales
                lines.Add($"{personaNatural.IdPersonaNatural}|{personaNatural.Nombre}|{personaNatural.Apellido}|{personaNatural.Dni}|{personaNatural.IdPersona}|{personaNatural.Estado}")
            Next
            System.IO.File.WriteAllLines(RutaArchivo, lines)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar las personas naturales: {ex.Message}")
        End Try
    End Sub



End Class