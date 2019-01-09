<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmConfirmations.aspx.vb" Inherits="EF_hrmConfirmations" title="Edit: Employee Confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Employee Confirmation"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="ToolBar0_1"
            ToolType="lgNMEdit"
            EnableDelete="False"
            ValidationGroup="hrmConfirmations"
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
                        <asp:Label ID="LabelEmployeeName" runat="server" Text="Employee Name :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextEmployeeName" runat="server" Text='<%# Bind("EmployeeName") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_DateOfJoining" runat="server" Text="Date Of Joining :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_DateOfJoining" runat="server" Text='<%# Bind("C_DateOfJoining") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_CompanyID" runat="server" Text="Company :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_CompanyID" runat="server" Text='<%# Eval("C_CompanyIDHRM_Companies.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_CompanyIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_CompanyID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_DivisionID" runat="server" Text="Division :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_DivisionID" runat="server" Text='<%# Eval("C_DivisionIDHRM_Divisions.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_DivisionIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_DivisionID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_OfficeID" runat="server" Text="Office :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_OfficeID" runat="server" Text='<%# Eval("C_OfficeIDHRM_Offices.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_OfficeIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_OfficeID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_DepartmentID" runat="server" Text="Department :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_DepartmentID" runat="server" Text='<%# Eval("C_DepartmentIDHRM_Departments.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_DepartmentIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_DepartmentID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_ProjectSiteID" runat="server" Text="Project Site :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_ProjectSiteID" runat="server" Text='<%# Eval("C_ProjectSiteIDDCM_Projects.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_ProjectSiteIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_ProjectSiteID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_DesignationID" runat="server" Text="Designation :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_DesignationID" runat="server" Text='<%# Eval("C_DesignationIDHRM_Designations.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_DesignationIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_DesignationID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_BasicSalary" runat="server" Text="Basic Salary :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_BasicSalary" runat="server" Text='<%# Bind("C_BasicSalary") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_StatusID" runat="server" Text="Status :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_StatusID" runat="server" Text='<%# Eval("C_StatusIDHRM_Status.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_StatusIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_StatusID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_StatusRemark" runat="server" Text="Status Remark :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_StatusRemark" runat="server" Text='<%# Bind("C_StatusRemark") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_JoinngStateID" runat="server" Text="Joinng State :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_JoinngStateID" runat="server" Text='<%# Eval("C_JoinngStateIDHRM_JoiningStates.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_JoinngStateIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_JoinngStateID") %>'></asp:Label>
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
                        ValidationGroup="hrmConfirmations"
                        Width="70px"
                        CssClass="mytxt"
                        runat="server" />
                      <asp:Image ID="ImageButton1" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CalendarExtenderC_ConfirmedOn"
                        TargetControlID="TextBoxC_ConfirmedOn"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButton1" />
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
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorC_ConfirmedOn"
                        runat="server"
                        ControlToValidate="TextBoxC_ConfirmedOn"
                        ControlExtender="MaskedEditExtenderC_ConfirmedOn"
                        InvalidValueMessage="Invalid value for Confirmed On."
                        EmptyValueMessage="Confirmed On is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Confirmed On."
                        EnableClientScript="true"
                        ValidationGroup="hrmConfirmations"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_ConfirmationRemark" runat="server" Text="Confirmation Remark :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_ConfirmationRemark"
                        Text='<%# Bind("C_ConfirmationRemark") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmConfirmations"
                        ToolTip="Enter value for Confirmation Remark."
                        Width="300px" Height="40px" TextMode="MultiLine"
                        MaxLength="250" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderC_ConfirmationRemark"
                        runat="server"
                        WatermarkText="[Enter Confirmation Remark]"
                        WatermarkCssClass="watermark"
                        TargetControlID="TextBoxC_ConfirmationRemark" />
                      <asp:RequiredFieldValidator
                        ID="RequiredFieldValidatorC_ConfirmationRemark"
                        runat="server"
                        ControlToValidate="TextBoxC_ConfirmationRemark"
                        Text="Confirmation Remark is required."
                        ErrorMessage="[Required!]"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="hrmConfirmations"
                        SetFocusOnError="true" />
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
        DataObjectTypeName="SIS.HRM.hrmConfirmations"
        SelectMethod="GetByID"
        UpdateMethod="Update"
        DeleteMethod="Delete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmConfirmations"
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
