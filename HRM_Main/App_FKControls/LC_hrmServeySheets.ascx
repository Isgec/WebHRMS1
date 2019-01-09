<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmServeySheets.ascx.vb" Inherits="LC_hrmServeySheets" %>
<asp:DropDownList 
  ID = "DDLhrmServeySheets"
  DataSourceID = "OdsDdlhrmServeySheets"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmServeySheets"
  Runat = "server" 
  ControlToValidate = "DDLhrmServeySheets"
  Text = "Servey Sheets is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmServeySheets"
  runat = "server"
  TargetControlID = "DDLhrmServeySheets"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmServeySheets"
  TypeName = "SIS.HRM.hrmServeySheets"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
