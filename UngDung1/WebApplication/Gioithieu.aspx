<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gioithieu.aspx.cs" Inherits="WebApplication.Gioithieu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="TenLoai" DataValueField="MaLoai" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:eStore20ConnectionString %>" SelectCommand="SELECT [MaLoai], [TenLoai] FROM [Loai]"></asp:SqlDataSource>

        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="MaHH" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="MaHH" HeaderText="MaHH" InsertVisible="False" ReadOnly="True" SortExpression="MaHH" />
                    <asp:BoundField DataField="TenHH" HeaderText="TenHH" SortExpression="TenHH" />
                    <asp:BoundField DataField="MaLoai" HeaderText="MaLoai" SortExpression="MaLoai" />
                    <asp:BoundField DataField="MoTaDonVi" HeaderText="MoTaDonVi" SortExpression="MoTaDonVi" />
                    <asp:BoundField DataField="DonGia" HeaderText="DonGia" SortExpression="DonGia" />
                    <asp:BoundField DataField="Hinh" HeaderText="Hinh" SortExpression="Hinh" />
                    <asp:BoundField DataField="NgaySX" HeaderText="NgaySX" SortExpression="NgaySX" />
                    <asp:BoundField DataField="GiamGia" HeaderText="GiamGia" SortExpression="GiamGia" />
                    <asp:BoundField DataField="SoLanXem" HeaderText="SoLanXem" SortExpression="SoLanXem" />
                    <asp:BoundField DataField="MoTa" HeaderText="MoTa" SortExpression="MoTa" />
                    <asp:BoundField DataField="MaNCC" HeaderText="MaNCC" SortExpression="MaNCC" />
                    <asp:BoundField DataField="SoLuong" HeaderText="SoLuong" SortExpression="SoLuong" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eStore20ConnectionString %>" SelectCommand="SELECT * FROM [HangHoa]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
