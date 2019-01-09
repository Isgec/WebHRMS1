Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.IDM
  <DataObject()> _
  Partial Public Class idmProjects
    Private Shared _RecordCount As Integer
    Private _ProjectID As String = ""
    Private _Description As String = ""
    Private _CustomerID As String = ""
    Private _CustomerOrderReference As String = ""
    Private _ContactPerson As String = ""
    Private _EmailID As String = ""
    Private _ContactNo As String = ""
    Private _Address1 As String = ""
    Private _Address2 As String = ""
    Private _Address3 As String = ""
    Private _Address4 As String = ""
    Private _ToEMailID As String = ""
    Private _CCEmailID As String = ""
    Private _IDM_Customers1_Description As String = ""
    Private _FK_PRJ_CustomerID As SIS.IDM.idmCustomers = Nothing
    Public ReadOnly Property ForeColor() As System.Drawing.Color
      Get
        Dim mRet As System.Drawing.Color = Drawing.Color.Blue
        Try
					mRet = GetColor()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Visible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
					mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Enable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
					mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Property ProjectID() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
        _ProjectID = value
      End Set
    End Property
    Public Property Description() As String
      Get
        Return _Description
      End Get
      Set(ByVal value As String)
        _Description = value
      End Set
    End Property
    Public Property CustomerID() As String
      Get
        Return _CustomerID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CustomerID = ""
				 Else
					 _CustomerID = value
			   End If
      End Set
    End Property
    Public Property CustomerOrderReference() As String
      Get
        Return _CustomerOrderReference
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CustomerOrderReference = ""
				 Else
					 _CustomerOrderReference = value
			   End If
      End Set
    End Property
    Public Property ContactPerson() As String
      Get
        Return _ContactPerson
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ContactPerson = ""
				 Else
					 _ContactPerson = value
			   End If
      End Set
    End Property
    Public Property EmailID() As String
      Get
        Return _EmailID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _EmailID = ""
				 Else
					 _EmailID = value
			   End If
      End Set
    End Property
    Public Property ContactNo() As String
      Get
        Return _ContactNo
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ContactNo = ""
				 Else
					 _ContactNo = value
			   End If
      End Set
    End Property
    Public Property Address1() As String
      Get
        Return _Address1
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Address1 = ""
				 Else
					 _Address1 = value
			   End If
      End Set
    End Property
    Public Property Address2() As String
      Get
        Return _Address2
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Address2 = ""
				 Else
					 _Address2 = value
			   End If
      End Set
    End Property
    Public Property Address3() As String
      Get
        Return _Address3
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Address3 = ""
				 Else
					 _Address3 = value
			   End If
      End Set
    End Property
    Public Property Address4() As String
      Get
        Return _Address4
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Address4 = ""
				 Else
					 _Address4 = value
			   End If
      End Set
    End Property
    Public Property ToEMailID() As String
      Get
        Return _ToEMailID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ToEMailID = ""
				 Else
					 _ToEMailID = value
			   End If
      End Set
    End Property
    Public Property CCEmailID() As String
      Get
        Return _CCEmailID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CCEmailID = ""
				 Else
					 _CCEmailID = value
			   End If
      End Set
    End Property
    Public Property IDM_Customers1_Description() As String
      Get
        Return _IDM_Customers1_Description
      End Get
      Set(ByVal value As String)
        _IDM_Customers1_Description = value
      End Set
    End Property
    Public Property DisplayField() As String
      Get
        Return "" & _Description.ToString.PadRight(50, " ")
      End Get
      Set(ByVal value As String)
      End Set
    End Property
    Public Property PrimaryKey() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
      End Set
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public ReadOnly Property FK_PRJ_CustomerID() As SIS.IDM.idmCustomers
      Get
        If _FK_PRJ_CustomerID Is Nothing Then
          _FK_PRJ_CustomerID = SIS.IDM.idmCustomers.GetByID(_CustomerID)
        End If
        Return _FK_PRJ_CustomerID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal orderBy As String) As List(Of SIS.IDM.idmProjects)
      Dim Results As List(Of SIS.IDM.idmProjects) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmProjectsSelectList"
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
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetNewRecord() As SIS.IDM.idmProjects
      Return New SIS.IDM.idmProjects()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal ProjectID As String) As SIS.IDM.idmProjects
      Dim Results As SIS.IDM.idmProjects = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmProjectsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,ProjectID.ToString.Length, ProjectID)
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
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal CustomerID As String) As List(Of SIS.IDM.idmProjects)
      Dim Results As List(Of SIS.IDM.idmProjects) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spidmProjectsSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spidmProjectsSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ProjectID",SqlDbType.NVarChar,6, IIf(ProjectID Is Nothing, String.Empty,ProjectID))
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_CustomerID",SqlDbType.NVarChar,6, IIf(CustomerID Is Nothing, String.Empty,CustomerID))
					End If
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
    Public Shared Function SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal CustomerID As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal ProjectID As String, ByVal Filter_ProjectID As String, ByVal Filter_CustomerID As String) As SIS.IDM.idmProjects
      Return GetByID(ProjectID)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function Insert(ByVal Record As SIS.IDM.idmProjects) As String
      Dim _Rec As SIS.IDM.idmProjects = SIS.IDM.idmProjects.GetNewRecord()
      With _Rec
        .ProjectID = Record.ProjectID
        .Description = Record.Description
        .CustomerID = Record.CustomerID
        .CustomerOrderReference = Record.CustomerOrderReference
        .ContactPerson = Record.ContactPerson
        .EmailID = Record.EmailID
        .ContactNo = Record.ContactNo
        .Address1 = Record.Address1
        .Address2 = Record.Address2
        .Address3 = Record.Address3
        .Address4 = Record.Address4
        .ToEMailID = Record.ToEMailID
        .CCEmailID = Record.CCEmailID
      End With
      Return SIS.IDM.idmProjects.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.IDM.idmProjects) As String
      Dim _Result As String = Record.ProjectID
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmProjectsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description",SqlDbType.NVarChar,51, Record.Description)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CustomerID",SqlDbType.NVarChar,7, Iif(Record.CustomerID= "" ,Convert.DBNull, Record.CustomerID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CustomerOrderReference",SqlDbType.NVarChar,51, Iif(Record.CustomerOrderReference= "" ,Convert.DBNull, Record.CustomerOrderReference))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactPerson",SqlDbType.NVarChar,51, Iif(Record.ContactPerson= "" ,Convert.DBNull, Record.ContactPerson))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmailID",SqlDbType.NVarChar,51, Iif(Record.EmailID= "" ,Convert.DBNull, Record.EmailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNo",SqlDbType.NVarChar,21, Iif(Record.ContactNo= "" ,Convert.DBNull, Record.ContactNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address1",SqlDbType.NVarChar,61, Iif(Record.Address1= "" ,Convert.DBNull, Record.Address1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address2",SqlDbType.NVarChar,61, Iif(Record.Address2= "" ,Convert.DBNull, Record.Address2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address3",SqlDbType.NVarChar,61, Iif(Record.Address3= "" ,Convert.DBNull, Record.Address3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address4",SqlDbType.NVarChar,61, Iif(Record.Address4= "" ,Convert.DBNull, Record.Address4))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ToEMailID",SqlDbType.NVarChar,251, Iif(Record.ToEMailID= "" ,Convert.DBNull, Record.ToEMailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CCEmailID",SqlDbType.NVarChar,251, Iif(Record.CCEmailID= "" ,Convert.DBNull, Record.CCEmailID))
          Cmd.Parameters.Add("@Return_ProjectID", SqlDbType.NVarChar, 6)
          Cmd.Parameters("@Return_ProjectID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@Return_ProjectID").Value
        End Using
      End Using
      Return _Result
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.IDM.idmProjects) As Int32
      Dim _Rec As SIS.IDM.idmProjects = SIS.IDM.idmProjects.GetByID(Record.ProjectID)
      With _Rec
        .Description = Record.Description
        .CustomerID = Record.CustomerID
        .CustomerOrderReference = Record.CustomerOrderReference
        .ContactPerson = Record.ContactPerson
        .EmailID = Record.EmailID
        .ContactNo = Record.ContactNo
        .Address1 = Record.Address1
        .Address2 = Record.Address2
        .Address3 = Record.Address3
        .Address4 = Record.Address4
        .ToEMailID = Record.ToEMailID
        .CCEmailID = Record.CCEmailID
      End With
      Return SIS.IDM.idmProjects.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.IDM.idmProjects) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmProjectsUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ProjectID",SqlDbType.NVarChar,7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description",SqlDbType.NVarChar,51, Record.Description)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CustomerID",SqlDbType.NVarChar,7, Iif(Record.CustomerID= "" ,Convert.DBNull, Record.CustomerID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CustomerOrderReference",SqlDbType.NVarChar,51, Iif(Record.CustomerOrderReference= "" ,Convert.DBNull, Record.CustomerOrderReference))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactPerson",SqlDbType.NVarChar,51, Iif(Record.ContactPerson= "" ,Convert.DBNull, Record.ContactPerson))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmailID",SqlDbType.NVarChar,51, Iif(Record.EmailID= "" ,Convert.DBNull, Record.EmailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNo",SqlDbType.NVarChar,21, Iif(Record.ContactNo= "" ,Convert.DBNull, Record.ContactNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address1",SqlDbType.NVarChar,61, Iif(Record.Address1= "" ,Convert.DBNull, Record.Address1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address2",SqlDbType.NVarChar,61, Iif(Record.Address2= "" ,Convert.DBNull, Record.Address2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address3",SqlDbType.NVarChar,61, Iif(Record.Address3= "" ,Convert.DBNull, Record.Address3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Address4",SqlDbType.NVarChar,61, Iif(Record.Address4= "" ,Convert.DBNull, Record.Address4))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ToEMailID",SqlDbType.NVarChar,251, Iif(Record.ToEMailID= "" ,Convert.DBNull, Record.ToEMailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CCEmailID",SqlDbType.NVarChar,251, Iif(Record.CCEmailID= "" ,Convert.DBNull, Record.CCEmailID))
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _Result
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)> _
    Public Shared Function Delete(ByVal Record As SIS.IDM.idmProjects, Optional ByVal Cascade As Boolean = False) As Int32
      Dim _Result as Integer = 0
      If Cascade Then
				
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmProjectsDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ProjectID",SqlDbType.NVarChar,Record.ProjectID.ToString.Length, Record.ProjectID)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _Result
    End Function
'		Autocomplete Method
		Public Shared Function SelectidmProjectsAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
			Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spidmProjectsAutoCompleteList"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
					Results = New List(Of String)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Not Reader.HasRows Then
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(50, " "),""))
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
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _ProjectID = Ctype(Reader("ProjectID"),String)
      _Description = Ctype(Reader("Description"),String)
      If Convert.IsDBNull(Reader("CustomerID")) Then
        _CustomerID = String.Empty
      Else
        _CustomerID = Ctype(Reader("CustomerID"), String)
      End If
      If Convert.IsDBNull(Reader("CustomerOrderReference")) Then
        _CustomerOrderReference = String.Empty
      Else
        _CustomerOrderReference = Ctype(Reader("CustomerOrderReference"), String)
      End If
      If Convert.IsDBNull(Reader("ContactPerson")) Then
        _ContactPerson = String.Empty
      Else
        _ContactPerson = Ctype(Reader("ContactPerson"), String)
      End If
      If Convert.IsDBNull(Reader("EmailID")) Then
        _EmailID = String.Empty
      Else
        _EmailID = Ctype(Reader("EmailID"), String)
      End If
      If Convert.IsDBNull(Reader("ContactNo")) Then
        _ContactNo = String.Empty
      Else
        _ContactNo = Ctype(Reader("ContactNo"), String)
      End If
      If Convert.IsDBNull(Reader("Address1")) Then
        _Address1 = String.Empty
      Else
        _Address1 = Ctype(Reader("Address1"), String)
      End If
      If Convert.IsDBNull(Reader("Address2")) Then
        _Address2 = String.Empty
      Else
        _Address2 = Ctype(Reader("Address2"), String)
      End If
      If Convert.IsDBNull(Reader("Address3")) Then
        _Address3 = String.Empty
      Else
        _Address3 = Ctype(Reader("Address3"), String)
      End If
      If Convert.IsDBNull(Reader("Address4")) Then
        _Address4 = String.Empty
      Else
        _Address4 = Ctype(Reader("Address4"), String)
      End If
      If Convert.IsDBNull(Reader("ToEMailID")) Then
        _ToEMailID = String.Empty
      Else
        _ToEMailID = Ctype(Reader("ToEMailID"), String)
      End If
      If Convert.IsDBNull(Reader("CCEmailID")) Then
        _CCEmailID = String.Empty
      Else
        _CCEmailID = Ctype(Reader("CCEmailID"), String)
      End If
      _IDM_Customers1_Description = Ctype(Reader("IDM_Customers1_Description"),String)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
