﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="misPrestamos.aspx.cs" Inherits="InterfazV2.misPrestamos" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="PanelUsuario"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click">Iniciar sesión</asp:LinkButton> 
        </div>
        <div>
        </br>
                 <asp:Button ID="hacerreserva"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Hacer Reservas"
                    OnClick="hacerReservas"/>
                 </asp:Button>
                <asp:Button ID="misreservas"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Mis Reservas"
                    OnClick="mostrarReservas"/>
                 </asp:Button>
                 <asp:Button ID="misprestamos"  
                    runat="server"
                   Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Mis Prestamos"
                    OnClick="misPrestamos"/>
                 </asp:Button>
                 <asp:Button ID="misdatos"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Mis Datos"
                    OnClick="misDatos"/>
                 </asp:Button>

                  <asp:Button ID="desideratas"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Desideratas"
                    OnClick="hacerDesideratas"/>
                 </asp:Button>
                
        </div>    
    </asp:Panel>
    <asp:Panel ID="PanelUsuarioDown"  runat="server" style="top:300px;">
        <div id="Div1">
            
        </div>
    </asp:Panel>
</asp:Content>