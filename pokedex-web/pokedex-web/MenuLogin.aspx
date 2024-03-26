<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MenuLogin.aspx.cs" Inherits="pokedex_web.MenuLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12">
            <h3>Te logeaste correctamente </h3>
            <hr />
        </div>
        <div class="col-4">
            <asp:Button text="Página 1" runat="server" Id="btnpagina1" CssClass="btn btn-primary"  OnClick="btnpagina1_Click"/>
        </div>
        <div class="col-4">
            <%if ((Session["Usuario"]!= null) && (((dominio.Usuario)Session["Usuario"]).TipoUsuario == dominio.TipoUsuario.ADMIN))
                {%>
            <asp:Button text="Página 2" runat="server" Id="btnpagina2" CssClass="btn btn-primary"  OnClick="btnpagina2_Click"/>
            <p>tenes que ser admin</p>
            <% }%>
        </div>
    </div>
</asp:Content>
