<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmOfficialProfile.aspx.vb" Inherits="EF_hrmOfficialProfile" title="Edit: Official Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Official Profile"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="ToolBar0_1"
            ToolType="lgNMEdit"
            EnableDelete="False"
            ValidationGroup="hrmOfficialProfile"
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
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelWorkingAreaID" runat="server" Text="Working Area :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmWorkingAreas
                        ID="LC_WorkingAreaID1"
                        SelectedValue='<%# Bind("WorkingAreaID") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="WorkingAreaID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelFunctionalStatusID1" runat="server" Text="Functional Status 1 :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmFunctionalStatus1
                        ID="LC_FunctionalStatusID11"
                        SelectedValue='<%# Bind("FunctionalStatusID1") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="FunctionalStatusID1"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelFunctionalStatusID2" runat="server" Text="Functional Status 2 :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmFunctionalStatus2
                        ID="LC_FunctionalStatusID21"
                        SelectedValue='<%# Bind("FunctionalStatusID2") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="FunctionalStatusID2"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelFunctionalStatusID3" runat="server" Text="Functional Status 3 :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmFunctionalStatus3
                        ID="LC_FunctionalStatusID31"
                        SelectedValue='<%# Bind("FunctionalStatusID3") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="FunctionalStatusID3"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelFunctionalStatusID4" runat="server" Text="Functional Status 4 :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmFunctionalStatus4
                        ID="LC_FunctionalStatusID41"
                        SelectedValue='<%# Bind("FunctionalStatusID4") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="FunctionalStatusID4"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelCareerStartedOn" runat="server" Text="Career Started On :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxCareerStartedOn"
                        Text='<%# Bind("CareerStartedOn") %>'
                        ValidationGroup="hrmOfficialProfile"
                        Width="70px"
                        CssClass="mytxt"
                        runat="server" />
                      <asp:Image ID="ImageButton1" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CalendarExtenderCareerStartedOn"
                        TargetControlID="TextBoxCareerStartedOn"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButton1" />
                      <AJX:MaskedEditExtender
                        ID="MaskedEditExtenderCareerStartedOn"
                        runat="server"
                        Mask="99/99/9999"
                        MaskType="Date"
                        CultureName="en-GB"
                        MessageValidatorTip="true"
                        InputDirection="LeftToRight"
                        ErrorTooltipEnabled="true"
                        TargetControlID="TextBoxCareerStartedOn" />
                      <AJX:MaskedEditValidator
                        ID="MaskedEditValidatorCareerStartedOn"
                        runat="server"
                        ControlToValidate="TextBoxCareerStartedOn"
                        ControlExtender="MaskedEditExtenderCareerStartedOn"
                        InvalidValueMessage="Invalid value for Career Started On."
                        EmptyValueMessage="Career Started On is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for Career Started On."
                        EnableClientScript="true"
                        ValidationGroup="hrmOfficialProfile"
                        IsValidEmpty="false"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelEducationDetails" runat="server" Text="Education Details :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxEducationDetails"
                        Text='<%# Bind("EducationDetails") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmOfficialProfile"
                        ToolTip="Enter value for Education Details."
                        Width="300px" Height="40px" TextMode="MultiLine"
                        MaxLength="250" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderEducationDetails"
                        runat="server"
                        WatermarkText="[Enter Education Details]"
                        TargetControlID="TextBoxEducationDetails" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelQualificationID1" runat="server" Text="Qualification 1 :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmQualifications
                        ID="LC_QualificationID11"
                        SelectedValue='<%# Bind("QualificationID1") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="QualificationID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelQualificationYear1" runat="server" Text="QualificationYear1 :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxQualificationYear1"
                        Text='<%# Bind("QualificationYear1") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmOfficialProfile"
                        ToolTip="Enter value for QualificationYear1."
                        Width="60px"
                        MaxLength="4" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderQualificationYear1"
                        runat="server"
                        WatermarkText="[Enter QualificationYear1]"
                        TargetControlID="TextBoxQualificationYear1" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelQualificationID2" runat="server" Text="Qualification 2 :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmQualifications
                        ID="LC_QualificationID21"
                        SelectedValue='<%# Bind("QualificationID2") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="QualificationID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelQualificationYear2" runat="server" Text="QualificationYear2 :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="TextBoxQualificationYear2"
                        Text='<%# Bind("QualificationYear2") %>'
                        CssClass="mytxt"
                        runat="server"
                        ValidationGroup="hrmOfficialProfile"
                        ToolTip="Enter value for QualificationYear2."
                        Width="60px"
                        MaxLength="4" />
                      <AJX:TextBoxWatermarkExtender
                        ID="TextBoxWatermarkExtenderQualificationYear2"
                        runat="server"
                        WatermarkText="[Enter QualificationYear2]"
                        TargetControlID="TextBoxQualificationYear2" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright" style="padding-top: 15px;">
                      <b>
                        <asp:Label ID="LabelIncrementCompany" runat="server" Text="Increment Company :" /></b>
                    </td>
                    <td style="padding-top: 15px;">
                      <LGM:LC_hrmCompanies
                        ID="LC_IncrementCompany1"
                        SelectedValue='<%# Bind("IncrementCompany") %>'
                        OrderBy="Description"
                        DataTextField="Description"
                        DataValueField="CompanyID"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        CssClass="myddl"
                        runat="Server" />
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
        DataObjectTypeName="SIS.HRM.hrmOfficialProfile"
        SelectMethod="GetByID"
        UpdateMethod="Update"
        DeleteMethod="Delete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmOfficialProfile"
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
