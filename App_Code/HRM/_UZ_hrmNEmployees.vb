Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  Partial Public Class hrmNEmployees
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
    Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmNEmployees) As SIS.HRM.hrmNEmployees
      'Update E-Mail, Cell, Deptt, Desig, Office, Company, Division, Active, Contractual,DOJ,ProjectSiteID, VPN_Expires in WebUser 
      'Update Cell No in VPN User
      '1. Web User
      Dim oUser As SIS.HRM.hrmWebUsers = SIS.HRM.hrmWebUsers.GetByID(Record.CardNo)
      If oUser IsNot Nothing Then
        With oUser
          .MobileNo = Record.ContactNumbers
          .EMailID = Record.EMailID
          .C_DateOfJoining = Record.C_DateOfJoining
          .C_CompanyID = Record.C_CompanyID
          .C_DivisionID = Record.C_DivisionID
          .C_OfficeID = Record.C_OfficeID
          .C_DepartmentID = Record.C_DepartmentID
          .C_ProjectSiteID = Record.C_ProjectSiteID
          .C_DesignationID = Record.C_DesignationID
          .ActiveState = Record.ActiveState
          .VPN_Expires = Record.VPNMailExpireOn
          .Contractual = Record.Contractual
        End With
        SIS.HRM.hrmWebUsers.UpdateData(oUser)
      End If
      '3. Update Employee Master
      Return SIS.HRM.hrmNEmployees.Update(Record)
    End Function
  End Class
End Namespace
