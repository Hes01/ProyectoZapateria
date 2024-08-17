Public Class PersonaJuridica
    Inherits Persona

    Public Property IdPersonaJuridica As Integer
    Public Property RazonSocial As String
    Public Property Estado As Boolean

    ' Método para leer personas jurídicas desde el archivo
    Public Shared Function LeerPersonasJuridicas() As List(Of PersonaJuridica)
        Dim personasJuridicas As New List(Of PersonaJuridica)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("Datos\persona_juridica.txt")
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i)
                Dim fields() As String = line.Split("|"c)
                Dim personaJuridica As New PersonaJuridica() With {
                    .IdPersonaJuridica = Integer.Parse(fields(0)),
                    .RazonSocial = fields(1),
                    .IdPersona = Integer.Parse(fields(2)),
                    .Estado = Boolean.Parse(fields(3))
                }
                personasJuridicas.Add(personaJuridica)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer las personas jurídicas: {ex.Message}")
        End Try
        Return personasJuridicas
    End Function

    Public Shared Function BuscarPersonaJuridicaPorId(idPersona As Integer) As PersonaJuridica
        Dim personasJuridicas As List(Of PersonaJuridica) = LeerPersonasJuridicas()
        Return personasJuridicas.FirstOrDefault(Function(p) p.IdPersona = idPersona)
    End Function
End Class