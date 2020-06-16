<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="editpost.aspx.cs" Inherits="final.editpost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .img{
            margin-left:100px;
            margin-top:30px;

        }
        .txtdesc{
        
        font-size:18px;
        color:gray;
        border:1.5px solid orangered;
        background-color:antiquewhite;
        
        margin-left:100px;
        }
        .btn{
            border:none;
            font-size:17px;
            height:40px;
            width:100px;
            background-color:orangered;
            color:white;
            border-radius:20px;
        }
        .btn:hover{
            background-color:white;
            color:orangered;
            border: 1.5px solid orangered;
        }

        .btnok{
            margin-left:100px;
        }
        .btncan{
            margin-left:300px;
        }
    </style>

  <div style="height:80px;width:100%;"></div>
    <div style="width:1800px;height:930px;background-color:antiquewhite;padding-top:30px;margin-left:100px;">
        <center>
        <hr style="margin-left:800px;"/>
        <h2 style="margin-left:100px;">Edit Post</h2>
        <hr style="margin-left:800px;"/>
        
            <table>
                <tr>
                    <td>

                        <asp:Image ID="Image1" runat="server" Height="600" Width="600" CssClass="img" ></asp:Image>
                       
                    </td>
                    
                </tr>
           
                <tr>
                    <td>
                        <h3 style="margin-left:100px;margin-top:20px;">Caption :</h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="desc" CssClass="txtdesc" runat="server" TextMode="MultiLine" Height="60" Width="85%" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="done" runat="server" Text="OK" OnClick="done_Click" CssClass="btnok btn"/>
                    
                        <asp:Button ID="cansle" runat="server" Text="Cancel" OnClick="cansle_Click" CssClass="btncan btn" />
                    
                        <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" CssClass="btndel btn" />
                    </td>
                </tr>
                
            </table>
        </center>
    </div>
</asp:Content>
