<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urun.aspx.cs" Inherits="StokOOP.Urun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN ADI</th>
            <th>ÜRÜN FİYATI</th>
            <th>ÜRÜN ADETİ</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("URUNID") %></td>
                         <td><%# Eval("URUNAD") %></td>
                         <td><%# Eval("URUNFIYAT") %></td>
                         <td><%# Eval("URUNADET") %></td>
                        <td><asp:HyperLink NavigateUrl='<%# "~/UrunSil.aspx?URUNID="+Eval("URUNID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink> </td>
                        <td><asp:HyperLink NavigateUrl='<%# "~/UrunGuncelle.aspx?URUNID="+Eval("URUNID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="UrunEkle.aspx" class="btn btn-info">Yeni Ürün Ekle</a>
</asp:Content>
