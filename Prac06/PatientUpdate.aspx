<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientUpdate.aspx.cs" Inherits="Prac06.PatientUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <table style="width: 94%;">
                <tr>
                    <td style="height: 19px; width: 115px">Patient Name:</td>
                    <td style="height: 19px">
                        <asp:TextBox ID="txtName" runat="server" Height="19px" Width="278px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Patient ID:</td>
                    <td>
                        <asp:Label ID="lblPatientID" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Gender</td>
                    <td>
                        <asp:RadioButtonList ID="rblGender" runat="server" Width="71px">
                            <asp:ListItem Value="M">Male</asp:ListItem>
                            <asp:ListItem Value="F">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Citizenship:</td>
                    <td>
                        <asp:DropDownList ID="ddlCitizenship" runat="server" Width="161px">
                            <asp:ListItem Selected="True">Singapore</asp:ListItem>
                            <asp:ListItem>Malaysia</asp:ListItem>
                            <asp:ListItem>Thailand</asp:ListItem>
                            <asp:ListItem>Brunei</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Address:</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server" Columns="2" Height="37px" TextMode="MultiLine" Width="273px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Country:</td>
                    <td>
                        <asp:DropDownList ID="ddlCountry" runat="server" Width="160px">
                            <asp:ListItem>Singapore</asp:ListItem>
                            <asp:ListItem>Malaysia</asp:ListItem>
                            <asp:ListItem>Thailand</asp:ListItem>
                            <asp:ListItem>Brunei</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Postal Code:</td>
                    <td>
                        <asp:TextBox ID="txtPostal" runat="server" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Contact Number:</td>
                    <td>
                        <asp:TextBox ID="txtContact" runat="server" Width="202px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="205px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                 <tr>
                    <td style="width: 115px">
                    </td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" />
                     </td>
                </tr>
                 <tr>
                    <td style="width: 115px">
                    </td>
                    <td></td>
                </tr>

            </table>
        </div>
    </div>

</asp:Content>
