Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.IDM
  <DataObject()> _
  Partial Public Class idmResponsibleAgency
    Private Shared _RecordCount As Integer
    Private _ResponsibleAgencyID As Int32 = 0
    Private _Description As String = ""
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
    Public Property ResponsibleAgencyID() As Int32
      Get
        Return _ResponsibleAgencyID
      End Get
      Set(ByVal value As Int32)
        _ResponsibleAgencyID = value
      End Set
    End Property
    Public Property Description() As String
      Get
        Return _Description
      End Get
      Set(ByVal value As String)
        _Description = value
      End Set
    End Property
    Public Property DisplayField() As String
      Get
        Return "" & _Description.ToString.PadRight(50, " ")
      End Get
      Set(ByVal value As String)
      End Set
    End Property
    Public Property PrimaryKey() As String
      Get
        Return _ResponsibleAgencyID
      End Get
      Set(ByVal value As String)
      End Set
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal orderBy As String) As List(Of SIS.IDM.idmResponsibleAgency)
      Dim Results As List(Of SIS.IDM.idmResponsibleAgency) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmResponsibleAgencySelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.IDM.idmResponsibleAgency)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.IDM.idmResponsibleAgency(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetNewRecord() As SIS.IDM.idmResponsibleAgency
      Return New SIS.IDM.idmResponsibleAgency()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByID(ByVal ResponsibleAgencyID As Int32) As SIS.IDM.idmResponsibleAgency
      Dim Results As SIS.IDM.idmResponsibleAgency = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmResponsibleAgencySelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ResponsibleAgencyID",SqlDbType.Int,ResponsibleAgencyID.ToString.Length, ResponsibleAgencyID)
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.IDM.idmResponsibleAgency(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function SelectList(ByVal startRowIndex As Integer, ByVal maximumRows As Integer, ByVal orderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.IDM.idmResponsibleAgency)
      Dim Results As List(Of SIS.IDM.idmResponsibleAgency) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spidmResponsibleAgencySelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spidmResponsibleAgencySelectListFilteres"
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@startRowIndex", SqlDbType.Int, -1, startRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@maximumRows", SqlDbType.Int, -1, maximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, orderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.IDM.idmResponsibleAgency)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.IDM.idmResponsibleAgency(Reader))
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
    Public Shared Function Insert(ByVal Record As SIS.IDM.idmResponsibleAgency) As Int32
      Dim _Rec As SIS.IDM.idmResponsibleAgency = SIS.IDM.idmResponsibleAgency.GetNewRecord()
      With _Rec
        .Description = Record.Description
      End With
      Return SIS.IDM.idmResponsibleAgency.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.IDM.idmResponsibleAgency) As Int32
      Dim _Result As Int32 = Record.ResponsibleAgencyID
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmResponsibleAgencyInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description",SqlDbType.NVarChar,51, Record.Description)
          Cmd.Parameters.Add("@Return_ResponsibleAgencyID", SqlDbType.Int, 10)
          Cmd.Parameters("@Return_ResponsibleAgencyID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@Return_ResponsibleAgencyID").Value
        End Using
      End Using
      Return _Result
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function Update(ByVal Record As SIS.IDM.idmResponsibleAgency) As Int32
      Dim _Rec As SIS.IDM.idmResponsibleAgency = SIS.IDM.idmResponsibleAgency.GetByID(Record.ResponsibleAgencyID)
      With _Rec
        .Description = Record.Description
      End With
      Return SIS.IDM.idmResponsibleAgency.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.IDM.idmResponsibleAgency) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmResponsibleAgencyUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ResponsibleAgencyID",SqlDbType.Int,11, Record.ResponsibleAgencyID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description",SqlDbType.NVarChar,51, Record.Description)
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
    Public Shared Function Delete(ByVal Record As SIS.IDM.idmResponsibleAgency, Optional ByVal Cascade As Boolean = False) As Int32
      Dim _Result as Integer = 0
      If Cascade Then
				
      End If
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spidmResponsibleAgencyDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ResponsibleAgencyID",SqlDbType.Int,Record.ResponsibleAgencyID.ToString.Length, Record.ResponsibleAgencyID)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _Result
    End Function
'		Autocomplete Method
		Public Shared Function SelectidmResponsibleAgencyAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
			Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spidmResponsibleAgencyAutoCompleteList"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix), 0, 1))
					Results = New List(Of String)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Not Reader.HasRows Then
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(50, " "),""))
					End If
					While (Reader.Read())
            Dim Tmp As SIS.IDM.idmResponsibleAgency = New SIS.IDM.idmResponsibleAgency(Reader)
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
					End While
					Reader.Close()
				End Using
			End Using
			Return Results.ToArray
		End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _ResponsibleAgencyID = Ctype(Reader("ResponsibleAgencyID"),Int32)
      _Description = Ctype(Reader("Description"),String)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
