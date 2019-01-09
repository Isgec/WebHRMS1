<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_hrmOfficialProfile.aspx.vb" Inherits="GF_hrmOfficialProfile" title="Maintain List: Official Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabeltaBH" runat="server" Text="&nbsp;List: Official Profile"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMGrid"
      EnableAdd = "False"
      ValidationGroup = "hrmOfficialProfile"
      SearchContext = "hrmOfficialProfile"
  EditUrl= "~/HRM_Main/App_Edit/EF_hrmOfficialProfile.aspx"
  AddUrl= "~/HRM_Main/App_Create/AF_hrmOfficialProfile.aspx"
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
        <asp:TemplateField HeaderText="Working Area" SortExpression="HRM_WorkingAreas1_Description">
          <ItemTemplate>
             <asp:Label ID="LabelWorkingAreaID" runat="server" Text='<%# Eval("WorkingAreaIDHRM_WorkingAreas.Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Functional Status 1" SortExpression="HRM_FunctionalStatus12_Description">
          <ItemTemplate>
             <asp:Label ID="LabelFunctionalStatusID1" runat="server" Text='<%# Eval("FunctionalStatusID1HRM_FunctionalStatus1.Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Functional Status 2" SortExpression="HRM_FunctionalStatus23_Description">
          <ItemTemplate>
             <asp:Label ID="LabelFunctionalStatusID2" runat="server" Text='<%# Eval("FunctionalStatusID2HRM_FunctionalStatus2.Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Functional Status 3" SortExpression="HRM_FunctionalStatus34_Description">
          <ItemTemplate>
             <asp:Label ID="LabelFunctionalStatusID3" runat="server" Text='<%# Eval("FunctionalStatusID3HRM_FunctionalStatus3.Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Functional Status 4" SortExpression="HRM_FunctionalStatus45_Description">
          <ItemTemplate>
             <asp:Label ID="LabelFunctionalStatusID4" runat="server" Text='<%# Eval("FunctionalStatusID4HRM_FunctionalStatus4.Description") %>'></asp:Label>
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
      DataObjectTypeName = "SIS.HRM.hrmOfficialProfile"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "SelectList"
      TypeName = "SIS.HRM.hrmOfficialProfile"
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
