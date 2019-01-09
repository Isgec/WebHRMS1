Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://WebHrms.services/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class HRMSServices
	Inherits System.Web.Services.WebService

	<WebMethod()> _
	Public Function Employee(ByVal CardNo As String) As SIS.HRM.hrmEmployees
		Return SIS.HRM.hrmEmployees.GetByID(CardNo)
	End Function
	<WebMethod()> _
	Public Function Office(ByVal OfficeID As Integer) As SIS.HRM.hrmOffices
		Return SIS.HRM.hrmOffices.GetByID(OfficeID)
	End Function
	<WebMethod()> _
	Public Function Department(ByVal DepartmentID As String) As SIS.HRM.hrmDepartments
		Return SIS.HRM.hrmDepartments.GetByID(DepartmentID)
	End Function
	<WebMethod()> _
	Public Function Designation(ByVal DesignationID As Integer) As SIS.HRM.hrmDesignations
		Return SIS.HRM.hrmDesignations.GetByID(DesignationID)
	End Function
	<WebMethod()> _
	Public Function Company(ByVal CompanyID As String) As SIS.HRM.hrmCompanies
		Return SIS.HRM.hrmCompanies.GetByID(CompanyID)
	End Function
	<WebMethod()> _
	Public Function ProjectSite(ByVal ProjectID As String) As SIS.HRM.hrmProjects
		Return SIS.HRM.hrmProjects.GetByID(ProjectID)
	End Function
	<WebMethod()> _
	Public Function Division(ByVal DivisionID As String) As SIS.HRM.hrmDivisions
		Return SIS.HRM.hrmDivisions.GetByID(DivisionID)
	End Function

End Class
