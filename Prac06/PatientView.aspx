<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientView.aspx.cs" Inherits="Prac06.PatientView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvPatient" runat="server" AutoGenerateColumns="False" OnRowCommand="gvPatient_RowCommand">
        <Columns>
            <asp:BoundField DataField="PatientID" HeaderText="PatientID" />
            <asp:BoundField DataField="PatientName" HeaderText="PatientName" />
            <asp:ButtonField CommandName="Select" HeaderText="Select" Text="Select" />
            <asp:ButtonField CommandName="Update" HeaderText="Update" Text="Update" />
        </Columns>
</asp:GridView>
</asp:Content>
