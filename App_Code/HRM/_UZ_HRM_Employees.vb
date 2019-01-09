Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
	Partial Public Class HRM_Employees
		Public Shared Function BirthDays(ByVal orderBy As String) As List(Of SIS.HRM.HRM_Employees)
			Dim Results As List(Of SIS.HRM.HRM_Employees) = Nothing
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spHRM_LG_Birthdays"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
					Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
					Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
					_RecordCount = -1
					Results = New List(Of SIS.HRM.HRM_Employees)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					While (Reader.Read())
						Results.Add(New SIS.HRM.HRM_Employees(Reader))
					End While
					Reader.Close()
					_RecordCount = Cmd.Parameters("@RecordCount").Value
				End Using
			End Using
			Return Results
		End Function
	End Class
End Namespace
