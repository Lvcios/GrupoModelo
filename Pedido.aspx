<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Pedido.aspx.vb" Inherits="GrupoModeloWEB.Pedido" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <link href="CCS\styles.css" rel="stylesheet" type="text/css" media="screen" />
    <title>Pedido</title>
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <link href="CCS\styles.css" rel="stylesheet" type="text/css" media="screen" />
  
    <style type="text/css">
        .style1
        {
            height: 31px;
        }
    </style>
  
</head>
<body class="fondopag">
    <div id="right">
    <div>
    <p class="titulo">PEDIDOS</p>
    	 <div class="alinearcentro">
		<table border="0" class="alinearcentro">
		    <tr>
		    <td colspan ="7" align="center"><img class"alinearcentro" width="400" height="200" border="0" alt="Grupo Modelo" src="CCS/logomodelo.jpg"/></td>
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
        <table border="0" class="link" >
            <tr>
            <td colspan="2" align ="right" >Folio del pedido</td>
                <td colspan = "2" align="left" >
                    <asp:TextBox ID="txt_folio_ped" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align = "right">
                    Cliente</td>
                <td colspan = "2" align = "left">
                    <asp:DropDownList ID="combo_cli" runat="server">
                    </asp:DropDownList>
                    <asp:Label ID="id_cli" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" align = "right">
                    agencia</td>
                <td colspan = "2" align = "left">
                    <asp:DropDownList ID="Combo_Age" runat="server">
                    </asp:DropDownList>
                    <asp:Label ID="id_age" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" align = "right">
                    Fecha en que se realiza
                </td>
                <td colspan = "2" align = "left">
                    <asp:TextBox ID="txt_fecha_ped" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align ="right" colspan = "2" >
                monto total
                </td>
                <td colspan="2" align ="left"  >
                    <asp:TextBox ID="txt_monto_ped" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr> 
            <tr>
                <td align = "center"   >
                    <asp:Button ID="cmd_agregar" runat="server" Text="Agregar" Height="26px" 
                        Width="67px"/>
                </td>
                <td align = "center">
                    <asp:Button ID="cmd_mod" runat="server" Text="Modificar"/>
                </td>
                <td align = "center" colspan="2">
                    <asp:Button ID="cmd_elim" runat="server" Text="Eliminar" />
                </td>
            </tr>
            <tr>
            <td colspan="3">Lista de pedidos: </td>
            </tr>
            <tr>
            <td colspan="4">
                <asp:GridView ID="Grid_ped" runat="server" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" DataKeyNames = "FOLIO_PED,FECHA_PED,RFC_AGE,RFC_CLI,MONTO_PED,FECHA_LIQ">
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
            <tr>
            <td colspan="4">Productos disponibles para el pedido</td>
            </tr>
            <tr>
            <td colspan="4">
            producto seleccionado:
                <asp:TextBox ID="txt_pro_ped" runat="server" Width="220px"></asp:TextBox>
                <asp:Label ID="id_pro" runat="server" Text="Label" Visible="False"></asp:Label>
                <asp:Label ID="pre_pro" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            </tr>
            <tr>
            <td>
            <asp:Button ID="cmd_agrega_pro" runat="server" Text="Agrega Producto" />
            </td>
              <td>Cantidad 
                    <asp:TextBox ID="txt_cnt_pro" runat="server"></asp:TextBox>
               </td>
            <td>    
            <asp:Button ID="cmd_quita_pro" runat="server" Text="Quita producto" />
            </td>
            <td>
            <asp:Button ID="cmd_terminar_pro" runat="server" Text="Terminar Pedido" />
            </td>
            </tr>
            <tr>
            <td colspan="4" class="style1">
            <asp:GridView ID="Grid_Pro" runat="server" CellPadding="4" ForeColor="#333333" 
                GridLines="None" DataKeyNames = "ID_PRO,NOM_PRO,PRE_PRO">
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
            <tr>
            <td colspan="4">
            Productos agregados al pedido
            </td
            </tr>
            <tr>
            <td colspan="4">
            <asp:GridView ID="Grid_Pro_Ped" runat="server" CellPadding="4" 
                ForeColor="#333333" GridLines="None" 
                    DataKeyNames="FOLIO_PED,RFC_AGE,ID_PRO,CNT_PRO,MON_PRO">
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
        <br />
        </form>
    </div> 
    </div>
</body>
</html>
