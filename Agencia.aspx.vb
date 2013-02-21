Public Partial Class Agencia
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        conexion.Open()
        Grid_Age.SelectedIndex = -1
        Grid_Age.AutoGenerateSelectButton = True
        Call llena_agencia()
    End Sub
Private Sub llena_agencia()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_AGENCIA", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_age.DataSource = rscliente.Tables(0)
        Grid_age.DataBind()
    End Sub
    Protected Sub cmd_agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agregar.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("AGREGA_AGENCIA '" + txt_id_age.Text + "','" + txt_nom_age.Text + "','" + txt_ubi_age.Text + "','" + txt_tel_age.Text + "'", conexion)
            'AGREGA_CLIENTE 'CM001EMX','Mexicana Ecatepec','Calzada Mexico-Pachuca 872','557281766'
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            'MsgBox ("Cliente agregado")
            Call llena_agencia()
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Agencia_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        conexion.Close() 
    End Sub

    Protected Sub Grid_Age_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_Age.SelectedIndexChanged
        txt_id_age.Text = Grid_age.SelectedDataKey(0).ToString()
        txt_nom_age.Text = Grid_age.SelectedDataKey(1).ToString()
        txt_ubi_age.Text = Grid_age.SelectedDataKey(2).ToString()
        txt_tel_age.Text = Grid_age.SelectedDataKey(3).ToString()
    End Sub

    Protected Sub cmd_mod_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_mod.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("MODIFICA_AGENCIA '" + txt_id_age.Text + "','" + txt_nom_age.Text + "','" + txt_ubi_age.Text + "','" + txt_tel_age.Text + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            Call llena_agencia()
            Grid_Age.SelectedIndex = -1
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub cmd_elim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_elim.Click
        Try
            Dim rsconsulta As New SqlClient.SqlDataAdapter("ELIMINA_AGENCIA '" + txt_id_age.Text + "'", conexion)
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            Call llena_agencia()
            Grid_Age.SelectedIndex = -1
            'conexion.Close()
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub txt_id_age_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt_id_age.TextChanged

    End Sub
End Class