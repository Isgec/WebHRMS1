<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_hrmPersonalProfile.aspx.vb" Inherits="GF_hrmPersonalProfile" title="Maintain List: Personal Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabeltaBH" runat="server" Text="&nbsp;List: Personal Profile"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMGrid"
      EnableAdd = "False"
      ValidationGroup = "hrmPersonalProfile"
      SearchContext = "hrmPersonalProfile"
  EditUrl = "~/HRM_Main/App_Edit/EF_hrmPersonalProfile.aspx"
  AddUrl = "~/HRM_Main/App_Create/AF_hrmPersonalProfile.aspx"
      runat = "server" />
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="CardNo">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
            <asp:ImageButton ID="Edit" runat="server" AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandArgument='<%# Bind("CardNo") %>' CommandName="lgEdit" />
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
        <asp:TemplateField HeaderText="Date Of Birth" SortExpression="DateOfBirth">
          <ItemTemplate>
            <asp:Label ID="LabelDateOfBirth" runat="server" Text='<%# Bind("DateOfBirth") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Blood Group" SortExpression="HRM_BloodGroups1_Description">
          <ItemTemplate>
             <asp:Label ID="LabelBloodGroupID" runat="server" Text='<%# Eval("BloodGroupIDHRM_BloodGroups.Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Contact Numbers" SortExpression="ContactNumbers">
          <ItemTemplate>
            <asp:Label ID="LabelContactNumbers" runat="server" Text='<%# Bind("ContactNumbers") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Office File Number" SortExpression="OfficeFileNumber">
          <ItemTemplate>
            <asp:Label ID="LabelOfficeFileNumber" runat="server" Text='<%# Bind("OfficeFileNumber") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="E-Mail" SortExpression="EMailID">
          <ItemTemplate>
            <asp:Label ID="LabelEMailID" runat="server" Text='<%# Bind("EMailID") %>'></asp:Label>
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
      DataObjectTypeName = "SIS.HRM.hrmPersonalProfile"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "SelectList"
      TypeName = "SIS.HRM.hrmPersonalProfile"
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
