Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmNewEmployees
    Private Shared _RecordCount As Integer
    Private _CardNo As String = ""
    Private _EmployeeName As String = ""
    Private _C_DateOfJoining As String = ""
    Private _C_CompanyID As String = ""
    Private _C_DivisionID As String = ""
    Private _C_OfficeID As String = ""
    Private _C_DepartmentID As String = ""
    Private _C_DesignationID As Int32 = 0
    Private _ActiveState As Boolean = False
    Private _FK_HRM_Employees_HRM_Companies As SIS.HRM.hrmCompanies = Nothing
    Private _FK_HRM_Employees_HRM_Departments As SIS.HRM.hrmDepartments = Nothing
    Private _FK_HRM_Employees_HRM_Designations As SIS.HRM.hrmDesignations = Nothing
    Private _FK_HRM_Employees_HRM_Divisions As SIS.HRM.hrmDivisions = Nothing
    Private _FK_HRM_Employees_HRM_Offices As SIS.HRM.hrmOffices = Nothing
    Public Property CardNo() As String
      Get
        Return _CardNo
      End Get
      Set(ByVal value As String)
        _CardNo = value
      End Set
    End Property
    Public Property EmployeeName() As String
      Get
        Return _EmployeeName
      End Get
      Set(ByVal value As String)
        _EmployeeName = value
      End Set
    End Property
    Public Property C_DateOfJoining() As String
      Get
        If Not _C_DateOfJoining = String.Empty Then
          Return Convert.ToDateTime(_C_DateOfJoining).ToString("dd/MM/yyyy")
        End If
        Return _C_DateOfJoining
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DateOfJoining = ""
				 Else
					 _C_DateOfJoining = value
			   End If
      End Set
    End Property
    Public Property C_CompanyID() As String
      Get
        Return _C_CompanyID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_CompanyID = ""
				 Else
					 _C_CompanyID = value
			   End If
      End Set
    End Property
    Public Property C_DivisionID() As String
      Get
        Return _C_DivisionID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DivisionID = ""
				 Else
					 _C_DivisionID = value
			   End If
      End Set
    End Property
    Public Property C_OfficeID() As String
      Get
        Return _C_OfficeID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_OfficeID = ""
				 Else
					 _C_OfficeID = value
			   End If
      End Set
    End Property
    Public Property C_DepartmentID() As String
      Get
        Return _C_DepartmentID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DepartmentID = ""
				 Else
					 _C_DepartmentID = value
			   End If
      End Set
    End Property
    Public Property C_DesignationID() As Int32
      Get
        Return _C_DesignationID
      End Get
      Set(ByVal value As Int32)
        _C_DesignationID = value
      End Set
    End Property
    Public Property ActiveState() As Boolean
      Get
        Return _ActiveState
      End Get
      Set(ByVal value As Boolean)
        _ActiveState = value
      End Set
    End Property
    Public Property DisplayField() As String
      Get
        Return "" & _EmployeeName.ToString.PadRight(50, " ")
      End Get
      Set(ByVal value As String)
      End Set
    End Property
    Public Property PrimaryKey() As String
      Get
        Return _CardNo
      End Get
      Set(ByVal value As String)
      End Set
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _FK_HRM_Employees_HRM_Companies Is Nothing Then
          _FK_HRM_Employees_HRM_Companies = SIS.HRM.hrmCompanies.GetByID(_C_CompanyID)
        End If
        Return _FK_HRM_Employees_HRM_Companies
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Departments() As SIS.HRM.hrmDepartments
      Get
        If _FK_HRM_Employees_HRM_Departments Is Nothing Then
          _FK_HRM_Employees_HRM_Departments = SIS.HRM.hrmDepartments.GetByID(_C_DepartmentID)
        End If
        Return _FK_HRM_Employees_HRM_Departments
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _FK_HRM_Employees_HRM_Designations Is Nothing Then
          _FK_HRM_Employees_HRM_Designations = SIS.HRM.hrmDesignations.GetByID(_C_DesignationID)
        End If
        Return _FK_HRM_Employees_HRM_Designations
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Divisions() As SIS.HRM.hrmDivisions
      Get
        If _FK_HRM_Employees_HRM_Divisions Is Nothing Then
          _FK_HRM_Employees_HRM_Divisions = SIS.HRM.hrmDivisions.GetByID(_C_DivisionID)
        End If
        Return _FK_HRM_Employees_HRM_Divisions
      End Get
    End Property
    Public ReadOnly Property FK_HRM_Employees_HRM_Offices() As SIS.HRM.hrmOffices
      Get
        If _FK_HRM_Employees_HRM_Offices Is Nothing Then
          _FK_HRM_Employees_HRM_Offices = SIS.HRM.hrmOffices.GetByID(_C_OfficeID)
        End If
        Return _FK_HRM_Employees_HRM_Offices
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal orderBy As String) As List(Of SIS.HRM.hrmNewEmployees)
      Dim Results As List(Of SIS.HRM.hrmNewEmployees) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNewEmployeesSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,2, 1)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmNewEmployees)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmNewEmployees(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetNewRecord() As SIS.HRM.hrmNewEmployees
      Dim Results As SIS.HRM.hrmNewEmployees = Nothing
      Results = New SIS.HRM.hrmNewEmployees()
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.hrmNewEmployees
      Dim Results As SIS.HRM.hrmNewEmployees = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNewEmployeesSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmNewEmployees(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmNewEmployees)
      Dim Results As List(Of SIS.HRM.hrmNewEmployees) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmNewEmployeesSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmNewEmployeesSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,2, 1)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmNewEmployees)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmNewEmployees(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
'		Autocomplete Method
		Public Shared Function SelecthrmNewEmployeesAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
			Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "sphrmNewEmployeesAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,2, 1)
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
            Dim Tmp As SIS.HRM.hrmNewEmployees = New SIS.HRM.hrmNewEmployees(Reader)
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
					End While
					Reader.Close()
				End Using
			End Using
			Return Results.ToArray
		End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _CardNo = Ctype(Reader("CardNo"),String)
      _EmployeeName = Ctype(Reader("EmployeeName"),String)
      If Convert.IsDBNull(Reader("C_DateOfJoining")) Then
        _C_DateOfJoining = String.Empty
      Else
        _C_DateOfJoining = Ctype(Reader("C_DateOfJoining"), String)
      End If
      If Convert.IsDBNull(Reader("C_CompanyID")) Then
        _C_CompanyID = String.Empty
      Else
        _C_CompanyID = Ctype(Reader("C_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader("C_DivisionID")) Then
        _C_DivisionID = String.Empty
      Else
        _C_DivisionID = Ctype(Reader("C_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader("C_OfficeID")) Then
        _C_OfficeID = String.Empty
      Else
        _C_OfficeID = Ctype(Reader("C_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader("C_DepartmentID")) Then
        _C_DepartmentID = String.Empty
      Else
        _C_DepartmentID = Ctype(Reader("C_DepartmentID"), String)
      End If
      _C_DesignationID = Ctype(Reader("C_DesignationID"),Int32)
      _ActiveState = Ctype(Reader("ActiveState"),Boolean)
      _FK_HRM_Employees_HRM_Companies = New SIS.HRM.hrmCompanies("HRM_Companies8",Reader)
      _FK_HRM_Employees_HRM_Departments = New SIS.HRM.hrmDepartments("HRM_Departments11",Reader)
      _FK_HRM_Employees_HRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations14",Reader)
      _FK_HRM_Employees_HRM_Divisions = New SIS.HRM.hrmDivisions("HRM_Divisions16",Reader)
      _FK_HRM_Employees_HRM_Offices = New SIS.HRM.hrmOffices("HRM_Offices25",Reader)
    End Sub
    Public Sub New(ByVal AliasName As String, ByVal Reader As SqlDataReader)
      On Error Resume Next
      _CardNo = Ctype(Reader(AliasName & "_CardNo"),String)
      _EmployeeName = Ctype(Reader(AliasName & "_EmployeeName"),String)
      If Convert.IsDBNull(Reader(AliasName & "_C_DateOfJoining")) Then
        _C_DateOfJoining = String.Empty
      Else
        _C_DateOfJoining = Ctype(Reader(AliasName & "_C_DateOfJoining"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_CompanyID")) Then
        _C_CompanyID = String.Empty
      Else
        _C_CompanyID = Ctype(Reader(AliasName & "_C_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_DivisionID")) Then
        _C_DivisionID = String.Empty
      Else
        _C_DivisionID = Ctype(Reader(AliasName & "_C_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_OfficeID")) Then
        _C_OfficeID = String.Empty
      Else
        _C_OfficeID = Ctype(Reader(AliasName & "_C_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_DepartmentID")) Then
        _C_DepartmentID = String.Empty
      Else
        _C_DepartmentID = Ctype(Reader(AliasName & "_C_DepartmentID"), String)
      End If
      _C_DesignationID = Ctype(Reader(AliasName & "_C_DesignationID"),Int32)
      _ActiveState = Ctype(Reader(AliasName & "_ActiveState"),Boolean)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
