<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satis.aspx.cs" Inherits="StokOOP.Satis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>SATIŞ ID</th>
            <th>URUN AD</th>
            <th>PERSONEL</th>
            <th>MÜŞTERİ</th>
            <th>TUTAR</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
            
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("SATISID") %></td>
                        <td><%# Eval("URUNAD") %></td>
                        <td><%# Eval("PERSONELAD") %></td>
                        <td><%# Eval("MUSTERIAD") %></td> 
                        <td><%# Eval("FIYAT") %></td>
                        <td><asp:HyperLink NavigateUrl='<%# "~/SatisSil.aspx?SATISID=" + Eval("SATISID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                        <td><asp:HyperLink NavigateUrl='<%# "~/SatisGuncelle.aspx?SATISID=" + Eval("SATISID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
      <a href="SatisEkle.aspx" class="btn btn-info">Yeni Satış Ekle</a>
</asp:Content>
