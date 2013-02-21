Imports System.Data.SqlClient
Partial Public Class Cliente
    Inherits System.Web.UI.Page
    Private Sub llena_cliente()
        'conexion.Open()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_CLIENTE", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Cli.DataSource = rscliente.Tables(0)
        Grid_Cli.DataBind()
        'conexion.Close()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conexion.Open()
        Grid_Cli.SelectedIndex = -1
        Grid_Cli.AutoGenerateSelectButton = True
        Call llena_cliente()
    End Sub



    Protected Sub Grid_Cli_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_Cli.SelectedIndexChanged
        'txt_clave.Text = Trim(lista_cliente.Item(0, lista_cliente.CurrentRow.Index).Value)
        txt_id_cli.Text = Grid_Cli.SelectedDataKey(0).ToString()
        txt_nom_cli.Text = Grid_Cli.SelectedDataKey(1).ToString()
        txt_ubi_cli.Text = Grid_Cli.SelectedDataKey(2).ToString()
        txt_tel_cli.Text = Grid_Cli.SelectedDataKey(3).ToString()

    End Sub

    Protected Sub cmd_agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agregar.Click
        'conexion.Open()

        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("AGREGA_CLIENTE '" + txt_id_cli.Text + "','" + txt_nom_cli.Text + "','" + txt_ubi_cli.Text + "','" + txt_tel_cli.Text + "'", conexion)
            'AGREGA_CLIENTE 'CM001EMX','Mexicana Ecatepec','Calzada Mexico-Pachuca 872','557281766'
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            'MsgBox ("Cliente agregado")
            Call llena_cliente()
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub Cliente_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        conexion.Close()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Protected Sub cmd_mod_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_mod.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("MODIFICA_CLIENTE '" + txt_id_cli.Text + "','" + txt_nom_cli.Text + "','" + txt_ubi_cli.Text + "','" + txt_tel_cli.Text + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            Call llena_cliente()
            Grid_Cli.SelectedIndex = -1
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub cmd_elim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_elim.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("ELIMINA_CLIENTE '" + txt_id_cli.Text + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            Call llena_cliente()
            Grid_Cli.SelectedIndex = -1
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub txt_id_cli_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt_id_cli.TextChanged
    End Sub
End Class