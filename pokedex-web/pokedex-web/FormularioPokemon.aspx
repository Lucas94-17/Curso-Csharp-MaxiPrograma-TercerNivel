<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FormularioPokemon.aspx.cs" Inherits="pokedex_web.FormularioPokemon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="IdPokemon" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="NumeroPokemon" class="form-label">Numero</label>
                <asp:TextBox runat="server" ID="txtNumero" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="NombrePokemon" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="ddlTipo" class="form-label">Tipo : </label>
                <asp:DropDownList runat="server" ID="dropTipo" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="ddlDebilidad" class="form-label">Debilidad : </label>
                <asp:DropDownList runat="server" ID="dropDebilidad" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="PokemonListar.aspx" class="btn btn-secondary">Cancelar</a>
                <%if (botonEliminacion)
                    {  %>
                <asp:Button runat="server" Text="Desactivar" ID="btnDesactivar" OnClick="btnDesactivar_Click" CssClass="btn btn-warning" />
                <%} %>
            </div>
        </div>

        <div class="col-6">
            <div class="col-3">
                <label for="txtDescripcion" cssclass="form-label">Descripcion : </label>
                <asp:TextBox runat="server" TextMode="Multiline" ID="txtDescripcion" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="txtImagenUrl" class="form-label">Url Imagen </label>
                        <asp:TextBox runat="server" ID="txtimagenUrl" CssClass="form-control"
                            AutoPostBack="true" OnTextChanged="txtimagenUrl_TextChanged"></asp:TextBox>
                    </div>
                    <asp:Image runat="server" ID="imgPokemon" Width="60%" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <div class="row">
        <div class="col-6">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <%if (botonEliminacion)
                        {  %>
                    <div class="mb-3">
                        <asp:Button Text="Eliminar" ID="ButtonEliminar" CssClass="btn btn-danger" OnClick="ButtonEliminar_Click" runat="server" />
                    </div>
                    <%} %>
                    <%if (ConfimarEliminacion)
                        {%>
                    <div class="mb-3">
                        <asp:CheckBox Text="Confirmar Eliminacion" ID="CheckConfirmarEliminacion" runat="server" />
                        <asp:Button Text="Eliminar" ID="btnConfirmaEliminar" CssClass="btn btn-outline-danger" OnClick="btnConfirmaEliminar_Click" runat="server" />
                    </div>
                    <%} %>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
