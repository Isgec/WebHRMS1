<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmNewEmployees.ascx.vb" Inherits="LC_hrmNewEmployees" %>
<asp:DropDownList 
  ID = "DDLhrmNewEmployees"
  DataSourceID = "OdsDdlhrmNewEmployees"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmNewEmployees"
  Runat = "server" 
  ControlToValidate = "DDLhrmNewEmployees"
  Text = "Employees is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmNewEmployees"
  runat = "server"
  TargetControlID = "DDLhrmNewEmployees"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmNewEmployees"
  TypeName = "SIS.HRM.hrmNewEmployees"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
