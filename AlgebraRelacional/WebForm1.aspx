<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="AlgebraRelacional.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultas Unarias</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Button Text="Consulta 1 (Selección)" runat="server" ID="btnConsulta1" OnClick="btnConsulta1_Click" />
                <asp:Button Text="Consulta 2 (Proyección)" runat="server" ID="btnConsulta2" OnClick="btnConsulta2_Click" />
                <asp:Button Text="Consulta 3 (Renombramiento)" runat="server" ID="btnConsulta3" OnClick="btnConsulta3_Click" />
            </p>
            <p>
                <asp:Button Text="Consulta 4 (Selección)" runat="server" ID="btnConsulta4" OnClick="btnConsulta4_Click" />
                <asp:Button Text="Consulta 5 (Proyección)" runat="server" ID="btnConsulta5" OnClick="btnConsulta5_Click" />
                <asp:Button Text="Consulta 6 (Renombramiento)" runat="server" ID="btnConsulta6" OnClick="btnConsulta6_Click" />
            </p>
            <p>
                <asp:Button Text="Consulta 7 (Selección)" runat="server" ID="btnConsulta7" OnClick="btnConsulta7_Click" />
                <asp:Button Text="Consulta 8 (Proyección)" runat="server" ID="btnConsulta8" OnClick="btnConsulta8_Click" />
                <asp:Button Text="Consulta 9 (Renombramiento)" runat="server" ID="btnConsulta9" OnClick="btnConsulta9_Click" />
            </p>
            <p>
    <asp:Button Text="Consulta 10 (Unión)" runat="server" ID="btnConsulta10" OnClick="btnConsulta10_Click" />
    <asp:Button Text="Consulta 11 (Unión)" runat="server" ID="btnConsulta11" OnClick="btnConsulta11_Click" />
    <asp:Button Text="Consulta 12 (Unión)" runat="server" ID="btnConsulta12" OnClick="btnConsulta12_Click" />
</p>
<p>
    <asp:Button Text="Consulta 13 (Diferencia)" runat="server" ID="btnConsulta13" OnClick="btnConsulta13_Click" />
    <asp:Button Text="Consulta 14 (Diferencia)" runat="server" ID="btnConsulta14" OnClick="btnConsulta14_Click" />
    <asp:Button Text="Consulta 15 (Diferencia)" runat="server" ID="btnConsulta15" OnClick="btnConsulta15_Click" />
</p>
<p>
    <asp:Button Text="Consulta 16 (Producto Cartesiano)" runat="server" ID="btnConsulta16" OnClick="btnConsulta16_Click" />
    <asp:Button Text="Consulta 17 (Producto Cartesiano)" runat="server" ID="btnConsulta17" OnClick="btnConsulta17_Click" />
    <asp:Button Text="Consulta 18 (Producto Cartesiano)" runat="server" ID="btnConsulta18" OnClick="btnConsulta18_Click" />
                <asp:GridView runat="server" ID="gvConsulta" AutoGenerateColumns="true" Height="245px" Width="296px"></asp:GridView>
</p>
        </div>
    </form>
</body>
</html>
