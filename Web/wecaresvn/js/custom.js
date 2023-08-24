

$(document).ready(function () {

    $("#btnHloginok").hide();

    $("#loginpopup").bind("click", function () {
        if ($("#loginpopup").attr("name") == "logined")
        { $('#login').modal('hide'); }
        else {
            $('#LoginResult').text("");
            $('#TextBoxAccount').val("");
            $('#TextBoxPwd').val("");
            $('#login').modal('toggle');
        }

    });

    $('#signup-link').bind("click", function () {
        $('#login').modal('hide');

        //$('#signup_details span[id*="Validator"]').toggle();
        $('#signup_details input').val("");
        $('#textboxsigninac').focus();

        $('#signup').modal('toggle');
    });
    $('#login-link').bind("click", function () {
        $('#signup').modal('hide');
        $('#LoginResult').text("");
        $('#TextBoxAccount').val("");
        $('#TextBoxAccount').focus();
        $('#TextBoxPwd').val("");
        $('#login').modal('toggle');
    });
    $('#btnfoget').bind("click", function () {
        $('#login').modal('hide');
        $('#LabelEmail').text("");
        $('#TextBoxEmail').val("");


        $('#TextBoxEmailAC').val("");
        $('#forgetPwd').modal('toggle');
    });
    $("#btnSigninCacel").bind("click", function () {
        //$('#signup_details input').val("");

        //改取消鍵 為demo鍵
        $('#TextBoxSigninAC').val("D123456789");
        $('#TextBoxSigninEmail').val("shinningstar1001@gmail.com");
        $('#TextBoxSigninPwd').val("000000");
        $('#TextBoxConfirmPwd').val("000000");
    });

    $("#btnForgetClear").bind("click", function () {
        $('#LabelEmail').text("");
        $('#TextBoxEmail').val("");
        $('#TextBoxEmailAC').val("");
    });

    $("#Hostpital").click(function () {
        //$("#Patients").removeAttr("name");
        //$("#Hostpital").attr("name", "1");
        $("#btnHloginok").show();
        $("#btnPloginok").hide();
        $("#loginaccpwd input").val("");
    })
    $("#Patients").click(function () {
        //$("#Hostpital").removeAttr("name");
        //$("#Patients").attr("name", "selected");
        $("#btnHloginok").hide();
        $("#btnPloginok").show();
        $("#loginaccpwd input").val("");
    })

    // Boostrap Slider
    $('.carousel').carousel();

    // navigation click actions	
    $('.scroll-link').on('click', function (event) {
        event.preventDefault();
        var sectionID = $(this).attr("data-id");
        scrollToID('#' + sectionID, 750);
        $('.navbar-nav li').each(function () {
            $(this).removeClass("active");
        });
        $(this).parent().addClass("active");
    });
    // scroll to top action
    $('.scroll-top').on('click', function (event) {
        event.preventDefault();
        $('html, body').animate({ scrollTop: 0 }, 'slow');
    });
    // mobile nav toggle
    $('#nav-toggle').on('click', function (event) {
        event.preventDefault();
        $('#main-nav').toggleClass("open");
    });

    // scroll function
    function scrollToID(id, speed) {
        var offSet = 50;
        var targetOffset = $(id).offset().top - offSet;
        var mainNav = $('#main-nav');
        $('html,body').animate({ scrollTop: targetOffset }, speed);
        if (mainNav.hasClass("open")) {
            mainNav.css("height", "1px").removeClass("in").addClass("collapse");
            mainNav.removeClass("open");
        }
    }
    if (typeof console === "undefined") {
        console = {
            log: function () { }
        };
    }


})
