Public Class Persona
    Public Const RutaArchivo As String = "Datos/persona.txt"
    Public Property IdPersona As Integer
    Public Property Telefono As String
    Public Property Correo As String
    Public Property Direccion As String
    Public Property Ruc As String
    Public Property TipoPersona As String
    Public Property Estado As Boolean

    ' Método para leer personas desde el archivo
    Public Shared Function LeerPersonas() As List(Of Persona)
        Dim personas As New List(Of Persona)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines(RutaArchivo)
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i)
                Dim fields() As String = line.Split("|"c)
                Dim persona As New Persona() With {
                    .IdPersona = Integer.Parse(fields(0)),
                    .Telefono = fields(1),
                    .Correo = fields(2),
                    .Direccion = fields(3),
                    .Ruc = fields(4),
                    .TipoPersona = fields(5),
                    .Estado = Boolean.Parse(fields(6))
                }
                personas.Add(persona)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer las personas: {ex.Message}")
        End Try
        Return personas
    End Function

    ' Método para buscar una persona por RUC
    Public Shared Function BuscarPersonaPorRuc(ruc As String) As Persona
        Dim personas As List(Of Persona) = LeerPersonas()
        Return personas.FirstOrDefault(Function(p) p.Ruc = ruc)
    End Function
    Public Shared Function BuscarPersonaPorId(idPersona As Integer) As Persona
        Dim personas As List(Of Persona) = LeerPersonas()
        Return personas.FirstOrDefault(Function(p) p.IdPersona = idPersona)
    End Function

End Class