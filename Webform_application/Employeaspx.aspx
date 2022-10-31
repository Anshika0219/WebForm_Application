<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Employeaspx.aspx.cs" Inherits="Employeaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 83px;
        }
        .auto-style2 {
            margin-left: 22px;
        }
        .auto-style3 {
            margin-left: 73px;
        }
        .auto-style4 {
            margin-left: 46px;
        }

        .auto-style6 {
            margin-left: 95px;
        }
        .auto-style7 {
            margin-left: 25px;
        }
        .auto-style8 {
            margin-left: 26px;
        }
        .auto-style9 {
            margin-left: 15px;
        }
        .auto-style10 {
            margin-left: 153px;
        }
        .auto-style12 {
            text-align: center;
        }
        .auto-style13 {
            margin-left: 35px;
        }
        .auto-style14 {
            width: 64px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
           <tr><td>Employe Name<asp:TextBox ID="EmployeName" runat="server" CssClass="auto-style13"></asp:TextBox>
               <br />
               </td> </tr>
           <tr><td>Employe Age<asp:TextBox ID="Employeage" runat="server" CssClass="auto-style4"></asp:TextBox>
               <br />
               </td> </tr>
           <tr><td>EmailId <asp:TextBox ID="emailId" runat="server" CssClass="auto-style1"></asp:TextBox>
               <br />
               </td> </tr>
           <tr><td>Password<asp:TextBox ID="password" runat="server" CssClass="auto-style3"></asp:TextBox>
               <br />
               </td> </tr>
           <tr><td>Contact Number<asp:TextBox ID="contactnumber" runat="server" CssClass="auto-style2"></asp:TextBox>
               <br />
               </td> </tr>
           <tr><td> Sallery<asp:TextBox ID="Sallery" runat="server" CssClass="auto-style6"></asp:TextBox>
               <br />
               </td>
           <td>
               <br />
               <asp:Button ID="Insert" runat="server" Text="Insert" OnClick="Insert_Click" CssClass="auto-style10" Width="82px"/></td>
               <td class="auto-style14">
                   <br />
                   <asp:Button ID="Read" runat="server" Text="Read" OnClick="Read_Click" CssClass="auto-style9" Width="69px" /></td>
               <td>
                   <br />
                   <asp:Button ID="Update" runat="server" Text="update" OnClick="Update_Click" CssClass="auto-style8" Width="73px" /></td>
               <td>
                   <br />
                   <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" CssClass="auto-style7" /></td></tr>
            <tr><td class="auto-style12">
                        <strong>
                        <br />
                        <br />
                        <asp:Label ID="Message" runat="server" Text="Message"></asp:Label>
                        <br />
                        <br />
                        </strong></td></tr>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                   </table>
            </div>
    </form>
</body>
</html>
