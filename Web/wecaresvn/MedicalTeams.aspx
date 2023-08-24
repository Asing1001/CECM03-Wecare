<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="MedicalTeams.aspx.cs" Inherits="MedicalTeams" %>

<%@ Register Src="menu.ascx" TagPrefix="uc1" TagName="menu" %>




<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
      <!-- Page Content -->
    <style>
        th {
    background-color: gray;
    color:white;
} 
    </style>
    
    <link href="css/star-rating.css" rel="stylesheet" />
    <script src="js/star-ratings.js"></script>

  <script>
      //標籤變紅色
      $("#ctrTitle> li:eq(2)").addClass("active");
  //評等 改default
  $.fn.rating.defaults = {
      stars: 5,
      glyphicon: true,
      symbol: null,
      disabled: false,
      readonly: false,
      rtl: false,
      size: 'md',
      showClear: false,
      showCaption: true,
      defaultCaption: '{rating} Stars',
      starCaptions: {
          0.5: 'Half Star',
          1: 'One Star',
          1.5: 'One & Half Star',
          2: 'Two Stars',
          2.5: 'Two & Half Stars',
          3: 'Three Stars',
          3.5: 'Three & Half Stars',
          4: 'Four Stars',
          4.5: 'Four & Half Stars',
          5: 'Five Stars'
      },
      starCaptionClasses: {
          0.5: 'label label-danger',
          1: 'label label-danger',
          1.5: 'label label-warning',
          2: 'label label-warning',
          2.5: 'label label-info',
          3: 'label label-info',
          3.5: 'label label-primary',
          4: 'label label-primary',
          4.5: 'label label-success',
          5: 'label label-success'
      },
      clearButton: '<i class="glyphicon glyphicon-minus-sign"></i>',
      clearButtonTitle: 'Clear',
      clearButtonBaseClass: 'clear-rating',
      clearButtonActiveClass: 'clear-rating-active',
      clearCaption: 'Not Rated',
      clearCaptionClass: 'label label-default',
      clearValue: 0,
      captionElement: null,
      clearElement: null,
      containerClass: null
  };
  
  </script>
    <div class="container">
       <div class="row" ; style="margin-top:20px;">
         <%--選單--%>
           <div class="col-md-3 col-xs-12" style="margin-top:8px;">
           <uc1:menu runat="server" ID="menu" />
           </div>
         <%--table--%>
           <div class="col-md-8" style="margin-top:45px;">
             <div class="panel panel-default panel-border-radius">
                <div class="panel panel-heading"><h4>醫療團隊</h4></div>
             </div>

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Staff_ID" DataSourceID="drName" CssClass=" table-bordered table-condensed table-responsive ">
                    <Columns>
                        <asp:BoundField DataField="Staff_Name" HeaderText="姓名" SortExpression="Staff_Name" >
                        <HeaderStyle Width="80px" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="科別" SortExpression="Div_ID">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Div_ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# ClassUtility.getDivTitles((int)Eval("Div_ID")) %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle Width="80px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="職稱" SortExpression="Job_ID" Visible="False">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Job_ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# ClassUtility.getJobTitles((int)Eval("Job_ID")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Staff_Skill" HeaderText="專長" SortExpression="Staff_Skill" >
                        <HeaderStyle Width="300px" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="詳細資料" InsertVisible="False" SortExpression="Staff_ID">
                            <EditItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Staff_ID") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "DoctorDetail.aspx?Staff_ID="+Eval("Staff_ID") %>'>醫師資料</asp:HyperLink>
                            </ItemTemplate>
                            <HeaderStyle Width="80px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="看診評價" SortExpression="Staff_ID">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Staff_ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <input id="input-21e" value='<%# ClassUtility.getStaffEvalution((int)Eval("Staff_ID")) %>' type="number" class="rating"  data-disabled="true" min="0" max="5" step="0.5" data-size="xs" readonly="true" showCaption="false" />
                            </ItemTemplate>
                            <ItemStyle Width="142px" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

                    <asp:SqlDataSource ID="drName" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT [Staff_Name], [Div_ID], [Job_ID], [Staff_Skill], [Staff_ID] FROM [Staffs] WHERE ([Staff_Name] = @Staff_Name)">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="Staff_Name" QueryStringField="drName" Type="String" />
                     
                            </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Staff_ID], [Staff_Name], [Job_ID], [Div_ID], [Staff_Skill] FROM [Staffs] WHERE (([Div_ID] = @Div_ID) AND ([Job_ID] = @Job_ID))">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="Div_ID" QueryStringField="divID" Type="Int32" />
                                <asp:Parameter DefaultValue="1" Name="Job_ID" Type="Int32" />
                            </SelectParameters>
                    </asp:SqlDataSource>
               </div>
        </div>
 </div>
</asp:Content>

