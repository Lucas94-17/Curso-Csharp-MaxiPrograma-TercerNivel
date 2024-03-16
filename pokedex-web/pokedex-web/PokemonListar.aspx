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
    <br />
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label runat="server" ID="ddlcampo" Text="campo" />
                <asp:DropDownList runat="server" CssClass="form-control">
                    <asp:ListItem Text="Nombre" />
                    <asp:ListItem Text="Tipo" />
                    <asp:ListItem Text="Numero" />
                </asp:DropDownList>
            </div>
        </div>
    </div>
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
