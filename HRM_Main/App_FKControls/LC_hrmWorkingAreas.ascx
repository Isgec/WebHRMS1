<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmWorkingAreas.ascx.vb" Inherits="LC_hrmWorkingAreas" %>
<asp:DropDownList 
  ID = "DDLhrmWorkingAreas"
  DataSourceID = "OdsDdlhrmWorkingAreas"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmWorkingAreas"
  Runat = "server" 
  ControlToValidate = "DDLhrmWorkingAreas"
  Text = "Working Areas is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmWorkingAreas"
  runat = "server"
  TargetControlID = "DDLhrmWorkingAreas"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmWorkingAreas"
  TypeName = "SIS.HRM.hrmWorkingAreas"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
