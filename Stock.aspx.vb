Public Partial Class Stock
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conexion.Open()
        Grid_Stock.AutoGenerateSelectButton = True
        'Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT nick_usuario, contra_usuario FROM Usuario WHEERE id_usuario " + TEXTBOXX.TEXT, conexion)
        'Combo_Pro.AutoPostBack = True
        id_age.Visible = False
        id_pro.Visible = False
        cnt_pro.Visible = False
        If Not Page.IsPostBack = True Then
            Call carga_combo_pro()
            Call carga_combo_age()
            Call llena_existencias()
        End If
    End Sub
    Private Sub carga_combo_pro()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM PRODUCTO", conexion)
        Dim rsusuario As New Data.DataSet
        rsconsulta.Fill(rsusuario)
        Combo_Pro.DataSource = rsusuario.Tables(0)
        Combo_Pro.DataValueField = "ID_PRO"
        Combo_Pro.DataTextField = "NOM_PRO"
        Combo_Pro.DataBind()
    End Sub

    Private Sub carga_combo_age()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM AGENCIA", conexion)
        Dim rsusuario As New Data.DataSet
        rsconsulta.Fill(rsusuario)
        Combo_Age.DataSource = rsusuario.Tables(0)
        Combo_Age.DataValueField = "RFC_AGE"
        Combo_Age.DataTextField = "NOM_AGE"
        Combo_Age.DataBind()
    End Sub
    Private Sub llena_existencias()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("CARGA_STOCK", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        Grid_Stock.DataSource = rscliente.Tables(0)
        Grid_Stock.DataBind()
    End Sub

    Private Sub Combo_Age_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Age.PreRender

    End Sub


    Private Sub Stock_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        conexion.Close()
    End Sub

    Protected Sub Grid_Stock_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid_Stock.SelectedIndexChanged
        Combo_Pro.Text = Grid_Stock.SelectedDataKey(1).ToString()
        Combo_Pro.DataValueField = Grid_Stock.SelectedDataKey(1).ToString()
        id_pro.Text = Grid_Stock.SelectedDataKey(1).ToString()
        'Combo_Prt.Text = Grid_Stock.SelectedDataKey(1).ToString()
        Combo_Age.Text = Grid_Stock.SelectedDataKey(0).ToString()
        Combo_Age.DataValueField = Grid_Stock.SelectedDataKey(0).ToString()
        id_Age.Text = Grid_Stock.SelectedDataKey(0).ToString()
        txt_cnt_pro.Text = Grid_Stock.SelectedDataKey(2).ToString()
        cnt_pro.Text = Grid_Stock.SelectedDataKey(2).ToString()
    End Sub

    Protected Sub cmd_agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agregar.Click
        'logica:
        Try
            id_pro.Text = Combo_Pro.SelectedValue.ToString
            id_age.Text = Combo_Age.SelectedValue.ToString
            Dim rsconsulta As New SqlClient.SqlDataAdapter("AGREGA_STOCK '" + id_age.Text + "','" + id_pro.Text + "'," + txt_cnt_pro.Text + "", conexion)
            'AGREGA_STOCK 'RFC_AGE','ID_PRO',100
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            Call llena_existencias()
            'MsgBox(Combo_Pro.SelectedIndex) DEVUELVE EL INDICE
            'MsgBox(Combo_Pro.SelectedItem.ToString) DEVUELVE EL TEXTO
            'MsgBox(Combo_Pro.SelectedValue.ToString) DEVUELVE LA CLAVE ASOCIADA AL TEXTO
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        
    End Sub

    Protected Sub Combo_Pro_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Combo_Pro.SelectedIndexChanged
        
    End Sub

    Private Sub Combo_Pro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Pro.TextChanged
        'nom_pro.Text = Combo_Pro.Text
    End Sub

    Private Sub Combo_Age_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_Age.SelectedIndexChanged
    End Sub

    Protected Sub cmd_mod_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_mod.Click
        Try
            id_pro.Text = Combo_Pro.SelectedValue.ToString
            id_age.Text = Combo_Age.SelectedValue.ToString
            txt_cnt_pro.Text = Int(txt_cnt_pro.Text) + Int(cnt_pro.Text)
            Dim rsconsulta As New SqlClient.SqlDataAdapter("MODIFICA_STOCK '" + id_age.Text + "','" + id_pro.Text + "'," + txt_cnt_pro.Text + "", conexion)
            'AGREGA_STOCK 'RFC_AGE','ID_PRO',100
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            Call llena_existencias()
            'MsgBox(Combo_Pro.SelectedIndex) DEVUELVE EL INDICE
            'MsgBox(Combo_Pro.SelectedItem.ToString) DEVUELVE EL TEXTO
            'MsgBox(Combo_Pro.SelectedValue.ToString) DEVUELVE LA CLAVE ASOCIADA AL TEXTO
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Protected Sub txt_cnt_pro_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt_cnt_pro.TextChanged

    End Sub

    Protected Sub cmd_elim_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_elim.Click
        Try
            id_pro.Text = Combo_Pro.SelectedValue.ToString
            id_age.Text = Combo_Age.SelectedValue.ToString
            txt_cnt_pro.Text = Int(txt_cnt_pro.Text) + Int(cnt_pro.Text)
            Dim rsconsulta As New SqlClient.SqlDataAdapter("ELIMINA_STOCK '" + id_age.Text + "','" + id_pro.Text + "'," + txt_cnt_pro.Text + "", conexion)
            'AGREGA_STOCK 'RFC_AGE','ID_PRO',100
            Dim rscliente As New Data.DataSet
            rsconsulta.Fill(rscliente)
            Call llena_existencias()
            'MsgBox(Combo_Pro.SelectedIndex) DEVUELVE EL INDICE
            'MsgBox(Combo_Pro.SelectedItem.ToString) DEVUELVE EL TEXTO
            'MsgBox(Combo_Pro.SelectedValue.ToString) DEVUELVE LA CLAVE ASOCIADA AL TEXTO
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class