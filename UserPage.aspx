<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="UserPage.aspx.cs" Inherits="UserPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
    SilCORE Character Builder: User Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
    Account
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <div style="float:left;width:50%;">  
        <asp:label ID="AccountCharacters" runat="server" text="Your Characters:"></asp:label>
        <br />
        <br />
        <asp:dropdownlist ID="DDLCharacterList" runat="server" DataSourceID="SQLUserCharacters" DataTextField="CHARACTER_NAME" DataValueField="CHARACTER_ID" AutoPostBack="True" AppendDataBoundItems="True" OnSelectedIndexChanged="DDLCharacterList_SelectedIndexChanged">
            <asp:ListItem>Select a character</asp:ListItem>
        </asp:dropdownlist>
        <asp:sqldatasource id="SQLUserCharacters" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringSilCORE %>" SelectCommand="SELECT [CHARACTER_ID], [CHARACTER_NAME], [CHARACTER_AGI], [CHARACTER_APP], [CHARACTER_BLD], [CHARACTER_CRE], [CHARACTER_FIT], [CHARACTER_INF], [CHARACTER_KNO], [CHARACTER_PER], [CHARACTER_PSY], [CHARACTER_WIL], [CHARACTER_EMERGENCY_DICE], [CHARACTER_XP] FROM [CHARACTER] WHERE ([CHARACTER_USER_ID] = @CHARACTER_USER_ID)">
            <SelectParameters>
                <asp:SessionParameter Name="CHARACTER_USER_ID" SessionField="user" Type="Int32" />
            </SelectParameters>
        </asp:sqldatasource>
        <br />
        <br />
        <asp:button ID="NewCharButton" runat="server" text="Create New" OnClick="NewCharButton_Click" />
        <br />
        <br />
        <div runat="server" id="AdminPanel">
            <asp:label ID="LabelAdminPanel" runat="server" text="Admin Panel: "></asp:label>
            <br />
            <a href="Reports.aspx">Reports</a>
            <br />
            <asp:button ID="MakeAdminButton" runat="server" text="Set Administrator" OnClick="MakeAdminButton_Click" />
            <br />
            <div id="SetAdminDiv" runat="server" visible="false">
                <asp:label ID="UserAdminLevelMessage" runat="server" text=""></asp:label>
                <br />
                <asp:label ID="LabelUsers" runat="server" text="User: "></asp:label>
                <br />
                <asp:dropdownlist ID="DDLUsers" runat="server" DataSourceID="SQLUsers" DataTextField="USER_LOGIN" DataValueField="USER_ID" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DDLUsers_SelectedIndexChanged">
                    <asp:ListItem>Select a user</asp:ListItem>
                </asp:dropdownlist>
                <asp:sqldatasource id="SQLUsers" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringSilCORE %>" SelectCommand="SELECT [USER_ID], [USER_LOGIN], [USER_ADMIN] FROM [USER_INFO]">
                </asp:sqldatasource>
                <br />
                <asp:label id="LableUserAdmin" runat="server" width="89" text="Admin: "></asp:label>
                <asp:checkbox id="ChecboxUserAdmin" runat="server"></asp:checkbox>
                <br />
                <asp:label id="LabelUserNews" runat="server" text="News Posts: "></asp:label>
                <asp:checkbox id="CheckboxNewsPosts" runat="server" Enabled="False"></asp:checkbox>
                <br />
                <br />
                <asp:label id="UserAdminLevelVerify" runat="server" text="Are you sure?"></asp:label>
                <br />
                <asp:button id="UserAdminLevelSure" runat="server" text="Yes" OnClick="UserAdminLevelSure_Click" />
                <asp:button id="UserAdminLevelConfirm" runat="server" text="Change" Enabled="false" OnClick="UserAdminLevelConfirm_Click" />
            </div>
            <br id="SetAdminBr" runat="server" visible="false"/>
            <asp:button ID="NewsPostButton" runat="server" text="Make News Post" Width="124px" OnClick="NewsPostButton_Click" />
            <br />
            <div id="MakeNewsPostDiv" runat="server" visible="false">
                <asp:label id="PostMessage" runat="server" text=""></asp:label>
                <br />
                <asp:label ID="PostTitle" runat="server" text="Title:"></asp:label>
                <br />
                <asp:textbox id="PostTitleText" runat="server"></asp:textbox>
                <br />
                <br />
                <asp:label ID="PostBox" runat="server" text="Post:"></asp:label>
                <br />
                <asp:textbox ID="PostText" runat="server" TextMode="MultiLine"></asp:textbox>
                <br />
                <br />
                <asp:label id="PostVerify" runat="server" text="Are you sure?"></asp:label>
                <br />
                <asp:button id="PostYes" runat="server" text="Yes" OnClick="PostYes_Click" />
                <asp:button id="PostConfirm" runat="server" text="Post" Enabled="false" OnClick="PostConfirm_Click" />
            </div>
        </div>
    </div>
    <div style="float:left;width:50%;">
        <asp:label ID="CharacterQuickView" runat="server" text="At a glance:"></asp:label>
        <br />
        <br />
        <asp:label ID="CharName" runat="server" text="Name: "></asp:label>
        <br />
        <br />
        <asp:label ID="CharStats" runat="server" text="Primary Stats: "></asp:label>
        <br />
        <br />
        <div style="float:left;width:50%;">
            <asp:label ID="StatAgi" runat="server" text="AGI: "></asp:label>
            <br />
            <asp:label ID="StatApp" runat="server" text="APP: "></asp:label>
            <br />
            <asp:label ID="StatBld" runat="server" text="BLD: "></asp:label>
            <br />
            <asp:label ID="StatCre" runat="server" text="CRE: "></asp:label>
            <br />
            <asp:label ID="StatFit" runat="server" text="FIT: "></asp:label>
         </div>
        <div style="float:left;width:50%;">
            <asp:label ID="StatInf" runat="server" text="INF: "></asp:label>
            <br />
            <asp:label ID="StatKno" runat="server" text="KNO: "></asp:label>
            <br />
            <asp:label ID="StatPer" runat="server" text="PER: "></asp:label>
            <br />
            <asp:label ID="StatPsy" runat="server" text="PSY: "></asp:label>
            <br />
            <asp:label ID="StatWil" runat="server" text="WIL: "></asp:label>
        </div>
        <br style="clear:both;"/>
        <br />
        <asp:label ID="EmergencyDice" runat="server" text="Emergency Dice: "></asp:label>
        <br />
        <asp:label ID="Experience" runat="server" text="XPs: "></asp:label>
        <br />
        <asp:LinkButton ID="ButtonDetail" runat="server" text="Detailed View" OnClick="ButtonDetail_Click" />
        <br />
        <br />
        <asp:button ID="ButtonDelete" runat="server" text="Delete" OnClick="ButtonDelete_Click" Visible="false" />
        <div id="DelConfirmDiv" runat="server" visible="false">
            <asp:Label ID="LableDelConfirmMes" runat="server" Text="Are you sure?"></asp:Label>
            <br />
            <asp:button ID="ButtonDeleteConfirm" runat="server" text="Confirm" Enabled="false" OnClick="ButtonDeleteConfirm_Click" />
            <asp:button ID="ButtonDeleteCancel" runat="server" text="cancel" OnClick="ButtonDeleteCancel_Click" />
        </div>
    </div>
    <br style="clear:both;" />
</asp:Content>

