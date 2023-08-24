<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="CommonHealth.aspx.cs" Inherits="CommonHealth" %>

<%@ Register Src="CtrAnnou.ascx" TagPrefix="uc1" TagName="CtrAnnou" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">







    <div id="main" style="width: 100%; margin:0 auto;">
        <div id="headPic" style="margin:0 auto; height: 100px; background-size: 100% 100%">
        </div>
        <div id="sh">
            <div id="sl">
                <%--健康新知輪播title--%>

                <asp:Literal ID="Literal1" runat="server">

                </asp:Literal>
                <img src="images/hk2.png" style="width:150px;height:200px;position:absolute;right:20%;bottom:10%"/>
            </div>
        </div>


        <%--健康新知詳細內容--%>

        <div id="tt2" style="display: none; margin: 0 auto; width: 960px;">
            <div id="shAll">全部展開</div>
            <div id="shno">全部收回</div>
              <div id="btnreturn" style="display: none;float:right; margin: 0 auto; text-align: center;">

        <a href='#'>Return<img src="images/return.jpg" style="height:30px;width:30px"/></a>

        <br/>
        <br/>
        <br/>
        <br/>
    </div>  

           <div style="float:left;width:15%;background-color:pink">
                <asp:Literal ID="Literal3" runat="server">

                </asp:Literal>
</div>
         
            
            
            <div id="SKR" style="width:70%;float:right">
            <asp:Literal ID="Literal2" runat="server">


            </asp:Literal>
</div>
          
        </div>
    </div>
    




    <script src="js/jquery.cycle.all.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function ($) {
            //標籤變紅色



            $("#ctrTitle> li:eq(3)").addClass("active");



            $('#shAll').click(function () {
                $('#SKR div').css("display", 'block');
                $("#shno").css("display", 'block');
                $("#shAll").css("display", 'none')
            }).mouseover(function () {
                $(this).css("color", "blue").css("cursor", "pointer")
            }).mouseleave(function () {
                $(this).css("color", "darkred")
            });

            $("#shno").css("display", 'none').click(function () {
                $('.showKnowledgeDetail > div > div').css("display", 'none');
                $("#shno").css("display", 'none');
                $('#shAll').css("display", 'block');
            }).mouseover(function () {
                $(this).css("color", "blue").css("cursor", "pointer")
            }).mouseleave(function () {
                $(this).css("color", "darkred")
            });



            $('#sl').cycle({
                fx: 'fade',  //特效選擇  'fade,shuffle'
                speed: 2000,
                timeout: 720,
                random: 1
            }).click(function () {

                $('#sh').fadeOut(1);
                $('#tt2').css("display", 'block');
                $('#btnreturn').toggle();
            }).mouseover(function(){           
        $(this).css("cursor", "pointer")
        })
        });

        function TypeClick(id) {
            var s = "#" + id;
            var t = "#s" + id+" h5";

           $(s).toggle();
           if ($(s).css("display") == "none") {
               $(t).css("color", "pink")
           }
           else { $(t).css("color", "rgb(64,98,47)") }



        }


        $('.showKnowledgeDetail h2').click(function () {
            $(this).next().toggle(500);
        }).mouseover(function () {
            $(this).css("cursor", "pointer")
        });

        $('#btnreturn').click(function () {
            $('#tt2').css("display", 'none');
            $('#sh').fadeIn(500);
            $('#btnreturn').toggle();
        });
    </script>



</asp:Content>

