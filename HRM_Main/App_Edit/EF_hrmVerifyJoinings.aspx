<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmVerifyJoinings.aspx.vb" Inherits="EF_hrmVerifyJoinings" title="Edit: Verify Joining" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Verify Joining"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server" >
<ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMEdit"
      EnableDelete = "False"
      ValidationGroup = "hrmVerifyJoinings"
      runat = "server" />
<asp:FormView ID="FormView1"
	runat = "server"
	DataKeyNames = "CardNo"
	DataSourceID = "ObjectDataSource1"
	DefaultMode = "Edit" 
  CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelCardNo" runat="server" Text="Card No :" /></b>
				</td>
				<td>
					<asp:Label ID="TextCardNo" runat="server" Text='<%# Bind("CardNo") %>' />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelSalute" runat="server" Text="Salute :" /></b>
				</td>
        <td>
          <asp:Label ID="TextSalute" runat="server" Text='<%# Eval("Salute") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelEmployeeName" runat="server" Text="Employee Name :" /></b>
				</td>
        <td>
          <asp:Label ID="TextEmployeeName" runat="server" Text='<%# Eval("EmployeeName") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelAliasName" runat="server" Text="Alias Name :" /></b>
				</td>
        <td>
          <asp:Label ID="TextAliasName" runat="server" Text='<%# Eval("AliasName") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelGender" runat="server" Text="Gender :" /></b>
				</td>
        <td>
          <asp:Label ID="TextGender" runat="server" Text='<%# Eval("Gender") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelC_DateOfJoining" runat="server" Text="Date Of Joining :" /></b>
				</td>
        <td>
          <asp:Label ID="TextC_DateOfJoining" runat="server" Text='<%# Eval("C_DateOfJoining") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_CompanyID" runat="server" Text="Joining Company :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_CompanyID" runat="server" Text='<%# Eval("J_CompanyIDHRM_Companies.Description") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_DivisionID" runat="server" Text="Joining Division :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_DivisionID" runat="server" Text='<%# Eval("J_DivisionIDHRM_Divisions.Description") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_OfficeID" runat="server" Text="Joining Office :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_OfficeID" runat="server" Text='<%# Eval("J_OfficeIDHRM_Offices.Description") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_DepartmentID" runat="server" Text="Joining Department :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_DepartmentID" runat="server" Text='<%# Eval("J_DepartmentIDHRM_Departments.Description") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_ProjectSiteID" runat="server" Text="Joining Project Site :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_ProjectSiteID" runat="server" Text='<%# Eval("J_ProjectSiteIDDCM_Projects.Description") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_DesignationID" runat="server" Text="Joining Designation :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_DesignationID" runat="server" Text='<%# Eval("J_DesignationIDHRM_Designations.Description") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_BasicSalary" runat="server" Text="Joining Basic Salary :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_BasicSalary" runat="server" Text='<%# Eval("J_BasicSalary") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_StatusID" runat="server" Text="Joining Status :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_StatusID" runat="server" Text='<%# Eval("J_StatusIDHRM_Status.Description") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelJ_StatusRemark" runat="server" Text="Joining Status Remark :" /></b>
				</td>
        <td>
          <asp:Label ID="TextJ_StatusRemark" runat="server" Text='<%# Eval("J_StatusRemark") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelFreezed" runat="server" Text="Freezed :" /></b>
				</td>
				<td>
            <asp:CheckBox ID="CheckBoxFreezed"
						  Checked='<%# Bind("Freezed") %>'
              runat="server" />
				</td>
			</tr>
		</table>
  </div>
  </EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ObjectDataSource1"
  DataObjectTypeName = "SIS.HRM.hrmVerifyJoinings"
  SelectMethod = "GetByID"
  UpdateMethod="UZ_Update"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.HRM.hrmVerifyJoinings"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="Code" Name="CardNo" Type="String" />
</SelectParameters>
<UpdateParameters>
  <asp:Parameter Name="CardNo" Type="String" />
</UpdateParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
