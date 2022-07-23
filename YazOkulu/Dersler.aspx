<%@ Page Title="" Language="C#" MasterPageFile="~/YazOkuluAnasayfa.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="YazOkulu.Dersler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
   <form runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Ders Seçin"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
       <br />
       <div>
        <asp:Label ID="Label2" runat="server" Text="Ogrenci ID"></asp:Label>
           <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
       </div>
       <br />

       <asp:Button ID="Button1" runat="server" Text="Kayıt Et" CssClass="btn btn-warning" OnClick="Button1_Click1" />
       </form>
</asp:Content>
