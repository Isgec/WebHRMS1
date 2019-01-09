
Partial Class Birthday
    Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Dim oEmps As List(Of SIS.HRM.HRM_Employees) = SIS.HRM.HRM_Employees.BirthDays("")
		Dim mDate As String = "<li style=""color:red""><b>" & Now.Day & "<sup><blink>" & IIf(Now.Day = 1 Or Now.Day = 21, "st", IIf(Now.Day = 2 Or Now.Day = 22, "nd", IIf(Now.Day = 3 Or Now.Day = 23, "rd", "th"))) & "</sup> " & MonthName(Now.Month) & "</b></li>"
		Dim mStr As String = mDate
		For Each emp As SIS.HRM.HRM_Employees In oEmps
			mStr &= "<li>" & emp.EmployeeName.ToUpper & " - " & emp.C_DepartmentIDHRM_Departments.Description & "</li>"
		Next
		'mStr &= mDate
		divEmps.InnerHtml = mStr
	End Sub
End Class
