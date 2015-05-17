<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="misPrestamos.aspx.cs" Inherits="InterfazV2.misPrestamos" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
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
                    <td align="center" rowspan="1" style="font-size: 20px"> DATOS PERSONALES </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> Nombre: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtNombre" runat="server" Width="250px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Apellidos: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtApellidos" runat="server" Width="250px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Teléfono: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtTelefono" runat="server" Width="250px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Email: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtEmail" runat="server" Width="250px"></asp:TextBox> </td>
                </tr>
                
                <tr>
                    <td colspan="2" align="center"> 
                        <asp:Label ID="labelError" runat="server" Text="" ForeColor="Red" Visible="false"> </asp:Label> </td>
                </tr>

                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnAceptar" runat="server" Text="Mostrar" Width="81px"/>
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" Width="81px"/>
                        <asp:Button ID="btnBorrar" runat="server" Text="Eliminar" Width="81px"/>
                    </td>
                </tr>

                <tr>
                    <td colspan="2" align="center"> 
                        <asp:Label ID="labelConfirmar" runat="server" Text="Indroduce tu password" ForeColor="Red" Visible="false"> </asp:Label> </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtPass" runat="server" Width="250px" Visible="false" TextMode="Password"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" Width="120px" 
                            Visible="false"/>
                    </td>
                </tr>

            </table>
        
        </div>
    
    </div>    
    </asp:Panel>

</asp:Content>