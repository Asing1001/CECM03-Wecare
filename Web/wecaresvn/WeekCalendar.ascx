<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WeekCalendar.ascx.cs" Inherits="WeekCalendar" %>
<style type="text/css">
    .text-center {
        text-align: center;
    }
    .divWCalSel {
        background-color: cyan;
    }
    .divItemExam {
        border: 1px solid blue;
        width: 130px;
        border-radius: 10px;
        vertical-align: top;
        margin: 3px auto;
        padding-left: 10px;
        background-color: pink;
    }
    .divItemDrug {
        border: 1px solid blue;
        width: 130px;
        border-radius: 10px;
        vertical-align: top;
        margin: 3px auto;
        padding-left: 10px;
        background-color: aquamarine;
    }
    .calMoveIn {
        background-color: lightblue;
    }
    .tip {
        width: 160px;
        height: 100px;
        padding: 5px;
        background-color: yellow;
        border: 3px solid red;
        border-radius: 10px;
        display: none;
        position: fixed;
        left: 0;
        top: 0;
    }
    #weekCal {
        border-collapse:collapse;
        margin: 0 auto;
        width: 100%;
    }
</style>
<table id="weekCal">
    <tr style="border-bottom:1px solid black;">
        <td class="text-center" style="border-right:1px black solid; width:120px;">
            <div id="r0c1Date">
                <asp:Label ID="Label0" runat="server" Text="Label"></asp:Label>
            </div>
            <div style="color:red;">(日)</div>
        </td>
        <td class="text-center" style="border-right:1px black solid; width:120px;">
            <div id="r0c2Date">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(一)</div>
        </td>
        <td class="text-center" style="border-right:1px black solid; width:120px;">
            <div id="r0c3Date">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(二)</div>
        </td>
        <td class="text-center" style="border-right:1px black solid; width:120px;">
            <div id="r0c4Date">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(三)</div>
        </td>
        <td class="text-center" style="border-right:1px black solid; width:120px;">
            <div id="r0c5Date">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(四)</div>
        </td>
        <td class="text-center" style="border-right:1px black solid; width:120px;">
            <div id="r0c6Date">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(五)</div>
        </td>
        <td class="text-center" style="width:120px;">
            <div id="r0c7Date">
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </div>
            <div style="color:red;">(六)</div>
        </td>
    </tr>
    <tr>
        <td style="border-right:1px black solid; vertical-align:top;">
            <asp:Literal ID="Literal0" runat="server"></asp:Literal>
        </td>
        <td style="border-right:1px black solid; vertical-align:top;">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </td>
        <td style="border-right:1px black solid; vertical-align:top;">
            <asp:Literal ID="Literal2" runat="server"></asp:Literal>
        </td>
        <td style="border-right:1px black solid; vertical-align:top;">
            <asp:Literal ID="Literal3" runat="server"></asp:Literal>
        </td>
        <td style="border-right:1px black solid; vertical-align:top;">
            <asp:Literal ID="Literal4" runat="server"></asp:Literal>
        </td>
        <td style="border-right:1px black solid; vertical-align:top;">
            <asp:Literal ID="Literal5" runat="server"></asp:Literal>
        </td>
        <td style="vertical-align:top;">
            <asp:Literal ID="Literal6" runat="server"></asp:Literal>
        </td>
    </tr>
</table>
<div id="tip" class="tip">
    <label id="name"></label><br />
    <label id="item"></label><br />
    <label id="date"></label>
