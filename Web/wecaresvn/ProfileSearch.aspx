<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="ProfileSearch.aspx.cs" Inherits="_wecaresvn_ProfileSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div style="margin: 0 auto; width: 960px;">
        <asp:Panel ID="Panel1" runat="server" Height="34px" Width="555px">
            <asp:Button ID="Button1" runat="server" Text="Button" Height="26px" Width="59px" />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="194px">
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="169px"></asp:TextBox>
        </asp:Panel>
        <div style="float: right; border: 1px solid Red; width: 200px; height: 200px; margin-right: 20px;">
            查調身份<br />
            radiobuttonlist
        </div>

        <asp:GridView ID="GridView1" runat="server" Height="200px" Width="720px" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
                <asp:BoundField DataField="ModelNumber" HeaderText="ModelNumber" SortExpression="ModelNumber" />
                <asp:BoundField DataField="ModelName" HeaderText="ModelName" SortExpression="ModelName" />
                <asp:BoundField DataField="ProductImage" HeaderText="ProductImage" SortExpression="ProductImage" />
                <asp:BoundField DataField="UnitCost" HeaderText="UnitCost" SortExpression="UnitCost" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:storeConnectionString %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>

        <br />

        <div style="float: right; border: 1px solid purple; height: 300px; width: 200px; margin-right: 120px; margin-top: 50px">
            功能按鈕置放區
        </div>
        <asp:Panel ID="Panel2" runat="server" Height="400px" Width="600px" ScrollBars="Auto">
            <div style="height: 21px; text-align: center;">
                基本資料欄位置放區
            </div>
        </asp:Panel>
        這是個人資料查詢及修改頁面
    </div>
</asp:Content>

