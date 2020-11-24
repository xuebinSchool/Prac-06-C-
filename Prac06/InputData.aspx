<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InputData.aspx.cs" Inherits="Prac06.InputData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1 class="H1">Input Patient Data</h1>
        <table style="width: 100%;">
            <tr>
                <td>Patient Name:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="272px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Patient ID: </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server" Width="270px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender:</td>
                <td>
                    <asp:RadioButtonList ID="rbtGender" runat="server">
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>
                    </asp:RadioButtonList>
                    </td>
            </tr>
             <tr>
                <td>Citizenship:</td>
                <td>
                    <asp:DropDownList ID="ddlCitizenship" runat="server" Width="169px">
                         <asp:ListItem Value="Singapore">Singapore</asp:ListItem>
                        <asp:ListItem Value="Alaska">Alaska</asp:ListItem>
                        <asp:ListItem Value="Fuji">Fuji</asp:ListItem>
                        <asp:ListItem Value="USSR">USSR</asp:ListItem>
                        <asp:ListItem Value="Peru">Peru</asp:ListItem>
                        <asp:ListItem Value="Argentina">Argentina</asp:ListItem>
                    </asp:DropDownList>
                 </td>
            </tr>
             <tr>
                <td>Address:</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" Columns="3" Rows="3" TextMode="MultiLine" Width="282px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td>Country:</td>
                <td>
                    <asp:DropDownList ID="ddlCountry" runat="server" Width="169px">
                        <asp:ListItem Value="Singapore">Singapore</asp:ListItem>
                        <asp:ListItem Value="Alaska">Alaska</asp:ListItem>
                        <asp:ListItem Value="Fuji">Fuji</asp:ListItem>
                        <asp:ListItem Value="USSR">USSR</asp:ListItem>
                        <asp:ListItem Value="Peru">Peru</asp:ListItem>
                        <asp:ListItem Value="Argentina">Argentina</asp:ListItem>
                    </asp:DropDownList>
                 </td>
            </tr>
             <tr>
                <td>Postal Code:</td>
                <td>
                    <asp:TextBox ID="txtPostal" runat="server" Width="272px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td>Contact Number:</td>
                <td>
                    <asp:TextBox ID="txtContact" runat="server" Width="272px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="357px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                 <td>
                     <asp:Label ID="lblMessage" runat="server" Text="" CssClass="H1"></asp:Label>
                 </td>
                 <td>

                 </td>
            </tr>
             <tr>
               <td>

               </td>
                 <td>
                     <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                     <asp:Button ID="btnClear" runat="server" Text="Clear" />
                 </td>
            </tr>
        </table>   
    </div>
</asp:Content>
