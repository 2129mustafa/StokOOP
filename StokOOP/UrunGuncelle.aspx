<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="StokOOP.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
     <form runat="server" class="form-group">  
         <div>
             <asp:Label ID="Label4" runat="server" Text="ÜRÜN ID" Font-Bold="true"></asp:Label>
             <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="ID..." Enabled="False"></asp:TextBox>
         </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="ÜRÜN ADI" Font-Bold="true"></asp:Label>
             <asp:DropDownList ID="DropDownListUrun" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="ÜRÜN FİYATI" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Ürün Fiyatı..."></asp:TextBox>
        </div>
        <br />
         <div>
             <asp:Label ID="Label3" runat="server" Text="ÜRÜN ADETİ" Font-Bold="true"></asp:Label>
             <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Ürün Adeti..."></asp:TextBox>
         </div>
         <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Güncelle" CssClass="btn btn-success" OnClick="Button1_Click"/>
        </div>
        
    </form>
</asp:Content>
