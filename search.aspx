<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="final.search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .link{
            color:dimgray;
            
        }
        .link:hover{
            color:orangered;
        }
    </style>
    <div style="height:80px;width:100%;"></div>
    <div style="margin-left:254px;padding-top:60px;background-size:cover;padding-bottom:50px; background-color:antiquewhite;">
        <center>
            <marquee width="55%" direction="left" style="font-size:20px;margin-bottom:50px;margin-top:30px;" >
                    Note : Click On Email To Get Information About That User
            </marquee>
        <table style="background-color:White; width:900px;border-radius:20px;">
           
               
                    <asp:Repeater ID="ser" runat="server">
                     <ItemTemplate>
                          <tr>
                              <td style="width:100px;">
                                  <asp:Image Height="70" Width="70" BorderWidth="3" BorderColor="OrangeRed" ID="ImageButton1" runat="server" ImageUrl='<%#Eval("image")%>' style="border-radius:100%;margin-left:30px;" ></asp:Image>
                              </td>
                            <td>
                                <asp:Label runat="server" ID="name" Text='<%#Eval("name") %>' style="margin-left:30px;" ></asp:Label>
                            </td>
                              <td>
                                <asp:LinkButton CssClass="link" runat="server" ID="mail" Text='<%#Eval("email") %>' OnClick="mail_Click" ></asp:LinkButton>
                                  <asp:HiddenField runat="server" ID="cmail" Value='<%#Eval("email") %>'/>
                            </td>
                           </tr>
                         
                     </ItemTemplate>
                    </asp:Repeater>
                
            
        </table>
            </center>
    
    </div>
</asp:Content>
