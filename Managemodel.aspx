<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Managemodel.aspx.cs" Inherits="final.Managemodel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
            <h1>Manage Model</h1>
        <hr />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="fid" DataSourceID="SqlDataSource1model" Height="124px" Width="1267px"  >
    <Columns>
        <asp:CommandField ShowEditButton="True" />
        <asp:BoundField DataField="fid" HeaderText="fid" InsertVisible="False" ReadOnly="True" SortExpression="fid" Visible="False" />
        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
        <asp:BoundField DataField="contactno" HeaderText="contactno" SortExpression="contactno" />
        <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
        <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
        <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
        <asp:BoundField DataField="height" HeaderText="height" SortExpression="height" />
        <asp:BoundField DataField="qualification" HeaderText="qualification" SortExpression="qualification" />
        <asp:BoundField DataField="isDeactive" HeaderText="isDeactive" SortExpression="isDeactive" />
        <asp:BoundField DataField="created" HeaderText="created" SortExpression="created" />
        <asp:BoundField DataField="updated" HeaderText="updated" SortExpression="updated" />
    </Columns>
    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FFF1D4" />
    <SortedAscendingHeaderStyle BackColor="#B95C30" />
    <SortedDescendingCellStyle BackColor="#F1E5CE" />
    <SortedDescendingHeaderStyle BackColor="#93451F" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1model" runat="server" ConnectionString="<%$ ConnectionStrings:promostreamConnectionString %>" DeleteCommand="DELETE FROM [tbl_model] WHERE [fid] = @fid" InsertCommand="INSERT INTO [tbl_model] ([name], [email], [contactno], [gender], [address], [age], [height], [qualification], [isDeactive], [created], [updated]) VALUES (@name, @email, @contactno, @gender, @address, @age, @height, @qualification, @isDeactive, @created, @updated)" SelectCommand="SELECT [fid], [name], [email], [contactno], [gender], [address], [age], [height], [qualification], [isDeactive], [created], [updated] FROM [tbl_model]" UpdateCommand="UPDATE [tbl_model] SET [name] = @name, [email] = @email, [contactno] = @contactno, [gender] = @gender, [address] = @address, [age] = @age, [height] = @height, [qualification] = @qualification, [isDeactive] = @isDeactive, [created] = @created, [updated] = @updated WHERE [fid] = @fid">
    <DeleteParameters>
        <asp:Parameter Name="fid" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="name" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="contactno" Type="Int64" />
        <asp:Parameter Name="gender" Type="String" />
        <asp:Parameter Name="address" Type="String" />
        <asp:Parameter Name="age" Type="Int32" />
        <asp:Parameter Name="height" Type="Int32" />
        <asp:Parameter Name="qualification" Type="String" />
        <asp:Parameter Name="isDeactive" Type="String" />
        <asp:Parameter Name="created" Type="DateTime" />
        <asp:Parameter Name="updated" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="name" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="contactno" Type="Int64" />
        <asp:Parameter Name="gender" Type="String" />
        <asp:Parameter Name="address" Type="String" />
        <asp:Parameter Name="age" Type="Int32" />
        <asp:Parameter Name="height" Type="Int32" />
        <asp:Parameter Name="qualification" Type="String" />
        <asp:Parameter Name="isDeactive" Type="String" />
        <asp:Parameter Name="created" Type="DateTime" />
        <asp:Parameter Name="updated" Type="DateTime" />
        <asp:Parameter Name="fid" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>

</asp:Content>
