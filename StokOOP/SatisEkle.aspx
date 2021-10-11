<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisEkle.aspx.cs" Inherits="StokOOP.SatisEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="form-group">  
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ürün Seçiniz" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="DropDownListUrun" runat="server" CssClass="form-control" ></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Personel Seçiniz" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="DropDownListPersonel" runat="server" CssClass="form-control" ></asp:DropDownList>
        </div>
        <br />
         <div>
             <asp:Label ID="Label3" runat="server" Text="Müşteri Seçiniz" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="DropDownListMusteri" runat="server" CssClass="form-control" ></asp:DropDownList>
         </div>
         <br />
        <div>
           <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Tutar..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Satış İşlemini Kaydet" CssClass="btn-primary" OnClick="Button1_Click"/>
        </div>   
    </form>
</asp:Content>
