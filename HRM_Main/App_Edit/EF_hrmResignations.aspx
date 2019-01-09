<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmResignations.aspx.vb" Inherits="EF_hrmResignations" title="Edit: Resignes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Resignes"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="ToolBar0_1"
            ToolType="lgNMEdit"
            EnableDelete="False"
            ValidationGroup="hrmResignations"
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
                        <asp:Label ID="LabelResigned" runat="server" Text="Resigned :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="CheckBoxResigned"
                        Checked='<%# Bind("Resigned") %>'
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_ResignedOn" runat="server" Text="Resigned On :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_ResignedOn"
                        Text='<%# Bind("C_ResignedOn") %>'
                        ValidationGroup="hrmResignations"
                        Width="70px"
                        CssClass="mytxt"
                        runat="server" />
                      <asp:Image ID="ImageButton1" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CalendarExtenderC_ResignedOn"
                        TargetControlID="TextBoxC_ResignedOn"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButton1" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderC_ResignedOn"
                        runat="server"
                        Mask="99/99/9999"
                        MaskType="Date"
                        CultureName="en-GB"
                        MessageValidatorTip="true"
                        InputDirection="LeftToRight"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxC_ResignedOn" />
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorC_ResignedOn"
                        runat="server"
                        ControlToValidate="TextBoxC_ResignedOn"
                        ControlExtender="MaskedEditExtenderC_ResignedOn"
                        InvalidValueMessage="Invalid value for Resigned On."
                        EmptyValueMessage="Resigned On is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Resigned On."
                        EnableClientScript="true"
                        ValidationGroup="hrmResignations"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_DateOfReleaving" runat="server" Text="Date Of Releaving :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_DateOfReleaving"
                        Text='<%# Bind("C_DateOfReleaving") %>'
                        ValidationGroup="hrmResignations"
                        Width="70px"
                        CssClass="mytxt"
                        runat="server" />
                      <asp:Image ID="ImageButton2" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CalendarExtenderC_DateOfReleaving"
                        TargetControlID="TextBoxC_DateOfReleaving"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButton2" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderC_DateOfReleaving"
                        runat="server"
                        Mask="99/99/9999"
                        MaskType="Date"
                        CultureName="en-GB"
                        MessageValidatorTip="true"
                        InputDirection="LeftToRight"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxC_DateOfReleaving" />
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorC_DateOfReleaving"
                        runat="server"
                        ControlToValidate="TextBoxC_DateOfReleaving"
                        ControlExtender="MaskedEditExtenderC_DateOfReleaving"
                        InvalidValueMessage="Invalid value for Date Of Releaving."
                        EmptyValueMessage="Date Of Releaving is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Date Of Releaving."
                        EnableClientScript="true"
                        ValidationGroup="hrmResignations"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelC_ResignedRemark" runat="server" Text="Resigned Remark :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxC_ResignedRemark"
                        Text='<%# Bind("C_ResignedRemark") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmResignations"
                        ToolTip="Enter value for Resigned Remark."
                        Width="300px" Height="40px" TextMode="MultiLine"
                        MaxLength="250" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderC_ResignedRemark"
                        runat="server"
                        WatermarkText="[Enter Resigned Remark]"
                        TargetControlID="TextBoxC_ResignedRemark" />
                      <asp:RequiredFieldValidator
                        ID="RequiredFieldValidatorC_ResignedRemark"
                        runat="server"
                        ControlToValidate="TextBoxC_ResignedRemark"
                        Text="Resigned Remark is required."
                        ErrorMessage="[Required!]"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="hrmResignations"
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
        DataObjectTypeName="SIS.HRM.hrmResignations"
        SelectMethod="GetByID"
        UpdateMethod="UZ_Update"
        DeleteMethod="Delete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmResignations"
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
