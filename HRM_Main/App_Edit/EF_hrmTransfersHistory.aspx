<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_hrmTransfersHistory.aspx.vb" Inherits="EF_hrmTransfersHistory" title="Edit: Process Transfers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabeltaApprovalWFTypes" runat="server" Text="&nbsp;Edit: Process Transfers"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLtaApprovalWFTypes" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="ToolBar0_1"
            ToolType="lgNMEdit"
            EnableDelete="False"
            ValidationGroup="hrmTransfersHistory"
            SearchContext="hrmTransfersHistory"
            runat="server" />
          <asp:FormView ID="FormView1"
            runat="server"
            DataKeyNames="TransferID"
            DataSourceID="ObjectDataSource1"
            DefaultMode="Edit" CssClass="sis_formview">
            <EditItemTemplate>
              <div id="frmdiv" class="ui-widget-content minipage">
                <table>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Create Event :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="Label2" runat="server" ForeColor="Red" Text='<%# Bind("CreateEvent") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelTransferID" runat="server" Text="TransferID :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextTransferID" runat="server" Text='<%# Bind("TransferID") %>' />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelCardNo" runat="server" Text="CardNo :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextCardNo" runat="server" Text='<%# Eval("CardNoHRM_Employees.EmployeeName") %>'></asp:Label>&nbsp;&nbsp;-
                      <asp:Label ID="TextCardNoHidden"  runat="server" Text='<%# Bind("CardNo") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelCompanyID" runat="server" Text="Company :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextCompanyID" runat="server" Text='<%# Eval("CompanyIDHRM_Companies.Description") %>'></asp:Label>
                      <asp:Label ID="TextCompanyIDHidden" Style="display: none" runat="server" Text='<%# Bind("CompanyID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelDivisionID" runat="server" Text="Division :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextDivisionID" runat="server" Text='<%# Eval("DivisionIDHRM_Divisions.Description") %>'></asp:Label>
                      <asp:Label ID="TextDivisionIDHidden" Style="display: none" runat="server" Text='<%# Bind("DivisionID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelOfficeID" runat="server" Text="Office :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextOfficeID" runat="server" Text='<%# Eval("OfficeIDHRM_Offices.Description") %>'></asp:Label>
                      <asp:Label ID="TextOfficeIDHidden" Style="display: none" runat="server" Text='<%# Bind("OfficeID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelDepartmentID" runat="server" Text="Department :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextDepartmentID" runat="server" Text='<%# Eval("DepartmentIDHRM_Departments.Description") %>'></asp:Label>
                      <asp:Label ID="TextDepartmentIDHidden" Style="display: none" runat="server" Text='<%# Bind("DepartmentID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelProjectSiteID" runat="server" Text="Project Site :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextProjectSiteID" runat="server" Text='<%# Bind("ProjectSiteID") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelTransferedOn" runat="server" Text="Transfered On :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextTransferedOn" runat="server" Text='<%# Bind("TransferedOn") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelRemarks" runat="server" Text="Remarks :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextRemarks" runat="server" Text='<%# Bind("Remarks") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelActiveState" runat="server" Text="Active State :" /></b>
                    </td>
                    <td>
                      <asp:Label ID="TextActiveState" runat="server" Text='<%# Bind("ActiveState") %>'></asp:Label>
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelExecuted" runat="server" Text="Execute :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="CheckBoxExecuted"
                        Checked='<%# Bind("Executed") %>'
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="LabelCancelled" runat="server" Text="Cancel :" /></b>
                    </td>
                    <td>
                      <asp:CheckBox ID="CheckBoxCancelled"
                        Checked='<%# Bind("Cancelled") %>'
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
        DataObjectTypeName="SIS.HRM.hrmTransfersHistory"
        SelectMethod="GetByID"
        UpdateMethod="UZ_Update"
        DeleteMethod="Delete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.HRM.hrmTransfersHistory"
        runat="server">
        <SelectParameters>
          <asp:QueryStringParameter DefaultValue="0" QueryStringField="TransferID" Name="TransferID" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
          <asp:Parameter Name="TransferID" Type="Int32" />
        </UpdateParameters>
      </asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>
