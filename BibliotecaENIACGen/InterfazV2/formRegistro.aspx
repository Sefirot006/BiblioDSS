<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formRegistro.aspx.cs" Inherits="InterfazV2.formRegistro" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click">Iniciar sesión</asp:LinkButton> 
        </div>
        <div id = "general" align="center">

        <div id = "contenido_login">
            <table>
                <tr>
                    <td align="center" rowspan="1" style="font-size: 18px"> Crear una cuenta nueva </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> DNI/NIE del usuario: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtId" runat="server" Width="300px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Nombre: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtNombre" runat="server" Width="300px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Apellidos: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtApellidos" runat="server" Width="300px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Correo electrónico: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Teléfono: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtTelefono" runat="server" Width="300px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Contraseña: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtPass" runat="server" Width="300px" TextMode="Password"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Confirmar contraseña: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtPass1" runat="server" Width="300px" TextMode="Password"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="center"> 
                        <asp:Label ID="labelError" runat="server" Text="" ForeColor="Red" Visible="false"> </asp:Label> </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnAceptar" runat="server" 
                            Text="Crear usuario" Width="150px" onclick="btnAceptar_Click"/>
                    </td>
                </tr>
            </table>
        
        </div>
    
    </div>    
    </asp:Panel>

</asp:Content>