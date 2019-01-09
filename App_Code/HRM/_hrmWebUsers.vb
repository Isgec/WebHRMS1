Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmWebUsers
    Private Shared _RecordCount As Integer
    Private _ApplicationId As String = ""
    Private _UserId As String = ""
    Private _UserName As String = ""
    Private _LoweredUserName As String = ""
    Private _MobileAlias As String = ""
    Private _IsAnonymous As Boolean = False
    Private _LastActivityDate As String = ""
    Private _UserFullName As String = ""
    Private _LocationID As String = ""
    Private _ExtnNo As String = ""
    Private _MobileNo As String = ""
    Private _EMailID As String = ""
    Private _C_DateOfJoining As String = ""
    Private _C_CompanyID As String = ""
    Private _C_DivisionID As String = ""
    Private _C_OfficeID As String = ""
    Private _C_DepartmentID As String = ""
    Private _C_ProjectSiteID As String = ""
    Private _C_DesignationID As String = ""
    Private _ActiveState As String = ""
    Private _VPN_IP As String = ""
    Private _VPN_Password As String = ""
    Private _VPN_Expires As String = ""
    Private _LoginID As String = ""
    Private _Contractual As Boolean = False
    Private _MD5Password As String = ""
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
    Public Property ApplicationId() As String
      Get
        Return _ApplicationId
      End Get
      Set(ByVal value As String)
        _ApplicationId = value
      End Set
    End Property
    Public Property UserId() As String
      Get
        Return _UserId
      End Get
      Set(ByVal value As String)
        _UserId = value
      End Set
    End Property
    Public Property UserName() As String
      Get
        Return _UserName
      End Get
      Set(ByVal value As String)
        _UserName = value
      End Set
    End Property
    Public Property LoweredUserName() As String
      Get
        Return _LoweredUserName
      End Get
      Set(ByVal value As String)
        _LoweredUserName = value
      End Set
    End Property
    Public Property MobileAlias() As String
      Get
        Return _MobileAlias
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _MobileAlias = ""
				 Else
					 _MobileAlias = value
			   End If
      End Set
    End Property
    Public Property IsAnonymous() As Boolean
      Get
        Return _IsAnonymous
      End Get
      Set(ByVal value As Boolean)
        _IsAnonymous = value
      End Set
    End Property
    Public Property LastActivityDate() As String
      Get
        If Not _LastActivityDate = String.Empty Then
          Return Convert.ToDateTime(_LastActivityDate).ToString("dd/MM/yyyy")
        End If
        Return _LastActivityDate
      End Get
      Set(ByVal value As String)
			   _LastActivityDate = value
      End Set
    End Property
    Public Property UserFullName() As String
      Get
        Return _UserFullName
      End Get
      Set(ByVal value As String)
        _UserFullName = value
      End Set
    End Property
    Public Property LocationID() As String
      Get
        Return _LocationID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _LocationID = ""
				 Else
					 _LocationID = value
			   End If
      End Set
    End Property
    Public Property ExtnNo() As String
      Get
        Return _ExtnNo
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ExtnNo = ""
				 Else
					 _ExtnNo = value
			   End If
      End Set
    End Property
    Public Property MobileNo() As String
      Get
        Return _MobileNo
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _MobileNo = ""
				 Else
					 _MobileNo = value
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
    Public Property ActiveState() As String
      Get
        Return _ActiveState
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _ActiveState = ""
				 Else
					 _ActiveState = value
			   End If
      End Set
    End Property
    Public Property VPN_IP() As String
      Get
        Return _VPN_IP
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _VPN_IP = ""
				 Else
					 _VPN_IP = value
			   End If
      End Set
    End Property
    Public Property VPN_Password() As String
      Get
        Return _VPN_Password
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _VPN_Password = ""
				 Else
					 _VPN_Password = value
			   End If
      End Set
    End Property
    Public Property VPN_Expires() As String
      Get
        If Not _VPN_Expires = String.Empty Then
          Return Convert.ToDateTime(_VPN_Expires).ToString("dd/MM/yyyy")
        End If
        Return _VPN_Expires
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _VPN_Expires = ""
				 Else
					 _VPN_Expires = value
			   End If
      End Set
    End Property
    Public Property LoginID() As String
      Get
        Return _LoginID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _LoginID = ""
				 Else
					 _LoginID = value
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
    Public Property MD5Password() As String
      Get
        Return _MD5Password
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _MD5Password = ""
				 Else
					 _MD5Password = value
			   End If
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _UserFullName.ToString.PadRight(50, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _UserName
      End Get
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public Class PKhrmWebUsers
			Private _UserName As String = ""
			Public Property UserName() As String
				Get
					Return _UserName
				End Get
				Set(ByVal value As String)
					_UserName = value
				End Set
			End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal orderBy As String) As List(Of SIS.HRM.hrmWebUsers)
      Dim Results As List(Of SIS.HRM.hrmWebUsers) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmWebUsersSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmWebUsers)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmWebUsers(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetNewRecord() As SIS.HRM.hrmWebUsers
      Return New SIS.HRM.hrmWebUsers()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal UserName As String) As SIS.HRM.hrmWebUsers
      Dim Results As SIS.HRM.hrmWebUsers = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmWebUsersSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UserName",SqlDbType.NVarChar,UserName.ToString.Length, UserName)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmWebUsers(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmWebUsers)
      Dim Results As List(Of SIS.HRM.hrmWebUsers) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmWebUsersSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmWebUsersSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmWebUsers)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmWebUsers(Reader))
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
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function Insert(ByVal Record As SIS.HRM.hrmWebUsers) As SIS.HRM.hrmWebUsers
      Dim _Rec As SIS.HRM.hrmWebUsers = SIS.HRM.hrmWebUsers.GetNewRecord()
      With _Rec
        .UserName = Record.UserName
        .LoweredUserName = Record.LoweredUserName
        .MobileAlias = Record.MobileAlias
        .IsAnonymous = Record.IsAnonymous
        .LastActivityDate = Record.LastActivityDate
        .UserFullName = Record.UserFullName
        .LocationID = Record.LocationID
        .ExtnNo = Record.ExtnNo
        .MobileNo = Record.MobileNo
        .EMailID = Record.EMailID
        .C_DateOfJoining = Record.C_DateOfJoining
        .C_CompanyID = Record.C_CompanyID
        .C_DivisionID = Record.C_DivisionID
        .C_OfficeID = Record.C_OfficeID
        .C_DepartmentID = Record.C_DepartmentID
        .C_ProjectSiteID = Record.C_ProjectSiteID
        .C_DesignationID = Record.C_DesignationID
        .ActiveState = Record.ActiveState
        .VPN_IP = Record.VPN_IP
        .VPN_Password = Record.VPN_Password
        .VPN_Expires = Record.VPN_Expires
        .LoginID = Record.LoginID
        .Contractual = Record.Contractual
        .MD5Password = Record.MD5Password
      End With
      Return SIS.HRM.hrmWebUsers.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.HRM.hrmWebUsers) As SIS.HRM.hrmWebUsers
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmWebUsersInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UserName",SqlDbType.NVarChar,257, Record.UserName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoweredUserName",SqlDbType.NVarChar,257, Record.LoweredUserName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MobileAlias",SqlDbType.NVarChar,17, Iif(Record.MobileAlias= "" ,Convert.DBNull, Record.MobileAlias))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsAnonymous",SqlDbType.Bit,3, Record.IsAnonymous)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LastActivityDate",SqlDbType.DateTime,21, Record.LastActivityDate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UserFullName",SqlDbType.NVarChar,51, Record.UserFullName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LocationID",SqlDbType.Int,11, Iif(Record.LocationID= "" ,Convert.DBNull, Record.LocationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ExtnNo",SqlDbType.NVarChar,51, Iif(Record.ExtnNo= "" ,Convert.DBNull, Record.ExtnNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MobileNo",SqlDbType.NVarChar,51, Iif(Record.MobileNo= "" ,Convert.DBNull, Record.MobileNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EMailID",SqlDbType.NVarChar,51, Iif(Record.EMailID= "" ,Convert.DBNull, Record.EMailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining",SqlDbType.DateTime,21, Iif(Record.C_DateOfJoining= "" ,Convert.DBNull, Record.C_DateOfJoining))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_CompanyID",SqlDbType.NVarChar,7, Iif(Record.C_CompanyID= "" ,Convert.DBNull, Record.C_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DivisionID",SqlDbType.NVarChar,7, Iif(Record.C_DivisionID= "" ,Convert.DBNull, Record.C_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_OfficeID",SqlDbType.Int,11, Iif(Record.C_OfficeID= "" ,Convert.DBNull, Record.C_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.C_DepartmentID= "" ,Convert.DBNull, Record.C_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.C_ProjectSiteID= "" ,Convert.DBNull, Record.C_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID",SqlDbType.Int,11, Iif(Record.C_DesignationID= "" ,Convert.DBNull, Record.C_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,3, Iif(Record.ActiveState= "" ,Convert.DBNull, Record.ActiveState))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VPN_IP",SqlDbType.NVarChar,16, Iif(Record.VPN_IP= "" ,Convert.DBNull, Record.VPN_IP))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VPN_Password",SqlDbType.NVarChar,51, Iif(Record.VPN_Password= "" ,Convert.DBNull, Record.VPN_Password))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VPN_Expires",SqlDbType.DateTime,21, Iif(Record.VPN_Expires= "" ,Convert.DBNull, Record.VPN_Expires))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID",SqlDbType.NVarChar,9, Iif(Record.LoginID= "" ,Convert.DBNull, Record.LoginID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Contractual",SqlDbType.Bit,3, Record.Contractual)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MD5Password",SqlDbType.NVarChar,51, Iif(Record.MD5Password= "" ,Convert.DBNull, Record.MD5Password))
          Cmd.Parameters.Add("@Return_UserName", SqlDbType.NVarChar, 257)
          Cmd.Parameters("@Return_UserName").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.UserName = Cmd.Parameters("@Return_UserName").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmWebUsers) As SIS.HRM.hrmWebUsers
      Dim _Rec As SIS.HRM.hrmWebUsers = SIS.HRM.hrmWebUsers.GetByID(Record.UserName)
      With _Rec
        .LoweredUserName = Record.LoweredUserName
        .MobileAlias = Record.MobileAlias
        .IsAnonymous = Record.IsAnonymous
        .LastActivityDate = Record.LastActivityDate
        .UserFullName = Record.UserFullName
        .LocationID = Record.LocationID
        .ExtnNo = Record.ExtnNo
        .MobileNo = Record.MobileNo
        .EMailID = Record.EMailID
        .C_DateOfJoining = Record.C_DateOfJoining
        .C_CompanyID = Record.C_CompanyID
        .C_DivisionID = Record.C_DivisionID
        .C_OfficeID = Record.C_OfficeID
        .C_DepartmentID = Record.C_DepartmentID
        .C_ProjectSiteID = Record.C_ProjectSiteID
        .C_DesignationID = Record.C_DesignationID
        .ActiveState = Record.ActiveState
        .VPN_IP = Record.VPN_IP
        .VPN_Password = Record.VPN_Password
        .VPN_Expires = Record.VPN_Expires
        .LoginID = Record.LoginID
        .Contractual = Record.Contractual
        .MD5Password = Record.MD5Password
      End With
      Return SIS.HRM.hrmWebUsers.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.HRM.hrmWebUsers) As SIS.HRM.hrmWebUsers
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmWebUsersUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_UserName",SqlDbType.NVarChar,257, Record.UserName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UserName",SqlDbType.NVarChar,257, Record.UserName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoweredUserName",SqlDbType.NVarChar,257, Record.LoweredUserName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MobileAlias",SqlDbType.NVarChar,17, Iif(Record.MobileAlias= "" ,Convert.DBNull, Record.MobileAlias))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IsAnonymous",SqlDbType.Bit,3, Record.IsAnonymous)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LastActivityDate",SqlDbType.DateTime,21, Record.LastActivityDate)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UserFullName",SqlDbType.NVarChar,51, Record.UserFullName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LocationID",SqlDbType.Int,11, Iif(Record.LocationID= "" ,Convert.DBNull, Record.LocationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ExtnNo",SqlDbType.NVarChar,51, Iif(Record.ExtnNo= "" ,Convert.DBNull, Record.ExtnNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MobileNo",SqlDbType.NVarChar,51, Iif(Record.MobileNo= "" ,Convert.DBNull, Record.MobileNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EMailID",SqlDbType.NVarChar,51, Iif(Record.EMailID= "" ,Convert.DBNull, Record.EMailID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DateOfJoining",SqlDbType.DateTime,21, Iif(Record.C_DateOfJoining= "" ,Convert.DBNull, Record.C_DateOfJoining))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_CompanyID",SqlDbType.NVarChar,7, Iif(Record.C_CompanyID= "" ,Convert.DBNull, Record.C_CompanyID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DivisionID",SqlDbType.NVarChar,7, Iif(Record.C_DivisionID= "" ,Convert.DBNull, Record.C_DivisionID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_OfficeID",SqlDbType.Int,11, Iif(Record.C_OfficeID= "" ,Convert.DBNull, Record.C_OfficeID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DepartmentID",SqlDbType.NVarChar,7, Iif(Record.C_DepartmentID= "" ,Convert.DBNull, Record.C_DepartmentID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_ProjectSiteID",SqlDbType.NVarChar,7, Iif(Record.C_ProjectSiteID= "" ,Convert.DBNull, Record.C_ProjectSiteID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@C_DesignationID",SqlDbType.Int,11, Iif(Record.C_DesignationID= "" ,Convert.DBNull, Record.C_DesignationID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ActiveState",SqlDbType.Bit,3, Iif(Record.ActiveState= "" ,Convert.DBNull, Record.ActiveState))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VPN_IP",SqlDbType.NVarChar,16, Iif(Record.VPN_IP= "" ,Convert.DBNull, Record.VPN_IP))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VPN_Password",SqlDbType.NVarChar,51, Iif(Record.VPN_Password= "" ,Convert.DBNull, Record.VPN_Password))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VPN_Expires",SqlDbType.DateTime,21, Iif(Record.VPN_Expires= "" ,Convert.DBNull, Record.VPN_Expires))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID",SqlDbType.NVarChar,9, Iif(Record.LoginID= "" ,Convert.DBNull, Record.LoginID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Contractual",SqlDbType.Bit,3, Record.Contractual)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MD5Password",SqlDbType.NVarChar,51, Iif(Record.MD5Password= "" ,Convert.DBNull, Record.MD5Password))
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return SIS.HRM.hrmWebUsers.GetByID(Record.UserName)
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)> _
    Public Shared Function Delete(ByVal Record As SIS.HRM.hrmWebUsers, Optional ByVal Cascade As Boolean = False) As Int32
      Dim _Result as Integer = 0
      If Cascade Then
				
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmWebUsersDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_UserName",SqlDbType.NVarChar,Record.UserName.ToString.Length, Record.UserName)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _RecordCount
    End Function
