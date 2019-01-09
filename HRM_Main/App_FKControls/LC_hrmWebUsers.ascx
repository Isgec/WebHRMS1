<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmWebUsers.ascx.vb" Inherits="LC_hrmWebUsers" %>
<asp:DropDownList 
  ID = "DDLhrmWebUsers"
  DataSourceID = "OdsDdlhrmWebUsers"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmWebUsers"
  Runat = "server" 
  ControlToValidate = "DDLhrmWebUsers"
  Text = "Web Users is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmWebUsers"
  runat = "server"
  TargetControlID = "DDLhrmWebUsers"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmWebUsers"
  TypeName = "SIS.HRM.hrmWebUsers"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
