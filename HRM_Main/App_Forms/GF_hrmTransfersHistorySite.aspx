<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_hrmTransfersHistorySite.aspx.vb" Inherits="GF_hrmTransfersHistorySite" title="Maintain List: Process Transfers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabeltaBH" runat="server" Text="&nbsp;List: Process Transfers [Site]"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMGrid"
      EnableAdd = "False"
      ValidationGroup = "hrmTransfersHistory"
      SearchContext = "hrmTransfersHistory"
	EditUrl = "~/HRM_Main/App_Edit/EF_hrmTransfersHistorySite.aspx"
      runat = "server" />
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="TransferID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
            <asp:ImageButton ID="Edit" runat="server" AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandArgument='<%# Bind("TransferID") %>' CommandName="lgEdit" />
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="TransferID" SortExpression="TransferID">
          <ItemTemplate>
            <asp:Label ID="LabelTransferID" runat="server" Text='<%# Bind("TransferID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignright" />
          <ItemStyle CssClass="alignright" />
          <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="CardNo" SortExpression="HRM_Employees1_EmployeeName">
          <ItemTemplate>
             <asp:Label ID="LabelCardNo" runat="server" Text='<%# Eval("CardNoHRM_Employees.EmployeeName") %>'></asp:Label>
          <asp:Label ID="TextCardNoHidden" style="display:none" runat="server" Text='<%# Bind("CardNo") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Company" SortExpression="HRM_Companies2_Description">
          <ItemTemplate>
             <asp:Label ID="LabelCompanyID" runat="server" Text='<%# Eval("CompanyIDHRM_Companies.Description") %>'></asp:Label>
          <asp:Label ID="TextCompanyIDHidden" style="display:none" runat="server" Text='<%# Bind("CompanyID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Division" SortExpression="HRM_Divisions3_Description">
          <ItemTemplate>
             <asp:Label ID="LabelDivisionID" runat="server" Text='<%# Eval("DivisionIDHRM_Divisions.Description") %>'></asp:Label>
          <asp:Label ID="TextDivisionIDHidden" style="display:none" runat="server" Text='<%# Bind("DivisionID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Office" SortExpression="HRM_Offices4_Description">
          <ItemTemplate>
             <asp:Label ID="LabelOfficeID" runat="server" Text='<%# Eval("OfficeIDHRM_Offices.Description") %>'></asp:Label>
          <asp:Label ID="TextOfficeIDHidden" style="display:none" runat="server" Text='<%# Bind("OfficeID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Department" SortExpression="HRM_Departments5_Description">
          <ItemTemplate>
             <asp:Label ID="LabelDepartmentID" runat="server" Text='<%# Eval("DepartmentIDHRM_Departments.Description") %>'></asp:Label>
          <asp:Label ID="TextDepartmentIDHidden" style="display:none" runat="server" Text='<%# Bind("DepartmentID") %>'></asp:Label>
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
      DataObjectTypeName = "SIS.HRM.hrmTransfersHistory"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "SelectListSite"
      TypeName = "SIS.HRM.hrmTransfersHistory"
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
