Partial Class AF_hrmDepartments
  Inherits SIS.SYS.InsertBase
  Protected Sub FormView1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.Init
    DataClassName = "hrmNewJoinings"
    SetFormView = FormView1
  End Sub
  Protected Sub ToolBar0_1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolBar0_1.Init
    SetToolBar = ToolBar0_1
  End Sub
  Protected Sub FormView1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.PreRender
    Dim oValidate_DepartmentID As TextBox = FormView1.FindControl("TextBoxDepartmentID")
    Dim validateScript As String = "<script type=""text/javascript"">" &
      "  function validate_DepartmentID(o) {" &
      "    PageMethods.validate_DepartmentID(o.value, validated_DepartmentID);" &
      "  }" &
      "  function validated_DepartmentID(result) {" &
      "    var p = result.split('|');" &
      "    if(p[0]=='1'){" &
      "      alert(p[1]);" &
      "      var o = $get('" & oValidate_DepartmentID.ClientID & "');" &
      "      o.value='';" &
      "      o.focus();" &
      "    }" &
      "  }" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateDepartmentID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateDepartmentID", validateScript)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_DepartmentID(ByVal value As String) As String
    Dim mRet As String="0|"
		Dim oVar As SIS.HRM.hrmDepartments = SIS.HRM.hrmDepartments.GetByID(value)
    If Not oVar Is Nothing Then
			mRet = "1|Record for " & value & " allready exists." 
    End If
    Return mRet
  End Function
End Class
