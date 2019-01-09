Partial Class AF_hrmNewJoinings
  Inherits SIS.SYS.InsertBase
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
    Dim oLC_J_CompanyID As LC_hrmCompanies = FormView1.FindControl("LC_J_CompanyID1")
    oLC_J_CompanyID.Enabled = True
    oLC_J_CompanyID.SelectedValue = String.Empty
    If Not Session("LC_J_CompanyID") Is Nothing Then
      If Session("LC_J_CompanyID") <> String.Empty Then
        oLC_J_CompanyID.SelectedValue = Session("LC_J_CompanyID")
      End If
    End If
    Dim oLC_J_DivisionID As LC_hrmDivisions = FormView1.FindControl("LC_J_DivisionID1")
    oLC_J_DivisionID.Enabled = True
    oLC_J_DivisionID.SelectedValue = String.Empty
    If Not Session("LC_J_DivisionID") Is Nothing Then
      If Session("LC_J_DivisionID") <> String.Empty Then
        oLC_J_DivisionID.SelectedValue = Session("LC_J_DivisionID")
      End If
    End If
    Dim oLC_J_OfficeID As LC_hrmOffices = FormView1.FindControl("LC_J_OfficeID1")
    oLC_J_OfficeID.Enabled = True
    oLC_J_OfficeID.SelectedValue = String.Empty
    If Not Session("LC_J_OfficeID") Is Nothing Then
      If Session("LC_J_OfficeID") <> String.Empty Then
        oLC_J_OfficeID.SelectedValue = Session("LC_J_OfficeID")
      End If
    End If
    Dim oLC_J_DepartmentID As LC_hrmDepartments = FormView1.FindControl("LC_J_DepartmentID1")
    oLC_J_DepartmentID.Enabled = True
    oLC_J_DepartmentID.SelectedValue = String.Empty
    If Not Session("LC_J_DepartmentID") Is Nothing Then
      If Session("LC_J_DepartmentID") <> String.Empty Then
        oLC_J_DepartmentID.SelectedValue = Session("LC_J_DepartmentID")
      End If
    End If
    Dim oLC_J_ProjectSiteIDDescription As TextBox = FormView1.FindControl("LC_J_ProjectSiteIDDescription1")
    oLC_J_ProjectSiteIDDescription.Enabled = True
    oLC_J_ProjectSiteIDDescription.Text = String.Empty
    If Not Session("LC_J_ProjectSiteIDDescription") Is Nothing Then
      If Session("LC_J_ProjectSiteIDDescription") <> String.Empty Then
        oLC_J_ProjectSiteIDDescription.Text = Session("LC_J_ProjectSiteIDDescription")
      End If
    End If
    Dim oLC_J_ProjectSiteID As TextBox = FormView1.FindControl("LC_J_ProjectSiteID1")
    oLC_J_ProjectSiteID.Enabled = True
    oLC_J_ProjectSiteID.Text = String.Empty
    If Not Session("LC_J_ProjectSiteID") Is Nothing Then
      If Session("LC_J_ProjectSiteID") <> String.Empty Then
        oLC_J_ProjectSiteID.Text = Session("LC_J_ProjectSiteID")
      End If
    End If
    Dim strScript As String = "<script type=""text/javascript""> " &
      "function LC_J_ProjectSiteID1_AutoCompleteExtender_Selected(sender, e) {" &
      "  var LC_J_ProjectSiteID1 = $get('" & oLC_J_ProjectSiteID.ClientID & "');" &
      "  LC_J_ProjectSiteID1.value = e.get_value();" &
      "}" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("LC_J_ProjectSiteID1") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "LC_J_ProjectSiteID1", strScript)
    End If
    Dim oLC_J_DesignationID As LC_hrmDesignations = FormView1.FindControl("LC_J_DesignationID1")
    oLC_J_DesignationID.Enabled = True
    oLC_J_DesignationID.SelectedValue = String.Empty
    If Not Session("LC_J_DesignationID") Is Nothing Then
      If Session("LC_J_DesignationID") <> String.Empty Then
        oLC_J_DesignationID.SelectedValue = Session("LC_J_DesignationID")
      End If
    End If
    Dim oLC_J_StatusID As LC_hrmStatus = FormView1.FindControl("LC_J_StatusID1")
    oLC_J_StatusID.Enabled = True
    oLC_J_StatusID.SelectedValue = String.Empty
    If Not Session("LC_J_StatusID") Is Nothing Then
      If Session("LC_J_StatusID") <> String.Empty Then
        oLC_J_StatusID.SelectedValue = Session("LC_J_StatusID")
      End If
    End If
    Dim oValidate_CardNo As TextBox = FormView1.FindControl("TextBoxCardNo")
    Dim validateScript As String = "<script type=""text/javascript"">" &
      "  function validate_CardNo(o) {" &
      "    PageMethods.validate_CardNo(o.value, validated_CardNo);" &
      "  }" &
      "  function validated_CardNo(result) {" &
      "    var p = result.split('|');" &
      "    if(p[0]=='1'){" &
      "      alert(p[1]);" &
      "      var o = $get('" & oValidate_CardNo.ClientID & "');" &
      "      o.value='';" &
      "      o.focus();" &
      "    }" &
      "  }" &
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateCardNo") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateCardNo", validateScript)
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_CardNo(ByVal value As String) As String
    Dim mRet As String = "0|"
    Dim oVar As SIS.HRM.hrmNewJoinings = SIS.HRM.hrmNewJoinings.GetByID(value)
    If Not oVar Is Nothing Then
      mRet = "1|Record for " & value & " allready exists."
    End If
    Return mRet
  End Function
End Class
