<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="CommonHealthModify.aspx.cs" Inherits="CommonHealthModify" %>







<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <div id="PtH" style="height:0px;width:100%"></div>
<div id="checkDelete"style="display:none;width:350px;margin:0 auto;" >
    
    <div id="checkD" style="width:350px;" ><label style="color:white"> 確認是否刪除??</label></div>
 <br />
    <div style="margin:0 auto;width:310px">
         
       <input type="button" id="btnCan" class="btnDel" value="取消" />
 <asp:Button runat="server" ForeColor="white" Text="刪除"  OnClick="btndelete_Click" Width="150" ID="Button1"  BorderWidth="3px" BorderStyle="Groove" BackColor="darkred" Font-Underline="True" Font-Bold="True" />
         </div>
       
    <br />
</div>











    
    <div id="newtable" style="margin-top:10px;margin-left:5%;height:120%; width:350px;float:right;position:fixed ">
             
              <div id="editb" style="color:white;background-image:url(images/edit.png);background-size:contain;background-repeat:no-repeat">編輯 </div>
     <asp:Table  ID="Table2" runat="server" Height="400px" Width= "350px" BackColor="White" BorderColor="Maroon" BorderStyle="Double" Visible="True">
                  <asp:TableRow runat="server" Width="100px">
                      <asp:TableCell runat="server" Width="50px">
                          <asp:Label ID="Label5" runat="server" Text="分類"></asp:Label> 

</asp:TableCell>
                      <asp:TableCell runat="server" Width="270px">
                          <asp:TextBox ID="TextBox4" style="margin:3px" runat="server"></asp:TextBox>
                        <div id="circle" >  <asp:Label ID="sindx"  ForeColor="White" runat="server" Text=""></asp:Label></div>
</asp:TableCell>
                  </asp:TableRow>
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server"> <asp:Label ID="Label6" runat="server" Text="標題"></asp:Label> 

</asp:TableCell>
                      <asp:TableCell runat="server">
                          <asp:TextBox ID="TextBox5" style="margin:3px" runat="server"></asp:TextBox>
</asp:TableCell>
                  </asp:TableRow>
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server"> <asp:Label ID="Label7" runat="server" Text="內文"></asp:Label>
</asp:TableCell>
                      <asp:TableCell runat="server">
                          <asp:TextBox ID="TextBox6" style="margin:3px" runat="server" height="100px" width="200px" TextMode="MultiLine"></asp:TextBox> 

</asp:TableCell>
                  </asp:TableRow>
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server">
                          <asp:Label ID="Label8" runat="server" Text="圖片"></asp:Label> 

</asp:TableCell>
                      <asp:TableCell runat="server" >
                          <asp:FileUpload style="margin:3px" ID="FileUpload1" runat="server" />
                          <asp:Image style="margin:3px" ID="Image2" runat="server" Height="100" Width="100" />

</asp:TableCell>
                      
                      
                       </asp:TableRow>
                  <asp:TableRow>
                     
                       <asp:TableCell ColumnSpan="2" VerticalAlign="Middle" HorizontalAlign="Center">
<br />
<asp:Button runat="server" Text="更新"  OnClick="btnupdata_Click"  Width="150" ID="btnupdata" BorderStyle="Ridge" BorderWidth="5px" BackColor="Maroon" ForeColor="White" Font-Bold="True" />

  
          <input type="button" class="btnDel" value="刪除" id="btnDel"/>                                     

                           <br /> 
                            <br />
                      </asp:TableCell>
                  </asp:TableRow>
              </asp:Table>
          
              
               <div id="newb" style="color:white;background-image:url(images/new.png);background-size:contain;background-repeat:no-repeat"> 新增</div>
              <asp:Table  ID="Table1" runat="server" Height="400px" Width="350px" BackColor="White" BorderColor="Maroon" BorderStyle="Double" Visible="True">
                  <asp:TableRow runat="server" Width="100px">
                      <asp:TableCell runat="server" Width="50px">
                          <asp:Label ID="Label1" runat="server" Text="分類"></asp:Label> 

