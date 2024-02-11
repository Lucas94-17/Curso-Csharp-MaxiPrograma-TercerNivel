<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="AutoForm.aspx.cs" Inherits="Ejemplo_Formulario.AutoForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centrar">
        <div class="col-6">
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Modelo</label>
                <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control" For="txtModelo" />
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" CssClass="form-control"  />
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Color</label>
                <asp:DropDownList ID="ddlistColor" runat="server" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Fecha</label>
                <asp:TextBox runat="server" ID="txtFecha" TextMode="Date" CssClass="form-control"  />
                
            </div>
            <div>
                <asp:CheckBox Text="Usado" runat="server" OnCheckedChanged="checkUsado_CheckedChanged" ID="checkUsado" CssClass="form-check-input" />
            </div>
            <div>
                <asp:RadioButton Text="Importado" ID="rdbimportado" runat="server"  GroupName="Importado"/>
                <asp:RadioButton Text="Nacional" ID="rdbNacional" Checked="True" runat="server" GroupName="Importado"/>
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server"  />
                <a href="Default.aspx">Cancelar</a>
            </div>
        </div>
    </div>
</asp:Content>
