var ExamStList = new Array();
var PiecolumnName = new Array();
var PiecolumnValue = new Array();
var Piecolumnall = 0;
$.ajax({
    url: "HadExamStatic.ashx",
    type: "get",
    dataType: "json",  //json,xml,text
    success: function (data) {
        for (var i = 0; i < data.Table.length; i++) {
            ExamStList.push([data.Table[i].ExamCat_Name, data.Table[i].CountExam]);  //檢驗項目統計圖
            PiecolumnName.push(data.Table[i].ExamCat_Name);
            PiecolumnValue.push(data.Table[i].CountExam);
            Piecolumnall += parseInt(PiecolumnValue[i])
        }
        console.log(Piecolumnall)
        //圓餅圖
        $(function () {
            $('#ctExamstatic').highcharts({
                chart: {
                    plotBackgroundColor: null,
                    plotBorderWidth: null,//null,
                    plotShadow: false
                },
                title: {
                    text: '檢驗項目統計圖',
                },
                tooltip: {
                    pointFormat: '{point.percentage:.1f}%</b>'
                },
                plotOptions: {
                    pie: {
                        allowPointSelect: true,
                        cursor: 'pointer',
                        dataLabels: {
                            enabled: true,
                            format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                            style: {
                                color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                            }
                        },
                        showInLegend: true
                    }
                },
                series: [{
                    type: 'pie',
                    name: '',
                    data: ExamStList
                }]
            });
        });
        //平面長條圖
        $(function () {
            $('#ctExamstaticbar').highcharts({
                chart: {
                    type: 'column'
                },
                title: {
                    text: '檢驗項目長條圖'
                },
                subtitle: {
                },
                xAxis: {
                    type: 'category',
                    labels: {
                        rotation: 0,
                        style: {
                            fontSize: '13px',
                            fontFamily: 'Verdana, sans-serif'
                        }
                    }
                },
                yAxis: {
                    min: 0,
                    title: {
                        text: '人數',
                        rotation: 0, y: -160, x: 25
                    }
                },
                legend: {
                    enabled: true
                },
                tooltip: {
                    pointFormat: '<b>{point.y:.f}個</b>'
                },
                series: [{
                    name: '檢驗名稱',
                    data: ExamStList,
                    dataLabels: {
                        enabled: true,
                        rotation: 0,
                        color: '#FFFFFF',
                        align: 'right',
                        x: -30,
                        y: 10,
                        style: {
                            fontSize: '13px',
                            fontFamily: 'Verdana, sans-serif',
                            textShadow: '0 0 3px black'
                        }
                    }
                }]
            });
        });
        //3D長條圖
        $(function () {
            // Set up the chart
            var chart = new Highcharts.Chart({
                chart: {
                    renderTo: 'container3dcolumn',
                    type: 'column',
                    margin: 75,
                    options3d: {
                        enabled: true,
                        alpha: 15,
                        beta: 15,
                        depth: 50,
                        viewDistance: 25
                    }
                },
                title: {
                    text: '檢驗項目長條圖'
                },
                tooltip: {
                    pointFormat: '<b>{point.y:.f}個</b>'
                },
                xAxis: {
                    type: 'category',
                    labels: {
                        rotation: 0,
                        style: {
                            fontSize: '13px',
                            fontFamily: 'Verdana, sans-serif'
                        }
                    }
                },
                yAxis: {
                    min: 0,
                    title: {
                        text: '人數',
                        rotation: 0,
                    }
                },
                subtitle: {
                    //text: '檢驗人數統計'
                },
                legend: {           //圖例標籤位置
                    align: 'right',
                    x: -70,
                    verticalAlign: 'top',
                    y: 20,
                    floating: true,
                    backgroundColor: (Highcharts.theme && Highcharts.theme.background2) || 'white',
                    borderColor: '#CCC',
                    borderWidth: 1,
                    shadow: false
                },
                plotOptions: {
                    column: {
                        depth: 25
                    }
                    //資料標籤
                    //        column: {
                    //    stacking: 'normal',
                    //    dataLabels: {
                    //        enabled: true,
                    //        color: (Highcharts.theme && Highcharts.theme.dataLabelsColor) || 'white',
                    //        style: {
                    //            textShadow: '0 0 3px black, 0 0 3px black'
                    //        }
                    //    }
                    //}
                },
                series: [{
                    name: '檢驗項目',
                    data: ExamStList,

                }]
            });

            function showValues() {
                $('#R0-value').html(chart.options.chart.options3d.alpha + '度');
                $('#R1-value').html(chart.options.chart.options3d.beta + '度');
            }

            // Activate the sliders
            $('#R0').on('change', function () {
                chart.options.chart.options3d.alpha = this.value;
                showValues();
                chart.redraw(false);
            });
            $('#R1').on('change', function () {
                chart.options.chart.options3d.beta = this.value;
                showValues();
                chart.redraw(false);
            });

            showValues();
        }); //3D
        //總表格一
        var Piecolumntitale = '<td>項目</td>';
        var PiecolumnNumber = '<td>人數</td>';
        var Piecolumnpersion = '<td>百分比</td>';
        $(function () {
            for (var i = 0; i < ExamStList.length; i++) {
                Piecolumntitale += '<td>' + PiecolumnName[i] + '</td>'
                PiecolumnNumber += '<td>' + PiecolumnValue[i] + '</td>'
                Piecolumnpersion += '<td>' + Math.round((PiecolumnValue[i] / Piecolumnall) * 10000) / 100 + '%' + '</td>'
            }
            Piecolumntitale += '<td>' + '總數' + '</td>'
            PiecolumnNumber += '<td>' + Piecolumnall + '</td>'
            Piecolumnpersion += '<td>' + '100%' + '</td>'
            $('#staticexamtable tr:nth-child(1)').html(Piecolumntitale)  //$('#statictotal').find('tr').eq(0).html(examtitale)  
            $('#staticexamtable tr:nth-child(2)').html(PiecolumnNumber)
            $('#staticexamtable tr:nth-child(3)').html(Piecolumnpersion)
        })


    }

});
//檢驗異常
var ExamTclass = new Array();      //檢驗項目
var ExamTStListwomen = new Array(); //女檢驗全
var ExamTStListmen = new Array();   //男檢驗全
var alllist = new Array();      //檢驗人數全
var Examclass = new Array();   //檢驗項目
var flag = true;
var ExamStListwomen = new Array();   //女檢驗異常
var ExamStListmen = new Array();   //男檢驗異常
var Unusalalllist = new Array();      //總異常
$.ajax({                            //總檢驗數據
    url: "HadExamNormal.ashx",
    type: "get",
    dataType: "json",
    success: function (data) {
        NonRepetitive(ExamTclass, data);
        RecordExamList(ExamTclass, data, ExamTStListwomen, ExamTStListmen, 0)
        $.ajax({                             //堆疊圖
            url: "HadExamUnusual.ashx",
            type: "get",
            dataType: "json",
            success: function (data) {
                flag = true;  //重新設定
                NonRepetitive(Examclass, data)
                RecordExamList(Examclass, data, ExamStListwomen, ExamStListmen, null);
                //平面堆疊圖
                $(function () {
                    $('#ctExamUnusual').highcharts({
                        chart: {
                            type: 'column'
                        },
                        title: {
                            text: '各項檢查異常值統計'
                        },
                        xAxis: {
                            categories: Examclass
                        },
                        yAxis: {
                            min: 0,
                            title: {
                                text: '人數',
                                rotation: 0, y: -170, x: 17
                            },
                            stackLabels: {
                                enabled: true,
                                style: {
                                    fontWeight: 'bold',
                                    color: (Highcharts.theme && Highcharts.theme.textColor) || 'gray'
                                }
                            }
                        },
                        legend: {
                            align: 'right',
                            x: -70,
                            verticalAlign: 'top',
                            y: 20,
                            floating: true,
                            backgroundColor: (Highcharts.theme && Highcharts.theme.background2) || 'white',
                            borderColor: '#CCC',
                            borderWidth: 1,
                            shadow: false
                        },
                        tooltip: {
                            formatter: function () {
                                return '<b>' + this.x + '</b><br/>' +
                                    this.series.name + ': ' + this.y + '<br/>' +
                                    '總異常: ' + this.point.stackTotal;
                            }
                        },
                        plotOptions: {
                            column: {
                                stacking: 'normal',
                                dataLabels: {
                                    enabled: true,
                                    color: (Highcharts.theme && Highcharts.theme.dataLabelsColor) || 'white',
                                    style: {
                                        textShadow: '0 0 3px black, 0 0 3px black'
                                    }
                                }
                            }
                        },
                        series: [{
                            name: '女異常數',
                            data: ExamStListwomen
                        }, {
                            name: '男異常數',
                            data: ExamStListmen
                        }]
                    });
                });
                //3D堆疊圖
                //$(function () {
                //    $('#ctExamUnusual').highcharts({

                //        chart: {
                //            type: 'column',
                //            options3d: {
                //                enabled: true,
                //                alpha: 0,
                //                beta: 5,
                //                viewDistance: 25,
                //                depth: 40
                //            },
                //            marginTop: 80,
                //            marginRight: 40
                //        },

                //        title: {
                //            text: '各項檢查異常值統計'
                //        },

                //        xAxis: {
                //            categories: Examclass
                //        },

                //        yAxis: {
                //            allowDecimals: false,
                //            min: 0,
                //            title: {
                //                text: '人數',
                //                rotation: 0,
                //            }
                //        },

                //        tooltip: {
                //            formatter: function () {
                //                return '<b>' + this.x + '</b><br/>' +
                //                    this.series.name + ': ' + this.y + '<br/>' +
                //                    '總異常: ' + this.point.stackTotal;
                //            }
                //        },
                //        legend: {
                //            align: 'right',
                //            x: -30,
                //            verticalAlign: 'top',
                //            y: 50,
                //            floating: true,
                //            backgroundColor: (Highcharts.theme && Highcharts.theme.background2) || 'white',
                //            borderColor: '#CCC',
                //            borderWidth: 1,
                //            shadow: false
                //        },
                //        plotOptions: {
                //            column: {
                //                stacking: 'normal',
                //                dataLabels: {
                //                    enabled: true,
                //                    color: (Highcharts.theme && Highcharts.theme.dataLabelsColor) || 'white',
                //                    style: {
                //                        textShadow: '0 0 3px black, 0 0 3px black'
                //                    }
                //                }
                //            }
                //        },

                //        series: [{
                //            name: '女異常人數',
                //            data: ExamStListwomen
                //        }, {
                //            name: '男異常人數',
                //            data: ExamStListmen
                //        }]
                //    });
                //});


                //異常Table
                var examtitale = '<td>項目</td>';
                var womennumber = '<td>女異常數</td>'
                var mennumber = '<td>男異常數</td>'
                var allnumber = '<td>總異常數</td>'
                var womenPercent = '<td>女異常比例</td>'
                var menPercent = '<td>男異常比例</td>'
                var allPercent = '<td>總異常比例</td>'
                $(function () {
                    for (var i = 0; i < Examclass.length; i++) {
                        if (ExamStListwomen[i] == null) {
                            ExamStListwomen.splice(i, 1, '0') //把null值改為 0                            
                        }
                        if (ExamStListmen[i] == null) {
                            ExamStListmen.splice(i, 1, '0')
                        }
                        alllist.push(parseInt(ExamTStListwomen[i]) + parseInt(ExamTStListmen[i]))
                        Unusalalllist.push(parseInt(ExamStListwomen[i]) + parseInt(ExamStListmen[i]))
                        examtitale += '<td>' + Examclass[i] + '</td>'
                        womennumber += '<td>' + ExamStListwomen[i] + '</td>'
                        mennumber += '<td>' + ExamStListmen[i] + '</td>'
                        allnumber += '<td>' + Unusalalllist[i] + '</td>'
                        womenPercent += '<td>' + Math.round((ExamStListwomen[i] / alllist[i]) * 10000) / 100 + '%' + '</td>'  //四捨五入到小數第二位數
                        menPercent += '<td>' + Math.round((ExamStListmen[i] / alllist[i]) * 10000) / 100 + '%' + '</td>'
                        allPercent += '<td>' + Math.round(((ExamStListwomen[i] / alllist[i]) + (ExamStListmen[i] / alllist[i])) * 10000) / 100 + '%' + '</td>'
                    }
                    $('#statictotal tr:nth-child(1)').html(examtitale)  //$('#statictotal').find('tr').eq(0).html(examtitale)  
                    $('#statictotal tr:nth-child(2)').html(womennumber)
                    $('#statictotal tr:nth-child(3)').html(mennumber)
                    $('#statictotal tr:nth-child(4)').html(allnumber)
                    $('#statictotal tr:nth-child(5)').html(womenPercent)
                    $('#statictotal tr:nth-child(6)').html(menPercent)
                    $('#statictotal tr:nth-child(7)').html(allPercent)
                })
            }
        });
    }
})

