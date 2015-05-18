<%@ Page Language="C#"  MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="bajaPAS.aspx.cs" Inherits="InterfazV2.bajaPAS" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="Panel3"  runat="server">
         <div>
             <br>
             <asp:Button ID="altapas" runat="server" BackColor="#465C71" 
                 BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                 OnClick="altaPas" Style="color: #DDE4EC" Text="Alta PAS" Width="150px" />
             </asp:button>
             <asp:Button ID="bajapas" runat="server" BackColor="#465C71" 
                 BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                 OnClick="bajaPas" Style="color: #DDE4EC" Text="Baja PAS" Width="150px" />
             </asp:button>
             <asp:Button ID="nuevodirector" runat="server" BackColor="#465C71" 
                 BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                 OnClick="nuevoDirector" Style="color: #DDE4EC" Text="Nuevo Director" 
                 Width="150px" />
             </asp:button>
             <asp:Button ID="checkprestamos" runat="server" BackColor="#465C71" 
                 BorderColor="#4E667D" BorderStyle="Solid" BorderWidth="3px" Height="30px" 
                 OnClick="checkPrestamos" Style="color: #DDE4EC" Text="Check Prestamos" 
                 Width="150px" />
             </asp:button>
             <br></br>
        </br>
                
                
        </div>
         <asp:Label ID="usuPAS"  runat="server" 
             Text="ID de PAS:&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp"></asp:Label>
            <asp:TextBox ID="usuPASInput"  runat="server" MaxLength="100"  style="width:200px" ></asp:TextBox>
        
           
         <asp:Button ID="baja"  
                    runat="server"
                    Width  = 250px
                    Height = 30px
                    Style="color: #DDE4EC" 
                    
                    BorderColor = "#4E667D"
                    BorderStyle = "Solid"
                    BorderWidth = "3px"
                    BackColor="#465C71"
                    
                    Text="ID del usuario a dar de baja como PAS."
                    OnClick="despedir_click"/>
                 </asp:Button>

    </asp:Panel>
    <asp:Panel ID="PanelmiZona"  runat="server" style="top:300px;">
        <div id="Div1">
            
        </div>
    </asp:Panel>
</asp:Content>
