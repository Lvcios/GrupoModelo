﻿Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        MsgBox("Hola mundo en ASP.NET ;)")
        MsgBox("Mucho Gusto " + TextBox1.Text)
    End Sub
End Class