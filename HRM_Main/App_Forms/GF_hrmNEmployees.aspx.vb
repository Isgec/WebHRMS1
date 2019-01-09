Partial Class GF_hrmNEmployees
  Inherits SIS.SYS.GridBase
  Protected Sub GVhrmNEmployees_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVhrmNEmployees.RowCommand
    If e.CommandName.ToLower = "lgedit" Then
      Try
        Dim CardNo As String = GVhrmNEmployees.DataKeys(e.CommandArgument).Values("CardNo")
        Dim RedirectUrl As String = TBLhrmNEmployees.EditUrl & "?CardNo=" & CardNo
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVhrmNEmployees_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVhrmNEmployees.Init
    DataClassName = "GhrmNEmployees"
    SetGridView = GVhrmNEmployees
  End Sub
  Protected Sub TBLhrmNEmployees_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLhrmNEmployees.Init
    SetToolBar = TBLhrmNEmployees
  End Sub
End Class
