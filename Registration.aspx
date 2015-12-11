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
<br>
<br>
<form>
<table>
<tr>
<td>Name</td><td><input type="text" name="name"></td>
</tr>
<tr>
<td>E-mail</td><td><input type="text" name="email"></td>
</tr>
<tr>
<td>Password</td><td><input type="text" name="pass"></td>
</tr>
<tr>
<td>Confirm Password</td><td><input type="text" name="cpass"></td>
</tr>

</table>
<br>
<input type="button" value="Confirm"><input type="button" value="Reset">
</asp:Content>

