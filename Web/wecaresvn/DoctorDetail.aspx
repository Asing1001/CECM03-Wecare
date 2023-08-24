<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="DoctorDetail.aspx.cs" Inherits="DoctorDetail" %>

<%@ Register Src="menu.ascx" TagPrefix="uc1" TagName="menu" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <link href="css/DrCss.css" rel="stylesheet" />
 <style>  
   #ContentPlaceHolder2_DetailsView1 td:first-of-type 
   {
    background-color: gray;
    color:white;
   } 
 </style>


    <div class="container">
     <div class="row"; style="margin-top:20px;">
         <%--選單--%>
     <div class="col-md-3 col-xs-12"  style="margin-top:8px">
        <uc1:menu runat="server" ID="menu" />
     </div>
         
      <div class="col-md-8" style="margin-top:45px;">
             <div class="panel panel-default panel-border-radius">
               <div class="panel panel-heading"><h4>醫療團隊</h4></div>
            </div>
          <%--table--%>
          <div class="col-md-6" style="width:60%">
         
                <asp:DetailsView ID="DetailsView1" runat="server"  Height="80px" Width="400px" AutoGenerateRows="False" DataKeyNames="Staff_ID" DataSourceID="DrDetail" CssClass=" table-bordered table-condensed table-responsive ">
                    <Fields>
                        <asp:ImageField DataImageUrlField="Staff_ID" DataImageUrlFormatString="HandlerDrPix.ashx?Staff_ID={0}" Visible="False">
                             <ControlStyle Width="60px" Height="60" />
                             <HeaderStyle Width="60px" />
                             <ItemStyle Width="300px" />
                        </asp:ImageField>
                        <asp:BoundField DataField="Staff_Name" HeaderText="姓名" SortExpression="Staff_Name" >
                        <HeaderStyle Width="60px" />
                        <ItemStyle Width="240px" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="職稱" SortExpression="Job_ID">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Job_ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Job_ID") %>'></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# ClassUtility.getJobTitles((int)Eval("Job_ID")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="科別" SortExpression="Div_ID">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Div_ID") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Div_ID") %>'></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# ClassUtility.getDivTitles((int)Eval("Div_ID")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="學歷">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Staff_Edu") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Staff_Edu") %>'></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label5" runat="server" Text='<%# ClassUtility.getStringbr((object)Eval("Staff_Edu")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="經歷">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Staff_Exp") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Staff_Exp") %>'></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# ClassUtility.getStringbr((object)Eval("Staff_Exp")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="專長">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Staff_Skill") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Staff_Skill") %>'></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# ClassUtility.getStringbr((object)Eval("Staff_Skill")) %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Staff_Email" HeaderText="E-mail" SortExpression="Staff_Email" />
                    </Fields>
                    <RowStyle Height="40px" />
                </asp:DetailsView>

                <asp:SqlDataSource ID="DrDetail" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT [Staff_ID], [Staff_Pix], [Staff_Name], [Job_ID], [Div_ID], [Staff_Email], [Staff_Edu], [Staff_Exp], [Staff_Skill] FROM [Staffs] WHERE ([Staff_ID] = @Staff_ID)" ProviderName="System.Data.SqlClient">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Staff_ID" QueryStringField="Staff_ID" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                </div>
        <%--照片--%>
        <div class="col-md-4" >
            <asp:FormView ID="FormView1" runat="server" Width="40px" DataKeyNames="Staff_ID" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" ImageUrl='<%#"HandlerDrPix.ashx?Staff_ID="+ Eval("Staff_ID") %>'  />
            </ItemTemplate>
            </asp:FormView>
    
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" ProviderName="System.Data.SqlClient" SelectCommand="SELECT DISTINCT [Staff_ID], [Staff_Pix] FROM [Staffs] WHERE ([Staff_ID] = @Staff_ID)" >
            <SelectParameters>
                <asp:QueryStringParameter Name="Staff_ID" QueryStringField="Staff_ID" Type="Int32" />
            </SelectParameters>
            </asp:SqlDataSource>
       </div>

    </div>
    </div>
</div>

</asp:Content>

