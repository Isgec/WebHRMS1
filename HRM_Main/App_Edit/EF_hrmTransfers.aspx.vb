Partial Class EF_hrmTransfers
  Inherits SIS.SYS.UpdateBase
  Protected Sub FormView1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.Init
    DataClassName = "hrmNewJoinings"
    SetFormView = FormView1
  End Sub
  Protected Sub ToolBar0_1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolBar0_1.Init
    SetToolBar = ToolBar0_1
  End Sub
  Protected Sub FormView1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FormView1.PreRender
    Dim oLC_U_CompanyID As LC_hrmCompanies = FormView1.FindControl("LC_U_CompanyID1")
    oLC_U_CompanyID.SelectedValue = oData.C_CompanyID
    Dim oLC_U_DivisionID As LC_hrmDivisions = FormView1.FindControl("LC_U_DivisionID1")
    oLC_U_DivisionID.SelectedValue = oData.C_DivisionID
    Dim oLC_U_OfficeID As LC_hrmOffices = FormView1.FindControl("LC_U_OfficeID1")
    oLC_U_OfficeID.SelectedValue = oData.C_OfficeID
    Dim oLC_U_DepartmentID As LC_hrmDepartments = FormView1.FindControl("LC_U_DepartmentID1")
    oLC_U_DepartmentID.SelectedValue = oData.C_DepartmentID
    Dim oLC_U_ProjectSiteID As LC_hrmProjects = FormView1.FindControl("LC_U_ProjectSiteID1")
    oLC_U_ProjectSiteID.SelectedValue = oData.C_ProjectSiteID
    Dim oActiveStat As CheckBox = FormView1.FindControl("CheckBoxU_ActiveState")
    oActiveStat.Checked = oData.ActiveState
  End Sub
  Dim oData As SIS.HRM.hrmTransfers = Nothing
	Protected Sub ObjectDataSource1_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ObjectDataSource1.Selected
		oData = e.ReturnValue
	End Sub
End Class
