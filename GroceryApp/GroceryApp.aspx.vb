Imports System.Data.SqlClient

Public Class GroceryApp
    Inherits System.Web.UI.Page

    Private _conn As SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim data As DataTable

        If (Not Me.IsPostBack) Then
            data = Me.GetLists
            gridView.DataSource = data
            gridView.DataBind()
        End If

    End Sub

    Sub OpenConnection()
        Dim conStr = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        Me._conn = New SqlConnection(conStr)
    End Sub

    Sub CloseConnection()
        Me._conn.Close()
    End Sub

    Function GetLists() As DataTable
        Dim resultSet As DataTable
        Dim qryStr As String
        Dim qry As SqlCommand
        Dim dbAdpt As SqlDataAdapter

        Me.OpenConnection()
        qryStr = "SELECT * FROM [GroceryLists]"
        qry = New SqlCommand(qryStr, Me._conn)
        qry.CommandType = CommandType.Text
        Me._conn.Open()

        resultSet = New DataTable()
        dbAdpt = New SqlDataAdapter(qry)
        dbAdpt.Fill(resultSet)

        dbAdpt.Dispose()
        qry.Dispose()

        Me.CloseConnection()

        Return resultSet
    End Function

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        OpenConnection()
        CloseConnection()
    End Sub
End Class