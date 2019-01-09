<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmJoiningStates.ascx.vb" Inherits="LC_hrmJoiningStates" %>
<asp:DropDownList 
  ID = "DDLhrmJoiningStates"
  DataSourceID = "OdsDdlhrmJoiningStates"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmJoiningStates"
  Runat = "server" 
  ControlToValidate = "DDLhrmJoiningStates"
  Text = "Joining States is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmJoiningStates"
  runat = "server"
  TargetControlID = "DDLhrmJoiningStates"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmJoiningStates"
  TypeName = "SIS.HRM.hrmJoiningStates"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
