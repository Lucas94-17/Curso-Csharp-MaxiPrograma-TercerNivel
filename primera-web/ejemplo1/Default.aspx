<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ejemplo1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
           <%if (user != "")
               {  %>
            <h2>Bienvenido !</h2>
            <asp:Label Text="Text" ID="lblUser" runat="server"></asp:Label>
            <%}else{ %>
            <h2>Debes Logearte ! </h2>
            <a href="Ejemplo2ConMiMaster">Login</a>
            <%} %>
        </section>
       
    </main>

</asp:Content>
