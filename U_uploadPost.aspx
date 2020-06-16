<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="U_uploadPost.aspx.cs" Inherits="final.U_uploadPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/newstyle.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .up{
            margin-left:340px;
            height:200px;
            width:40%;
            font-size:20px;
            color:black;
            background-color:white;
            margin-bottom:50px;
        }
        .fileup{
            margin-top:20px;
            margin-left:20px;
            height:40px;
            width:300px;
            font-size:18px;
        }
        .rebtn{
            height:40px;
            width:150px;
            border:none;
            background-color:orangered;
            border-radius:10px;
        }
        .rebtn:hover{
            background-color:white;
            border: 1px solid orangered;
        }
        .txtdesc{
        height:80px;
        width:80%;
        font-size:18px;
        color:gray;
        border:none;
        background-color:antiquewhite;
        border-bottom:1.5px solid orangered;
        }

        .down{
            margin:50px;
        }
        .lbldesc{
            
            font-size:17px;
            

        }
        .editlink{
            margin-left:30px;
            font-size:17px;
            text-decoration:none;
            color:gray;
        }
        .editlink:hover
        {
            color:orangered;
        }
    </style>
    <div style="height:80px;width:100%;"></div>
   <div style="margin-left:254px;padding-top:60px;background-color:antiquewhite;">
                        
     <div style="height:100%;width:70%;background-color:white;margin-top:50px;margin-left:200px;border-radius:50px;">
        <hr style="width:75%;"/>
            <h2 style="text-align:center;">Upload Post</h2>
        <hr style="width:75%"/>
         <div class="up">
             <center>
             <asp:FileUpload CssClass="fileup" ID="FileUpload1" runat="server" />
              <asp:TextBox CssClass="txtdesc" ID="txtdesc" runat="server" TextMode="MultiLine" placeholder=" Descripation"></asp:TextBox>
             <asp:Button CssClass="rebtn" runat="server" ID="upload" Text="Upload" OnClick="upload_Click" />
             </center>
         </div>
         <hr style="width:75%;"/>
            <h2 style="text-align:center;">Your Photos</h2>
        <hr style="width:75%"/>
         <div class="down">
             <asp:Repeater ID="rpost" runat="server">
                 <ItemTemplate>
                     <center>
                     <table>
                         <tr>
                             <td style="width:200px;">
                                  <asp:Image Height="500" Width="500" runat="server" ImageUrl='<%#Eval("post_img")%>' ></asp:Image>
                              </td>
                          </tr>
                         <tr>
                            <td>
                                 <asp:Label runat="server" CssClass="lbldesc" Height="60" Width="400" Text='<%#Eval("post_desc ") %>' ID="desc" ></asp:Label> 
                           
                           
                                <asp:LinkButton CssClass="editlink" ID="edit" runat="server" OnClick="edit_Click"  >Edit Post</asp:LinkButton>
                                 <asp:HiddenField ID="id" runat ="server"  Value='<%#Eval("pid")%>'/>
                             </td>
                          </tr>
                     </table>
                         </center>
                </ItemTemplate>
             </asp:Repeater>
         </div>
    </div>
       </div>
</asp:Content>
