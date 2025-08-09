Public Class Cliente
    Inherits Persona

    Private _ClienteId As Integer

    Public Sub New()
    End Sub

    Public Sub New(clienteId As Integer)
        MyBase.New()
        _ClienteId = clienteId
    End Sub
End Class
