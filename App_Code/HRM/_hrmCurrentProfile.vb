Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmCurrentProfile
    Private Shared _RecordCount As Integer
    Private _CardNo As String
    Private _EmployeeName As String
    Private _C_DateOfJoining As String
    Private _C_CompanyID As String
    Private _C_DivisionID As String
    Private _C_OfficeID As String
    Private _C_DepartmentID As String
    Private _C_ProjectSiteID As String
    Private _C_DesignationID As String
    Private _C_BasicSalary As Decimal
    Private _C_StatusID As String
    Private _C_StatusRemark As String
    Private _ActiveState As Boolean
    Private _ActiveStateEventName As String
    Private _C_CompanyIDHRM_Companies As SIS.HRM.hrmCompanies
    Private _C_DivisionIDHRM_Divisions As SIS.HRM.hrmDivisions
    Private _C_OfficeIDHRM_Offices As SIS.HRM.hrmOffices
    Private _C_DepartmentIDHRM_Departments As SIS.HRM.hrmDepartments
    Private _C_ProjectSiteIDDCM_Projects As SIS.HRM.hrmProjects
    Private _C_DesignationIDHRM_Designations As SIS.HRM.hrmDesignations
    Private _C_StatusIDHRM_Status As SIS.HRM.hrmStatus
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
    Public Property C_ProjectSiteID() As String
      Get
        Return _C_ProjectSiteID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_ProjectSiteID = ""
				 Else
					 _C_ProjectSiteID = value
			   End If
      End Set
    End Property
    Public Property C_DesignationID() As String
      Get
        Return _C_DesignationID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DesignationID = ""
				 Else
					 _C_DesignationID = value
			   End If
      End Set
    End Property
    Public Property C_BasicSalary() As Decimal
      Get
        Return _C_BasicSalary
      End Get
      Set(ByVal value As Decimal)
        _C_BasicSalary = value
      End Set
    End Property
    Public Property C_StatusID() As String
      Get
        Return _C_StatusID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_StatusID = ""
				 Else
					 _C_StatusID = value
			   End If
      End Set
    End Property
    Public Property C_StatusRemark() As String
      Get
        Return _C_StatusRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_StatusRemark = ""
				 Else
					 _C_StatusRemark = value
			   End If
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
    Public Property ActiveStateEventName() As String
      Get
        Return _ActiveStateEventName
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ActiveStateEventName = ""
				 Else
					 _ActiveStateEventName = value
			   End If
      End Set
    End Property
    Public ReadOnly Property C_CompanyIDHRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _C_CompanyIDHRM_Companies Is Nothing Then
          _C_CompanyIDHRM_Companies = SIS.HRM.hrmCompanies.GetByID(_C_CompanyID)
        End If
        Return _C_CompanyIDHRM_Companies
      End Get
    End Property
    Public ReadOnly Property C_DivisionIDHRM_Divisions() As SIS.HRM.hrmDivisions
      Get
        If _C_DivisionIDHRM_Divisions Is Nothing Then
          _C_DivisionIDHRM_Divisions = SIS.HRM.hrmDivisions.GetByID(_C_DivisionID)
        End If
        Return _C_DivisionIDHRM_Divisions
      End Get
    End Property
    Public ReadOnly Property C_OfficeIDHRM_Offices() As SIS.HRM.hrmOffices
      Get
        If _C_OfficeIDHRM_Offices Is Nothing Then
          _C_OfficeIDHRM_Offices = SIS.HRM.hrmOffices.GetByID(_C_OfficeID)
        End If
        Return _C_OfficeIDHRM_Offices
      End Get
    End Property
    Public ReadOnly Property C_DepartmentIDHRM_Departments() As SIS.HRM.hrmDepartments
      Get
        If _C_DepartmentIDHRM_Departments Is Nothing Then
          _C_DepartmentIDHRM_Departments = SIS.HRM.hrmDepartments.GetByID(_C_DepartmentID)
        End If
        Return _C_DepartmentIDHRM_Departments
      End Get
    End Property
    Public ReadOnly Property C_ProjectSiteIDDCM_Projects() As SIS.HRM.hrmProjects
      Get
        If _C_ProjectSiteIDDCM_Projects Is Nothing Then
          _C_ProjectSiteIDDCM_Projects = SIS.HRM.hrmProjects.GetByID(_C_ProjectSiteID)
        End If
        Return _C_ProjectSiteIDDCM_Projects
      End Get
    End Property
    Public ReadOnly Property C_DesignationIDHRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _C_DesignationIDHRM_Designations Is Nothing Then
          _C_DesignationIDHRM_Designations = SIS.HRM.hrmDesignations.GetByID(_C_DesignationID)
        End If
        Return _C_DesignationIDHRM_Designations
      End Get
    End Property
    Public ReadOnly Property C_StatusIDHRM_Status() As SIS.HRM.hrmStatus
      Get
        If _C_StatusIDHRM_Status Is Nothing Then
          _C_StatusIDHRM_Status = SIS.HRM.hrmStatus.GetByID(_C_StatusID)
        End If
        Return _C_StatusIDHRM_Status
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.hrmCurrentProfile
      Dim Results As SIS.HRM.hrmCurrentProfile = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmCurrentProfileSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmCurrentProfile(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmCurrentProfile)
      Dim Results As List(Of SIS.HRM.hrmCurrentProfile) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmCurrentProfileSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmCurrentProfileSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmCurrentProfile)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmCurrentProfile(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmCurrentProfile) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmCurrentProfileUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeName",SqlDbType.NVarChar,51, Record.EmployeeName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining",SqlDbType.DateTime,21, Iif(Record.C_DateOfJoining= "" ,Convert.DBNull, Record.C_DateOfJoining))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_CompanyID",SqlDbType.NVarChar,7, Iif(Record.C_CompanyID= "" ,Convert.DBNull, Record.C_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DivisionID",SqlDbType.NVarChar,7, Iif(Record.C_DivisionID= "" ,Convert.DBNull, Record.C_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_OfficeID",SqlDbType.Int,11, Iif(Record.C_OfficeID= "" ,Convert.DBNull, Record.C_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.C_DepartmentID= "" ,Convert.DBNull, Record.C_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.C_ProjectSiteID= "" ,Convert.DBNull, Record.C_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID",SqlDbType.Int,11, Iif(Record.C_DesignationID= "" ,Convert.DBNull, Record.C_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_BasicSalary",SqlDbType.Decimal,15, Record.C_BasicSalary)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusID",SqlDbType.NVarChar,3, Iif(Record.C_StatusID= "" ,Convert.DBNull, Record.C_StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusRemark",SqlDbType.NVarChar,251, Iif(Record.C_StatusRemark= "" ,Convert.DBNull, Record.C_StatusRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,3, Record.ActiveState)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveStateEventName",SqlDbType.NVarChar,21, Iif(Record.ActiveStateEventName= "" ,Convert.DBNull, Record.ActiveStateEventName))
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
      If Convert.IsDBNull(Reader("C_ProjectSiteID")) Then
        _C_ProjectSiteID = String.Empty
      Else
        _C_ProjectSiteID = Ctype(Reader("C_ProjectSiteID"), String)
      End If
      If Convert.IsDBNull(Reader("C_DesignationID")) Then
        _C_DesignationID = String.Empty
      Else
        _C_DesignationID = Ctype(Reader("C_DesignationID"), String)
      End If
      _C_BasicSalary = Ctype(Reader("C_BasicSalary"),Decimal)
      If Convert.IsDBNull(Reader("C_StatusID")) Then
        _C_StatusID = String.Empty
      Else
        _C_StatusID = Ctype(Reader("C_StatusID"), String)
      End If
      If Convert.IsDBNull(Reader("C_StatusRemark")) Then
        _C_StatusRemark = String.Empty
      Else
        _C_StatusRemark = Ctype(Reader("C_StatusRemark"), String)
      End If
      _ActiveState = Ctype(Reader("ActiveState"),Boolean)
      If Convert.IsDBNull(Reader("ActiveStateEventName")) Then
        _ActiveStateEventName = String.Empty
      Else
        _ActiveStateEventName = Ctype(Reader("ActiveStateEventName"), String)
      End If
      _C_CompanyIDHRM_Companies = New SIS.HRM.hrmCompanies("HRM_Companies1",Reader)
      _C_DivisionIDHRM_Divisions = New SIS.HRM.hrmDivisions("HRM_Divisions2",Reader)
      _C_OfficeIDHRM_Offices = New SIS.HRM.hrmOffices("HRM_Offices3",Reader)
      _C_DepartmentIDHRM_Departments = New SIS.HRM.hrmDepartments("HRM_Departments4",Reader)
      _C_ProjectSiteIDDCM_Projects = New SIS.HRM.hrmProjects("DCM_Projects5",Reader)
      _C_DesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations6",Reader)
      _C_StatusIDHRM_Status = New SIS.HRM.hrmStatus("HRM_Status7",Reader)
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
      If Convert.IsDBNull(Reader(AliasName & "_C_ProjectSiteID")) Then
        _C_ProjectSiteID = String.Empty
      Else
        _C_ProjectSiteID = Ctype(Reader(AliasName & "_C_ProjectSiteID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_DesignationID")) Then
        _C_DesignationID = String.Empty
      Else
        _C_DesignationID = Ctype(Reader(AliasName & "_C_DesignationID"), String)
      End If
      _C_BasicSalary = Ctype(Reader(AliasName & "_C_BasicSalary"),Decimal)
      If Convert.IsDBNull(Reader(AliasName & "_C_StatusID")) Then
        _C_StatusID = String.Empty
      Else
        _C_StatusID = Ctype(Reader(AliasName & "_C_StatusID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_StatusRemark")) Then
        _C_StatusRemark = String.Empty
      Else
        _C_StatusRemark = Ctype(Reader(AliasName & "_C_StatusRemark"), String)
      End If
      _ActiveState = Ctype(Reader(AliasName & "_ActiveState"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_ActiveStateEventName")) Then
        _ActiveStateEventName = String.Empty
      Else
        _ActiveStateEventName = Ctype(Reader(AliasName & "_ActiveStateEventName"), String)
      End If
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
