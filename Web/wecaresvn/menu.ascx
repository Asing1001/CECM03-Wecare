<%@ Control Language="C#" AutoEventWireup="true" CodeFile="menu.ascx.cs" Inherits="menu" %>

<link href="css/DrCss.css" rel="stylesheet" />
<link href="css/jquery-autocomplete.css" rel="stylesheet" />

<style>
    #ui-id-9 .ui-widget-content{
        background-color:white;
    }
</style>
<script src="js/jquery-autocomplete.js"></script>
<script src="js/jquery-Accordion.min.js"></script>

<script>
    $(function () {
        $.ajax({
            url: 'Handlers/HandlerJsonDrSearch.ashx',
            type:'get',
            datatype: 'json',
            success: function (data) {
                $("#ContentPlaceHolder2_menu_keyword").autocomplete({ source: data });
            }
        })
        $("#accordion").accordion({
            heightStyle: "content"

        });
    });
</script>
                    <h4>查詢醫生</h4>
                    <div class="z1">
                        <asp:TextBox ID="keyword" runat="server"  class="form-control" style="width:160px ;display:inline-block;"></asp:TextBox>
                       <div class="input-group-btn" style="width:40px;display:inline-block;" >
                           <asp:Button ID="btnSearchDr" runat="server" Text="搜尋"  OnClick="btnSearchDr_Click"/>
                        </div>
                        <div id="SearchList">
                          
                        </div>
                    </div>

                  <h4>團隊總覽</h4>
                  <div id="accordion" class="z1">

                      <h3>內科部</h3>
                      <div style="height:auto">
                           <ul  class="list-unstyled">
                          <asp:DataList ID="DataList2" runat="server" DataKeyField="Div_ID" DataSourceID="SqlDataSource2">
                              <ItemTemplate>
                                  <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "MedicalTeams.aspx?divID="+Eval("Div_ID") %>'><%#Eval("Div_Name")%></asp:HyperLink>
                              </ItemTemplate>
                          </asp:DataList>
                           </ul>
                          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT * FROM [Divisions]"></asp:SqlDataSource>
                      </div>

                      <h3>外科部</h3>
                      <div style="height:auto">
                          <ul  class="list-unstyled" >
                                <li><a href="#">一般外科</a>
                                </li>
                                <li><a href="#">胸腔外科</a>
                                </li>
                                <li><a href="#">心臟外科</a>
                                </li>
                                <li><a href="#">腦腫瘤神經外科</a>
                                </li>
                                <li><a href="#">一般整形外科</a>
                                </li>
                                <li><a href="#">整形外傷科</a>
                                </li>
                                <li><a href="#">直腸肛門科</a>
                                </li>
                          </ul>
                        </div>
                     <h3>急診醫學部</h3>
                      <div style="height:auto">
                          <ul  class="list-unstyled" >
                                <li><a href="#">家醫科</a>
                                </li>
                                <li><a href="#">職業醫學科</a>
                                </li>
                                <li><a href="#">急診醫學科</a>
                                </li>
                          </ul>
                        </div>
                     <h3>牙科部</h3>
                      <div style="height:auto">
                          <ul  class="list-unstyled" >
                                <li><a href="#">一般牙科</a>
                                </li>
                                <li><a href="#">牙周病科</a>
                                </li>
                                <li><a href="#">口腔外科</a>
                                </li>
                                <li><a href="#">顱顏矯正牙科</a>
                                </li>
                          </ul>
                        </div>
                       </div>
 
        
     