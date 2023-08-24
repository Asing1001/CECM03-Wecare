<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MonthCalendar.ascx.cs" Inherits="WeekCalendar" %>

<style type="text/css">
    #monthCal {
        border-collapse: collapse;
        margin: 0 auto;
        width: 100%;
    }
    .text-center {
        text-align: center;
    }
    .divMCal {
        height: 120px;
    }
    .divMCalSel {
        background-color: #f5f5f5;
    }
    .divMItem {
        border: 1px solid blue;
        width: 120px;
        border-radius: 10px;
        vertical-align: top;
        margin-top: 5px;
        margin-left: 20px;
        background-color: pink;
    }
    #monthCal td {
        width: 14%;
    }
</style>


<div>
<table id="monthCal">
    <tr>
        <td colspan="7" style="text-align:center; font-size:large; border-bottom:1px solid black; height: 30px;">
            <asp:Label ID="monthLabel" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr style="height: 30px;">
        <td class="text-center" style="border-bottom:1px black solid;">
            <div style="color: red;">(日)</div>
        </td>
        <td class="text-center" style="border-left:1px black solid; border-right:1px black solid;border-bottom:1px black solid;">
            <div>(一)</div>
        </td>
        <td class="text-center" style="border-left:1px black solid; border-right:1px black solid;border-bottom:1px black solid;">
            <div>(二)</div>
        </td>
        <td class="text-center" style="border-left:1px black solid; border-right:1px black solid;border-bottom:1px black solid;">
            <div>(三)</div>
        </td>
        <td class="text-center" style="border-left:1px black solid; border-right:1px black solid;border-bottom:1px black solid;">
            <div>(四)</div>
        </td>
        <td class="text-center" style="border-left:1px black solid; border-right:1px black solid;border-bottom:1px black solid;">
            <div>(五)</div>
        </td>
        <td class="text-center" style="border-bottom:1px black solid;">
            <div style="color: red;">(六)</div>
        </td>
    </tr>
    <tr>
        <td style="border-bottom:1px black solid;">
            <asp:Label ID="Label00" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal00" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label01" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal01" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label02" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal02" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label03" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal03" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label04" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal04" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label05" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal05" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-bottom:1px black solid;">
            <asp:Label ID="Label06" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal06" runat="server"></asp:Literal>
            </div>
        </td>
    </tr>
    <tr>
        <td style="border-bottom:1px black solid;">
            <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal10" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal11" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal12" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal13" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal14" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal15" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-bottom:1px black solid;">
            <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal16" runat="server"></asp:Literal>
            </div>
        </td>
    </tr>
    <tr>
        <td style="border-bottom:1px black solid;">
            <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal20" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal21" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal22" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal23" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal24" runat="server"></asp:Literal>

            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label25" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal25" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-bottom:1px black solid;">
            <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal26" runat="server"></asp:Literal>
            </div>
        </td>
    </tr>
    <tr>
        <td style="border-bottom:1px black solid;">
            <asp:Label ID="Label30" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal30" runat="server"></asp:Literal>

            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label31" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal31" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal32" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label33" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal33" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label34" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal34" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border:1px black solid;">
            <asp:Label ID="Label35" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal35" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-bottom:1px black solid;">
            <asp:Label ID="Label36" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal36" runat="server"></asp:Literal>
            </div>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal40" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-left:1px black solid; border-right:1px black solid">
            <asp:Label ID="Label41" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal41" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-left:1px black solid; border-right:1px black solid">
            <asp:Label ID="Label42" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal42" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-left:1px black solid; border-right:1px black solid">
            <asp:Label ID="Label43" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal43" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-left:1px black solid; border-right:1px black solid">
            <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal44" runat="server"></asp:Literal>
            </div>
        </td>
        <td style="border-left:1px black solid; border-right:1px black solid">
            <asp:Label ID="Label45" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal45" runat="server"></asp:Literal>
            </div>
        </td>
        <td>
            <asp:Label ID="Label46" runat="server" Text="Label"></asp:Label>
            <br />
            <div class="divMCal">
                <asp:Literal ID="Literal46" runat="server"></asp:Literal>
            </div>
        </td>
    </tr>
</table>
</div>
<script>
    $(function () {
        $('.divMCal').sortable({ connectWith: ".divMCal" }).disableSelection();
        $('#monthCal td:gt(6)').hover(
            function () {
                $(this).addClass('divMCalSel');
            },
            function () {
                $(this).removeClass('divMCalSel');
            });
    });

</script>
