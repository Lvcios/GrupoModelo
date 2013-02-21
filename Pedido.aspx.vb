Public Partial Class Pedido
    Inherits System.Web.UI.Page
    Public ReadOnly Property folio_ped() As String
        Get
            Return txt_folio_ped.Text
        End Get
    End Property


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conexion.Open()
        Grid_ped.AutoGenerateSelectButton = True
        Grid_Pro.AutoGenerateSelectButton = True
        Grid_Pro_Ped.AutoGenerateSelectButton = True
        If Not Page.IsPostBack = True Then
            Call carga_ped()
            Call carga_cli()
            Call carga_age()
            Call llena_producto()
            Call llena_detalle_pedido()
            txt_fecha_ped.Text = Now
            'SELECT TOP 1 FOLIO_PED FROM PEDIDO ORDER BY FOLIO_PED DESC
            Call ultimo_folio()
        End If
    End Sub
    Private Sub llena_producto()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_PRODUCTO", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Pro.DataSource = rscliente.Tables(0)
        Grid_Pro.DataBind()
    End Sub
    Private Sub ultimo_folio()

    End Sub
    Private Sub llena_detalle_pedido()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_PEDIDO_DETALLE '" + txt_folio_ped.Text + "'", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Pro_Ped.DataSource = rscliente.Tables(0)
        Grid_Pro_Ped.DataBind()
    End Sub
    Private Sub carga_ped()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_PEDIDO", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Ped.DataSource = rscliente.Tables(0)
        Grid_Ped.DataBind()
    End Sub
    Private Sub carga_cli()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM CLIENTE", conexion)
        Dim rsusuario As New Data.DataSet
        rsconsulta.Fill(rsusuario)
        combo_cli.DataSource = rsusuario.Tables(0)
        combo_cli.DataValueField = "RFC_CLI"
        combo_cli.DataTextField = "NOM_CLI"
        combo_cli.DataBind()
    End Sub
    Private Sub carga_age()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM AGENCIA", conexion)
        Dim rsusuario As New Data.DataSet
        rsconsulta.Fill(rsusuario)
        Combo_Age.DataSource = rsusuario.Tables(0)
        Combo_Age.DataValueField = "RFC_AGE"
        Combo_Age.DataTextField = "NOM_AGE"
        Combo_Age.DataBind()
    End Sub

    Private Sub Pedido_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        conexion.Close()
    End Sub

    Protected Sub cmd_agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agregar.Click
        'Dim rsconsulta As New SqlClient.SqlDataAdapter("AGREGA_PEDIDO '" + txt_folio_ped.Text + "','" + txt_fecha_ped.Text + "','','','',,''", conexion)
        'Dim rscliente As New Data.DataSet
        'rsconsulta.Fill(rscliente)
        'Call carga_ped()
        Try
            'insertar datos
            txt_monto_ped.Text = 0
            txt_fecha_ped.Text = Now
            Dim rsconsulta As New SqlClient.SqlDataAdapter("AGREGA_PEDIDO '" + txt_folio_ped.Text + "','" + txt_fecha_ped.Text + "','" + Combo_Age.SelectedValue.ToString + "','" + combo_cli.SelectedValue.ToString + "'," + txt_monto_ped.Text + ",'" + txt_fecha_ped.Text + "'", conexion)
            'AGREGA_PEDIDO '95900','01-06-2011','AG002MDF','WM001MDF',30000,'02-06-2011'
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            carga_ped()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub combo_cli_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles combo_cli.SelectedIndexChanged
        MsgBox(Trim(combo_cli.SelectedItem.Text))
    End Sub

    Private Sub combo_cli_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_cli.TextChanged

    End Sub

    Protected Sub Grid_Ped_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_Ped.SelectedIndexChanged

    End Sub

    Protected Sub cmd_mod_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_mod.Click
        Try
            txt_fecha_ped.Text = Now
            Dim rsconsulta As New SqlClient.SqlDataAdapter("MODIFICA_PEDIDO '" + txt_folio_ped.Text + "','" + txt_fecha_ped.Text + "','" + Combo_Age.SelectedValue.ToString + "','" + combo_cli.SelectedValue.ToString + "'," + txt_monto_ped.Text + ",'" + txt_fecha_ped.Text + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            carga_ped()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub cmd_elim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_elim.Click
        Try
            txt_fecha_ped.Text = Now
            'PRIMERO DEBEMOS ELIMINAR LOS PRODUCTOS DE ESE PEDIDO
            Dim rsconsulta As New SqlClient.SqlDataAdapter("ELIMINA_PEDIDO '" + txt_folio_ped.Text + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            carga_ped()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub Grid_ped_SelectedIndexChanged1(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_ped.SelectedIndexChanged
        txt_folio_ped.Text = Grid_ped.SelectedDataKey(0).ToString()
        combo_cli.Text = Grid_ped.SelectedDataKey(3).ToString()
        Combo_Age.Text = Grid_ped.SelectedDataKey(2).ToString()
        txt_fecha_ped.Text = Grid_ped.SelectedDataKey(1).ToString()
        txt_monto_ped.Text = Grid_ped.SelectedDataKey(4).ToString()
        Call llena_detalle_pedido()
    End Sub

    Protected Sub Grid_Pro_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_Pro.SelectedIndexChanged
        txt_pro_ped.Text = Grid_Pro.SelectedDataKey(1).ToString()
        id_pro.Text = Grid_Pro.SelectedDataKey(0).ToString()
        pre_pro.Text = Grid_Pro.SelectedDataKey(2).ToString()
    End Sub

    Protected Sub cmd_agrega_pro_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agrega_pro.Click
        Try
            id_age.Text = Combo_Age.SelectedValue.ToString
            Dim monto As Integer
            monto = Int(txt_cnt_pro.Text) * Int(pre_pro.Text)
            Dim rsconsulta As New SqlClient.SqlDataAdapter("AGREGA_PEDIDO_DETALLE '" & txt_folio_ped.Text & "','" & Combo_Age.SelectedValue.ToString & "','" & id_pro.Text.ToString & "'," & txt_cnt_pro.Text & "," & Int(monto), conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            llena_detalle_pedido()
            txt_fecha_ped.Text = Now
            txt_monto_ped.Text = Int(txt_monto_ped.Text) + monto
            Dim rsconsulta1 As New SqlClient.SqlDataAdapter("MODIFICA_PEDIDO '" + txt_folio_ped.Text + "','" + txt_fecha_ped.Text + "','" + Combo_Age.SelectedValue.ToString + "','" + combo_cli.SelectedValue.ToString + "'," + txt_monto_ped.Text + ",'" + txt_fecha_ped.Text + "'", conexion)
            Dim rscliente1 As New Data.DataSet
            rsconsulta1.Fill(rscliente1)
            carga_ped()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub cmd_quita_pro_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_quita_pro.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("ELIMINA_PEDIDO_DETALLE '" + txt_folio_ped.Text + "','" + Combo_Age.SelectedValue.ToString + "','" + id_pro.Text + "'", conexion)
            'AGREGA_PEDIDO_DETALLE '89773','AG001MDF','BRSIX710',40,2600
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            'Dim monto As Integer
            'monto = Int(txt_cnt_pro.Text) * Int(pre_pro.Text)
            'txt_monto_ped.Text = Int(txt_monto_ped.Text) - monto
            'Dim rsconsulta1 As New SqlClient.SqlDataAdapter("MODIFICA_PEDIDO '" + txt_folio_ped.Text + "','" + txt_fecha_ped.Text + "','" + Combo_Age.SelectedValue.ToString + "','" + combo_cli.SelectedValue.ToString + "'," + txt_monto_ped.Text + ",'" + txt_fecha_ped.Text + "'", conexion)
            'Dim rscliente1 As New Data.DataSet
            'rsconsulta1.Fill(rscliente1)
            llena_detalle_pedido()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub cmd_terminar_pro_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_terminar_pro.Click
    End Sub

    Protected Sub txt_cnt_pro_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Protected Sub Grid_Pro_Ped_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_Pro_Ped.SelectedIndexChanged
        id_pro.Text = Grid_Pro_Ped.SelectedDataKey(2).ToString()
        pre_pro.Text = Grid_Pro_Ped.SelectedDataKey(2).ToString()
    End Sub
End Class