<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SchowcaseWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 676px">
    <form id="form1" runat="server">
    <div>
        <h2>Дизайнер графических панелей</h2>
        <asp:LinkButton ID="DownloadInstallerLinkButton" runat="server" OnClick="DownloadInstallerLinkButtonClick">Загрузить дистрибутив</asp:LinkButton><br/>
        <h2>Доступно</h2>        
        <asp:Panel ID="ReportLinkPanel" runat="server">
        </asp:Panel>
    </div>
    </form>
</body>
</html>
