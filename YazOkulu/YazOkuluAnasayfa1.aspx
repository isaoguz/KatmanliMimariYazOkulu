<%@ Page Title="" Language="C#" MasterPageFile="~/YazOkuluAnasayfa.Master" AutoEventWireup="true" CodeBehind="YazOkuluAnasayfa1.aspx.cs" Inherits="YazOkulu.YazOkuluAnasayfa1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">

        <div class="form-group">
            <div>
                <strong>
                <asp:Label for="TxtAd" ID="Label1" runat="server" Text="Öğrenci Adı"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
                <div>
                    <strong>
                <asp:Label for="TxtSoyad" ID="Label2" runat="server" Text="Öğrenci Soyadı"></asp:Label>
                    </strong>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
                   <br />
                <div>
                    <strong>
                <asp:Label for="TxtNumara" ID="Label3" runat="server" Text="Öğrenci Numarası"></asp:Label>
                    </strong>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
                   <br />
                <div>
                    <strong>
                <asp:Label for="TxtSifre" ID="Label4" runat="server" Text="Öğrenci Şifre"></asp:Label>
                    </strong>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
                   <br />
                <div>
                    <strong>
                <asp:Label for="TxtFotograf" ID="Label5" runat="server" Text="Öğrenci Fotoğraf"></asp:Label>
                    </strong>
                <asp:TextBox ID="TxtFotograf" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <asp:Button ID="BtnKaydet" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>

</asp:Content>
