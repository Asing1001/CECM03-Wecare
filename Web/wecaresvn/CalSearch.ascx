<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CalSearch.ascx.cs" Inherits="CalSearch" %>
<style>
    .btnDay {
        -moz-box-shadow: inset 0px 1px 0px 0px #ffffff;
        -webkit-box-shadow: inset 0px 1px 0px 0px #ffffff;
        box-shadow: inset 0px 1px 0px 0px #ffffff;
        background: -webkit-gradient( linear, left top, left bottom, color-stop(0.05, #f9f9f9), color-stop(1, #e9e9e9) );
        background: -moz-linear-gradient( center top, #f9f9f9 5%, #e9e9e9 100% );
        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#f9f9f9', endColorstr='#e9e9e9');
        background-color: #f9f9f9;
        -webkit-border-top-left-radius: 15px;
        -moz-border-radius-topleft: 15px;
        border-top-left-radius: 15px;
        -webkit-border-top-right-radius: 0px;
        -moz-border-radius-topright: 0px;
        border-top-right-radius: 0px;
        -webkit-border-bottom-right-radius: 0px;
        -moz-border-radius-bottomright: 0px;
        border-bottom-right-radius: 0px;
        -webkit-border-bottom-left-radius: 15px;
        -moz-border-radius-bottomleft: 15px;
        border-bottom-left-radius: 15px;
        text-indent: 0px;
        border: 1px solid #dcdcdc;
        display: inline-block;
        color: #666666;
        font-family: Arial;
        font-size: 20px;
        font-weight: normal;
        font-style: normal;
        height: 40px;
        line-height: 30px;
        width: 40px;
        text-decoration: none;
        text-align: center;
        text-shadow: 1px 1px 0px #ffffff;
    }

        .btnDay:hover {
            background: -webkit-gradient( linear, left top, left bottom, color-stop(0.05, #e9e9e9), color-stop(1, #f9f9f9) );
            background: -moz-linear-gradient( center top, #e9e9e9 5%, #f9f9f9 100% );
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#e9e9e9', endColorstr='#f9f9f9');
            background-color: #e9e9e9;
        }

        .btnDay:active {
            position: relative;
            top: 1px;
        }

    .btnSearch {
	-moz-box-shadow:inset 0px 1px 0px 0px #ffffff;
	-webkit-box-shadow:inset 0px 1px 0px 0px #ffffff;
	box-shadow:inset 0px 1px 0px 0px #ffffff;
	background:-webkit-gradient( linear, left top, left bottom, color-stop(0.05, #f9f9f9), color-stop(1, #e9e9e9) );
	background:-moz-linear-gradient( center top, #f9f9f9 5%, #e9e9e9 100% );
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#f9f9f9', endColorstr='#e9e9e9');
	background-color:#f9f9f9;
	-webkit-border-top-left-radius:6px;
	-moz-border-radius-topleft:6px;
	border-top-left-radius:6px;
	-webkit-border-top-right-radius:6px;
	-moz-border-radius-topright:6px;
	border-top-right-radius:6px;
	-webkit-border-bottom-right-radius:6px;
	-moz-border-radius-bottomright:6px;
	border-bottom-right-radius:6px;
	-webkit-border-bottom-left-radius:6px;
	-moz-border-radius-bottomleft:6px;
	border-bottom-left-radius:6px;
	text-indent:0;
	border:1px solid #dcdcdc;
	display:inline-block;
	color:#666666;
	font-family:Arial;
	font-size:15px;
	font-weight:bold;
	font-style:normal;
	height:40px;
	line-height:40px;
	width:100px;
	text-decoration:none;
	text-align:center;
	text-shadow:1px 1px 0px #ffffff;
}
.btnSearch:hover {
	background:-webkit-gradient( linear, left top, left bottom, color-stop(0.05, #dfdfdf), color-stop(1, #ededed) );
	background:-moz-linear-gradient( center top, #dfdfdf 5%, #ededed 100% );
	filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#dfdfdf', endColorstr='#ededed');
	background-color:#dfdfdf;
}.btnSearch:active {
	position:relative;
	top:1px;
}
    /* This button was generated using CSSButtonGenerator.com */
</style>
<div class="row">
    <%--style="float:left; width:800px; font-size:20px;">--%>
    <div class="bs-component">
        <%--<div class="navbar navbar-inverse">
                <div class="navbar-header">
                  <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-inverse-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                  </button>
                  <a class="navbar-brand" href="#">搜尋對象</a>
                </div>
                <div class="navbar-collapse collapse navbar-inverse-collapse">
                  <ul class="nav navbar-nav">                   
                    <li class="dropdown">
                      <a href="#" class="dropdown-toggle" data-toggle="dropdown">請選擇...<b class="caret"></b></a>
                      <ul class="dropdown-menu">
                        <li><a href="#">醫療人員</a></li>
                        <li><a href="#">病患</a></li>                   
                      </ul>
                    </li>
                  </ul>
                  <form class="navbar-form navbar-left">
                    <input type="text" class="form-control col-lg-8" placeholder="Search">
                  </form>
                  <ul class="nav navbar-nav navbar-right">
                    <li><a href="#">Link</a></li>
                    <li class="dropdown">
                      <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                      <ul class="dropdown-menu">
                        <li><a href="#">Action</a></li>
                        <li><a href="#">Another action</a></li>
                        <li><a href="#">Something else here</a></li>
                        <li class="divider"></li>
                        <li><a href="#">Separated link</a></li>
                      </ul>
                    </li>
                  </ul>
                </div>
              </div>--%>
        <%--<div id="source-button" class="btn btn-primary btn-xs" style="display: none;">&lt; &gt;</div></div>--%>
        <div class="col-xs-12">
            <asp:Label ID="Label1" runat="server" Text="搜尋對象：" Font-Size="Large"></asp:Label>
            <asp:DropDownList ID="WorkerList" runat="server" Height="40px" Font-Size="Large">
                <asp:ListItem>醫療人員</asp:ListItem>
                <asp:ListItem>病患</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label2" runat="server" Text="搜尋條件：" Font-Size="Large"></asp:Label>
            <asp:DropDownList ID="ruleList" runat="server" Height="40px" Font-Size="Large">
                <asp:ListItem>姓名</asp:ListItem>
                <asp:ListItem>身份証字號</asp:ListItem>
                <asp:ListItem>出生年月日</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server" Height="40px" class="" Font-Size="Large"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="搜尋" CssClass="btnSearch" Font-Size="Large" Height="40px" Width="80px" />
        </div>
        <%--<div class="btn-group col-xs-6">
          <button id="btnDay" type="button" class="btn btn-default">日</button>
          <button id="btnWeek" type="button" class="btn btn-default">週</button>
          <button id="btnMonth"type="button" class="btn btn-default">月</button>
        </div>--%>
    </div>
    <br />

    <%--<div style="float:right; height:50px; width:150px;">
    <div id="btnDay" class="btnDay">日</div>
    <div id="btnWeek" class="btnDay" style="border-radius:0;">週</div>
    <div id="btnMonth" class="btnDay" style="border-radius: 0 15px 15px 0;">月</div>
</div><br />--%>
    <%--<div style="float:left; width:99px; height: 22px;">
	<div id="lnkYestoday" style="text-align:center; float:left; border:1px solid lightblue; border-radius:5px 0 0 5px; width:20px;"><a id="previous" class=""><</a></div>
	<div id="lnkToday" style="text-align:center; float:left; border:1px solid lightblue; width:50px;"><a id="today" class="">Today</a></div>
	<div id="lnkTomorow" style="text-align:center; float:left; border:1px solid lightblue; border-radius:0 5px 5px 0; width:20px;"><a id="next" class="">></a></div>
</div>--%>
</div>
<script>
    //$(function () {
    //    $('#btnDay')
    //        .click(function () {
    //            $('#monthCal').css('display', 'none');
    //            $('#weekCal').css('display', 'none');
    //            $('#dayCal').css('display', 'block');
    //        })
    //        .mouseover(function () {
    //            $(this).css('cursor', 'pointer');
    //        });
    //    $('#btnWeek').click(function () {
    //        $('#monthCal').css('display', 'none');
    //        $('#weekCal').css('display', 'block');
    //        $('#dayCal').css('display', 'none');
    //        })
    //        .mouseover(function () {
    //            $(this).css('cursor', 'pointer');
    //        });
    //    $('#btnMonth').click(function () {
    //        $('#monthCal').css('display', 'block');
    //        $('#weekCal').css('display', 'none');
    //        $('#dayCal').css('display', 'none');
    //        })
    //        .mouseover(function () {
    //            $(this).css('cursor', 'pointer');
    //        });
    //});
</script>
