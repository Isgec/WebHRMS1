Partial Class EF_hrmNEmployees
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVhrmNEmployees_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVhrmNEmployees.Init
    DataClassName = "EhrmNEmployees"
    SetFormView = FVhrmNEmployees
  End Sub
  Protected Sub TBLhrmNEmployees_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLhrmNEmployees.Init
    SetToolBar = TBLhrmNEmployees
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function C_ProjectSiteIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.IDM.idmProjects.SelectidmProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub FVhrmNEmployees_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVhrmNEmployees.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_hrmNEmployees = {"
    Dim oF_C_ProjectSiteID_Display As Label  = FVhrmNEmployees.FindControl("F_C_ProjectSiteID_Display")
    Dim oF_C_ProjectSiteID As TextBox  = FVhrmNEmployees.FindControl("F_C_ProjectSiteID")
		mStr = mStr & vbCrLf &	"ACEC_ProjectSiteID_Selected: function(sender, e) {"
		mStr = mStr & vbCrLf &	"  var F_C_ProjectSiteID = $get('" & oF_C_ProjectSiteID.ClientID & "');"
		mStr = mStr & vbCrLf &	"  var F_C_ProjectSiteID_Display = $get('" & oF_C_ProjectSiteID_Display.ClientID & "');"
		mStr = mStr & vbCrLf & "  var retval = e.get_value();"
		mStr = mStr & vbCrLf &	"  var p = retval.split('|');"
		mStr = mStr & vbCrLf & "  F_C_ProjectSiteID.value = p[0];"
		mStr = mStr & vbCrLf & "  F_C_ProjectSiteID_Display.innerHTML = e.get_text();"
		mStr = mStr & vbCrLf & "},"
		mStr = mStr & vbCrLf & "ACEC_ProjectSiteID_Populating: function(o,e) {"
		mStr = mStr & vbCrLf & "  var p = o.get_element();"
		mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'url(../../images/loader.gif)';"
		mStr = mStr & vbCrLf & "  p.style.backgroundRepeat= 'no-repeat';"
		mStr = mStr & vbCrLf & "  p.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf & "  o._contextKey = '';"
		mStr = mStr & vbCrLf & 	"},"
		mStr = mStr & vbCrLf & 	"ACEC_ProjectSiteID_Populated: function(o,e) {"
		mStr = mStr & vbCrLf & 	"  var p = o.get_element();"
		mStr = mStr & vbCrLf & 	"  p.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf & 	"},"
		mStr = mStr & vbCrLf & 	"validate_C_ProjectSiteID: function(o) {"
		mStr = mStr & vbCrLf & 	"  this.validated_FK_HRM_C_ProjectSiteID_main = true;"
		mStr = mStr & vbCrLf & 	"  this.validate_FK_HRM_C_ProjectSiteID(o);"
		mStr = mStr & vbCrLf & 	"  },"
		Dim FK_HRM_C_ProjectSiteIDC_ProjectSiteID As TextBox = FVhrmNEmployees.FindControl("F_C_ProjectSiteID")
		mStr = mStr & vbCrLf & 	"validate_FK_HRM_C_ProjectSiteID: function(o) {"
		mStr = mStr & vbCrLf & 	"  var value = o.id;"
		mStr = mStr & vbCrLf & 	"  var C_ProjectSiteID = $get('" & FK_HRM_C_ProjectSiteIDC_ProjectSiteID.ClientID & "');"
		mStr = mStr & vbCrLf & 	"  if(C_ProjectSiteID.value==''){"
		mStr = mStr & vbCrLf & 	"    if(this.validated_FK_HRM_C_ProjectSiteID_main){"
		mStr = mStr & vbCrLf &	"      var o_d = $get(o.id +'_Display');"
		mStr = mStr & vbCrLf &	"      try{o_d.innerHTML = '';}catch(ex){}"
		mStr = mStr & vbCrLf &	"    }"
		mStr = mStr & vbCrLf &	"    return true;"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  value = value + ',' + C_ProjectSiteID.value ;"
		mStr = mStr & vbCrLf &	"    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
		mStr = mStr & vbCrLf &	"    o.style.backgroundRepeat= 'no-repeat';"
		mStr = mStr & vbCrLf &	"    o.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"    PageMethods.validate_FK_HRM_C_ProjectSiteID(value, this.validated_FK_HRM_C_ProjectSiteID);"
		mStr = mStr & vbCrLf &	"  },"
		mStr = mStr & vbCrLf &	"validated_FK_HRM_C_ProjectSiteID_main: false,"
		mStr = mStr & vbCrLf &	"validated_FK_HRM_C_ProjectSiteID: function(result) {"
		mStr = mStr & vbCrLf &	"  var p = result.split('|');"
		mStr = mStr & vbCrLf &	"  var o = $get(p[1]);"
		mStr = mStr & vbCrLf &	"  if(this.validated_FK_HRM_C_ProjectSiteID_main){"
		mStr = mStr & vbCrLf &	"    var o_d = $get(p[1]+'_Display');"
		mStr = mStr & vbCrLf &	"    try{o_d.innerHTML = p[2];}catch(ex){}"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf &	"  if(p[0]=='1'){"
		mStr = mStr & vbCrLf &	"    o.value='';"
		mStr = mStr & vbCrLf &	"    o.focus();"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scripthrmNEmployees") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scripthrmNEmployees", mStr)
		End If
  End Sub
	<System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_HRM_C_ProjectSiteID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim C_ProjectSiteID As String = CType(aVal(1),String)
		Dim oVar As SIS.IDM.idmProjects = SIS.IDM.idmProjects.GetByID(C_ProjectSiteID)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found." 
    Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
End Class
