<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmBloodGroups.ascx.vb" Inherits="LC_hrmBloodGroups" %>
<asp:DropDownList 
  ID = "DDLhrmBloodGroups"
  DataSourceID = "OdsDdlhrmBloodGroups"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmBloodGroups"
  Runat = "server" 
  ControlToValidate = "DDLhrmBloodGroups"
  Text = "Blood Groups is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmBloodGroups"
  runat = "server"
  TargetControlID = "DDLhrmBloodGroups"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmBloodGroups"
  TypeName = "SIS.HRM.hrmBloodGroups"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
