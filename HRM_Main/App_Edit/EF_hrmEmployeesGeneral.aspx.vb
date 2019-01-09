Partial Class EF_hrmEmployeesGeneral
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
  Public Shared Function C_ProjectSiteIDCompletionList(ByVal prefixText As String, ByVal count As Integer) As String()
    Return SIS.HRM.hrmProjects.SelecthrmProjectsAutoCompleteList(prefixText, count)
  End Function
  Protected Sub FormView1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.PreRender
    Dim oLC_C_ProjectSiteID As TextBox = FormView1.FindControl("LC_C_ProjectSiteID1")
    Dim strScriptC_ProjectSiteID As String = "<script type=""text/javascript""> " &
      "function LC_C_ProjectSiteID1_AutoCompleteExtender_Selected(sender, e) {" &
      "  var LC_C_ProjectSiteID1 = $get('" & oLC_C_ProjectSiteID.ClientID & "');" &
      "  LC_C_ProjectSiteID1.value = e.get_value();" &
      "}" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("LC_C_ProjectSiteID1") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "LC_C_ProjectSiteID1", strScriptC_ProjectSiteID)
    End If
  End Sub
End Class
