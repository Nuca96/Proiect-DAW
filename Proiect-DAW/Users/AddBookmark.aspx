<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddBookmark.aspx.cs" Inherits="Proiect_DAW.Users.AddBookmark" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <th>Adaugî o rețetî!</th> 
        </tr>
        <tr>
            <td>Denumiri:</td>
            <td>
                <asp:TextBox ID="IdName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Categorii:</td>
            <td>
                <asp:DropDownList ID="IdCategory" runat="server" DataSourceID="DefaultConnection" DataTextField="Name" DataValueField="Name">
                </asp:DropDownList>
                <asp:SqlDataSource ID="DefaultConnection" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Name] FROM [Categories]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>Adaugî șî o pozî:</td>
            <td>
                <asp:FileUpload ID="IdPhoto" runat="server" Width="299px" />
            </td>
        </tr>
        <tr>
            <td>Cum o fași:</td>
            <td>
                <asp:TextBox ID="IdDescription" runat="server" Height="149px" Width="293px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Gata-i!" />
        <br />
        <asp:Label ID="message" runat="server"></asp:Label>
    </div>
</asp:Content>
