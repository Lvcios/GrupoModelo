Public Partial Class Mod_Pedido
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Grid_Pro.AutoGenerateSelectButton = True
        Grid_Pro_Ped.AutoGenerateSelectButton = True
        conexion.Open()
        llena_producto()
        llena_detalle_pedido()
        Label1.Text = PreviousPage.Request("txt_folio_ped.txt")
    End Sub

    Private Sub Mod_Pedido_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        conexion.Close()
    End Sub
    Private Sub llena_producto()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_PRODUCTO", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Pro.DataSource = rscliente.Tables(0)
        Grid_Pro.DataBind()
    End Sub
    Private Sub llena_detalle_pedido()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_PEDIDO_DETALLE", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Pro_Ped.DataSource = rscliente.Tables(0)
        Grid_Pro_Ped.DataBind()
    End Sub

    Protected Sub cmd_agrega_pro_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agrega_pro.Click

    End Sub
End Class