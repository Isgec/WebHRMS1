<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Birthday.aspx.vb" Inherits="Birthday" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-top:0px; margin-left:0px">
<div style="background-image:url(gifs/002.gif);background-position:-22px -2px; height:226px;width:229px; font-family: Verdana;color: #006600; font-size:12px">
	<marquee height="120px" width="229px" behavior="scroll" direction="up" scrollamount="2" scrolldelay="100" style="padding-top:50px" onmouseover="this.stop()" onmouseout="this.start()">
		<ul id="divEmps" runat="server" style="text-align:center;padding-left:0px">
			<li>LALIT GUPTA - 04 May</li>
			<li>Veena Rani</li>
			<li>Akhilesh Mishra</li>
			<li>Vinay Sharma</li>
			<li>Praveen Singh</li>
		</ul>
	</marquee>
</div>
</body>
</html>
