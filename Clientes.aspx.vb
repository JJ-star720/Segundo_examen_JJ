Imports System.Web.UI.WebControls.Expressions
Imports Microsoft.Ajax.Utilities
Public Class Clientes
    Inherits System.Web.UI.Page
    Protected dbClientrepo As New ClienteRepository()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_click(sender As Object, e As EventArgs)
        If IDClients.Value.IsNullOrWhiteSpace Then
            If TxtNombre.Text And Txtapellido.Text And Txttelefono.Text = "" Then
                LblMensaje.Text = "El campo es obligatorio"
            Else
                Dim person As New Persona() With {
                    .Nombre = TxtNombre.Text,
                    .Apellido = Txtapellido.Text,
                    .Edad = Conversion.Val(Txtedad.Text),
                    .Dirreccion = Txtdireccion.Text,
                    .Telefono = Conversion.Val(Txttelefono.Text),
                    .Correo = Txtcorreo.Text
                }
                Dim resultado As String = dbClientrepo.createCliente(person)
                LblMensaje.Text = resultado
                GvClientes.DataBind()
            End If
        Else

            Dim newcliente As New Persona() With {
                .Nombre = TxtNombre.Text,
                .Apellido = Txtapellido.Text,
                .Edad = Decimal.Parse(Txtedad.Text),
                .Dirreccion = Txtdireccion.Text,
                .Telefono = Decimal.Parse(Txttelefono.Text),
                .Correo = Txtcorreo.Text
            }
            Dim resultado As String = dbClientrepo.UpdateClientes(IDClients.Value, newcliente)
            LblMensaje.Text = resultado
            IDClients.Value = ""
            GvClientes.DataBind()

        End If



    End Sub
End Class