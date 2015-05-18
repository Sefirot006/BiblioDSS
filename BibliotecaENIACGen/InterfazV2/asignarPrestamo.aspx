<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="asignarPrestamo.aspx.cs" Inherits="InterfazV2.asignarPrestamo" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="PanelPASMod"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click1">Iniciar sesión</asp:LinkButton> 
        </div>
        <div>
          <br>
            <br>
            <br></br>
            <asp:Button ID="asignarprestamo" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="asignarPrestamo1" Style="color: #DDE4EC" Text="Asignar Prestamo" 
                Width="150px" />
            </asp:button>
            <asp:Button ID="altaobra" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="nuevaObra" Style="color: #DDE4EC" Text="Nueva obra" Width="150px" />
            </asp:button>
            <asp:Button ID="modificarobra" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="modificaObra" Style="color: #DDE4EC" Text="Modificar Obra" 
                Width="150px" />
            </asp:button>
            <asp:Button ID="borrarobra" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="borrarObra" Style="color: #DDE4EC" Text="Borrar Obra" Width="150px" />
            </asp:button>
            <asp:Button ID="desideratas" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="verDesideratas" Style="color: #DDE4EC" Text="Desideratas" 
                Width="150px" />
            </asp:button>
            <br></br>
            </br>
        </br>
                 
                
        </div>    
    </asp:Panel>
    <asp:Panel ID="PanelPASModDown"  runat="server" style="top:300px;">
        <div id="Div1">
        <br>
        <br>
            <asp:Label ID="DNI"  runat="server" Text="DNI/NIE:&nbsp "></asp:Label>
            <asp:TextBox ID="DNIInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
            <br>
            <br>
            <asp:Label ID="Isbn"  runat="server" Text="ISBN:&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp "></asp:Label>
            <asp:TextBox ID="IsbnInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
            <br>
            <br>
            <asp:Label ID="Ejemplar"  runat="server" Text="Ejamplar: "></asp:Label>
            <asp:TextBox ID="EjamplarInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="EjmplarRequired" runat="server" ControlToValidate="EjamplarInput" 
                                     CssClass="failureNotification" ErrorMessage="Es necesario el ejemplar." ToolTip="Es necesario el ejemplar." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
            
            <br>
            <br>
            <asp:Button ID="confirmar"  
                runat="server"
                Width  = 150px
                Height = 30px
                Style="color: #DDE4EC" 
                    
                BorderColor = "#4E667D"
                BorderStyle = "Solid"
                BorderWidth = "3px"
                BackColor="#465C71"
                runat="server"
                Text="Confirmar"
                OnClick="confirmarPrestamo"/>
            </asp:Button>
            <asp:Button ID="eliminar"  
                runat="server"
                Width  = 150px
                Height = 30px
                Style="color: #DDE4EC" 
                    
                BorderColor = "#4E667D"
                BorderStyle = "Solid"
                BorderWidth = "3px"
                BackColor="#465C71"
                runat="server"
                Text="Retirar Préstamo"
                OnClick="eliminarPrestamo"/>
            </asp:Button>  


        </div>

    </asp:Panel>
    <asp:Panel ID ="PanelModObraBuscada" runar="server" style="top:100px;">
     
            
            
    </asp:Panel>
</asp:Content>