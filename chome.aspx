<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="chome.aspx.cs" Inherits="final.chome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
    .main
    {
        height:650px;
        width:65%;
        background-color:White;
        border-radius:20px;
        margin-left:6%;
    }
    h2
    {
        color:orangered;
    }
    .submain
    {
        text-align:center;
    }
    .table
    {
        width:100%;
    }
    
    .maincon
    {
       margin-top:50px;
      
    }
    .txt
    {
        margin-left:125px;
        margin-bottom:20px;
        height:40px;
        width:70%;
        font-size:18px;
        color:gray;
        border:none;
        background-color:antiquewhite;
        border-bottom:1.5px solid orangered;
        
        
    }
    input::-webkit-input-placeholder {
    color: gray !important;
    }

    input:-moz-placeholder { /* Firefox 18- */
    color: gray !important;
    }

    input::-moz-placeholder { /* Firefox 19+ */
    color: gray !important;
    }

    input:-ms-input-placeholder {
    color: gray !important;
    }
    
    
    
    .txt:hover
    {
        
    }
    h3
    {
        margin-top:30px;
        margin-left:125px;
        font-family:Sans-Serif;
    }
    .m
    {
        height:80px;
        font-family:Sans-Serif;
    }
    .select
    {
        height:40px;
        width:70%;
        font-size:18px;
        color:gray;
        border:none;
        background-color:antiquewhite;
        border-bottom:1.5px solid orangered;
    }
    
    .btna
    {
        margin-top:20px;
        margin-left:125px;
        width:70%;
        height:50px;
        background-color:orangered;
        border:none;
        font-size:18px;
        
    }
    .btna:hover
    {
        border-radius:20px;
        color:White;
    }
    
    
    
    
  
  </style>
    <div style="height:80px;width:100%;"></div>
    <div style="margin-left:254px;padding-top:60px;background-size:cover;height:1000px;background-color:antiquewhite;">
    <div class="main">
        <div class="submain">
        <hr  style="width:100%; height:1px; background-color:Gray;" />
            <h2>Add Advertisement</h2>
        <hr style="width:100%; height:1px; background-color:Gray;" />
        </div>
        <div class="maincon">
            <table class="table">
                <tr>
                    <td>
                       <asp:TextBox ID="title" runat="server" placeholder="  Advertisement Title" class="txt" ForeColor="gray"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td>
                       <asp:TextBox TextMode="MultiLine" ID="descri" runat="server" placeholder=" Advertisement Description" class="txt m"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td >
                        <h3>Who can see my post :</h3><br />
                       
                        <asp:DropDownList  CssClass="txt" runat="server" ID="allowuser">
                            <asp:ListItem Text="photographer"></asp:ListItem>
                            <asp:ListItem Text="model"></asp:ListItem>
                            <asp:ListItem Text="both"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table>
            <asp:Button runat="server" ID="a_upload" Text="Post" class="btna" OnClick="a_upload_Click" />
        </div>
        
    </div>
        </div>
</asp:Content>
