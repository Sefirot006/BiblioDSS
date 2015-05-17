<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="desideratas.aspx.cs" Inherits="InterfazV2.desideratas" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="PanelPASDesi"  runat="server">
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
                <asp:Button ID="desideratas1"  
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
    <asp:Panel ID="PanelPASDesiDown"  runat="server" style="top:300px;">
        <div id="Div1">
          <br>
        <br>
         <asp:Label ID="desi"  runat="server" Text="Nº Desiderata: "></asp:Label>
            <asp:TextBox ID="desiInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
        <br>
        <br>
             <asp:Label ID="email"  runat="server" Text="Correo PAS:&nbsp&nbsp&nbsp&nbsp "></asp:Label>
            <asp:TextBox ID="emailInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
        <br>
        <br>
             <asp:Label ID="pass"  runat="server" Text="Contraseña:&nbsp&nbsp&nbsp&nbsp "></asp:Label>
            <asp:TextBox ID="passInput"  runat="server" MaxLength="100"  style="width:200px" TextMode="Password" ></asp:TextBox>
            <br>
        <br>
        <asp:Button ID="AceptarDesiderata"  
                    runat="server"
                    Width  = 150px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Aceptar"
                    OnClick="aceptarDesiderata"/>
                 </asp:Button>
          
           <asp:Button ID="ListarDesideratasNo"  
                    runat="server"
                    Width  = 250px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="Listar desideratas por aceptar"
                    OnClick="listarDesideratasFalse"/>
                 </asp:Button>

                
            


        </div>

    </asp:Panel>
    <asp:Panel ID ="PanelDesi" runat="server" style="top:100px;">
     <br>
        <br>
    </asp:Panel>
</asp:Content>