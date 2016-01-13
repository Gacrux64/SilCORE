﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CharacterCreator.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Silcore Character Creator</title>
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="box">
            <header>
                <img id="banner" src="App_Themes/SilCOREBW/Images/banner.jpg" alt="SilCORE Banner" />
            </header>
            <div id="left">
                    <h2 style="text-align:center;">Navigation</h2>
                        <a href="Default.aspx"><div class="links">Home</div></a>
                        <a href="Registration.aspx"><div class="links">Registration</div></a>
                        <a href="Browse.aspx"><div class="links">Browse Characters</div></a>
                        <a href="http://www.dp9.com"><div class="links">Dream Pod 9 Website</div></a>
                        <a href="http://www.drivethrurpg.com"><div class="links">Drive Thru RPG</div></a>
            </div>
            <div id="content2">
                <h2>
                    Character Creator
                </h2>
            <div id="contentBox2">
                    Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Primary Statistic:
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <br />
                    <br />
                    AGI<br />
                    <asp:Button ID="Button1" runat="server" Text="&lt;" OnClick="Button1_Click" />
                    <asp:TextBox ID="TextBox2" runat="server" Width="40px" ReadOnly="True">0</asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="&gt;" OnClick="Button2_Click" />
                    <br />
                    APP<br />
                    <asp:Button ID="Button3" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox3" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button4" runat="server" Text="&gt;" />
                    <br />
                    BLD<br />
                    <asp:Button ID="Button5" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox4" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button6" runat="server" Text="&gt;" />
                    <br />
                    CRE<br />
                    <asp:Button ID="Button7" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox5" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button8" runat="server" Text="&gt;" />
                    <br />
                    FIT<br />
                    <asp:Button ID="Button9" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox6" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button10" runat="server" Text="&gt;" />
                    <br />
                    INF<br />
                    <asp:Button ID="Button11" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox7" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button12" runat="server" Text="&gt;" />
                    <br />
                    KNO<br />
                    <asp:Button ID="Button13" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox8" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button14" runat="server" Text="&gt;" />
                    <br />
                    /PER<br />
                    <asp:Button ID="Button15" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox9" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button16" runat="server" Text="&gt;" />
                    <br />
                    PSY<br />
                    <asp:Button ID="Button17" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox10" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button18" runat="server" Text="&gt;" />
                    <br />
                    WIL<br />
                    <asp:Button ID="Button19" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox11" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button20" runat="server" Text="&gt;" />
                    <br />
                    <br />
                    Secondary Statistic<br />
                    <br />
                    STR<br />
                    <asp:Button ID="Button21" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox12" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button22" runat="server" Text="&gt;" />
                    <br />
                    HEA<br />
                    <asp:Button ID="Button23" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox13" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button24" runat="server" Text="&gt;" />
                    <br />
                    STA<br />
                    <asp:Button ID="Button25" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox14" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button26" runat="server" Text="&gt;" />
                    <br />
                    UD<br />
                    <asp:Button ID="Button27" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox15" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button28" runat="server" Text="&gt;" />
                    <br />
                    AD<br />
                    <asp:Button ID="Button29" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox16" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button30" runat="server" Text="&gt;" />
                    <br />
                    FLESH WOUND<br />
                    <asp:Button ID="Button31" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox17" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button32" runat="server" Text="&gt;" />
                    <br />
                    DEEP WOUND<br />
                    <asp:Button ID="Button33" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox18" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button34" runat="server" Text="&gt;" />
                    <br />
                    <br />
                    Skill, Perks and Flaws<br />
                    <br />
                    SKILLS<br />
                    <asp:ListBox ID="ListBox1" runat="server">
                        <asp:ListItem>Skill1</asp:ListItem>
                    </asp:ListBox>
                    <asp:Button ID="Button36" runat="server" Text="&lt;&lt;" />
                    <asp:Button ID="Button35" runat="server" Text="&gt;&gt;" />
                    <asp:ListBox ID="ListBox4" runat="server"></asp:ListBox>
                    <br />
                    PERKS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                    <asp:ListBox ID="ListBox2" runat="server">
                        <asp:ListItem>Perk1</asp:ListItem>
                    </asp:ListBox>
                    <asp:Button ID="Button37" runat="server" Text="&lt;&lt;" />
                    <asp:Button ID="Button38" runat="server" Text="&gt;&gt;" />
                    <asp:ListBox ID="ListBox5" runat="server"></asp:ListBox>
                    <br />
                    FLAWS<br />
                    <asp:ListBox ID="ListBox3" runat="server">
                        <asp:ListItem>Flaw1</asp:ListItem>
                    </asp:ListBox>
                    <asp:Button ID="Button39" runat="server" Text="&lt;&lt;" />
                    <asp:Button ID="Button40" runat="server" Text="&gt;&gt;" />
                    <asp:ListBox ID="ListBox6" runat="server"></asp:ListBox>
                    <br />
                    <br />
                    Miscellaneous<br />
                    <br />
                    EMERGENCY DICE<br />
                    <asp:Button ID="Button41" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox19" runat="server" ReadOnly="True" Width="40px"></asp:TextBox>
                    <asp:Button ID="Button42" runat="server" Text="&gt;" />
                    <br />
                    EXP<br />
                    <asp:Button ID="Button43" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox20" runat="server" ReadOnly="True" Width="40px"></asp:TextBox>
                    <asp:Button ID="Button44" runat="server" Text="&gt;" />
                    <br />
                    GAME TYPE<br />
                    <asp:Button ID="Button45" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox21" runat="server" ReadOnly="True" Width="40px"></asp:TextBox>
                    <asp:Button ID="Button46" runat="server" Text="&gt;" />
                    <br />
                    <br />
                    <asp:Button ID="Button47" runat="server" Text="Submit" />
                    <br />
            </div>
                
                <br>
            <footer id="footer2">
             
            </footer>
            </div>
        </div>
        </div>
    </form>
</body>
</html>