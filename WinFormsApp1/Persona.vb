Public Class Persona
    Public Shared ReadOnly RutaArchivo As String = "C:\Users\IK\Desktop\avance paul\proyecto MA\WinFormsApp1\WinFormsApp1\archivos\persona.txt"
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

    ''''''''''''''''>>>>>>>>>>>>>

    Public Shared Sub ModificarPersona(personaModificada As Persona)
        Dim personas As List(Of Persona) = LeerPersonas()

        ' Encuentra el índice de la persona a modificar
        Dim indice As Integer = personas.FindIndex(Function(p) p.IdPersona = personaModificada.IdPersona)

        If indice <> -1 Then
            ' Actualiza los datos de la persona en la lista
            personas(indice) = personaModificada

            ' Guarda los cambios en el archivo
            GuardarPersonas(personas)
        Else
            MessageBox.Show("La persona no fue encontrada para modificar.")
        End If
    End Sub

    Private Shared Sub GuardarPersonas(personas As List(Of Persona))
        Try
            ' Escribe los encabezados y luego las personas en el archivo
            Dim lines As New List(Of String)
            lines.Add("IdPersona|Telefono|Correo|Direccion|Ruc|TipoPersona|Estado")
            For Each persona As Persona In personas
                lines.Add($"{persona.IdPersona}|{persona.Telefono}|{persona.Correo}|{persona.Direccion}|{persona.Ruc}|{persona.TipoPersona}|{persona.Estado}")
            Next
            System.IO.File.WriteAllLines(RutaArchivo, lines)
        Catch ex As Exception
            MessageBox.Show($"Error al guardar las personas: {ex.Message}")
        End Try
    End Sub





End Class