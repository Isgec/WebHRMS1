Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
	Partial Public Class hrmTransfers
		Private _CreateEvent As Boolean = True
		Public Property CreateEvent() As Boolean
			Get
				Return _CreateEvent
			End Get
			Set(ByVal value As Boolean)
				_CreateEvent = value
			End Set
		End Property
		Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmTransfers) As Int32
			Dim _Result As Integer = 0
			If Record.U_UnderTransfer Then
				Dim oTransfersHistory As New SIS.HRM.hrmTransfersHistory
				With oTransfersHistory
					.ActiveState = Record.U_ActiveState
					.Cancelled = False
					.CardNo = Record.CardNo
					.CompanyID = Record.U_CompanyID
					.DepartmentID = Record.U_DepartmentID
					.DivisionID = Record.U_DivisionID
					.Executed = False
					.OfficeID = Record.U_OfficeID
					.ProjectSiteID = Record.U_ProjectSiteID
					.Remarks = Record.C_TransferRemark
					.TransferedOn = Record.C_TransferedOn
					.CreateEvent = Record.CreateEvent
				End With
				SIS.HRM.hrmTransfersHistory.Insert(oTransfersHistory)
			End If
			Return Update(Record)
		End Function
		Public Shared Function TransferExecuted(ByVal Record As SIS.HRM.hrmTransfers) As Int32
			Dim _Result As Integer = 0
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "sphrm_LG_TransferExecuted"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo", SqlDbType.NVarChar, 9, Record.CardNo)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_CompanyID", SqlDbType.NVarChar, 7, IIf(Record.U_CompanyID = "", Convert.DBNull, Record.U_CompanyID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DivisionID", SqlDbType.NVarChar, 7, IIf(Record.U_DivisionID = "", Convert.DBNull, Record.U_DivisionID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_OfficeID", SqlDbType.Int, 11, IIf(Record.U_OfficeID = "", Convert.DBNull, Record.U_OfficeID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DepartmentID", SqlDbType.NVarChar, 7, IIf(Record.U_DepartmentID = "", Convert.DBNull, Record.U_DepartmentID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ProjectSiteID", SqlDbType.NVarChar, 7, IIf(Record.U_ProjectSiteID = "", Convert.DBNull, Record.U_ProjectSiteID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState", SqlDbType.Bit, 3, Record.U_ActiveState)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy", SqlDbType.NVarChar, 21, Global.System.Web.HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn", SqlDbType.DateTime, 21, Now)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent", SqlDbType.NVarChar, 21, "Transfer")
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveStateEventName", SqlDbType.NVarChar, 21, "Transfered")



					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderTransfer", SqlDbType.Bit, 3, False)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_CompanyID", SqlDbType.NVarChar, 7, Convert.DBNull)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_DivisionID", SqlDbType.NVarChar, 7, Convert.DBNull)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_OfficeID", SqlDbType.Int, 11, Convert.DBNull)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_DepartmentID", SqlDbType.NVarChar, 7, Convert.DBNull)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_ProjectSiteID", SqlDbType.NVarChar, 7, Convert.DBNull)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_ActiveState", SqlDbType.Bit, 3, False)
					Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
					Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
					Con.Open()
					Cmd.ExecuteNonQuery()
					_Result = Cmd.Parameters("@RowCount").Value
				End Using
			End Using
			Return _Result
		End Function

	End Class
End Namespace
