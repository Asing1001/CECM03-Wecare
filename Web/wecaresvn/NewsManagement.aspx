<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="NewsManagement.aspx.cs" Inherits="_wecaresvn_NewsManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <script src="js/myAlert.js"></script>
   
    
     <div id="checkDelete"style="display:none;width:350px;margin:300px auto;" >
    
    <div id="checkD" style="width:350px;" ><label style="color:white"> 確認是否刪除??</label></div>
 <br />
    <div style="margin:0 auto;width:310px">
         
       <input type="button" id="btnCan" class="btnDel" value="取消" />
 <asp:Button runat="server" ForeColor="white" Text="刪除"  OnClick="btndelete_Click" Width="150" ID="btndelete"  BorderWidth="3px" BorderStyle="Groove" BackColor="darkred" Font-Underline="True" Font-Bold="True" />
         </div>
       
    <br />
</div>
    
     <div style="width: 960px;   margin:10px auto;">
       
         <div  class="clsNewsTable">
        <div class="NewsSearch" >
          <div style="height:50px;width:100%;background-image:url('images/newsSearch.jpg');background-size:cover"></div>
            <br />     
            &nbsp;
             
             <asp:DropDownList ID="DropDownList1" runat="server">
                     <asp:ListItem Value="News_Title">標題</asp:ListItem>
                     <asp:ListItem Value="News_Cont">內容</asp:ListItem>
                     <asp:ListItem Value="News_Type">分類</asp:ListItem>
                 </asp:DropDownList>
            選擇搜尋方式
            <br />
              <br />
            
                <div style="height:21px; width:38px; background-color:#99cc33;border-radius:15px;text-align:center;float:left">  <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged" Width="161px"></asp:TextBox></div>                      
          <br />
           
              <hr style="color:black;" />
            <div class="btnS" style="background-image:url('images/btnOK.jpg'); background-size:cover;height:25px;width:54px; float:right"  ></div>
        </div>
                  



             <div style="float:right;width:80%">
        <asp:GridView ID="GridView1"  BorderStyle="None" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="News_ID" DataSourceID="SqlDataSource1" OnRowCreated="GridView1_RowCreated" Width="100%" OnRowDataBound="GridView1_RowDataBound" PageSize="5" AllowSorting="True" Height="100px">
            <Columns>
                <asp:BoundField DataField="News_ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="News_ID" Visible="False" >
                <HeaderStyle BackColor="#990000" ForeColor="White" Width="50px" />
                <ItemStyle BorderStyle="None" />
                </asp:BoundField>
                <asp:BoundField DataField="News_Date" DataFormatString="{0:d}" HeaderText="日期">
                <HeaderStyle Width="120px" BackColor="#990000" ForeColor="White" HorizontalAlign="Center" />
                <ItemStyle BorderStyle="None" ForeColor="#990000" />
                </asp:BoundField>
                <asp:BoundField DataField="News_Type" HeaderText="分類" SortExpression="News_Type">
                <HeaderStyle Width="100px" BackColor="#990000" ForeColor="White" HorizontalAlign="Center" />
                <ItemStyle BorderStyle="None" ForeColor="#990000" />
                </asp:BoundField>
                <asp:HyperLinkField DataNavigateUrlFields="News_ID" DataNavigateUrlFormatString="~/NewsManagement.aspx?News_ID={0}" DataTextField="News_Title" HeaderText="標題" >
                <HeaderStyle BackColor="#990000" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle BorderStyle="None" />
                </asp:HyperLinkField>
                <asp:BoundField DataField="News_Cont" HeaderText="內文" SortExpression="News_Cont" Visible="False" />
            </Columns>
            <FooterStyle BorderStyle="None" />
            <HeaderStyle HorizontalAlign="Center" Height="40px" />
            <PagerStyle HorizontalAlign="Right" BorderColor="White" BorderStyle="None" Font-Size="Small" Font-Bold="True" Height="15px" Width="50%" />
            <SortedAscendingHeaderStyle BackColor="#660033" Font-Bold="True" Font-Overline="False" />
            <SortedDescendingHeaderStyle BackColor="#996600" Font-Bold="True" />
        </asp:GridView>
</div>
</div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT * FROM [News] ORDER BY [News_Date] DESC" DeleteCommand="DELETE FROM [News] WHERE [News_ID] = @News_ID" InsertCommand="INSERT INTO [News] ([News_Type], [News_Title], [News_Cont], [News_Date]) VALUES (@News_Type, @News_Title, @News_Cont, @News_Date)" UpdateCommand="UPDATE [News] SET [News_Type] = @News_Type, [News_Title] = @News_Title, [News_Cont] = @News_Cont, [News_Date] = @News_Date WHERE [News_ID] = @News_ID" ProviderName="System.Data.SqlClient">
            <DeleteParameters>
                <asp:Parameter Name="News_ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="News_Type" Type="String" />
                <asp:Parameter Name="News_Title" Type="String" />
                <asp:Parameter Name="News_Cont" Type="String" />
                <asp:Parameter Name="News_Date" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="News_Type" Type="String" />
                <asp:Parameter Name="News_Title" Type="String" />
                <asp:Parameter Name="News_Cont" Type="String" />
                <asp:Parameter Name="News_Date" Type="DateTime" />
                <asp:Parameter Name="News_ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

       
     
   
        <div style="margin:0 auto;height:400px">
         <div style="width:100%;border:none;float:left">

