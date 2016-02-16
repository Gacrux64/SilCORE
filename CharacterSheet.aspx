<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CharacterSheet.aspx.cs" Inherits="CharacterSheet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
    Character Sheet
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
    Character Sheet
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <asp:Label ID="LabelName" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <div style="float:left;width:50%;"">
        <span>Primary Stats:</span>
        <br />
        <br />
        <asp:Label ID="LabelAGI" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelAPP" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelBLD" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelCRE" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelFIT" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <span>Secondary Stats:</span>
        <br />
        <br />
        <asp:Label ID="LabelSTR" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelHEA" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelSTA" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelUD" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelAD" runat="server" Text=""></asp:Label>
    </div>
    <div style="float:left;width:50%;">
        <br />
        <br />
        <asp:Label ID="LabelINF" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelKNO" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelPER" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelPSY" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelWIL" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="LabelFW" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelDW" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelID" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="LabelSS" runat="server" Text=""></asp:Label>
    </div>
    <br style="clear:both;" />
    <hr />
    <br />
    <span>Skills: </span>
    <br />
    <br />
    <asp:Label ID="LabelSkills" runat="server" Text=""></asp:Label>
    <hr />
    <br />
    <div style="float:left;width:50%;"">
        <span>Perks: </span>
        <br />
        <br />
        <asp:Label ID="LabelPerks" runat="server" Text=""></asp:Label>
    </div>
    <div style="float:left;width:50%;">
        <span>Flaws: </span>
        <br />
        <br />
        <asp:Label ID="LabelFlaws" runat="server" Text=""></asp:Label>
    </div>
    <br style="clear:both;" />
    <hr />
    <br />
    <span>Misc: </span>
    <br />
    <br />
    <asp:Label ID="LabelED" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="LabelXP" runat="server" Text=""></asp:Label>
</asp:Content>

