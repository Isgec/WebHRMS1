<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmFunctionalStatus3.ascx.vb" Inherits="LC_hrmFunctionalStatus3" %>
<asp:DropDownList 
  ID = "DDLhrmFunctionalStatus3"
  DataSourceID = "OdsDdlhrmFunctionalStatus3"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmFunctionalStatus3"
  Runat = "server" 
  ControlToValidate = "DDLhrmFunctionalStatus3"
  Text = "Functional Status3 is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmFunctionalStatus3"
  runat = "server"
  TargetControlID = "DDLhrmFunctionalStatus3"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmFunctionalStatus3"
  TypeName = "SIS.HRM.hrmFunctionalStatus3"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
