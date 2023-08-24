<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="SatisfactionQuestionnaire.aspx.cs" Inherits="SatisfactionQuestionnaire" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
    <link href="css/star-rating.css" rel="stylesheet" />
    <link href="css/SQtextslider.css" rel="stylesheet" />
    <style>
    th
    {
        background-color: gray;
        color:white;
    }
        #lotteryGame .modal-body 
    {
        max-height: 600px;
    }
        #lotteryBtn 
        {
            cursor:pointer;
        }

        .direct{
            width:180px;
            height:180px;
            margin-top:220px;
            margin-left:118px;
            position:absolute;
        }
    </style>
    <script src="js/TeamReportSQ.js"></script>
    <script src="js/star-ratings.js"></script>
    <script src="js/jquery.easing.min.js"></script>
    <script src="js/jQueryRotate.2.2.js"></script>
    <script src="js/jquery.textslider.min.js"></script>
    <script src="js/myAlert.js"></script>

    <script>
        
        jQuery(document).ready(function () {
            //評價star
            $(".rating-kv").rating();

            //跑馬燈textslider
            $('.slideText').textslider({
                direction: 'scrollUp', // 捲動方向: scrollUp向上, scrollDown向下
                scrollNum: 0.1, // 一次捲動幾個元素
                scrollSpeed: 50, // 捲動速度(ms)
                pause: 80 // 停頓時間(ms)
            });
           
        });
    </script>
    <div class="container" style="height:800px">
        <%--圖片--%>
        <div class="row">
            <img src="images/CustomerSatisfaction.jpg" class="img-responsive col-xs-offset-2 col-xs-8 "  />
        </div>
        <div class="row">        <%-- 獲獎名單--%>
         <div class="col-md-2 left" >
             <img src="images/RotateList.png" class="img-responsive"  />
                  <div id="slideText" class="slideText">
                      <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                  </div>
                  
         </div>
        <%--table--%>
        <div class="col-md-8 left" >
        <h4>請提供您寶貴的意見，您的指教將是我們進步的動力！</h4>
             <asp:GridView ID="GridView1" runat="server" CssClass=" table-bordered table-condensed table-responsive " AutoGenerateColumns="False" DataKeyNames="Eva_ID" DataSourceID="SqlDataSource1" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" ShowHeaderWhenEmpty="True">
                 <Columns>
                     <asp:BoundField DataField="Eva_ID" HeaderText="評價編號" SortExpression="Eva_ID" ReadOnly="True" >
                     <HeaderStyle HorizontalAlign="Center" />
                     </asp:BoundField>
                     <asp:BoundField DataField="Staff_Name" HeaderText="醫生名稱" SortExpression="Staff_Name" >
                     <HeaderStyle HorizontalAlign="Center" />
                     </asp:BoundField>
                     <asp:BoundField DataField="Diag_ND" HeaderText="看診日期" SortExpression="Diag_ND" DataFormatString="{0:d}" >
                     <HeaderStyle HorizontalAlign="Center" />
                     </asp:BoundField>
                     <asp:TemplateField HeaderText="是否評分" SortExpression="Eva_ID" >
                         <EditItemTemplate>
                             <asp:Label ID="Label1" runat="server" Text='<%# Eval("Eva_ID") %>'></asp:Label>
                         </EditItemTemplate>
                         <ItemTemplate>
                             <asp:HyperLink ID="HyperScore" runat="server" NavigateUrl='<%# "SatisfactionQuestionnaire.aspx?EvaID="+Eval("Eva_ID") %>'  Text='<%# ClassUtility.getEvaSco((int)Eval("Eva_ID")) %>' Enabled='<%# ClassUtility.Readonly((object)Eval("Eva_Sco")) %>' ></asp:HyperLink>
                         </ItemTemplate>
                         <HeaderStyle HorizontalAlign="Center" />
                     </asp:TemplateField>
                      <asp:BoundField DataField="Eva_Com" HeaderText="評語" SortExpression="Eva_Com" ReadOnly="True" >
                          <HeaderStyle HorizontalAlign="Center" />
                     <ItemStyle Width="350px" />
                     </asp:BoundField>
                     <asp:HyperLinkField DataTextField="Eva_Rlt" HeaderText="參加抽獎" >
                     <ItemStyle Width="92px" />
                     </asp:HyperLinkField>
                     
                 </Columns>
                 <EmptyDataTemplate>
                     尚無資料
                 </EmptyDataTemplate>
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT [Eva_ID], [Diag_ND], [Staff_Name],[Eva_Sco],[Eva_Com],[Eva_Rlt] FROM [View_Evaluation] WHERE ([Ptt_ID] = @Ptt_ID)">
                 <SelectParameters>
                     <asp:CookieParameter CookieName="PttID" Name="Ptt_ID" Type="Int32" />
                 </SelectParameters>
             </asp:SqlDataSource>
             </div>
           <%-- 編輯--%>
            <div class="col-md-1" style="margin-top:30px">
             <asp:FormView ID="FormView1" runat="server" DataSourceID="SqlDataSource2" DataKeyNames="Eva_ID" DefaultMode="Edit" >
                 <EditItemTemplate>
                     
                     評分編號:
                     <asp:Label ID="Eva_IDLabel1" runat="server" Text='<%# Eval("Eva_ID") %>' />
                     <br />
                     評分:
                     <asp:HiddenField ID="TextBox2" runat="server" Value='<%# Bind("Eva_Sco") %>'/>
                     <input id="input-star" value="0" type="number" class="rating" min="0" max="5" step="1" data-size="xs" />
                     <br />
                     評語:<br />
                     <asp:TextBox ID="Eva_ComTextBox" runat="server" Text='<%# Bind("Eva_Com") %>' Height="77px" MaxLength="20" TextMode="MultiLine" />
                     <br />
                     (評語:限20字，送出後無法修改)<br/>
                     <br/>
                     <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="送出" OnClick="UpdateButton_Click" />
                     &nbsp;
                     <asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                 </EditItemTemplate>
             </asp:FormView>
             
             <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT [Eva_ID], [Eva_Sco], [Eva_Com] FROM [Evaluation] WHERE ([Eva_ID] = @Eva_ID)" UpdateCommand="UPDATE [Evaluation] SET [Eva_Sco] = @Eva_Sco, [Eva_Com] = @Eva_Com WHERE [Eva_ID] = @Eva_ID">
                 <SelectParameters>
                     <asp:QueryStringParameter Name="Eva_ID" QueryStringField="EvaID" Type="Int32" />
                 </SelectParameters>
                 <UpdateParameters>
                     <asp:Parameter Name="Eva_Sco" Type="Int32" />
                     <asp:Parameter Name="Eva_Com" Type="String" />
                     <asp:Parameter Name="Eva_ID" Type="Int32" />
                 </UpdateParameters>
             </asp:SqlDataSource>
             </div>

            </div>
        </div>

      <div class="modal fade " id="lotteryGame" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="false" >
         <div class="modal-dialog modal-lg" style="margin-top:80px;" >
         <div class="modal-content" >
             <%-- 表頭--%> 
<%--         <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
             </div>--%>

             <%-- 身體--%>  
             <div class="modal-body" id="forgetPwd_details" style="background-image:url(../images/RotateAllBG7.jpg) ;background-size:cover;position:absolute; width: 700px;height:500px ">
		        <div class="direct"  id="lotteryBtn" style="background-image:url(../images/rotate-static18.png)"; >
		        </div>
             </div>
          </div>
         </div>
	    </div>

</asp:Content>

