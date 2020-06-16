<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="login.aspx.cs" Inherits="final.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #form1{
            height:700px;
            width:100%;
            color:chocolate;

        }
    </style>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title>Login</title>
       
        <link href="css/logstyle.css" rel="stylesheet" type="text/css"/>
</head>
<body>

    <form id="form1">
        <div style="height:600px;width:70%;margin-left:300px;">
        <div class="main">
            <h1>L O G I N</h1>
            <asp:Table runat="server" Height="101px" Width="149px">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" CssClass="txt" id="txtuname" placeholder="Username" required  ></asp:TextBox>
                       </asp:TableCell>
                </asp:TableRow>
                   <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox runat="server" id="txtpass" CssClass="txt" placeholder="Password" required TextMode="Password" ></asp:TextBox>
                       </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblmsg" CssClass="txt" Text="Invalid Login Details" ForeColor="White" Visible="false" ></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server"  >
                    <asp:TableCell runat="server">
                        <asp:Button CssClass="buttonlogin" ID="btnsubmit" runat="server" Text="Login" OnClick="btnsubmit_Click" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
             </div>
            </div>
    </form>

</body>
</html>
</asp:Content>
