<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmResignationsHistory.aspx.vb" Inherits="EF_hrmResignationsHistory" title="Edit: Process Resignations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Process Resignations"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMEdit"
      EnableDelete = "False"
      ValidationGroup = "hrmResignationsHistory"
      runat = "server" />
<asp:FormView ID="FormView1"
	runat = "server"
	DataKeyNames = "ResignID"
	DataSourceID = "ObjectDataSource1"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
              <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelResignID" runat="server" Text="ID :" /></b>
				</td>
				<td>
					<asp:Label ID="TextResignID" runat="server" Text='<%# Bind("ResignID") %>' />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelCardNo" runat="server" Text="Card No :" /></b>
				</td>
        <td>
          <asp:Label ID="TextCardNo" runat="server" Text='<%# Eval("CardNoHRM_Employees.EmployeeName") %>'></asp:Label>
          <asp:Label ID="TextCardNoHidden" style="display:none" runat="server" Text='<%# Bind("CardNo") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelStatusID" runat="server" Text="Status :" /></b>
				</td>
        <td>
          <asp:Label ID="TextStatusID" runat="server" Text='<%# Eval("StatusIDHRM_Status.Description") %>'></asp:Label>
          <asp:Label ID="TextStatusIDHidden" style="display:none" runat="server" Text='<%# Bind("StatusID") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelResignedOn" runat="server" Text="Resigned On :" /></b>
				</td>
        <td>
          <asp:Label ID="TextResignedOn" runat="server" Text='<%# Bind("ResignedOn") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelReleavedOn" runat="server" Text="Releaved On :" /></b>
				</td>
        <td>
          <asp:Label ID="TextReleavedOn" runat="server" Text='<%# Bind("ReleavedOn") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelRemarks" runat="server" Text="Remarks :" /></b>
				</td>
        <td>
          <asp:Label ID="TextRemarks" runat="server" Text='<%# Bind("Remarks") %>'></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelExecuted" runat="server" Text="Execute :" /></b>
				</td>
				<td>
            <asp:CheckBox ID="CheckBoxExecuted"
						  Checked='<%# Bind("Executed") %>'
              runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="LabelCancelled" runat="server" Text="Cancel :" /></b>
				</td>
				<td>
            <asp:CheckBox ID="CheckBoxCancelled"
						  Checked='<%# Bind("Cancelled") %>'
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
  DataObjectTypeName = "SIS.HRM.hrmResignationsHistory"
  SelectMethod = "GetByID"
  UpdateMethod="UZ_Update"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.HRM.hrmResignationsHistory"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ResignID" Name="ResignID" Type="Int32" />
</SelectParameters>
<UpdateParameters>
  <asp:Parameter Name="ResignID" Type="Int32" />
</UpdateParameters>
</asp:ObjectDataSource>
</div>
  </div>
</asp:Content>
