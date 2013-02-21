<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Stock.aspx.vb" Inherits="GrupoModeloWEB.Stock" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <link href="CCS\styles.css" rel="stylesheet" type="text/css" media="screen" />
    <title>Agencias</title>
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <link href="CCS\styles.css" rel="stylesheet" type="text/css" media="screen" />
  
</head>
<body class="fondopag">
    <div id="right">
    <div>
    <p class="titulo">EXISTENCIAS</p>
    	 <div class="alinearcentro">
		<table border="0" class="alinearcentro">
		<tr>
		    <td colspan ="7" align="center"><img WIDTH=400 HEIGHT=200 BORDER="0" ALT="Grupo Modelo" src="CCS/logomodelo.jpg"></td>
		    </tr>
		    <tr>
			<td><a href="Index.aspx"  title="" class="link" >Inicio</a></td>
			<td><a href="Pedido.aspx" title="" class="link">Pedidos</a></td>
			<td><a href="Pago.aspx" title="" class="link">Pagos</a></td>
			<td><a href="Producto.aspx" title="" class="link">Catálogo</a></td>
			<td><a href="Cliente.aspx" title="" class="link">Clientes</a></td>
			<td><a href="Stock.aspx" title="" class="link">Existencias</a></td>
			<td><a href="Agencia.aspx" title="" class="link">Agencias</a></td>
			</tr>
		</table>
	</div>
    <form id="form1" runat="server">
    
        <br />
        <table  border="0" class="link">
            <tr>
            <td>
        <asp:Label ID="Label1" runat="server" Text="Producto"></asp:Label>
                </td>
                <td colspan = "2">
                    <asp:DropDownList ID="Combo_Pro" runat="server">
                    </asp:DropDownList>
                    <asp:Label ID="id_pro" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label2" runat="server" Text="Unidades a agregar: "></asp:Label>
                </td>
                <td colspan = 2>
        <asp:TextBox ID="txt_cnt_pro" runat="server"></asp:TextBox>
                    <asp:Label ID="cnt_pro" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan = 2>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Label4" runat="server" Text="Agencia"></asp:Label>
                </td>
                <td colspan = 2>
                    <asp:DropDownList ID="Combo_Age" runat="server">
                    </asp:DropDownList>
                    <asp:Label ID="id_age" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
             </tr>
            <tr> 
                <td align = "center"   >
                    <asp:Button ID="cmd_agregar" runat="server" Text="Agregar" Height="26px" 
                        Width="67px" />
                </td>
                <td align = "center">
                    <asp:Button ID="cmd_mod" runat="server" Text="Modificar" />
                </td>
                <td align = "center">
                    <asp:Button ID="cmd_elim" runat="server" Text="Eliminar" />
                </td>
            </tr> 
        </table>
        <asp:GridView ID="Grid_Stock" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" DataKeyNames="RFC_AGE,ID_PRO,STOCK_PRO" class="link">
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <br />
        </form>
    </div> 
    </div>
</body>
</html>