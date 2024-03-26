<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="LoginEjemplo.aspx.cs" Inherits="pokedex_web.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-6"></div>
        <div class="mb-3">
            <label for="lblUsuario" class="form-label">Usuario</label>
            <asp:TextBox runat="server" Cssclass="form-control" ID="txtUsuario"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="lblPassword" class="form-label">Password</label>
            <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" Type="password"></asp:TextBox>
        </div>
           <asp:Button runat="server" ID="btnIngresar" OnClick="btnIngresar_Click" Text="Ingresar"/>
</asp:Content>
