<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="Redirect.aspx.cs" Inherits="Redirect" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
    Redirecting
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
    Please wait.
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <asp:Label ID="LabelMes" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="LabelRedirect" runat="server" Text="Redirecting..."></asp:Label>
</asp:Content>

