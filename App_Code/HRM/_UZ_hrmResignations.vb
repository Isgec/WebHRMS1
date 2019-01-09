Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
	Partial Public Class hrmResignations
		Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmResignations) As Int32
			Dim _Result As Integer = 0
			If Record.Resigned Then
				Dim oResignationsHistory As SIS.HRM.hrmResignationsHistory = New SIS.HRM.hrmResignationsHistory
				With oResignationsHistory
					.Cancelled = False
					.CardNo = Record.CardNo
					.Executed = False
					.ReleavedOn = Record.C_DateOfReleaving
					.ResignedOn = Record.C_ResignedOn
					.Remarks = Record.C_ResignedRemark
					.StatusID = Record.C_StatusID
					'Change Status to Resigned to be updated in Main File
					Record.C_StatusID = "RE"
				End With
				SIS.HRM.hrmResignationsHistory.Insert(oResignationsHistory)
				'Record.ActiveState = True
				'Record.ActiveStateEventName = "Resigned"
				'Record.ModifiedEvent = "Resigned"

			End If
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "sphrmResignationsUpdate"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo", SqlDbType.NVarChar, 9, Record.CardNo)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusID", SqlDbType.NVarChar, 3, Record.C_StatusID)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Resigned", SqlDbType.Bit, 3, Record.Resigned)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedOn", SqlDbType.DateTime, 21, IIf(Record.C_ResignedOn = "", Convert.DBNull, Record.C_ResignedOn))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfReleaving", SqlDbType.DateTime, 21, IIf(Record.C_DateOfReleaving = "", Convert.DBNull, Record.C_DateOfReleaving))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedRemark", SqlDbType.NVarChar, 251, IIf(Record.C_ResignedRemark = "", Convert.DBNull, Record.C_ResignedRemark))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState", SqlDbType.Bit, 3, True)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveStateEventName", SqlDbType.NVarChar, 21, "Resigned")
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy", SqlDbType.NVarChar, 21, Global.System.Web.HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn", SqlDbType.DateTime, 21, Now)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent", SqlDbType.NVarChar, 21, "Resigned")
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
