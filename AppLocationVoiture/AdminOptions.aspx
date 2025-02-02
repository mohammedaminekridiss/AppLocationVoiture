<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminOptions.aspx.cs" Inherits="AppLocationVoiture.AdminOptions" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Gérer les Options</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Gérer les Options</h2>

            <!-- Formulaire Ajouter une Option -->
            <asp:TextBox ID="txtLibelle" runat="server" placeholder="Libelle"></asp:TextBox>
            <asp:TextBox ID="txtDescription" runat="server" placeholder="Description"></asp:TextBox>
            <asp:TextBox ID="txtPrixTTC" runat="server" placeholder="Prix TTC"></asp:TextBox>
            <asp:Button ID="btnAddOption" runat="server" Text="Ajouter Option" OnClick="btnAddOption_Click" />

            <hr />

            <!-- Grille des Options -->
            <asp:GridView ID="gvOptions" runat="server" AutoGenerateColumns="False" OnRowEditing="gvOptions_RowEditing" DataKeyNames="IdOption" OnRowDeleting="gvOptions_RowDeleting" OnRowUpdating="gvOptions_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="IdOption" HeaderText="ID" SortExpression="IdOption" />
                    <asp:BoundField DataField="Libelle" HeaderText="Libelle" SortExpression="Libelle" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="PrixTTC" HeaderText="Prix TTC" SortExpression="PrixTTC" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
