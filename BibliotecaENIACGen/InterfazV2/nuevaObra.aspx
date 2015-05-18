﻿<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="nuevaObra.aspx.cs" Inherits="InterfazV2.nuevaObra" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="PanelPAS"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click">Iniciar sesión</asp:LinkButton> 
        </div>
        <div>
            <br>
            <asp:Button ID="asignarprestamo" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="asignarPrestamo" Style="color: #DDE4EC" Text="Asignar Prestamo" 
                Width="150px" />
            </asp:button>
            <asp:Button ID="altaobra" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="newObra" Style="color: #DDE4EC" Text="Nueva obra" Width="150px" />
            </asp:button>
            <asp:Button ID="modificarobra" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="modificarObra" Style="color: #DDE4EC" Text="Modificar Obra" 
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
        </br>
                 
                
        </div>    
    </asp:Panel>
    <asp:Panel ID="PanelPASDown"  runat="server" style="top:300px;">
        <div id="Div1">
            <br>
            <br />
            <asp:Label ID="titol" runat="server" 
                Text="Título:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "></asp:Label>
            &nbsp;<asp:TextBox ID="titolInput" runat="server" MaxLength="100" 
                style="width:400px"></asp:TextBox>
            <br>
            <br></br>
            <asp:Label ID="isbn" runat="server" 
                Text="ISBN:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "></asp:Label>
            <asp:TextBox ID="isbnInput" runat="server" MaxLength="100" style="width:400px"></asp:TextBox>
            <br>
            <br></br>
            <asp:Label ID="paginas" runat="server" Text="Páginas:&nbsp;&nbsp; "></asp:Label>
            <asp:TextBox ID="paginasInput" runat="server" MaxLength="100" 
                style="width:400px"></asp:TextBox>
            <br>
            <br></br>
            <asp:Label ID="anyo" runat="server" 
                Text="Año:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "></asp:Label>
            &nbsp;<asp:TextBox ID="anyoInput" runat="server" MaxLength="100" style="width:400px"></asp:TextBox>
            <br>
            <br></br>
            <asp:Label ID="img" runat="server" Text="Ruta Img: "></asp:Label>
            &nbsp;<asp:TextBox ID="imgInput" runat="server" MaxLength="100" style="width:400px"></asp:TextBox>
            <br>
            <br></br>
            <asp:Label ID="autores" runat="server" 
                Text="Autor:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ">
            
            </asp:Label>
            <asp:ListBox ID="ListBox1" runat="server" Rows="6" SelectionMode="Multiple" 
                Width="400px"></asp:ListBox>
            <br>
            <br></br>
            <asp:Label ID="tema" runat="server" Text="Temática: "></asp:Label>
            <asp:ListBox ID="tematica" runat="server" Rows="6" SelectionMode="Multiple" 
                Width="400px"></asp:ListBox>
            <br>
            <br></br>
            <asp:Button ID="confirmar" runat="server" BackColor="#465C71" 
                BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                OnClick="confirmarObra" Style="color: #DDE4EC" Text="Confirmar" Width="150px" />
            </asp:button>
            </br>
            </br>
            </br>
            </br>
            </br>
            </br>
            </br>
        </br>
        </div>
    </asp:Panel>
</asp:Content>
