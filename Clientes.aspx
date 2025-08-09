<%@ Page Title="Mantenimientos de clientes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Clientes.aspx.vb" Inherits="ClientesCrudWebForms.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:HiddenField ID="IDClients" runat="server" />
    <div class="row mb-3">
    <div class="col-md-4">
        <h2>Lista de clientes</h2>
    <asp:GridView ID="GvClientes" runat="server" AllowPaging="True"
         OnSelectedIndexChanged="GvClientes_SelectedIndexChanged"
         OnRowDeleting="GvClientes_RowDeleting"
         AllowSorting  ="True" AutoGenerateColumns="False" DataKeyNames="ClienteID"
         DataSourceID  ="SqlDataSource" Width="819px">
       <Columns>
          <asp:CommandField ShowSelectButton="True"></asp:CommandField>
          <asp:BoundField DataField="clienteID" HeaderText="ClienteID" InsertVisible="False" ReadOnly="True" SortExpression="ClienteID" />
          <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
          <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
          <asp:BoundField DataField="edad" HeaderText="edad" SortExpression="edad" />
          <asp:BoundField DataField="dirreccion" HeaderText="dirreccion" SortExpression="dirreccion" />
          <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
          <asp:BoundField DataField="correo" HeaderText="correo" SortExpression="correo" />
          <asp:CommandField ShowDeleteButton="True" />
       </Columns>
     </asp:GridView>

   <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:Conexion %>"
    SelectCommand="SELECT * FROM [Clientes]">
   </asp:SqlDataSource>

        <h3>Formulario</h3>

       <div class="form-group mb-3">
            <label for="TxtNombre">nombre</label>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
       </div>

        <div class="form-group mb-3">
             <label for="Txtapellido">apellido</label>
             <asp:TextBox TextMode="Number" ID="Txtapellido" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group mb-3">
            <label for="Txtedad">edad</label>
            <asp:TextBox ID="Txtedad" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group mb-3">
           <label for="Txtdirreccion">dirreccion</label>
           <asp:TextBox ID="Txtdireccion" runat="server" CssClass="form-control"></asp:TextBox>
       </div>

        <div class="form-group mb-3">
           <label for="Txttelefono">telefono</label>
           <asp:TextBox ID="Txttelefono" runat="server" CssClass="form-control"></asp:TextBox>
       </div>

        <div class="form-group mb-3">
          <label for="Txtcorreo">correo</label>
          <asp:TextBox ID="Txtcorreo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        </div>

        <div class="form-group">
            <asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        </div>

        <div class="form-group mb-3">
            <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
        </div>
    </div>

</div>

</asp:Content>
