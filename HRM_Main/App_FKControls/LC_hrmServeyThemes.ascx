<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmServeyThemes.ascx.vb" Inherits="LC_hrmServeyThemes" %>
<asp:DropDownList 
  ID = "DDLhrmServeyThemes"
  DataSourceID = "OdsDdlhrmServeyThemes"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmServeyThemes"
  Runat = "server" 
  ControlToValidate = "DDLhrmServeyThemes"
  Text = "Survey Themes is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmServeyThemes"
  runat = "server"
  TargetControlID = "DDLhrmServeyThemes"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmServeyThemes"
  TypeName = "SIS.HRM.hrmServeyThemes"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
