<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_hrmVerifyJoinings.aspx.vb" Inherits="GF_hrmVerifyJoinings" title="Maintain List: Verify Joining" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabeltaBH" runat="server" Text="&nbsp;List: Verify Joining"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMGrid"
      EnableAdd = "False"
      ValidationGroup = "hrmVerifyJoinings"
      SearchContext = "hrmVerifyJoinings"
  EditUrl = "~/HRM_Main/App_Edit/EF_hrmVerifyJoinings.aspx"
  AddUrl = "~/HRM_Main/App_Create/AF_hrmVerifyJoinings.aspx"
      runat = "server" />
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GridView1" runat="server" SkinID="gv_silver" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="CardNo">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
            <asp:ImageButton ID="Edit" runat="server" AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandArgument='<%# Container.DataItemIndex %>' CommandName="lgEdit" />
						&nbsp;
            <asp:ImageButton ID="FastEdit" runat="server" AlternateText="InLineEdit" ToolTip="Inlie Edit the record." SkinID="FastEdit" CommandArgument='<%# Bind("CardNo") %>' CommandName="Edit" />
          </ItemTemplate>
          <HeaderStyle Width="70px" />
					<EditItemTemplate>
						<asp:ImageButton ID="Save" runat="server" AlternateText="Save" ToolTip="Save changes." SkinID="save" CommandArgument='<%# Bind("CardNo") %>' commandName="Update" ValidationGroup = "hrmVerifyJoinings" />
						&nbsp;
						<asp:ImageButton ID="Cancel" runat="server" AlternateText="Cancel" ToolTip="Cancel changes." SkinID="cancel" CommandArgument='<%# Bind("CardNo") %>' commandname="Cancel" />
					</EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Card No" SortExpression="CardNo">
          <ItemTemplate>
            <asp:Label ID="LabelCardNo" runat="server" Text='<%# Bind("CardNo") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Employee Name" SortExpression="EmployeeName">
          <ItemTemplate>
            <asp:Label ID="LabelEmployeeName" runat="server" Text='<%# Bind("EmployeeName") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Date Of Joining" SortExpression="C_DateOfJoining">
          <ItemTemplate>
            <asp:Label ID="LabelC_DateOfJoining" runat="server" Text='<%# Bind("C_DateOfJoining") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Joining Department" SortExpression="HRM_Departments4_Description">
          <ItemTemplate>
             <asp:Label ID="LabelJ_DepartmentID" runat="server" Text='<%# Eval("J_DepartmentIDHRM_Departments.Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Joining Designation" SortExpression="HRM_Designations6_Description">
          <ItemTemplate>
             <asp:Label ID="LabelJ_DesignationID" runat="server" Text='<%# Eval("J_DesignationIDHRM_Designations.Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Joining Basic Salary" SortExpression="J_BasicSalary">
          <ItemTemplate>
            <asp:Label ID="LabelJ_BasicSalary" runat="server" Text='<%# Bind("J_BasicSalary") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignright" />
          <ItemStyle CssClass="alignright" />
          <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Freezed" SortExpression="Freezed">
          <ItemTemplate>
            <asp:Label ID="LabelFreezed" runat="server" Text='<%# Bind("Freezed") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="50px" />
        <EditItemTemplate>
            <asp:CheckBox ID="CheckBoxFreezed"
						  Checked='<%# Bind("Freezed") %>'
              runat="server" />
        </EditItemTemplate>
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
      <RowStyle BackColor="PaleGoldenrod" />
      <PagerStyle BackColor="DarkGoldenrod" Font-Bold="True" HorizontalAlign="Center" />
      <HeaderStyle BackColor="DarkGoldenrod" BorderColor="Black" BorderStyle="Solid" BorderWidth="1pt" />
      <AlternatingRowStyle BackColor="Bisque" />
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ObjectDataSource1"
      runat = "server"
      DataObjectTypeName = "SIS.HRM.hrmVerifyJoinings"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "SelectList"
      UpdateMethod = "UZ_Update"
      TypeName = "SIS.HRM.hrmVerifyJoinings"
      SelectCountMethod = "SelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GridView1" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
  </div>
</asp:Content>
