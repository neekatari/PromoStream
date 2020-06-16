<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="stream.aspx.cs" Inherits="final.stream" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/newstyle.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height:1700px;" >
     <style>
        .bid
        {
            height:30px;
            width:100px;
            color:White;
            background-color:orangered;
            border-radius:5px;
            border:none;
            float:right;
            text-align:center;
            
            
           
        }
        .bid:hover
        {
            background-color:orange;
        }
        .con
        {
            text-align:left;
            float:left;
        }
    </style>

   
        <div style="height:80px;width:100%;"></div>
   <div class="maincontent" style="margin-left:254px;padding-top:60px;background-size:cover;height:100%;background-color:antiquewhite;">
   <center>
   <div style="margin-top:50px;font-size:18px;">
    <asp:Repeater runat="server" ID="r1">
        <ItemTemplate>
            <table style="border:1px solid gray; background-color:White; width:900px;text-align:left;">
                 <tr>
                     <td rowspan="3" style="width:100px;">
                        <asp:Image Height="70" Width="70" BorderWidth="3" BorderColor="OrangeRed" ID="Image1" runat="server" ImageUrl='<%#Eval("image")%>' style="border-radius:100%;"></asp:Image>
                    </td>
                    <td colspan="2"style="width:1px;" >
                       Advertiser Name:
                    </td>
                     
                    <td style="color:gray">
                        <asp:Label ID="Label1" Text='<%#Eval("name")%>' runat="server" CssClass="con" />
                    </td>
                     <td rowspan="3" >
                        <asp:LinkButton runat="server" Text="Apply" OnClick="btnads_Click1" ID="btnads" CssClass="bid"></asp:LinkButton>
                        <asp:HiddenField runat="server" ID="adid" Value='<%#Eval("aid")%>' />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" >
                        Title :
                    </td>
                    <td style="color:gray">
                        <asp:Label ID="img" Text='<%#Eval("post_title")%>' runat="server" CssClass="con" />
                    </td>
                </tr>
                <tr>
                    
                    <td colspan="2">
                        Description :
                    </td>
                    <td style="color:gray ;width:300px;"">
                        <asp:Label ID='title' runat="server"  Text='<%#Eval("description")%>' CssClass="con"></asp:Label>
                    </td>
                
                    
                </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
    </div>
    </center>
   </div>
  </div>



</asp:Content>
