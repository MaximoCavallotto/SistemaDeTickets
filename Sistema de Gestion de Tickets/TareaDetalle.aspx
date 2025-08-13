<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TareaDetalle.aspx.cs" Inherits="Sistema_de_Gestion_de_Tickets.TareaDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mb-3">
        <asp:Label Id="lblNombre" Text="" runat="server" />
        <asp:Button Text="Modificar" ID="btnModificarTitulo" runat="server" />
        <asp:DropDownList ID="ddlEstado" runat="server">
        </asp:DropDownList>
    </div>
    <div class="mb-3">   
        <asp:Label Id="lblDescripcion" Text="" runat="server" />
        <asp:Button Text="Modificar" ID="btnModificarDescripcion" runat="server" />
    </div>
    <div>   
        <asp:GridView runat="server" ID="dgvSubTareas" CssClass="table table-dark">

        </asp:GridView>
    </div>
</asp:Content>
