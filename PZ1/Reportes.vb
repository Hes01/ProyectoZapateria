Imports System.IO
Imports System.Linq

Public Class Reportes
    Private Sub btnObtenerVentas_Click(sender As Object, e As EventArgs) Handles btnObtenerVentas.Click
        CargarVentasPorVendedor()
        CargarVentasPorProducto()
    End Sub

    Private Sub CargarVentasPorVendedor()
        ' Leer datos de archivos
        Dim comprobantes As List(Of String) = LeerArchivo("Datos\comprobantes.txt")
        Dim detallesComprobante As List(Of String) = LeerArchivo("Datos\detalles_comprobantes.txt")
        Dim personas As List(Of String) = LeerArchivo("Datos\persona.txt")
        Dim personasNaturales As List(Of String) = LeerArchivo("Datos\persona_natural.txt")
        Dim personasJuridicas As List(Of String) = LeerArchivo("Datos\persona_juridica.txt")

        ' Filtrar los comprobantes de ventas con estado True y dentro del rango de fechas seleccionado
        Dim ventas = From c In comprobantes
                     Let fechaComprobante = c.Split("|")(1)
                     Where c.Split("|")(6) = "True" AndAlso
                       DateTime.TryParse(fechaComprobante, Nothing) AndAlso
                       DateTime.Parse(fechaComprobante) >= dtpFecha1Reporte.Value AndAlso
                       DateTime.Parse(fechaComprobante) <= dtpFecha2Reporte.Value
                     Select c

        ' Filtrar los vendedores activos
        Dim vendedoresActivos = From p In personas
                                Where p.Split("|")(5) = "Vendedor" AndAlso p.Split("|")(6) = "True"
                                Let idPersona = p.Split("|")(0)
                                Let nombreCompleto = (From n In personasNaturales
                                                      Where n.Split("|")(4) = idPersona
                                                      Select n.Split("|")(1) & " " & n.Split("|")(2)).FirstOrDefault()
                                Select New With {
                                .IdPersona = idPersona,
                                .NombreCompleto = nombreCompleto
                            }

        ' Unir ventas con detalles de comprobantes
        Dim ventasDetalles = From v In ventas
                             Let idComprobante = v.Split("|")(0)
                             Let idVendedor = v.Split("|")(5) ' idVendedor en comprobante.txt
                             Let cantidadVendida = (From d In detallesComprobante
                                                    Where d.Split("|")(4) = idComprobante
                                                    Select Val(d.Split("|")(1))).Sum()
                             Select New With {
                             .IdVendedor = idVendedor,
                             .CantidadVendida = cantidadVendida
                         }

        ' Agrupar el total vendido por cada vendedor
        Dim ventasPorVendedor = From v In ventasDetalles
                                Group By v.IdVendedor Into TotalCantidadVendida = Sum(v.CantidadVendida)
                                Select New With {
                                .IdVendedor = IdVendedor,
                                .TotalCantidadVendida = TotalCantidadVendida
                            }

        ' Unir ventas por vendedor con datos del vendedor
        Dim resultado = From v In ventasPorVendedor
                        Join p In vendedoresActivos On v.IdVendedor Equals p.IdPersona
                        Select New With {
                        .IdVendedor = p.IdPersona,
                        .Vendedor = p.NombreCompleto,
                        .TotalCantidadVendida = v.TotalCantidadVendida
                    }

        ' Asignar el resultado al primer DataGridView
        dgvVendedores.DataSource = resultado.ToList()
    End Sub

    Private Sub CargarVentasPorProducto()
        ' Leer datos de archivos
        Dim comprobantes As List(Of String) = LeerArchivo("Datos\comprobantes.txt")
        Dim detallesComprobante As List(Of String) = LeerArchivo("Datos\detalles_comprobantes.txt")
        Dim productos As List(Of String) = LeerArchivo("Datos\producto.txt")
        Dim marcas As List(Of String) = LeerArchivo("Datos\marca.txt")

        ' Filtrar los comprobantes de ventas con estado True y dentro del rango de fechas seleccionado
        Dim ventas = From c In comprobantes
                     Let fechaComprobante = c.Split("|")(1)
                     Where c.Split("|")(6) = "True" AndAlso
                       DateTime.TryParse(fechaComprobante, Nothing) AndAlso
                       DateTime.Parse(fechaComprobante) >= dtpFecha1Reporte.Value AndAlso
                       DateTime.Parse(fechaComprobante) <= dtpFecha2Reporte.Value
                     Select c

        ' Obtener los IdComprobante de las ventas filtradas
        Dim idComprobantes = (From v In ventas
                              Select v.Split("|")(0)).ToList()

        ' Filtrar los detalles de comprobantes que están en las ventas filtradas
        Dim detallesVentas = From d In detallesComprobante
                             Where idComprobantes.Contains(d.Split("|")(4)) AndAlso d.Split("|")(5) = "True"
                             Select d

        ' Sumar la cantidad vendida por cada producto
        Dim ventasPorProducto = From d In detallesVentas
                                Let idProducto = d.Split("|")(3)
                                Let cantidadVendida = Val(d.Split("|")(1))
                                Group By idProducto Into CantidadVendida = Sum(cantidadVendida)
                                Select New With {
                                .IdProducto = idProducto,
                                .CantidadVendida = CantidadVendida
                            }

        ' Obtener información del producto y marca
        Dim productosConMarca = From p In productos
                                Join m In marcas On p.Split("|")(7) Equals m.Split("|")(0)
                                Select New With {
                                .IdProducto = p.Split("|")(0),
                                .NombreProducto = p.Split("|")(2),
                                .Marca = m.Split("|")(1)
                            }

        ' Unir ventas por producto con datos del producto y marca
        Dim resultado = From vp In ventasPorProducto
                        Join pm In productosConMarca On vp.IdProducto Equals pm.IdProducto
                        Select New With {
                        .IdProducto = pm.IdProducto,
                        .DescripcionProducto = pm.NombreProducto & " (" & pm.Marca & ")",
                        .CantidadVendida = vp.CantidadVendida
                    }

        ' Asignar el resultado al segundo DataGridView
        dgvProductos.DataSource = resultado.ToList()
    End Sub

    Private Function LeerArchivo(ruta As String) As List(Of String)
        Dim lineas As New List(Of String)
        Try
            Using sr As New StreamReader(ruta)
                While Not sr.EndOfStream
                    lineas.Add(sr.ReadLine())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al leer el archivo {ruta}: {ex.Message}")
        End Try
        Return lineas
    End Function

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Home.Show()
        Me.Hide()

    End Sub
End Class