</div>
<%--<table id="week" class="auto-style1" style="border-collapse:collapse;">
    <tr id="r0" style="height:40px;">
        <td id="r0c0" class="auto-style2"></td>
        <td id="r0c1" class="text-center">
            <div id="r0c1Date">
                <asp:Label ID="lblSun" runat="server" Text="Label"></asp:Label>
            </div>
            <div style="color:red;">(日)</div>
        </td>
        <td id="r0c2" class="text-center">
            <div id="r0c2Date">
                <asp:Label ID="lblMon" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(一)</div>
        </td>
        <td id="r0c3" class="text-center">
            <div id="r0c3Date">
                <asp:Label ID="lblTue" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(二)</div>
        </td>
        <td id="r0c4" class="text-center">
            <div id="r0c4Date">
                <asp:Label ID="lblWen" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(三)</div>
        </td>
        <td id="r0c5" class="text-center">
            <div id="r0c5Date">
                <asp:Label ID="lblThu" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(四)</div>
        </td>
        <td id="r0c6" class="text-center">
            <div id="r0c6Date">
                <asp:Label ID="lblFri" runat="server" Text="Label"></asp:Label>
            </div>
            <div>(五)</div>
        </td>
        <td id="r0c7" class="text-center">
            <div id="r0c7Date">
                <asp:Label ID="lblSat" runat="server" Text="Label"></asp:Label>
            </div>
            <div style="color:red;">(六)</div>
        </td>
    </tr>
    <tr>
        <td class="auto-style3" style="width:100px;">提醒項目</td>
        <td style="border:1px solid black; vertical-align:top;">
            <asp:DataList ID="eCalSun" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:pink; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\exam.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患名稱") %>'></asp:Label>
                        <asp:Label ID="lblExamItemName" runat="server" text='<%# Bind("檢驗項目") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:DataList ID="dCalSun" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:aquamarine; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\drug.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患姓名") %>'></asp:Label>
                        <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("特殊藥物") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </td>
        <td style="border:1px solid black; vertical-align:top;">
            <asp:DataList ID="eCalMon" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:pink; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\exam.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患名稱") %>'></asp:Label>
                        <asp:Label ID="lblExamItemName" runat="server" text='<%# Bind("檢驗項目") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:DataList ID="dCalMon" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:aquamarine; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\drug.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患姓名") %>'></asp:Label>
                        <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("特殊藥物") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </td>
        <td style="border:1px solid black; vertical-align:top;">
            <asp:DataList ID="eCalTue" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:pink; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\exam.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患名稱") %>'></asp:Label>
                        <asp:Label ID="lblExamItemName" runat="server" text='<%# Bind("檢驗項目") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:DataList ID="dCalTue" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:aquamarine; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\drug.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患姓名") %>'></asp:Label>
                        <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("特殊藥物") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </td>
        <td style="border:1px solid black; vertical-align:top;">
            <asp:DataList ID="eCalWen" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:pink; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\exam.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患名稱") %>'></asp:Label>
                        <asp:Label ID="lblExamItemName" runat="server" text='<%# Bind("檢驗項目") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:DataList ID="dCalWen" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:aquamarine; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\drug.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患姓名") %>'></asp:Label>
                        <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("特殊藥物") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </td>
        <td style="border:1px solid black; vertical-align:top;">
            <asp:DataList ID="eCalThu" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:pink; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\exam.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患名稱") %>'></asp:Label>
                        <asp:Label ID="lblExamItemName" runat="server" text='<%# Bind("檢驗項目") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:DataList ID="dCalThu" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:aquamarine; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\drug.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患姓名") %>'></asp:Label>
                        <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("特殊藥物") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </td>
        <td style="border:1px solid black; vertical-align:top;">
            <asp:DataList ID="eCalFri" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:pink; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\exam.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患名稱") %>'></asp:Label>
                        <asp:Label ID="lblExamItemName" runat="server" text='<%# Bind("檢驗項目") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:DataList ID="dCalFri" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:aquamarine; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\drug.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患姓名") %>'></asp:Label>
                        <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("特殊藥物") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </td>
        <td style="vertical-align:top; border-top:1px black solid;">
            <asp:DataList ID="eCalSat" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:pink; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\exam.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患名稱") %>'></asp:Label>
                        <asp:Label ID="lblExamItemName" runat="server" text='<%# Bind("檢驗項目") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <asp:DataList ID="dCalSat" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <ItemTemplate>
                    <div draggable="true" style="border:1px solid blue; width:180px; border-radius:10px; vertical-align:top; margin-top:5px; margin-left:5px; background-color:aquamarine; ">
                        <asp:Image ID="imgExam" runat="server" ImageUrl="images\drug.jpg" Width="15" Height="15" />
                        <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患姓名") %>'></asp:Label>
                        <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("特殊藥物") %>'></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </td>
    </tr>
</table>--%>
<%--<script src="js/jquery.js"></script>--%>

