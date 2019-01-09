<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmTransfers.aspx.vb" Inherits="EF_hrmTransfers" title="Edit: Transfers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Transfers"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="ToolBar0_1"
            ToolType="lgNMEdit"
            EnableDelete="False"
            ValidationGroup="hrmTransfers"
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
                        <asp:Label ID="LabelC_CompanyID" runat="server" Text="Current Company :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_CompanyID" runat="server" Text='<%# Eval("C_CompanyIDHRM_Companies.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_CompanyIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_CompanyID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_DivisionID" runat="server" Text="Current Division :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_DivisionID" runat="server" Text='<%# Eval("C_DivisionIDHRM_Divisions.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_DivisionIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_DivisionID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_OfficeID" runat="server" Text="Current Office :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_OfficeID" runat="server" Text='<%# Eval("C_OfficeIDHRM_Offices.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_OfficeIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_OfficeID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_DepartmentID" runat="server" Text="Current Department :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_DepartmentID" runat="server" Text='<%# Eval("C_DepartmentIDHRM_Departments.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_DepartmentIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_DepartmentID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_ProjectSiteID" runat="server" Text="Current Project Site :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextC_ProjectSiteID" runat="server" Text='<%# Eval("C_ProjectSiteIDDCM_Projects.Description") %>'></asp:Label>
                      <asp:Label ID="TextC_ProjectSiteIDHidden" Style="display: none" runat="server" Text='<%# Bind("C_ProjectSiteID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelU_UnderTransfer" runat="server" Text="Under Transfer :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="CheckBoxU_UnderTransfer"
                        Checked='<%# Bind("U_UnderTransfer") %>'
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelU_CompanyID" runat="server" Text="New Company :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmCompanies
                        ID="LC_U_CompanyID1"
                        SelectedValue='<%# Bind("U_CompanyID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="CompanyID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmTransfers"
                        RequiredFieldErrorMessage="New Company is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelU_DivisionID" runat="server" Text="New Division :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmDivisions
                        ID="LC_U_DivisionID1"
                        SelectedValue='<%# Bind("U_DivisionID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="DivisionID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmTransfers"
                        RequiredFieldErrorMessage="New Division is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelU_OfficeID" runat="server" Text="New Office :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmOffices
                        ID="LC_U_OfficeID1"
                        SelectedValue='<%# Bind("U_OfficeID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="OfficeID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmTransfers"
                        RequiredFieldErrorMessage="New Office is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelU_DepartmentID" runat="server" Text="New Department :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmDepartments
                        ID="LC_U_DepartmentID1"
                        SelectedValue='<%# Bind("U_DepartmentID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="DepartmentID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        ValidationGroup="hrmTransfers"
                        RequiredFieldErrorMessage="New Department is required."
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelU_ProjectSiteID" runat="server" Text="New Project Site :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmProjects
                        ID="LC_U_ProjectSiteID1"
                        SelectedValue='<%# Bind("U_ProjectSiteID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="ProjectCode"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelU_ActiveState" runat="server" Text="New Active State :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="CheckBoxU_ActiveState"
                        Checked='<%# Bind("U_ActiveState") %>'
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_TransferedOn" runat="server" Text="Transfered On :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_TransferedOn"
                        Text='<%# Bind("C_TransferedOn") %>'
                        ValidationGroup="hrmTransfers"
                        Width="70px"
                        CssClass="mytxt"
                        runat="server" />
                      <asp:Image ID="ImageButton1" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CalendarExtenderC_TransferedOn"
                        TargetControlID="TextBoxC_TransferedOn"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButton1" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderC_TransferedOn"
                        runat="server"
                        Mask="99/99/9999"
                        MaskType="Date"
                        CultureName="en-GB"
                        MessageValidatorTip="true"
                        InputDirection="LeftToRight"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxC_TransferedOn" />
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorC_TransferedOn"
                        runat="server"
                        ControlToValidate="TextBoxC_TransferedOn"
                        ControlExtender="MaskedEditExtenderC_TransferedOn"
                        InvalidValueMessage="Invalid value for Transfered On."
                        EmptyValueMessage="Transfered On is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Transfered On."
                        EnableClientScript="true"
                        ValidationGroup="hrmTransfers"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_TransferRemark" runat="server" Text="Transfer Remark :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_TransferRemark"
                        Text='<%# Bind("C_TransferRemark") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmTransfers"
                        ToolTip="Enter value for Transfer Remark."
                        Width="300px" Height="40px" TextMode="MultiLine"
                        MaxLength="250" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderC_TransferRemark"
                        runat="server"
                        WatermarkText="[Enter Transfer Remark]"
                        TargetControlID="TextBoxC_TransferRemark" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="Label1" ForeColor="Red" runat="server" Text="CREATE HRIS EVENT :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="F_CreateEvent"
                        Checked='<%# Bind("CreateEvent") %>'
                        runat="server" />
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
        DataObjectTypeName="SIS.HRM.hrmTransfers"
        SelectMethod="GetByID"
        UpdateMethod="UZ_Update"
        DeleteMethod="Delete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmTransfers"
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
