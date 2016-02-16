<%@ Page Title="" Language="C#" MasterPageFile="~/Template/CharacterTemplate.master" AutoEventWireup="true" CodeFile="CharacterCreator.aspx.cs" Inherits="Template_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
Character Creator
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        table{
            width:430px;
        }
        td{
            border:solid;
            border-width:1px;
            text-align:center;
        }
        Thead>tr>td{
            font-weight:bold;
        }
        #flawsDiv1 {
            width: 138px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
    Character Creator
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <script>
       
            
    </script>
            <div id="smalldiv" style="width:30%; float:left;">
                    Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:requiredfieldvalidator ID="RequiredFiledValidator" runat="server" errormessage="*Please give your charcter a name." ControlToValidate="TextBox1" ForeColor="Red"></asp:requiredfieldvalidator>
                    <br />
                    <br />
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                    GAME TYPE:
                    <asp:DropDownList ID="DropDownList18" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList18_SelectedIndexChanged">
                        <asp:ListItem Value="20">Gritty</asp:ListItem>
                        <asp:ListItem Value="30">Adventurous</asp:ListItem>
                        <asp:ListItem Value="50">Cinematic</asp:ListItem>
                        <asp:ListItem Value="0">Custom</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div runat="server" visible="false" ID="customgame">

                       CP: <asp:TextBox type="number" ID="TextBox23" runat="server" OnTextChanged="TextBox23_TextChanged" AutoPostBack="True"></asp:TextBox><br />
                        SP:

                        <asp:TextBox ID="TextBox27" runat="server" OnTextChanged="TextBox27_TextChanged" AutoPostBack="True">0</asp:TextBox>

                        <br />

                    </div>
                    
                    
                            <br />
                    
                    
                            Character Points:<asp:Label ID="Label1" runat="server"></asp:Label>
                            <br />
                            <br />
                         Primary Statistic:<br />
                            <br />
                    <span onmouseover="agility()">AGI </span>
                    <br />
                
                    <asp:Button ID="Button1" runat="server" Text="&lt;" OnClick="Button1_Click"  />
                    <asp:TextBox ID="TextBox2" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="&gt;" OnClick="Button2_Click" />
                            
                            <br />
                
                    <span onmouseover="appearance()">APP</span><br />
                    <asp:Button ID="Button3" runat="server" Text="&lt;" OnClick="Button3_Click" />
                    <asp:TextBox ID="TextBox3" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button4" runat="server" Text="&gt;" OnClick="Button4_Click" />
                    <br />
                    <span onmouseover="build()">BLD</span><br />
                    <asp:Button ID="Button5" runat="server" Text="&lt;" OnClick="Button5_Click" />
                    <asp:TextBox ID="TextBox4" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button6" runat="server" Text="&gt;" OnClick="Button6_Click" />
                    <br />
                    <span onmouseover="creativity()">CRE</span><br />
                    <asp:Button ID="Button7" runat="server" Text="&lt;" OnClick="Button7_Click" />
                    <asp:TextBox ID="TextBox5" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button8" runat="server" Text="&gt;" OnClick="Button8_Click" />
                    <br />
                    <span onmouseover="fitness()">FIT</span><br />
                    <asp:Button ID="Button9" runat="server" Text="&lt;" OnClick="Button9_Click" />
                    <asp:TextBox ID="TextBox6" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button10" runat="server" Text="&gt;" OnClick="Button10_Click" />
                    <br />
                    <span onmouseover="influence()">INF</span><br />
                    <asp:Button ID="Button11" runat="server" Text="&lt;" OnClick="Button11_Click" />
                    <asp:TextBox ID="TextBox7" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button12" runat="server" Text="&gt;" OnClick="Button12_Click" />
                    <br />
                    <span onmouseover="knowledge()">KNO</span><br />
                    <asp:Button ID="Button13" runat="server" Text="&lt;" OnClick="Button13_Click" />
                    <asp:TextBox ID="TextBox8" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button14" runat="server" Text="&gt;" OnClick="Button14_Click" />
                    <br />
                    <span onmouseover="perception()">PER</span><br />
                    <asp:Button ID="Button15" runat="server" Text="&lt;" OnClick="Button15_Click" />
                    <asp:TextBox ID="TextBox9" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button16" runat="server" Text="&gt;" OnClick="Button16_Click" />
                    <br />
                    <span onmouseover="psyche()">PSY</span><br />
                    <asp:Button ID="Button17" runat="server" Text="&lt;" OnClick="Button17_Click" />
                    <asp:TextBox ID="TextBox10" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button18" runat="server" Text="&gt;" OnClick="Button18_Click" />
                    <br />
                    <span onmouseover="willpower()">WIL</span><br />
                    <asp:Button ID="Button19" runat="server" Text="&lt;" OnClick="Button19_Click" />
                    <asp:TextBox ID="TextBox11" runat="server" Width="40px" ReadOnly="True">-1</asp:TextBox>
                    <asp:Button ID="Button20" runat="server" Text="&gt;" OnClick="Button20_Click" />
                    <br />
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

                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                
    <div id="description" style="width:60%; height:450px; float:left">
        <h2>&nbsp;</h2>
        <h2>Description: Primary Stats</h2>
        <p id="contentDescription" style="padding-top:7px">Hover over the Stat name in order to learn more about it</p>
        <table id="StatsTable">
            
        </table>
    </div>
    <br />
     <div id="description2" style=" width:60%; float:left">
        <h2>&nbsp;</h2>
         <h2>&nbsp;</h2>
         <h2>Description: Secondary Stats</h2>
        <p id="secondaryDescription">Hover over the Stat name in order to learn more about it. Note: FLESH WOUND, DEEP WOUND, INSTANT DEATH have the same description for obvious reasons</p>
         <table id="secondStatsTable">
            
        </table>
    </div>
    <br />
    <br />
    <div style="clear:both;">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                    <br />
                    Skill Points:<asp:Label ID="Label2" runat="server"></asp:Label>
                            <br />
                    <br />
                    SKILLS<br />
        
                        
                    <asp:ListBox ID="ListBox1" style="vertical-align:top;" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="169px">
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
                        <asp:ListItem Value="6">Level 6</asp:ListItem>
                        <asp:ListItem Value="7">Level 7</asp:ListItem>
                        <asp:ListItem Value="8">Level 8</asp:ListItem>
                        <asp:ListItem Value="9">Level 9</asp:ListItem>
                        <asp:ListItem Value="10">Level 10</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:DropDownList ID="DropDownList2"  runat="server" Width="104px">
                        <asp:ListItem Value="1">Complexity 1</asp:ListItem>
                        <asp:ListItem Value="2">Complexity 2</asp:ListItem>
                        <asp:ListItem Value="3">Complexity 3</asp:ListItem>
                        <asp:ListItem Value="4">Complexity 4</asp:ListItem>
                        <asp:ListItem Value="5">Complexity 5</asp:ListItem>
                    </asp:DropDownList>
            </div>
        
                    
                            <asp:Button ID="Button36" runat="server" ValidationGroup="skilladd" OnClick="Button36_Click" Text="Add" />
                            <asp:Button ID="Button35" runat="server" ValidationGroup="skillremove" Text="Remove" OnClick="Button35_Click" />
                            <asp:ListBox ID="ListBox4" runat="server"></asp:ListBox>
                    <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="skilladd" runat="server" ControlToValidate="ListBox1" ErrorMessage="*Please choose a skill to add" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ListBox4" Display="Dynamic" ErrorMessage="*Please choose a skill to remove" ForeColor="Red" ValidationGroup="skillremove"></asp:RequiredFieldValidator>
                <asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>
            
                    
                    
                    PERKS<br />         
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" >
                        <ContentTemplate>
        <asp:ListBox ID="ListBox2" runat="server" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" AutoPostBack="True" Width="169px">
                        <asp:ListItem>Accelerated Healing</asp:ListItem>
                        <asp:ListItem>Acute Sense (Specific)</asp:ListItem>
                        <asp:ListItem>Smell</asp:ListItem>
                        <asp:ListItem>Taste</asp:ListItem>
                        <asp:ListItem>Ambidextrous</asp:ListItem>
                        <asp:ListItem>Animal Companion</asp:ListItem>
                        <asp:ListItem>Animal Kinship</asp:ListItem>
                        <asp:ListItem>Authority</asp:ListItem>
                        <asp:ListItem>Common Sense</asp:ListItem>
                        <asp:ListItem>Connections (Allies)</asp:ListItem>
                        <asp:ListItem>Connections (Contacts)</asp:ListItem>
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
                        <asp:ListItem>Thick-Skinned</asp:ListItem>
                        <asp:ListItem>Wealthy</asp:ListItem>
                    </asp:ListBox>
                            <div runat="server"  visible="true" id="perksDiv" style="vertical-align:top; float:right; position:relative; right:470px">
                                <div runat="server" visible="false" id="perksDiv1">
                                &nbsp;<asp:DropDownList ID="DropDownList3" runat="server" Width="104px" AppendDataBoundItems="True">
                                    <asp:ListItem>Hearing</asp:ListItem>
                                    <asp:ListItem>Sight</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv2">
                                &nbsp;<asp:DropDownList ID="DropDownList4" runat="server" Width="104px">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv3">
                                &nbsp;<asp:DropDownList ID="DropDownList5" runat="server" Width="104px">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                              
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv4">
                                &nbsp;<asp:DropDownList ID="DropDownList6" runat="server" Width="104px">
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>

                                      </asp:DropDownList>
                              </div>
                                <div runat="server" visible="false" id="perksDiv5">
                              
                                &nbsp;<asp:DropDownList ID="DropDownList7" runat="server" Width="104px">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                              
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv6">
                                &nbsp;<asp:DropDownList ID="DropDownList8" runat="server" Width="104px">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv7">
                                &nbsp;<asp:DropDownList ID="DropDownList9" runat="server" Width="104px">
                                        <asp:ListItem Value="1">20 000</asp:ListItem>
                                        <asp:ListItem Value="2">50 000</asp:ListItem>
                                        <asp:ListItem Value="3">75 000</asp:ListItem>
                                        <asp:ListItem Value="4">150 000</asp:ListItem>
                                        <asp:ListItem Value="5">500 000</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                 <div runat="server" visible="false" id="perksDiv8">
                                &nbsp;<asp:DropDownList ID="DropDownList10" runat="server" Width="104px">
                                       
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                      
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv9">
                                &nbsp;<asp:DropDownList ID="DropDownList11" runat="server" Width="104px">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv10">
                                &nbsp;<asp:DropDownList ID="DropDownList12" runat="server" Width="104px" >
                                        <asp:ListItem Value="2">Enlisted/Member</asp:ListItem>
                                        <asp:ListItem Value="4">Junior Nco/Veteran Member</asp:ListItem>
                                        <asp:ListItem Value="8">Senior Nco/Assistant-Director</asp:ListItem>
                                        <asp:ListItem Value="12">Senior Officer/Director</asp:ListItem>
                                </asp:DropDownList>
                                    </div>
                                    <div runat="server" visible="false" id="perksDiv105">
                                &nbsp;<asp:DropDownList ID="DropDownList16" runat="server" Width="104px">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>6</asp:ListItem>
                                        <asp:ListItem>7</asp:ListItem>
                                        <asp:ListItem>8</asp:ListItem>
                                        <asp:ListItem>9</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv11" style="padding-left:5px;">
                                &nbsp;<asp:DropDownList ID="DropDownList13" runat="server" Width="104px">
                                        <asp:ListItem Value="2">2D</asp:ListItem>
                                        <asp:ListItem Value="5">3D</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="perksDiv12">
                                
                                <asp:DropDownList Visible="false" ID="DropDownList14" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="3">1</asp:ListItem>
                                        <asp:ListItem Value="6">2</asp:ListItem>
                                        <asp:ListItem Value="9">3</asp:ListItem>
                                        
                                </asp:DropDownList>
                              <asp:DropDownList Visible="false" ID="DropDownList15" runat="server" Width="104px">
                                        
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        
                                </asp:DropDownList>
                                   <br />
                                 <asp:DropDownList ID="DropDownList17" runat="server" Width="104px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList17_SelectedIndexChanged">
                                        <asp:ListItem>Choose</asp:ListItem>
                                        <asp:ListItem>Renewable</asp:ListItem>
                                        <asp:ListItem>Non-Renewable</asp:ListItem>
                                    </asp:DropDownList>
                                    <br />
                                    
                                </div>
                            </div>
                    <asp:Button ID="Button37" runat="server" ValidationGroup="perkadd" Text="Add" OnClick="Button37_Click" />
                    <asp:Button ID="Button38" runat="server" ValidationGroup="perkremove" Text="Remove" OnClick="Button38_Click" />
                    <asp:ListBox ID="ListBox5" runat="server"></asp:ListBox>
                    <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="perkadd" runat="server" ControlToValidate="ListBox2" ErrorMessage="*Please choose a perk to add" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator><asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="perkremove" runat="server" ControlToValidate="ListBox5" ErrorMessage="*Please choose a perk to remove" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:Label ID="Label4" runat="server" ForeColor="Red"></asp:Label>
                             <asp:Label ID="Label6" runat="server" ForeColor="Red"></asp:Label>
                             </ContentTemplate>
            </asp:UpdatePanel>
                    FLAWS<br />
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                    <asp:ListBox ID="ListBox3" runat="server" OnSelectedIndexChanged="ListBox3_SelectedIndexChanged" Width="169px" AutoPostBack="True">
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
                            <div runat="server" id="flawsDiv" style="vertical-align:top; float:right; position:relative; right:470px">
                                <div runat="server" visible="false" id="flawsDiv1" style="position:absolute;right:-1px;">

                                    <asp:TextBox ID="TextBox24" runat="server" ValidationGroup="perkadd" onclick="this.value=''; this.style.color='black'" ForeColor="Gray" Width="104px">Drugs</asp:TextBox>
                                    <br />
                                    <asp:TextBox  ID="TextBox25" runat="server" ValidationGroup="perkadd" onclick="this.type='number'; this.min='3'; this.style.color='black'" ForeColor="Gray" Width="104px">Rating</asp:TextBox>

                                </div>
                                <div runat="server" visible="false" id="age">
                                    <asp:DropDownList ID="DropDownList19" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-2">Young</asp:ListItem>
                                        <asp:ListItem Value="-4">Old</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="belief">
                                    <asp:DropDownList  ID="DropDownList20" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="honor">
                                    <asp:DropDownList ID="DropDownList21" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        <asp:ListItem Value="-4">4</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <div runat="server" Visible="false" id="criminal">
                                    <asp:DropDownList ID="DropDownList22" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" Visible="false" id="curse">
                                    <asp:DropDownList ID="DropDownList23" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        <asp:ListItem Value="-4">4</asp:ListItem>
                                        <asp:ListItem Value="-5">5</asp:ListItem>
                                        <asp:ListItem Value="-6">6</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="debt">
                                    <asp:DropDownList ID="DropDownList24" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">20 000</asp:ListItem>
                                        <asp:ListItem Value="-2">50 000</asp:ListItem>
                                        <asp:ListItem Value="-3">75 000</asp:ListItem>
                                        <asp:ListItem Value="-4">150 000</asp:ListItem>
                                        <asp:ListItem Value="-5">500 000</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="dedicated">
                                    <asp:DropDownList ID="DropDownList25" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="infamous">
                                    <asp:DropDownList ID="DropDownList26" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        <asp:ListItem Value="-4">4</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="lame">
                                    <asp:DropDownList ID="DropDownList27" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-2">Removable</asp:ListItem>
                                        <asp:ListItem Value="-6">Permanent</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="liar">
                                    <asp:DropDownList ID="DropDownList28" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">Liar</asp:ListItem>
                                        <asp:ListItem Value="-5">Mythomaniac</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="motionsickness">
                                    <asp:TextBox  ID="TextBox26" runat="server" onclick="this.type='number'; this.style.color='black'" ForeColor="Gray" Width="104px">Rating</asp:TextBox>

                                </div>
                                <div runat="server" visible="false" id="obligation">
                                    <asp:DropDownList ID="DropDownList30" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="onearmed">
                                    <asp:DropDownList ID="DropDownList31" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-2">Temporary</asp:ListItem>
                                        <asp:ListItem Value="-5">Permanent</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="phobia">
                                    <asp:DropDownList ID="DropDownList32" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-2">Mild</asp:ListItem>
                                        <asp:ListItem Value="-4">Severe</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="poorsense" style="position:absolute;right:-1px;">
                                    <asp:DropDownList ID="DropDownList33" runat="server" Width="104px" OnSelectedIndexChanged="DropDownList33_SelectedIndexChanged" AutoPostBack="True">
                                        
                                        <asp:ListItem>Hearing</asp:ListItem>
                                        <asp:ListItem>Sight</asp:ListItem>
                                        <asp:ListItem>Smell/Taste</asp:ListItem>
                                        <asp:ListItem>Blind/Deaf</asp:ListItem>
                                        
                                </asp:DropDownList>
                                    <br />
                                    <asp:DropDownList Visible="false" ID="DropDownList34" runat="server" Width="104px">
                                        
                                        <asp:ListItem>Temporary Blind</asp:ListItem>
                                        <asp:ListItem>Temporary Deaf</asp:ListItem>
                                        <asp:ListItem>Permanently Blind</asp:ListItem>
                                        <asp:ListItem>Permanently Deaf</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="quirk">
                                    <asp:DropDownList ID="DropDownList35" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="secret">
                                    <asp:DropDownList ID="DropDownList36" runat="server" Width="104px">
                             
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="sick">
                                    <asp:DropDownList ID="DropDownList37" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        <asp:ListItem Value="-4">4</asp:ListItem>
                                        <asp:ListItem Value="-5">5</asp:ListItem>
                                        <asp:ListItem Value="-6">6</asp:ListItem>
                                        <asp:ListItem Value="-7">7</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="socialstigma">
                                   <asp:DropDownList ID="DropDownList38" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>
                                <div runat="server" visible="false" id="wanted">
                                    <asp:DropDownList ID="DropDownList39" runat="server" Width="104px">
                                        
                                        <asp:ListItem Value="-1">1</asp:ListItem>
                                        <asp:ListItem Value="-2">2</asp:ListItem>
                                        <asp:ListItem Value="-3">3</asp:ListItem>
                                        <asp:ListItem Value="-4">4</asp:ListItem>
                                        <asp:ListItem Value="-5">5</asp:ListItem>
                                        
                                </asp:DropDownList>
                                </div>

                            </div>
                    <asp:Button ID="Button39" runat="server" ValidationGroup="flawadd"  Text="Add" OnClick="Button39_Click" />
                    <asp:Button ID="Button40" runat="server" ValidationGroup="flawremove" Text="Remove" OnClick="Button40_Click" />
                    <asp:ListBox ID="ListBox6" runat="server"></asp:ListBox><br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="flawadd" runat="server" ControlToValidate="ListBox3" ErrorMessage="*Please choose a flaw to add" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="flawremove" runat="server" ControlToValidate="ListBox6" ErrorMessage="*Please choose a flaw to remove" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
                            <asp:Label ID="Label7" runat="server" ForeColor="Red"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
                    <br />
                    <br />
                    Miscellaneous<br />
                    <br />
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="Button48" runat="server" OnClick="Button48_Click" Text="Convert CP to Dices" Width="138px" />
                            <br />
                            <asp:Button ID="Button49" runat="server" Text="Convert SP to Dices" Width="138px" OnClick="Button49_Click" />
                            <br />
                            EMERGENCY DICE<br />
                            <asp:TextBox ID="TextBox21" runat="server" ReadOnly="True" Width="40px">0</asp:TextBox>
                            <asp:Button ID="Button42" runat="server" OnClick="Button42_Click" Text="Convert to Exp" />
                    <br />
                            EXP<br />
                            <asp:TextBox ID="TextBox22" runat="server" Height="22px" ReadOnly="True" Width="40px">0</asp:TextBox>
                            <asp:Button ID="Button41" runat="server" Text="Convert to Dice" OnClick="Button41_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br />
                    <asp:Button ID="Button47" runat="server" Text="Submit" OnClick="Button47_Click" />
                    <br />

                
          </div>
</asp:Content>

