<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_hrmDepartments.aspx.vb" Inherits="GF_hrmDepartments" title="Maintain List: Departments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabeltaBH" runat="server" Text="&nbsp;List: Departments"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <LGM:ToolBar0 
      ID = "ToolBar0_1"
      ToolType = "lgNMGrid"
      ValidationGroup = "hrmDepartments"
      SearchContext = "hrmDepartments"
  EditUrl = "~/HRM_Main/App_Edit/EF_hrmDepartments.aspx"
  AddUrl = "~/HRM_Main/App_Create/AF_hrmDepartments.aspx"
      runat = "server" />
    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GridView1" runat="server" SkinID="gv_silver" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="DepartmentID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
            <asp:ImageButton ID="Edit" runat="server" AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandArgument='<%# Container.DataItemIndex %>' CommandName="lgEdit" />
						&nbsp;
            <asp:ImageButton ID="FastEdit" runat="server" AlternateText="InLineEdit" ToolTip="Inlie Edit the record." SkinID="FastEdit" CommandArgument='<%# Bind("DepartmentID") %>' CommandName="Edit" />
          </ItemTemplate>
          <HeaderStyle Width="70px" />
					<EditItemTemplate>
						<asp:ImageButton ID="Save" runat="server" AlternateText="Save" ToolTip="Save changes." SkinID="save" CommandArgument='<%# Container.DataItemIndex %>' commandName="Update" ValidationGroup = "hrmDepartments" />
						&nbsp;
						<asp:ImageButton ID="Cancel" runat="server" AlternateText="Cancel" ToolTip="Cancel changes." SkinID="cancel" CommandArgument='<%# Bind("DepartmentID") %>' commandname="Cancel" />
					</EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Department" SortExpression="DepartmentID">
          <ItemTemplate>
            <asp:Label ID="LabelDepartmentID" runat="server" Text='<%# Bind("DepartmentID") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        <EditItemTemplate>
            <asp:TextBox ID="TextBoxDescription"
              Text='<%# Bind("Description") %>'
              CssClass="mytxt"
						  runat="server"
						  ValidationGroup="hrmDepartments"
              ToolTip="Enter value for Description."
            Width="260px"
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
      DataObjectTypeName = "SIS.HRM.hrmDepartments"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "SelectList"
      UpdateMethod = "Update"
      TypeName = "SIS.HRM.hrmDepartments"
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
