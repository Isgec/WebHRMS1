<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmEMailGroups.ascx.vb" Inherits="LC_hrmEMailGroups" %>
<asp:DropDownList 
  ID = "DDLhrmEMailGroups"
  DataSourceID = "OdsDdlhrmEMailGroups"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmEMailGroups"
  Runat = "server" 
  ControlToValidate = "DDLhrmEMailGroups"
  Text = "EMailGroups is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmEMailGroups"
  runat = "server"
  TargetControlID = "DDLhrmEMailGroups"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmEMailGroups"
  TypeName = "SIS.HRM.hrmEMailGroups"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