//找出不重複的檢驗項目方法
function NonRepetitive(classname, data) {
    for (var i = 0; i < data.Table.length; i++) {          //取出jsony 資料        
        for (var j = 0; j < classname.length; j++) {       //新陣列
            flag = true;
            if (data.Table[i].Exam_NameCH.toString() == classname[j].toString()) {  //判斷取出的json資料 和 陣列已存在的值有沒有一樣 
                flag = false;  //一樣就跳離判斷且不要寫入陣列        
                break;
            }
        }
        if (flag) {
            classname.push([data.Table[i].Exam_NameCH])

        }
    }
}
//分為男女兩陣列方法
function RecordExamList(classname, data, women, men, myvalue) {
    for (var i = 0; i < classname.length; i++) {
        var flagcount = 0; //用來記錄是否男生或女生都有此檢驗項目
        for (var j = 0; j < data.Table.length; j++) {
            var examjson = data.Table[j].Exam_NameCH + data.Table[j].Ptt_Sex.toString()
            if ((classname[i] + "女") == (examjson)) {
                women.push(data.Table[j].CountExam)  //有此檢驗相目的就加入陣列
                flagcount += 1;     //代表女生有此檢驗
            }
            else if ((classname[i] + "男") == (examjson)) {
                men.push(data.Table[j].CountExam)
                flagcount -= 1;    //代表男生有此檢驗，男女都有flgcount會為零
            }

        }
        if (flagcount == 1) {                //沒有檢驗項目的男生給予null值
            men.push(myvalue)
        }
        else if (flagcount == -1) {
            women.push(myvalue)    //沒有檢驗項目的女生給予null值
        }
    }
}