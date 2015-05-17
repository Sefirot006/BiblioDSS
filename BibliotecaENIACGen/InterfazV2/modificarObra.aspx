<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="modificarObra.aspx.cs" Inherits="InterfazV2.modificarObra" %>

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


        </div>

    </asp:Panel>
    <asp:Panel ID ="PanelModObraBuscada" runar="server" style="top:100px;">
     <br>
        </br>
     <asp:Label ID="titol"  runat="server" Text="Título:&nbsp&nbsp&nbsp&nbsp&nbsp "></asp:Label>
           <asp:TextBox ID="titolInput"  runat="server" MaxLength="100"  style="width:400px" ></asp:TextBox>
            <br>
        </br>
          
           <asp:Label ID="isbn"  runat="server" Text="ISBN:&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp "></asp:Label>
           <asp:TextBox ID="isbnInput"  runat="server" MaxLength="100"  style="width:400px" ></asp:TextBox>
            <br>
        </br>
         
           <asp:Label ID="paginas"  runat="server" Text="Páginas:&nbsp&nbsp "></asp:Label>
           <asp:TextBox ID="paginasInput"  runat="server" MaxLength="100"  style="width:400px" ></asp:TextBox>
            <br>
        </br>
            
           <asp:Label ID="anyo"  runat="server" Text="Año:&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp "></asp:Label>
           <asp:TextBox ID="anyoInput"  runat="server" MaxLength="100"  style="width:400px" ></asp:TextBox>
            <br>
        </br>
           
           <asp:Label ID="img"  runat="server" Text="Ruta Img: "></asp:Label>
           <asp:TextBox ID="imgInput"  runat="server" MaxLength="100"  style="width:400px" ></asp:TextBox>  

           <br>
        </br>
            
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
                    OnClick="confirmarModificacionObra"/>
                 </asp:Button>  
    </asp:Panel>
</asp:Content>