<div  class="clsNewsDeTable">
<asp:DetailsView  runat="server" AutoGenerateRows="False" DataKeyNames="News_ID" DataSourceID="SqlDataSource3" Height="300px" Width="960px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="3px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HeaderStyle-BackColor="#371200" ID="dv1">
            <CommandRowStyle Font-Size="X-Large" HorizontalAlign="Center" />
            <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <FieldHeaderStyle BorderStyle="None" HorizontalAlign="Center" Font-Bold="True" Font-Size="Large" />
            <Fields>
                <asp:BoundField DataField="News_ID" HeaderText="News_ID" InsertVisible="False" ReadOnly="True" SortExpression="News_ID" Visible="False" />
                <asp:BoundField DataField="News_Date" DataFormatString="{0:d}" HeaderText="日期" SortExpression="News_Date">
                <HeaderStyle BorderColor="White" ForeColor="White" Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" BorderWidth="1px" BorderStyle="Solid" />
                <ItemStyle BackColor="White" ForeColor="Black" Height="15px" HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="News_Type"  HeaderText="分類" SortExpression="News_Type" >
                <HeaderStyle BorderColor="White" ForeColor="White" Height="15px" Width="100px" BorderStyle="Solid" BorderWidth="1px" />
                <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:BoundField DataField="News_Title" HeaderText="標題" SortExpression="News_Title" >
                <HeaderStyle BorderColor="White" BorderWidth="1px" ForeColor="White" Height="15px" Width="100px" BorderStyle="Solid" />
                <ItemStyle ForeColor="Black" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="內文" SortExpression="News_Cont">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("News_Cont") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("News_Cont") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox8" runat="server" BorderStyle="None" Height="150px" Text='<%# Bind("News_Cont") %>' TextMode="MultiLine" Width="700px" ReadOnly="True"></asp:TextBox>
                    </ItemTemplate>
                    <HeaderStyle BorderColor="White" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Left" Height="200px" />
                </asp:TemplateField>
                
            </Fields>
            <FooterStyle BackColor="#003300" ForeColor="White" />
            <HeaderStyle Font-Bold="True" ForeColor="White" Font-Size="Large" Font-Underline="False" BackColor="#993300" />
            <PagerSettings Mode="NumericFirstLast" PageButtonCount="6" />
            <PagerStyle BackColor="Black" Font-Size="XX-Large" ForeColor="#CC3300" HorizontalAlign="Center" BorderStyle="None" Font-Bold="True" Width="400px" />
            <RowStyle BackColor="White" BorderColor="#990033" Font-Size="Large" />
        </asp:DetailsView>
</div>




