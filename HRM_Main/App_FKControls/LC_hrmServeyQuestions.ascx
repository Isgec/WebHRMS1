<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmServeyQuestions.ascx.vb" Inherits="LC_hrmServeyQuestions" %>
<asp:DropDownList 
  ID = "DDLhrmServeyQuestions"
  DataSourceID = "OdsDdlhrmServeyQuestions"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmServeyQuestions"
  Runat = "server" 
  ControlToValidate = "DDLhrmServeyQuestions"
  Text = "Servey Questions is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmServeyQuestions"
  runat = "server"
  TargetControlID = "DDLhrmServeyQuestions"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmServeyQuestions"
  TypeName = "SIS.HRM.hrmServeyQuestions"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
