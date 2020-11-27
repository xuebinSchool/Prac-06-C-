<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prac06._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Input Patient Data below here</h1>
        <p class="lead">Yup its right below here</p>
        <p>Just go down once more</p>
    </div>
    <div class="container">
        <div class="row">
            <table style="width: 94%;">
                <tr>
                    <td style="height: 19px; width: 115px">Patient Name:</td>
                    <td style="height: 19px">
                        <asp:TextBox ID="TextBox1" runat="server" Height="19px" Width="278px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Patient ID:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="276px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Gender</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="M">Male</asp:ListItem>
                            <asp:ListItem Value="F">Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 115px">Citizenship:</td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 115px"></td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 115px"></td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 115px"></td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 115px"></td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 115px"></td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width: 115px"></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>

</asp:Content>
