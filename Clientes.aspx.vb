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

    Protected Sub GvClientes_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim index = GvClientes.SelectedIndex
        Dim IdClientet As Integer = Convert.ToInt32(GvClientes.SelectedDataKey.Value)

        If index >= 0 Then
            Dim row = GvClientes.Rows(index)
            Dim Prodcus As New Persona With {
                .Nombre = row.Cells(2).Text,
                .Apellido = row.Cells(3).Text,
                .Edad = row.Cells(4).Text,
                .Dirreccion = row.Cells(5).Text,
                .Telefono = row.Cells(6).Text,
                .Correo = row.Cells(7).Text
            }
            IdClientet = row.Cells(1).Text

            ' Asignar los valores de las celdas a los controles del formulario
            TxtNombre.Text = Prodcus.Nombre


        End If
    End Sub

    Protected Sub GvClientes_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id As Integer = Convert.ToInt32(GvClientes.DataKeys(e.RowIndex).Value)
        Dim resultado As String = dbClientrepo.EliminarCliente(id)
        ' Mostrar el mensaje de resultado en la etiqueta LblMensaje
        LblMensaje.Text = resultado
        e.Cancel = True
        GvClientes.DataBind()
    End Sub
End Class