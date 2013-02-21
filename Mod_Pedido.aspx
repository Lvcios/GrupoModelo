<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Mod_Pedido.aspx.vb" Inherits="GrupoModeloWEB.Mod_Pedido" %>
<%@ PreviousPageType VirtualPath="Pedido.aspx" %> 

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Productos del pedido</title>
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <link href="CCS\styles.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body class="fondopag">
    <form id="form1" runat="server">
    <div class="link">
    Agregar o quitar productos del pedido con folio:<asp:Label ID="Label1" 
            runat="server" Text="Label"></asp:Label>
&nbsp;<table border="3" class="alinearcentro">
        <tr>
        <td>
            <asp:Button ID="cmd_agrega_pro" runat="server" Text="Agrega Producto" />
        </td>
        <td>
            <asp:Button ID="cmd_quita_pro" runat="server" Text="Quita producto" />
        </td>
        <td>
            <asp:Button ID="cmd_terminar_pro" runat="server" Text="Terminar Pedido" />
        </td>
        </tr>
        <tr>
        <td colspan="3">
        Productos disponibles
        </td>
        </tr>
        <tr>
        <td>Seleccionado: </td>
        <td colspan="2"><asp:TextBox id="txt_nom_pro" runat="server" Width="243px"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Unidades: </td>
        <td colspan="2"><asp:TextBox id="txt_cnt_pro" runat="server" Width="243px"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Filtro: </td>
        <td colspan="2"><asp:TextBox id="txt_filtro_pro" runat="server" Width="243px"></asp:TextBox></td>
        </tr>
        <tr>
        <td colspan="3">
            <asp:GridView ID="Grid_Pro" runat="server" CellPadding="4" ForeColor="#333333" 
                GridLines="None">
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
        <td colspan="3">
        Productos del pedido</td>
        </tr>
        <tr>
        <td>Filtro: </td>
        <td colspan="2"><asp:TextBox id="txt_filtro_ped" runat="server" Width="241px"></asp:TextBox></td>
        </tr>
        <tr>
        <td colspan="3">
            <asp:GridView ID="Grid_Pro_Ped" runat="server" CellPadding="4" 
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
    </div>
    </form>
</body>
</html>
