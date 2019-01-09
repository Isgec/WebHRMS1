Partial Class GF_hrmEmployeesGeneral
  Inherits SIS.SYS.GridBase
  Private Sub GridView1_Init(sender As Object, e As EventArgs) Handles GridView1.Init
    DataClassName = "GtaBH"
    SetGridView = GridView1
  End Sub
  Private Sub ToolBar0_1_Init(sender As Object, e As EventArgs) Handles ToolBar0_1.Init
    SetToolBar = ToolBar0_1
  End Sub

  Private Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim Code As String = GridView1.DataKeys(e.CommandArgument).Values("CardNo")
        Dim RedirectUrl As String = ToolBar0_1.EditUrl & "?Code=" & Code
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
End Class
