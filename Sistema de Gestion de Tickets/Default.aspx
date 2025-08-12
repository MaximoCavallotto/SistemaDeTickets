<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sistema_de_Gestion_de_Tickets.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="d-flex justify-content-center align-items-center min-vh-100" >

            <div class="w-100 p-4 border rounded shadow" style="border: 2px solid red; background-color: #90D5F5; color: white; text-shadow: -1px 2px 6px rgba(0,0,0,1); max-width: 400px;">
                <div class="mb-3 text-center">
                    <h1>Bienvenido</h1>
                </div>
                <div class="mb-3">
                    <asp:Label runat="server" AssociatedControlID="txtboxUsuario" CssClass="form-label">Usuario</asp:Label>
                    <asp:TextBox ID="txtboxUsuario" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <asp:Label runat="server" AssociatedControlID="txtboxContraseña" CssClass="form-label">Contraseña</asp:Label>
                    <asp:TextBox ID="txtboxContraseña" TextMode="Password" runat="server" CssClass="form-control" />
                </div>
                <div class="d-flex justify-content-center align-items-center">
                    <asp:Label CssClass="form-label" color="Red" Text="Usuario o contraseña incorrecta..." Visible="false" ID="lblLogFalla" runat="server" />
                </div>
                <div class="d-flex justify-content-center align-items-center">
                    <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnIngresar" OnClick="btnIngresar_Click" runat="server" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>
