
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
    <span>Please complete the form to register</span>
    <br />
    <br />
    <br />
    <div id="labels" style="float:left; display:inline-block;">
        First Name<br /><asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ErrorMessage="*Please enter your first name." ControlToValidate="TextBoxFirstName" Display="Dynamic" ForeColor="Gray"></asp:RequiredFieldValidator>
        <br />
        Last Name <br /><asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ErrorMessage="*Please enter your last name." ControlToValidate="TextBoxLastName" Display="Dynamic" ForeColor="Gray"></asp:RequiredFieldValidator>
        <br />
        User Name<br /><asp:TextBox ID="TextBoxLogin" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorlogin" runat="server" ErrorMessage="*Please enter a user name." ControlToValidate="TextBoxLogin" Display="Dynamic" ForeColor="Gray"></asp:RequiredFieldValidator>
        <br />
        E-mail<br /><asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="*Please enter an E-mail address." ControlToValidate="TextBoxEmail" Display="Dynamic" ForeColor="Gray"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ErrorMessage="*Not a valid E-mail." ControlToValidate="TextBoxEmail" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Gray"></asp:RegularExpressionValidator>
        <br />
        Password<br /><asp:TextBox ID="TextBoxPass1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPass1" runat="server" ErrorMessage="*Please enter a password." ControlToValidate="TextBoxPass1" Display="Dynamic" ForeColor="Gray"></asp:RequiredFieldValidator>
        <br />
        Confirm Password<br /><asp:TextBox ID="TextBoxPass2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPass2" runat="server" ErrorMessage="*Please enter your password again." ControlToValidate="TextBoxPass2" Display="Dynamic" ForeColor="Gray"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidatorPasswords" runat="server" ErrorMessage="*The passwords you entered do not match." ControlToCompare="TextBoxPass1" ControlToValidate="TextBoxPass2" Display="Dynamic" ForeColor="Gray"></asp:CompareValidator>
        <br />
    </div>
    
       
    <br style="clear:both;" />
<br />
&nbsp;<asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />
    <asp:Button ID="ButtonCancel" runat="server" OnClick="ButtonCancel_Click" Text="Reset" />
 
    <br />
 
</asp:Content>

