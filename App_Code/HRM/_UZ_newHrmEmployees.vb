Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  Partial Public Class newHrmEmployees
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Blue
      Return mRet
    End Function
    Public Function GetVisible() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEnable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEditable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetDeleteable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public ReadOnly Property Editable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Deleteable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetDeleteable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function UZ_newHrmEmployeesSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal CardNo As String, ByVal C_OfficeID As Int32, ByVal C_DepartmentID As String, ByVal C_DesignationID As Int32, ByVal CategoryID As Int32) As List(Of SIS.HRM.newHrmEmployees)
      Dim Results As List(Of SIS.HRM.newHrmEmployees) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "EmployeeName"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spatn_LG_newHrmEmployeesSelectListSearch"
            Cmd.CommandText = "spnewHrmEmployeesSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spatn_LG_newHrmEmployeesSelectListFilteres"
            Cmd.CommandText = "spnewHrmEmployeesSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CardNo", SqlDbType.NVarChar, 8, IIf(CardNo Is Nothing, String.Empty, CardNo))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_C_OfficeID", SqlDbType.Int, 10, IIf(C_OfficeID = Nothing, 0, C_OfficeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_C_DepartmentID", SqlDbType.NVarChar, 6, IIf(C_DepartmentID Is Nothing, String.Empty, C_DepartmentID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_C_DesignationID", SqlDbType.Int, 10, IIf(C_DesignationID = Nothing, 0, C_DesignationID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CategoryID", SqlDbType.Int, 10, IIf(CategoryID = Nothing, 0, CategoryID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.newHrmEmployees)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.newHrmEmployees(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_newHrmEmployeesInsert(ByVal Record As SIS.HRM.newHrmEmployees) As SIS.HRM.newHrmEmployees
      Dim _Result As SIS.HRM.newHrmEmployees = newHrmEmployeesInsert(Record)
      'Create Event
      Dim oRef As New HRISEvents.wsWebHrAdm1
      Dim oEvt As HRISEvents.admITEventTransactions = oRef.EventTransaction
      With oEvt
        .CardNo = Record.CardNo
        .EventDate = Record.C_DateOfJoining
        .Description = "New Joining: [" & Record.CardNo & "] " & Record.EmployeeName & vbCrLf
        .Description &= "Date of joining: " & Record.C_DateOfJoining
        Try
          .Circular = "Employee ID: " & Record.CardNo & vbCrLf
          .Circular &= "Employee Name: " & Record.EmployeeName & vbCrLf
          .Circular &= "Company: " & Record.FK_HRM_Employees_HRM_Companies.Description & vbCrLf
          .Circular &= "Location: " & Record.FK_HRM_Employees_HRM_Offices.Description & vbCrLf
          .Circular &= "Department: " & Record.FK_HRM_Employees_HRM_Departments.Description & vbCrLf
          .Circular &= "Designation: " & Record.FK_HRM_Employees_HRM_Designations.Description & vbCrLf
        Catch ex As Exception
        End Try
      End With
      Try
        oRef.CreateEventTransaction(oEvt)
      Catch ex As Exception
      End Try
      'End Of Create Event
      'Create Record in Perks
      Dim oPrkEmp As SIS.PRK.PrkEmployees = SIS.PRK.PrkEmployees.GetByID(Record.CardNo)
      If oPrkEmp Is Nothing Then
        oPrkEmp = New SIS.PRK.PrkEmployees
        With oPrkEmp
          .EmployeeID = Record.CardNo
          .CardNo = Record.CardNo
          .EmployeeName = Record.EmployeeName
          .DOJ = Record.C_DateOfJoining
          .DOR = ""
          .CategoryID = 16
          .Company = "200"
          .Department = "ACC-I"
          .ESI = False
          .MaintenanceAllowed = False
          .PostedAt = "Office"
          .VehicleType = "None"
          .Basic = Record.C_BasicSalary
          SIS.PRK.PrkEmployees.Insert(oPrkEmp)
        End With
      End If
      'Create Web Login
      Dim oUsr As MembershipUser = Membership.GetUser(Record.CardNo)
      If oUsr Is Nothing Then
        Try
          oUsr = Membership.CreateUser(Record.CardNo, Record.CardNo)
          If Not oUsr Is Nothing Then
            Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
              Using Cmd As SqlCommand = Con.CreateCommand()
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.CommandText = "spVRUsersUpdate"
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_UserName", SqlDbType.NVarChar, 21, Record.CardNo)
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UserFullName", SqlDbType.NVarChar, 51, Record.EmployeeName)
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining", SqlDbType.DateTime, 21, IIf(Record.C_DateOfJoining = "", Convert.DBNull, Record.C_DateOfJoining))
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_CompanyID", SqlDbType.NVarChar, 7, IIf(Record.C_CompanyID = "", Convert.DBNull, Record.C_CompanyID))
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DivisionID", SqlDbType.NVarChar, 7, IIf(Record.C_DivisionID = "", Convert.DBNull, Record.C_DivisionID))
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_OfficeID", SqlDbType.Int, 11, IIf(Record.C_OfficeID = "", Convert.DBNull, Record.C_OfficeID))
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DepartmentID", SqlDbType.NVarChar, 7, IIf(Record.C_DepartmentID = "", Convert.DBNull, Record.C_DepartmentID))
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ProjectSiteID", SqlDbType.NVarChar, 7, IIf(Record.C_ProjectSiteID = "", Convert.DBNull, Record.C_ProjectSiteID))
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID", SqlDbType.Int, 11, IIf(Record.C_DesignationID = "", Convert.DBNull, Record.C_DesignationID))
                SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState", SqlDbType.Bit, 3, Record.ActiveState)
                Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
                Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
                Con.Open()
                Cmd.ExecuteNonQuery()
              End Using
            End Using
          End If
        Catch ex As Exception
        End Try
      End If
      'Create User Authorization
      Dim oWS As New WebAuth.WebAuthorizationService
      Dim UseLive As Boolean = Convert.ToBoolean(Web.Configuration.WebConfigurationManager.AppSettings("UseLive").ToString)
      Dim aAuth() As String = {""}
      If UseLive Then
        aAuth = Web.Configuration.WebConfigurationManager.AppSettings("LiveAuth").ToString.Split(",".ToCharArray)
      Else
        aAuth = Web.Configuration.WebConfigurationManager.AppSettings("TestAuth").ToString.Split(",".ToCharArray)
      End If
      Dim str As String = ""
      For Each auth As String In aAuth
        Dim appl As String = ""
        Dim role As String = ""
        Dim tmp() As String = auth.Split(":".ToCharArray)
        appl = tmp(0)
        role = tmp(1)
        str = oWS.CreateWebAuthorization(appl, oUsr.UserName, role)
      Next
      Return _Result
    End Function
    Public Shared Function UZ_newHrmEmployeesUpdate(ByVal Record As SIS.HRM.newHrmEmployees) As SIS.HRM.newHrmEmployees
      Dim _Result As SIS.HRM.newHrmEmployees = newHrmEmployeesUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_newHrmEmployeesDelete(ByVal Record As SIS.HRM.newHrmEmployees) As Integer
      Dim _Result As Integer = newHrmEmployeesDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_CardNo"), TextBox).Text = ""
          CType(.FindControl("F_EmployeeName"), TextBox).Text = ""
          CType(.FindControl("F_C_DivisionID"), Object).SelectedValue = ""
          CType(.FindControl("F_C_OfficeID"), Object).SelectedValue = ""
          CType(.FindControl("F_C_DepartmentID"), Object).SelectedValue = ""
          CType(.FindControl("F_C_DesignationID"), Object).SelectedValue = ""
          CType(.FindControl("F_ActiveState"), CheckBox).Checked = False
          CType(.FindControl("F_CategoryID"), Object).SelectedValue = ""
          CType(.FindControl("F_Salute"), TextBox).Text = ""
          CType(.FindControl("F_Gender"), TextBox).Text = ""
          CType(.FindControl("F_C_DateOfJoining"), TextBox).Text = ""
          CType(.FindControl("F_C_ProjectSiteID"), TextBox).Text = ""
          CType(.FindControl("F_C_ProjectSiteID_Display"), Label).Text = ""
          CType(.FindControl("F_C_BasicSalary"), TextBox).Text = 0
          CType(.FindControl("F_C_StatusID"), DropDownList).SelectedValue = ""
          CType(.FindControl("F_Resigned"), CheckBox).Checked = False
          CType(.FindControl("F_C_ResignedOn"), TextBox).Text = ""
          CType(.FindControl("F_C_DateOfReleaving"), TextBox).Text = ""
          CType(.FindControl("F_C_ResignedRemark"), TextBox).Text = ""
          CType(.FindControl("F_Confirmed"), CheckBox).Checked = False
          CType(.FindControl("F_C_ConfirmedOn"), TextBox).Text = ""
          CType(.FindControl("F_C_ConfirmationRemark"), TextBox).Text = ""
          CType(.FindControl("F_DateOfBirth"), TextBox).Text = ""
          CType(.FindControl("F_FatherName"), TextBox).Text = ""
          CType(.FindControl("F_ContactNumbers"), TextBox).Text = ""
          CType(.FindControl("F_OfficeFileNumber"), TextBox).Text = ""
          CType(.FindControl("F_PFNumber"), TextBox).Text = ""
          CType(.FindControl("F_PAN"), TextBox).Text = ""
          CType(.FindControl("F_ModifiedBy"), TextBox).Text = ""
          CType(.FindControl("F_Freezed"), CheckBox).Checked = False
          CType(.FindControl("F_ESINumber"), TextBox).Text = ""
          CType(.FindControl("F_VerifierID"), TextBox).Text = ""
          CType(.FindControl("F_VerifierID_Display"), Label).Text = ""
          CType(.FindControl("F_VerificationRequired"), CheckBox).Checked = False
          CType(.FindControl("F_C_CompanyID"), Object).SelectedValue = ""
          CType(.FindControl("F_ApprovalRequired"), CheckBox).Checked = False
          CType(.FindControl("F_ModifiedOn"), TextBox).Text = ""
          CType(.FindControl("F_EMailID"), TextBox).Text = ""
          CType(.FindControl("F_ApproverID"), TextBox).Text = ""
          CType(.FindControl("F_ApproverID_Display"), Label).Text = ""
          CType(.FindControl("F_Contractual"), CheckBox).Checked = False
          CType(.FindControl("F_SiteAllowanceApprover"), TextBox).Text = ""
          CType(.FindControl("F_SiteAllowanceApprover_Display"), Label).Text = ""
          CType(.FindControl("F_TASelfApproval"), CheckBox).Checked = False
          CType(.FindControl("F_NonTechnical"), CheckBox).Checked = False
          CType(.FindControl("F_TAVerifier"), TextBox).Text = ""
          CType(.FindControl("F_TAVerifier_Display"), Label).Text = ""
          CType(.FindControl("F_TASanctioningAuthority"), TextBox).Text = ""
          CType(.FindControl("F_TASanctioningAuthority_Display"), Label).Text = ""
          CType(.FindControl("F_TAApprover"), TextBox).Text = ""
          CType(.FindControl("F_TAApprover_Display"), Label).Text = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
