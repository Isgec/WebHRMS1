<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmFunctionalStatus1.ascx.vb" Inherits="LC_hrmFunctionalStatus1" %>
<asp:DropDownList 
  ID = "DDLhrmFunctionalStatus1"
  DataSourceID = "OdsDdlhrmFunctionalStatus1"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmFunctionalStatus1"
  Runat = "server" 
  ControlToValidate = "DDLhrmFunctionalStatus1"
  Text = "Functional Status1 is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmFunctionalStatus1"
  runat = "server"
  TargetControlID = "DDLhrmFunctionalStatus1"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmFunctionalStatus1"
  TypeName = "SIS.HRM.hrmFunctionalStatus1"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
