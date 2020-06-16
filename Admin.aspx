<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="final.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>DashBoard</h2>
        <table style="height:400px;">

            <tr>
                <td>
                     <h4>Total Contract Establish Today :</h4>
                     
                </td>
                <td>
                    <h4><asp:Label ID="totalcontract" runat="server"  ></asp:Label></h4>
                </td>
            
            </tr>
            <tr>
                <td>
                    
                    <h4>Total Contract Establish Till Now :</h4>
                   
                </td>
                <td>
                     <h4><asp:Label ID="totalcon" runat="server"  ></asp:Label></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <h4>Total User Loged In Today :</h4>
                </td>
                <td>
                    <h4><asp:Label ID="totallog" runat="server" ></asp:Label></h4>
                </td>
            </tr>
              <tr>
                <td>
                    <h4>Total User Registered Today :</h4>
                </td>
                <td>
                    <h4><asp:Label ID="regtotal" runat="server" ></asp:Label></h4>
                </td>
            </tr>
              <tr>
                <td>
                    <h4>Total User We Have:</h4>
                </td>
                <td>
                    <h4><asp:Label ID="totaluser" runat="server" ></asp:Label></h4>
                </td>
            </tr>
              <tr>
                <td>
                    <h4>Total Models We Have :</h4>
                </td>
                <td>
                    <h4><asp:Label ID="model" runat="server" ></asp:Label></h4>
                </td>
            </tr>
              <tr>
                <td>
                    <h4>Total Photographers We Have :</h4>
                </td>
                <td>
                    <h4><asp:Label ID="photographer" runat="server" ></asp:Label></h4>
                </td>
            </tr>
              <tr>
                <td>
                    <h4>Total Customer We Have :</h4>
                </td>
                <td>
                    <h4><asp:Label ID="customer" runat="server" ></asp:Label></h4>
                </td>
            </tr>
        </table>
   </div>
</asp:Content>
