<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="prestamosChequear.aspx.cs" Inherits="InterfazV2.prestamosChequear" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="Panel3"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click">Iniciar sesión</asp:LinkButton> 
        </div>
         <div>
        </br>
                 <asp:Button ID="altapas"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Alta PAS"
                    OnClick="altaPas"/>
                 </asp:Button>

                 <asp:Button ID="bajapas"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Baja PAS"
                    OnClick="bajaPas"/>
                 </asp:Button>
                  <asp:Button ID="nuevodirector"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Nuevo Director"
                    OnClick="nuevoDirector"/>
                 </asp:Button>
                  <asp:Button ID="checkprestamos"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Check Prestamos"
                    OnClick="checkPrestamos"/>
                 </asp:Button>
                
                
        </div>    
        <br />
        <br />
         <asp:Label ID="email"  runat="server" Text="Correo PAS:&nbsp&nbsp&nbsp&nbsp "></asp:Label>
            <asp:TextBox ID="emailInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
        <br>
        <br>
             <asp:Label ID="pass"  runat="server" Text="Contraseña:&nbsp&nbsp&nbsp&nbsp "></asp:Label>
            <asp:TextBox ID="passInput"  runat="server" MaxLength="100"  style="width:200px" TextMode="Password" ></asp:TextBox>
            <br>
        <br>
         <asp:Button ID="check"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Iniciar Checkeo"
                    OnClick="enviar_notificacion_click"/>
                 </asp:Button>

    </asp:Panel>
    <asp:Panel ID="PanelmiZona"  runat="server" style="top:300px;">
        <div id="Div1">
            
        </div>
    </asp:Panel>
</asp:Content>



