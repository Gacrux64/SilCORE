<%@ Page Title="" Language="C#" MasterPageFile="~/Template/CharacterTemplate.master" AutoEventWireup="true" CodeFile="CharacterCreator.aspx.cs" Inherits="Template_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
Character Creator
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <script>
        var contentUntouched = "";
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
    Character Creator
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div id="smalldiv" style="width:30%; float:left;">
                    Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Primary Statistic:
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <br />
                    <br />
                    <span onmouseover="agility()">AGI</span><br />
                    <asp:Button ID="Button1" runat="server" Text="&lt;"  />
                    <asp:TextBox ID="TextBox2" runat="server" Width="40px" ReadOnly="True">0</asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="appearance()">APP</span><br />
                    <asp:Button ID="Button3" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox3" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button4" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="build()">BLD</span><br />
                    <asp:Button ID="Button5" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox4" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button6" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="creativity()">CRE</span><br />
                    <asp:Button ID="Button7" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox5" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button8" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="fitness()">FIT</span><br />
                    <asp:Button ID="Button9" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox6" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button10" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="influence()">INF</span><br />
                    <asp:Button ID="Button11" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox7" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button12" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="knowledge()">KNO</span><br />
                    <asp:Button ID="Button13" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox8" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button14" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="perception()">PER</span><br />
                    <asp:Button ID="Button15" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox9" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button16" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="psyche()">PSY</span><br />
                    <asp:Button ID="Button17" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox10" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button18" runat="server" Text="&gt;" />
                    <br />
                    <span onmouseover="willpower()">WIL</span><br />
                    <asp:Button ID="Button19" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox11" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button20" runat="server" Text="&gt;" />
                    <br />
                    <br />
                    Secondary Statistic<br />
                    <br />
                    <span onmouseover="strength()">STR</span><br />
                    <asp:TextBox ID="TextBox12" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <br />
                    <span onmouseover="health()">HEA</span><br />
                    
                    <asp:TextBox ID="TextBox13" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    
                    <br />
                    <span onmouseover="stamina()">STA</span><br />
                    
                    <asp:TextBox ID="TextBox14" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    
                    <br />
                    <span onmouseover="unarmedDamage()">UD</span><br />
                    
                    <asp:TextBox ID="TextBox15" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    
                    <br />
                    <span onmouseover="armedDamage()">AD</span><br />
                    
                    <asp:TextBox ID="TextBox16" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    
                    <br />
                    <span onmouseover="injury()">FLESH WOUND</span><br />
                    
                    <asp:TextBox ID="TextBox17" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    
                    <br />
                    <span onmouseover="injury()">DEEP WOUND</span><br />
                    
                    <asp:TextBox ID="TextBox18" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    
                    <br />
                    <span onmouseover="injury()">INSTANT DEATH</span><br />
                    <asp:TextBox ID="TextBox19" runat="server" ReadOnly="True" Width="40px"></asp:TextBox>
                    <br />
                    <span onmouseover="systemShock()" >SYSTEM SHOCK</span><br />
                    <asp:TextBox ID="TextBox20" runat="server" ReadOnly="True" Width="40px"></asp:TextBox>
                    <br />
                </div>
                
    <div id="description" style="width:60%; height:450px; float:left">
        <h2>Description: Primary Stats</h2>
        <p id="contentDescription" style="padding-top:7px">Hover over the Stat name in order to learn more about it</p>
        <table id="StatsTable">
            
        </table>
    </div>
     <div id="description2" style="width:60%; float:left">
        <h2>Description: Secondary Stats</h2>
        <p id="secondaryDescription">Hover over the Stat name in order to learn more about it. Note: FLESH WOUND, DEEP WOUND, INSTANT DEATH have the same description for obvious reasons</p>
         <table id="secondStatsTable">
            
        </table>
    </div>
    <div style="clear:both">
                    Skill, Perks and Flaws<br />
                    <br />
                    SKILLS<br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                    <asp:ListBox ID="ListBox1" style="vertical-align:top;" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                        <asp:ListItem>Animal Handling</asp:ListItem>
                        <asp:ListItem>Archery</asp:ListItem>
                        <asp:ListItem>Athletics</asp:ListItem>
                        <asp:ListItem>Business</asp:ListItem>
                        <asp:ListItem>Combat Sense</asp:ListItem>
                        <asp:ListItem>Craft (Specific)</asp:ListItem>
                        <asp:ListItem>Defense</asp:ListItem>
                        <asp:ListItem>Demolition/Trap</asp:ListItem>
                        <asp:ListItem>Disguise</asp:ListItem>
                        <asp:ListItem>Etiquette (Specific)</asp:ListItem>
                        <asp:ListItem>Forgery (Specific)</asp:ListItem>
                        <asp:ListItem>Gambling</asp:ListItem>
                        <asp:ListItem>Gunnery (Specific)</asp:ListItem>
                        <asp:ListItem>Hand-to-hand</asp:ListItem>
                        <asp:ListItem>Heavy Weapons</asp:ListItem>
                        <asp:ListItem>Information Warfare</asp:ListItem>
                        <asp:ListItem>Interrogation</asp:ListItem>
                        <asp:ListItem>Language (Specific)</asp:ListItem>
                        <asp:ListItem>Leadership</asp:ListItem>
                        <asp:ListItem>Medicine</asp:ListItem>
                        <asp:ListItem>Melee</asp:ListItem>
                        <asp:ListItem>Natural Sense</asp:ListItem>
                        <asp:ListItem>Navigation (Specific)</asp:ListItem>
                        <asp:ListItem>Negotiation</asp:ListItem>
                        <asp:ListItem>Notice</asp:ListItem>
                        <asp:ListItem>Personal Flight Device</asp:ListItem>
                        <asp:ListItem>Performance Art</asp:ListItem>
                        <asp:ListItem>Pilot (Specific)</asp:ListItem>
                        <asp:ListItem>Riding</asp:ListItem>
                        <asp:ListItem>Seduction</asp:ListItem>
                        <asp:ListItem>Sleight-of-hand</asp:ListItem>
                        <asp:ListItem>Small Arms</asp:ListItem>
                        <asp:ListItem>Social Science (Specific)</asp:ListItem>
                        <asp:ListItem>Stealth</asp:ListItem>
                        <asp:ListItem>Streetwise</asp:ListItem>
                        <asp:ListItem>Survival</asp:ListItem>
                        <asp:ListItem>Teaching</asp:ListItem>
                        <asp:ListItem>Technical Sciences</asp:ListItem>
                        <asp:ListItem>Tinker</asp:ListItem>
                        <asp:ListItem>Throwing</asp:ListItem>
                        <asp:ListItem>Trivia/Lore (Specific)</asp:ListItem>
                        <asp:ListItem>Visual Art (Specific)</asp:ListItem>
                        <asp:ListItem>Zero-G</asp:ListItem>
                    </asp:ListBox>
        <div style="vertical-align:top; float:right; position:relative; right:470px">
                    <asp:DropDownList ID="DropDownList1"  runat="server" Width="104px">
                        <asp:ListItem Value="1">Level 1</asp:ListItem>
                        <asp:ListItem Value="2">Level 2</asp:ListItem>
                        <asp:ListItem Value="3">Level 3</asp:ListItem>
                        <asp:ListItem Value="4">Level 4</asp:ListItem>
                        <asp:ListItem Value="5">Level 5</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:DropDownList ID="DropDownList2"  runat="server" Width="104px">
                        <asp:ListItem Value="1">Complexity 1</asp:ListItem>
                        <asp:ListItem Value="2">Complexity 2</asp:ListItem>
                        <asp:ListItem Value="3">Complexity 3</asp:ListItem>
                        <asp:ListItem Value="4">Complexity 4</asp:ListItem>
                        <asp:ListItem Value="5">Complexity 5</asp:ListItem>
                    </asp:DropDownList>
            </div>
        
                    
                            <asp:Button ID="Button36" runat="server" OnClick="Button36_Click" Text="Add" />
                            <asp:Button ID="Button35" runat="server" Text="Remove" OnClick="Button35_Click" />
                            <asp:ListBox ID="ListBox4" runat="server"></asp:ListBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
            
                    
                    <br />
                    PERKS<br />         <asp:ListBox ID="ListBox2" runat="server"><asp:ListItem>Accelerated Healing</asp:ListItem>
                        <asp:ListItem>Acute Sense (Specific)</asp:ListItem>
                        <asp:ListItem>Smell</asp:ListItem>
                        <asp:ListItem>Taste</asp:ListItem>
                        <asp:ListItem>Ambidtextrous</asp:ListItem>
                        <asp:ListItem>Animal Companion</asp:ListItem>
                        <asp:ListItem>Animal Kinship</asp:ListItem>
                        <asp:ListItem>Authority</asp:ListItem>
                        <asp:ListItem>Common Sense</asp:ListItem>
                        <asp:ListItem>Connections</asp:ListItem>
                        <asp:ListItem>Double Jointed</asp:ListItem>
                        <asp:ListItem>Fake Identity</asp:ListItem>
                        <asp:ListItem>Famous</asp:ListItem>
                        <asp:ListItem>Favor</asp:ListItem>
                        <asp:ListItem>Immunity</asp:ListItem>
                        <asp:ListItem>Influence</asp:ListItem>
                        <asp:ListItem>Intuition</asp:ListItem>
                        <asp:ListItem>Light Sleeper</asp:ListItem>
                        <asp:ListItem>Longevity</asp:ListItem>
                        <asp:ListItem>Lucky</asp:ListItem>
                        <asp:ListItem>Machine-Touch</asp:ListItem>
                        <asp:ListItem>Perfect-Pitch</asp:ListItem>
                        <asp:ListItem>Photographic Memory</asp:ListItem>
                        <asp:ListItem>Property</asp:ListItem>
                        <asp:ListItem>Quick Learner</asp:ListItem>
                        <asp:ListItem>Radiation Resistance</asp:ListItem>
                        <asp:ListItem>Military Rank</asp:ListItem>
                        <asp:ListItem>Sense of Direction</asp:ListItem>
                        <asp:ListItem>Sense of Time</asp:ListItem>
                        <asp:ListItem>Strong Immune System</asp:ListItem>
                        <asp:ListItem>Subordinates</asp:ListItem>
                        <asp:ListItem>Thick-Skinned</asp:ListItem>
                        <asp:ListItem>Wealthy</asp:ListItem>
                    </asp:ListBox>
                    <asp:Button ID="Button37" runat="server" Text="&lt;&lt;" />
                    <asp:Button ID="Button38" runat="server" Text="&gt;&gt;" />
                    <asp:ListBox ID="ListBox5" runat="server"></asp:ListBox>
                    <br />
                    FLAWS<br />
                    <asp:ListBox ID="ListBox3" runat="server">
                        <asp:ListItem>Addiction</asp:ListItem>
                        <asp:ListItem>Age</asp:ListItem>
                        <asp:ListItem>Amnesiac</asp:ListItem>
                        <asp:ListItem>Animal Antipathy</asp:ListItem>
                        <asp:ListItem>Bad Luck</asp:ListItem>
                        <asp:ListItem>Beliefs</asp:ListItem>
                        <asp:ListItem>Bloodlust</asp:ListItem>
                        <asp:ListItem>Code of Honor</asp:ListItem>
                        <asp:ListItem>Criminal Background</asp:ListItem>
                        <asp:ListItem>Curse</asp:ListItem>
                        <asp:ListItem>Debt</asp:ListItem>
                        <asp:ListItem>Dedicated</asp:ListItem>
                        <asp:ListItem>Dependent</asp:ListItem>
                        <asp:ListItem>Destitute</asp:ListItem>
                        <asp:ListItem>Flashbacks</asp:ListItem>
                        <asp:ListItem>Goal</asp:ListItem>
                        <asp:ListItem>Heavy Sleeper</asp:ListItem>
                        <asp:ListItem>Infamous</asp:ListItem>
                        <asp:ListItem>Insomniac</asp:ListItem>
                        <asp:ListItem>Lame</asp:ListItem>
                        <asp:ListItem>Liar</asp:ListItem>
                        <asp:ListItem>Mechanical Inaptitude</asp:ListItem>
                        <asp:ListItem>Motion Sickness</asp:ListItem>
                        <asp:ListItem>Nemesis</asp:ListItem>
                        <asp:ListItem>Obligations</asp:ListItem>
                        <asp:ListItem>One-Armed</asp:ListItem>
                        <asp:ListItem>Paranoid</asp:ListItem>
                        <asp:ListItem>Phobia</asp:ListItem>
                        <asp:ListItem>Poor Senses (Specific)</asp:ListItem>
                        <asp:ListItem>Quirk</asp:ListItem>
                        <asp:ListItem>Radiation Vulnerability</asp:ListItem>
                        <asp:ListItem>Secret</asp:ListItem>
                        <asp:ListItem>Sick</asp:ListItem>
                        <asp:ListItem>Slow Healing</asp:ListItem>
                        <asp:ListItem>Slow Learner</asp:ListItem>
                        <asp:ListItem>Social Stigma</asp:ListItem>
                        <asp:ListItem>Split Personality</asp:ListItem>
                        <asp:ListItem>Thin-Skinned</asp:ListItem>
                        <asp:ListItem>Wanted</asp:ListItem>
                        <asp:ListItem>Weak Immune System</asp:ListItem>
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
                    <asp:TextBox ID="TextBox21" runat="server" ReadOnly="True" Width="40px"></asp:TextBox>
                    <asp:Button ID="Button42" runat="server" Text="&gt;" />
                    <br />
                    EXP<br />
                    <asp:Button ID="Button43" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox22" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button44" runat="server" Text="&gt;" />
                    <br />
                    GAME TYPE<br />
                    <asp:Button ID="Button45" runat="server" Text="&lt;" />
                    <asp:TextBox ID="TextBox23" runat="server" Width="40px" ReadOnly="True"></asp:TextBox>
                    <asp:Button ID="Button46" runat="server" Text="&gt;" />
                    <br />
                    <br />
                    <asp:Button ID="Button47" runat="server" Text="Submit" />
                    <br />

                
          </div>
</asp:Content>

