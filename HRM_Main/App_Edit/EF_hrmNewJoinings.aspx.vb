Partial Class EF_hrmNewJoinings
  Inherits SIS.SYS.UpdateBase
  Protected Sub FormView1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.Init
    DataClassName = "hrmNewJoinings"
    SetFormView = FormView1
  End Sub
  Protected Sub ToolBar0_1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolBar0_1.Init
    SetToolBar = ToolBar0_1
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function J_ProjectSiteIDCompletionList(ByVal prefixText As String, ByVal count As Integer) As String()
    Return SIS.HRM.hrmProjects.SelecthrmProjectsAutoCompleteList(prefixText, count)
  End Function
  Protected Sub FormView1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.PreRender
		Dim oLC_J_ProjectSiteID As TextBox = FormView1.FindControl("LC_J_ProjectSiteID1")
		Dim strScript As String = "<script type=""text/javascript""> " & _
			"function LC_J_ProjectSiteID1_AutoCompleteExtender_Selected(sender, e) {" & _
			"  var LC_J_ProjectSiteID1 = $get('" & oLC_J_ProjectSiteID.ClientID & "');" & _
			"  LC_J_ProjectSiteID1.value = e.get_value();" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("LC_J_ProjectSiteID1") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "LC_J_ProjectSiteID1", strScript)
			End If
	End Sub
End Class
