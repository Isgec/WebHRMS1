<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_hrmDepartments.aspx.vb" Inherits="AF_hrmDepartments" title="Add: Departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Add: Departments"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server" >
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMAdd"
      ValidationGroup = "hrmDepartments"
      runat = "server" />
<asp:FormView ID="FormView1"
	runat = "server"
	DataKeyNames = "DepartmentID"
	DataSourceID = "ObjectDataSource1"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelDepartmentID" runat="server" Text="Department :" /></b>
				</td>
				<td>
					<asp:TextBox ID="TextBoxDepartmentID"
						Text='<%# Bind("DepartmentID") %>'
            CssClass="mytxt"
						runat="server"
            onblur= "validate_DepartmentID(this);"
						ValidationGroup="hrmDepartments"
            ToolTip="Enter value for Department."
            Width="60px"
						MaxLength="6" />
					<AJX:TextBoxWatermarkExtender 
						ID = "TextBoxWatermarkExtenderDepartmentID"
						runat = "server"
            WatermarkText="[Enter Department]"
						TargetControlID="TextBoxDepartmentID" />
					<asp:RequiredFieldValidator 
						ID = "RequiredFieldValidatorDepartmentID"
						runat = "server"
						ControlToValidate = "TextBoxDepartmentID"
						Text = "Department is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "hrmDepartments"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelDescription" runat="server" Text="Description :" /></b>
				</td>
				<td>
					<asp:TextBox ID="TextBoxDescription"
						Text='<%# Bind("Description") %>'
            CssClass="mytxt"
						runat="server"
						ValidationGroup="hrmDepartments"
            ToolTip="Enter value for Description."
            Width="100px"
						MaxLength="30" />
					<AJX:TextBoxWatermarkExtender 
						ID = "TextBoxWatermarkExtenderDescription"
						runat = "server"
            WatermarkText="[Enter Description]"
						TargetControlID="TextBoxDescription" />
					<asp:RequiredFieldValidator 
						ID = "RequiredFieldValidatorDescription"
						runat = "server"
						ControlToValidate = "TextBoxDescription"
						Text = "Description is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "hrmDepartments"
						SetFocusOnError="true" />
				</td>
			</tr>
		</table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ObjectDataSource1"
  DataObjectTypeName = "SIS.HRM.hrmDepartments"
  InsertMethod="Insert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.HRM.hrmDepartments"
  SelectMethod = "GetByID"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" Name="DepartmentID" QueryStringField="Code" Type="String" />
</SelectParameters>
<InsertParameters>
  <asp:Parameter Name="DepartmentID" Type="String" Direction="Output" />
</InsertParameters>
</asp:ObjectDataSource>
</div>
  </div>
</asp:Content>
