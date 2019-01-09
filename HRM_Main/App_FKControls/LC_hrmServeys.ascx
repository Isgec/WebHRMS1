<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmServeys.ascx.vb" Inherits="LC_hrmServeys" %>
<asp:DropDownList 
  ID = "DDLhrmServeys"
  DataSourceID = "OdsDdlhrmServeys"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmServeys"
  Runat = "server" 
  ControlToValidate = "DDLhrmServeys"
  Text = "Serveys is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmServeys"
  runat = "server"
  TargetControlID = "DDLhrmServeys"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmServeys"
  TypeName = "SIS.HRM.hrmServeys"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
