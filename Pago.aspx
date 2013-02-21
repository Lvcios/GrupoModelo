<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Pago.aspx.vb" Inherits="GrupoModeloWEB.Pago" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <link href="CCS\styles.css" rel="stylesheet" type="text/css" media="screen" />
    <title>Pagos por pedido</title>
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
		    <td colspan ="7" align="center"><img class="alinearcentro" width="400" height="200" border="0" alt="Grupo Modelo" src="CCS/logomodelo.jpg"/></td>
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
                pedido</td>
                <td colspan = "2">
                    <asp:TextBox ID="txt_id_ped" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    monto a pagar</td>
                <td colspan = "2">
        <asp:TextBox ID="txt_mon_ped" runat="server"></asp:TextBox>
                    <asp:Label ID="monto_original" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan = "2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    fecha</td>
                <td colspan = "2">
                    <asp:TextBox ID="txt_fecha_ped" runat="server" ReadOnly="True"></asp:TextBox>
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
            <tr>
            <td colspan ="3">
                <asp:GridView ID="Grid_ped" runat="server" CellPadding="4" 
                    DataKeyNames="FOLIO_PED,FECHA_PED,RFC_AGE,RFC_CLI,MONTO_PED,FECHA_LIQ" 
                    ForeColor="#333333" GridLines="None">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
                </td>
            </tr>
        </table>
        <asp:GridView ID="Grid_Pagos" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" DataKeyNames="FOLIO_PED,MTO_PAGO,FECHA_PAGO" 
            class="link">
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
