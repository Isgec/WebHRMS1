<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmStatus.ascx.vb" Inherits="LC_hrmStatus" %>
<asp:DropDownList 
  ID = "DDLhrmStatus"
  DataSourceID = "OdsDdlhrmStatus"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmStatus"
  Runat = "server" 
  ControlToValidate = "DDLhrmStatus"
  Text = "Status is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmStatus"
  runat = "server"
  TargetControlID = "DDLhrmStatus"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmStatus"
  TypeName = "SIS.HRM.hrmStatus"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
