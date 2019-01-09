<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmFunctionalStatus2.ascx.vb" Inherits="LC_hrmFunctionalStatus2" %>
<asp:DropDownList 
  ID = "DDLhrmFunctionalStatus2"
  DataSourceID = "OdsDdlhrmFunctionalStatus2"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmFunctionalStatus2"
  Runat = "server" 
  ControlToValidate = "DDLhrmFunctionalStatus2"
  Text = "Functional Status2 is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmFunctionalStatus2"
  runat = "server"
  TargetControlID = "DDLhrmFunctionalStatus2"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmFunctionalStatus2"
  TypeName = "SIS.HRM.hrmFunctionalStatus2"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
