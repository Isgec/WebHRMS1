<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_hrmNEmployees.aspx.vb" Inherits="GF_hrmNEmployees" title="Maintain List: Employees" %>
<asp:Content ID="CPHhrmNEmployees" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabeltaBH" runat="server" Text="&nbsp;List: Employees"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLhrmNEmployees" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLhrmNEmployees"
      ToolType = "lgNMGrid"
      EditUrl = "~/HRM_Main/App_Edit/EF_hrmNEmployees.aspx"
      EnableAdd = "False"
      ValidationGroup = "hrmNEmployees"
      Skin = "tbl_blue"
      runat = "server" />
    <asp:UpdateProgress ID="UPGShrmNEmployees" runat="server" AssociatedUpdatePanelID="UPNLhrmNEmployees" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVhrmNEmployees" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODShrmNEmployees" DataKeyNames="CardNo">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="CardNo" SortExpression="CardNo">
          <ItemTemplate>
            <asp:Label ID="LabelCardNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("CardNo") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Employee Name" SortExpression="EmployeeName">
          <ItemTemplate>
            <asp:Label ID="LabelEmployeeName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("EmployeeName") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Department" SortExpression="HRM_Departments11_Description">
          <ItemTemplate>
             <asp:Label ID="L_C_DepartmentID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("C_DepartmentID") %>' Text='<%# Eval("HRM_Departments11_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Project Site" SortExpression="IDM_Projects1_Description">
          <ItemTemplate>
             <asp:Label ID="L_C_ProjectSiteID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("C_ProjectSiteID") %>' Text='<%# Eval("IDM_Projects1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Designation" SortExpression="HRM_Designations14_Description">
          <ItemTemplate>
             <asp:Label ID="L_C_DesignationID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("C_DesignationID") %>' Text='<%# Eval("HRM_Designations14_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Contact Numbers" SortExpression="ContactNumbers">
          <ItemTemplate>
            <asp:Label ID="LabelContactNumbers" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ContactNumbers") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="EMailID" SortExpression="EMailID">
          <ItemTemplate>
            <asp:Label ID="LabelEMailID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("EMailID") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="VPN Mail Expire On" SortExpression="VPNMailExpireOn">
          <ItemTemplate>
            <asp:Label ID="LabelVPNMailExpireOn" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("VPNMailExpireOn") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="80px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODShrmNEmployees"
      runat = "server"
      DataObjectTypeName = "SIS.HRM.hrmNEmployees"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "SelectList"
      TypeName = "SIS.HRM.hrmNEmployees"
      SelectCountMethod = "SelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVhrmNEmployees" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
