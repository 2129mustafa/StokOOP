<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="DepartmanGuncelle.aspx.cs" Inherits="StokOOP.DepartmanGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" class="form-group">  
        <div>
            
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Departman ID" Enabled="False"></asp:TextBox>
        </div>
        <br />
         <div>
             <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Departman AD"></asp:TextBox>
         </div>
         <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Departman Güncelle" CssClass="btn btn-success" OnClick="Button1_Click"/>
        </div>    
    </form>

</asp:Content>
