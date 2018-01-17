<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="Proiect_DAW.Admin.UserMgmt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Da, ești admin. Ti crez&#39; șmecher?</p>
    <div>
        Adaugă o categorie:
        <asp:TextBox ID="TextCategory" runat="server"></asp:TextBox>
        <asp:Button ID="AddCategory" runat="server" OnClick="AddCategory_Click" Text="Adaug!" />
        <br />
        Adaugă o etichetă:
        <asp:TextBox ID="TextTag" runat="server"></asp:TextBox>
        <asp:Button ID="AddTag" runat="server" OnClick="AddTag_Click" Text="Adaug!" />
        <br />
        <asp:Label ID="message" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
