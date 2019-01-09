<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmNEmployees.aspx.vb" Inherits="EF_hrmNEmployees" title="Edit: Employees" %>
<asp:Content ID="CPHhrmNEmployees" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Employees"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="TBLhrmNEmployees"
            ToolType="lgNMEdit"
            UpdateAndStay="False"
            EnableDelete="False"
            ValidationGroup="hrmNEmployees"
            Skin="tbl_blue"
            runat="server" />
          <asp:FormView ID="FVhrmNEmployees"
            runat="server"
            DataKeyNames="CardNo"
            DataSourceID="ODShrmNEmployees"
            DefaultMode="Edit" CssClass="sis_formview">
            <EditItemTemplate>
              <div id="frmdiv" class="ui-widget-content minipage">
                <table>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_CardNo" runat="server" ForeColor="#CC6633" Text="CardNo :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_CardNo"
                        Text='<%# Bind("CardNo") %>'
                        ToolTip="Value of CardNo."
                        Enabled="False"
                        CssClass="mypktxt"
                        Width="56px"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_Salute" runat="server" Text="Salute :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_Salute"
                        Text='<%# Bind("Salute") %>'
                        Width="350px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="hrmNEmployees"
                        onblur="this.value=this.value.replace(/\'/g,'');"
                        ToolTip="Enter value for Salute."
                        MaxLength="50"
                        Enabled="False"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_EmployeeName" runat="server" Text="Employee Name :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_EmployeeName"
                        Text='<%# Bind("EmployeeName") %>'
                        Width="350px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="hrmNEmployees"
                        onblur="this.value=this.value.replace(/\'/g,'');"
                        ToolTip="Enter value for Employee Name."
                        MaxLength="50"
                        Enabled="False"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_AliasName" runat="server" Text="Alias Name :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_AliasName"
                        Text='<%# Bind("AliasName") %>'
                        Width="350px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="hrmNEmployees"
                        onblur="this.value=this.value.replace(/\'/g,'');"
                        ToolTip="Enter value for Alias Name."
                        MaxLength="50"
                        Enabled="False"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_Gender" runat="server" Text="Gender :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_Gender"
                        Text='<%# Bind("Gender") %>'
                        Width="7px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="hrmNEmployees"
                        onblur="this.value=this.value.replace(/\'/g,'');"
                        ToolTip="Enter value for Gender."
                        MaxLength="1"
                        Enabled="False"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_C_DateOfJoining" runat="server" Text="Date Of Joining :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_C_DateOfJoining"
                        Text='<%# Bind("C_DateOfJoining") %>'
                        Width="70px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        Enabled="False"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_C_CompanyID" runat="server" Text="Company :" /></b>
                    </td>
                    <td>
                      <LGM:LC_hrmCompanies
                        ID="F_C_CompanyID"
                        SelectedValue='<%# Bind("C_CompanyID") %>'
                        OrderBy="DisplayField"
                        DataTextField="DisplayField"
                        DataValueField="PrimaryKey"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        Width="200px"
                        CssClass="myfktxt"
                        Enabled="False"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_C_DivisionID" runat="server" Text="Division :" /></b>
                    </td>
                    <td>
                      <LGM:LC_hrmDivisions
                        ID="F_C_DivisionID"
                        SelectedValue='<%# Bind("C_DivisionID") %>'
                        OrderBy="DisplayField"
                        DataTextField="DisplayField"
                        DataValueField="PrimaryKey"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        Width="200px"
                        CssClass="myfktxt"
                        Enabled="False"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_C_OfficeID" runat="server" Text="Office :" /></b>
                    </td>
                    <td>
                      <LGM:LC_hrmOffices
                        ID="F_C_OfficeID"
                        SelectedValue='<%# Bind("C_OfficeID") %>'
                        OrderBy="DisplayField"
                        DataTextField="DisplayField"
                        DataValueField="PrimaryKey"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        Width="200px"
                        CssClass="myfktxt"
                        Enabled="False"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_C_DepartmentID" runat="server" Text="Department :" /></b>
                    </td>
                    <td>
                      <LGM:LC_hrmDepartments
                        ID="F_C_DepartmentID"
                        SelectedValue='<%# Bind("C_DepartmentID") %>'
                        OrderBy="DisplayField"
                        DataTextField="DisplayField"
                        DataValueField="PrimaryKey"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        Width="200px"
                        CssClass="myfktxt"
                        Enabled="False"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_C_ProjectSiteID" runat="server" Text="Project Site :" /></b>
                    </td>
                    <td>
                      <asp:TextBox
                        ID="F_C_ProjectSiteID"
                        CssClass="myfktxt"
                        Text='<%# Bind("C_ProjectSiteID") %>'
                        AutoCompleteType="None"
                        Width="42px"
                        onfocus="return this.select();"
                        ToolTip="Enter value for Project Site."
                        ValidationGroup="hrmNEmployees"
                        onblur="script_hrmNEmployees.validate_C_ProjectSiteID(this);"
                        runat="Server" />
                      <asp:Label
                        ID="F_C_ProjectSiteID_Display"
                        Text='<%# Eval("IDM_Projects1_Description") %>'
                        runat="Server" />
                      <AJX:AutoCompleteExtender
                        ID="ACEC_ProjectSiteID"
                        BehaviorID="B_ACEC_ProjectSiteID"
                        ContextKey=""
                        UseContextKey="true"
                        ServiceMethod="C_ProjectSiteIDCompletionList"
                        TargetControlID="F_C_ProjectSiteID"
                        EnableCaching="false"
                        CompletionInterval="100"
                        FirstRowSelected="true"
                        MinimumPrefixLength="1"
                        OnClientItemSelected="script_hrmNEmployees.ACEC_ProjectSiteID_Selected"
                        OnClientPopulating="script_hrmNEmployees.ACEC_ProjectSiteID_Populating"
                        OnClientPopulated="script_hrmNEmployees.ACEC_ProjectSiteID_Populated"
                        CompletionSetCount="10"
                        CompletionListCssClass="autocomplete_completionListElement"
                        CompletionListItemCssClass="autocomplete_listItem"
                        CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_C_DesignationID" runat="server" Text="Designation :" /></b>
                    </td>
                    <td>
                      <LGM:LC_hrmDesignations
                        ID="F_C_DesignationID"
                        SelectedValue='<%# Bind("C_DesignationID") %>'
                        OrderBy="DisplayField"
                        DataTextField="DisplayField"
                        DataValueField="PrimaryKey"
                        IncludeDefault="true"
                        DefaultText="-- Select --"
                        Width="200px"
                        CssClass="myfktxt"
                        Enabled="False"
                        runat="Server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_ActiveState" runat="server" Text="Active State :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="F_ActiveState"
                        Checked='<%# Bind("ActiveState") %>'
                        Enabled="False"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_C_DateOfReleaving" runat="server" Text="Date Of Releaving :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_C_DateOfReleaving"
                        Text='<%# Bind("C_DateOfReleaving") %>'
                        Width="70px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="hrmNEmployees"
                        Enabled="False"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_ContactNumbers" runat="server" Text="Contact Numbers :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_ContactNumbers"
                        Text='<%# Bind("ContactNumbers") %>'
                        Width="350px" Height="40px" TextMode="MultiLine"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="hrmNEmployees"
                        onblur="this.value=this.value.replace(/\'/g,'');"
                        ToolTip="Enter value for Contact Numbers."
                        MaxLength="100"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_EMailID" runat="server" Text="EMailID :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_EMailID"
                        Text='<%# Bind("EMailID") %>'
                        Width="350px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="hrmNEmployees"
                        onblur="this.value=this.value.replace(/\'/g,'');"
                        ToolTip="Enter value for EMailID."
                        MaxLength="50"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_Contractual" runat="server" Text="Contractual :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="F_Contractual"
                        Checked='<%# Bind("Contractual") %>'
                        Enabled="False"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_VPNMailExpireOn" runat="server" Text="VPN Mail Expire On :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_VPNMailExpireOn"
                        Text='<%# Bind("VPNMailExpireOn") %>'
                        Width="70px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="hrmNEmployees"
                        runat="server" />
                      <asp:Image ID="ImageButtonVPNMailExpireOn" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer" ImageUrl="~/Images/cal.png" />
                      <AJX:CalendarExtender
                        ID="CEVPNMailExpireOn"
                        TargetControlID="F_VPNMailExpireOn"
                        Format="dd/MM/yyyy"
                        runat="server" CssClass="MyCalendar" PopupButtonID="ImageButtonVPNMailExpireOn" />
                      <AJX:MaskedEditExtender
                        ID="MEEVPNMailExpireOn"
                        runat="server"
                        Mask="99/99/9999"
                        MaskType="Date"
                        CultureName="en-GB"
                        MessageValidatorTip="true"
                        InputDirection="LeftToRight"
                        ErrorTooltipEnabled="true"
                        TargetControlID="F_VPNMailExpireOn" />
                      <AJX:MaskedEditValidator
                        ID="MEVVPNMailExpireOn"
                        runat="server"
                        ControlToValidate="F_VPNMailExpireOn"
                        ControlExtender="MEEVPNMailExpireOn"
                        InvalidValueMessage="Invalid value for VPN Mail Expire On."
                        EmptyValueMessage="VPN Mail Expire On is required."
                        EmptyValueBlurredText="[Required!]"
                        Display="Dynamic"
                        TooltipMessage="Enter value for VPN Mail Expire On."
                        EnableClientScript="true"
                        ValidationGroup="hrmNEmployees"
                        IsValidEmpty="True"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="Label1" runat="server" Text="Blackberry :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="F_Blackberry"
                        Checked='<%# Bind("Blackberry") %>'
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
        ID="ODShrmNEmployees"
        DataObjectTypeName="SIS.HRM.hrmNEmployees"
        SelectMethod="GetByID"
        UpdateMethod="UZ_Update"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmNEmployees"
        runat="server">
        <SelectParameters>
          <asp:QueryStringParameter DefaultValue="0" QueryStringField="CardNo" Name="CardNo" Type="String" />
        </SelectParameters>
      </asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>
