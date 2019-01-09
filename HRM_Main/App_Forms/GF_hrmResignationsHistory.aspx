<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_hrmResignationsHistory.aspx.vb" Inherits="GF_hrmResignationsHistory" title="Maintain List: Process Resignations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabeltaBH" runat="server" Text="&nbsp;List: Process Resignations"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMGrid"
      EnableAdd = "False"
      ValidationGroup = "hrmResignationsHistory"
      SearchContext = "hrmResignationsHistory"
      EditUrl = "~/HRM_Main/App_Edit/EF_hrmResignationsHistory.aspx"
      AddUrl = "~/HRM_Main/App_Create/AF_hrmResignationsHistory.aspx"
      runat = "server" />
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GridView1" runat="server" SkinID="gv_silver" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="ResignID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
            <asp:ImageButton ID="Edit" runat="server" AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandArgument='<%# Container.DataItemIndex %>' CommandName="lgEdit" />
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ID" SortExpression="ResignID">
          <ItemTemplate>
            <asp:Label ID="LabelResignID" runat="server" Text='<%# Bind("ResignID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignright" />
          <ItemStyle CssClass="alignright" />
          <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Card No" SortExpression="HRM_Employees1_EmployeeName">
          <ItemTemplate>
             <asp:Label ID="LabelCardNo" runat="server" Text='<%# Eval("CardNoHRM_Employees.EmployeeName") %>'></asp:Label>
          <asp:Label ID="TextCardNoHidden" style="display:none" runat="server" Text='<%# Bind("CardNo") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status" SortExpression="HRM_Status2_Description">
          <ItemTemplate>
             <asp:Label ID="LabelStatusID" runat="server" Text='<%# Eval("StatusIDHRM_Status.Description") %>'></asp:Label>
          <asp:Label ID="TextStatusIDHidden" style="display:none" runat="server" Text='<%# Bind("StatusID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Resigned On" SortExpression="ResignedOn">
          <ItemTemplate>
            <asp:Label ID="LabelResignedOn" runat="server" Text='<%# Bind("ResignedOn") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Releaved On" SortExpression="ReleavedOn">
          <ItemTemplate>
            <asp:Label ID="LabelReleavedOn" runat="server" Text='<%# Bind("ReleavedOn") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Remarks" SortExpression="Remarks">
          <ItemTemplate>
            <asp:Label ID="LabelRemarks" runat="server" Text='<%# Bind("Remarks") %>'></asp:Label>
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
      DataObjectTypeName = "SIS.HRM.hrmResignationsHistory"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "SelectList"
      TypeName = "SIS.HRM.hrmResignationsHistory"
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
