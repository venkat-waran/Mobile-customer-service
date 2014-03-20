<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css"">
    .abc: hover 
    {
    	display: block;
    }
    .ab
    {
    	height:14px;
    	width:auto;
    	overflow:hidden;
    	position: absolute;
    	
    }
    .ab:hover
    {
    	height:auto;
    	overflow:visible;
    	position: absolute;
    }
    .abc 
    {
    	display: block;
    }
    
    .dick
    {
    	color:Maroon;
    	text-decoration:none;
    	text-shadow: red;
    	height:20px;
    	width:30px;
    	padding:15px;
    }
    .dick:hover
    {
    	
    	text-decoration:none;
    	text-shadow: red;
    	color:Lime;
    	height:60px;
    	width:50px;
    	background-color:Green;
    	padding:15px;
    	text-decoration:blink;
      }
    </style>
</head>
<body bgcolor="#999999" text="Comp" 
    background="img/Background-homepage-png.png">
    <form id="form1" runat="server">
    <p style="font-weight: 700">
        <asp:Image ID="Image1" runat="server" Height="212px" 
            ImageUrl="~\img\Untitlednokia.png" 
            style="margin-left: 0px" Width="1350px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <div style="height: 68px; position: absolute; top: 239px; left: 550px; width: 548px;">
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
            AutoCompleteType="Email"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Enter Correct password" 
            Visible="False" ForeColor="#0000CC"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Newuser" CausesValidation="False" />
    </div>
    <div style="position: absolute; top: 234px; left: 40px; width: 445px; height: 75px;">
&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        <asp:LinkButton Class="dick" ID="LinkButton1" runat="server" 
            onclick="LinkButton1_Click1">Complaints</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton Class="dick" ID="LinkButton3" runat="server" 
            onclick="LinkButton3_Click">New products</asp:LinkButton>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="login to register complaints" 
            Visible="False"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
</form>
</body>
</html>
