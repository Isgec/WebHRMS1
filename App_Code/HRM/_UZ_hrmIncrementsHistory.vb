Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
	Partial Public Class hrmIncrementsHistory
		Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmIncrementsHistory) As Int32
			Dim _Result As Integer = 0
			If Record.Cancelled Or Record.Executed Then
				If Record.Cancelled Then
					Dim oIncrement As SIS.HRM.hrmIncrements = SIS.HRM.hrmIncrements.GetByID(Record.CardNo)
					With oIncrement
						.U_UnderIncrement = False
						.ModifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
						.ModifiedOn = Now
						.ModifiedEvent = "Increment Cancelled"
					End With
					SIS.HRM.hrmIncrements.Update(oIncrement)
				ElseIf Record.Executed Then
					Dim oIncrement As SIS.HRM.hrmIncrements = SIS.HRM.hrmIncrements.GetByID(Record.CardNo)
					With oIncrement
						.U_UnderIncrement = False
						.C_BasicSalary = .U_NewBasicSalary
						.ModifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
						.ModifiedOn = Now
						.ModifiedEvent = "Incremented"
					End With
					SIS.HRM.hrmIncrements.Update(oIncrement)
				End If
				Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
					Using Cmd As SqlCommand = Con.CreateCommand()
						Cmd.CommandType = CommandType.StoredProcedure
						Cmd.CommandText = "sphrmIncrementsHistoryUpdate"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_IncrementID", SqlDbType.Int, 11, Record.IncrementID)
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
			End If
			Return _Result
		End Function
	End Class
End Namespace
