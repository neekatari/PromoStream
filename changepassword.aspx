<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="changepassword.aspx.cs" Inherits="final.changepassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .mains{
            height:100%;
            width:100%;
            text-align:center;
            font-size:20px;
           
        }
        .submain{
            
            background-color:antiquewhite;
            height:400px;
            width:50%;
            color:dimgray;
            margin-left:200px;
            padding-top:100px;
             border-radius:30px;
            
        }
        .txt{
            height:50px;
            width:500px;
            border:1.5px solid orangered;
            margin-bottom:20px;
            border-radius:10px;
            font-size:20px;

        }
        .btn{
            margin-top:40px;
            border:none;
            background-color:orangered;
            color:white;
            border-radius:10px;
            height:50px;
            width:200px;
             
            font-size:18px;
        }
        .btn:hover{
            border:1.5px solid orangered;
            background-color:white;
            color:orangered;
        }
    </style>
    <div style="height:80px;width:100%;"></div>
    <div class="mains">
        <center>
            
        <div >
            <div style="margin-top:100px;">
            <hr style="width:60%;margin-left:490px;" />
                <h1 style="margin-left:900px;color:orangered;">Change Password</h1>
            <hr style="width:60%;margin-left:490px;"/>
            </div>
            <div class="submain">
            <table>
                <tr>
                    <td>
                        Old Password :
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="old" CssClass="txt" placeholder=" Old Password"  TextMode="Password" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        New Password :
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="newp" CssClass="txt" placeholder=" New Password"  TextMode="Password" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Conform New Password :
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="cnew" CssClass="txt" placeholder=" Confrom New Password"  TextMode="Password" ></asp:TextBox>
                    </td>
                </tr>
               
                       
                    
            </table>
                <asp:Button ID="sub" runat="server" Text="Submite" CssClass="btn" OnClick="sub_Click" ></asp:Button>
                </div>
            </div>
            
        </div>
        </center>
    </div>

</asp:Content>
