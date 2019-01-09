Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmPromotions
    Private Shared _RecordCount As Integer
    Private _CardNo As String
    Private _EmployeeName As String
    Private _C_DateOfJoining As String
    Private _C_DepartmentID As String
    Private _C_DesignationID As Int32
    Private _U_UnderPromotion As Boolean
    Private _U_NewDesignationID As String
    Private _C_PromotionOn As String
    Private _C_PromotionRemark As String
    Private _Resigned As Boolean
    Private _ActiveState As Boolean
    Private _Confirmed As Boolean
    Private _ModifiedEvent As String
    Private _ModifiedOn As String
    Private _ModifiedBy As String
    Private _C_DepartmentIDHRM_Departments As SIS.HRM.hrmDepartments
    Private _C_DesignationIDHRM_Designations As SIS.HRM.hrmDesignations
    Private _U_NewDesignationIDHRM_Designations As SIS.HRM.hrmDesignations
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
    Public Property U_UnderPromotion() As Boolean
      Get
        Return _U_UnderPromotion
      End Get
      Set(ByVal value As Boolean)
        _U_UnderPromotion = value
      End Set
    End Property
    Public Property U_NewDesignationID() As String
      Get
        Return _U_NewDesignationID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _U_NewDesignationID = ""
				 Else
					 _U_NewDesignationID = value
			   End If
      End Set
    End Property
    Public Property C_PromotionOn() As String
      Get
        If Not _C_PromotionOn = String.Empty Then
          Return Convert.ToDateTime(_C_PromotionOn).ToString("dd/MM/yyyy")
        End If
        Return _C_PromotionOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_PromotionOn = ""
				 Else
					 _C_PromotionOn = value
			   End If
      End Set
    End Property
    Public Property C_PromotionRemark() As String
      Get
        Return _C_PromotionRemark
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _C_PromotionRemark = ""
				 Else
					 _C_PromotionRemark = value
			   End If
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
    Public Property ActiveState() As Boolean
      Get
        Return _ActiveState
      End Get
      Set(ByVal value As Boolean)
        _ActiveState = value
      End Set
    End Property
    Public Property Confirmed() As Boolean
      Get
        Return _Confirmed
      End Get
      Set(ByVal value As Boolean)
        _Confirmed = value
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
    Public ReadOnly Property U_NewDesignationIDHRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _U_NewDesignationIDHRM_Designations Is Nothing Then
          _U_NewDesignationIDHRM_Designations = SIS.HRM.hrmDesignations.GetByID(_U_NewDesignationID)
        End If
        Return _U_NewDesignationIDHRM_Designations
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
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.hrmPromotions
      Dim Results As SIS.HRM.hrmPromotions = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmPromotionsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmPromotions(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmPromotions)
      Dim Results As List(Of SIS.HRM.hrmPromotions) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmPromotionsSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmPromotionsSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderPromotion",SqlDbType.Bit,2, 0)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Resigned",SqlDbType.Bit,2, 0)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,2, 1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Confirmed",SqlDbType.Bit,2, 1)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmPromotions)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmPromotions(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmPromotions) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmPromotionsUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID",SqlDbType.Int,11, Record.C_DesignationID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_UnderPromotion",SqlDbType.Bit,3, Record.U_UnderPromotion)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@U_NewDesignationID",SqlDbType.Int,11, Iif(Record.U_NewDesignationID= "" ,Convert.DBNull, Record.U_NewDesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionOn",SqlDbType.DateTime,21, Iif(Record.C_PromotionOn= "" ,Convert.DBNull, Record.C_PromotionOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_PromotionRemark",SqlDbType.NVarChar,251, Iif(Record.C_PromotionRemark= "" ,Convert.DBNull, Record.C_PromotionRemark))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedEvent",SqlDbType.NVarChar,21, "Promotion")
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedOn",SqlDbType.DateTime,21, Now)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModifiedBy",SqlDbType.NVarChar,21, Global.System.Web.HttpContext.Current.Session("LoginID"))
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
      _U_UnderPromotion = Ctype(Reader("U_UnderPromotion"),Boolean)
      If Convert.IsDBNull(Reader("U_NewDesignationID")) Then
        _U_NewDesignationID = String.Empty
      Else
        _U_NewDesignationID = Ctype(Reader("U_NewDesignationID"), String)
      End If
      If Convert.IsDBNull(Reader("C_PromotionOn")) Then
        _C_PromotionOn = String.Empty
      Else
        _C_PromotionOn = Ctype(Reader("C_PromotionOn"), String)
      End If
      If Convert.IsDBNull(Reader("C_PromotionRemark")) Then
        _C_PromotionRemark = String.Empty
      Else
        _C_PromotionRemark = Ctype(Reader("C_PromotionRemark"), String)
      End If
      _Resigned = Ctype(Reader("Resigned"),Boolean)
      _ActiveState = Ctype(Reader("ActiveState"),Boolean)
      _Confirmed = Ctype(Reader("Confirmed"),Boolean)
      If Convert.IsDBNull(Reader("ModifiedEvent")) Then
        _ModifiedEvent = String.Empty
      Else
        _ModifiedEvent = Ctype(Reader("ModifiedEvent"), String)
      End If
      If Convert.IsDBNull(Reader("ModifiedOn")) Then
        _ModifiedOn = String.Empty
      Else
        _ModifiedOn = Ctype(Reader("ModifiedOn"), String)
      End If
      If Convert.IsDBNull(Reader("ModifiedBy")) Then
        _ModifiedBy = String.Empty
      Else
        _ModifiedBy = Ctype(Reader("ModifiedBy"), String)
      End If
      _C_DepartmentIDHRM_Departments = New SIS.HRM.hrmDepartments("HRM_Departments1",Reader)
      _C_DesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations2",Reader)
      _U_NewDesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations3",Reader)
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
      _U_UnderPromotion = Ctype(Reader(AliasName & "_U_UnderPromotion"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_U_NewDesignationID")) Then
        _U_NewDesignationID = String.Empty
      Else
        _U_NewDesignationID = Ctype(Reader(AliasName & "_U_NewDesignationID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_PromotionOn")) Then
        _C_PromotionOn = String.Empty
      Else
        _C_PromotionOn = Ctype(Reader(AliasName & "_C_PromotionOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_C_PromotionRemark")) Then
        _C_PromotionRemark = String.Empty
      Else
        _C_PromotionRemark = Ctype(Reader(AliasName & "_C_PromotionRemark"), String)
      End If
      _Resigned = Ctype(Reader(AliasName & "_Resigned"),Boolean)
      _ActiveState = Ctype(Reader(AliasName & "_ActiveState"),Boolean)
      _Confirmed = Ctype(Reader(AliasName & "_Confirmed"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedEvent")) Then
        _ModifiedEvent = String.Empty
      Else
        _ModifiedEvent = Ctype(Reader(AliasName & "_ModifiedEvent"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedOn")) Then
        _ModifiedOn = String.Empty
      Else
        _ModifiedOn = Ctype(Reader(AliasName & "_ModifiedOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ModifiedBy")) Then
        _ModifiedBy = String.Empty
      Else
        _ModifiedBy = Ctype(Reader(AliasName & "_ModifiedBy"), String)
      End If
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
