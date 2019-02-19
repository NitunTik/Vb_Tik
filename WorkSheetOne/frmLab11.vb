Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmLab11
    Dim strCon As String = ConfigurationManager.ConnectionStrings("WorkSheetOne.My.MySettings.MyData").ConnectionString

    Dim MyConn As SqlConnection
    Dim MyDA As SqlDataAdapter
    Dim MyDS As DataSet

    Private Sub DataGrid()


    End Sub
End Class