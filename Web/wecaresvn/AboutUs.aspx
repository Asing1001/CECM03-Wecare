<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" %>

<%@ Register Src="CtrAnnou.ascx" TagPrefix="uc1" TagName="CtrAnnou" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
   
    
<div style="width:960px;margin:0 auto" >  
   
<div  id="AboutheadPic" style="width:100%; margin:0 auto; height:100px; background-size:100% 100%"  >
   
<div style="float:right"></div>
  
</div>
    <div style="height:900px">
       <h2 style="color:darkred">醫院簡介</h2> 

<p>
     醫院創建於西元 1895 年，院址初設於臺北市大稻埕，1898 年遷至現址（現稱為西址）；當時為木造建築，1912 年開始進行整建為文藝復興風格之熱帶式建築，於 1921 年完工，是當時東南亞最大型、最現代化之醫院。
</p>
<p>
    1991 年新大樓（現稱東址）整建完成，兩院區間由景福地下通道貫連。目前有員工六千餘人，病床二千四百餘張，每日門診服務量逾八千人次。2000 年奉行政院核定，接收國軍 817 醫院為醫院公館院區；2004 年 4 月衛生署雲林醫院改制為醫院雲林分院，同年 8 月國立臺北護理學院附設醫院改制為醫院北護分院；2008 年啟用兒童醫療大樓；2009 年公館院區因籌建癌醫中心醫院而停止營運；2010 年 10 月承接北海岸金山醫院，改制為醫院金山分院；2011 年 7 月承接行政院衛生署新竹醫院及行政院衛生署竹東醫院，分別改制為醫院新竹分院及竹東分院，不僅醫院之醫療體系日益茁壯，亦將為民眾提供全方面之醫療服務。
</p>
<p>
創建迄今百餘年來，醫院培育醫界人才無數，包括醫學生、專科醫師、藥師、護理師等醫事人員等，學員分佈全球各地，頭角崢嶸，表現優異。在醫療服務上，醫院的臨床醫療品質更是名聞遐邇，備受國人信賴。而醫院在肝炎、器官移植、癌症診斷治療及生醫光電和臨床試驗藥物研發上的尖端研究成就，亦獲得國際的肯定而享負盛名。

</p>
<p>
身為國家級教學醫院，醫院肩負著教學、研究、服務三大任務。教學方面配合延續醫學院的課程設計，培育醫學及各類專科醫學人才；研究方面整合研究資源，成立核心研究室，提供同仁最好的研究設備與研究環境；服務方面以病人安全為中心的服務導向，強調人性化的照護，著重醫療品質及病人安全管理，以提供高品質的精緻醫療服務。醫院亦致力於推動國際合作，以擷取各先進國家醫療發展的經驗與知識，促進我國醫療的蓬勃發展。今後仍將秉承優良的傳統繼續努力奮進。
    </p>
        <hr />
       <h2 style="color:darkred">地理位置</h2>
      
            <div id="map_canvas" style="float:left;width:60%;height:430px" ></div>

        <div style="float:right;width:38%">
           <div class="AboutusInf"> <h4>&nbsp;&nbsp;附近停車場</h4></div>
            <p>1
                <label id="ad1" class="btnA" style="color: red">大安高工</label>
                </p>
            <p>2
                <label id="ad2" class="btnA" style="color: red">建國高架橋下停車場</label>
               </p>
            <p>3
                <label id="ad5" class="btnA" style="color: red">附中公園地下停車場</label>
                </p>
            <p>4
                <label id="ad4" class="btnA" style="color: red">大安森林公園地下停車場</label>
               </p>
            
            <hr />

           <div class="AboutusInf"> <h4 >&nbsp;&nbsp; 公車撘乘路線說明</h4> </div>

<p>1 <label id="ad3" style="color:red" class="btnA"> 信義路段：</label> 0東左、20、22、38、294、204、226、信義線、指南3  (在信義復興路口下車) </p>
<p>2 <label id="ad6" style="color:red" class="btnA">臺北車站(青島)</label>：(74、278、204)--和安里站　　(74、278)--大安高工站 </p>
<hr />
          <div class="AboutusInf"> <h4>&nbsp;&nbsp; 搭乘捷運</h4> </div>

