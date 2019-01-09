<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmQualifications.ascx.vb" Inherits="LC_hrmQualifications" %>
<asp:DropDownList 
  ID = "DDLhrmQualifications"
  DataSourceID = "OdsDdlhrmQualifications"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmQualifications"
  Runat = "server" 
  ControlToValidate = "DDLhrmQualifications"
  Text = "Qualifications is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmQualifications"
  runat = "server"
  TargetControlID = "DDLhrmQualifications"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmQualifications"
  TypeName = "SIS.HRM.hrmQualifications"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
