<%@ Page Title="" Language="C#" MasterPageFile="~/Template/CharacterTemplate.master" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Template_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
    Reports
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <h2 style="text-align:left;">Report No1</h2>
    <hr />
    <div runat="server" id="report1">
        <p id="userlog">Number of users login:<span id="userLoginNumber"></span></p>
        <p>From: <span id="startdate"></span> To:<span id="finishdate"></span></p>
    </div>
    <hr />
    <hr />
    <h2 style="text-align:left;">Report No2</h2>
    <hr />
    <div runat="server" id="report2">
        
    </div>
    <hr />
    <hr />
    <h2 style="text-align:left;">Report No3</h2>
    <hr />
    <div runat="server" id="report3">
        This is all the characters that have been registered to Silcore's Character Creation<br /><br />
        <div runat="server" id="characterReport" style="margin-left:25px;">
            Username: BigManAwesome
            <div class="characters" style="margin-left:50px;">
               Character Name: Bob
                <br />
                Average Stats: 2.6;<br />
                Skills: Archery: Level-1, Complexity-2 | Melee: Level-5,  Complexity-5.<br />
                Perks: Light Sleeper | Acute Sense - Hearing.<br />
                Flaws: Beliefs-3.<br />
            </div>
            <hr />
            <div class="characters" style="margin-left:50px;">
               Character Name: BobNo2(Dummy)
                <br />
                Average Stats: 2.6;<br />
                Skills: Archery: Level-1, Complexity-2 | Melee: Level-5,  Complexity-5.<br />
                Perks: Light Sleeper | Acute Sense - Hearing.<br />
                Flaws: Beliefs-3.<br />
            </div>
            <br />
            Username: BigManAwesome2
            <div class="characters" style="margin-left:50px;">
               Character Name: Bob
                <br />
                Average Stats: 2.6;<br />
                Skills: Archery: Level-1, Complexity-2 | Melee: Level-5,  Complexity-5.<br />
                Perks: Light Sleeper | Acute Sense - Hearing.<br />
                Flaws: Beliefs-3.<br />
            </div>
    </div>
 </div>
</asp:Content>