<p>1 <label style="color:red" > 捷運大安站</label></p>


        <br />
         <br />
         <br />
    
        </div>
       
    </div>
   </div>
   

    
    <style type="text/css">
      html { height: 100% }
      body { height: 100%; margin: 0; padding: 0 }
      #map_canvas { height: 100% }
    </style>

    <script type="text/javascript">
        function initialize() {
            var mapOptions = {
                zoom: 16,
                //center: new google.maps.LatLng(25.033656, 121.543336),
                center: new google.maps.LatLng(25.0336931, 121.5404387),
                mapTypeId: google.maps.MapTypeId.ROADMAP,


            }
            var map = new google.maps.Map(document.getElementById("map_canvas"), mapOptions);
            var myLatlng = new google.maps.LatLng(25.033656, 121.543336);

            var imageUrl = "images/wecare_con.jpg"
            var marker = new google.maps.Marker({
                position: myLatlng,
                map: map,
                title: "WeCare",
                icon: imageUrl

            });

            //建立marker物件
            var marker1 = new google.maps.Marker({
                position: new google.maps.LatLng(25.0326376, 121.5410408),
                map: map,
                title: "大安高工",
                icon: "images/car.png",

            });
            marker1.setVisible(false);

            var marker2 = new google.maps.Marker({
                position: new google.maps.LatLng(25.0344518, 121.5377635),
                map: map,
                title: "建國高架橋下停車場",
                icon: "images/car.png"

            });
            marker2.setVisible(false);

            var marker3 = new google.maps.Marker({
                position: new google.maps.LatLng(25.0344987, 121.5437543),
                map: map,
                title: "信義復興路口",
                icon: "images/bus.png"

            });
            marker3.setVisible(false);

            var marker4 = new google.maps.Marker({
                position: new google.maps.LatLng(25.0332745, 121.5357456),
                map: map,
                title: "大安森林公園地下停車場",
                icon: "images/car.png"

            });
            marker4.setVisible(false);

            var marker5 = new google.maps.Marker({
                position: new google.maps.LatLng(25.0362096, 121.5422867),
                map: map,
                title: "附中公園地下停車場",
                icon: "images/car.png"

            });
            marker5.setVisible(false);

            var marker6 = new google.maps.Marker({
                position: new google.maps.LatLng(25.0357702, 121.5437332),
                map: map,
                title: "和安里站",
                icon: "images/bus.png"

            });
            marker6.setVisible(false);

            var marker7 = new google.maps.Marker({
                position: new google.maps.LatLng(25.0324866, 121.5433733),
                map: map,
                title: "大安高工站",
                icon: "images/bus.png"

            });
            marker7.setVisible(false);



            $("#ad1").click(function () {

                markervisable(marker1);

            }
             );

            $("#ad2").click(function () {

                markervisable(marker2);

            }
             );

            $("#ad3").click(function () {
                markervisable(marker3);
            }
             );

            $("#ad4").click(function () {
                markervisable(marker4);
            }
             );

            $("#ad5").click(function () {
                markervisable(marker5);
            }
            );

            $("#ad6").click(function () {
                markervisable(marker6);
                markervisable(marker7);
            }
           );








        }

        function markervisable(marker) {

         
            if (marker.visible == true) {
                marker.setVisible(false);
            }
            else {
                marker.setVisible(true);
            }
            
        }
        function loadScript() {
            var script = document.createElement("script");
            script.type = "text/javascript";
            script.src = "http://maps.googleapis.com/maps/api/js?key=AIzaSyD6LUTN9fz6na0U2qtLWKWQk_fS5-yqq-w&sensor=FALSE&callback=initialize";
            document.body.appendChild(script);
        }

        window.onload = loadScript;
    </script>










    <script>
       //標籤變紅色
        $("#ctrTitle> li:eq(1)").addClass("active");

    </script>




</asp:Content>

