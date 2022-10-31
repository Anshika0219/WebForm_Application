<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Employeaspx.aspx.cs" Inherits="Employeaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 115px;
        }
        .auto-style2 {
            margin-left: 57px;
        }
        .auto-style3 {
            margin-left: 111px;
        }
        .auto-style4 {
            margin-left: 77px;
        }
        .auto-style5 {
            margin-left: 66px;
        }
        .auto-style6 {
            margin-left: 126px;
        }
        .auto-style7 {
            margin-left: 98px;
        }
        .auto-style8 {
            margin-left: 140px;
        }
        .auto-style9 {
            margin-left: 179px;
        }
        .auto-style10 {
            margin-left: 409px;
        }
        .auto-style11 {
            width: 254px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                     <tr><td>Employe Name<asp:TextBox ID="EmployeName" runat="server" CssClass="auto-style5"></asp:TextBox>
                         <br />
                         </td> </tr>
                     <tr><td>Employe Age<asp:TextBox ID="Employeage" runat="server" CssClass="auto-style4" OnTextChanged="Employeage_TextChanged"></asp:TextBox>
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
                    <br />
                    </td></tr>
               <tr><td><asp:Button ID="Insert" runat="server" Text="Insert" OnClick="Insert_Click" CssClass="auto-style10" Width="98px"/></td>
                   <td class="auto-style11"><asp:Button ID="Read" runat="server" Text="Read" OnClick="Read_Click" CssClass="auto-style9" Width="59px" /></td>
                 <td><asp:Button ID="Update" runat="server" Text="update" OnClick="Update_Click" CssClass="auto-style8" Width="74px" /></td>
                   <td><asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" CssClass="auto-style7" /></td>
               </tr>
                    <tr><td>
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="Message" runat="server" Text="Message"></asp:Label>
                        <br />
                        </td></tr>
                   </table>
            </div>
    </form>
</body>
</html>
