<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="false" CodeFile="Calendar.aspx.cs" Inherits="Calendar" %>

<%@ Register Src="DayCalendar.ascx" TagName="DayCalendar" TagPrefix="uc1" %>

<%@ Register Src="WeekCalendar.ascx" TagName="WeekCalendar" TagPrefix="uc2" %>

<%@ Register Src="MonthCalendar.ascx" TagName="MonthCalendar" TagPrefix="uc3" %>
<%--<%@ Register Src="~/MonthCalendar.ascx" TagPrefix="uc1" TagName="MonthCalendar" %>--%>

<%@ Register Src="CalSearch.ascx" TagName="CalSearch" TagPrefix="uc4" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div id="coverAll" style="width: 9999999px; height: 9999999px; display: none; background-color: silver; opacity: 0.5; float: left; position: absolute;"></div>
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <div id="eCalDetail" style="position: fixed; border: 1px black solid; width: 300px; height: 260px; display: none; vertical-align: middle; margin: -130px 0 0 -150px; top: 50%; left: 50%; background-color: white;">
                    <table style="border-collapse: collapse;">
                        <tr style="text-align: center;">
                            <td colspan="2">
                                <h2>檢驗提醒 詳細資料</h2>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 100px; text-align: right;">病患姓名：</td>
                            <td style="width: 200px;">
                                <label id="eName"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">病歷號碼：</td>
                            <td>
                                <label id="ePttNum"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">檢驗項目：</td>
                            <td>
                                <label id="eItem"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">檢驗時間：</td>
                            <td>
                                <label id="eDatetime"></label>
                            </td>
                        </tr>
                        <tr style="display: none;">
                            <td style="text-align: right;">提醒天數：</td>
                            <td>
                                <label id="eRmdDays"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">主治醫師：</td>
                            <td>
                                <label id="eDocterName"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">備註：</td>
                            <td>
                                <label id="eRem"></label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: center;">
                                <div id="eBtnMod" class="btnDay" style="border-radius: 10px; font-size: 16px; width: 60px; height: 30px;">修改</div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <br />
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="dCalDetail" style="position: fixed; border: 1px black solid; width: 300px; height: 260px; display: none; vertical-align: middle; margin: -130px 0 0 -150px; top: 50%; left: 50%; background-color: white;">
                    <table style="border-collapse: collapse;">
                        <tr style="text-align: center;">
                            <td colspan="2">
                                <h2>用藥提醒 詳細資料</h2>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 100px; text-align: right;">病患姓名：</td>
                            <td style="width: 200px;">
                                <label id="dName"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">病歷號碼：</td>
                            <td>
                                <label id="dPttNum"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">用藥項目：</td>
                            <td>
                                <label id="dItem"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">用藥時間：</td>
                            <td>
                                <label id="dDatetime"></label>
                            </td>
                        </tr>
                        <tr style="display: none;">
                            <td style="text-align: right;">提醒天數：</td>
                            <td>
                                <label id="dRmdDays"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">主治醫師：</td>
                            <td>
                                <label id="dDocterName"></label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right;">備註：</td>
                            <td>
                                <label id="dRem"></label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: center;">
                                <div id="dBtnMod" class="btnDay" style="border-radius: 10px; font-size: 16px; width: 60px; height: 30px;">修改</div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <br />
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="Cal" style="display: block;">
                    <div id="searchBar" class="page-header">
                        <uc4:CalSearch ID="CalSearch1" runat="server" />
                        <%--<h1 id="tables">Tables</h1>--%>
                    </div>
                    <div class="page-header btn-group col-xs-2 pull-right">
                        <button id="btnDay" type="button" class="btn btn-default">日</button>
                        <button id="btnWeek" type="button" class="btn btn-default">週</button>
                        <button id="btnMonth" type="button" class="btn btn-default">月</button>
                    </div>
<%--                    <div class="page-header col-xs-2 pull-left" style="width: 20%; height: 22px;">
                        <button id="btnLast" type="button" class="btn btn-default"><</button>
                        <button id="btnToday" type="button" class="btn btn-default">Today</button>
                        <button id="btnNext" type="button" class="btn btn-default">></button>
                    </div>--%>
                    <div class="page-header col-xs-2 pull-left" style="width: 20%; height: 22px;">
                        <asp:Button ID="btnLast" runat="server" Text="<" CssClass="btn btn-default" OnClick="btnLast_Click" />
                        <asp:Button ID="btnToday" runat="server" Text="Today" CssClass="btn btn-default" OnClick="btnToday_Click" UseSubmitBehavior="False" />
                        <asp:Button ID="btnNext" runat="server" Text=">" CssClass="btn btn-default" OnClick="btnNext_Click" UseSubmitBehavior="False" />
                    </div>
                    <div class="bs-component">
                        <div id="weekCal" class="col-lg-12" style="width: 100%; margin: 0 auto; border: 1px black solid; border-radius: 20px; display: none;">
                            <uc2:WeekCalendar ID="WeekCalendar1" runat="server" />
                        </div>
                        <div id="dayCal" class="page-header col-lg-offset-3 col-lg-6" style="display:none;">
                            <uc1:DayCalendar ID="DayCalendar1" runat="server" />
                        </div>
                        <div id="monthCal" class="col-lg-12" style="display:none;">
                            <%--<div style="text-align:center;">
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </div>--%>
                            <div class="col-lg-12" style="width: 100%; margin: 0 auto; border: 1px black solid; border-radius: 20px;">
                                <uc3:MonthCalendar runat="server" ID="MonthCalendar" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        $(function () {
            if ($.cookie("caltype") == "day") {
                $('#monthCal').css('display', 'none');
                $('#weekCal').css('display', 'none');
                $('#dayCal').css('display', 'block');
            }
            else if ($.cookie("caltype") == "week") {
                $('#monthCal').css('display', 'none');
                $('#weekCal').css('display', 'block');
                $('#dayCal').css('display', 'none');
            }
            else if ($.cookie("caltype") == "month") {
                $('#monthCal').css('display', 'block');
                $('#weekCal').css('display', 'none');
                $('#dayCal').css('display', 'none');
            }
            if ($.cookie("Job") == null) {
                $('#searchBar').hide();
            }
            else {
                $('#searchBar').show();
            }
            
            $('#btnDay')
                .click(function () {
                    $('#monthCal').css('display', 'none');
                    $('#weekCal').css('display', 'none');
                    $('#dayCal').css('display', 'block');
                    document.cookie = "caltype=day";
                })
                .mouseover(function () {
                    $(this).css('cursor', 'pointer');
                });
            $('#btnWeek').click(function () {
                $('#monthCal').css('display', 'none');
                $('#weekCal').css('display', 'block');
                $('#dayCal').css('display', 'none');
                document.cookie = "caltype=week";
            })
                .mouseover(function () {
                    $(this).css('cursor', 'pointer');
                });
            $('#btnMonth').click(function () {
                $('#monthCal').css('display', 'block');
                $('#weekCal').css('display', 'none');
                $('#dayCal').css('display', 'none');
                document.cookie = "caltype=month";
            })
                .mouseover(function () {
                    $(this).css('cursor', 'pointer');
                });
        });
    </script>
</asp:Content>