</asp:TableCell>
                      <asp:TableCell runat="server" Width="270px">
               
                           <asp:TextBox ID="TextBox1" style="margin:3px" runat="server"></asp:TextBox>
</asp:TableCell>
                  </asp:TableRow>
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server"> <asp:Label ID="Label2" runat="server" Text="標題"></asp:Label> 

</asp:TableCell>
                      <asp:TableCell runat="server">
                          <asp:TextBox ID="TextBox2" style="margin:3px" runat="server"></asp:TextBox>
</asp:TableCell>
                  </asp:TableRow>
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server"> <asp:Label ID="Label3" runat="server" Text="內文"></asp:Label>
</asp:TableCell>
                      <asp:TableCell runat="server">
                          <asp:TextBox ID="TextBox3" style="margin:3px" runat="server" height="100px" width="200px" TextMode="MultiLine"></asp:TextBox> 

</asp:TableCell>
                  </asp:TableRow>
                  <asp:TableRow runat="server">
                      <asp:TableCell runat="server">
                          <asp:Label ID="Label4" runat="server" Text="圖片"></asp:Label> 

</asp:TableCell>
                      <asp:TableCell runat="server" >
                          <asp:FileUpload style="margin:3px" ID="FileUpload3" runat="server" />
                          <asp:Image style="margin:3px" ID="Image1" runat="server" Height="100" Width="100" />

</asp:TableCell>
                      
                      
                       </asp:TableRow>
                  <asp:TableRow>
                      <asp:TableCell ColumnSpan="2" VerticalAlign="Middle" HorizontalAlign="Center">
                          <br />
<asp:Button runat="server" Text="新增"    BorderStyle="Ridge" BorderWidth="5px" BackColor="Maroon" ForeColor="White" Font-Bold="True" OnClick="btnNew_Click" Width="250" ID="btnNew" />
                          <br />
                      </asp:TableCell>
                  </asp:TableRow>
                  <%-- demo --%>
                  <asp:TableRow>
                      <asp:TableCell ColumnSpan="2" VerticalAlign="Middle" HorizontalAlign="Center">
                          <div id="demo1" class="cDemo">DEMO1</div><div id="demo2" class="cDemo">DEMO2</div>
                          <br />
                      </asp:TableCell>
                  </asp:TableRow>



              </asp:Table>
                  
          <div id="newbb" style=" border-bottom-left-radius:30px;border-bottom-right-radius:30px;margin-top:10px;background-color:darkred;width:100px;height:20px;text-align:center"></div>     
              
          </div>

    <%-- margin可改變view的左右位置 --%>
      <div style="width:100%;height:100%; margin-left:20%">
       <div class="left" style="margin-top:20px" >
         <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Health_ID" DataSourceID="SqlDataSource1" Height="20px" Width="70%" OnRowCreated="GridView1_RowCreated"  OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand"  PageSize="6">
            <Columns>
                <asp:BoundField DataField="Health_ID" HeaderText="編號" InsertVisible="False" ReadOnly="True" SortExpression="Health_ID" >
                <HeaderStyle Width="5%" Height="20px" HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Health_Type" HeaderText="分類" SortExpression="Health_Type" >
                <HeaderStyle Width="20%" HorizontalAlign="Justify" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Health_Title" HeaderText="標題" SortExpression="Health_Title" >
                <HeaderStyle Width="20%" />
                </asp:BoundField>
                <asp:BoundField DataField="Health_Cont" HeaderText="內文" SortExpression="Health_Cont" >
                <%--<ControlStyle Width="260px" />--%>
                <HeaderStyle Width="60%" />
               <%-- <ItemStyle Width="260px" />--%>
                </asp:BoundField>
                <asp:ImageField DataImageUrlField="Health_ID" DataImageUrlFormatString="~/Handlers/HealthPic.ashx?Health_ID={0}" HeaderText="圖片">
                    <ControlStyle Height="100px" Width="100px" />
                    <ItemStyle Height="100px" Width="100px" />
                </asp:ImageField>
                <asp:ButtonField Text="選取編輯" commandName="mys"   >
                <HeaderStyle Width="50px" />
                </asp:ButtonField>
            </Columns>
             <HeaderStyle BackColor="Maroon" ForeColor="White" />
             <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:GridView>
           <br />
           <br />
           <br />
          <br />
         
        
        </div>
    
          
 


              
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT * FROM [HealthKnowledge] ORDER BY [Health_ID] DESC"></asp:SqlDataSource>
          
 </div>



    <script src="js/myAlert.js"></script>


