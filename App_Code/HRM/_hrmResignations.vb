Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmResignations
    Private Shared _RecordCount As Integer
    Private _CardNo As String
    Private _EmployeeName As String
    Private _C_DateOfJoining As String
    Private _C_DepartmentID As String
    Private _C_DesignationID As Int32
    Private _C_StatusID As String
    Private _Resigned As Boolean
    Private _C_ResignedOn As String
    Private _C_DateOfReleaving As String
    Private _C_ResignedRemark As String
    Private _ActiveState As Boolean
    Private _ActiveStateEventName As String
    Private _ModifiedBy As String
    Private _ModifiedOn As String
    Private _ModifiedEvent As String
    Private _C_DepartmentIDHRM_Departments As SIS.HRM.hrmDepartments
    Private _C_DesignationIDHRM_Designations As SIS.HRM.hrmDesignations
    Private _C_StatusIDHRM_Status As SIS.HRM.hrmStatus
    Private _ModifiedByaspnet_Users As SIS.HRM.hrmUsers
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
    Public Property C_StatusID() As String
      Get
        Return _C_StatusID
      End Get
      Set(ByVal value As String)
        _C_StatusID = value
      End Set
    End Property
    Public Property Resigned() As Boolean
      Get
        Return _Resigned
      End Get
      Set(ByVal value As Boolean)
        _Resigned = value
      End Set
    End Property
    Public Property C_ResignedOn() As String
      Get
        If Not _C_ResignedOn = String.Empty Then
          Return Convert.ToDateTime(_C_ResignedOn).ToString("dd/MM/yyyy")
        End If
        Return _C_ResignedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_ResignedOn = ""
				 Else
					 _C_ResignedOn = value
			   End If
      End Set
    End Property
    Public Property C_DateOfReleaving() As String
      Get
        If Not _C_DateOfReleaving = String.Empty Then
          Return Convert.ToDateTime(_C_DateOfReleaving).ToString("dd/MM/yyyy")
        End If
        Return _C_DateOfReleaving
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_DateOfReleaving = ""
				 Else
					 _C_DateOfReleaving = value
			   End If
      End Set
    End Property
    Public Property C_ResignedRemark() As String
      Get
        Return _C_ResignedRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_ResignedRemark = ""
				 Else
					 _C_ResignedRemark = value
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
    Public ReadOnly Property C_DepartmentIDHRM_Departments() As SIS.HRM.hrmDepartments
      Get
        If _C_DepartmentIDHRM_Departments Is Nothing Then
          _C_DepartmentIDHRM_Departments = SIS.HRM.hrmDepartments.GetByID(_C_DepartmentID)
        End If
        Return _C_DepartmentIDHRM_Departments
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
    Public ReadOnly Property ModifiedByaspnet_Users() As SIS.HRM.hrmUsers
      Get
        If _ModifiedByaspnet_Users Is Nothing Then
          _ModifiedByaspnet_Users = SIS.HRM.hrmUsers.GetByID(_ModifiedBy)
        End If
        Return _ModifiedByaspnet_Users
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.hrmResignations
      Dim Results As SIS.HRM.hrmResignations = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmResignationsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmResignations(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmResignations)
      Dim Results As List(Of SIS.HRM.hrmResignations) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmResignationsSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmResignationsSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Resigned",SqlDbType.Bit,2, 0)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,2, 1)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmResignations)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmResignations(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmResignations) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmResignationsUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_StatusID",SqlDbType.NVarChar,3, Record.C_StatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Resigned",SqlDbType.Bit,3, Record.Resigned)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedOn",SqlDbType.DateTime,21, Iif(Record.C_ResignedOn= "" ,Convert.DBNull, Record.C_ResignedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfReleaving",SqlDbType.DateTime,21, Iif(Record.C_DateOfReleaving= "" ,Convert.DBNull, Record.C_DateOfReleaving))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ResignedRemark",SqlDbType.NVarChar,251, Iif(Record.C_ResignedRemark= "" ,Convert.DBNull, Record.C_ResignedRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,3, Record.ActiveState)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveStateEventName",SqlDbType.NVarChar,21, Record.ActiveStateEventName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy",SqlDbType.NVarChar,21, Global.System.Web.HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn",SqlDbType.DateTime,21, Now)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent",SqlDbType.NVarChar,21, "Resigned")
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
      If Convert.IsDBNull(Reader("C_DepartmentID")) Then
        _C_DepartmentID = String.Empty
      Else
        _C_DepartmentID = Ctype(Reader("C_DepartmentID"), String)
      End If
      _C_DesignationID = Ctype(Reader("C_DesignationID"),Int32)
      _C_StatusID = Ctype(Reader("C_StatusID"),String)
      _Resigned = Ctype(Reader("Resigned"),Boolean)
      If Convert.IsDBNull(Reader("C_ResignedOn")) Then
        _C_ResignedOn = String.Empty
      Else
        _C_ResignedOn = Ctype(Reader("C_ResignedOn"), String)
      End If
      If Convert.IsDBNull(Reader("C_DateOfReleaving")) Then
        _C_DateOfReleaving = String.Empty
      Else
        _C_DateOfReleaving = Ctype(Reader("C_DateOfReleaving"), String)
      End If
      If Convert.IsDBNull(Reader("C_ResignedRemark")) Then
        _C_ResignedRemark = String.Empty
      Else
        _C_ResignedRemark = Ctype(Reader("C_ResignedRemark"), String)
      End If
      _ActiveState = Ctype(Reader("ActiveState"),Boolean)
      If Convert.IsDBNull(Reader("ActiveStateEventName")) Then
        _ActiveStateEventName = String.Empty
      Else
        _ActiveStateEventName = Ctype(Reader("ActiveStateEventName"), String)
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
        _ModifiedEvent = Ctype(Reader("ModifiedEvent"), String)
      End If
      _C_DepartmentIDHRM_Departments = New SIS.HRM.hrmDepartments("HRM_Departments1",Reader)
      _C_DesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations2",Reader)
      _C_StatusIDHRM_Status = New SIS.HRM.hrmStatus("HRM_Status3",Reader)
      _ModifiedByaspnet_Users = New SIS.HRM.hrmUsers("aspnet_Users4",Reader)
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
      If Convert.IsDBNull(Reader(AliasName & "_C_DepartmentID")) Then
        _C_DepartmentID = String.Empty
      Else
        _C_DepartmentID = Ctype(Reader(AliasName & "_C_DepartmentID"), String)
      End If
      _C_DesignationID = Ctype(Reader(AliasName & "_C_DesignationID"),Int32)
      _C_StatusID = Ctype(Reader(AliasName & "_C_StatusID"),String)
      _Resigned = Ctype(Reader(AliasName & "_Resigned"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_C_ResignedOn")) Then
        _C_ResignedOn = String.Empty
      Else
        _C_ResignedOn = Ctype(Reader(AliasName & "_C_ResignedOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_DateOfReleaving")) Then
        _C_DateOfReleaving = String.Empty
      Else
        _C_DateOfReleaving = Ctype(Reader(AliasName & "_C_DateOfReleaving"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_ResignedRemark")) Then
        _C_ResignedRemark = String.Empty
      Else
        _C_ResignedRemark = Ctype(Reader(AliasName & "_C_ResignedRemark"), String)
      End If
      _ActiveState = Ctype(Reader(AliasName & "_ActiveState"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_ActiveStateEventName")) Then
        _ActiveStateEventName = String.Empty
      Else
        _ActiveStateEventName = Ctype(Reader(AliasName & "_ActiveStateEventName"), String)
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
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
