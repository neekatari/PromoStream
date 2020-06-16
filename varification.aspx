s<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="varification.aspx.cs" Inherits="final.varification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Verification</title>

    <link rel="stylesheet" href="css/newstyle.css"/>
    
</head>
<body style="background-image:url('../images/otp.jpg')" >
        
         <div class="main" >
                    <h2>Verification With OTP</h2>
                    <hr />
        <form runat="server">
        <asp:Table runat="server" Width="634px">
                    <asp:TableRow runat="server" >
                        <asp:TableCell runat="server" >
                            <asp:TextBox CssClass="txtotp" ID="txtotp" runat="server" placeholder="Enter OTP" Height="40px" Width="200px"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow CssClass="">
                        <asp:TableCell runat="server">
                            <asp:Button runat="server" ID="btnsub" Text="Submit" CssClass="otpbutton" OnClick="btnsub_Click" Height="40px"  Width="200px" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="Label1" ForeColor="White" runat="server" Text=""></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="Label2" ForeColor="White" runat="server" Text=""></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
        </asp:Table>
            </form>
        </div>  
           
 
</body>
</html>
