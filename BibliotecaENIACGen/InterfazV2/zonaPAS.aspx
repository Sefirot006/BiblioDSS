<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="zonaPAS.aspx.cs" Inherits="InterfazV2.zonaPAS" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="PanelPAS"  runat="server">
        <div>
        </br>
                 <asp:Button ID="asignarprestamo"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Asignar Prestamo"
                    OnClick="asignarPrestamo"/>
                 </asp:Button>
                 <asp:Button ID="altaobra"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Nueva obra"
                    OnClick="nuevaObra"/>
                 </asp:Button>
                 <asp:Button ID="modificarobra"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Modificar Obra"
                    OnClick="modificarObra"/>
                 </asp:Button>
                  <asp:Button ID="borrarobra"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Borrar Obra"
                    OnClick="borrarObra"/>
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
                    OnClick="verDesideratas"/>
                 </asp:Button>
                 
                
        </div>    
    </asp:Panel>
    <asp:Panel ID="PanelPASDown"  runat="server" style="top:300px;">
        <div id="Div1">
            
        </div>
    </asp:Panel>
</asp:Content>

