Imports System.Data.SqlClient
Module ModuleGral
    'ConfigurationManager.ConnectionStrings("grupomodelo").ConnectionString
    Public conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("grupomodelo").ConnectionString)
    Public seguridad As String

End Module
