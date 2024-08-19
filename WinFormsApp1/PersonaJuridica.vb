Public Class PersonaJuridica
    Inherits Persona

    Public Property IdPersonaJuridica As Integer
    Public Property RazonSocial As String
    Public Overloads Property Estado As Boolean

    ' Método para leer personas jurídicas desde el archivo
    Public Shared Function LeerPersonasJuridicas() As List(Of PersonaJuridica)
        Dim personasJuridicas As New List(Of PersonaJuridica)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("C:\Users\IK\Desktop\avance paul\proyecto MA\WinFormsApp1\WinFormsApp1\archivos\personaJuridica.txt")
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


    '-------------
    Public Shared Sub ModificarPersonaJuridica(personaJuridicaModificada As PersonaJuridica)
        Dim personasJuridicas As List(Of PersonaJuridica) = LeerPersonasJuridicas()

        ' Encuentra el índice de la persona jurídica a modificar
        Dim indice As Integer = personasJuridicas.FindIndex(Function(p) p.IdPersonaJuridica = personaJuridicaModificada.IdPersonaJuridica)

        If indice <> -1 Then
            ' Actualiza los datos de la persona jurídica en la lista
            personasJuridicas(indice) = personaJuridicaModificada

            ' Guarda los cambios en el archivo
            GuardarPersonasJuridicas(personasJuridicas)
        Else
            MessageBox.Show("La persona jurídica no fue encontrada para modificar.")
        End If
    End Sub

    Private Shared Sub GuardarPersonasJuridicas(personasJuridicas As List(Of PersonaJuridica))
        Try
            ' Escribe los encabezados y luego las personas jurídicas en el archivo
            Dim lines As New List(Of String)
            lines.Add("IdPersonaJuridica|RazonSocial|IdPersona|Estado")
            For Each personaJuridica As PersonaJuridica In personasJuridicas
                lines.Add($"{personaJuridica.IdPersonaJuridica}|{personaJuridica.RazonSocial}|{personaJuridica.IdPersona}|{personaJuridica.Estado}")
            Next
            System.IO.File.WriteAllLines("C:\Users\IK\Desktop\avance paul\proyecto MA\WinFormsApp1\WinFormsApp1\archivos\personaJuridica.txt", lines)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar las personas jurídicas: {ex.Message}")
        End Try
    End Sub








End Class