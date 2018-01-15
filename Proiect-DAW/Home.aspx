<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Proiect_DAW.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:TextBox ID="TBSearch" runat="server" Width="328px"></asp:TextBox>&nbsp;
        <asp:Button ID="BSearch" runat="server" Text="Cautî șeva!"  OnClick="BSearch_Click" />
    </div>
    <div>
        Aci urmeazî sî fii pusi chestii interesanti
    </div>
</asp:Content>
