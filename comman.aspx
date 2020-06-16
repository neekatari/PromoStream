<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="comman.aspx.cs" Inherits="final.comman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .cmain{
            
            margin-left:255px;
            background-color:antiquewhite;
        }
      
        .cup{
           
            height:500px;
            width:100%;
            text-align:center;
            
            
        }
        .img{
             
            
            
        }
        .name{
            margin-top:30px;
            text-align:center;
            font-size:30px;
            
        }
        .ucenter{
            font-size:20px;
        }
       .table{
           margin-left:300px;
            width:700px;
            height:400px;
       }
       .udown{
           
           width:80%;
           margin-top:50px;
       }
       .heading{
           margin-left:800px;
           color:orangered;
       }
       .btnallow{
           border:none;
           height:40px;
           width:120px;
           text-align:center;
           color:white;
           background-color:orangered;
           border-radius:10px;
           
       }
       
       
       
       
    </style>
    <div style="height:80px;width:100%;"></div>
    <div class="cmain">
        <center>
        <marquee width="55%" direction="left" style="font-size:20px;margin-bottom:50px;margin-top:30px;" >
                    Note : Click On Allow Button To Establish Your Contract.
                    </marquee>
            </center>
        <div class="cup">
                    
           <div class="img">
               <asp:Image ID="imgcp" BorderColor="orangered" BorderWidth="7" style="border-radius:100%;" runat="server" Height="300" Width="300" />
               
           </div>
            <div class="name">
                <asp:Label ID="Name" runat="server" Text=""></asp:Label>
                <asp:Button ID="btnallow" runat="server" Text="Allow" OnClick="btnallow_Click" CssClass="btnallow" />
            </div>
           
        </div>
            <center>
        <div class="ucenter">
            
            <hr style="width:70%; background-color:gray;"  />
                 <h1 class="heading">Bio</h1>
             <hr style="width:70%; background-color:gray;" />
            <br />
            <table class="table" >
                <tr class="txt">
                    <td > 
                        <asp:Label runat="server" Text="Address" ID="lbladd"  ></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="Add"  ></asp:Label>
                    </td>

                </tr>
                
                <tr class="txt">
                    <td>
                        <asp:Label runat="server" Text="Contact" ID="lblcon" ></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="cont"  ></asp:Label>
                    </td>

                </tr>
                <tr class="txt">
                    <td>
                        <asp:Label runat="server" Text="E-mail" ID="lblmail"  ></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="email"  Enabled="false" ></asp:Label>
                    </td>

                </tr>
                <tr class="txt">
                    <td>
                        <asp:Label runat="server" Text="Gender" ID="lblgen"  ></asp:Label>
                    </td>
                    <td>
                        <asp:label runat="server" ID="gender" ></asp:label>
                    </td>

                </tr>
                <tr class="txt">
                    <td>
                        <asp:Label runat="server" Text="Age" ID="lblage"  ></asp:Label>
                    </td>
                    <td>
                        <asp:label runat="server" ID="age"  ></asp:label>
                    </td>

                </tr>
                <tr class="txt">
                    <td>
                        <asp:Label runat="server" Text="Qualification" ID="lblqua"  ></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="quali"  ></asp:Label>
                    </td>

                </tr>
                <tr class="txt">
                    <td>
                        <asp:Label runat="server" Text="Type" ID="lbltype" Visible="false"  ></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="type"  Visible="false" ></asp:Label>
                    </td>
                </tr>
                <tr class="txt">
                    <td>
                        <asp:Label runat="server" Text="height" ID="lblhei" Visible="false"  ></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="txthei"  Visible="false" ></asp:Label>
                    </td>

                </tr>
            </table>
                
        </div>
            
             <hr style="width:70%; background-color:gray;"  />
                 <h1 class="heading">Photos</h1>
             <hr style="width:70%; background-color:gray;" />  
            
        <div class="udown">
            
            <table>
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
        <center>
    </div>
</asp:Content>
