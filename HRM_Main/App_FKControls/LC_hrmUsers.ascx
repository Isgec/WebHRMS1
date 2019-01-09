<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmUsers.ascx.vb" Inherits="LC_hrmUsers" %>
<asp:DropDownList 
  ID = "DDLhrmUsers"
  DataSourceID = "OdsDdlhrmUsers"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmUsers"
  Runat = "server" 
  ControlToValidate = "DDLhrmUsers"
  Text = "Web Users is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmUsers"
  runat = "server"
  TargetControlID = "DDLhrmUsers"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmUsers"
  TypeName = "SIS.HRM.hrmUsers"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
