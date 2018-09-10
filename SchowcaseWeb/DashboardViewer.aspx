<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashboardViewer.aspx.cs" Inherits="SchowcaseWeb.DashboardViewer" %>

<%@ Register assembly="DevExpress.Dashboard.v15.2.Web, Version=15.2.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.DashboardWeb" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: auto;
        }
    </style>
</head>
<body style="height: auto; width: auto;">
    <form id="form1" runat="server">
    <div>
    
        <dx:ASPxDashboardViewer ID="MyDashboardViewer" runat="server" OnDashboardLoading="MyDashboardViewer_DashboardLoading" FullscreenMode="True" Height="100%" Width="100%">
        </dx:ASPxDashboardViewer>
    
    </div>
    </form>
</body>
</html>
