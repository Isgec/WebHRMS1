<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_UpdateEmployee.aspx.vb" Inherits="GF_UpdateEmployee" title="Update: Employee" %>
<asp:Content ID="CPHnewHrmEmployees" ContentPlaceHolderID="cph1" runat="Server">
  <style>
    .err{
      white-space:nowrap;
    }
  </style>
  <div class="ui-widget-content page">
    <div class="caption">
      <asp:Label ID="LabelnewHrmEmployees" runat="server" Text="&nbsp;Update: Employee"></asp:Label>
    </div>
    <div class="pagedata" style="min-height:300px;">
      <LGM:ToolBar0
        ID="TBLdummy"
        ToolType="lgNReport"
        runat="server" />
      <br />
      <br />
      <div id="divFU" runat="server">
        <asp:Button ID="cmdDownload" runat="server" Text="Download" />
        <asp:Label ID="LUpload" runat="server" Text="Upload : " ForeColor="Black" Font-Bold="true"></asp:Label>
        <asp:FileUpload ID="F_Upload" runat="server" />
        <asp:Button ID="cmdUpload" runat="server" Text=" Upload " />
      </div>
      <div id="divData" runat="server" visible="false">

      </div>

    </div>
  </div>
</asp:Content>
