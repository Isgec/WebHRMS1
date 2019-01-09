Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
	Partial Public Class hrmTransfersHistory
		Private _CreateEvent As Boolean = True
		Public Property CreateEvent() As Boolean
			Get
				Return _CreateEvent
			End Get
			Set(ByVal value As Boolean)
				_CreateEvent = value
			End Set
		End Property
		Public Shared Function UZ_UpdateSite(ByVal Record As SIS.HRM.hrmTransfersHistory) As Int32
			Dim _Result As Integer = 1
			If Record.Executed Or Record.Cancelled Then
				If Record.Cancelled Then
					Dim oTransfer As SIS.HRM.hrmTransfers = SIS.HRM.hrmTransfers.GetByID(Record.CardNo)
					With oTransfer
						.U_UnderTransfer = False
						.ModifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
						.ModifiedOn = Now
						.ModifiedEvent = "Transfer Cancelled"
					End With
					SIS.HRM.hrmTransfers.Update(oTransfer)
					Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
						Using Cmd As SqlCommand = Con.CreateCommand()
							Cmd.CommandType = CommandType.StoredProcedure
							Cmd.CommandText = "sphrmTransfersHistoryUpdate"
							SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_TransferID", SqlDbType.Int, 11, Record.TransferID)
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
				ElseIf Record.Executed Then
					Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
						Using Cmd As SqlCommand = Con.CreateCommand()
							Record.VerifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
							Record.VerifiedOn = Now
							Cmd.CommandType = CommandType.Text
							Cmd.CommandText = "UPDATE HRM_Transfers SET VerifiedBy = '" & Record.VerifiedBy & "', VerifiedOn = " & Record.VerifiedOn & " WHERE TransferID =" & Record.TransferID
							Con.Open()
							Cmd.ExecuteNonQuery()
						End Using
					End Using
				End If
			End If
			Return _Result
		End Function
		Public Shared Function UZ_Update(ByVal Record As SIS.HRM.hrmTransfersHistory) As Int32
			Dim _Result As Integer = 0
			If Record.Executed Or Record.Cancelled Then
				If Record.Cancelled Then
					Dim oTransfer As SIS.HRM.hrmTransfers = SIS.HRM.hrmTransfers.GetByID(Record.CardNo)
					With oTransfer
						.U_UnderTransfer = False
						.ModifiedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
						.ModifiedOn = Now
						.ModifiedEvent = "Transfer Cancelled"
					End With
					SIS.HRM.hrmTransfers.Update(oTransfer)
				ElseIf Record.Executed Then
					Dim EventDescription As String = ""
					Dim oTransfer As SIS.HRM.hrmTransfers = SIS.HRM.hrmTransfers.GetByID(Record.CardNo)
					With oTransfer
						'If Create Event was selected by user
						If Record.CreateEvent Then
							If .C_CompanyID <> .U_CompanyID Then
								EventDescription = "Company Changed to: " & .U_CompanyID
							End If
							If .C_DivisionID <> .U_DivisionID Then
								If EventDescription <> "" Then
									EventDescription = EventDescription & ", " & "Division changed to: " & .U_DivisionID
								Else
									EventDescription = "Division changed to: " & .U_DivisionID
								End If
							End If
							If .C_OfficeID <> .U_OfficeID Then
								If EventDescription <> "" Then
									EventDescription = EventDescription & ", " & "Location changed to: " & .U_OfficeID
								Else
									EventDescription = "Location changed to: " & .U_OfficeID
								End If
							End If
							If .C_DepartmentID <> .U_DepartmentID Then
								If EventDescription <> "" Then
									EventDescription = EventDescription & ", " & "Department changed to: " & .U_DepartmentID
								Else
									EventDescription = "Department changed to: " & .U_DepartmentID
								End If
							End If
							If .C_ProjectSiteID <> .U_ProjectSiteID Then
								If EventDescription <> "" Then
									EventDescription = EventDescription & ", " & "Project Site changed to: " & .U_ProjectSiteID
								Else
									EventDescription = "Project Site changed to: " & .U_ProjectSiteID
								End If
							End If
							If .ActiveState <> .U_ActiveState Then
								If EventDescription <> "" Then
									EventDescription = EventDescription & ", " & "Active State changed to: " & .U_ActiveState
								Else
									EventDescription = "Active State changed to: " & .U_ActiveState
								End If
							End If
							Try
								Dim oRef As New HRISEvents.wsWebHrAdm1
								Dim oEvt As HRISEvents.admITEventTransactions = oRef.EventTransaction
								With oEvt
									.CardNo = Record.CardNo
									.Description = EventDescription
									.EventDate = Record.TransferedOn
									.Circular = EventDescription
								End With
								oRef.CreateEventTransaction(oEvt)
							Catch ex As Exception
								Throw New Exception(ex.Message)
							End Try
						End If
						'End of Create Event
					End With
					SIS.HRM.hrmTransfers.TransferExecuted(oTransfer)
				End If
				Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
					Using Cmd As SqlCommand = Con.CreateCommand()
						Cmd.CommandType = CommandType.StoredProcedure
						Cmd.CommandText = "sphrmTransfersHistoryUpdate"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_TransferID", SqlDbType.Int, 11, Record.TransferID)
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