<script>
    $(function () {
        $('#weekCal td:gt(6)')
            .hover(
                function () {
                    $(this).addClass('divWCalSel');
                },
                function () {
                    $(this).removeClass('divWCalSel');
                }
            );
        $('.divWCal')
            .sortable({
                opacity: 0.3,
                cursor: 'move',
                connectWith: ".divWCal",
                update: function () {
                    //alert($(this).attr('name'));
                }
            })
            .disableSelection();

        $('.divItemExam')
            .mouseover(function () {
                $(this).css('cursor', 'pointer');
                var txt = $(this).text();
                var txtArray = txt.split(/\s+/);
                timer = window.setTimeout(function () {
                    $(this).addClass('calMoveIn');
                    $('#tip').show(300);
                    $('#name').text("病患姓名：" + txtArray[0]);
                    $('#item').text("檢驗項目：" + txtArray[1]);
                    $('#date').text('檢驗日期：' + txtArray[4]);
                }, 600);
            })
            .mouseleave(function () {
                window.clearTimeout(timer)
                $(this).removeClass('calMoveIn');
                $('#tip').hide(100);
            })
            .mousemove(function (e) {
                $('.tip').css('top', e.pageY + 10).css('left', e.pageX + 10);
            })
            .click(function () {
                $('#coverAll').show();
                $('html').css('overflow', 'hidden');
                $('#coverAll').click(function () {
                    $(this).hide();
                    $('#eCalDetail').hide();
                    $('html').css('overflow', 'auto');
                });
                $('#eCalDetail').css('display', 'block');
                
                var txt = $(this).text();
                var txtArray = txt.split(/\s+/);
                var cid = txtArray[2];
                var ctype = txtArray[3] == 1 ? "exam" : "drug";
                $.ajax({
                    url: "HandlerGetSingleExamCal.ashx",
                    type: "get",
                    dataType: "json",  //json,xml,text
                    data: { 'id' : cid, 'type' : ctype},
                    success: function (data) {
                        $('#eName').text(data.Ptt_Name);
                        $('#ePttNum').text(data.Ptt_Num);
                        $('#eItem').text(data.Exam_NameCH);
                        $('#eDatetime').text(data.ExamCal_Date);
                        $('#eDocterName').text(data.Doctor_Name);
                        $('#eRem').text(data.ExamCal_Rem);
                        $('#eRmdDays').text(data.RmdDay_Days);
                    },
                    error: function (e) {

                    },
                    complete: function () {

                    }
                })
            });

        $('.divItemDrug')
            .mouseover(function () {
                $(this).css('cursor', 'pointer');
                var txt = $(this).text();
                var txtArray = txt.split(/\s+/);
                timer = window.setTimeout(function () {
                    $(this).addClass('calMoveIn');
                    $('#tip').show(300);
                    $('#name').text("病患姓名：" + txtArray[0]);
                    $('#item').text("用藥項目：" + txtArray[1]);
                    $('#date').text('檢驗日期：' + txtArray[4]);
                }, 600);
            })
            .mouseleave(function () {
                window.clearTimeout(timer);
                $(this).removeClass('calMoveIn');
                $('#tip').hide(100);
            })
            .mousemove(function (e) {
                $('.tip').css('top', e.pageY + 10).css('left', e.pageX + 10);
            })
            .click(function () {
                $('#coverAll').show();
                $('html').css('overflow', 'hidden');
                $('#dCalDetail').css('display', 'block');
                $('#coverAll').click(function () {
                    $(this).hide();
                    $('#dCalDetail').hide();
                    $('html').css('overflow', 'auto');
                });
                var txt = $(this).text();
                var txtArray = txt.split(/\s+/);
                var cid = txtArray[2];
                var ctype = txtArray[3] == 1 ? "exam" : "drug";
                $.ajax({
                    url: "HandlerGetSingleExamCal.ashx",
                    type: "get",
                    dataType: "json",  //json,xml,text
                    data: { 'id': cid, 'type': ctype },
                    success: function (data) {
                        $('#dName').text(data.Ptt_Name);
                        $('#dPttNum').text(data.Ptt_Num);
                        $('#dItem').text(data.Drug_NameCH);
                        $('#dDatetime').text(data.DrugCal_Date);
                        $('#dDocterName').text(data.Doctor_Name);
                        $('#dRem').text(data.DrugCal_Rem);
                        $('#dRmdDays').text(data.RmdDay_Days);
                    },
                    error: function (e) {

                    },
                    complete: function () {

                    }
                });
            });
        });
</script>