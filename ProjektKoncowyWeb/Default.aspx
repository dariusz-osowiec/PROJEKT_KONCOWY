<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjektKoncowyWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="bazaPomiarow" DataKeyNames="ID">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="I" HeaderText="I" 
                SortExpression="I" />
            <asp:BoundField DataField="U" HeaderText="U" SortExpression="U" />
            <asp:BoundField DataField="DataPomiaru" HeaderText="DataPomiaru" 
                SortExpression="DataPomiaru" />
            <asp:BoundField DataField="Symulator" HeaderText="Symulator" 
                SortExpression="Symulator" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="bazaPomiarow" runat="server" 
        ConnectionString="<%$ ConnectionStrings:SkladPomiarowConnectionString %>" 
        SelectCommand="SELECT * FROM [Pomiary]">
    </asp:SqlDataSource>
    </form>
</body>
</html>
