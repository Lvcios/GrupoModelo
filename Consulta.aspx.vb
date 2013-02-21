Imports System.Data.SqlClient
Partial Public Class Consulta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        conexion.Close()
        conexion.Open()
        'Dim rsconsulta As New SqlClient.SqlDataAdapter("SELECT * FROM PRODUCTO", conexion)
        Dim rsconsulta As New SqlClient.SqlDataAdapter(TextBox1.Text, conexion)
        Dim rscliente As New Data.DataSet
        rsconsulta.Fill(rscliente)
        GridView1.DataSource = rscliente.Tables(0) ' datagrid
        GridView1.DataBind()
        conexion.Close()
    End Sub
End Class