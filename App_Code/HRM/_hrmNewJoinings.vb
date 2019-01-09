Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmNewJoinings
    Private Shared _RecordCount As Integer
    Private _CardNo As String
    Private _Salute As String
    Private _EmployeeName As String
    Private _AliasName As String
    Private _Gender As String
    Private _C_DateOfJoining As String
    Private _J_CompanyID As String
    Private _J_DivisionID As String
    Private _J_OfficeID As String
    Private _J_DepartmentID As String
    Private _J_ProjectSiteID As String
    Private _J_DesignationID As String
    Private _J_BasicSalary As String
    Private _J_StatusID As String
    Private _J_StatusRemark As String
    Private _C_JoinngStateID As String
    Private _Freezed As String
    Private _ModifiedBy As String
    Private _ModifiedOn As String
		Private _ModifiedEvent As String
		Private _Contractual As Boolean = False
		Private _EMailID As String = ""
		Private _ContactNumbers As String = ""
		Private _J_CompanyIDHRM_Companies As SIS.HRM.hrmCompanies
    Private _J_DivisionIDHRM_Divisions As SIS.HRM.hrmDivisions
    Private _J_OfficeIDHRM_Offices As SIS.HRM.hrmOffices
    Private _J_DepartmentIDHRM_Departments As SIS.HRM.hrmDepartments
    Private _J_ProjectSiteIDDCM_Projects As SIS.HRM.hrmProjects
    Private _J_ProjectSiteIDDescription As String
    Private _J_DesignationIDHRM_Designations As SIS.HRM.hrmDesignations
    Private _J_StatusIDHRM_Status As SIS.HRM.hrmStatus
    Private _C_JoinngStateIDHRM_JoiningStates As SIS.HRM.hrmJoiningStates
		Private _ModifiedByaspnet_Users As SIS.HRM.hrmUsers
		Public Property EMailID() As String
			Get
				Return _EMailID
			End Get
			Set(ByVal value As String)
				If Convert.IsDBNull(value) Then
					_EMailID = ""
				Else
					_EMailID = value
				End If
			End Set
		End Property
		Public Property ContactNumbers() As String
			Get
				Return _ContactNumbers
			End Get
			Set(ByVal value As String)
				If Convert.IsDBNull(value) Then
					_ContactNumbers = ""
				Else
					_ContactNumbers = value
				End If
			End Set
		End Property
		Public Property Contractual() As Boolean
			Get
				Return _Contractual
			End Get
			Set(ByVal value As Boolean)
				_Contractual = value
			End Set
		End Property
    Public Property CardNo() As String
      Get
        Return _CardNo
      End Get
      Set(ByVal value As String)
        _CardNo = value
      End Set
    End Property
    Public Property Salute() As String
      Get
        Return _Salute
      End Get
      Set(ByVal value As String)
        _Salute = value
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
    Public Property AliasName() As String
      Get
        Return _AliasName
      End Get
      Set(ByVal value As String)
        _AliasName = value
      End Set
    End Property
    Public Property Gender() As String
      Get
        Return _Gender
      End Get
      Set(ByVal value As String)
        _Gender = value
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
    Public Property J_CompanyID() As String
      Get
        Return _J_CompanyID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_CompanyID = ""
				 Else
					 _J_CompanyID = value
			   End If
      End Set
    End Property
    Public Property J_DivisionID() As String
      Get
        Return _J_DivisionID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_DivisionID = ""
				 Else
					 _J_DivisionID = value
			   End If
      End Set
    End Property
    Public Property J_OfficeID() As String
      Get
        Return _J_OfficeID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_OfficeID = ""
				 Else
					 _J_OfficeID = value
			   End If
      End Set
    End Property
    Public Property J_DepartmentID() As String
      Get
        Return _J_DepartmentID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_DepartmentID = ""
				 Else
					 _J_DepartmentID = value
			   End If
      End Set
    End Property
    Public Property J_ProjectSiteID() As String
      Get
        Return _J_ProjectSiteID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_ProjectSiteID = ""
				 Else
					 _J_ProjectSiteID = value
			   End If
      End Set
    End Property
    Public Property J_DesignationID() As String
      Get
        Return _J_DesignationID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_DesignationID = ""
				 Else
					 _J_DesignationID = value
			   End If
      End Set
    End Property
    Public Property J_BasicSalary() As String
      Get
        Return _J_BasicSalary
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_BasicSalary = ""
				 Else
					 _J_BasicSalary = value
			   End If
      End Set
    End Property
    Public Property J_StatusID() As String
      Get
        Return _J_StatusID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_StatusID = ""
				 Else
					 _J_StatusID = value
			   End If
      End Set
    End Property
    Public Property J_StatusRemark() As String
      Get
        Return _J_StatusRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _J_StatusRemark = ""
				 Else
					 _J_StatusRemark = value
			   End If
      End Set
    End Property
    Public Property C_JoinngStateID() As String
      Get
        Return _C_JoinngStateID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_JoinngStateID = ""
				 Else
					 _C_JoinngStateID = value
			   End If
      End Set
    End Property
    Public Property Freezed() As String
      Get
        Return _Freezed
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _Freezed = ""
				 Else
					 _Freezed = value
			   End If
      End Set
    End Property
    Public Property ModifiedBy() As String
      Get
        Return _ModifiedBy
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ModifiedBy = ""
				 Else
					 _ModifiedBy = value
			   End If
      End Set
    End Property
    Public Property ModifiedOn() As String
      Get
        If Not _ModifiedOn = String.Empty Then
          Return Convert.ToDateTime(_ModifiedOn).ToString("dd/MM/yyyy")
        End If
        Return _ModifiedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ModifiedOn = ""
				 Else
					 _ModifiedOn = value
			   End If
      End Set
    End Property
    Public Property ModifiedEvent() As String
      Get
        Return _ModifiedEvent
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ModifiedEvent = ""
				 Else
					 _ModifiedEvent = value
			   End If
      End Set
    End Property
    Public ReadOnly Property J_CompanyIDHRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _J_CompanyIDHRM_Companies Is Nothing Then
          _J_CompanyIDHRM_Companies = SIS.HRM.hrmCompanies.GetByID(_J_CompanyID)
        End If
        Return _J_CompanyIDHRM_Companies
      End Get
    End Property
    Public ReadOnly Property J_DivisionIDHRM_Divisions() As SIS.HRM.hrmDivisions
      Get
        If _J_DivisionIDHRM_Divisions Is Nothing Then
          _J_DivisionIDHRM_Divisions = SIS.HRM.hrmDivisions.GetByID(_J_DivisionID)
        End If
        Return _J_DivisionIDHRM_Divisions
      End Get
    End Property
    Public ReadOnly Property J_OfficeIDHRM_Offices() As SIS.HRM.hrmOffices
      Get
        If _J_OfficeIDHRM_Offices Is Nothing Then
          _J_OfficeIDHRM_Offices = SIS.HRM.hrmOffices.GetByID(_J_OfficeID)
        End If
        Return _J_OfficeIDHRM_Offices
      End Get
    End Property
    Public ReadOnly Property J_DepartmentIDHRM_Departments() As SIS.HRM.hrmDepartments
      Get
        If _J_DepartmentIDHRM_Departments Is Nothing Then
          _J_DepartmentIDHRM_Departments = SIS.HRM.hrmDepartments.GetByID(_J_DepartmentID)
        End If
        Return _J_DepartmentIDHRM_Departments
      End Get
    End Property
    Public ReadOnly Property J_ProjectSiteIDDCM_Projects() As SIS.HRM.hrmProjects
      Get
        If _J_ProjectSiteIDDCM_Projects Is Nothing Then
          _J_ProjectSiteIDDCM_Projects = SIS.HRM.hrmProjects.GetByID(_J_ProjectSiteID)
        End If
        Return _J_ProjectSiteIDDCM_Projects
      End Get
    End Property
    Public Property J_ProjectSiteIDDescription() As String
      Get
        Return _J_ProjectSiteIDDescription
      End Get
      Set(ByVal value As String)
        _J_ProjectSiteIDDescription = value
      End Set
    End Property
    Public ReadOnly Property J_DesignationIDHRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _J_DesignationIDHRM_Designations Is Nothing Then
          _J_DesignationIDHRM_Designations = SIS.HRM.hrmDesignations.GetByID(_J_DesignationID)
        End If
        Return _J_DesignationIDHRM_Designations
      End Get
    End Property
    Public ReadOnly Property J_StatusIDHRM_Status() As SIS.HRM.hrmStatus
      Get
        If _J_StatusIDHRM_Status Is Nothing Then
          _J_StatusIDHRM_Status = SIS.HRM.hrmStatus.GetByID(_J_StatusID)
        End If
        Return _J_StatusIDHRM_Status
      End Get
    End Property
    Public ReadOnly Property C_JoinngStateIDHRM_JoiningStates() As SIS.HRM.hrmJoiningStates
      Get
        If _C_JoinngStateIDHRM_JoiningStates Is Nothing Then
          _C_JoinngStateIDHRM_JoiningStates = SIS.HRM.hrmJoiningStates.GetByID(_C_JoinngStateID)
        End If
        Return _C_JoinngStateIDHRM_JoiningStates
      End Get
    End Property
    Public ReadOnly Property ModifiedByaspnet_Users() As SIS.HRM.hrmUsers
      Get
        If _ModifiedByaspnet_Users Is Nothing Then
          _ModifiedByaspnet_Users = SIS.HRM.hrmUsers.GetByID(_ModifiedBy)
        End If
        Return _ModifiedByaspnet_Users
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.hrmNewJoinings
      Dim Results As SIS.HRM.hrmNewJoinings = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNewJoiningsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmNewJoinings(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmNewJoinings)
      Dim Results As List(Of SIS.HRM.hrmNewJoinings) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmNewJoiningsSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmNewJoiningsSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Freezed",SqlDbType.Bit,2, 0)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmNewJoinings)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmNewJoinings(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function Insert(ByVal Record As SIS.HRM.hrmNewJoinings) As String
      Dim _Result As String = Record.CardNo
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNewJoiningsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Salute",SqlDbType.NVarChar,51, Record.Salute)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeName",SqlDbType.NVarChar,51, Record.EmployeeName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AliasName",SqlDbType.NVarChar,51, Record.AliasName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Gender",SqlDbType.NVarChar,2, Record.Gender)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining",SqlDbType.DateTime,21, Iif(Record.C_DateOfJoining= "" ,Convert.DBNull, Record.C_DateOfJoining))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_CompanyID",SqlDbType.NVarChar,7, Iif(Record.J_CompanyID= "" ,Convert.DBNull, Record.J_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DivisionID",SqlDbType.NVarChar,7, Iif(Record.J_DivisionID= "" ,Convert.DBNull, Record.J_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_OfficeID",SqlDbType.Int,11, Iif(Record.J_OfficeID= "" ,Convert.DBNull, Record.J_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.J_DepartmentID= "" ,Convert.DBNull, Record.J_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.J_ProjectSiteID= "" ,Convert.DBNull, Record.J_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DesignationID",SqlDbType.Int,11, Iif(Record.J_DesignationID= "" ,Convert.DBNull, Record.J_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_BasicSalary",SqlDbType.Decimal,15, Iif(Record.J_BasicSalary= "" ,Convert.DBNull, Record.J_BasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_StatusID",SqlDbType.NVarChar,3, Iif(Record.J_StatusID= "" ,Convert.DBNull, Record.J_StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_StatusRemark",SqlDbType.NVarChar,251, Iif(Record.J_StatusRemark= "" ,Convert.DBNull, Record.J_StatusRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_JoinngStateID",SqlDbType.NVarChar,3, "NJ")
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy",SqlDbType.NVarChar,21, Global.System.Web.HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn",SqlDbType.DateTime,21, Now)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent", SqlDbType.NVarChar, 21, "New Joining")
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Contractual", SqlDbType.Bit, 3, Record.Contractual)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EMailID", SqlDbType.NVarChar, 51, IIf(Record.EMailID = String.Empty, Convert.DBNull, Record.EMailID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNumbers", SqlDbType.NVarChar, 101, IIf(Record.ContactNumbers = String.Empty, Convert.DBNull, Record.ContactNumbers))
					Cmd.Parameters.Add("@Return_CardNo", SqlDbType.NVarChar, 8)
          Cmd.Parameters("@Return_CardNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@Return_CardNo").Value
        End Using
      End Using
      Return _Result
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmNewJoinings) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNewJoiningsUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Salute",SqlDbType.NVarChar,51, Record.Salute)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeName",SqlDbType.NVarChar,51, Record.EmployeeName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AliasName",SqlDbType.NVarChar,51, Record.AliasName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Gender",SqlDbType.NVarChar,2, Record.Gender)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining",SqlDbType.DateTime,21, Iif(Record.C_DateOfJoining= "" ,Convert.DBNull, Record.C_DateOfJoining))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_CompanyID",SqlDbType.NVarChar,7, Iif(Record.J_CompanyID= "" ,Convert.DBNull, Record.J_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DivisionID",SqlDbType.NVarChar,7, Iif(Record.J_DivisionID= "" ,Convert.DBNull, Record.J_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_OfficeID",SqlDbType.Int,11, Iif(Record.J_OfficeID= "" ,Convert.DBNull, Record.J_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.J_DepartmentID= "" ,Convert.DBNull, Record.J_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.J_ProjectSiteID= "" ,Convert.DBNull, Record.J_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_DesignationID",SqlDbType.Int,11, Iif(Record.J_DesignationID= "" ,Convert.DBNull, Record.J_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_BasicSalary",SqlDbType.Decimal,15, Iif(Record.J_BasicSalary= "" ,Convert.DBNull, Record.J_BasicSalary))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_StatusID",SqlDbType.NVarChar,3, Iif(Record.J_StatusID= "" ,Convert.DBNull, Record.J_StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@J_StatusRemark",SqlDbType.NVarChar,251, Iif(Record.J_StatusRemark= "" ,Convert.DBNull, Record.J_StatusRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_JoinngStateID",SqlDbType.NVarChar,3, "NJ")
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy",SqlDbType.NVarChar,21, Global.System.Web.HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn",SqlDbType.DateTime,21, Now)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent",SqlDbType.NVarChar,21, "New Joining")
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Contractual", SqlDbType.Bit, 3, Record.Contractual)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EMailID", SqlDbType.NVarChar, 51, IIf(Record.EMailID = String.Empty, Convert.DBNull, Record.EMailID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNumbers", SqlDbType.NVarChar, 101, IIf(Record.ContactNumbers = String.Empty, Convert.DBNull, Record.ContactNumbers))
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
    Public Shared Function Delete(ByVal Record As SIS.HRM.hrmNewJoinings) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmNewJoiningsDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,Record.CardNo.ToString.Length, Record.CardNo)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _Result
    End Function
    Public Shared Function SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _CardNo = Ctype(Reader("CardNo"),String)
      _Salute = Ctype(Reader("Salute"),String)
      _EmployeeName = Ctype(Reader("EmployeeName"),String)
      _AliasName = Ctype(Reader("AliasName"),String)
      _Gender = Ctype(Reader("Gender"),String)
      If Convert.IsDBNull(Reader("C_DateOfJoining")) Then
        _C_DateOfJoining = String.Empty
      Else
        _C_DateOfJoining = Ctype(Reader("C_DateOfJoining"), String)
      End If
      If Convert.IsDBNull(Reader("J_CompanyID")) Then
        _J_CompanyID = String.Empty
      Else
        _J_CompanyID = Ctype(Reader("J_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader("J_DivisionID")) Then
        _J_DivisionID = String.Empty
      Else
        _J_DivisionID = Ctype(Reader("J_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader("J_OfficeID")) Then
        _J_OfficeID = String.Empty
      Else
        _J_OfficeID = Ctype(Reader("J_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader("J_DepartmentID")) Then
        _J_DepartmentID = String.Empty
      Else
        _J_DepartmentID = Ctype(Reader("J_DepartmentID"), String)
      End If
      If Convert.IsDBNull(Reader("J_ProjectSiteID")) Then
        _J_ProjectSiteID = String.Empty
      Else
        _J_ProjectSiteID = Ctype(Reader("J_ProjectSiteID"), String)
      End If
      If Convert.IsDBNull(Reader("J_DesignationID")) Then
        _J_DesignationID = String.Empty
      Else
        _J_DesignationID = Ctype(Reader("J_DesignationID"), String)
      End If
      If Convert.IsDBNull(Reader("J_BasicSalary")) Then
        _J_BasicSalary = String.Empty
      Else
        _J_BasicSalary = Ctype(Reader("J_BasicSalary"), String)
      End If
      If Convert.IsDBNull(Reader("J_StatusID")) Then
        _J_StatusID = String.Empty
      Else
        _J_StatusID = Ctype(Reader("J_StatusID"), String)
      End If
      If Convert.IsDBNull(Reader("J_StatusRemark")) Then
        _J_StatusRemark = String.Empty
      Else
        _J_StatusRemark = Ctype(Reader("J_StatusRemark"), String)
      End If
      If Convert.IsDBNull(Reader("C_JoinngStateID")) Then
        _C_JoinngStateID = String.Empty
      Else
        _C_JoinngStateID = Ctype(Reader("C_JoinngStateID"), String)
      End If
      If Convert.IsDBNull(Reader("Freezed")) Then
        _Freezed = String.Empty
      Else
        _Freezed = Ctype(Reader("Freezed"), String)
      End If
      If Convert.IsDBNull(Reader("ModifiedBy")) Then
        _ModifiedBy = String.Empty
      Else
        _ModifiedBy = Ctype(Reader("ModifiedBy"), String)
      End If
      If Convert.IsDBNull(Reader("ModifiedOn")) Then
        _ModifiedOn = String.Empty
      Else
        _ModifiedOn = Ctype(Reader("ModifiedOn"), String)
      End If
			If Convert.IsDBNull(Reader("ModifiedEvent")) Then
				_ModifiedEvent = String.Empty
			Else
				_ModifiedEvent = CType(Reader("ModifiedEvent"), String)
			End If
			If Convert.IsDBNull(Reader("EMailID")) Then
				_EMailID = String.Empty
			Else
				_EMailID = CType(Reader("EMailID"), String)
			End If
			If Convert.IsDBNull(Reader("ContactNumbers")) Then
				_ContactNumbers = String.Empty
			Else
				_ContactNumbers = CType(Reader("ContactNumbers"), String)
			End If
			_J_CompanyIDHRM_Companies = New SIS.HRM.hrmCompanies("HRM_Companies1", Reader)
      _J_DivisionIDHRM_Divisions = New SIS.HRM.hrmDivisions("HRM_Divisions2",Reader)
      _J_OfficeIDHRM_Offices = New SIS.HRM.hrmOffices("HRM_Offices3",Reader)
      _J_DepartmentIDHRM_Departments = New SIS.HRM.hrmDepartments("HRM_Departments4",Reader)
      If Convert.IsDBNull(Reader("J_ProjectSiteID")) Then
        _J_ProjectSiteIDDescription = String.Empty
      Else
        _J_ProjectSiteIDDescription = Reader("DCM_Projects5_Description") & " [" & Ctype(Reader("J_ProjectSiteID"), String) & "]"
      End If
      _J_ProjectSiteIDDCM_Projects = New SIS.HRM.hrmProjects("DCM_Projects5",Reader)
      _J_DesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations6",Reader)
      _J_StatusIDHRM_Status = New SIS.HRM.hrmStatus("HRM_Status7",Reader)
      _C_JoinngStateIDHRM_JoiningStates = New SIS.HRM.hrmJoiningStates("HRM_JoiningStates8",Reader)
			_ModifiedByaspnet_Users = New SIS.HRM.hrmUsers("aspnet_Users9", Reader)
			_Contractual = CType(Reader("Contractual"), Boolean)
    End Sub
    Public Sub New(ByVal AliasName As String, ByVal Reader As SqlDataReader)
      On Error Resume Next
      _CardNo = Ctype(Reader(AliasName & "_CardNo"),String)
      _Salute = Ctype(Reader(AliasName & "_Salute"),String)
      _EmployeeName = Ctype(Reader(AliasName & "_EmployeeName"),String)
      _AliasName = Ctype(Reader(AliasName & "_AliasName"),String)
      _Gender = Ctype(Reader(AliasName & "_Gender"),String)
      If Convert.IsDBNull(Reader(AliasName & "_C_DateOfJoining")) Then
        _C_DateOfJoining = String.Empty
      Else
        _C_DateOfJoining = Ctype(Reader(AliasName & "_C_DateOfJoining"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_CompanyID")) Then
        _J_CompanyID = String.Empty
      Else
        _J_CompanyID = Ctype(Reader(AliasName & "_J_CompanyID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_DivisionID")) Then
        _J_DivisionID = String.Empty
      Else
        _J_DivisionID = Ctype(Reader(AliasName & "_J_DivisionID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_OfficeID")) Then
        _J_OfficeID = String.Empty
      Else
        _J_OfficeID = Ctype(Reader(AliasName & "_J_OfficeID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_DepartmentID")) Then
        _J_DepartmentID = String.Empty
      Else
        _J_DepartmentID = Ctype(Reader(AliasName & "_J_DepartmentID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_ProjectSiteID")) Then
        _J_ProjectSiteID = String.Empty
      Else
        _J_ProjectSiteID = Ctype(Reader(AliasName & "_J_ProjectSiteID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_DesignationID")) Then
        _J_DesignationID = String.Empty
      Else
        _J_DesignationID = Ctype(Reader(AliasName & "_J_DesignationID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_BasicSalary")) Then
        _J_BasicSalary = String.Empty
      Else
        _J_BasicSalary = Ctype(Reader(AliasName & "_J_BasicSalary"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_StatusID")) Then
        _J_StatusID = String.Empty
      Else
        _J_StatusID = Ctype(Reader(AliasName & "_J_StatusID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_J_StatusRemark")) Then
        _J_StatusRemark = String.Empty
      Else
        _J_StatusRemark = Ctype(Reader(AliasName & "_J_StatusRemark"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_JoinngStateID")) Then
        _C_JoinngStateID = String.Empty
      Else
        _C_JoinngStateID = Ctype(Reader(AliasName & "_C_JoinngStateID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_Freezed")) Then
        _Freezed = String.Empty
      Else
        _Freezed = Ctype(Reader(AliasName & "_Freezed"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedBy")) Then
        _ModifiedBy = String.Empty
      Else
        _ModifiedBy = Ctype(Reader(AliasName & "_ModifiedBy"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedOn")) Then
        _ModifiedOn = String.Empty
      Else
        _ModifiedOn = Ctype(Reader(AliasName & "_ModifiedOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedEvent")) Then
        _ModifiedEvent = String.Empty
      Else
        _ModifiedEvent = Ctype(Reader(AliasName & "_ModifiedEvent"), String)
      End If
			_Contractual = CType(Reader(AliasName & "_Contractual"), Boolean)
			If Convert.IsDBNull(Reader(AliasName & "_EMailID")) Then
				_EMailID = String.Empty
			Else
				_EMailID = CType(Reader(AliasName & "_EMailID"), String)
			End If
			If Convert.IsDBNull(Reader(AliasName & "_ContactNumbers")) Then
				_ContactNumbers = String.Empty
			Else
				_ContactNumbers = CType(Reader(AliasName & "_ContactNumbers"), String)
			End If
		End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
