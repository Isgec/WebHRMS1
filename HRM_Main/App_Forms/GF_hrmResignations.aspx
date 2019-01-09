<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_hrmResignations.aspx.vb" Inherits="GF_hrmResignations" title="Maintain List: Resignes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabeltaBH" runat="server" Text="&nbsp;List: Resignes"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMGrid"
      EnableAdd = "False"
      ValidationGroup = "hrmResignations"
      SearchContext = "hrmResignations"
      EditUrl = "~/HRM_Main/App_Edit/EF_hrmResignations.aspx"
      AddUrl = "~/HRM_Main/App_Create/AF_hrmResignations.aspx"
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
            <asp:ImageButton ID="Edit" runat="server" AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandArgument='<%# Container.DataItemIndex %>'  CommandName="lgEdit"/>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
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
        <asp:TemplateField HeaderText="Department" SortExpression="HRM_Departments1_Description">
          <ItemTemplate>
             <asp:Label ID="LabelC_DepartmentID" runat="server" Text='<%# Eval("C_DepartmentIDHRM_Departments.Description") %>'></asp:Label>
          <asp:Label ID="TextC_DepartmentIDHidden" style="display:none" runat="server" Text='<%# Bind("C_DepartmentID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Designation" SortExpression="HRM_Designations2_Description">
          <ItemTemplate>
             <asp:Label ID="LabelC_DesignationID" runat="server" Text='<%# Eval("C_DesignationIDHRM_Designations.Description") %>'></asp:Label>
          <asp:Label ID="TextC_DesignationIDHidden" style="display:none" runat="server" Text='<%# Bind("C_DesignationID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status" SortExpression="HRM_Status3_Description">
          <ItemTemplate>
             <asp:Label ID="LabelC_StatusID" runat="server" Text='<%# Eval("C_StatusIDHRM_Status.Description") %>'></asp:Label>
          <asp:Label ID="TextC_StatusIDHidden" style="display:none" runat="server" Text='<%# Bind("C_StatusID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
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
      DataObjectTypeName = "SIS.HRM.hrmResignations"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "SelectList"
      TypeName = "SIS.HRM.hrmResignations"
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
