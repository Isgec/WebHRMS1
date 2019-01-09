Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmResignationsHistory
    Private Shared _RecordCount As Integer
    Private _ResignID As Int32
    Private _CardNo As String
    Private _StatusID As String
    Private _ResignedOn As String
    Private _ReleavedOn As String
    Private _Remarks As String
    Private _Executed As Boolean
    Private _Cancelled As Boolean
    Private _ProcessedBy As String
    Private _ProcessedOn As String
    Private _CardNoHRM_Employees As SIS.HRM.hrmEmployees
    Private _StatusIDHRM_Status As SIS.HRM.hrmStatus
    Private _ProcessedByHRM_Employees As SIS.HRM.hrmEmployees
    Public Property ResignID() As Int32
      Get
        Return _ResignID
      End Get
      Set(ByVal value As Int32)
        _ResignID = value
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
    Public Property StatusID() As String
      Get
        Return _StatusID
      End Get
      Set(ByVal value As String)
        _StatusID = value
      End Set
    End Property
    Public Property ResignedOn() As String
      Get
        If Not _ResignedOn = String.Empty Then
          Return Convert.ToDateTime(_ResignedOn).ToString("dd/MM/yyyy")
        End If
        Return _ResignedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ResignedOn = ""
				 Else
					 _ResignedOn = value
			   End If
      End Set
    End Property
    Public Property ReleavedOn() As String
      Get
        If Not _ReleavedOn = String.Empty Then
          Return Convert.ToDateTime(_ReleavedOn).ToString("dd/MM/yyyy")
        End If
        Return _ReleavedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ReleavedOn = ""
				 Else
					 _ReleavedOn = value
			   End If
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
    Public ReadOnly Property StatusIDHRM_Status() As SIS.HRM.hrmStatus
      Get
        If _StatusIDHRM_Status Is Nothing Then
          _StatusIDHRM_Status = SIS.HRM.hrmStatus.GetByID(_StatusID)
        End If
        Return _StatusIDHRM_Status
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
    Public Shared Function GetByID(ByVal ResignID As Int32) As SIS.HRM.hrmResignationsHistory
      Dim Results As SIS.HRM.hrmResignationsHistory = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmResignationsHistorySelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ResignID",SqlDbType.Int,ResignID.ToString.Length, ResignID)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmResignationsHistory(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmResignationsHistory)
      Dim Results As List(Of SIS.HRM.hrmResignationsHistory) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmResignationsHistorySelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmResignationsHistorySelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Executed",SqlDbType.Bit,2, 0)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Cancelled",SqlDbType.Bit,2, 0)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmResignationsHistory)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmResignationsHistory(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function Insert(ByVal Record As SIS.HRM.hrmResignationsHistory) As Int32
      Dim _Result As Int32 = Record.ResignID
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmResignationsHistoryInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.NVarChar,3, Record.StatusID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ResignedOn",SqlDbType.DateTime,21, Iif(Record.ResignedOn= "" ,Convert.DBNull, Record.ResignedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ReleavedOn",SqlDbType.DateTime,21, Iif(Record.ReleavedOn= "" ,Convert.DBNull, Record.ReleavedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Remarks",SqlDbType.NVarChar,251, Record.Remarks)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Executed",SqlDbType.Bit,3, Record.Executed)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Cancelled",SqlDbType.Bit,3, Record.Cancelled)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessedBy",SqlDbType.NVarChar,9, Global.System.Web.HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProcessedOn",SqlDbType.DateTime,21, Now)
          Cmd.Parameters.Add("@Return_ResignID", SqlDbType.Int, 10)
          Cmd.Parameters("@Return_ResignID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@Return_ResignID").Value
        End Using
      End Using
      Return _Result
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmResignationsHistory) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmResignationsHistoryUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ResignID",SqlDbType.Int,11, Record.ResignID)
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
      _ResignID = Ctype(Reader("ResignID"),Int32)
      _CardNo = Ctype(Reader("CardNo"),String)
      _StatusID = Ctype(Reader("StatusID"),String)
      If Convert.IsDBNull(Reader("ResignedOn")) Then
        _ResignedOn = String.Empty
      Else
        _ResignedOn = Ctype(Reader("ResignedOn"), String)
      End If
      If Convert.IsDBNull(Reader("ReleavedOn")) Then
        _ReleavedOn = String.Empty
      Else
        _ReleavedOn = Ctype(Reader("ReleavedOn"), String)
      End If
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
      _StatusIDHRM_Status = New SIS.HRM.hrmStatus("HRM_Status2",Reader)
      _ProcessedByHRM_Employees = New SIS.HRM.hrmEmployees("HRM_Employees3",Reader)
    End Sub
    Public Sub New(ByVal AliasName As String, ByVal Reader As SqlDataReader)
      On Error Resume Next
      _ResignID = Ctype(Reader(AliasName & "_ResignID"),Int32)
      _CardNo = Ctype(Reader(AliasName & "_CardNo"),String)
      _StatusID = Ctype(Reader(AliasName & "_StatusID"),String)
      If Convert.IsDBNull(Reader(AliasName & "_ResignedOn")) Then
        _ResignedOn = String.Empty
      Else
        _ResignedOn = Ctype(Reader(AliasName & "_ResignedOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ReleavedOn")) Then
        _ReleavedOn = String.Empty
      Else
        _ReleavedOn = Ctype(Reader(AliasName & "_ReleavedOn"), String)
      End If
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
