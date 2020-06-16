<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cnotification.aspx.cs" Inherits="final.cnotification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
        .maincontent{
            margin-left:400px;
            
            padding-bottom:100px;
        }
        .link{
            color:dimgray;
            
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
        <asp:Repeater ID="r" runat="server">
            <ItemTemplate>
               <table style="border:1px solid gray; background-color:White; width:900px;font-size:22px;color:black;text-align:left;">
                   <tr>
                       <td rowspan="2">
                        <asp:Image Height="70" Width="70" BorderWidth="3" BorderColor="OrangeRed" ID="Image1" runat="server" ImageUrl='<%#Eval("image")%>' style="border-radius:100%;"></asp:Image>
                    </td>
                       <td style="width:150px;">
                           Title :
                       </td>
                       <td style="text-align:left;">
                            <asp:Label runat="server" Text='<%#Eval("title") %>'></asp:Label>
                        </td>
                    </tr>
                   <tr>
                       <td style="width:150px;">
                           Note :
                       </td>
                    <td>
                         <asp:LinkButton CssClass="link" runat="server" Text= '<%# "Congratulations Your Contract Has Been Established With "+ Eval("mail") %>' OnClick="m_Click"  ID="m" ></asp:LinkButton>
                    </td>
                   <asp:HiddenField ID="cmail" Value='<%#Eval("mail") %>'  runat="server"  />
                   </tr>
                </table>
            </ItemTemplate>
        </asp:Repeater>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

    </div>
             </center>
   </div>
</asp:Content>
