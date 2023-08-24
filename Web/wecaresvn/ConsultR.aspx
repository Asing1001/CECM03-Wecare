﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ConsultR.aspx.cs" Inherits="CounsultR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
 
    <script src="Scripts/ui/jquery.ui.core.js"></script>
    <script src="Scripts/ui/jquery.ui.widget.js"></script>
    <script src="Scripts/ui/jquery.ui.mouse.js"></script>
    <script src="Scripts/ui/jquery.ui.draggable.js"></script>
    <script src="Scripts/ui/jquery.ui.resizable.js"></script>
    

    <!--Script references. -->
    <%--<script src="Scripts/jquery-2.1.1.min.js"></script>--%>

 <!--Reference the SignalR library. -->
    <script src="Scripts/jquery.signalR-2.1.1.min.js"></script>

 <!--Reference the autogenerated SignalR hub script. -->
 <script type="text/javascript" src='<%= ResolveClientUrl("~/signalr/hubs") %>'></script>
    <%--<script src="js/Mydrag.js"></script>--%>
    <link href="css/ChatStyle.css" rel="stylesheet" />
    <link href="css/JQueryUI/themes/base/jquery.ui.all.css" rel="stylesheet" />


    <script type="text/javascript">

        $(function () {

            
            //標籤變紅色     
        $("#ctrTitle> li:eq(4)").addClass("active");

   




            setScreen(false);
            
            // Declare a proxy to reference the hub. 
            var chatHub = $.connection.chatHub;

            registerClientMethods(chatHub);

            // Start Hub
            $.connection.hub.start().done(function () {

                registerEvents(chatHub)

            });

        });

        function setScreen(isLogin) {

            if (!isLogin) {
                $("#divChat").hide();
                $("#privatediv").hide();
                $("#divLogin").show();
                
            }
            else {
                $("#divChat").show();
                $("#privatediv").show();
                $("#divLogin").hide();
            }
        }

        function registerEvents(chatHub) {

            $("#btnStartChat").click(function () {
                var name = $("#txtNickName").val();

                if ($.cookie('Job')!=null) {
                    name = $("#txtNickName").val()+ "wecare"
                }

                if (name.length > 0) {
                    chatHub.server.connect(name);
                }
                else {
                    alert("請輸入您的暱稱!");
                }
            });

            $('#btnSendMsg').click(function () {

                var msg = $("#txtMessage").val();
                if (msg.length > 0) {
                    var userName = $('#hdUserName').val();
                    chatHub.server.sendMessageToAll(userName, msg);
                    $("#txtMessage").val('');
                }
            });


            $("#txtNickName").keypress(function (e) {
                if (e.which == 13) {                   
                    e.preventDefault();
                    $("#btnStartChat").click();
                        return false;                  
                    
                }
            });

            $("#txtMessage").keypress(function (e) {
                if (e.which == 13) {
                    e.preventDefault();
                    $('#btnSendMsg').click();
                    return false;
                }
            });
        }

        function registerClientMethods(chatHub) {            
            // Calls when user successfully logged in
            // Clients.Caller.onConnected(id, userName, ConnectedUsers, CurrentMessage);
            chatHub.client.onConnected = function (id, userName, allUsers, messages) {
                setScreen(true);

                //藏ID
                $('#hdId').val(id);
                $('#hdUserName').val(userName);
                $('#spanUser').html(userName);

                // Add All Users
                for (i = 0; i < allUsers.length; i++) {

                    AddUser(chatHub, allUsers[i].ConnectionId, allUsers[i].UserName);
                }

                // Add Existing Messages to pubic chat
                for (i = 0; i < messages.length; i++) {

                    AddMessage(messages[i].UserName, messages[i].Message);
                }
            }

            // On New User Connected
            chatHub.client.onNewUserConnected = function (id, name) {

                AddUser(chatHub, id, name);
            }


            // On User Disconnected
            chatHub.client.onUserDisconnected = function (id, userName) {

                $('#' + id).remove();

                var ctrId = 'private_' + id;
                $('#' + ctrId).remove();

                var disc = $('<div class="disconnect">"' + userName + '" 離開了!</div>');

                $(disc).hide();
                $('#divusers').prepend(disc);
                $(disc).fadeIn(200).delay(2000).fadeOut(200);
            }

            chatHub.client.messageReceived = function (userName, message) {

                AddMessage(userName, message);
            }


            chatHub.client.sendPrivateMessage = function (windowId, fromUserName, message) {

                var ctrId = 'private_' + windowId;

                if ($('#' + ctrId).length == 0) {
                    createPrivateChatWindow(chatHub, windowId, ctrId, fromUserName);
                }

                $('#' + ctrId).find('#divMessage').append('<div class="message"><span class="userName">' + fromUserName + '</span>: ' + message + '</div>');

                // set scrollbar
                if ($('#divChatWindow')[0].scrollHeight != null) {
                    var height = $('#' + ctrId).find('#divMessage')[0].scrollHeight;
                    $('#' + ctrId).find('#divMessage').scrollTop(height);
                }
            }
        }

        function AddUser(chatHub, id, name) {

            if (id=="" ||name =="") {
                return;
            }

            var userId = $('#hdId').val();

            var code = "";

            //若是自己
            if (userId == id) {
                code = $('<div class="loginUser">' + name + "</div>");
                if (name.match('wecare') != null) {  //若為醫院員工
                    var indexOfWecare= name.indexOf('wecare')
                    name = name.substring(0, indexOfWecare)
                    code = $('<div class="loginUser">' + '<span class="glyphicon glyphicon-tower"></span>' + name + "</div>")
                }
            }
            else {

                code = $('<a id="' + id + '" class="user" >' + name + '</a>');

                //若為醫院員工  
                if (name.match('wecare') != null) {
                    var indexOfWecare = name.indexOf('wecare')
                    name = name.substring(0, indexOfWecare)
                    code = $('<a id="' + id + '" class="user" >' + '<span class="glyphicon glyphicon-tower"></span>' + name + '<a>')
                }

                //點別人名字
                $(code).dblclick(function () {

                    var id = $(this).attr('id');

                    if (userId != id)
                        OpenPrivateChatWindow(chatHub, id, name);

                });
            }

            $("#divusers").append(code);

        }

        function AddMessage(userName, message) {
            $('#divChatWindow').append('<div class="message"><span class="userName">' + userName + '</span>: ' + message + '</div>');

            
              var height = $('#divChatWindow')[0].scrollHeight;
              $('#divChatWindow').scrollTop(height);
            
            
        }

        function OpenPrivateChatWindow(chatHub, id, userName) {

            var ctrId = 'private_' + id;

            if ($('#' + ctrId).length > 0) return;

            createPrivateChatWindow(chatHub, id, ctrId, userName);

        }

        
        var dragid = "";
        var offsetForPrivate = 1;
        function createPrivateChatWindow(chatHub, userId, ctrId, userName) {
            dragid = ctrId;
            var div = '</br><div id="' + ctrId + '" class="ui-widget-content draggable" style="float:right; " >' +

                '<div class="header" id="myheader" >' +

                  '<div  style="float:right;"  id="close">X &nbsp  ' +
                           '</div>' +

                '<div  style="float:right;"  id="minimize"> ─&nbsp  ' +
                           '</div>' +
                        

                           '<span class="selText" rel="0">' + userName + '</span>' +
                       '</div>' +

                       '<div id="divMessage" class="messageArea">' +

                       '</div>' +
                       '<div class="buttonBar" id="mysendbar">' +
                          '<input id="txtPrivateMessage" class="msgText" type="text"   />' +
                          '<input id="btnSendMessage" class="submitButton button" type="button" value="發送"   />' +
                       '</div>' +
                    '</div>';

            var $div = $(div);

            // DELETE BUTTON IMAGE
            $div.find('#close').click(function () {
                $('#' + ctrId).remove();
                offsetForPrivate--;
            });

            // Send Button event
            $div.find("#btnSendMessage").click(function () {
             
                $textBox = $div.find("#txtPrivateMessage");
                var msg = $textBox.val();
                if (msg.length > 0) {

                    chatHub.server.sendPrivateMessage(userId, msg);
                    $textBox.val('');
                }
            });

            // Text Box event
            $div.find("#txtPrivateMessage").keypress(function (e) {
                if (e.which == 13) {
                    e.preventDefault();
                    $div.find("#btnSendMessage").click();
                    return false;
                }
            });

            AddDivToContainer($div);

            //縮小放大、位移
            var isshow = true;
            $div.find('#minimize').click(function () {
                var containtop= $('#divContainer').position().top;
                var headerheight = $('#myheader').height();
                if (isshow) {
                    $div.find("#divMessage").hide();
                    $div.find("#mysendbar").hide();                    
                    $div.offset({ "top": containtop + $('#divContainer').outerHeight(true) - headerheight +5 })
                }
                else {
                    $div.find("#divMessage").show();
                    $div.find("#mysendbar").show();
                    $div.offset({ "top": containtop + $('#divContainer').outerHeight(true) - headerheight - 230 })
                }
                isshow = !isshow;               
            })
        }

       var offset=1
        function AddDivToContainer($div) {           
            var privatediv = $('#privatediv');
            //append新的視窗，定位其位置
            console.log($div.height())
            $($div).appendTo(privatediv).offset({
                "top": privatediv.position().top + privatediv.height() - 230 - $('#myheader').height() * offset
                ,"left": $('#divChat').position().left - (255 * offsetForPrivate)
                //$('#privatediv').Width - 
            });
            if (offsetForPrivate == 3) {
                offsetForPrivate = 0;

                offset++;
            }


            offsetForPrivate++
            
           
            //使它可以移動
            $($div).draggable();
        }

      
        $(document).ready(function () {
            $('#divChat').draggable()            
        });

    

    </script>


 

    <div id="divContainer" class="row nopadding" style="height:100%;">
        <div id="divLogin" class="login row">
            <div>
                <h2 class="form-signin-heading">請輸入暱稱:</h2>                
            <input id="txtNickName" type="text" class="form-control"/>
            </div>
            <div id="divButton">
                <input id="btnStartChat" type="button" class="btn btn-primary btn-block" style="background-color:#3b5998" value="進入諮詢室" />
            </div>
        </div>

        <div id="divChat" class="chatRoom col-xs-12 col-md-4 nopadding " style="border-bottom:none !important; height:100%;">
            <div class="title col-xs-12">
                歡迎來到線上諮詢區 [<span id='spanUser'></span>]
            </div>
            <div class="content col-xs-12 nopadding">
                <div id="divChatWindow" class="chatWindow col-md-8 col-xs-12 nopadding">
                </div>
                <div id="divusers" class="users col-md-4 visible-md visible-lg nopadding">
                </div>
            </div>
            <div class="messageBar col-xs-12" style="min-height:39px;">
                <input class="textbox" type="text" id="txtMessage" />
                <input id="btnSendMsg" type="button" value="發送" class="submitButton" />
            </div>
        </div>
        <div id="privatediv" class="col-md-8 hidden-sm hidden-xs nopadding " style="position:relative; display:none !important; height:100%;  float:left;" ></div>

        <input id="hdId" type="hidden" />
        <input id="hdUserName" type="hidden" />
    </div>
    <script>
       
    </script>
</asp:Content>
