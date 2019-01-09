Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.IDM
  Partial Public Class idmProjects
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
		Public Shared Function UZ_GetByID(ByVal ProjectID As String) As SIS.IDM.idmProjects
			Dim Results As SIS.IDM.idmProjects = Nothing
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spidm_LG_ProjectsSelectByID"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, Global.System.Web.HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PRFilter", SqlDbType.Bit, 3, Global.System.Web.HttpContext.Current.Session("PRFilter"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID", SqlDbType.NVarChar, ProjectID.ToString.Length, ProjectID)
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.IDM.idmProjects(Reader)
					End If
					Reader.Close()
				End Using
			End Using
			Return Results
		End Function
		Public Shared Function UZ_SelectList(ByVal OrderBy As String) As List(Of SIS.IDM.idmProjects)
			Dim Results As List(Of SIS.IDM.idmProjects) = Nothing
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spidm_LG_ProjectsSelectList"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, Global.System.Web.HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PRFilter", SqlDbType.Bit, 3, Global.System.Web.HttpContext.Current.Session("PRFilter"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
					Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
					Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
					_RecordCount = -1
					Results = New List(Of SIS.IDM.idmProjects)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					While (Reader.Read())
						Results.Add(New SIS.IDM.idmProjects(Reader))
					End While
					Reader.Close()
					_RecordCount = Cmd.Parameters("@RecordCount").Value
				End Using
			End Using
			Return Results
		End Function
		Public Shared Function UZ_SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal CustomerID As String) As List(Of SIS.IDM.idmProjects)
			Dim Results As List(Of SIS.IDM.idmProjects) = Nothing
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spidm_LG_ProjectsSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spidm_LG_ProjectsSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ProjectID", SqlDbType.NVarChar, 6, IIf(ProjectID Is Nothing, String.Empty, ProjectID))
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CustomerID", SqlDbType.NVarChar, 6, IIf(CustomerID Is Nothing, String.Empty, CustomerID))
					End If
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, Global.System.Web.HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PRFilter", SqlDbType.Bit, 3, Global.System.Web.HttpContext.Current.Session("PRFilter"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
					Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
					Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
					_RecordCount = -1
					Results = New List(Of SIS.IDM.idmProjects)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					While (Reader.Read())
						Results.Add(New SIS.IDM.idmProjects(Reader))
					End While
					Reader.Close()
					_RecordCount = Cmd.Parameters("@RecordCount").Value
				End Using
			End Using
			Return Results
		End Function
		Public Shared Function UZ_SelectidmProjectsAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
			Dim Results As List(Of String) = Nothing
			Dim aVal() As String = contextKey.Split("|".ToCharArray)
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spidm_LG_ProjectsAutoCompleteList"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, Global.System.Web.HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PRFilter", SqlDbType.Bit, 3, Global.System.Web.HttpContext.Current.Session("PRFilter"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix), 0, IIf(Prefix.ToLower = Prefix, 0, 1)))
					Results = New List(Of String)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Not Reader.HasRows Then
						Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(50, " "), ""))
					End If
					While (Reader.Read())
						Dim Tmp As SIS.IDM.idmProjects = New SIS.IDM.idmProjects(Reader)
						Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
					End While
					Reader.Close()
				End Using
			End Using
			Return Results.ToArray
		End Function
	End Class
End Namespace
