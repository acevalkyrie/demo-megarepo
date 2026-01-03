<%@ Page Language="C#" AutoEventWireup="true" CodeFile="colors.aspx.cs" Inherits="colors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Favorite Colors</title>
</head>
<body bgcolor="<% Response.Write(strColor); %>">
    <form id="frmColors" runat="server">
        <div>
            <h2>Click on one of my favorite colors</h2></div>
        <div>
            <asp:Button ID="btnPink" runat="server" Text="Pink" OnClick="btnPink_Click" />
        </div>
        <div>&nbsp;</div>
        <div>
            <asp:Button ID="btnRed" runat="server" Text="Red" OnClick="btnRed_Click" />
        </div>
        <div>&nbsp;</div>
        <div>
            <asp:Button ID="btnBlue" runat="server" Text="Blue" OnClick="btnBlue_Click" />
        </div>
        <div>&nbsp;</div>
        <div>
            <asp:Button ID="btnYellow" runat="server" Text="Yellow" OnClick="btnYellow_Click" />
        </div>
        <div>&nbsp;</div>
        <div>&nbsp;</div>
        <div><h2>Enter your favorite color</h2></div>
        <div>
            <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </div>
        <div>&nbsp;</div>
    </form>
    <a href="default.html">Home</a>
</body>
</html>
