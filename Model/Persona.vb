Imports System.Net
Public Class Persona
    Private _nombre As String
    Private _apellido As String
    Private _edad As String
    Private _dirreccion As String
    Private _telefono As String
    Private _correo As String

    Public Sub New(nombre As String, apellido As String, edad As String, dirreccion As String, telefono As String, correo As String)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Edad = edad
        Me.Dirreccion = dirreccion
        Me.Telefono = telefono
        Me.Correo = correo
    End Sub

    Public Sub New()
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

    Public Property Edad As String
        Get
            Return _edad
        End Get
        Set(value As String)
            _edad = value
        End Set
    End Property

    Public Property Dirreccion As String
        Get
            Return _dirreccion
        End Get
        Set(value As String)
            _dirreccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
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
