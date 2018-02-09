<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GroceryApp.aspx.vb" Inherits="GroceryApp.GroceryApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:GridView ID="gridView" runat="server"></asp:GridView>
        <h3>Modify Record</h3>

        Record ID :<asp:TextBox ID="recorIdTxt" runat="server"></asp:TextBox>
        <br />
        Record Name<asp:TextBox ID="RecordNameTxt" runat="server"></asp:TextBox>
        <br />
        Record Count: <asp:TextBox ID="RecordCountTxt" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="createRecord" runat="server" Text="Create" />
        <br /><br />
        <asp:Button ID="EditRecord" runat="server" Text="Edit" />
        <br /><br />
        <asp:Button ID="DeleteRecord" runat="server" Text="Delete" />
    </form>
</body>
</html>
