Public Partial Class Pago
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Grid_Pagos.AutoGenerateSelectButton = True
        Grid_ped.AutoGenerateSelectButton = True
        Call llena_pagos()
        Call carga_ped()

    End Sub

    Private Sub carga_ped()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_PEDIDO", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Ped.DataSource = rscliente.Tables(0)
        Grid_Ped.DataBind()
    End Sub
    Private Sub llena_pagos()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_PEDIDO_PAGO '" & txt_id_ped.Text & "'", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Pagos.DataSource = rscliente.Tables(0)
        Grid_Pagos.DataBind()
    End Sub

    Protected Sub Grid_Pagos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_Pagos.SelectedIndexChanged
        'txt_id_ped.Text = Grid_Pagos.SelectedDataKey(0).ToString()
        txt_mon_ped.Text = Grid_Pagos.SelectedDataKey(1).ToString()
        txt_fecha_ped.Text = Grid_Pagos.SelectedDataKey(2).ToString()
        monto_original.Text = Grid_Pagos.SelectedDataKey(1).ToString()
    End Sub

    Protected Sub Grid_ped_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_ped.SelectedIndexChanged
        txt_id_ped.Text = Grid_ped.SelectedDataKey(0).ToString()
        Call llena_pagos()
    End Sub

    Protected Sub cmd_agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agregar.Click
        Try
            txt_fecha_ped.Text = Now
            Dim rsconsulta As New SqlClient.SqlDataAdapter("AGREGA_PEDIDO_PAGO '" & txt_id_ped.Text & "'," + txt_mon_ped.Text + ",'" + txt_fecha_ped.Text.Trim + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            llena_pagos()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub cmd_mod_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_mod.Click
        Try
            'txt_fecha_ped.Text = Now
            Dim rsconsulta As New SqlClient.SqlDataAdapter("MODIFICA_PEDIDO_PAGO '" & txt_id_ped.Text & "'," + txt_mon_ped.Text + "," + monto_original.Text + ",'" + txt_fecha_ped.Text.Trim + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            llena_pagos()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub cmd_elim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_elim.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("ELIMINA_PEDIDO_PAGO '" & txt_id_ped.Text & "'," + txt_mon_ped.Text + ",'" + txt_fecha_ped.Text.Trim + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            llena_pagos()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class