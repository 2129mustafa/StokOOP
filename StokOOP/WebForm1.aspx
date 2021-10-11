<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StokOOP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <table class="table table-bordered">
       <tr>
           <th>DEPARTMAN ID</th>
           <th>DEPARTMAN ADI</th>
           <th>SİL</th>
           <th>GÜNCELLE</th>
       </tr>
       <tbody>
           <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
                   <tr>
                       <td><%#Eval("DEPARTMANID")%></td>
                       <td><%#Eval("DEPARTMANAD") %></td>
                       <td> <asp:HyperLink NavigateUrl='<%#"~/DepartmanSil.aspx?DEPARTMANID=" + Eval("DEPARTMANID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink> </td>
                       <td><asp:HyperLink NavigateUrl='<%#"~/DepartmanGuncelle.aspx?DEPARTMANID=" + Eval("DEPARTMANID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                   </tr>
               </ItemTemplate>

           </asp:Repeater>
       </tbody>
   </table>
    <a href="DepartmanEkle.aspx" class="btn btn-info">Yeni Departman Ekle</a>
</asp:Content>
