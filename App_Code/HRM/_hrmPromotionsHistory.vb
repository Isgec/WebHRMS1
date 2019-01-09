Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmPromotionsHistory
    Private Shared _RecordCount As Integer
    Private _PromotionID As Int32
    Private _CardNo As String
    Private _PromotionOn As String
    Private _DesignationID As Int32
    Private _Remarks As String
    Private _Executed As Boolean
    Private _Cancelled As Boolean
    Private _ProcessedBy As String
    Private _ProcessedOn As String
    Private _CardNoHRM_Employees As SIS.HRM.hrmEmployees
    Private _DesignationIDHRM_Designations As SIS.HRM.hrmDesignations
    Private _ProcessedByHRM_Employees As SIS.HRM.hrmEmployees
    Public Property PromotionID() As Int32
      Get
        Return _PromotionID
      End Get
      Set(ByVal value As Int32)
        _PromotionID = value
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
    Public Property PromotionOn() As String
      Get
        If Not _PromotionOn = String.Empty Then
          Return Convert.ToDateTime(_PromotionOn).ToString("dd/MM/yyyy")
        End If
        Return _PromotionOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PromotionOn = ""
				 Else
					 _PromotionOn = value
			   End If
      End Set
    End Property
    Public Property DesignationID() As Int32
      Get
        Return _DesignationID
      End Get
      Set(ByVal value As Int32)
        _DesignationID = value
      End Set
    End Property
    Public Property Remarks() As String
      Get
        Return _Remarks
      End Get
      Set(ByVal value As String)
        _Remarks = value
      End Set
    End Property
    Public Property Executed() As Boolean
      Get
        Return _Executed
      End Get
      Set(ByVal value As Boolean)
        _Executed = value
      End Set
    End Property
    Public Property Cancelled() As Boolean
      Get
        Return _Cancelled
      End Get
      Set(ByVal value As Boolean)
        _Cancelled = value
      End Set
    End Property
    Public Property ProcessedBy() As String
      Get
        Return _ProcessedBy
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ProcessedBy = ""
				 Else
					 _ProcessedBy = value
			   End If
      End Set
    End Property
    Public Property ProcessedOn() As String
      Get
        If Not _ProcessedOn = String.Empty Then
          Return Convert.ToDateTime(_ProcessedOn).ToString("dd/MM/yyyy")
        End If
        Return _ProcessedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ProcessedOn = ""
				 Else
					 _ProcessedOn = value
			   End If
      End Set
    End Property
    Public ReadOnly Property CardNoHRM_Employees() As SIS.HRM.hrmEmployees
      Get
        If _CardNoHRM_Employees Is Nothing Then
          _CardNoHRM_Employees = SIS.HRM.hrmEmployees.GetByID(_CardNo)
        End If
        Return _CardNoHRM_Employees
      End Get
    End Property
    Public ReadOnly Property DesignationIDHRM_Designations() As SIS.HRM.hrmDesignations
      Get
        If _DesignationIDHRM_Designations Is Nothing Then
          _DesignationIDHRM_Designations = SIS.HRM.hrmDesignations.GetByID(_DesignationID)
        End If
        Return _DesignationIDHRM_Designations
      End Get
    End Property
    Public ReadOnly Property ProcessedByHRM_Employees() As SIS.HRM.hrmEmployees
      Get
        If _ProcessedByHRM_Employees Is Nothing Then
          _ProcessedByHRM_Employees = SIS.HRM.hrmEmployees.GetByID(_ProcessedBy)
        End If
        Return _ProcessedByHRM_Employees
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal PromotionID As Int32) As SIS.HRM.hrmPromotionsHistory
      Dim Results As SIS.HRM.hrmPromotionsHistory = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmPromotionsHistorySelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PromotionID",SqlDbType.Int,PromotionID.ToString.Length, PromotionID)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmPromotionsHistory(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmPromotionsHistory)
      Dim Results As List(Of SIS.HRM.hrmPromotionsHistory) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmPromotionsHistorySelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmPromotionsHistorySelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Executed",SqlDbType.Bit,2, 0)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Cancelled",SqlDbType.Bit,2, 0)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmPromotionsHistory)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmPromotionsHistory(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function Insert(ByVal Record As SIS.HRM.hrmPromotionsHistory) As Int32
      Dim _Result As Int32 = Record.PromotionID
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmPromotionsHistoryInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PromotionOn",SqlDbType.DateTime,21, Iif(Record.PromotionOn= "" ,Convert.DBNull, Record.PromotionOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DesignationID",SqlDbType.Int,11, Record.DesignationID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Remarks",SqlDbType.NVarChar,251, Record.Remarks)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Executed",SqlDbType.Bit,3, Record.Executed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Cancelled",SqlDbType.Bit,3, Record.Cancelled)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessedBy",SqlDbType.NVarChar,9, Global.System.Web.HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessedOn",SqlDbType.DateTime,21, Now)
          Cmd.Parameters.Add("@Return_PromotionID", SqlDbType.Int, 10)
          Cmd.Parameters("@Return_PromotionID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@Return_PromotionID").Value
        End Using
      End Using
      Return _Result
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmPromotionsHistory) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmPromotionsHistoryUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_PromotionID",SqlDbType.Int,11, Record.PromotionID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Executed",SqlDbType.Bit,3, Record.Executed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Cancelled",SqlDbType.Bit,3, Record.Cancelled)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessedBy",SqlDbType.NVarChar,9, Global.System.Web.HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessedOn",SqlDbType.DateTime,21, Now)
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
      _PromotionID = Ctype(Reader("PromotionID"),Int32)
      _CardNo = Ctype(Reader("CardNo"),String)
      If Convert.IsDBNull(Reader("PromotionOn")) Then
        _PromotionOn = String.Empty
      Else
        _PromotionOn = Ctype(Reader("PromotionOn"), String)
      End If
      _DesignationID = Ctype(Reader("DesignationID"),Int32)
      _Remarks = Ctype(Reader("Remarks"),String)
      _Executed = Ctype(Reader("Executed"),Boolean)
      _Cancelled = Ctype(Reader("Cancelled"),Boolean)
      If Convert.IsDBNull(Reader("ProcessedBy")) Then
        _ProcessedBy = String.Empty
      Else
        _ProcessedBy = Ctype(Reader("ProcessedBy"), String)
      End If
      If Convert.IsDBNull(Reader("ProcessedOn")) Then
        _ProcessedOn = String.Empty
      Else
        _ProcessedOn = Ctype(Reader("ProcessedOn"), String)
      End If
      _CardNoHRM_Employees = New SIS.HRM.hrmEmployees("HRM_Employees1",Reader)
      _DesignationIDHRM_Designations = New SIS.HRM.hrmDesignations("HRM_Designations2",Reader)
      _ProcessedByHRM_Employees = New SIS.HRM.hrmEmployees("HRM_Employees3",Reader)
    End Sub
    Public Sub New(ByVal AliasName As String, ByVal Reader As SqlDataReader)
      On Error Resume Next
      _PromotionID = Ctype(Reader(AliasName & "_PromotionID"),Int32)
      _CardNo = Ctype(Reader(AliasName & "_CardNo"),String)
      If Convert.IsDBNull(Reader(AliasName & "_PromotionOn")) Then
        _PromotionOn = String.Empty
      Else
        _PromotionOn = Ctype(Reader(AliasName & "_PromotionOn"), String)
      End If
      _DesignationID = Ctype(Reader(AliasName & "_DesignationID"),Int32)
      _Remarks = Ctype(Reader(AliasName & "_Remarks"),String)
      _Executed = Ctype(Reader(AliasName & "_Executed"),Boolean)
      _Cancelled = Ctype(Reader(AliasName & "_Cancelled"),Boolean)
      If Convert.IsDBNull(Reader(AliasName & "_ProcessedBy")) Then
        _ProcessedBy = String.Empty
      Else
        _ProcessedBy = Ctype(Reader(AliasName & "_ProcessedBy"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ProcessedOn")) Then
        _ProcessedOn = String.Empty
      Else
        _ProcessedOn = Ctype(Reader(AliasName & "_ProcessedOn"), String)
      End If
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
