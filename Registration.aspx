<%@ Page Title="" Language="C#" MasterPageFile="~/Template.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
    Registration
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
    User Registration
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    Please complete the form to register
<br />
<br />

<table>
<tr>
<td>First Name</td><td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" ForeColor="Gray"></asp:Label>
    </td>
</tr>
<tr>
<td>Last Name</td><td>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" ForeColor="Gray"></asp:Label>
    </td>
</tr>
<tr>
<td>User Name</td><td>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" ForeColor="Gray"></asp:Label>
    </td>
</tr>
<tr>
<td>E-mail</td><td>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" ForeColor="Gray"></asp:Label>
    </td>
</tr>
<tr>
<td>Password</td><td>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:Label ID="Label5" runat="server" ForeColor="Gray"></asp:Label>
    </td>
</tr>
<tr>
<td>Confirm Password</td><td>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" ForeColor="Gray"></asp:Label>
    </td>
</tr>

</table>
<br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
 
</asp:Content>

