Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
	Partial Public Class hrmIncrements
		Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmIncrements) As Int32
			Dim _Result As Integer = 0
			If Record.U_UnderIncrement Then
				Dim oIncrementHistory As New SIS.HRM.hrmIncrementsHistory
				With oIncrementHistory
					.BasicSalary = Record.U_NewBasicSalary
					.Cancelled = False
					.CardNo = Record.CardNo
					.Executed = False
					.IncrementOn = Record.C_IncrementOn
					.Remarks = Record.C_IncrementRemark
				End With
				SIS.HRM.hrmIncrementsHistory.Insert(oIncrementHistory)
			End If
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "sphrmIncrementsUpdate"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo", SqlDbType.NVarChar, 9, Record.CardNo)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_BasicSalary", SqlDbType.Decimal, 15, Record.C_BasicSalary)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderIncrement", SqlDbType.Bit, 3, Record.U_UnderIncrement)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewBasicSalary", SqlDbType.Decimal, 15, IIf(Record.U_NewBasicSalary = "", Convert.DBNull, Record.U_NewBasicSalary))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_IncrementOn", SqlDbType.DateTime, 21, IIf(Record.C_IncrementOn = "", Convert.DBNull, Record.C_IncrementOn))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_IncrementRemark", SqlDbType.NVarChar, 251, IIf(Record.C_IncrementRemark = "", Convert.DBNull, Record.C_IncrementRemark))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent", SqlDbType.NVarChar, 21, "Increment")
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn", SqlDbType.DateTime, 21, Now)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy", SqlDbType.NVarChar, 21, Global.System.Web.HttpContext.Current.Session("LoginID"))
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
