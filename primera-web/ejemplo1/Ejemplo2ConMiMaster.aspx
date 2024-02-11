<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Ejemplo2ConMiMaster.aspx.cs" Inherits="ejemplo1.Ejemplo2ConMiMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hola como estas</h1>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtPass" runat="server"  Type ="password"></asp:TextBox>
    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>    
</asp:Content>
