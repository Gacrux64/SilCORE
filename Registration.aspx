
<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

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
<br />
    <div id="labels" style="float:left; display:inline-block;">
        First Name<br /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="fnameAlert" runat="server" ForeColor="Gray"></asp:Label>
        <br />
        Last Name <br /><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Label ID="lnameAlert" runat="server" ForeColor="Gray"></asp:Label>
        <br />
        User Name<br /><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Label ID="usernameAlert" runat="server" ForeColor="Gray"></asp:Label>
        <br />
        E-mail<br /><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:Label ID="emailAlert" runat="server" ForeColor="Gray"></asp:Label>
        <br />
        Password<br /><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:Label ID="passAlert" runat="server" ForeColor="Gray"></asp:Label>
        <br />
        Confirm Password<br /><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <asp:Label ID="confpassAlert" runat="server" ForeColor="Gray"></asp:Label>
        <br />
    </div>
    
       
    <br style="clear:both;" />
<br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
 
    <br />
 
</asp:Content>

