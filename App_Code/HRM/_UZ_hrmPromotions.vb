Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
	Partial Public Class hrmPromotions
		Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmPromotions) As Int32
			Dim _Result As Integer = 0
			If Record.U_UnderPromotion Then
				Dim oPromotionHistory As New SIS.HRM.hrmPromotionsHistory
				With oPromotionHistory
					.Cancelled = False
					.CardNo = Record.CardNo
					.DesignationID = Record.U_NewDesignationID
					.Executed = False
					.PromotionOn = Record.C_PromotionOn
					.Remarks = Record.C_PromotionRemark
				End With
				SIS.HRM.hrmPromotionsHistory.Insert(oPromotionHistory)
			End If
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "sphrmPromotionsUpdate"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo", SqlDbType.NVarChar, 9, Record.CardNo)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID", SqlDbType.Int, 11, Record.C_DesignationID)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderPromotion", SqlDbType.Bit, 3, Record.U_UnderPromotion)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewDesignationID", SqlDbType.Int, 11, IIf(Record.U_NewDesignationID = "", Convert.DBNull, Record.U_NewDesignationID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionOn", SqlDbType.DateTime, 21, IIf(Record.C_PromotionOn = "", Convert.DBNull, Record.C_PromotionOn))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionRemark", SqlDbType.NVarChar, 251, IIf(Record.C_PromotionRemark = "", Convert.DBNull, Record.C_PromotionRemark))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent", SqlDbType.NVarChar, 21, "Promotion")
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
