<%@ Page Language="C#" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="about" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About Me!</title>
</head>
<body <% Response.Write("bgcolor='" + strColor + "'"); %>>

    <form id="form1" runat="server">
        <div>
            <h1>This is a web page about <% DisplayData("N"); %> </h1>
            <hr />
            <h2>Name: <% DisplayData("N"); %></h2>
            <br />
            <h2>Main Hobby: <% DisplayData("H"); %></h2>
            <br />
            <h2>Life Aspiration: <% DisplayData("A"); %></h2>
            <br />
            <h2>Interesting Website: <% DisplayData("W"); %></h2>
        </div>
    </form>
    <a href="default.html">Home</a>
</body>
</html>
