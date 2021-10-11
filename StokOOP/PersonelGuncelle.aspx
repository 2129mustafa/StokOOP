<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelGuncelle.aspx.cs" Inherits="StokOOP.PersonelGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group"> 
        <div>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" placeholder="Personel ID..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Personel Adı..."></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Personel Soyadı..."></asp:TextBox>
        </div>
        <br />
         <div>
             <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" placeholder="Personel Maaşı..."></asp:TextBox>
         </div>
         <br />
        <br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" ></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Personeli Güncelle" CssClass="btn btn-success" OnClick="Button1_Click" />
        </div>
        
    </form>
</asp:Content>
