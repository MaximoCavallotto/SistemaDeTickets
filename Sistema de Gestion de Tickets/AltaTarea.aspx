<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AltaTarea.aspx.cs" Inherits="Sistema_de_Gestion_de_Tickets.AltaTarea" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-5">
        <div class="row justify-content-center">
            <div class="col-md-8 col-lg-6">
                <div class="p-4 border rounded shadow" style="border: 2px solid red; background-color: #D4C3C3; color: white; text-shadow: -1px 2px 6px rgba(0,0,0,1);">

                    <h1 class="text-center mb-4">Crear nueva tarea</h1>

                    <div class="mb-3">
                        <asp:Label Text="Nombre:" ID="lblNombre" CssClass="form-label" runat="server" />
                        <asp:TextBox ID="txtboxNombre" CssClass="form-control" runat="server" />
                    </div>

                    <div class="mb-3">
                        <asp:Label Text="Descripción:" ID="lblDescripcion" CssClass="form-label" runat="server" />
                        <asp:TextBox runat="server" CssClass="form-control" ID="txtboxDescripcion" TextMode="MultiLine" Rows="4" />
                    </div>

                    <div class="d-grid">
                        <asp:Button ID="btnGuardarTarea" runat="server" OnClick="btnGuardarTarea_Click" Text="Guardar Tarea" CssClass="btn btn-light" />
                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