<div  class="clsNewsDeTable">
 <asp:DetailsView  runat="server" AutoGenerateRows="False" DataKeyNames="News_ID" DataSourceID="SqlDataSource3" Height="460px" Width="960px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="3px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HeaderStyle-BackColor="#371200" ID="dv2">
            <CommandRowStyle Font-Size="X-Large" HorizontalAlign="Center" />
            <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <FieldHeaderStyle BorderStyle="None" HorizontalAlign="Center" Font-Bold="True" Font-Size="Large" />
            <Fields>
                <asp:BoundField DataField="News_ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="News_ID" >
                <HeaderStyle BorderColor="White" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" Height="10px" HorizontalAlign="Center" Width="100px" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="日期" SortExpression="News_Date">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("News_Date") %>' Width="100px"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" onfocus="this.blur()" Text='<%# Bind("News_Date", "{0:d}") %>' TextMode="Date" Width="189px" Height="30px"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("News_Date", "{0:d}") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderColor="White" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" Height="15px" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                    <ItemStyle ForeColor="Black" Height="15px" HorizontalAlign="Left" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="分類" SortExpression="News_Type">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("News_Type") %>' Height="25px" Width="51px"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("News_Type") %>' Height="25px" Width="50px"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("News_Type") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderColor="White" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" Height="15px" Width="100px" />
                    <ItemStyle HorizontalAlign="Left" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="標題" SortExpression="News_Title">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("News_Title") %>' Width="960px"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("News_Title") %>' Width="960px"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("News_Title") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle BorderColor="White" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" Height="15px" Width="100px" />
                    <ItemStyle ForeColor="Black" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="內文" SortExpression="News_Cont">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Height="150px" Text='<%# Bind("News_Cont") %>' TextMode="MultiLine" Width="100%"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Height="150px" Text='<%# Bind("News_Cont") %>' TextMode="MultiLine" Width="100%"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox7" runat="server" Height="150px" Text='<%# Bind("News_Cont") %>' TextMode="MultiLine" Width="100%" ReadOnly="True"></asp:TextBox>
                    </ItemTemplate>
                    <HeaderStyle BorderColor="White" BorderStyle="Solid" BorderWidth="1px" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Height="150px" />
                    <ItemStyle HorizontalAlign="Left" Height="150px" Width="700px" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="編輯" ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Insert" Text="插入" OnClientClick="sAlert(&quot;新增成功&quot;)"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="New" Text="新增"></asp:LinkButton>
                        &nbsp;&nbsp;<input id="DeleteC" type="button"  value="刪除" style="border:1px solid red;border-radius:5px; background-color: #CC3300; color: #FFFFFF; font-size: 20px;"/>
                    </ItemTemplate>
                    <HeaderStyle Height="50px" />
                    <ItemStyle BackColor="White" Height="50px" HorizontalAlign="Center" />
                </asp:TemplateField>
                
            </Fields>
            <FooterStyle BackColor="#003300" ForeColor="White" />
            <HeaderStyle Font-Bold="True" ForeColor="White" Font-Size="Large" Font-Underline="False" BackColor="#993300" />
            <PagerSettings Mode="NumericFirstLast" PageButtonCount="6" />
            <PagerStyle BackColor="Black" Font-Size="XX-Large" ForeColor="#CC3300" HorizontalAlign="Center" BorderStyle="None" Font-Bold="True" Width="400px" />
            <RowStyle BackColor="White" BorderColor="#990033" Font-Size="Large" />
        </asp:DetailsView>
    </div>
             <br/>
             <br/>

             <br/>
             <br/>
           
             <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" DeleteCommand="DELETE FROM [News] WHERE [News_ID] = @News_ID" InsertCommand="INSERT INTO [News] ([News_Type], [News_Title], [News_Cont], [News_Date]) VALUES (@News_Type, @News_Title, @News_Cont, @News_Date)" SelectCommand="SELECT * FROM [News] WHERE ([News_ID] = @News_ID)" UpdateCommand="UPDATE [News] SET [News_Type] = @News_Type, [News_Title] = @News_Title, [News_Cont] = @News_Cont, [News_Date] = @News_Date WHERE [News_ID] = @News_ID">
                 <DeleteParameters>
                     <asp:Parameter Name="News_ID" Type="Int32" />
                 </DeleteParameters>
                 <InsertParameters>
                     <asp:Parameter Name="News_Type" Type="String" />
                     <asp:Parameter Name="News_Title" Type="String" />
                     <asp:Parameter Name="News_Cont" Type="String" />
                     <asp:Parameter Name="News_Date" Type="DateTime" />
                 </InsertParameters>
                 <SelectParameters>
                     <asp:QueryStringParameter Name="News_ID" QueryStringField="News_ID" Type="Int32" DefaultValue="17" />
                 </SelectParameters>
                 <UpdateParameters>
                     <asp:Parameter Name="News_Type" Type="String" />
                     <asp:Parameter Name="News_Title" Type="String" />
                     <asp:Parameter Name="News_Cont" Type="String" />
                     <asp:Parameter Name="News_Date" Type="DateTime" />
                     <asp:Parameter Name="News_ID" Type="Int32" />
                 </UpdateParameters>
             </asp:SqlDataSource>

             </div>
             
           
            
            

        </div>
        
        <br />
        
        <br />
        <br />
        <br />
    </div>
    
    
   
    <script>
        $(function(){
        
            $("#DeleteC").click(function () {
            $("#PtH").css("height", "300px");
            $("#ContentPlaceHolder2_GridView1").css("display", "none");
            $("#ContentPlaceHolder2_dv2").css("display", "none");
            $(".NewsSearch").css("display", "none");
            $("hr").css("display", "none");

            $("body").css("background", "gray");
            $("#checkDelete,#checkDelete div").css("display", "block");



            }).mouseover(function () {
                $(this).css("background-color", "#FFFFFF ");
                $(this).css("color", "#CC3300");
                
            }).mouseleave(function () {

 $(this).css("background-color"," #CC3300");
                $(this).css("color","#FFFFFF");

            });
            $("#btnCan").click(function () {
                $("#PtH").css("height", "0px")
                $("body").css("background", "white")
                $("#ContentPlaceHolder2_GridView1").toggle();
                $("#ContentPlaceHolder2_dv2").toggle();
                $(".NewsSearch").toggle();
                $("hr").toggle();
                $("#checkDelete").toggle(1000);

            })




        });
    </script>

</asp:Content>

