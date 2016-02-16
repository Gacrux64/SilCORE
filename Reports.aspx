<%@ Page Title="" Language="C#" MasterPageFile="~/Template/CharacterTemplate.master" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Template_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
    Reports
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <h2 style="text-align:left;">User Registration</h2>

    <div runat="server" id="report1">
        <p id="userlog">Number of users registered:<span id="userLoginNumber"></span></p>
        <div runat="server" id="fromDate" style="width:35%; float:left;">From: <span id="startdate"></span> 
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" ForeColor="White" Height="37px" Width="122px" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </div>
        <div runat="server" id="toDate" style="width:35%; float:left;">
            To: <asp:Label ID="Label2" runat="server"></asp:Label>
            <span id="finishdate"></span>&nbsp;<asp:Calendar ID="Calendar2" runat="server" ForeColor="White" OnDayRender="Calendar2_DayRender" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
        </div>
    </div>
    <br style="clear:both"/>
    <br />
    <asp:Label ID="LabelDateCheck" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="ButtonDateCheck" runat="server" Text="Submit" OnClick="ButtonDateCheck_Click" />
    <hr />
    <h2 style="text-align:left">Average Statistic</h2>
    <div style="float:left;width:25%;"">
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
    <div style="float:left;width:25%;">
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
    <br style="clear:both;"/>
    <hr />
    <h2 style="text-align:left;">Exception Report</h2>
    <div runat="server" id="report2">
        <p>Registered users with no created characters:</p>
        <asp:listview ID="ListViewNoChars" runat="server" DataSourceID="SQLDataSourceNoChars">
            <AlternatingItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="USER_LOGINLabel" runat="server" Text='<%# Eval("USER_LOGIN") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="USER_LOGINTextBox" runat="server" Text='<%# Bind("USER_LOGIN") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>All users have characters.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="USER_LOGINTextBox" runat="server" Text='<%# Bind("USER_LOGIN") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="USER_LOGINLabel" runat="server" Text='<%# Eval("USER_LOGIN") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                <tr runat="server" style="">
                                    <th runat="server">USERS</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="">
                            <asp:DataPager ID="DataPager1"  PageSize="10" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Link" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="">
                    <td>
                        <asp:Label ID="USER_LOGINLabel" runat="server" Text='<%# Eval("USER_LOGIN") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:listview>
        <asp:sqldatasource ID="SQLDataSourceNoChars" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringSilCORE %>" SelectCommand="SELECT USER_LOGIN FROM USER_INFO LEFT JOIN CHARACTER ON USER_ID = CHARACTER_USER_ID
WHERE CHARACTER_ID IS NULL"></asp:sqldatasource>
    </div>
    <hr />
    <h2 style="text-align:left;">Character Creation Report</h2>
    <div runat="server" id="report3">
        <p>Characters created with the SilCORE Character Builder by user account.</p>
        <div runat="server" id="characterReport" style="margin-left:25px;">
            Username:
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SQLDataSourceUsers" DataTextField="USER_LOGIN" DataValueField="USER_ID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:sqldatasource ID="SQLDataSourceCharByUser" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringSilCORE %>" SelectCommand="SELECT [CHARACTER_ID], [CHARACTER_NAME], [CHARACTER_GAME_TYPE], [CHARACTER_DATE_CREATED] FROM [CHARACTER] WHERE ([CHARACTER_USER_ID] = @CHARACTER_USER_ID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="CHARACTER_USER_ID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:sqldatasource>
            <asp:SqlDataSource ID="SQLDataSourceUsers" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringSilCORE %>" SelectCommand="SELECT [USER_ID], [USER_LOGIN] FROM [USER_INFO]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:gridview ID="GridViewUserChars" runat="server" OnRowCommand="GridViewUserChars_RowCommand" AutoGenerateColumns="False" DataSourceID="SQLDataSourceCharByUser" DataKeyNames="CHARACTER_ID" AllowPaging="True">
                <Columns>
                    <asp:BoundField DataField="CHARACTER_ID" HeaderText="System ID" SortExpression="CHARACTER_ID" InsertVisible="False" ReadOnly="True" />
                    <asp:BoundField DataField="CHARACTER_NAME" HeaderText="Character Name" SortExpression="CHARACTER_NAME" />
                    <asp:BoundField DataField="CHARACTER_GAME_TYPE" HeaderText="Game Type" SortExpression="CHARACTER_GAME_TYPE" />
                    <asp:BoundField DataField="CHARACTER_DATE_CREATED" DataFormatString="{0:d}" HeaderText="Date Created" SortExpression="CHARACTER_DATE_CREATED" />
                    <asp:ButtonField CommandName="Detail" HeaderText="Detail View" ShowHeader="True" Text="Sheet" />
                </Columns>
                <PagerSettings Mode="NextPrevious" />
            </asp:gridview>
            
    </div>
 </div>
</asp:Content>

