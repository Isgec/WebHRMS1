<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmEmployees.ascx.vb" Inherits="LC_hrmEmployees" %>
<asp:DropDownList 
  ID = "DDLhrmEmployees"
  DataSourceID = "OdsDdlhrmEmployees"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmEmployees"
  Runat = "server" 
  ControlToValidate = "DDLhrmEmployees"
  Text = "Employees is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmEmployees"
  runat = "server"
  TargetControlID = "DDLhrmEmployees"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmEmployees"
  TypeName = "SIS.HRM.hrmEmployees"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
