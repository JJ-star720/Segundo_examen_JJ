Public Class Usuario
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Email As String
    Public Property Password As String

    ' Constructor por defecto
    Public Sub New()
    End Sub

    ' Constructor con parámetros
    Public Sub New(id As Integer, nombre As String, apellido As String, email As String, password As String)
        Me.Id = id
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Email = email
        Me.Password = password
    End Sub

    ' Método para validar el usuario (ejemplo simple)
    Public Function Validar() As Boolean
        Return Not String.IsNullOrEmpty(Email) AndAlso Not String.IsNullOrEmpty(Password)
    End Function

    ' Método para convertir un DataTable a un objeto Usuario
    Public Function dtToUsuario(dataTable As DataTable) As Usuario
        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
            Dim row = dataTable.Rows(0)
            Return New Usuario() With {
                .Id = Convert.ToInt32(row("ID")),
                .Nombre = Convert.ToString(row("NOMBRE")),
                .Apellido = Convert.ToString(row("APELLIDO")),
                .Email = Convert.ToString(row("EMAIL")),
                .Password = Convert.ToString(row("CONTRASEÑA"))
            }
        End If
        Return Nothing
    End Function

End Class
