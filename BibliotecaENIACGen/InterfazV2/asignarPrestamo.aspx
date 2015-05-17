<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="asignarPrestamo.aspx.cs" Inherits="InterfazV2.asignarPrestamo" %>

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
                    OnClick="asignarPrestamo1"/>
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
    <asp:Panel ID="PanelPASModDown"  runat="server" style="top:300px;">
        <div id="Div1">
        <br>
        <br>
            <asp:Label ID="DNI"  runat="server" Text="DNI/NIE: "></asp:Label>
            <asp:TextBox ID="DNIInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
            <br>
            <br>
            <asp:Label ID="Isbn"  runat="server" Text="ISBN:&nbsp&nbsp&nbsp&nbsp&nbsp "></asp:Label>
            <asp:TextBox ID="IsbnInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
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


        </div>

    </asp:Panel>
    <asp:Panel ID ="PanelModObraBuscada" runar="server" style="top:100px;">
     
            
            
    </asp:Panel>
</asp:Content>