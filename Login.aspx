<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="GrupoModeloWEB.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <link href="CCS\styles.css" rel="stylesheet" type="text/css" media="screen" />
    <title>Login Grupo Modelo</title>
    <meta name="keywords" content="" />
    <meta name="description" content="" />
    <link href="CCS\styles.css" rel="stylesheet" type="text/css" media="screen" />
  
</head>
<body class="fondopag">
    <div id="right">
    <div>
    <p class="titulo">LOGIN</p>
    	 <div>
		<table border="0" class="alinearcentro">
		<tr>
		    <td align="center">
                            <img class"alinearcentro" width="400" height="200" border="0" 
                                alt="Grupo Modelo" src="CCS/logomodelo.jpg" align="top"/></td>
		                <td>
                            &nbsp;</td>
		 </tr>
		</table>
	</div>
    <form id="form1" runat="server" class ="alinearcentro">
    
        <br />
        <table  border="0" class="link">
            <tr>
            <td>
                usuario&nbsp;</td>
                <td colspan = "2">
                    <asp:DropDownList ID="combo_us" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    contraseña</td>
                <td colspan = 2>
        <asp:TextBox ID="txt_contra" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr> 
                <td align = "center"   colspan="4" >
                    <asp:Button ID="cmd_agregar" runat="server" Text="Autenticar    ." Height="26px" 
                        Width="67px" />
                </td>
                <td align = "center">
                    &nbsp;</td>
                <td align = "center">
                    &nbsp;</td>
            </tr> 
            <tr>
            <td colspan ="3">
                &nbsp;</td>
            </tr>
        </table>
        <br />
        </form>
    </div> 
    </div>
</body>
</html>
