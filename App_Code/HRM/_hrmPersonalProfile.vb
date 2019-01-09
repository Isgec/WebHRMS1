Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmPersonalProfile
    Private Shared _RecordCount As Integer
    Private _CardNo As String
    Private _EmployeeName As String
    Private _FatherName As String
    Private _SpouseName As String
    Private _PermanentAddress As String
    Private _PermanentCity As String
    Private _CurrentAddress As String
    Private _CurrentCity As String
    Private _DateOfBirth As String
    Private _BloodGroupID As String
    Private _ContactNumbers As String
    Private _OfficeFileNumber As String
    Private _PFNumber As String
    Private _ESINumber As String
    Private _PAN As String
    Private _EMailID As String
    Private _BloodGroupIDHRM_BloodGroups As SIS.HRM.hrmBloodGroups
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
    Public Property FatherName() As String
      Get
        Return _FatherName
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FatherName = ""
				 Else
					 _FatherName = value
			   End If
      End Set
    End Property
    Public Property SpouseName() As String
      Get
        Return _SpouseName
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _SpouseName = ""
				 Else
					 _SpouseName = value
			   End If
      End Set
    End Property
    Public Property PermanentAddress() As String
      Get
        Return _PermanentAddress
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PermanentAddress = ""
				 Else
					 _PermanentAddress = value
			   End If
      End Set
    End Property
    Public Property PermanentCity() As String
      Get
        Return _PermanentCity
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PermanentCity = ""
				 Else
					 _PermanentCity = value
			   End If
      End Set
    End Property
    Public Property CurrentAddress() As String
      Get
        Return _CurrentAddress
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CurrentAddress = ""
				 Else
					 _CurrentAddress = value
			   End If
      End Set
    End Property
    Public Property CurrentCity() As String
      Get
        Return _CurrentCity
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CurrentCity = ""
				 Else
					 _CurrentCity = value
			   End If
      End Set
    End Property
    Public Property DateOfBirth() As String
      Get
        If Not _DateOfBirth = String.Empty Then
          Return Convert.ToDateTime(_DateOfBirth).ToString("dd/MM/yyyy")
        End If
        Return _DateOfBirth
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _DateOfBirth = ""
				 Else
					 _DateOfBirth = value
			   End If
      End Set
    End Property
    Public Property BloodGroupID() As String
      Get
        Return _BloodGroupID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _BloodGroupID = ""
				 Else
					 _BloodGroupID = value
			   End If
      End Set
    End Property
    Public Property ContactNumbers() As String
      Get
        Return _ContactNumbers
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ContactNumbers = ""
				 Else
					 _ContactNumbers = value
			   End If
      End Set
    End Property
    Public Property OfficeFileNumber() As String
      Get
        Return _OfficeFileNumber
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _OfficeFileNumber = ""
				 Else
					 _OfficeFileNumber = value
			   End If
      End Set
    End Property
    Public Property PFNumber() As String
      Get
        Return _PFNumber
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PFNumber = ""
				 Else
					 _PFNumber = value
			   End If
      End Set
    End Property
    Public Property ESINumber() As String
      Get
        Return _ESINumber
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ESINumber = ""
				 Else
					 _ESINumber = value
			   End If
      End Set
    End Property
    Public Property PAN() As String
      Get
        Return _PAN
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _PAN = ""
				 Else
					 _PAN = value
			   End If
      End Set
    End Property
    Public Property EMailID() As String
      Get
        Return _EMailID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _EMailID = ""
				 Else
					 _EMailID = value
			   End If
      End Set
    End Property
    Public ReadOnly Property BloodGroupIDHRM_BloodGroups() As SIS.HRM.hrmBloodGroups
      Get
        If _BloodGroupIDHRM_BloodGroups Is Nothing Then
          _BloodGroupIDHRM_BloodGroups = SIS.HRM.hrmBloodGroups.GetByID(_BloodGroupID)
        End If
        Return _BloodGroupIDHRM_BloodGroups
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.hrmPersonalProfile
      Dim Results As SIS.HRM.hrmPersonalProfile = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmPersonalProfileSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmPersonalProfile(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmPersonalProfile)
      Dim Results As List(Of SIS.HRM.hrmPersonalProfile) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmPersonalProfileSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmPersonalProfileSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmPersonalProfile)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmPersonalProfile(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmPersonalProfile) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmPersonalProfileUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FatherName",SqlDbType.NVarChar,51, Iif(Record.FatherName= "" ,Convert.DBNull, Record.FatherName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SpouseName",SqlDbType.NVarChar,51, Iif(Record.SpouseName= "" ,Convert.DBNull, Record.SpouseName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PermanentAddress",SqlDbType.NVarChar,251, Iif(Record.PermanentAddress= "" ,Convert.DBNull, Record.PermanentAddress))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PermanentCity",SqlDbType.NVarChar,51, Iif(Record.PermanentCity= "" ,Convert.DBNull, Record.PermanentCity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CurrentAddress",SqlDbType.NVarChar,251, Iif(Record.CurrentAddress= "" ,Convert.DBNull, Record.CurrentAddress))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CurrentCity",SqlDbType.NVarChar,51, Iif(Record.CurrentCity= "" ,Convert.DBNull, Record.CurrentCity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DateOfBirth",SqlDbType.DateTime,21, Iif(Record.DateOfBirth= "" ,Convert.DBNull, Record.DateOfBirth))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@BloodGroupID",SqlDbType.NVarChar,6, Iif(Record.BloodGroupID= "" ,Convert.DBNull, Record.BloodGroupID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ContactNumbers",SqlDbType.NVarChar,101, Iif(Record.ContactNumbers= "" ,Convert.DBNull, Record.ContactNumbers))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfficeFileNumber",SqlDbType.NVarChar,51, Iif(Record.OfficeFileNumber= "" ,Convert.DBNull, Record.OfficeFileNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PFNumber",SqlDbType.NVarChar,51, Iif(Record.PFNumber= "" ,Convert.DBNull, Record.PFNumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ESINumber",SqlDbType.NVarChar,51, Iif(Record.ESINumber= "" ,Convert.DBNull, Record.ESINumber))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PAN",SqlDbType.NVarChar,21, Iif(Record.PAN= "" ,Convert.DBNull, Record.PAN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EMailID",SqlDbType.NVarChar,51, Iif(Record.EMailID= "" ,Convert.DBNull, Record.EMailID))
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
      If Convert.IsDBNull(Reader("FatherName")) Then
        _FatherName = String.Empty
      Else
        _FatherName = Ctype(Reader("FatherName"), String)
      End If
      If Convert.IsDBNull(Reader("SpouseName")) Then
        _SpouseName = String.Empty
      Else
        _SpouseName = Ctype(Reader("SpouseName"), String)
      End If
      If Convert.IsDBNull(Reader("PermanentAddress")) Then
        _PermanentAddress = String.Empty
      Else
        _PermanentAddress = Ctype(Reader("PermanentAddress"), String)
      End If
      If Convert.IsDBNull(Reader("PermanentCity")) Then
        _PermanentCity = String.Empty
      Else
        _PermanentCity = Ctype(Reader("PermanentCity"), String)
      End If
      If Convert.IsDBNull(Reader("CurrentAddress")) Then
        _CurrentAddress = String.Empty
      Else
        _CurrentAddress = Ctype(Reader("CurrentAddress"), String)
      End If
      If Convert.IsDBNull(Reader("CurrentCity")) Then
        _CurrentCity = String.Empty
      Else
        _CurrentCity = Ctype(Reader("CurrentCity"), String)
      End If
      If Convert.IsDBNull(Reader("DateOfBirth")) Then
        _DateOfBirth = String.Empty
      Else
        _DateOfBirth = Ctype(Reader("DateOfBirth"), String)
      End If
      If Convert.IsDBNull(Reader("BloodGroupID")) Then
        _BloodGroupID = String.Empty
      Else
        _BloodGroupID = Ctype(Reader("BloodGroupID"), String)
      End If
      If Convert.IsDBNull(Reader("ContactNumbers")) Then
        _ContactNumbers = String.Empty
      Else
        _ContactNumbers = Ctype(Reader("ContactNumbers"), String)
      End If
      If Convert.IsDBNull(Reader("OfficeFileNumber")) Then
        _OfficeFileNumber = String.Empty
      Else
        _OfficeFileNumber = Ctype(Reader("OfficeFileNumber"), String)
      End If
      If Convert.IsDBNull(Reader("PFNumber")) Then
        _PFNumber = String.Empty
      Else
        _PFNumber = Ctype(Reader("PFNumber"), String)
      End If
      If Convert.IsDBNull(Reader("ESINumber")) Then
        _ESINumber = String.Empty
      Else
        _ESINumber = Ctype(Reader("ESINumber"), String)
      End If
      If Convert.IsDBNull(Reader("PAN")) Then
        _PAN = String.Empty
      Else
        _PAN = Ctype(Reader("PAN"), String)
      End If
      If Convert.IsDBNull(Reader("EMailID")) Then
        _EMailID = String.Empty
      Else
        _EMailID = Ctype(Reader("EMailID"), String)
      End If
      _BloodGroupIDHRM_BloodGroups = New SIS.HRM.hrmBloodGroups("HRM_BloodGroups1",Reader)
    End Sub
    Public Sub New(ByVal AliasName As String, ByVal Reader As SqlDataReader)
      On Error Resume Next
      _CardNo = Ctype(Reader(AliasName & "_CardNo"),String)
      _EmployeeName = Ctype(Reader(AliasName & "_EmployeeName"),String)
      If Convert.IsDBNull(Reader(AliasName & "_FatherName")) Then
        _FatherName = String.Empty
      Else
        _FatherName = Ctype(Reader(AliasName & "_FatherName"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_SpouseName")) Then
        _SpouseName = String.Empty
      Else
        _SpouseName = Ctype(Reader(AliasName & "_SpouseName"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_PermanentAddress")) Then
        _PermanentAddress = String.Empty
      Else
        _PermanentAddress = Ctype(Reader(AliasName & "_PermanentAddress"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_PermanentCity")) Then
        _PermanentCity = String.Empty
      Else
        _PermanentCity = Ctype(Reader(AliasName & "_PermanentCity"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_CurrentAddress")) Then
        _CurrentAddress = String.Empty
      Else
        _CurrentAddress = Ctype(Reader(AliasName & "_CurrentAddress"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_CurrentCity")) Then
        _CurrentCity = String.Empty
      Else
        _CurrentCity = Ctype(Reader(AliasName & "_CurrentCity"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_DateOfBirth")) Then
        _DateOfBirth = String.Empty
      Else
        _DateOfBirth = Ctype(Reader(AliasName & "_DateOfBirth"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_BloodGroupID")) Then
        _BloodGroupID = String.Empty
      Else
        _BloodGroupID = Ctype(Reader(AliasName & "_BloodGroupID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ContactNumbers")) Then
        _ContactNumbers = String.Empty
      Else
        _ContactNumbers = Ctype(Reader(AliasName & "_ContactNumbers"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_OfficeFileNumber")) Then
        _OfficeFileNumber = String.Empty
      Else
        _OfficeFileNumber = Ctype(Reader(AliasName & "_OfficeFileNumber"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_PFNumber")) Then
        _PFNumber = String.Empty
      Else
        _PFNumber = Ctype(Reader(AliasName & "_PFNumber"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_ESINumber")) Then
        _ESINumber = String.Empty
      Else
        _ESINumber = Ctype(Reader(AliasName & "_ESINumber"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_PAN")) Then
        _PAN = String.Empty
      Else
        _PAN = Ctype(Reader(AliasName & "_PAN"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_EMailID")) Then
        _EMailID = String.Empty
      Else
        _EMailID = Ctype(Reader(AliasName & "_EMailID"), String)
      End If
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
