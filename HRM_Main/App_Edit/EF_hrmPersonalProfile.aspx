<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmPersonalProfile.aspx.vb" Inherits="EF_hrmPersonalProfile" title="Edit: Personal Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Personal Profile"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="ToolBar0_1"
            ToolType="lgNMEdit"
            EnableDelete="False"
            ValidationGroup="hrmPersonalProfile"
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
                      <asp:Label ID="TextEmployeeName" runat="server" Text='<%# Eval("EmployeeName") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelFatherName" runat="server" Text="Father Name :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxFatherName"
                        Text='<%# Bind("FatherName") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for Father Name."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderFatherName"
                        runat="server"
                        WatermarkText="[Enter Father Name]"
                        TargetControlID="TextBoxFatherName" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelSpouseName" runat="server" Text="Spouse Name :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxSpouseName"
                        Text='<%# Bind("SpouseName") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for Spouse Name."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderSpouseName"
                        runat="server"
                        WatermarkText="[Enter Spouse Name]"
                        TargetControlID="TextBoxSpouseName" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelPermanentAddress" runat="server" Text="Permanent Address :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxPermanentAddress"
                        Text='<%# Bind("PermanentAddress") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for Permanent Address."
                        Width="300px" Height="40px" TextMode="MultiLine"
                        MaxLength="250" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderPermanentAddress"
                        runat="server"
                        WatermarkText="[Enter Permanent Address]"
                        TargetControlID="TextBoxPermanentAddress" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelPermanentCity" runat="server" Text="Permanent City :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxPermanentCity"
                        Text='<%# Bind("PermanentCity") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for Permanent City."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderPermanentCity"
                        runat="server"
                        WatermarkText="[Enter Permanent City]"
                        TargetControlID="TextBoxPermanentCity" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelCurrentAddress" runat="server" Text="Current Address :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxCurrentAddress"
                        Text='<%# Bind("CurrentAddress") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for Current Address."
                        Width="300px" Height="40px" TextMode="MultiLine"
                        MaxLength="250" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderCurrentAddress"
                        runat="server"
                        WatermarkText="[Enter Current Address]"
                        TargetControlID="TextBoxCurrentAddress" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelCurrentCity" runat="server" Text="Current City :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxCurrentCity"
                        Text='<%# Bind("CurrentCity") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for Current City."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderCurrentCity"
                        runat="server"
                        WatermarkText="[Enter Current City]"
                        TargetControlID="TextBoxCurrentCity" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelDateOfBirth" runat="server" Text="Date Of Birth :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxDateOfBirth"
                        Text='<%# Bind("DateOfBirth") %>'
                        ValidationGroup="hrmPersonalProfile"
                        Width="70px"
                        CssClass="mytxt"
                        runat="server" />
                      <asp:Image ID="ImageButton1" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CalendarExtenderDateOfBirth"
                        TargetControlID="TextBoxDateOfBirth"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButton1" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderDateOfBirth"
                        runat="server"
                        Mask="99/99/9999"
                        MaskType="Date"
                        CultureName="en-GB"
                        MessageValidatorTip="true"
                        InputDirection="LeftToRight"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxDateOfBirth" />
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorDateOfBirth"
                        runat="server"
                        ControlToValidate="TextBoxDateOfBirth"
                        ControlExtender="MaskedEditExtenderDateOfBirth"
                        InvalidValueMessage="Invalid value for Date Of Birth."
                        EmptyValueMessage="Date Of Birth is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Date Of Birth."
                        EnableClientScript="true"
                        ValidationGroup="hrmPersonalProfile"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelBloodGroupID" runat="server" Text="Blood Group :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmBloodGroups
                        ID="LC_BloodGroupID1"
                        SelectedValue='<%# Bind("BloodGroupID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="BloodGroupID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelContactNumbers" runat="server" Text="Contact Numbers :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxContactNumbers"
                        Text='<%# Bind("ContactNumbers") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for Contact Numbers."
                        Width="300px"
                        MaxLength="100" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderContactNumbers"
                        runat="server"
                        WatermarkText="[Enter Contact Numbers]"
                        TargetControlID="TextBoxContactNumbers" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelOfficeFileNumber" runat="server" Text="Office File Number :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxOfficeFileNumber"
                        Text='<%# Bind("OfficeFileNumber") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for Office File Number."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderOfficeFileNumber"
                        runat="server"
                        WatermarkText="[Enter Office File Number]"
                        TargetControlID="TextBoxOfficeFileNumber" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelPFNumber" runat="server" Text="PF Number :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxPFNumber"
                        Text='<%# Bind("PFNumber") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for PF Number."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderPFNumber"
                        runat="server"
                        WatermarkText="[Enter PF Number]"
                        TargetControlID="TextBoxPFNumber" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelESINumber" runat="server" Text="ESI Number :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxESINumber"
                        Text='<%# Bind("ESINumber") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for ESI Number."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderESINumber"
                        runat="server"
                        WatermarkText="[Enter ESI Number]"
                        TargetControlID="TextBoxESINumber" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelPAN" runat="server" Text="PAN :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxPAN"
                        Text='<%# Bind("PAN") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for PAN."
                        Width="100px"
                        MaxLength="20" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderPAN"
                        runat="server"
                        WatermarkText="[Enter PAN]"
                        TargetControlID="TextBoxPAN" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelEMailID" runat="server" Text="E-Mail :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxEMailID"
                        Text='<%# Bind("EMailID") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmPersonalProfile"
                        ToolTip="Enter value for E-Mail."
                        Width="200px"
                        MaxLength="50" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderEMailID"
                        runat="server"
                        WatermarkText="[Enter E-Mail]"
                        TargetControlID="TextBoxEMailID" />
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
        DataObjectTypeName="SIS.HRM.hrmPersonalProfile"
        SelectMethod="GetByID"
        UpdateMethod="Update"
        DeleteMethod="Delete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmPersonalProfile"
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
