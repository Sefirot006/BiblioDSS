<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="borrarObra.aspx.cs" Inherits="InterfazV2.borrarObra" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="PanelPASMod"  runat="server">
        <div>
          <br>
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
                    OnClick="modificaObra"/>
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
                    OnClick="borrarObra1"/>
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
    <asp:Panel ID="PanelPASModDown"  runat="server" style="top:300px;">
        <div id="Div1">
        <br>
        <br>
            <asp:Label ID="busqueda"  runat="server" Text="Buscar por ISBN: "></asp:Label>
            <asp:TextBox ID="busquedaInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
            <asp:Button ID="busquedaIsbn"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Buscar"
                    OnClick="buscarObraIsbn"/>
                 </asp:Button>
                 <asp:Button ID="borrar"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    runat="server"
                    Text="Borrar Obra"
                    OnClick="BorrarObraPorIsbn"/>
                 </asp:Button> 


        </div>

    </asp:Panel>
    <asp:Panel ID ="PanelModObraBuscada" runar="server" style="top:100px;">
     
            
            
    </asp:Panel>
</asp:Content>