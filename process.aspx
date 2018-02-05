<%@ Page Language="C#" AutoEventWireup="true" CodeFile="process.aspx.cs" Inherits="process" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 81px;
        }
        .auto-style2 {
            width: 106px;
        }
        .auto-style3 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="115px" />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search for Customer" />
                </td>
            </tr>
        </table>
    
    </div>
&nbsp;<table class="auto-style3">
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td>
                    <asp:GridView ID="GridView2" runat="server" BackColor="#FFFF66" BorderColor="#3333CC" BorderWidth="0px" Font-Bold="True" Font-Italic="True" Font-Overline="False" PageIndex="10" PageSize="5">
                        <AlternatingRowStyle BackColor="#66FFFF" />
                        <HeaderStyle BackColor="#6600FF" />
                        <SelectedRowStyle ForeColor="#FF0066" />
                        <SortedAscendingCellStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 0px" Text="Save" Width="90px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
