<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<%@ Register Src="CtrAnnou.ascx" TagPrefix="uc1" TagName="CtrAnnou" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
   

    <%-- <div id="headPic" >--%>
    <div id="ind" style="margin:0 auto;width:960px ;height:10px; background:-webkit-linear-gradient(top,#000000 95%,#ffffff ); ">
   
     <div id="slider">
         <div class="show1"></div>
         <div class="show2"></div>
         <div class="show3"></div>
         <div class="show4"></div>
         <div class="show5"></div>
         <div class="show6"></div>
        
     </div>

    <div style="margin:1% auto;float:left;width:960px ;">
       <div id="news" style="margin-left:100px;">
      
         
           <table id="newsTable" style="color:#ff0000">
 <asp:Literal ID="Literal2" runat="server">

            </asp:Literal>		

           </table>
             	
	
      
           </div>
      <a href="NewsManagement.aspx">  <div id="moreStyle"></div></a>    
    </div>

</div>
   
    
    <script src="js/jquery.cycle.all.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {
           
//標籤變紅色
       $("#ctrTitle > li:eq(0)").addClass("active");

 

            $("#news").fadeOut();
            $('#moreStyle').fadeOut();


           

            $('#ind').animate({
                height:600,
             
            }, 1000,function () {

                $("#news").fadeIn(1000);
                $('#moreStyle').fadeIn(2000);
            });



            $('#slider').cycle({
                fx:'fade' ,  //特效選擇  'shuffle'
                speed: 1000,
                timeout: 720,
                random: 1
            });
        });

        $('#moreStyle').mouseover(function () {
            $('#moreStyle').css("background-size", "64px 12px");
        }).mouseleave(function () {
            $('#moreStyle').css("background-size", "52px 10px");
        });


    </script>
</asp:Content>

