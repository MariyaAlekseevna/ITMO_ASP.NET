<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SummaryBD.aspx.cs" Inherits="ITMO_ASP.NET_Web_Labs_1_2_3_4_5_8_RSVP.SummaryBD" MasterPageFile="~/Site.master"%>


<asp:Content ID="MainContent2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Список участников</h2>
        <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="Rdata" HeaderText="Rdata" SortExpression="Rdata" />
            </Columns>
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ 
                 ConnectionStrings:SeminarBD %>" SelectCommand="SELECT [Name], [Email], [Phone], 
                 [WillAttend], [Rdata] FROM [GuestResponses]"></asp:SqlDataSource>
    </div>
</asp:Content>


<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Список участников</h2>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="Rdata" HeaderText="Rdata" SortExpression="Rdata" />
            </Columns>
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SeminarBD %>" SelectCommand="SELECT [Name], [Email], [Phone], [WillAttend], [Rdata] FROM [GuestResponses]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>--%>
