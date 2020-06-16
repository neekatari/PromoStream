<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="notification.aspx.cs" Inherits="final.notification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/newstyle.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .maincontent{
            margin-left:400px;
            
            padding-bottom:100px;
        }
        .link{
            color:black;
        }
        .link:hover{
            color:orangered;
        }
        .heading{
           margin-left:800px;
           color:orangered;
       }
        
    </style>
    <div style="height:80px;width:100%;"></div>
   
     <div class="maincontent"style="margin-left:254px;padding-top:60px;background-size:cover;height:100%;background-color:antiquewhite;">
         <center>
              <marquee width="55%" direction="left" style="font-size:20px;margin-bottom:50px;" >
Note : Click On User Email To Get User Information.
</marquee>
             <hr style="width:70%; background-color:gray;"  />
                 <h1 class="heading">Notification</h1>
             <hr style="width:70%; background-color:gray;" />
    <div style="margin-top:50px;" >
        <asp:Repeater runat="server" ID="r2" >
            <ItemTemplate>
            <table style="border:1px solid gray; background-color:White; width:900px;font-size:22px;">
                <tr>
                    <td rowspan="2">
                        <asp:Image Height="70" Width="70" BorderWidth="3" BorderColor="OrangeRed" ID="Image1" runat="server" ImageUrl='<%#Eval("image")%>' style="border-radius:100%;"></asp:Image>
                    </td>
                    <td>
                        Email:
                    </td>
                    <td>
                        <asp:LinkButton runat="server"  ID="mail" OnClick="mail_Click" Text='<%# Eval("mail") %>'  CssClass="link" ></asp:LinkButton>
                        <asp:HiddenField ID="hidemail" Value='<%# Eval("mail") %>'  runat="server" />
                        <asp:HiddenField  ID="adid" Value='<%# Eval("adsid") %>' runat="server" />
                        <asp:HiddenField ID="nid" Value='<%# Eval("notid") %>' runat="server" />
                    </td>
                </tr>
                
                <tr>
                    <td>
                        Title:
                    </td>
                    <td>
                        <asp:Label runat="server" ID="title" Text='<%# Eval("post_title") %>'> </asp:Label>
                        
                    </td>
                    
                </tr>
            </table>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater ID="r" runat="server">
            <ItemTemplate>
               <table style="border:1px solid gray; background-color:White; width:900px;font-size:22px;">
                   <tr>
                       <td>
                           
                       </td>
                       <td>
                    <asp:LinkButton runat="server" Text= '<%# "Congratulations Your Contract Has Been Established With "+ Eval("mail") %>' OnClick="m_Click"  ID="m" ></asp:LinkButton>
                   <asp:HiddenField ID="cmail" Value='<%#Eval("mail") %>'  runat="server"  />
                           </td>
                       </tr>
                </table>
            </ItemTemplate>
        </asp:Repeater>

    </div>
             </center>
   </div>
</asp:Content>
