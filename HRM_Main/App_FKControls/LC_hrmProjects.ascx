<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmProjects.ascx.vb" Inherits="LC_hrmProjects" %>
<asp:DropDownList 
  ID = "DDLhrmProjects"
  DataSourceID = "OdsDdlhrmProjects"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmProjects"
  Runat = "server" 
  ControlToValidate = "DDLhrmProjects"
  Text = "Projects is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmProjects"
  runat = "server"
  TargetControlID = "DDLhrmProjects"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmProjects"
  TypeName = "SIS.HRM.hrmProjects"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
