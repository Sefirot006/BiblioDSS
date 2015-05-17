<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="misDatos.aspx.cs" Inherits="InterfazV2.misDatos" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="PanelUsuario"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click">Iniciar sesión</asp:LinkButton> 
        </div>
        <div>
            <br>
            <br></br>
            <asp:Button ID="hacerreserva" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                onclick="hacerreserva_Click" Style="color: #DDE4EC" Text="Hacer Reservas" 
                Width="150px" />
            </asp:button>
            <asp:Button ID="misreservas" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                onclick="misreservas_Click" Style="color: #DDE4EC" Text="Mis Reservas" 
                Width="150px" />
            </asp:button>
            <asp:Button ID="misprestamos" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                onclick="misprestamos_Click" Style="color: #DDE4EC" Text="Mis Prestamos" 
                Width="150px" />
            </asp:button>
            <asp:Button ID="misdatos" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                onclick="misdatos_Click" Style="color: #DDE4EC" Text="Mis Datos" 
                Width="150px" />
            </asp:button>
            <asp:Button ID="desideratas" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="hacerDesideratas" Style="color: #DDE4EC" Text="Desideratas" 
                Width="150px" />
            </asp:button>
        </br>
                
        </div>    
    </asp:Panel>
    
    <asp:Panel ID="Panel1"  runat="server">
        
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
                        <asp:Button ID="btnAceptar" runat="server" Text="Mostrar" Width="81px" 
                            onclick="btnAceptar_Click"/>
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" Width="81px" 
                            onclick="btnModificar_Click"/>
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
                            Visible="false" onclick="btnConfirmar_Click"/>
                    </td>
                </tr>

            </table>
        
        </div>
    
    </div>    
    </asp:Panel>

</asp:Content>