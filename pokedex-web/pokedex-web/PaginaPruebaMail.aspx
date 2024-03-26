<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="PaginaPruebaMail.aspx.cs" Inherits="pokedex_web.PaginaPruebaMail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <label class="form-label">Email</label>
                <asp:Textbox runat="server" ID="txtEmail" cssclass="form-control" />
            </div>
            <div class="mb-3">
                <label class="form-label">Asunto</label>
                <asp:Textbox runat="server" ID="txtAsunto" cssclass="form-control" />
            </div>
            <div class="mb-3">
                <label class="form-label">Mensaje</label>
                <asp:TextBox TextMode="MultiLine" runat="server" ID="txtMensaje" cssclass="form-control" />
            </div>
            <asp:Button Text="Aceptar" CssClass="btn btn-primary"  ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" />
        </div>
        <div class="col"></div>
    </div>
</asp:Content>
