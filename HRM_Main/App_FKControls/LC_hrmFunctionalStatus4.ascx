<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmFunctionalStatus4.ascx.vb" Inherits="LC_hrmFunctionalStatus4" %>
<asp:DropDownList 
  ID = "DDLhrmFunctionalStatus4"
  DataSourceID = "OdsDdlhrmFunctionalStatus4"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmFunctionalStatus4"
  Runat = "server" 
  ControlToValidate = "DDLhrmFunctionalStatus4"
  Text = "Functional Status4 is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmFunctionalStatus4"
  runat = "server"
  TargetControlID = "DDLhrmFunctionalStatus4"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmFunctionalStatus4"
  TypeName = "SIS.HRM.hrmFunctionalStatus4"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
