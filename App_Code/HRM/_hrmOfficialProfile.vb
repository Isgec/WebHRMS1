Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.HRM
  <DataObject()> _
  Partial Public Class hrmOfficialProfile
    Private Shared _RecordCount As Integer
    Private _CardNo As String
    Private _EmployeeName As String
    Private _WorkingAreaID As String
    Private _FunctionalStatusID1 As String
    Private _FunctionalStatusID2 As String
    Private _FunctionalStatusID3 As String
    Private _FunctionalStatusID4 As String
    Private _CareerStartedOn As String
    Private _EducationDetails As String
    Private _QualificationID1 As String
    Private _QualificationYear1 As String
    Private _QualificationID2 As String
    Private _QualificationYear2 As String
    Private _IncrementCompany As String
    Private _WorkingAreaIDHRM_WorkingAreas As SIS.HRM.hrmWorkingAreas
    Private _FunctionalStatusID1HRM_FunctionalStatus1 As SIS.HRM.hrmFunctionalStatus1
    Private _FunctionalStatusID2HRM_FunctionalStatus2 As SIS.HRM.hrmFunctionalStatus2
    Private _FunctionalStatusID3HRM_FunctionalStatus3 As SIS.HRM.hrmFunctionalStatus3
    Private _FunctionalStatusID4HRM_FunctionalStatus4 As SIS.HRM.hrmFunctionalStatus4
    Private _QualificationID1HRM_Qualifications As SIS.HRM.hrmQualifications
    Private _QualificationID2HRM_Qualifications As SIS.HRM.hrmQualifications
    Private _IncrementCompanyHRM_Companies As SIS.HRM.hrmCompanies
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
    Public Property WorkingAreaID() As String
      Get
        Return _WorkingAreaID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _WorkingAreaID = ""
				 Else
					 _WorkingAreaID = value
			   End If
      End Set
    End Property
    Public Property FunctionalStatusID1() As String
      Get
        Return _FunctionalStatusID1
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FunctionalStatusID1 = ""
				 Else
					 _FunctionalStatusID1 = value
			   End If
      End Set
    End Property
    Public Property FunctionalStatusID2() As String
      Get
        Return _FunctionalStatusID2
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FunctionalStatusID2 = ""
				 Else
					 _FunctionalStatusID2 = value
			   End If
      End Set
    End Property
    Public Property FunctionalStatusID3() As String
      Get
        Return _FunctionalStatusID3
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FunctionalStatusID3 = ""
				 Else
					 _FunctionalStatusID3 = value
			   End If
      End Set
    End Property
    Public Property FunctionalStatusID4() As String
      Get
        Return _FunctionalStatusID4
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FunctionalStatusID4 = ""
				 Else
					 _FunctionalStatusID4 = value
			   End If
      End Set
    End Property
    Public Property CareerStartedOn() As String
      Get
        If Not _CareerStartedOn = String.Empty Then
          Return Convert.ToDateTime(_CareerStartedOn).ToString("dd/MM/yyyy")
        End If
        Return _CareerStartedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _CareerStartedOn = ""
				 Else
					 _CareerStartedOn = value
			   End If
      End Set
    End Property
    Public Property EducationDetails() As String
      Get
        Return _EducationDetails
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _EducationDetails = ""
				 Else
					 _EducationDetails = value
			   End If
      End Set
    End Property
    Public Property QualificationID1() As String
      Get
        Return _QualificationID1
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _QualificationID1 = ""
				 Else
					 _QualificationID1 = value
			   End If
      End Set
    End Property
    Public Property QualificationYear1() As String
      Get
        Return _QualificationYear1
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _QualificationYear1 = ""
				 Else
					 _QualificationYear1 = value
			   End If
      End Set
    End Property
    Public Property QualificationID2() As String
      Get
        Return _QualificationID2
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _QualificationID2 = ""
				 Else
					 _QualificationID2 = value
			   End If
      End Set
    End Property
    Public Property QualificationYear2() As String
      Get
        Return _QualificationYear2
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _QualificationYear2 = ""
				 Else
					 _QualificationYear2 = value
			   End If
      End Set
    End Property
    Public Property IncrementCompany() As String
      Get
        Return _IncrementCompany
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _IncrementCompany = ""
				 Else
					 _IncrementCompany = value
			   End If
      End Set
    End Property
    Public ReadOnly Property WorkingAreaIDHRM_WorkingAreas() As SIS.HRM.hrmWorkingAreas
      Get
        If _WorkingAreaIDHRM_WorkingAreas Is Nothing Then
          _WorkingAreaIDHRM_WorkingAreas = SIS.HRM.hrmWorkingAreas.GetByID(_WorkingAreaID)
        End If
        Return _WorkingAreaIDHRM_WorkingAreas
      End Get
    End Property
    Public ReadOnly Property FunctionalStatusID1HRM_FunctionalStatus1() As SIS.HRM.hrmFunctionalStatus1
      Get
        If _FunctionalStatusID1HRM_FunctionalStatus1 Is Nothing Then
          _FunctionalStatusID1HRM_FunctionalStatus1 = SIS.HRM.hrmFunctionalStatus1.GetByID(_FunctionalStatusID1)
        End If
        Return _FunctionalStatusID1HRM_FunctionalStatus1
      End Get
    End Property
    Public ReadOnly Property FunctionalStatusID2HRM_FunctionalStatus2() As SIS.HRM.hrmFunctionalStatus2
      Get
        If _FunctionalStatusID2HRM_FunctionalStatus2 Is Nothing Then
          _FunctionalStatusID2HRM_FunctionalStatus2 = SIS.HRM.hrmFunctionalStatus2.GetByID(_FunctionalStatusID2)
        End If
        Return _FunctionalStatusID2HRM_FunctionalStatus2
      End Get
    End Property
    Public ReadOnly Property FunctionalStatusID3HRM_FunctionalStatus3() As SIS.HRM.hrmFunctionalStatus3
      Get
        If _FunctionalStatusID3HRM_FunctionalStatus3 Is Nothing Then
          _FunctionalStatusID3HRM_FunctionalStatus3 = SIS.HRM.hrmFunctionalStatus3.GetByID(_FunctionalStatusID3)
        End If
        Return _FunctionalStatusID3HRM_FunctionalStatus3
      End Get
    End Property
    Public ReadOnly Property FunctionalStatusID4HRM_FunctionalStatus4() As SIS.HRM.hrmFunctionalStatus4
      Get
        If _FunctionalStatusID4HRM_FunctionalStatus4 Is Nothing Then
          _FunctionalStatusID4HRM_FunctionalStatus4 = SIS.HRM.hrmFunctionalStatus4.GetByID(_FunctionalStatusID4)
        End If
        Return _FunctionalStatusID4HRM_FunctionalStatus4
      End Get
    End Property
    Public ReadOnly Property QualificationID1HRM_Qualifications() As SIS.HRM.hrmQualifications
      Get
        If _QualificationID1HRM_Qualifications Is Nothing Then
          _QualificationID1HRM_Qualifications = SIS.HRM.hrmQualifications.GetByID(_QualificationID1)
        End If
        Return _QualificationID1HRM_Qualifications
      End Get
    End Property
    Public ReadOnly Property QualificationID2HRM_Qualifications() As SIS.HRM.hrmQualifications
      Get
        If _QualificationID2HRM_Qualifications Is Nothing Then
          _QualificationID2HRM_Qualifications = SIS.HRM.hrmQualifications.GetByID(_QualificationID2)
        End If
        Return _QualificationID2HRM_Qualifications
      End Get
    End Property
    Public ReadOnly Property IncrementCompanyHRM_Companies() As SIS.HRM.hrmCompanies
      Get
        If _IncrementCompanyHRM_Companies Is Nothing Then
          _IncrementCompanyHRM_Companies = SIS.HRM.hrmCompanies.GetByID(_IncrementCompany)
        End If
        Return _IncrementCompanyHRM_Companies
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal CardNo As String) As SIS.HRM.hrmOfficialProfile
      Dim Results As SIS.HRM.hrmOfficialProfile = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmOfficialProfileSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo",SqlDbType.NVarChar,CardNo.ToString.Length, CardNo)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.HRM.hrmOfficialProfile(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.HRM.hrmOfficialProfile)
      Dim Results As List(Of SIS.HRM.hrmOfficialProfile) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "sphrmOfficialProfileSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "sphrmOfficialProfileSelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.HRM.hrmOfficialProfile)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.HRM.hrmOfficialProfile(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.HRM.hrmOfficialProfile) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sphrmOfficialProfileUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo",SqlDbType.NVarChar,9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@WorkingAreaID",SqlDbType.Int,11, Iif(Record.WorkingAreaID= "" ,Convert.DBNull, Record.WorkingAreaID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID1",SqlDbType.Int,11, Iif(Record.FunctionalStatusID1= "" ,Convert.DBNull, Record.FunctionalStatusID1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID2",SqlDbType.Int,11, Iif(Record.FunctionalStatusID2= "" ,Convert.DBNull, Record.FunctionalStatusID2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID3",SqlDbType.Int,11, Iif(Record.FunctionalStatusID3= "" ,Convert.DBNull, Record.FunctionalStatusID3))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FunctionalStatusID4",SqlDbType.Int,11, Iif(Record.FunctionalStatusID4= "" ,Convert.DBNull, Record.FunctionalStatusID4))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CareerStartedOn",SqlDbType.DateTime,21, Iif(Record.CareerStartedOn= "" ,Convert.DBNull, Record.CareerStartedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EducationDetails",SqlDbType.NVarChar,251, Iif(Record.EducationDetails= "" ,Convert.DBNull, Record.EducationDetails))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID1",SqlDbType.Int,11, Iif(Record.QualificationID1= "" ,Convert.DBNull, Record.QualificationID1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear1",SqlDbType.NVarChar,5, Iif(Record.QualificationYear1= "" ,Convert.DBNull, Record.QualificationYear1))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationID2",SqlDbType.Int,11, Iif(Record.QualificationID2= "" ,Convert.DBNull, Record.QualificationID2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@QualificationYear2",SqlDbType.NVarChar,5, Iif(Record.QualificationYear2= "" ,Convert.DBNull, Record.QualificationYear2))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IncrementCompany",SqlDbType.NVarChar,7, Iif(Record.IncrementCompany= "" ,Convert.DBNull, Record.IncrementCompany))
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
      If Convert.IsDBNull(Reader("WorkingAreaID")) Then
        _WorkingAreaID = String.Empty
      Else
        _WorkingAreaID = Ctype(Reader("WorkingAreaID"), String)
      End If
      If Convert.IsDBNull(Reader("FunctionalStatusID1")) Then
        _FunctionalStatusID1 = String.Empty
      Else
        _FunctionalStatusID1 = Ctype(Reader("FunctionalStatusID1"), String)
      End If
      If Convert.IsDBNull(Reader("FunctionalStatusID2")) Then
        _FunctionalStatusID2 = String.Empty
      Else
        _FunctionalStatusID2 = Ctype(Reader("FunctionalStatusID2"), String)
      End If
      If Convert.IsDBNull(Reader("FunctionalStatusID3")) Then
        _FunctionalStatusID3 = String.Empty
      Else
        _FunctionalStatusID3 = Ctype(Reader("FunctionalStatusID3"), String)
      End If
      If Convert.IsDBNull(Reader("FunctionalStatusID4")) Then
        _FunctionalStatusID4 = String.Empty
      Else
        _FunctionalStatusID4 = Ctype(Reader("FunctionalStatusID4"), String)
      End If
      If Convert.IsDBNull(Reader("CareerStartedOn")) Then
        _CareerStartedOn = String.Empty
      Else
        _CareerStartedOn = Ctype(Reader("CareerStartedOn"), String)
      End If
      If Convert.IsDBNull(Reader("EducationDetails")) Then
        _EducationDetails = String.Empty
      Else
        _EducationDetails = Ctype(Reader("EducationDetails"), String)
      End If
      If Convert.IsDBNull(Reader("QualificationID1")) Then
        _QualificationID1 = String.Empty
      Else
        _QualificationID1 = Ctype(Reader("QualificationID1"), String)
      End If
      If Convert.IsDBNull(Reader("QualificationYear1")) Then
        _QualificationYear1 = String.Empty
      Else
        _QualificationYear1 = Ctype(Reader("QualificationYear1"), String)
      End If
      If Convert.IsDBNull(Reader("QualificationID2")) Then
        _QualificationID2 = String.Empty
      Else
        _QualificationID2 = Ctype(Reader("QualificationID2"), String)
      End If
      If Convert.IsDBNull(Reader("QualificationYear2")) Then
        _QualificationYear2 = String.Empty
      Else
        _QualificationYear2 = Ctype(Reader("QualificationYear2"), String)
      End If
      If Convert.IsDBNull(Reader("IncrementCompany")) Then
        _IncrementCompany = String.Empty
      Else
        _IncrementCompany = Ctype(Reader("IncrementCompany"), String)
      End If
      _WorkingAreaIDHRM_WorkingAreas = New SIS.HRM.hrmWorkingAreas("HRM_WorkingAreas1",Reader)
      _FunctionalStatusID1HRM_FunctionalStatus1 = New SIS.HRM.hrmFunctionalStatus1("HRM_FunctionalStatus12",Reader)
      _FunctionalStatusID2HRM_FunctionalStatus2 = New SIS.HRM.hrmFunctionalStatus2("HRM_FunctionalStatus23",Reader)
      _FunctionalStatusID3HRM_FunctionalStatus3 = New SIS.HRM.hrmFunctionalStatus3("HRM_FunctionalStatus34",Reader)
      _FunctionalStatusID4HRM_FunctionalStatus4 = New SIS.HRM.hrmFunctionalStatus4("HRM_FunctionalStatus45",Reader)
      _QualificationID1HRM_Qualifications = New SIS.HRM.hrmQualifications("HRM_Qualifications6",Reader)
      _QualificationID2HRM_Qualifications = New SIS.HRM.hrmQualifications("HRM_Qualifications7",Reader)
      _IncrementCompanyHRM_Companies = New SIS.HRM.hrmCompanies("HRM_Companies8",Reader)
    End Sub
    Public Sub New(ByVal AliasName As String, ByVal Reader As SqlDataReader)
      On Error Resume Next
      _CardNo = Ctype(Reader(AliasName & "_CardNo"),String)
      _EmployeeName = Ctype(Reader(AliasName & "_EmployeeName"),String)
      If Convert.IsDBNull(Reader(AliasName & "_WorkingAreaID")) Then
        _WorkingAreaID = String.Empty
      Else
        _WorkingAreaID = Ctype(Reader(AliasName & "_WorkingAreaID"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FunctionalStatusID1")) Then
        _FunctionalStatusID1 = String.Empty
      Else
        _FunctionalStatusID1 = Ctype(Reader(AliasName & "_FunctionalStatusID1"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FunctionalStatusID2")) Then
        _FunctionalStatusID2 = String.Empty
      Else
        _FunctionalStatusID2 = Ctype(Reader(AliasName & "_FunctionalStatusID2"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FunctionalStatusID3")) Then
        _FunctionalStatusID3 = String.Empty
      Else
        _FunctionalStatusID3 = Ctype(Reader(AliasName & "_FunctionalStatusID3"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_FunctionalStatusID4")) Then
        _FunctionalStatusID4 = String.Empty
      Else
        _FunctionalStatusID4 = Ctype(Reader(AliasName & "_FunctionalStatusID4"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_CareerStartedOn")) Then
        _CareerStartedOn = String.Empty
      Else
        _CareerStartedOn = Ctype(Reader(AliasName & "_CareerStartedOn"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_EducationDetails")) Then
        _EducationDetails = String.Empty
      Else
        _EducationDetails = Ctype(Reader(AliasName & "_EducationDetails"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_QualificationID1")) Then
        _QualificationID1 = String.Empty
      Else
        _QualificationID1 = Ctype(Reader(AliasName & "_QualificationID1"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_QualificationYear1")) Then
        _QualificationYear1 = String.Empty
      Else
        _QualificationYear1 = Ctype(Reader(AliasName & "_QualificationYear1"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_QualificationID2")) Then
        _QualificationID2 = String.Empty
      Else
        _QualificationID2 = Ctype(Reader(AliasName & "_QualificationID2"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_QualificationYear2")) Then
        _QualificationYear2 = String.Empty
      Else
        _QualificationYear2 = Ctype(Reader(AliasName & "_QualificationYear2"), String)
      End If
      If Convert.IsDBNull(Reader(AliasName & "_IncrementCompany")) Then
        _IncrementCompany = String.Empty
      Else
        _IncrementCompany = Ctype(Reader(AliasName & "_IncrementCompany"), String)
      End If
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