'		Autocomplete Method
		Public Shared Function SelecthrmWebUsersAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
			Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "sphrmWebUsersAutoCompleteList"
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
            Dim Tmp As SIS.HRM.hrmWebUsers = New SIS.HRM.hrmWebUsers(Reader)
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
					End While
					Reader.Close()
				End Using
			End Using
			Return Results.ToArray
		End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _ApplicationId = Ctype(Reader("ApplicationId"),String)
      _UserId = Ctype(Reader("UserId"),String)
      _UserName = Ctype(Reader("UserName"),String)
      _LoweredUserName = Ctype(Reader("LoweredUserName"),String)
      If Convert.IsDBNull(Reader("MobileAlias")) Then
        _MobileAlias = String.Empty
      Else
        _MobileAlias = Ctype(Reader("MobileAlias"), String)
      End If
      _IsAnonymous = Ctype(Reader("IsAnonymous"),Boolean)
      _LastActivityDate = Ctype(Reader("LastActivityDate"),DateTime)
      _UserFullName = Ctype(Reader("UserFullName"),String)
      If Convert.IsDBNull(Reader("LocationID")) Then
        _LocationID = String.Empty
      Else
        _LocationID = Ctype(Reader("LocationID"), String)
      End If
      If Convert.IsDBNull(Reader("ExtnNo")) Then
        _ExtnNo = String.Empty
      Else
        _ExtnNo = Ctype(Reader("ExtnNo"), String)
      End If
      If Convert.IsDBNull(Reader("MobileNo")) Then
        _MobileNo = String.Empty
      Else
        _MobileNo = Ctype(Reader("MobileNo"), String)
      End If
      If Convert.IsDBNull(Reader("EMailID")) Then
        _EMailID = String.Empty
      Else
        _EMailID = Ctype(Reader("EMailID"), String)
      End If
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
      If Convert.IsDBNull(Reader("ActiveState")) Then
        _ActiveState = String.Empty
      Else
        _ActiveState = Ctype(Reader("ActiveState"), String)
      End If
      If Convert.IsDBNull(Reader("VPN_IP")) Then
        _VPN_IP = String.Empty
      Else
        _VPN_IP = Ctype(Reader("VPN_IP"), String)
      End If
      If Convert.IsDBNull(Reader("VPN_Password")) Then
        _VPN_Password = String.Empty
      Else
        _VPN_Password = Ctype(Reader("VPN_Password"), String)
      End If
      If Convert.IsDBNull(Reader("VPN_Expires")) Then
        _VPN_Expires = String.Empty
      Else
        _VPN_Expires = Ctype(Reader("VPN_Expires"), String)
      End If
      If Convert.IsDBNull(Reader("LoginID")) Then
        _LoginID = String.Empty
      Else
        _LoginID = Ctype(Reader("LoginID"), String)
      End If
      _Contractual = Ctype(Reader("Contractual"),Boolean)
      If Convert.IsDBNull(Reader("MD5Password")) Then
        _MD5Password = String.Empty
      Else
        _MD5Password = Ctype(Reader("MD5Password"), String)
      End If
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
