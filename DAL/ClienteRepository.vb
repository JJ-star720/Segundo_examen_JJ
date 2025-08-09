Imports System.Data.SqlClient
Public Class ClienteRepository
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("Conexion").ConnectionString

    Public Function createCliente(cliente As Cliente) As String
        Try
            Dim query As String = "INSERT INTO Clientes (Nombre, Apellido, Edad, Direccion, Telefono, Correo) 
            VALUES (@Nombre, @Apellido, @Edad, @Direccion, @Telefono, @Correo )"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", cliente.Nombre),
                New SqlParameter("@Apellido", cliente.Apellido),
                New SqlParameter("@Edad", cliente.Edad),
                New SqlParameter("@Direccion", cliente.Direccion),
                New SqlParameter("@Telefono", cliente.Telefono),
                New SqlParameter("@Correo", cliente.Correo)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Clientes registrado con exito."
        Catch ex As Exception
            Return "Error al crear el Cliente: " & ex.Message
        End Try
    End Function

    Public Function EliminarCliente(id As Integer) As String
        Try
            Dim query As String = "DELETE FROM Clientes WHERE ClienteID = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", id)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return "No se encontró el Cliente con el ID especificado."
                    End If
                End Using
            End Using
            Return "Cliente eliminado exitosamente."
        Catch ex As Exception
            Return "Error al eliminar el Cliente: " & ex.Message
        End Try
    End Function

    Friend Function UpdateClientes(id As String, cliente As Cliente) As String
        Try
            Dim query As String = "UPDATE Clientes SET Nombre = @Nombre,
            Apellido = @Apellido, Edad = @Edad, Direccion = @Direccion, 
            Telefono = @Telefono, Correo = @Correo WHERE ClienteID = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", id),
                New SqlParameter("@Nombre", cliente.Nombre),
                New SqlParameter("@Apellido", cliente.Apellido),
                New SqlParameter("@Edad", cliente.Edad),
                New SqlParameter("@Direccion", cliente.Direccion),
                New SqlParameter("@Telefono", cliente.Telefono),
                New SqlParameter("@Correo", cliente.Correo)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Producto actualizado exitosamente."
        Catch ex As Exception
            Return "Error al actualizar el Producto: " & ex.Message
        End Try
    End Function


End Class
