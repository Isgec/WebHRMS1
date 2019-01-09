<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmEmployeesGeneral.aspx.vb" Inherits="EF_hrmEmployeesGeneral" title="Edit: Employees Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Employees Master"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="ToolBar0_1"
            ToolType="lgNMEdit"
            EnableDelete="False"
            ValidationGroup="hrmEmployeesGeneral"
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
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelSalute" runat="server" Text="Salute :" /></b>
                    </td>
                    <td>
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
                        ValidationGroup="hrmEmployeesGeneral"
                        ToolTip="Enter value for Employee Name."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderEmployeeName"
                        runat="server"
                        WatermarkText="[Enter Employee Name]"
                        WatermarkCssClass="watermark"
                        TargetControlID="TextBoxEmployeeName" />
                      <asp:RequiredFieldValidator
                        ID="RequiredFieldValidatorEmployeeName"
                        runat="server"
                        ControlToValidate="TextBoxEmployeeName"
                        Text="Employee Name is required."
                        ErrorMessage="[Required!]"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="hrmEmployeesGeneral"
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
                        ValidationGroup="hrmEmployeesGeneral"
                        ToolTip="Enter value for Alias Name."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderAliasName"
                        runat="server"
                        WatermarkText="[Enter Alias Name]"
                        WatermarkCssClass="watermark"
                        TargetControlID="TextBoxAliasName" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelGender" runat="server" Text="Gender :" /></b>
                    </td>
                    <td>
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
                        ValidationGroup="hrmEmployeesGeneral"
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
                        ValidationGroup="hrmEmployeesGeneral"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelC_CompanyID" runat="server" Text="Present Company :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmCompanies
                        ID="LC_C_CompanyID1"
                        SelectedValue='<%# Bind("C_CompanyID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="CompanyID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelC_DivisionID" runat="server" Text="Present Division :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmDivisions
                        ID="LC_C_DivisionID1"
                        SelectedValue='<%# Bind("C_DivisionID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="DivisionID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelC_OfficeID" runat="server" Text="Present Office :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmOffices
                        ID="LC_C_OfficeID1"
                        SelectedValue='<%# Bind("C_OfficeID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="OfficeID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelC_DepartmentID" runat="server" Text="Present Department :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmDepartments
                        ID="LC_C_DepartmentID1"
                        SelectedValue='<%# Bind("C_DepartmentID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="DepartmentID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright"><b>Present Project Site :</b></td>
                    <td>
                      <asp:TextBox
                        ID="LC_C_ProjectSiteID1"
                        CssClass="mytxt"
                        Width="40px"
                        Text='<%# Bind("C_ProjectSiteID") %>'
                        AutoCompleteType="None"
                        Style="display: none"
                        runat="Server" />
                      <asp:TextBox
                        ID="LC_C_ProjectSiteIDDescription1"
                        Text='<%# Bind("C_ProjectSiteIDDescription") %>'
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        Width="200px"
                        AutoCompleteType="None"
                        ToolTip="Enter value for Present Project Site."
                        runat="Server" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderC_ProjectSiteID"
                        runat="server"
                        WatermarkText="[Enter Present Project Site]"
                        WatermarkCssClass="watermark"
                        TargetControlID="LC_C_ProjectSiteIDDescription1" />
                      <AJX:AutoCompleteExtender
                        ID="LC_C_ProjectSiteID1_AutoCompleteExtender"
                        ServiceMethod="C_ProjectSiteIDCompletionList"
                        TargetControlID="LC_C_ProjectSiteIDDescription1"
                        CompletionInterval="100"
                        FirstRowSelected="true"
                        MinimumPrefixLength="1"
                        OnClientItemSelected="LC_C_ProjectSiteID1_AutoCompleteExtender_Selected"
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
                        <asp:Label ID="LabelC_DesignationID" runat="server" Text="Present Designation :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmDesignations
                        ID="LC_C_DesignationID1"
                        SelectedValue='<%# Bind("C_DesignationID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="DesignationID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_BasicSalary" runat="server" Text="Present Basic Salary :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_BasicSalary"
                        Text='<%# Bind("C_BasicSalary") %>'
                        runat="server"
                        ValidationGroup="hrmEmployeesGeneral"
                        MaxLength="14"
                        Width="70px"
                        CssClass="mytxt"
                        Style="text-align: right" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderC_BasicSalary"
                        runat="server"
                        Mask="999999999999.99"
                        AcceptNegative="Left"
                        MaskType="Number"
                        MessageValidatorTip="true"
                        InputDirection="RightToLeft"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxC_BasicSalary" />
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorC_BasicSalary"
                        runat="server"
                        ControlToValidate="TextBoxC_BasicSalary"
                        ControlExtender="MaskedEditExtenderC_BasicSalary"
                        InvalidValueMessage="Invalid value for Present Basic Salary."
                        EmptyValueMessage="Present Basic Salary is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Present Basic Salary."
                        EnableClientScript="true"
                        ValidationGroup="hrmEmployeesGeneral"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelC_StatusID" runat="server" Text="Present Status :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmStatus
                        ID="LC_C_StatusID1"
                        SelectedValue='<%# Bind("C_StatusID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="StatusID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelConfirmed" runat="server" Text="Confirmed :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="CheckBoxConfirmed"
                        Checked='<%# Bind("Confirmed") %>'
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_ConfirmedOn" runat="server" Text="Confirmed On :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_ConfirmedOn"
                        Text='<%# Bind("C_ConfirmedOn") %>'
                        ValidationGroup="hrmEmployeesGeneral"
                        Width="70px"
                        CssClass="mytxt"
                        runat="server" />
                      <asp:Image ID="ImageButton2" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CalendarExtenderC_ConfirmedOn"
                        TargetControlID="TextBoxC_ConfirmedOn"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButton2" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderC_ConfirmedOn"
                        runat="server"
                        Mask="99/99/9999"
                        MaskType="Date"
                        CultureName="en-GB"
                        MessageValidatorTip="true"
                        InputDirection="LeftToRight"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxC_ConfirmedOn" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelEMailID" runat="server" Text="E-Mail-ID :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxEMailID"
                        Text='<%# Bind("EMailID") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmEmployeesGeneral"
                        ToolTip="Enter value for E-Mail-ID."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderEMailID"
                        runat="server"
                        WatermarkText="[Enter E-Mail-ID]"
                        WatermarkCssClass="watermark"
                        TargetControlID="TextBoxEMailID" />
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
        DataObjectTypeName="SIS.HRM.hrmEmployeesGeneral"
        SelectMethod="GetByID"
        UpdateMethod="UZ_Update"
        DeleteMethod="Delete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmEmployeesGeneral"
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