<script>
   





    $(function () {
        if ($("#ContentPlaceHolder2_Table2").css("display") == "block" || $("#ContentPlaceHolder2_Table1").css("display") == "block")
        {
            $("#editb").css("width", 350);
            $("#newb").css("width", 350);
            $("#newbb").css("width", 350);
        }

        $("#btnDel").click(function () {
            $("#PtH").css("height", "300px");
            $("#ContentPlaceHolder2_GridView1").css("display", "none");
            $("#newtable div,#newtable table").css("display", "none");
            
            $("body").css("background", "gray");
            $("#checkDelete,#checkDelete div").css("display", "block");



        });

        $("#btnCan").click(function () {
            $("#PtH").css("height", "0px")
            $("body").css("background", "white")
            $("#ContentPlaceHolder2_GridView1").toggle();
            $("#newtable div,#newtable table").toggle();
            $("#checkDelete").toggle(1000);
            
        })

        $("#demo1").click(function () {
            $("#ContentPlaceHolder2_TextBox1").val("CECM03成果發表會");
            $("#ContentPlaceHolder2_TextBox2").val("歡迎貴賓蒞臨");
            $("#ContentPlaceHolder2_TextBox3").val("歡迎大家前來");
        }).hover(function () {
            $(this).css("cursor", "pointer")
        });


        $("#demo2").click(function () {
            $("#ContentPlaceHolder2_TextBox1").val("CECM03成果發表會");
            $("#ContentPlaceHolder2_TextBox2").val("預祝順利結束");
            $("#ContentPlaceHolder2_TextBox3").val("預祝成果發表會順利圓滿落幕");
        }).hover(function () {
            $(this).css("cursor", "pointer")
        });






    });

   




       $("#newb").mouseover(function () {
           $("#editb").animate(
               {
                   width: 350,
               },100);
           $(this).css("background-color", "blue").animate(
               {
                   width: 350,
               }, 100, function () {
                   $("#ContentPlaceHolder2_Table1").toggle(100);

               });
           $("#newbb").animate(
                   {
                       width: 350,
                   },100);
           
         



       }).mouseout(function () {
           $(this).css("background-color", "darkred");
          
           if ($("#ContentPlaceHolder2_Table2").css("display") != "table" && $("#ContentPlaceHolder2_Table1").css("display") != "table") {
               $("#editb").css("width", 100);
               $("#newb").css("width", 100);
               $("#newbb").css("width", 100);
           }



       });
    
       $("#editb").mouseover(function () {
           $("#newb").animate(
                   {
                       width: 350,
                   },100);
           $(this).css("background-color", "blue").animate(
               {
                   width:350,
               },100, function () {
                   $("#ContentPlaceHolder2_Table2").toggle(100);
               });
           $("#newbb").animate(
                   {
                       width: 350,
                   },100);

       }).mouseout(function () {
           $(this).css("background-color", "darkred");
           if ($("#ContentPlaceHolder2_Table2").css("display") != "table" && $("#ContentPlaceHolder2_Table1").css("display") != "table") {
               $("#editb").css("width", 100);
               $("#newb").css("width", 100);
               $("#newbb").css("width", 100);
           }
           });

     



   

  

    $("#ContentPlaceHolder2_Table1 td").change(function () {
    var upf = $(this).children("input")[0];
    var img = $(this).children("img")[0];


        img.src =window.URL.createObjectURL(upf.files[0]);

    });
    
    $("#ContentPlaceHolder2_Table2 td").change(function () {
        var upf = $(this).children("input")[0];
        var img = $(this).children("img")[0];


        img.src = window.URL.createObjectURL(upf.files[0]);

    });


     


</script>



   

</asp:Content>

