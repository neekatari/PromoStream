<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="reg.aspx.cs" Inherits="final.reg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>
        .main{
            margin-top:50px;
            background-color:white;
            height:900px;
            width:50%;
            margin-left:480px;
            border-radius:50px;
            text-align:center;
        }
        .container{
            margin-left:140px;
            margin-top:50px;
        }
        .signup-content{
            margin-top:50px;
        }
        .form-input,.form-select{
            height:50px;
            margin-bottom:20px;
        }
       

    </style>


    <div class="main">

        <section class="signup">
            <!-- <img src="images/signup-bg.jpg" alt=""> -->
            <div>
                <div class="signup-content">
    <h2>Create Account</h2>
    
        <div  class="container">
                <asp:Table runat="server" Height="485px" Width="634px">
                    <asp:TableRow runat="server" CssClass="form-group" >
                        <asp:TableCell runat="server" >
                            <asp:TextBox CssClass="form-input" ID="txtname" runat="server" placeholder="Your Name" required  Width="490px"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow runat="server">
                        <asp:TableCell runat="server" CssClass="form-group">
                            <asp:TextBox CssClass="form-input" ID="txtmail" runat="server" TextMode="Email" placeholder="E-mail address" required  Width="490px" ></asp:TextBox>
                            <asp:Label runat="server" ID="error" Text="*" ForeColor="Red" Font-Size="X-Large" Visible="false" ></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow runat="server" CssClass="form-group">
                        <asp:TableCell runat="server">
                            <asp:TextBox CssClass="form-input" ID="txtcontact" runat="server"  placeholder="Contact Number" required TextMode="Phone" Width="490px" ></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server" CssClass="form-group" >
                            
                            <asp:TableCell runat="server">
                            <asp:DropDownList runat="server" required ID="GEnder" CssClass="form-select" Width="490px" >
                                <asp:ListItem Text="Male" Value="male"></asp:ListItem>
                                <asp:ListItem Text="Female" Value="female"></asp:ListItem>
                            </asp:DropDownList>
                            </asp:TableCell>
                    </asp:TableRow>
                     <asp:TableRow runat="server" CssClass="form-group" >
                        <asp:TableCell runat="server">
                            <asp:TextBox CssClass="form-input" ID="txtaddress" runat="server" placeholder="Address" required TextMode="MultiLine" Width="490px" ></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    
                    <asp:TableRow runat="server" CssClass="form-group" >
                         <asp:TableCell runat="server">
                             <asp:TextBox CssClass="form-input" ID="txtage" runat="server" TextMode="Number" placeholder="Age" required Width="490px" ></asp:TextBox>
                          </asp:TableCell>
                     </asp:TableRow>
                  
                    <asp:TableRow runat="server" CssClass="form-group" >
                        <asp:TableCell runat="server">
                            <asp:TextBox CssClass="form-input" ID="txtquali" runat="server" placeholder="Qualification" required Width="490px" ></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>  
                    <asp:TableRow CssClass="form-group" >
                        <asp:TableCell runat="server">
                            <asp:DropDownList required Width="490px" CssClass="form-select" runat="server" ID="listcategory" AutoPostBack="true" OnSelectedIndexChanged= "listcategory_SelectedIndexChanged">
                                <asp:ListItem Text="select Category" Value="select"></asp:ListItem>
                                <asp:ListItem Text="Photographer" Value="photographer"></asp:ListItem>
                                <asp:ListItem Text="Fashionblogger" Value="model"></asp:ListItem>
                                <asp:ListItem Text="Customer" Value="customer"></asp:ListItem>
                             </asp:DropDownList>
                        </asp:TableCell>
                      </asp:TableRow>
                      <asp:TableRow runat="server" CssClass="form-group" >
                        <asp:TableCell runat="server">
                           <asp:DropDownList ID="dtype" required CssClass="form-input" Width="490px" runat="server">
                                    <asp:ListItem>Select category</asp:ListItem>
                               </asp:DropDownList>
                        </asp:TableCell>
                      </asp:TableRow> 


                      <asp:TableRow runat="server" CssClass="form-group" >
                       <asp:TableCell runat="server">
                            <asp:TextBox ID="txtheight" required CssClass="form-input" runat="server" placeholder="Height" Visible="false" Width="490px" ></asp:TextBox>
                        </asp:TableCell>
                      </asp:TableRow>

                      <asp:TableRow runat="server" CssClass="form-group" >
                        <asp:TableCell runat="server">
                                <asp:TextBox CssClass="form-input" ID="txtpass" runat="server" placeholder="password" required TextMode="Password" Width="490px" ></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow >
                        <asp:TableCell runat="server">
                            <asp:Button runat="server" ID="btnsub" Text="Submit" CssClass="button" Height="44px" BackColor="OrangeRed" BorderStyle="None" OnClick="btnsub_Click" Font-Size="20px" Width="490px" />
                        </asp:TableCell>
                    </asp:TableRow>


                          
                </asp:Table>
        </div>
    
   
                            </div>
            </div>
        </section>

    </div>
</asp:Content>
