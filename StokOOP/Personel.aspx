﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Personel.aspx.cs" Inherits="StokOOP.Personel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>PERSONEL ID</th>
            <th>PERSONEL ADI</th>
            <th>PERSONEL SOYADI</th>
            <th>PERSONEL DEPARTMAN</th>
            <th>PERSONEL MAAŞ</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
            
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("PERSONELID") %></td>
                         <td><%# Eval("PERSONELAD") %></td>
                         <td><%# Eval("PERSONELSOYAD") %></td>
                         <td><%# Eval("PERSONELDEP") %></td>
                         <td><%# Eval("PERSONELMAAS") %></td>
                        <td> <asp:HyperLink NavigateUrl='<%# "~/PersonelSil.aspx?PERSONELID=" + Eval("PERSONELID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                         <td> <asp:HyperLink NavigateUrl='<%# "~/PersonelGuncelle.aspx?PERSONELID=" + Eval("PERSONELID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="PersonelEkle.aspx" class="btn btn-info">Yeni Personel Ekle</a>
</asp:Content>
