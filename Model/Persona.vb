Imports System.Net
Public Class Persona
    Private _nombre As String
    Private _apellido As String
    Private _edad As Integer
    Private _direccion As String
    Private _telefono As Integer
    Private _correo As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, apellido As String, edad As Integer, direccion As String, telefono As Integer, correo As String)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Edad = edad
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Correo = correo
    End Sub



    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Edad As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
End Class
