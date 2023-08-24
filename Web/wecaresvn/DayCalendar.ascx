<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DayCalendar.ascx.cs" Inherits="DayCalendar" %>

<style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 283px;
    }
    .RowHeader {
        width: 10px;
        height: 30px;
    }
    .auto-style4 {
        height: 40px;
    }
    .eachDiv {
        background-color: lightgoldenrodyellow;
        width: 140px;
        border: 1px solid blue;
        border-radius: 5px;
        color: red;
        margin-bottom:3px;
        margin-right:5px;
    }
    #sortable {
        list-style-type: none;
        margin: 0;
        padding: 0;
        width: 60%;
    }
    #sortable li {
        margin: 0 3px 3px 3px;
        padding: 0.4em;
        padding-left: 1.5em;
        font-size: 1.4em;
        height: 18px;
    }
    #sortable li div {
        position: absolute;
        margin-left: -1.3em;
    }
</style>
<%--<script>
    $(function () {
        $("#sortable").sortable();
        $("#sortable").disableSelection();
    });
</script>--%>

<asp:Panel ID="OutPanel" runat="server">

    
    <%--<table id="t1" class="auto-style1" style="width:100%; margin:0 auto;">--%>
       <%-- <tr>
            <td id="r0c0" style="width:100px;">
            </td>
            <td id="r0c1">
                <div id="Today" style="height:40px;  text-align:center; font-size:20px;vertical-align:middle;">
                    <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>                    
                </div>
                
            </td>
        </tr>--%>
     <table  id="t1" class="table table-striped table-hover ">
         <thead>
                  <tr >                                    
                    <th><h2 class="text-danger ">病患姓名</h2></th>
                    <th><h2 class="text-danger ">提醒事項</h2></th>
                  </tr>
                </thead>
        <tr>
           
                <asp:DataList ID="eCal" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <ItemTemplate>
                       <tr> 
                    
                            <%--<asp:Image ID="img" runat="server" Height="15" ImageUrl="~\images\exam.jpg" Width="15" />--%>
                          <td>  <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患名稱") %>'></asp:Label></td>
                          <td>   <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("檢驗項目") %>'></asp:Label></td>
                       
                           </tr>
                    </ItemTemplate>
                </asp:DataList>

                <asp:DataList ID="drugCalList" runat="server" ExtractTemplateRows="False" FooterStyle-VerticalAlign="Top" RepeatColumns="6" RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <ItemTemplate>
                         <tr class="danger"> 
                      
                            <%--<asp:Image ID="img" runat="server" Height="15" ImageUrl="~\images\exam.jpg" Width="15" />--%>
                          <td> <asp:Label ID="lblPttName" runat="server" Text='<%# Bind("病患姓名") %>'></asp:Label></td> 
                          <td>  <asp:Label ID="lblDrugName" runat="server" Text='<%# Bind("特殊藥物") %>'></asp:Label></td> 
                     
                              </tr> 
                    </ItemTemplate>
                </asp:DataList>
           
        </tr>
    </table>
</asp:Panel>

<%--<div class="col-lg-12">
            <div class="page-header">
              <h1 id="tables">Tables</h1>
            </div>

            <div class="bs-component">
              <table class="table table-striped table-hover ">
                <thead>
                  <tr>
                    <th>#</th>
                    <th>Column heading</th>
                    <th>Column heading</th>
                    <th>Column heading</th>
                  </tr>
                </thead>
                <tbody>                 
                  <tr>
                    <td>2</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                  </tr>                 
                  <tr class="danger">
                    <td>5</td>
                    <td>Column content</td>
                    <td>Column content</td>
                    <td>Column content</td>
                  </tr>                 
                </tbody>
              </table> 
            <div id="source-button" class="btn btn-primary btn-xs" style="display: none;">&lt; &gt;</div>

            </div><!-- /example -->
          </div>--%>