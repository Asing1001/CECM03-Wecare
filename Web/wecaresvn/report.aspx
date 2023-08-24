<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="report.aspx.cs" Inherits="report1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <style>
        #searchbar .dropdown-menu
        {
            display:block;
            padding-bottom: 2px;
            position:initial;
            min-width: 100px;
            margin:5px;
        }

       th 
        {
            background-color: gray;
            color:white;
        } 
    </style>
    <script src="ChartReport/highcharts.js"></script>
    <script src="ChartReport/exporting.js"></script>
    <script src="js/TeamReportSQ.js"></script>

    
<%--<div style="width:960px; height:750px;margin:0 auto;">--%>
    <div class="container" style="height:1000px">
       <%--圖片--%>
        <div class="row">
            <img src="images/RP.jpg" class="img-responsive col-xs-offset-2 col-xs-8"  />
        </div>
        
        <%--搜尋列--%>
        <div class="row " id="searchbar" style="margin-top:30px;">
            <div class="col-xs-offset-3 col-xs-2 text-right" style="font-size:17px; margin-top:7px">
                      <asp:Label ID="Label1" runat="server" Text="搜尋類別"></asp:Label>
            </div>
            <div style="margin-right:0 !important">
                <asp:DropDownList ID="ReportSearchDDL" runat="server" AutoPostBack="True" CssClass="dropdown-menu">
                    <asp:ListItem Value="2">檢查項目</asp:ListItem>
                    <asp:ListItem Value="1">檢查時間</asp:ListItem>
                </asp:DropDownList>
          
                <asp:DropDownList ID="DateDDL" runat="server" AutoPostBack="True" CssClass="dropdown-menu" DataSourceID="reportYearDLL" DataTextField="Column1" DataValueField="Column1"   AppendDataBoundItems="True" Width="100px">
                    <asp:ListItem Selected="True" Value="1">請選擇</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-xs-2" style="margin-left:0 !important">
                <asp:SqlDataSource ID="reportYearDLL" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT DISTINCT  DATEPART (yyyy,[檢驗日期]) FROM [View_ExamCalendar] WHERE (病患名稱 = @病患名稱) AND (結果值 <> '尚未檢測')">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Ptt_Nam" Name="病患名稱" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:DropDownList ID="ExamDDL" runat="server" AppendDataBoundItems="True" CssClass="dropdown-menu" AutoPostBack="True" DataSourceID="reportExamDLL" DataTextField="檢驗項目" DataValueField="檢驗項目" Width="100px">
                    <asp:ListItem Selected="True" Value="1">請選擇</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="reportExamDLL" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT DISTINCT [檢驗項目] FROM [View_ExamCalendar] WHERE ([病患名稱] = @病患名稱)AND (結果值 <> '尚未檢測')" OnSelected="reportExamDLL_Selected">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Ptt_Nam" Name="病患名稱" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
        
             
           </div>
      </div>
    
            <%--table--%>
        <div class="row">
            <asp:GridView ID="GridView1" runat="server" CssClass="col-xs-offset-3 col-xs-6 col-xs-12 table-bordered table-condensed table-responsive  " AutoGenerateColumns="False" DataSourceID="reportYearData" Width="500px" OnRowDataBound="GridView1_RowDataBound" Height="50px" AllowPaging="True" PageSize="5" OnPageIndexChanging="GridView1_PageIndexChanging" ShowHeaderWhenEmpty="True">
                <Columns>
                    <asp:BoundField DataField="病患名稱" HeaderText="病患名稱" SortExpression="病患名稱" Visible="False" >
                    <HeaderStyle Height="40px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="檢驗日期" HeaderText="檢驗日期" SortExpression="檢驗日期" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="檢驗項目" HeaderText="檢驗項目" SortExpression="檢驗項目" />
                    <asp:BoundField DataField="主治醫師" HeaderText="主治醫師" SortExpression="主治醫師" />
                    <asp:BoundField DataField="結果值" HeaderText="結果值" SortExpression="結果值" />
                    <asp:BoundField DataField="檢驗結果" HeaderText="檢驗結果" SortExpression="檢驗結果" />
                </Columns>
                <EmptyDataTemplate>
                    尚無資料
                </EmptyDataTemplate>
            </asp:GridView>
            <asp:HiddenField ID="HiddenField1" runat="server"/>
            <asp:SqlDataSource ID="reportYearData" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT 病患名稱, 檢驗日期, 檢驗項目, 主治醫師, 結果值, 檢驗結果 FROM View_ExamCalendar WHERE (病患名稱 = @病患名稱) AND (DATEPART(yyyy, 檢驗日期) = @Column1) AND (結果值 &lt;&gt; '尚未檢測') ORDER BY 檢驗日期">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Ptt_Nam" Name="病患名稱" Type="String" />
                    <asp:ControlParameter ControlID="DateDDL" Name="Column1" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="reportExamData" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT 病患名稱, 檢驗日期, 檢驗項目, 主治醫師, 結果值, 檢驗結果 FROM View_ExamCalendar WHERE (病患名稱 = @病患名稱) AND (檢驗項目 = @檢驗項目) AND (結果值 &lt;&gt; '尚未檢測') ORDER BY 檢驗日期">
                <SelectParameters>
                    <asp:Parameter DefaultValue="Ptt_Nam" Name="病患名稱" Type="String" />
                    <asp:ControlParameter ControlID="ExamDDL" Name="檢驗項目" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="GetAllData" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT 病患名稱, 檢驗日期, 檢驗項目, 主治醫師, 結果值, 檢驗結果 FROM View_ExamCalendar WHERE (病患名稱 = @病患名稱) AND (結果值 &lt;&gt; '尚未檢測') ORDER BY 檢驗日期">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Ptt_Nam" Name="病患名稱" Type="String" />
                    </SelectParameters>
            </asp:SqlDataSource>
            </div>
     <br />
     <br />
      <div class="row" >
          <div class="col-xs-offset-3 col-xs-6">
          <div id="container"   >
          </div>
              </div>
      </div>
    </div>
</asp:Content>

