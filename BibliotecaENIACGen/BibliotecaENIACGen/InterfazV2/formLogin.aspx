<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formLogin.aspx.cs" Inherits="InterfazV2.formLogin" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Panel ID="Panel1"  runat="server" >
        <div id = "general" align="center">
        <div id = "contenido_login" >
        <fieldset class="login" >
                <legend>Información de cuenta</legend>
            <table>
            
            
                <tr>
                    <td align="center" rowspan="1" style="font-size: 18px"> Inicio de Sesión </td>
                </tr> 
                
                <tr>
                    <td colspan="2" align="left"> Usuario: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtUsuario" runat="server" Width="300px"> </asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Password: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtPass" runat="server" Width="300px" TextMode="Password"></asp:TextBox> </td>
                </tr>
      
                <tr>
                    <td colspan="2" align="center"> 
                        <asp:Label ID="labelError" runat="server" Text="" ForeColor="Red" Visible="false"> </asp:Label> </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnAceptar" runat="server" 
                            Text="Aceptar" Width="100px" onclick="btnAceptar_Click"/>
                    </td>
                </tr>
                <tr>
                    <td align="left" rowspan="1" style="font-size: 14px"> 
                        <asp:LinkButton ID="linkRegistro" runat="server" onclick="linkOut_Click"> Registrarse</asp:LinkButton> si no tiene una cuenta. </td> 
                </tr>
            
            </table>
          </fieldset>
        </div>
        </div>    
    </asp:Panel>
</asp:Content>