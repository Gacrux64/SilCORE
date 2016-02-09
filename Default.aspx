<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderPageTitle" Runat="Server">
    Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderTitle" Runat="Server">
    Updates
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMainBox" Runat="Server">
    <asp:listview ID="ListViewNewsPosts" runat="server" DataSourceID="SqlDataSourceNews">
        <AlternatingItemTemplate>
            <span style="">
            Posted on:
            <asp:Label ID="UPDATE_POST_DATELabel" runat="server" Text='<%# Eval("UPDATE_POST_DATE", "{0:d}") %>'></asp:Label>
            <br />
            <asp:Label ID="UPDATE_POST_NEWSLabel" runat="server" Text='<%# Eval("UPDATE_POST_NEWS") %>'></asp:Label>
            <br />
            <br />
            </span>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <span style="">UPDATE_POST_DATE:
            <asp:TextBox ID="UPDATE_POST_DATETextBox" runat="server" Text='<%# Bind("UPDATE_POST_DATE") %>' />
            <br />
            UPDATE_POST_NEWS:
            <asp:TextBox ID="UPDATE_POST_NEWSTextBox" runat="server" Text='<%# Bind("UPDATE_POST_NEWS") %>' />
            <br />
            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            <br /><br /></span>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <span>No news has been posted yet.</span>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <span style="">UPDATE_POST_DATE:
            <asp:TextBox ID="UPDATE_POST_DATETextBox" runat="server" Text='<%# Bind("UPDATE_POST_DATE") %>' />
            <br />UPDATE_POST_NEWS:
            <asp:TextBox ID="UPDATE_POST_NEWSTextBox" runat="server" Text='<%# Bind("UPDATE_POST_NEWS") %>' />
            <br />
            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            <br /><br /></span>
        </InsertItemTemplate>
        <ItemTemplate>
            <span style="">
            Posted on:
            <asp:Label ID="UPDATE_POST_DATELabel" runat="server" Text='<%# Eval("UPDATE_POST_DATE", "{0:d}") %>'></asp:Label>
            <br />
            <asp:Label ID="UPDATE_POST_NEWSLabel" runat="server" Text='<%# Eval("UPDATE_POST_NEWS") %>'></asp:Label>
            <br />
            <br />
            </span>
        </ItemTemplate>
        <LayoutTemplate>
            <div id="itemPlaceholderContainer" runat="server" style="">
                <span runat="server" id="itemPlaceholder" />
            </div>
            <div style="">
                <asp:DataPager PageSize="3" ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="link" ShowFirstPageButton="True" ShowLastPageButton="True" FirstPageText="Newest" LastPageText="Oldest" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <span style="">UPDATE_POST_DATE:
            <asp:Label ID="UPDATE_POST_DATELabel" runat="server" Text='<%# Eval("UPDATE_POST_DATE") %>' />
            <br />
            UPDATE_POST_NEWS:
            <asp:Label ID="UPDATE_POST_NEWSLabel" runat="server" Text='<%# Eval("UPDATE_POST_NEWS") %>' />
            <br />
            <br /></span>
        </SelectedItemTemplate>
    </asp:listview>
    <asp:SqlDataSource ID="SqlDataSourceNews" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringSilCORE %>" SelectCommand="SELECT [UPDATE_POST_DATE], [UPDATE_POST_NEWS] FROM [UPDATE_POST]"></asp:SqlDataSource>
</asp:Content>

