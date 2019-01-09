Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
	Partial Public Class hrmPromotionsHistory
		Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmPromotionsHistory) As Int32
			Dim _Result As Integer = 0
			If Record.Executed Or Record.Cancelled Then
				If Record.Cancelled Then
					Dim oPromotion As SIS.HRM.hrmPromotions = SIS.HRM.hrmPromotions.GetByID(Record.CardNo)
					With oPromotion
						.U_UnderPromotion = False
						.ModifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
						.ModifiedOn = Now
						.ModifiedEvent = "Promotion Cancelled"
					End With
					SIS.HRM.hrmPromotions.Update(oPromotion)
				ElseIf Record.Executed Then
					Dim oPromotion As SIS.HRM.hrmPromotions = SIS.HRM.hrmPromotions.GetByID(Record.CardNo)
					With oPromotion
						.C_DesignationID = .U_NewDesignationID
						.U_UnderPromotion = False
						.ModifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
						.ModifiedOn = Now
						.ModifiedEvent = "Promoted"
					End With
					SIS.HRM.hrmPromotions.Update(oPromotion)
				End If
				Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
					Using Cmd As SqlCommand = Con.CreateCommand()
						Cmd.CommandType = CommandType.StoredProcedure
						Cmd.CommandText = "sphrmPromotionsHistoryUpdate"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_PromotionID", SqlDbType.Int, 11, Record.PromotionID)
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
