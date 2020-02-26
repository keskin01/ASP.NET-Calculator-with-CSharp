<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HW1_24808869768_WSP.Default" %>

<!DOCTYPE html>
    <script runat="server">

    </script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="width: 150px; height: 237px">
    <form id="form1" runat="server">
            <div><table><tr>
                <td colspan="4" class="calc_td_result">
                    <input type="text" readonly="readonly" runat="server" name="Calculate Result" id="Result" class="calc_result" visible="False" />
                <asp:TextBox ID="txtBox" runat="server" OnTextChanged="txtBox_TextChanged" ReadOnly="True">0</asp:TextBox>
&nbsp;</td>
                        </tr></table></div>
        <p>
            <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click" />
            <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click"/>
            <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click"/>
            <asp:Button ID="btnDiv" runat="server" Text="/" OnClick="btnDiv_Click" />
        </p>
        <p>
            <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click" />
            <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click" />
            <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click" />
            <asp:Button ID="btnMulti" runat="server" OnClick="btnMulti_Click" Text="*" />
        </p>
        <p>
            <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="1" />
            <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click"/>
            <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click" />
            <asp:Button ID="btnSub" runat="server" Text="-" OnClick="btnSub_Click" />
        </p>
        <p>
            <asp:Button ID="btn0" runat="server" Text="0" OnClick="btn0_Click" />
            <asp:Button ID="btnPlus" runat="server" Text="+" OnClick="btnPlus_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="CLC" OnClick="btnCancel_Click" />
            <asp:Button ID="btnEqual" runat="server" Text="=" OnClick="btnEqual_Click" />
        </p>
    </form>
    </body>
</html>
