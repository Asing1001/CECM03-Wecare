var x;
var evaid;
var datalist = [];
var Datelist = [];

$(document).ready(function () {

    //report
    //病患report 預設為檢查項目,故隱藏檢查日期
    if ($("#ContentPlaceHolder2_ReportSearchDDL").val() == "2")  
    {
        $("#ContentPlaceHolder2_DateDDL").hide();

    }
    else
    {
        $("#ContentPlaceHolder2_ExamDDL").hide();
    }

    $("#ContentPlaceHolder2_ReportSearchDDL").change(function () {
        if ($("#ContentPlaceHolder2_ReportSearchDDL").val() == "1") {
            $("#ContentPlaceHolder2_ExamDDL").val("1");
            $("#ContentPlaceHolder2_ExamDDL").hide();
            $("#ContentPlaceHolder2_DateDDL").show();
        }
        else {
            $("#ContentPlaceHolder2_ExamDDL").show();
            $("#ContentPlaceHolder2_DateDDL").hide();
            $("#ContentPlaceHolder2_DateDDL").val("1");


        }
    })

    //console.log($('#ContentPlaceHolder2_ExamDDL').val());
    $("#ContentPlaceHolder2_ExamDDL").change(function(){
       $('#ContentPlaceHolder2_HiddenField1').val("1"); //換項目 page 重回1,Hideen重置回1
    })

    if ($("#ContentPlaceHolder2_ExamDDL").val() != "1") //項目 非請選擇 時
    {
        //alert($('#ContentPlaceHolder2_HiddenField1').val());
        $.getJSON("Handlers/HandlerJsonReportPatients.ashx", { "pexam": $('#ContentPlaceHolder2_ExamDDL').val(), "Page": $('#ContentPlaceHolder2_HiddenField1').val() },
                function (data) {
                    $.each(data, function (propName, propValue) //array
                    {
                        datalist.push(parseInt(this.結果值));
                        Datelist.push(this.檢驗日期.slice(0, -9));
                    })
                    $('#container').highcharts({
                        title: {
                            text: '檢查報告分析',
                            x: -20 //center
                        },
                        subtitle: {
                            text: '(一頁5筆)',
                            x: -20
                        },
                        xAxis: {
                            categories: Datelist
                        },
                        yAxis: {
                            title: {
                                text: '值',
                                rotation: 0, y: -170, x: 20
                            },
                            plotLines: [{
                                value: 0,
                                width: 1,
                                color: '#808080'
                            }]
                        },
                        tooltip: {
                            valueSuffix: ''
                        },
                        legend: {
                            layout: 'vertical',
                            align: 'right',
                            verticalAlign: 'middle',
                            borderWidth: 0
                        },
                        series: [{
                            name: $('#ContentPlaceHolder2_ExamDDL').val(),
                            data: datalist
                        }]

                    });
                }
              )
    }
    

    // SatisfactionQuestionnaire
    $("#ContentPlaceHolder2_FormView1_UpdateButton").click(function () {
        $("#ContentPlaceHolder2_FormView1_TextBox2").val($("#input-star").val());
    })

    $('a[id^="ContentPlaceHolder2_GridView1_HyperScore_"]').each(function () {
        if ($(this).text() != "評分")
        { $(this).css("color","black");
            if ($(this).parent().next().next().children().text() == "")
            {
                $(this).parent().next().next().children().html("抽獎");
                $(this).parent().next().next().children().click(function () {
                    evaid = $(this).parent().prev().prev().prev().prev().prev().html();
                    //alert(evaid);
                    $('#ContentPlaceHolder2_FormView1').hide(); //右邊編輯評價視窗隱藏
                    $('#lotteryGame').modal('show');
                    x = $(this);
                })
            }
            else {
                $(this).parent().next().next().children().css("color", "black");
            
            }
        }
        else { $(this).parent().next().next().children().html("先評分"); }

    })

    
    //JQuery Rotate
        var rotateFunc = function (awards, angle, text) { //awards:獎項，angle:獎項對應的角度
            $('#lotteryBtn').stopRotate();
            $("#lotteryBtn").rotate({
                angle: 0,
                duration: 5000,
                animateTo: angle + 1440, //angle是圖片上各獎項對應的角度，1440是我要讓指針旋轉4圈。所以最後的結束的角度就是這樣子
                callback: function () {

                    sAlert(text); //套用myalert
                    //alert(text);
                    if (text == "恭喜您!!抽中商城購物金")
                    {
                        //傳email
                        $.ajax({
                            url: "Handlers/HandlerSendCoupon.ashx",
                            type: "get"})
                    }

                    $.ajax({
                        url: "Handlers/HandlerSQRlt.ashx",
                        data: { "Eva_Id": evaid, "Eva_Rlt": text.slice(7, text.length) },
                        type: "get"
                    })

                    x.html(text.slice(7, text.length)); //顯示中獎獎項
                    x.css("color", "black");
                    $('#lotteryGame').modal("hide");
                }
            });
        };
        $("#lotteryBtn").rotate({
            bind:
            {
                click: function () {
                    var data = [1, 2, 3, 0]; //返回的數組
                    data = 1;  //data[Math.floor(Math.random() * data.length)];
                    if (data == 1) {
                        rotateFunc(1, 157, '恭喜您!!抽中商城購物金')
                    }
                    if (data == 2) {
                        rotateFunc(2, 247, '恭喜您!!抽中活性碳口罩')
                    }
                    if (data == 3) {
                        rotateFunc(3, 22, '恭喜您!!抽中3M乾洗手')

                    }
                    if (data == 0) {
                        var angle = [67, 112, 202, 292, 337];
                        angle = angle[Math.floor(Math.random() * angle.length)]
                        rotateFunc(0, angle, '很遺憾,這次您未抽中獎')

                    }
                    x.unbind();//抽過 不能再抽
                }
            }

        })


   // })
})