Imports OfficeOpenXml
Imports System.Web.Script.Serialization
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Partial Class GF_UpdateEmployee
  Inherits SIS.SYS.GridBase
  Private st As Long = HttpContext.Current.Server.ScriptTimeout
  Public Property uData As List(Of tmpEmp)
    Get
      If ViewState("uData") IsNot Nothing Then
        Return CType(ViewState("uData"), List(Of tmpEmp))
      Else
        Return New List(Of tmpEmp)
      End If
    End Get
    Set(value As List(Of tmpEmp))
      ViewState.Add("uData", value)
    End Set
  End Property
  Protected Sub TBLDummy_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLdummy.Init
    SetToolBar = TBLdummy
  End Sub
  Private Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
    If Not F_Upload.HasFile Then Exit Sub
    Dim tmpData As New List(Of tmpEmp)
    Dim IsError As Boolean = False
    Dim ErrMsg As New ArrayList
    '1. Read XL File
    HttpContext.Current.Server.ScriptTimeout = Integer.MaxValue
    Try
      Dim tmpPath As String = Server.MapPath("~/../App_Temp")
      Dim tmpName As String = IO.Path.GetRandomFileName()
      Dim tmpFile As String = tmpPath & "\\" & tmpName
      F_Upload.SaveAs(tmpFile)
      Dim fi As FileInfo = New FileInfo(tmpFile)
      Using xlP As ExcelPackage = New ExcelPackage(fi)
        Dim wsD As ExcelWorksheet = Nothing
        Try
          wsD = xlP.Workbook.Worksheets("Data")
        Catch ex As Exception
          wsD = Nothing
        End Try
        If wsD Is Nothing Then
          ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize("Invalid XL Data Sheet Not Found") & "');", True)
          xlP.Dispose()
          HttpContext.Current.Server.ScriptTimeout = st
          Exit Sub
        End If
        'Load Document
        For I As Integer = 2 To 99999
          Dim x As New tmpEmp
          x.CardNo = wsD.Cells(I, 1).Text
          If x.CardNo = "" Then Exit For
          With x
            If Not Employee(x.CardNo) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " Card No Not Found.")
            End If
            x.EmployeeName = wsD.Cells(I, 2).Text
            x.C_CompanyID = wsD.Cells(I, 3).Text
            If Not Company(x.C_CompanyID) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " Company ID Not Found.")
            End If
            x.C_DivisionID = wsD.Cells(I, 4).Text
            If Not Division(x.C_DivisionID) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " Division ID Not Found.")
            End If
            x.C_OfficeID = wsD.Cells(I, 5).Text
            If Not Office(x.C_OfficeID) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " Office ID Not Found.")
            End If
            x.C_DepartmentID = wsD.Cells(I, 6).Text
            If Not Department(x.C_DepartmentID) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " Department ID Not Found.")
            End If
            x.C_DesignationID = wsD.Cells(I, 7).Text
            If Not Designation(x.C_DesignationID) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " Designation ID Not Found.")
            End If
            x.VerificationRequired = wsD.Cells(I, 8).Text
            x.VerifierID = wsD.Cells(I, 9).Text
            If x.VerificationRequired <> "" Then
              If x.VerificationRequired.ToLower = "yes" Then
                x.VerificationRequired = 1
              Else
                x.VerificationRequired = 0
              End If
            End If
            If x.VerificationRequired = "1" Then
              If x.VerifierID = "" Then
                IsError = True
                ErrMsg.Add("Line No." & I & " Verifier ID is Required.")
              Else
                If Not Employee(x.VerifierID) Then
                  IsError = True
                  ErrMsg.Add("Line No." & I & " Verifier ID Not Found.")
                End If
              End If
            Else
              x.VerifierID = ""
            End If
            x.ApprovalRequired = wsD.Cells(I, 10).Text
            x.ApproverID = wsD.Cells(I, 11).Text
            If x.ApprovalRequired <> "" Then
              If x.ApprovalRequired.ToLower = "yes" Then
                x.ApprovalRequired = 1
              Else
                x.ApprovalRequired = 0
              End If
            End If
            If x.ApprovalRequired = "1" Then
              If x.ApproverID = "" Then
                IsError = True
                ErrMsg.Add("Line No." & I & " Approver ID is Required.")
              Else
                If Not Employee(x.ApproverID) Then
                  IsError = True
                  ErrMsg.Add("Line No." & I & " Approver ID Not Found.")
                End If
              End If
            Else
              x.ApproverID = ""
            End If
            x.Contractual = wsD.Cells(I, 12).Text
            If x.Contractual <> "" Then
              If x.Contractual.ToLower = "yes" Then
                x.Contractual = 1
              Else
                x.Contractual = 0
              End If
            End If
            x.CategoryID = wsD.Cells(I, 13).Text
            If Not Category(x.CategoryID) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " TA Category ID Not Found.")
            End If
            x.NonTechnical = wsD.Cells(I, 14).Text
            If x.NonTechnical <> "" Then
              If x.NonTechnical.ToLower = "yes" Then
                x.NonTechnical = 1
              Else
                x.NonTechnical = 0
              End If
            End If
            x.TAVerifier = wsD.Cells(I, 15).Text
            If x.TAVerifier <> "" Then
              If Not Employee(x.TAVerifier) Then
                IsError = True
                ErrMsg.Add("Line No." & I & " TA Verifier ID Not Found.")
              End If
            End If
            x.TAApprover = wsD.Cells(I, 16).Text
            If Not Employee(x.TAApprover) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " TA Approver ID Not Found.")
            End If
            x.TASanctioningAuthority = wsD.Cells(I, 17).Text
            If Not Employee(x.TASanctioningAuthority) Then
              IsError = True
              ErrMsg.Add("Line No." & I & " TA Sanctioning ID Not Found.")
            End If
            x.EMailID = wsD.Cells(I, 18).Text
          End With
          tmpData.Add(x)
        Next
        xlP.Dispose()
      End Using
    Catch ex As Exception
      HttpContext.Current.Server.ScriptTimeout = st
      ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
    End Try
    '2. If Error Show Data
    If IsError Then
      Dim strHTML As String = "<h2>Following erros found in Excel, Pl. rectify and upload again.</h2><br/>"
      strHTML &= "<table class='err'>"
      For Each str As String In ErrMsg
        strHTML &= "<tr><td>" & str & "</td></tr>"
      Next
      strHTML &= "</table>"
      divData.InnerHtml = strHTML
      divData.Visible = True
      divFU.Visible = False
    End If
    '3. If No error then Update
    If Not IsError Then
      ErrMsg = New ArrayList
      For Each x As tmpEmp In tmpData
        If Not UpdateEmployee(x) Then
          ErrMsg.Add("Card No.: " & x.CardNo & " not updated.")
        End If
      Next
      Dim strHTML As String = "<h2>Total Records: " & tmpData.Count & "Record Processed</h2><br/>"
      strHTML &= "<table class='err'>"
      For Each str As String In ErrMsg
        strHTML &= "<tr><td>" & str & "</td></tr>"
      Next
      strHTML &= "</table>"
      divData.InnerHtml = strHTML
      divData.Visible = True
      divFU.Visible = False
    End If
    HttpContext.Current.Server.ScriptTimeout = st
  End Sub
  Private Function UpdateEmployee(x As tmpEmp) As Boolean
    Try
      Dim emp As SIS.HRM.newHrmEmployees = SIS.HRM.newHrmEmployees.newHrmEmployeesGetByID(x.CardNo)
      If x.EmployeeName <> "" Then
        emp.EmployeeName = x.EmployeeName
      End If
      If x.C_CompanyID <> "" Then
        emp.C_CompanyID = x.C_CompanyID
      End If
      If x.C_DivisionID <> "" Then
        emp.C_DivisionID = x.C_DivisionID
      End If
      If x.C_OfficeID <> "" Then
        emp.C_OfficeID = x.C_OfficeID
      End If
      If x.C_DepartmentID <> "" Then
        emp.C_DepartmentID = x.C_DepartmentID
      End If
      If x.C_DesignationID <> "" Then
        emp.C_DesignationID = x.C_DesignationID
      End If
      If x.VerificationRequired <> "" Then
        If x.VerificationRequired = "1" Then
          emp.VerificationRequired = True
        Else
          emp.VerificationRequired = False
        End If
      End If
      If x.VerificationRequired = "1" Then
        emp.VerifierID = x.VerifierID
      End If
      If x.ApprovalRequired <> "" Then
        If x.ApprovalRequired = "1" Then
          emp.ApprovalRequired = True
        Else
          emp.ApprovalRequired = False
        End If
      End If
      If x.ApprovalRequired = "1" Then
        emp.ApproverID = x.ApproverID
      End If
      If x.Contractual <> "" Then
        If x.Contractual = "1" Then
          emp.Contractual = True
        Else
          emp.Contractual = False
        End If
      End If
      If x.CategoryID <> "" Then
        emp.CategoryID = x.CategoryID
      End If
      If x.NonTechnical <> "" Then
        If x.NonTechnical = "1" Then
          emp.NonTechnical = True
        Else
          emp.NonTechnical = False
        End If
      End If
      If x.TAVerifier <> "" Then
        emp.TAVerifier = x.TAVerifier
      End If
      If x.TAApprover <> "" Then
        emp.TAApprover = x.TAApprover
      End If
      If x.TASanctioningAuthority <> "" Then
        emp.TASanctioningAuthority = x.TASanctioningAuthority
      End If
      If x.EMailID <> "" Then
        emp.EMailID = x.EMailID
      End If
      SIS.HRM.newHrmEmployees.UpdateData(emp)
      Return True
    Catch ex As Exception
      Return False
    End Try
  End Function

  Private Function Category(value As String) As Boolean
    If value = "" Then Return True
    Dim mret As Integer = 0
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select isnull(count(*),0) as cnt from TA_Categories where CategoryID=" & value & ""
        Con.Open()
        mret = Cmd.ExecuteScalar
      End Using
    End Using
    Return (mret > 0)
  End Function
  Private Function Employee(value As String) As Boolean
    Dim mret As Integer = 0
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select isnull(count(*),0) as cnt from HRM_Employees where CardNo='" & value & "'"
        Con.Open()
        mret = Cmd.ExecuteScalar
      End Using
    End Using
    Return (mret > 0)
  End Function
  Private Function Designation(value As String) As Boolean
    If value = "" Then Return True
    Dim mret As Integer = 0
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select isnull(count(*),0) as cnt from HRM_Designations where DesignationID=" & value & ""
        Con.Open()
        mret = Cmd.ExecuteScalar
      End Using
    End Using
    Return (mret > 0)
  End Function
  Private Function Department(value As String) As Boolean
    If value = "" Then Return True
    Dim mret As Integer = 0
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select isnull(count(*),0) as cnt from HRM_Departments where DepartmentID='" & value & "'"
        Con.Open()
        mret = Cmd.ExecuteScalar
      End Using
    End Using
    Return (mret > 0)
  End Function
  Private Function Office(value As String) As Boolean
    If value = "" Then Return True
    Dim mret As Integer = 0
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select isnull(count(*),0) as cnt from HRM_Offices where OfficeID=" & value & ""
        Con.Open()
        mret = Cmd.ExecuteScalar
      End Using
    End Using
    Return (mret > 0)
  End Function
  Private Function Division(value As String) As Boolean
    If value = "" Then Return True
    Dim mret As Integer = 0
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select isnull(count(*),0) as cnt from HRM_Divisions where DivisionID='" & value & "'"
        Con.Open()
        mret = Cmd.ExecuteScalar
      End Using
    End Using
    Return (mret > 0)
  End Function
  Private Function Company(value As String) As Boolean
    If value = "" Then Return True
    Dim mret As Integer = 0
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "select isnull(count(*),0) as cnt from HRM_Companies where CompanyID='" & value & "'"
        Con.Open()
        mret = Cmd.ExecuteScalar
      End Using
    End Using
    Return (mret > 0)
  End Function

  Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
    Dim TemplateName As String = "EmpUpd_Template.xlsx"

    Dim tmpFile As String = Server.MapPath("~/App_Templates/" & TemplateName)
    If IO.File.Exists(tmpFile) Then
      Dim FileName As String = Server.MapPath("~/..") & "App_Temp/" & Guid.NewGuid().ToString()
      IO.File.Copy(tmpFile, FileName)
      Dim FileInfo As IO.FileInfo = New IO.FileInfo(FileName)
      Dim xlPk As ExcelPackage = New ExcelPackage(FileInfo)

      '1.
      Dim xlWS As ExcelWorksheet = xlPk.Workbook.Worksheets("Data")
      Dim r As Integer = 1
      Dim c As Integer = 1
      Dim cnt As Integer = 1


      '1. Write Master Data Units & Package Type
      '1.a Units
      Dim Emps As List(Of tmpEmp) = tmpEmp.GetList
      r = 2
      c = 1
      For Each x As tmpEmp In Emps
        With xlWS
          c = 1
          .Cells(r, c).Value = x.CardNo
          c += 1
          .Cells(r, c).Value = x.EmployeeName
          c += 1
          .Cells(r, c).Value = x.C_CompanyID
          c += 1
          .Cells(r, c).Value = x.C_DivisionID
          c += 1
          .Cells(r, c).Value = x.C_OfficeID
          c += 1
          .Cells(r, c).Value = x.C_DepartmentID
          c += 1
          .Cells(r, c).Value = x.C_DesignationID
          c += 1
          .Cells(r, c).Value = IIf(Convert.ToBoolean(x.VerificationRequired) = True, "YES", "NO")
          c += 1
          .Cells(r, c).Value = x.VerifierID
          c += 1
          .Cells(r, c).Value = IIf(Convert.ToBoolean(x.ApprovalRequired) = True, "YES", "NO")
          c += 1
          .Cells(r, c).Value = x.ApproverID
          c += 1
          .Cells(r, c).Value = IIf(Convert.ToBoolean(x.Contractual) = True, "YES", "NO")
          c += 1
          .Cells(r, c).Value = x.CategoryID
          c += 1
          .Cells(r, c).Value = IIf(Convert.ToBoolean(x.NonTechnical) = True, "YES", "NO")
          c += 1
          .Cells(r, c).Value = x.TAVerifier
          c += 1
          .Cells(r, c).Value = x.TAApprover
          c += 1
          .Cells(r, c).Value = x.TASanctioningAuthority
          c += 1
          .Cells(r, c).Value = x.EMailID
          c += 1
          r += 1
        End With
      Next

      xlPk.Save()
      xlPk.Dispose()

      Response.Clear()
      Response.AppendHeader("content-disposition", "attachment; filename=EmpList.xlsx")
      Response.ContentType = SIS.SYS.Utilities.ApplicationSpacific.ContentType(TemplateName)
      Response.WriteFile(FileName)
      HttpContext.Current.Server.ScriptTimeout = st
      Response.End()
    End If

  End Sub

  Public Class tmpEmp
    Public Property CardNo As String = ""
    Public Property EmployeeName As String = ""
    Public Property C_CompanyID As String = ""
    Public Property C_DivisionID As String = ""
    Public Property C_OfficeID As String = ""
    Public Property C_DepartmentID As String = ""
    Public Property C_DesignationID As String = ""
    Public Property VerificationRequired As String = ""
    Public Property VerifierID As String = ""
    Public Property ApprovalRequired As String = ""
    Public Property ApproverID As String = ""
    Public Property Contractual As String = ""
    Public Property CategoryID As String = ""
    Public Property NonTechnical As String = ""
    Public Property TAVerifier As String = ""
    Public Property TAApprover As String = ""
    Public Property TASanctioningAuthority As String = ""
    Public Property EMailID As String = ""

    Public Shared Function GetList() As List(Of tmpEmp)
      Dim mret As New List(Of tmpEmp)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "select * from HRM_Employees where activestate=1"
          Con.Open()
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            mret.Add(New tmpEmp(rd))
          End While
        End Using
      End Using
      Return mret
    End Function

    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              Dim Found As Boolean = False
              For I As Integer = 0 To Reader.FieldCount - 1
                If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                  Found = True
                  Exit For
                End If
              Next
              If Found Then
                If Convert.IsDBNull(Reader(pi.Name)) Then
                  Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                    Case "decimal"
                      CallByName(Me, pi.Name, CallType.Let, "0.00")
                    Case "bit"
                      CallByName(Me, pi.Name, CallType.Let, Boolean.FalseString)
                    Case Else
                      CallByName(Me, pi.Name, CallType.Let, String.Empty)
                  End Select
                Else
                  CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
                End If
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub
    Public Sub New()
    End Sub

  End Class
End Class
