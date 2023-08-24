<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TimeLinesEdit.aspx.cs" Inherits="TimeLinesEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <script src="TiemlineJquery/DateTimepickerUI/jquery-ui.min.js"></script>
    <script src="TiemlineJquery/DateTimepickerUI/TW.js"></script>
    <link href="TiemlineJquery/DateTimepickerUI/jquery-ui.structure.min.css" rel="stylesheet" />
    <link href="TiemlineJquery/DateTimepickerUI/jquery-ui.theme.min.css" rel="stylesheet" />
    <link href="TiemlineJquery/TimeLineEdit.css" rel="stylesheet" />
   <style>
       .ui-datepicker-trigger {                               
                               margin-top: 5px;
                               /*margin-bottom: -1px;*/
                               width:25px;
                               height:25px;
                              }
       .calendetemp{
           min-width:130px;
       }
       .divGrid{
           /*left:50%;
           margin-left:100px;*/
           width:960px ; margin:0 auto
       }
       #divDetail{
      
           position:absolute;
           left:50%;
           top:45%;
           margin-top:-150px;
           margin-left:-150px;
       }

        #divDetail > table > tr:nth-child(even){
            background-color:orange;
        }
        #divDetail > table > tr:nth-child(odd){
            background-color:yellow;
        }
        #backid img{
            position:fixed;
            top:15%;
            left:-510px;
            /*width:80px;*/
            /*height:585px;*/
        }
        .timelinetile{

        }
   </style>

    <div style="width:960px ; margin:0 auto;min-height:585px">
        <div id="backid">
        <a href='../TimeLines.aspx' ><img src="TiemlineJquery/timeimg.png"  alt="返回" title="返回" id="timebackimg" /></a>
        </div>
            
            <asp:GridView ID="GridViewTimExit" CssClass="divGrid" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="TimeLine_ID" DataSourceID="SqlDataSource1" OnRowCommand="GridViewTimExit_RowCommand"  OnRowUpdated="GridViewTimExit_RowUpdated" HorizontalAlign="Center" AllowSorting="True" >
                
                    <Columns>
                    <asp:TemplateField HeaderText="TimeID" SortExpression="TimeLine_ID" Visible="False">
                        <EditItemTemplate>
                            <asp:Label ID="LabTimeIdedit" runat="server" Text='<%# Eval("TimeLine_ID") %>' Visible="False"></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="LabTimeId" runat="server" Text='<%# Bind("TimeLine_ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Ptt_ID" HeaderText="Ptt_ID" SortExpression="Ptt_ID" Visible="False" />
                
                    <asp:TemplateField HeaderText="日期" SortExpression="TimeLine_Date">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtUpCalder" runat="server" onfocus="this.blur()" Text='<%# Bind("TimeLine_Date", "{0:d}") %>' Width="100px" Wrap="False"></asp:TextBox>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </EditItemTemplate>              
                        <ItemTemplate>
                            <asp:Label ID="txtCalder" runat="server" Text='<%# Bind("TimeLine_Date", "{0:d}") %>'></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle Width="120px" Wrap="True" />
                        <ItemStyle Width="130px" VerticalAlign="NotSet"  CssClass="calendetemp" />
                    </asp:TemplateField>
                       
                    <asp:BoundField DataField="TimeLine_Title" HeaderText="標題" SortExpression="TimeLine_Title" />
                    <asp:TemplateField HeaderText="描述" SortExpression="TimeLine_Des">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TimeLine_Des") %>' TextMode="MultiLine" Width="300px" Columns="5" Rows="5"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("TimeLine_Des") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="圖片">
                        <EditItemTemplate>
                           
                            <asp:FileUpload ID="UpFileUpload" runat="server" Width="150px" class=".upfimg" />
                            <asp:Image ID="UpdateImg" runat="server" Height="100px" Width="100px" />
                         
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="GridviewImg" runat="server" Height="100px" ImageUrl='<%# Eval("TimeLine_ID", "~/HandlerTimeImg.ashx?timelineID={0}") %>' onerror="this.src='TiemlineJquery/wecare-02.png'" Width="100px" />
                        </ItemTemplate>
                        <HeaderStyle Width="100px" />
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="True" ShowInsertButton="True">
                    <ControlStyle Width="40px" />
                    <HeaderStyle Width="100px" />
                    </asp:CommandField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandName="delete" OnClientClick="return confirm('再一次確認，您要刪除這筆資料嗎?')" Text="刪除"></asp:LinkButton>
                        </ItemTemplate>
                        <HeaderStyle Width="40px" />
                    </asp:TemplateField>
                </Columns>
      
                <EmptyDataRowStyle BorderWidth="0px" />
      
                <EmptyDataTemplate>
                    <div  id="divDetail" >
                        <div class="TimeDetailedit" >
                    <asp:DetailsView ID="DetailsViewInsert" runat="server" AutoGenerateRows="False" DataKeyNames="TimeLine_ID" DataSourceID="SqlDataSource1" DefaultMode="Insert" Height="400px" Width="450px" OnItemCommand="DetailsViewInsert_ItemCommand" OnItemInserted="DetailsViewInsert_ItemInserted" HorizontalAlign="Left" BorderStyle="None" >
                        <AlternatingRowStyle VerticalAlign="Middle" Width="200px" />
                        <CommandRowStyle HorizontalAlign="Center" Width="200px" />
                        <EditRowStyle Width="200px" />
                        <EmptyDataRowStyle Width="200px" />
                        <FieldHeaderStyle Width="200px" />
                        <Fields>
                            <asp:BoundField DataField="TimeLine_ID" HeaderText="TimeLine_ID" InsertVisible="False" ReadOnly="True" SortExpression="TimeLine_ID" />
                            <asp:TemplateField HeaderText="Ptt_ID" SortExpression="Ptt_ID" Visible="False">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Ptt_ID") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:TextBox ID="InsertxtPttID" runat="server" Text='<%# Bind("Ptt_ID") %>'></asp:TextBox>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Ptt_ID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="日期" SortExpression="TimeLine_Date">
                                <InsertItemTemplate>
                                    <asp:TextBox ID="TxtInsCalendar" runat="server" onfocus="this.blur()" Text='<%# Bind("TimeLine_Date", "{0:d}") %>' Wrap="False"></asp:TextBox>                                   
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtInsCalendar" ErrorMessage="請輸入值" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("TimeLine_Date") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle BorderStyle="None" />
                                <ItemStyle BorderStyle="None" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="TimeLine_Title" HeaderText="標題" SortExpression="TimeLine_Title" ControlStyle-CssClass="timelinetile" >
                            <HeaderStyle BorderStyle="None" />
                            <ItemStyle BorderStyle="None" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="描述" SortExpression="TimeLine_Des">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TimeLine_Des") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <InsertItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Height="150px" Rows="5" Text='<%# Bind("TimeLine_Des") %>' Width="300px" TextMode="MultiLine"></asp:TextBox>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("TimeLine_Des") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle BorderStyle="None" />
                                <ItemStyle BorderStyle="None" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="圖片">
                      
                                <InsertItemTemplate>
                                    <asp:FileUpload ID="InsFileUpload" runat="server" />
                                    <asp:Image ID="InsImage" runat="server" Height="100px" Width="100px" />
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle BorderStyle="None" />
                                <ItemStyle BorderStyle="None" />
                            </asp:TemplateField>
                            <asp:TemplateField ShowHeader="False">
                                <InsertItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Insert" Text="插入"></asp:LinkButton>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                    <asp:LinkButton ID="LbtnBack" runat="server" OnClick="LbtnBack_Click" CausesValidation="False">返回</asp:LinkButton>
                                    <div style="width:100px;height:30px;margin-left:10px" ><input id="demoword" type="button" value="DEMO" /></div>
                                </InsertItemTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="New" Text="新增"></asp:LinkButton>
                                </ItemTemplate>
                                <HeaderStyle BorderStyle="None" />
                                <ItemStyle BorderStyle="None" />
                            </asp:TemplateField>
                        </Fields>
                        <HeaderStyle Width="200px" Wrap="True" BorderStyle="None"/>
                        <InsertRowStyle Font-Names="微軟正黑體" Font-Size="Large" Font-Underline="False" Width="350px" />
                        <RowStyle VerticalAlign="Middle" Width="200px" BorderStyle="None" />
                    </asp:DetailsView>
                            </div>
                      </div> 
                </EmptyDataTemplate>
                
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" DeleteCommand="DELETE FROM [TimeLines] WHERE [TimeLine_ID] = @TimeLine_ID" InsertCommand="INSERT INTO [TimeLines] ([Ptt_ID], [TimeLine_Date], [TimeLine_Title], [TimeLine_Des]) VALUES (@Ptt_ID, @TimeLine_Date, @TimeLine_Title, @TimeLine_Des)" SelectCommand="SELECT [TimeLine_ID], [Ptt_ID], [TimeLine_Date], [TimeLine_Title], [TimeLine_Des] FROM [TimeLines] WHERE [Ptt_ID] = @Ptt_ID order by timeline_Date asc" UpdateCommand="UPDATE [TimeLines] SET [Ptt_ID] = @Ptt_ID, [TimeLine_Date] = @TimeLine_Date, [TimeLine_Title] = @TimeLine_Title, [TimeLine_Des] = @TimeLine_Des WHERE [TimeLine_ID] = @TimeLine_ID" >
                <DeleteParameters>
                    <asp:Parameter Name="TimeLine_ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:CookieParameter CookieName="PttID" DefaultValue=""  Name="Ptt_ID" Type="Int32" />
                    <%--<asp:Parameter Name="Ptt_ID" Type="Int32" DefaultValue=""/>--%>
                    <asp:Parameter DbType="Date" Name="TimeLine_Date" />
                    <asp:Parameter Name="TimeLine_Title" Type="String" />
                    <asp:Parameter Name="TimeLine_Des" Type="String" />
                    
                </InsertParameters>
                <SelectParameters>
                    <asp:CookieParameter CookieName="PttID" DefaultValue="1"  Name="Ptt_ID" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:CookieParameter CookieName="PttID" DefaultValue=""  Name="Ptt_ID" Type="Int32" />
                    <%--<asp:Parameter Name="Ptt_ID" Type="Int32" />--%>
                    <asp:Parameter DbType="Date" Name="TimeLine_Date" />
                    <asp:Parameter Name="TimeLine_Title" Type="String" />
                    <asp:Parameter Name="TimeLine_Des" Type="String" />                   
                    <asp:Parameter Name="TimeLine_ID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        <div style="height:70px;"></div>
            
    <br />
        <script>
            var rowindex = $("#ContentPlaceHolder2_GridViewTimExit tr").size();
            var Gridview = $("#ContentPlaceHolder2_GridViewTimExit td");
            var calender = $(this).children('input')[0]
            $(function () {
                for (var i = 0; i < rowindex; i++) {
                    $("#ContentPlaceHolder2_GridViewTimExit_txtUpCalder_" + i).datepicker({
                        showOn: "button",
                        buttonImage:"TiemlineJquery/DateTimepickerUI/images/calendar-icon.png",
                        buttonImageOnly: true,
                        buttonText: "Select date",
                        //showOtherMonths: true,
                        //selectOtherMonths: true
                    });
                }
            });

            $(function () {
                    $("#ContentPlaceHolder2_GridViewTimExit_DetailsViewInsert_TxtInsCalendar").datepicker({
                            showOn: "button",
                            buttonImage: "TiemlineJquery/DateTimepickerUI/images/calendar-icon.png",
                            buttonImageOnly: true,
                            buttonText: "Select date",
                });
            });
                      
            //顯示圖片
                 
            $("input[type='file']").change(function () {   //當FileUpload發生改變時觸發
                var up = $(this)[0];  //找到FileUpload  
                var img = $(this).next()[0];   //找到Image控制項
                if (up.files !=null) {
                   img.src = window.URL.createObjectURL(up.files[0]); //將圖片顯示出來
               }
            })

            //$("#ContentPlaceHolder2_GridViewTimExit_DetailsViewInsert_InsFileUpload").change(function () {
            //    var up = window.document.getElementById("ContentPlaceHolder2_GridViewTimExit_DetailsViewInsert_InsFileUpload");
            //    var img = window.document.getElementById("ContentPlaceHolder2_GridViewTimExit_DetailsViewInsert_InsImage");
            //        img.src = window.URL.createObjectURL(up.files[0]);           
            //})

            $(function () {

                $("#timebackimg").mouseover(function () { //滑鼠滑入時
                    if ($("#backid img").css('left')== '-' + 510 + 'px') {
                        $("#backid img").animate({ left: '0px' }, 600, 'swing');
                    }
                });


                $("#timebackimg").mouseleave(function () {　//滑鼠離開後
                    $("#backid img").animate({ left: '-' + 510 + 'px' }, 600, 'swing');
                });
            });

            $("#demoword").click(function () {
                $("#ContentPlaceHolder2_GridViewTimExit_DetailsViewInsert_TxtInsCalendar").val("2014-09-19");
                $(".timelinetile").val("頭痛");
                $("#ContentPlaceHolder2_GridViewTimExit_DetailsViewInsert_TextBox1").text("去W診所看醫師，安排做檢驗");
            })
        </script>


        </div>
</asp:Content>

