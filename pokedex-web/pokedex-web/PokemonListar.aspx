<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PokemonListar.aspx.cs" Inherits="pokedex_web.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lista de pokemons</h1>
    <div class="col-3">
        <div class="mb-3">
            <label text="Filtrar" runtar="server">Filtrar</label>
            <asp:TextBox ID="Filtro" runat="server" AutoPostBack="true" OnTextChanged="Filtro_TextChanged" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="col-3">
        <div class="mb-3">
            <asp:Button runat="server" ID="btnLimpiarFiltro" OnClick="btnLimpiarFiltro_Click" Text="Limpiar Filtro" />
        </div>
    </div>
    <div class="col-6">
        <div class="mb-3">
            <asp:CheckBox Text="Filtro Avanzado" CssClass="" ID="chkAvanzado"
                runat="server" AutoPostBack="true"
                OnCheckedChanged="chkAvanzado_CheckedChanged" />
        </div>
    </div>
    <%if (chkAvanzado.Checked)
        {%>
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label runat="server" ID="label1" Text="campo" />
                <asp:DropDownList runat="server" AutoPostBack="true" CssClass="form-control" ID="ddlCampo" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged">
                    <asp:ListItem Text="Nombre" />
                    <asp:ListItem Text="Tipo" />
                    <asp:ListItem Text="Número" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label runat="server" ID="Label2" Text="Criterio" />
                <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCriterio">
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label runat="server" ID="Label3" Text="Filtro" />
                <asp:TextBox runat="server" ID="txtFiltroAvanzado" CssClass="form-control" />
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label runat="server" ID="Label4" Text="Estado" />
                <asp:DropDownList runat="server" CssClass="form-control" ID="ddlEstado">
                    <asp:ListItem Text="Todos" />
                    <asp:ListItem Text="Activo" />
                    <asp:ListItem Text="Inactivo" />
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-3">
            <asp:Button Text="Buscar" runat="server" CssClass="btn btn-primary" ID="btnBuscar" OnClick="btnBuscar_Click" />
        </div>
    </div>
    <% }%>
    <div class="mb-3">
        <asp:GridView ID="dgvpokemons" runat="server" CssClass="table"
            AutoGenerateColumns="false" DataKeyNames="Id"
            OnSelectedIndexChanged="dgvPokemos_SelectIndexChanged"
            OnPageIndexChanging="dgvPokemons_PageIndexChanging" AllowPaging="true" PageSize="4">
            <Columns>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
                <asp:BoundField HeaderText="Debilidad" DataField="Debilidad.Descripcion" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:CheckBoxField HeaderText="Activo" DataField="Activo" />
                <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="✏️" />
            </Columns>
        </asp:GridView>
        <a href="FormularioPokemon.aspx" class="btn btn-primary">Agregar</a>
    </div>
</asp:Content>
