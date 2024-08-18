Imports System.Data.SqlTypes

Public Class Empleado
    Public Property IdEmpleado As Integer
    Public Property Sueldo As Decimal
    Public Property Telefono As String
    Public Property correo As String
    Public Property Direccion As String
    Public Property Dni As String
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property idTipo As Integer
    Public Property Estado As Boolean '1:cliente

    ' Método para leer personas desde el archivo
    Public Shared Function LeerEmpleados() As List(Of Empleado)
        Dim empleados As New List(Of Empleado)
        Try
            Dim lines() As String = System.IO.File.ReadAllLines("Datos\persona.txt")
            For i As Integer = 1 To lines.Length - 1
                Dim line As String = lines(i)
                Dim fields() As String = line.Split("|"c)
                Dim empleado As New Empleado() With {
                    .IdEmpleado = Integer.Parse(fields(0)),
                    .Sueldo = fields(1),
                    .Telefono = fields(2),
                    .correo = fields(3),
                    .Direccion = fields(4),
                    .Dni = fields(6),
                    .Nombre = fields(7),
                    .Apellido = fields(8),
                    .idTipo = fields(10),
                    .Estado = Boolean.Parse(fields(11))
                }
                empleados.Add(empleado)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error al leer las Empleado: {ex.Message}")
        End Try
        Return empleados
    End Function

    ' Método para buscar una empleado por dni
    Public Shared Function BuscarEmpleadoPorDni(dni As String) As Empleado
        Dim empleados As List(Of Empleado) = LeerEmpleados()
        Return empleados.FirstOrDefault(Function(p) p.Dni = dni)
    End Function
    Public Shared Function BuscarEmpleadoPorId(idEmpleado As Integer) As Empleado
        Dim empleados As List(Of Empleado) = LeerEmpleados()
        Return empleados.FirstOrDefault(Function(p) p.IdEmpleado = idEmpleado)
    End Function

























End Class
