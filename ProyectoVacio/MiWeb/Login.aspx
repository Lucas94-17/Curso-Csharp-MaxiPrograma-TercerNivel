<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MiWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
  
  <div class="col-2"></div>
    <div class="col">
        <div class="mb-3">
      <label for="exampleInputEmail1" class="form-label">Email address</label>
        <asp:TextBox runat="server" ID="txtEmail" type="email" CssClass="form-control"></asp:TextBox>
      <%--<input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">--%>
      <%--<div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>--%>
    </div>
    <div class="mb-3">
      <label for="exampleInputPassword1" class="form-label">Password</label>
      <%--<input type="password" class="form-control" id="exampleInputPassword1">--%>
        <asp:TextBox runat="server" type="password" CssClass="form-control"/>
    </div>
    <div class="mb-3 form-check">
    </div>
    <%--<button type="submit" class="btn btn-primary">Submit</button>--%>
        <asp:Button Text="Ingresar" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" CssClass="btn btn-primary"/>
        <asp:Button Text="Reset" />
    </div>
   <div class="col-2"></div>
</asp:Content>
