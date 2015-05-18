<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.master"  CodeBehind="zonaDirector.aspx.cs" Inherits="InterfazV2.zonaDirector" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="PanelDirector"  runat="server">
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
    </asp:Panel>
    <asp:Panel ID="PanelDirectorDown"  runat="server" style="top:300px;">
        <div id="Div1">
            
        </div>
    </asp:Panel>
</asp:Content>

