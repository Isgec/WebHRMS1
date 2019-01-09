<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmNewJoinings.aspx.vb" Inherits="EF_hrmNewJoinings" title="Edit: New Joining" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: New Joining"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="ToolBar0_1"
            ToolType="lgNMEdit"
            ValidationGroup="hrmNewJoinings"
            runat="server" />
          <asp:FormView ID="FormView1"
            runat="server"
            DataKeyNames="CardNo"
            DataSourceID="ObjectDataSource1"
            DefaultMode="Edit" CssClass="sis_formview">
            <EditItemTemplate>
              <div id="frmdiv" class="ui-widget-content minipage">
                <table>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelCardNo" runat="server" Text="Card No :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextCardNo" runat="server" Text='<%# Bind("CardNo") %>' />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelSalute" runat="server" Text="Salute :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <asp:DropDownList
                        ID="ENUM_Salute1"
                        SelectedValue='<%# Bind("Salute") %>'
                        CssClass="myddl"
                        Width="200px"
                        ValidationGroup="hrmNewJoinings"
                        runat="Server">
                        <asp:ListItem Value="Mr.">Mr.</asp:ListItem>
                        <asp:ListItem Value="Ms.">Ms.</asp:ListItem>
                        <asp:ListItem Value="Mrs.">Mrs.</asp:ListItem>
                        <asp:ListItem Value="Dr.">Dr.</asp:ListItem>
                      </asp:DropDownList>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelEmployeeName" runat="server" Text="Employee Name :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxEmployeeName"
                        Text='<%# Bind("EmployeeName") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmNewJoinings"
                        ToolTip="Enter value for Employee Name."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderEmployeeName"
                        runat="server"
                        WatermarkText="[Enter Employee Name]"
                        TargetControlID="TextBoxEmployeeName" />
                      <asp:RequiredFieldValidator
                        ID="RequiredFieldValidatorEmployeeName"
                        runat="server"
                        ControlToValidate="TextBoxEmployeeName"
                        Text="Employee Name is required."
                        ErrorMessage="[Required!]"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="hrmNewJoinings"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelAliasName" runat="server" Text="Alias Name :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxAliasName"
                        Text='<%# Bind("AliasName") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmNewJoinings"
                        ToolTip="Enter value for Alias Name."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderAliasName"
                        runat="server"
                        WatermarkText="[Enter Alias Name]"
                        TargetControlID="TextBoxAliasName" />
                      <asp:RequiredFieldValidator
                        ID="RequiredFieldValidatorAliasName"
                        runat="server"
                        ControlToValidate="TextBoxAliasName"
                        Text="Alias Name is required."
                        ErrorMessage="[Required!]"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="hrmNewJoinings"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelGender" runat="server" Text="Gender :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <asp:DropDownList
                        ID="ENUM_Gender1"
                        SelectedValue='<%# Bind("Gender") %>'
                        CssClass="myddl"
                        Width="200px"
                        ValidationGroup="hrmNewJoinings"
                        runat="Server">
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>
                      </asp:DropDownList>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_DateOfJoining" runat="server" Text="Date Of Joining :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_DateOfJoining"
                        Text='<%# Bind("C_DateOfJoining") %>'
                        ValidationGroup="hrmNewJoinings"
                        Width="70px"
                        CssClass="mytxt"
                        runat="server" />
                      <asp:Image ID="ImageButton1" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CalendarExtenderC_DateOfJoining"
                        TargetControlID="TextBoxC_DateOfJoining"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButton1" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderC_DateOfJoining"
                        runat="server"
                        Mask="99/99/9999"
                        MaskType="Date"
                        CultureName="en-GB"
                        MessageValidatorTip="true"
                        InputDirection="LeftToRight"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxC_DateOfJoining" />
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorC_DateOfJoining"
                        runat="server"
                        ControlToValidate="TextBoxC_DateOfJoining"
                        ControlExtender="MaskedEditExtenderC_DateOfJoining"
                        InvalidValueMessage="Invalid value for Date Of Joining."
                        EmptyValueMessage="Date Of Joining is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Date Of Joining."
                        EnableClientScript="true"
                        ValidationGroup="hrmNewJoinings"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelJ_CompanyID" runat="server" Text="Joining Company :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmCompanies
                        ID="LC_J_CompanyID1"
                        SelectedValue='<%# Bind("J_CompanyID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="CompanyID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmNewJoinings"
                        RequiredFieldErrorMessage="Joining Company is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelJ_DivisionID" runat="server" Text="Joining Division :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmDivisions
                        ID="LC_J_DivisionID1"
                        SelectedValue='<%# Bind("J_DivisionID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="DivisionID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmNewJoinings"
                        RequiredFieldErrorMessage="Joining Division is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelJ_OfficeID" runat="server" Text="Joining Office :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmOffices
                        ID="LC_J_OfficeID1"
                        SelectedValue='<%# Bind("J_OfficeID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="OfficeID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmNewJoinings"
                        RequiredFieldErrorMessage="Joining Office is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelJ_DepartmentID" runat="server" Text="Joining Department :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmDepartments
                        ID="LC_J_DepartmentID1"
                        SelectedValue='<%# Bind("J_DepartmentID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="DepartmentID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmNewJoinings"
                        RequiredFieldErrorMessage="Joining Department is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright"><b>Joining Project Site :</b></td>
                    <td style="padding-left: 5px;">
                      <asp:TextBox
                        ID="LC_J_ProjectSiteID1"
                        CssClass="mytxt"
                        Width="40px"
                        Text='<%# Bind("J_ProjectSiteID") %>'
                        AutoCompleteType="None"
                        Style="display: none"
                        runat="Server" />
                      <asp:TextBox
                        ID="LC_J_ProjectSiteIDDescription1"
                        Text='<%# Bind("J_ProjectSiteIDDescription") %>'
                        CssClass="mytxt"
                        Width="200px"
                        AutoCompleteType="None"
                        ToolTip="Enter value for Joining Project Site."
                        runat="Server" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderJ_ProjectSiteID"
                        runat="server"
                        WatermarkText="[Enter Joining Project Site]"
                        TargetControlID="LC_J_ProjectSiteIDDescription1" />
                      <AJX:AutoCompleteExtender
                        ID="LC_J_ProjectSiteID1_AutoCompleteExtender"
                        ServiceMethod="J_ProjectSiteIDCompletionList"
                        TargetControlID="LC_J_ProjectSiteIDDescription1"
                        CompletionInterval="100"
                        FirstRowSelected="true"
                        MinimumPrefixLength="1"
                        OnClientItemSelected="LC_J_ProjectSiteID1_AutoCompleteExtender_Selected"
                        CompletionSetCount="10"
                        CompletionListCssClass="autocomplete_completionListElement"
                        CompletionListItemCssClass="autocomplete_listItem"
                        CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelJ_DesignationID" runat="server" Text="Joining Designation :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmDesignations
                        ID="LC_J_DesignationID1"
                        SelectedValue='<%# Bind("J_DesignationID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="DesignationID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmNewJoinings"
                        RequiredFieldErrorMessage="Joining Designation is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelJ_BasicSalary" runat="server" Text="Joining Basic Salary :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxJ_BasicSalary"
                        Text='<%# Bind("J_BasicSalary") %>'
                        runat="server"
                        ValidationGroup="hrmNewJoinings"
                        MaxLength="14"
                        Width="70px"
                        CssClass="mytxt"
                        Style="text-align: right" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderJ_BasicSalary"
                        runat="server"
                        Mask="999999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxJ_BasicSalary" />
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorJ_BasicSalary"
                        runat="server"
                        ControlToValidate="TextBoxJ_BasicSalary"
                        ControlExtender="MaskedEditExtenderJ_BasicSalary"
                        InvalidValueMessage="Invalid value for Joining Basic Salary."
                        EmptyValueMessage="Joining Basic Salary is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Joining Basic Salary."
                        EnableClientScript="true"
                        ValidationGroup="hrmNewJoinings"
                        IsValidEmpty="false"
                        MinimumValue="0.01"
                        MinimumValueBlurredText="Joining Basic Salary should be greater than zero."
                        MinimumValueMessage="*"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelJ_StatusID" runat="server" Text="Joining Status :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmStatus
                        ID="LC_J_StatusID1"
                        SelectedValue='<%# Bind("J_StatusID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="StatusID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmNewJoinings"
                        RequiredFieldErrorMessage="Joining Status is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelJ_StatusRemark" runat="server" Text="Joining Status Remark :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxJ_StatusRemark"
                        Text='<%# Bind("J_StatusRemark") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmNewJoinings"
                        ToolTip="Enter value for Joining Status Remark."
                        Width="300px" Height="40px" TextMode="MultiLine"
                        MaxLength="250" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderJ_StatusRemark"
                        runat="server"
                        WatermarkText="[Enter Joining Status Remark]"
                        TargetControlID="TextBoxJ_StatusRemark" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="Label1" runat="server" Text="Contractual :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="CheckBoxContractual"
                        Checked='<%# Bind("Contractual") %>'
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="Label2" runat="server" Text="E-Mail ID :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_EMailID"
                        Text='<%# Bind("EMailID") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmNewJoinings"
                        ToolTip="Enter E-Mail ID."
                        Width="100px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtender1"
                        runat="server"
                        WatermarkText="[E-MailID]"
                        TargetControlID="F_EMailID" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="Label3" runat="server" Text="Mobile No :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_ContactNumbers"
                        Text='<%# Bind("ContactNumbers") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmNewJoinings"
                        ToolTip="Enter Mobile No."
                        Width="100px"
                        MaxLength="100" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtender2"
                        runat="server"
                        WatermarkText="[Mobile No]"
                        TargetControlID="F_ContactNumbers" />
                    </td>
                  </tr>
                </table>
              </div>
            </EditItemTemplate>
          </asp:FormView>
        </ContentTemplate>
      </asp:UpdatePanel>
      <asp:ObjectDataSource
        ID="ObjectDataSource1"
        DataObjectTypeName="SIS.HRM.hrmNewJoinings"
        SelectMethod="GetByID"
        UpdateMethod="Update"
        DeleteMethod="Delete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmNewJoinings"
        runat="server">
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
