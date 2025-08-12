<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Panel.aspx.cs" Inherits="Sistema_de_Gestion_de_Tickets.Panel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center">
        <h1>Tu lista de tareas.</h1>
    </div>
    <div class="container my-5" style="max-width: 700px;">
        <div class="row justify-content-center gx-3 gy-4">
            <asp:Repeater ID="repRepetidor" runat="server">
                <ItemTemplate>
                    <div class="col-md-4 d-flex justify-content-center">
                        <div class="card border-success w-100 h-100" style="max-width: 14rem;">
                            <div class="card-header">Header</div>
                            <div class="card-body text-success d-flex flex-column">
                                <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                <p class="card-text"><%# Eval("Descripcion") %></p>
                            </div>
                            <div class= "d-grid gap-2 col-6 mx-auto mb-2">   
                                <asp:Button CssClass="btn btn-outline-success" OnClick="btnVerTarea_Click" Text="Ver Tarea" ID="btnVerTarea" CommandArgument='<%# Eval("Id") %>' runat="server" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
