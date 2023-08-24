<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="ShowReport.aspx.cs" Inherits="ShowReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <link href="ChartReport/ExamTable.css" rel="stylesheet" />
     <style>
         .clscharttable{  
             /*border:1px solid green;*/           
             width:1200px;
             margin:0 auto;
         }
         .clscharttable tr td{
             /*border:1px solid green;*/
             width:1200px;
             margin:0 auto;
         }
         #coluam3dtable,#coluam3dtable td{
              border:1px solid green;
         }
         .arrowpostion{
             position:absolute;
             top:20%;
             z-index:1;
         }
         #arrowup{
             position:absolute;
             bottom:-80%;
         }
         #totop{
             position:absolute;
             top:1%;
         }
     </style>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <div style="width:100%;height:100%;">
        <p id="totop"></p>
    <h1 style="color:black;text-align:center;"></h1>
        <div class="nav"><a href="#todown"><img id="arrownext" class="arrowpostion" src="ChartReport/Arrowdown.png" style="width:100px;height:100px" title="下一頁"/></a></div>
        <div >
         <table id="showcharttable" class="clscharttable">         
            <tr><td><div id="ctExamstatic" style="height:350px;width: 550px" ></div></td> <%--style="min-width: 600px; height: 400px; max-width: 600px; margin: 0 auto"--%>
                <td><div style="max-width:10px" ></div></td> <%--style="min-width: 600px; height: 400px; max-width: 600px; margin: 0 auto"--%>
                <td>  
                    <div id="container3dcolumn" style="min-height:350px;width: 550px"></div>
                    <div id="sliders">
	                    <table id="coluam3dtable">
		                    <tr><td>旋轉X軸&nbsp</td><td><input id="R0" type="range" min="0" max="45" value="10"/> <span id="R0-value" class="value"></span></td>
	                        <td>旋轉Y軸&nbsp</td><td><input id="R1" type="range" min="0" max="45" value="15"/> <span id="R1-value" class="value"></span></td></tr>
	                    </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td><div style="height:10px"></div></td>
            </tr>
            <%--<tr><td><div id="ctExamstaticbar" style="height:400px;min-width: 550px" ></div></td></tr>--%>  <%--column 平面統計--%>
         </table>
         <table id="showcharttable2" style="width:800px;margin:0 auto">
              <tr> 
               <td>
                   <div class="Tablestatic" style="width:800px;margin:0auto">      <%--style="border-radius:10px;"--%>
                    <table id="staticexamtable" >
                        <tr></tr>
                        <tr></tr>
                        <tr></tr>
                        </table>
                       </div>
                </td>
              </tr>
             <tr>
                 <td>
                     <div style="height:70px"></div>
                 </td>
             </tr>
             <tr>
                 <td>
                     <div style="height:30px"><p id="todown"></p></div>
                 </td>
             </tr> 
         </table>
           
          <table id="showcharttable3" class="clscharttable">
            <tr>
                <td colspan='3'><div id="ctExamUnusual" style="min-width: 550px; height: 350px; margin: 0 auto"></div></td>
            </tr>
            <tr>              
                <td colspan='3'>
                    <div class="Tablestatic" style="width:900px;margin:0 auto">      <%--style="border-radius:10px;"--%>
                    <table id="statictotal" >
                        <tr></tr>
                        <tr></tr>
                        <tr></tr>
                        <tr></tr>
                        <tr></tr>
                        <tr></tr>
                        <tr></tr>
                    </table>
                    </div>
                </td>            
            </tr>
            <tr>
                  <td>
                      <div style="height:100px"></div>
                  </td>
              </tr>
        </table>
        </div> 
        <div class="nav"><a href="#totop"><img id="arrowup"  src="ChartReport/Arrowup.png" style="width:100px;height:100px" title="上一頁"/></a></div>
    </div>
    <script src="ChartReport/highcharts.js"></script>
    <script src="ChartReport/highcharts-3d.js"></script>
    <script src="ChartReport/exporting.js"></script>
    <script src="ChartReport/jquery.easing.1.3.js"></script>
    <script src="ChartReport/showReportChart.js"></script>  <%--我做的圖表--%>
      <script type="text/javascript">  //移動動畫
          $(function () {
              $('div.nav a').bind('click', function (event) {
                  var $anchor = $(this);

                  $('html, body').stop().animate({
                      scrollTop: $($anchor.attr('href')).offset().top
                  }, 1500, 'easeInOutExpo');
                  /*
                  if you don't want to use the easing effects:
                  $('html, body').stop().animate({
                      scrollTop: $($anchor.attr('href')).offset().top
                  }, 1000);
                  */
                  event.preventDefault();
              });
          });
        </script>
</asp:Content>

