﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="pokedex_web.MiPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .Validacion {
            font-size: 12px;
            color: red;
        }
    </style>
    <script>
        function validar() {
            const txtApellido = document.getElementById("txtApellido");
            const txtNombre = document.getElementById("txtNombre");
            if (txtApellido.value == "") {
                txtApellido.classList.add("is-invalid");
                txtApellido.classList.remove("is-valid");
                txtNombre.classList.add("is-valid");
                return false;
            }
            txtApellido.classList.remove("is-invalid");
            txtApellido.classList.add("is-valid");
            return true;
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Mi Perfil</h1>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label class="form-label">Email</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Nombre</label>
                <asp:TextBox runat="server" CssClass="form-control" ClientIDMode="Static" ID="txtNombre" />
                <%--<asp:RequiredFieldValidator runat="server" CssClass="Validacion" ErrorMessage="El nombre es requerido" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>--%>
            </div>
            <div class="mb-3">
                <label class="form-label">Apellido</label>
                <asp:TextBox ID="txtApellido" ClientIDMode="Static" runat="server" CssClass="form-control" MaxLength="8">
                </asp:TextBox>
                <%--<asp:RangeValidator ErrorMessage="Fuera de rango" Type="Integer" MinimumValue="1" MaximumValue="20" ControlToValidate="txtApellido" runat="server" />--%>
                <%--<asp:RegularExpressionValidator ErrorMessage="Solo numeros !" ControlToValidate="txtApellido" ValidationExpression="^[0-9]+$" runat="server" />--%>
            </div>
            <div class="mb-3">
                <label class="form-label">Fecha de Nacimiento</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtFechaNacimiento" TextMode="date"></asp:TextBox>
            </div>

        </div>
        <div class="col-md-4">
            <div class="mb-3">
                <label class="form-label">Imagen de Perfil</label>
                <input id="txtImagen" class="form-input" type="file" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Image ID="imgNuevoPerfil" runat="server" CssClass="img-fluid mb-3"
                    ImageUrl="https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <asp:Button Text="Guardar" CssClass="btn btn-primary" OnClientClick="return validar()" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" />
            <a href="/" class="btn btn-danger">Regresar</a>
        </div>
    </div>
</asp:Content>
