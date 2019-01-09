Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  Partial Public Class hrmResignationsHistory
    Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmResignationsHistory) As Int32
      Dim _Result As Integer = 0
      If Record.Cancelled Then
        Dim oResignation As SIS.HRM.hrmResignations = SIS.HRM.hrmResignations.GetByID(Record.CardNo)
        With oResignation
          .C_StatusID = Record.StatusID
          .Resigned = False
          .C_DateOfReleaving = ""
          .C_ResignedOn = ""
          .C_ResignedRemark = ""
          .ModifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
          .ModifiedOn = Now
          .ModifiedEvent = "Resigne Cancelled"
        End With
        SIS.HRM.hrmResignations.Update(oResignation)
      ElseIf Record.Executed Then
        Dim oResignation As SIS.HRM.hrmResignations = SIS.HRM.hrmResignations.GetByID(Record.CardNo)
        With oResignation
          'Create Event
          Dim oRef As New HRISEvents.wsWebHrAdm1
          Dim oEvt As HRISEvents.admITEventTransactions = oRef.EventTransaction
          With oEvt
            .CardNo = oResignation.CardNo
            .EventDate = oResignation.C_DateOfReleaving
            .Description = "Resigned: [" & Record.CardNo & "] " & oResignation.EmployeeName & vbCrLf
            .Description &= "Date of releaving: " & oResignation.C_DateOfReleaving
            Try
              .Circular = "Employee ID: " & oResignation.CardNo & vbCrLf
              .Circular &= "Employee Name: " & oResignation.EmployeeName & vbCrLf
              .Circular &= "Department: " & oResignation.C_DepartmentIDHRM_Departments.Description & vbCrLf
              .Circular &= "Designation: " & oResignation.C_DesignationIDHRM_Designations.Description & vbCrLf
            Catch ex As Exception
            End Try
          End With
          oRef.CreateEventTransaction(oEvt)
          'End Of Create Event

          .ActiveState = False
          .ActiveStateEventName = "Releaved"
          .C_StatusID = "RL"
          .ModifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
          .ModifiedOn = Now
          .ModifiedEvent = "Resigne Executed"
        End With
        SIS.HRM.hrmResignations.Update(oResignation)
        '===================
        'Deactivate WebLogin
        '===================
        Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "UPDATE aspnet_membership SET IsLockedOut = 1 WHERE UserID = (SELECT UserID FROM aspnet_users WHERE UserName = '" & Record.CardNo & "')"
            Con.Open()
            Cmd.ExecuteNonQuery()
          End Using
        End Using
        'End Of Deactivate Web Login
        '===========================
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmResignationsHistoryUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ResignID", SqlDbType.Int, 11, Record.ResignID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Executed", SqlDbType.Bit, 3, Record.Executed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Cancelled", SqlDbType.Bit, 3, Record.Cancelled)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessedBy", SqlDbType.NVarChar, 9, Global.System.Web.HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessedOn", SqlDbType.DateTime, 21, Now)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      '==================
      'Delete Invalid Attendance Date
      RemoveAttendanceAfterReleavingDate(Record.CardNo)
      '==================
      Return _Result
    End Function
    Public Shared Sub RemoveAttendanceAfterReleavingDate(ByVal CardNo As String)
      Dim oEmp As SIS.HRM.hrmNEmployees = SIS.HRM.hrmNEmployees.GetByID(CardNo)
      If oEmp.C_DateOfReleaving <> String.Empty Then
        Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.CommandText = "spatn_LG_RemoveAttendanceAfterReleaving"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo", SqlDbType.NVarChar, 8, CardNo)
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfReleaving", SqlDbType.DateTime, 20, oEmp.C_DateOfReleaving)
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining", SqlDbType.DateTime, 20, oEmp.C_DateOfJoining)
            Con.Open()
            Cmd.ExecuteNonQuery()
          End Using
        End Using
      End If
    End Sub

  End Class
End Namespace
