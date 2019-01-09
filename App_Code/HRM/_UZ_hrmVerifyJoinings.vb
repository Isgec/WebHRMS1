Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports SIS.LGM.WebAuthorization
Imports AttendanceSystem
Namespace SIS.HRM
	Partial Public Class hrmVerifyJoinings
		Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmVerifyJoinings) As Int32
      Dim _Result As Integer = 0
      Record = SIS.HRM.hrmVerifyJoinings.GetByID(Record.CardNo)
      If Record.Freezed Then
        Return 0
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "sphrmVerifyJoiningsUpdate"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo", SqlDbType.NVarChar, 9, Record.CardNo)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Freezed", SqlDbType.Bit, 3, 1)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy", SqlDbType.NVarChar, 21, Global.System.Web.HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn", SqlDbType.DateTime, 21, Now)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent", SqlDbType.NVarChar, 21, "Verified")
					Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
					Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
					Con.Open()
					Cmd.ExecuteNonQuery()
					_Result = Cmd.Parameters("@RowCount").Value
				End Using
			End Using
      If _Result > 0 Then
        Record = SIS.HRM.hrmVerifyJoinings.GetByID(Record.CardNo)
        Dim oCurrentProfile As SIS.HRM.hrmCurrentProfile = SIS.HRM.hrmCurrentProfile.GetByID(Record.CardNo)
        With oCurrentProfile
          .ActiveState = True
          .ActiveStateEventName = Record.ModifiedEvent
          .C_BasicSalary = Record.J_BasicSalary
          .C_CompanyID = Record.J_CompanyID
          .C_DepartmentID = Record.J_DepartmentID
          .C_DesignationID = Record.J_DesignationID
          .C_DivisionID = Record.J_DivisionID
          .C_OfficeID = Record.J_OfficeID
          .C_ProjectSiteID = Record.J_ProjectSiteID
          .C_StatusID = Record.J_StatusID
          .C_StatusRemark = Record.J_StatusRemark
          SIS.HRM.hrmCurrentProfile.Update(oCurrentProfile)
        End With
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
            .Circular &= "Company: " & Record.J_CompanyIDHRM_Companies.Description & vbCrLf
            .Circular &= "Location: " & Record.J_OfficeIDHRM_Offices.Description & vbCrLf
            .Circular &= "Department: " & Record.J_DepartmentIDHRM_Departments.Description & vbCrLf
            .Circular &= "Designation: " & Record.J_DesignationIDHRM_Designations.Description & vbCrLf
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
            .Basic = Record.J_BasicSalary
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
                  SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining", SqlDbType.DateTime, 21, IIf(oCurrentProfile.C_DateOfJoining = "", Convert.DBNull, oCurrentProfile.C_DateOfJoining))
                  SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_CompanyID", SqlDbType.NVarChar, 7, IIf(oCurrentProfile.C_CompanyID = "", Convert.DBNull, oCurrentProfile.C_CompanyID))
                  SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DivisionID", SqlDbType.NVarChar, 7, IIf(oCurrentProfile.C_DivisionID = "", Convert.DBNull, oCurrentProfile.C_DivisionID))
                  SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_OfficeID", SqlDbType.Int, 11, IIf(oCurrentProfile.C_OfficeID = "", Convert.DBNull, oCurrentProfile.C_OfficeID))
                  SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DepartmentID", SqlDbType.NVarChar, 7, IIf(oCurrentProfile.C_DepartmentID = "", Convert.DBNull, oCurrentProfile.C_DepartmentID))
                  SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ProjectSiteID", SqlDbType.NVarChar, 7, IIf(oCurrentProfile.C_ProjectSiteID = "", Convert.DBNull, oCurrentProfile.C_ProjectSiteID))
                  SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID", SqlDbType.Int, 11, IIf(oCurrentProfile.C_DesignationID = "", Convert.DBNull, oCurrentProfile.C_DesignationID))
                  SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState", SqlDbType.Bit, 3, oCurrentProfile.ActiveState)
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
        End If
        Return _Result
    End Function
	End Class
End Namespace
