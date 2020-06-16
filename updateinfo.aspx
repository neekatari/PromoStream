<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="updateinfo.aspx.cs" Inherits="final.updateinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/newstyle.css" rel="stylesheet" type="text/css"/>
    <style>
        .main{
            margin-top:70px;
            height:800px;
            width:65%;
            background-color:white;
            border-radius:20px;
            margin-left:120px;
            font-size:24px;
            z-index:0;
        }
        .heading{
            margin-left:320px;
            color:orangered;
        }
        .txt{
            margin-top:5px;
            border:none;
            color:gray;
            height:40px;
            width:70%;
            color:dimgray;
            font-size:22px;
            border-bottom:2px solid dimgray;
            
        }
        .txt:hover{
            border-bottom:2px solid orangered;
        }
        .table{
            padding-left:150px;
            width:100%;
        }
        .buttonup{
            margin-top:100px;
            margin-left:320px;
            color:white;
            background-color:orangered;
            border:none;
            border-radius:20px;
            height:40px;
            width:300px;
            font-size:20px;
        }
        .buttonup:hover{
            border: 2px solid orangered;
            background-color:white;
            color:orangered;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="maincontent" style="margin-left:254px;padding-top:60px;background-size:cover; background-attachment:fixed; height:1000px;background-color:antiquewhite;">
        <div class="main" >
             <hr style="width:100%; background-color:gray;"  />
                 <h1 class="heading">Update information</h1>
             <hr style="width:100%; background-color:gray;" />
            <br />
            <table class="table">
               
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Name" ID="lblname" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="name" CssClass="txt"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Address" ID="lbladd" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="Add" CssClass="txt" ></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Contact" ID="lblcon" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="con" CssClass="txt" ></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="E-mail" ID="lblmail" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="email" CssClass="txt" Enabled="false" ></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Gender" ID="lblgen" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="gender" CssClass="txt" ></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Age" ID="lblage" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="age" CssClass="txt" ></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Qualification" ID="lblqua" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="quali" CssClass="txt" ></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Type" ID="lbltype" Visible="false" ></asp:Label>
                    </td>
                    <td>
                        
                        <asp:DropDownList runat="server" ID="sub" Visible="false" CssClass="txt">
                            <asp:ListItem Text="Fashion" Value="fashion"> </asp:ListItem>
                            <asp:ListItem Text="Event" Value="event"> </asp:ListItem>
                            <asp:ListItem Text="Wildlife" Value="wildlife"> </asp:ListItem>
                            <asp:ListItem Text="Sports" Value="sports"> </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="height" ID="lblhei" Visible="false" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txthei" CssClass="txt" Visible="false" ></asp:TextBox>
                    </td>

                </tr>
            </table>
            <asp:Button runat="server"  ID="update" Text="Update Info" OnClick="update_Click" CssClass="buttonup" />

        </div>
        </div>
</asp:Content>