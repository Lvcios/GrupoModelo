Public Partial Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack = True Then
            Call carga_usuarios()
        End If
    End Sub
    Private Sub carga_usuarios()
        Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM USUARIO", conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        combo_us.DataSource = rscliente.Tables(0)
        combo_us.DataValueField = "CONTRA_US"
        combo_us.DataTextField = "NICK_US"
        combo_us.DataBind()
    End Sub


    Protected Sub cmd_agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_agregar.Click
        Try
            If (txt_contra.Text = combo_us.SelectedValue.ToString) Then
                Response.Redirect("Index.aspx")
                seguridad = "Admin"
            Else
                MsgBox("Autenticación fallida =(")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try


        'Grid_Ped.DataSource = rscliente.Tables(0)
        'Grid_Ped.DataBind()
    End Sub
End Class