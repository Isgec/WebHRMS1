<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_hrmRatings.ascx.vb" Inherits="LC_hrmRatings" %>
<asp:DropDownList 
  ID = "DDLhrmRatings"
  DataSourceID = "OdsDdlhrmRatings"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorhrmRatings"
  Runat = "server" 
  ControlToValidate = "DDLhrmRatings"
  Text = "Ratings is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEhrmRatings"
  runat = "server"
  TargetControlID = "DDLhrmRatings"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlhrmRatings"
  TypeName = "SIS.HRM.hrmRatings"
  SortParameterName = "OrderBy"
  SelectMethod = "SelectList"
  Runat="server" />
