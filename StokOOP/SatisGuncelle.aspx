<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisGuncelle.aspx.cs" Inherits="StokOOP.SatisGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">  
        <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="ID..." Enabled="False"></asp:TextBox>
        </div>
        <br />
        <div>  
            <asp:Label ID="Label1" runat="server" Text="ÜRÜN" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="DropDownListUrun" runat="server" CssClass="form-control" ></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="PERSONEL" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="DropDownListPersonel" runat="server" CssClass="form-control" ></asp:DropDownList>
        </div>
        <br />
         <div>
            <asp:Label ID="Label3" runat="server" Text="MÜŞTERİ" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="DropDownListMusteri" runat="server" CssClass="form-control" ></asp:DropDownList>
         </div>
         <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="FİYAT" Font-Bold="true"></asp:Label>
           <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Tutar..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Satış İşlemini Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />
        </div>   
    </form>

</asp:Content>
