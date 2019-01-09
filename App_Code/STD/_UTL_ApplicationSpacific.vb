Imports System.Data
Imports System.Data.SqlClient
Namespace SIS.SYS.Utilities
	Public Class ApplicationSpacific
		Public Shared Sub Initialize()
			With HttpContext.Current
				.Session("ApplicationID") = 6
				.Session("ApplicationDefaultPage") = "~/Default.aspx"
			End With
		End Sub
		Public Shared Sub ApplicationReports(ByVal Context As HttpContext)

			If Not Context.Request.QueryString("ReportName") Is Nothing Then
				Select Case (Context.Request.QueryString("ReportName").ToLower)
					Case "serveyanalysis"
            'Dim oRep As RPT_hrmServeyAnalysis = New RPT_hrmServeyAnalysis(Context)
            'oRep.GenerateReport()
        End Select
			End If

		End Sub
    Public Shared Function ContentType(ByVal FileName As String) As String
      Dim mRet As String = "application/octet-stream"
      Dim Extn As String = IO.Path.GetExtension(FileName).ToLower.Replace(".", "")
      Select Case Extn
        Case "pdf", "rtf"
          mRet = "application/" & Extn
        Case "doc", "docx"
          mRet = "application/vnd.ms-works"
        Case "xls", "xlsx"
          mRet = "application/vnd.ms-excel"
        Case "gif", "jpg", "jpeg", "png", "tif", "bmp"
          mRet = "image/" & Extn
        Case "pot", "ppt", "pps", "pptx", "ppsx"
          mRet = "application/vnd.ms-powerpoint"
        Case "htm", "html"
          mRet = "text/HTML"
        Case "txt"
          mRet = "text/plain"
        Case "zip"
          mRet = "application/zip"
        Case "rar", "tar", "tgz"
          mRet = "application/x-compressed"
        Case Else
          mRet = "application/octet-stream"
      End Select
      Return mRet
    End Function
  End Class
End Namespace
