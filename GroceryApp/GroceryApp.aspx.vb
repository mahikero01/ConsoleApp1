Imports System.Data.SqlClient

Public Class GroceryApp
    Inherits System.Web.UI.Page

    Private _conn As SqlConnection

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If (Not IsPostBack) Then
            Me.RefreshList()
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
        Me._conn.Open()
        qryStr = "SELECT * FROM [GroceryLists]"
        qry = New SqlCommand(qryStr, Me._conn)
        qry.CommandType = CommandType.Text

        resultSet = New DataTable()
        dbAdpt = New SqlDataAdapter(qry)
        dbAdpt.Fill(resultSet)

        dbAdpt.Dispose()
        qry.Dispose()

        Me.CloseConnection()

        Return resultSet
    End Function

    Sub RefreshList()
        Dim data As DataTable
        data = Me.GetLists
        gridView.DataSource = data
        gridView.DataBind()
    End Sub

    Sub ClearBox()
        recorIdTxt.Text = ""
        RecordNameTxt.Text = ""
        RecordCountTxt.Text = ""
    End Sub

    Function TransactQuery(qryStr As String)
        Dim transact As SqlTransaction
        Dim qry As SqlCommand

        Me.OpenConnection()
        Me._conn.Open()
        transact = Me._conn.BeginTransaction()
        qry = New SqlCommand(qryStr, Me._conn, transact)
        qry.CommandType = CommandType.Text
        qry.ExecuteNonQuery()
        transact.Commit()

        transact.Dispose()
        qry.Dispose()
    End Function

    Protected Sub createRecord_Click(sender As Object, e As EventArgs) Handles createRecord.Click
        Dim qryStr As String

        qryStr = "INSERT INTO [GroceryLists] (GroceryName, GroceryQty) "
        qryStr = qryStr & "VALUES ('" & RecordNameTxt.Text & "'," & RecordCountTxt.Text & ")"
        Me.TransactQuery(qryStr)

        Me.RefreshList()
        Me.ClearBox()
    End Sub

    Protected Sub EditRecord_Click(sender As Object, e As EventArgs) Handles EditRecord.Click
        Dim qryStr As String

        qryStr = "UPDATE [GroceryLists] SET "
        qryStr = qryStr & "GroceryName = '" & RecordNameTxt.Text & "', GroceryQty = " & RecordCountTxt.Text & " "
        qryStr = qryStr & "WHERE GroceryListID = " & recorIdTxt.Text
        Me.TransactQuery(qryStr)

        Me.RefreshList()
        Me.ClearBox()
    End Sub

    Protected Sub DeleteRecord_Click(sender As Object, e As EventArgs) Handles DeleteRecord.Click
        Dim qryStr As String

        qryStr = "DELETE FROM [GroceryLists] "
        qryStr = qryStr & "WHERE GroceryListID = " & recorIdTxt.Text
        Me.TransactQuery(qryStr)

        Me.RefreshList()
        Me.ClearBox()
    End Sub
End Class