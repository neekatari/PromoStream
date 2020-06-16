<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="final.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
           
    <style>
        .pall{
            text-align:center;
            font-size:22px;
            height:300px;
            width:600px;
            

            
        }
        .newupimage {
            margin-top: 0px;
            height: 100%;
            width: 80%;
            margin-left: 100px;
            align-content: center;
            background-size:cover;
            background-repeat:no-repeat;
            background-color:antiquewhite;
            border-radius:20px;
            
            
    
}

        .updatebtn{
            margin-top:20px;
            color:white;
            background-color:orangered;
            border-radius:20px;
            border:none;
            height:40px;
            width:20%;
        }
        .updatebtn:hover{
            color:black;
            background-color:white;
            border: 1px solid orangered;
        }
        .maincontent {
            margin-left: 253px;
            padding-top: 60px;
        }  
          .rebtn{
            height:40px;
            width:150px;
            border:none;
            background-color:orangered;
            border-radius:10px;
            margin-left:80px;
        } 
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
         
    </style>
    
    <div class="upimage">
       
    </div> 
    <center> 
        <div class="maincontent" style="">
        <div class="newupimage" >
           
            <asp:Table runat="server" >
                <asp:TableRow>
                    <asp:TableCell>
            <asp:Image ID="Image1" BorderWidth="7px" BorderColor="orangered" runat="server" Height="300px" Width="300px"  style="margin-top: 108px;border-radius:100%; margin-bottom: 55px" />
                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
            <asp:FileUpload ID="FileUpload1" runat="server" style="margin-bottom: 30px; margin-left:50px;" BorderStyle="None" ForeColor="orangered" BackColor="#cccccc" />
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                    <asp:Button ID="btndis" runat="server" Text="Upload" CssClass="rebtn"  OnClick="btndis_Click" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:table>
            <br />
            <hr / style="width:100%">
            <asp:Label Text="Bio - Information" runat="server" Font-Size="XX-Large" ForeColor="#333333" ></asp:Label>
            <hr / style="width:100%" >
            <br />
            <asp:Table runat="server" BackColor="white" CssClass="pall" GridLines="both" >
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="name" runat="server" Text="Name" ForeColor="Black" Font-Bold="true"  ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblname" runat="server" Visible="false"  ></asp:Label>
                    </asp:TableCell>
                    
                </asp:TableRow>
    
            <asp:TableRow>
                
                    <asp:TableCell>
                        <asp:Label ID="address" runat="server" Text="Address" ForeColor="Black" Font-Bold="true" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lbladdress" runat="server"  Visible="true" ></asp:Label>
                        </asp:TableCell>
                </asp:TableRow>
            <asp:TableRow>
                
                    <asp:TableCell>
                        <asp:Label ID="conta" runat="server" Text="Contact"  ForeColor="Black" Font-Bold="true" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblcontact" runat="server"  Visible="false" ></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                        <asp:TableRow>
                            
                    <asp:TableCell>
                        <asp:Label ID="mail" runat="server" Text="E-mail" ForeColor="Black" Font-Bold="true" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblemail" runat="server"  Visible="false" ></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                        <asp:TableRow>
                            
                    <asp:TableCell>
                        <asp:Label ID="gender" runat="server" Text="Gender" ForeColor="Black" Font-Bold="true" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblgender" runat="server"  Visible="false"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                        <asp:TableRow>
                            
                    <asp:TableCell>
                        <asp:Label ID="age" runat="server" Text="Age" ForeColor="Black" Font-Bold="true" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblage" runat="server"  Visible="false" ></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
              <asp:TableRow>
                  
                    <asp:TableCell>
                        <asp:Label ID="lblqua" runat="server" Text="Qualification" ForeColor="Black" Font-Bold="true" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="lblquali" runat="server"  ></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    
                    <asp:TableCell>
                        <asp:Label ID="lblhei" runat="server" Text="Height" ForeColor="Black" Font-Bold="true" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="height" runat="server"  Visible="false" ></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
                  <asp:TableRow>
                      
                    <asp:TableCell>
                        <asp:Label ID="lblsun" runat="server" Text="Type" ForeColor="Black" Font-Bold="true" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:Label ID="sub" runat="server"  Visible="false" ></asp:Label>
                    </asp:TableCell>
                </asp:TableRow>
             </asp:Table>

            <asp:Button ID="update" Text="Edit Profile" runat="server" CssClass="updatebtn" OnClick="update_Click" />
            <hr / style="width:100%" >
            <h2>Photos</h2>
            <hr / style="width:100%" >

             <table style="margin-top:50px;margin-left:34px;">
                        <tr>
                            <td>
            <asp:Repeater runat="server" ID="rpost">
                <ItemTemplate>
                   
                                <asp:Image BorderWidth="3px" BorderColor="White" runat="server" ID="imgs" ImageUrl='<%#Eval("post_img")%>' Height="300" Width="300" CssClass="imgborder" />
                           
                </ItemTemplate>
            </asp:Repeater>
                                 </td>
                        </tr>
                    </table>

           </div>

        </div>
    </center>
</asp:Content>
