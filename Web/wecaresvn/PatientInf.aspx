<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PatientInf.aspx.cs" Inherits="PatientInf" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <div style="width: 960px; height: 750px; margin: 30px auto 30px auto;">
        <%--<h2 style="color: black; text-align: center; font-style: oblique"></h2>--%>
        <div style="width: 610px;  margin:0 auto;">

            <%--上半部--%>
            <div class="row" style="width: 660px; height: 245px">
                <%--圖片上傳、顯示--%>
                <div style="width: 230px; height: 200px; float: left">
                    <%--<asp:Image ID="Image1" runat="server" onerror="this.onload = null; this.src='images/765-default-avatar.png';" Width="190px" Height="170px" ImageUrl="Handlers/ProfilePhoto.ashx" />--%>
                    <img alt="Responsive image" id="Image1" class="img-thumbnail" src="<%="Handlers/ProfilePhoto.ashx"%>" style="width: 190px; height: 190px" onerror="this.src='images/765-default-avatar.png'" />
                    <div style="height: 0; overflow: hidden">
                        <input type="file" id="FileUpload1" />
                    </div>
                    <button class="btn btn-default" type="button" onclick="chooseFile();" style="width: 92px; height:30px">選擇檔案</button>
                    <input class="btn btn-default" type="button" value="上傳" id="btnupload" style="width: 92px;height:30px" />
                </div>

                <%--非更動區塊--%>
                <div style="width: 345px; height: 245px; float: left">
                    <asp:Panel ID="Panel3" runat="server" Height="245px" Width="390px">
                        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="UnchangeableData" Height="177px" Width="391px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="0px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                            <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                            <Fields>
                                <asp:BoundField DataField="Ptt_Name" HeaderText="姓名：" SortExpression="Ptt_Name" />
                                <asp:BoundField DataField="Ptt_Sex" HeaderText="性別：" SortExpression="Ptt_Sex" />
                                <asp:TemplateField HeaderText="生日：" SortExpression="Ptt_BD">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Ptt_BD") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <InsertItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Ptt_BD") %>'></asp:TextBox>
                                    </InsertItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Ptt_BD", "{0:d}") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Ptt_PID" HeaderText="身份證字號：" SortExpression="Ptt_PID" />
                            </Fields>
                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        </asp:DetailsView>
                        <%--<button type="button" class="btn btn-danger btn-lg btn-block">修改密碼</button>--%>
                    <div class="row text-center">           
            <a href="#" class="btn btn-lg btn-primary" data-toggle="modal" data-target="#largeModal">修改密碼</a>
        </div>

                        <div class="modal fade" id="largeModal" tabindex="-1" role="dialog" aria-labelledby="largeModal" aria-hidden="true">
      <div class="modal-dialog modal-lg">
        <div class="modal-content">
          <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
           <%-- <h3>修改密碼</h3>--%>
          </div>
          <div class="modal-body">
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtoldpwd"></asp:RequiredFieldValidator>
              <label for="txtoldpwd" class="control-label" >輸入舊密碼：</label>
              <asp:TextBox ID="txtoldpwd" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
              
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtnewpwd"></asp:RequiredFieldValidator>
             <label for="txtnewpwd" class="control-label">輸入新密碼：</label>
              <asp:TextBox ID="txtnewpwd" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
               
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3"  runat="server" ErrorMessage="*" ControlToValidate="txtconfirmpwd"></asp:RequiredFieldValidator>
             <label for="txtconfirmpwd" class="control-label">確認新密碼：</label>
              <asp:CompareValidator ID="CompareValidator1" runat="server" CssClass="text-danger" ErrorMessage="密碼不符" ControlToCompare="txtnewpwd" ControlToValidate="txtconfirmpwd"></asp:CompareValidator><asp:TextBox ID="txtconfirmpwd" TextMode="Password" runat="server" CssClass="form-control"></asp:TextBox>
               
          </div>
          <div class="modal-footer">
            <asp:Button ID="editpwd" CssClass="btn btn-primary" runat="server" Text="修改" OnClick="editpwd_Click" />            
            <button type="button" class="btn btn-primary" data-dismiss="modal">取消</button>
          </div>
        </div>
      </div>
    </div>



                    </asp:Panel>
                    </div>
            </div>
            <%--上半部結束--%>

           <%--下半部:可更動資料--%>
            <div class="row" style="width: 660px; height: 450px; float: none">
                <asp:Panel ID="Panel1" runat="server" Height="450px" Width="600px">
                    <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="0px" CellPadding="4" DataKeyNames="Ptt_ID" DataSourceID="ChangeableDataSource" ForeColor="Black" GridLines="Horizontal" Height="406px" Width="622px">
                        <EditRowStyle BackColor="White" Font-Bold="True" ForeColor="Black" Width="600px" />
                        <EmptyDataRowStyle ForeColor="Black" />
                        <Fields>
                            <asp:TemplateField HeaderText="電話：" SortExpression="Ptt_TN">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Ptt_TN") %>' Width="300px"></asp:TextBox>
                                </EditItemTemplate>
                                 <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Ptt_TN") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email：" SortExpression="Ptt_Email">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Ptt_Email") %>' Width="300px"></asp:TextBox>
                                </EditItemTemplate>
                                                               <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Ptt_Email") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="地址：" SortExpression="Ptt_Addr">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Ptt_Addr") %>' Width="300px"></asp:TextBox>
                                </EditItemTemplate>                               
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Ptt_Addr") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="檢驗是否提醒：" SortExpression="Ptt_ExamRmd">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Ptt_ExamRmd") %>' />
                                </EditItemTemplate>                             
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Ptt_ExamRmd") %>' Enabled="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="用藥是否提醒：" SortExpression="Ptt_DrugRmd">
                                <EditItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("Ptt_DrugRmd") %>' />
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("Ptt_DrugRmd") %>' Enabled="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Ptt_ID" HeaderText="Ptt_ID" SortExpression="Ptt_ID" InsertVisible="False" ReadOnly="True" Visible="False" />
                            <asp:TemplateField ShowHeader="False">
                                <EditItemTemplate>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Cancel" Font-Size="Large" Font-Underline="True" Text="更新" OnClick="LinkButton1_Click" CausesValidation="False"></asp:LinkButton>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                             <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Font-Size="Large" Font-Underline="True" Text="取消"></asp:LinkButton>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Edit" CssClass="Edit" Font-Size="Large" Font-Underline="True" Text="修改"></asp:LinkButton>
                                </ItemTemplate>
                                <HeaderStyle Font-Size="Large" ForeColor="Blue" />
                            </asp:TemplateField>
                        </Fields>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" Width="400px" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    </asp:DetailsView>
                       </asp:Panel>
            </div>
            <%--下半部結束--%>
        </div>
    </div>
    <%--顯示邏輯結束--%>

       <%--不可更動的DataSource--%>
                    <asp:SqlDataSource ID="UnchangeableData" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT [Ptt_Name], [Ptt_PID], [Ptt_Sex],[Ptt_BD] FROM [Patients] WHERE ([Ptt_ID] = @Ptt_ID)">
                        <SelectParameters>
                            <asp:CookieParameter CookieName="PttID" Name="Ptt_ID" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <%--可更動區的DataSource--%>
                    <asp:SqlDataSource ID="ChangeableDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:MedicareConnectionString %>" SelectCommand="SELECT [Ptt_BD], [Ptt_TN], [Ptt_Addr], [Ptt_Email], [Ptt_ExamRmd], [Ptt_DrugRmd], [Ptt_ID] FROM [Patients] WHERE ([Ptt_ID] = @Ptt_ID)"  >
                        <SelectParameters>
                            <%--<asp:CookieParameter CookieName="account" Name="Staff_Acc" Type="String" />--%>
                            <asp:CookieParameter CookieName="PttID" Name="Ptt_ID" Type="Int32" />
                        </SelectParameters>
                        
                    </asp:SqlDataSource>  

    <script>
       

        var files;
        $("#FileUpload1").change(function readURL() {
            //預覽
            var reader = new FileReader();
            reader.readAsDataURL(this.files[0]);
            reader.onload = function (e) {
                $('#Image1').attr('src', e.target.result);
                files = e.target.result;
            }
        })

        function chooseFile() {
            $("#FileUpload1").click();  //代替很醜的fileupload
        }

        $('#btnupload').click(
            function () {
                //寫到資料庫                
                $.post("Handlers/PatientUploadFiles.ashx", { "files": files }, function (data) {
                    alert(data);  //Handler回傳 上傳成功!
                })
            }
            )

        //Example
        //$('#btn2').click(function () {
        //    $.post("UploadFiles.ashx", { "name": "JQ", "age": 35 }, function (data) {
        //        $('div').html("<h1>" + data + "</h1>");
        //    })
        //})
    </script>
</asp:Content>

