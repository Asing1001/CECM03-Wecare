<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TimeLines.aspx.cs" Inherits="TimeLines" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <link href="TiemlineJquery/timeline.css" rel="stylesheet" />
    <script src="TiemlineJquery/jmpress.min.js"></script>
    <script src="TiemlineJquery/jsTimeLine2.js"></script>
    <style type="text/css">
	
	html,body
	{
		margin:0;
		padding:0;
	}
	#dasky
	{
		font-family: 'Droid Sans', sans-serif;
        /*height:100%;
        width:100%;*/

	}
    .bgsize{
        position:absolute;       
        /*margin:0 auto;
        padding:0;*/        
        height:80%;
        width:100%;
        /*top:114px;*/
        /*left:0;*/

    }

    .noDisplay{
        display:none !important;
    }

</style>
<div style="height:100%;width:100%;">  <%--style="height:610px;width:1600px; margin:0 auto";padding:0;--%>
 <div class="bgsize">
<div id="dasky" class="mydasky">
<asp:Literal ID="Literal1" runat="server"></asp:Literal>
</div>
   </div>
</div>
    <script>       
              //$('footer').addClass("noDisplay").hide()      
        var tb = function () {
            var header = "<div class ='tb1' style='border:1px solid blue;width:100px; height:'100px';><table><tr>";
            var td = "<td>" + 123 + "</td>";
            var tr = "<tr></tr>";
            var tbfoot = "</tr></table></div>";
            //td = $(td).text("dddd");
            var table1 = header + tb;
            $(document.body).append()

        }
        $(".dsk-link").click(function(){
            tb();
        })
        


    </script>

</asp:Content>


