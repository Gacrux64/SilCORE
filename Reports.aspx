<%@ Page Title="" Language="C#" MasterPageFile="~/Template/CharacterTemplate.master" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Template_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
    Reports
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <h2 style="text-align:left;">User Login Report</h2>
    <hr />
    <div runat="server" id="report1">
        <p id="userlog">Number of users login:<span id="userLoginNumber"></span></p>
        <div runat="server" id="fromDate" style="width:35%; float:left;">From: <span id="startdate"></span> 
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" ForeColor="White" Height="37px" Width="122px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </div>
        <div runat="server" id="toDate" style="width:35%; float:right;">
            To: <asp:Label ID="Label2" runat="server"></asp:Label>
            <span id="finishdate"></span>&nbsp;<asp:Calendar ID="Calendar2" runat="server" ForeColor="White" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>

        </div>
    </div>
    <br style="clear:both"/>
    <hr />
    <hr />
    <h2 style="text-align:left">Average Statistic</h2>
    <div runat="server" id="Pstats" style="margin-left:25px; width:35%; float:left;">
        AGI:<span id="agi"></span><br />
        APP:<span id="app"></span><br />
        BLD:<span id="bld"></span><br />
        CRE:<span id="cre"></span><br />
        FIT:<span id="fit"></span><br />
        INF:<span id="inf"></span><br />
        KNO:<span id="kno"></span><br />
        PER:<span id="per"></span><br />
        PSY:<span id="psy"></span><br />
        WIL:<span id="wil"></span><br />
    </div>
    <div runat="server" id="Sstats" style="margin-left:25px; width:55%; float:right;">
        STR:<span id="str"></span><br />
        HEA:<span id="hea"></span><br />
        STA:<span id="sta"></span><br />
        UD:<span id="ud"></span><br />
        AD:<span id="ad"></span><br />
        FLESH WOUND:<span id="flesh"></span><br />
        DEEP WOUND:<span id="deep"></span><br />
        INSTANT DEATH:<span id="instant"></span><br />
        SYSTEM SHOCK:<span id="shock"></span>
    </div>
    <br style="clear:both;"/>
    <hr />
    <hr />
    <h2 style="text-align:left;">Exception Report</h2>
    <hr />
    <div runat="server" id="report2">
        <p>Users without any character created:</p>
            <div runat="server" id="userExceptions" style="margin-left:25px;">
                Iamlegend<br />
                UserPlaceHolder<br />
            </div>
    </div>
    <hr />
    <hr />
    <h2 style="text-align:left;">Character Creation Report</h2>
    <hr />
    <div runat="server" id="report3">
        <p>This is all the characters that have been registered to Silcore's Character Creation</p>
        <div runat="server" id="characterReport" style="margin-left:25px;">
            Username:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem> Select Username</asp:ListItem>
                <asp:ListItem>BigManAwesome</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <div class="characters" style="margin-left:50px;">
              Character Name: <a href="">Bob</a><br />
              Character Name: <a href="">BobNo2(Dummy)</a>
               
            </div>
            <br />
            
    </div>
 </div>
</asp:Content>

