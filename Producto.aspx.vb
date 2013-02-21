Public Partial Class Producto
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conexion.Open()
        Grid_Pro.SelectedIndex = -1
        Grid_Pro.AutoGenerateSelectButton = True
        Call llena_producto()
    End Sub

    Private Sub llena_producto()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_PRODUCTO", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Pro.DataSource = rscliente.Tables(0)
        Grid_Pro.DataBind()
    End Sub

    Private Sub Producto_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        conexion.Close()
    End Sub

    Protected Sub cmd_agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agregar.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("AGREGA_PRODUCTO '" + txt_id_pro.Text + "','" + txt_nom_pro.Text + "','" + txt_pre_pro.Text + "'", conexion)
            'AGREGA_CLIENTE 'CM001EMX','Mexicana Ecatepec','Calzada Mexico-Pachuca 872','557281766'
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            'MsgBox ("Cliente agregado")
            Call llena_producto()
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub Grid_Pro_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_Pro.SelectedIndexChanged
        txt_id_pro.Text = Grid_Pro.SelectedDataKey(0).ToString()
        txt_nom_pro.Text = Grid_Pro.SelectedDataKey(1).ToString()
        txt_pre_pro.Text = Grid_Pro.SelectedDataKey(2).ToString()
    End Sub

    Protected Sub cmd_mod_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_mod.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("MODIFICA_PRODUCTO '" + txt_id_pro.Text + "','" + txt_nom_pro.Text + "','" + txt_pre_pro.Text + "'", conexion)
            'AGREGA_CLIENTE 'CM001EMX','Mexicana Ecatepec','Calzada Mexico-Pachuca 872','557281766'
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            'MsgBox ("Cliente agregado")
            Call llena_producto()
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub cmd_elim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_elim.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("ELIMINA_PRODUCTO '" + txt_id_pro.Text + "'", conexion)
            'AGREGA_CLIENTE 'CM001EMX','Mexicana Ecatepec','Calzada Mexico-Pachuca 872','557281766'
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            'MsgBox ("Cliente agregado")
            Call llena_producto()
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub
End Class