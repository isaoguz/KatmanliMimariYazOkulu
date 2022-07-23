<%@ Page Title="" Language="C#" MasterPageFile="~/YazOkuluAnasayfa.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="YazOkulu.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Ogrenci ID</th>
            <th>Ogrenci Ad</th>
            <th>Ogrenci Soyad</th>
            <th>Ogrenci Numara</th>
            <th>Ogrenci Sifre</th>
            <th>Ogrenci Fotoğraf</th>
            <th>Ogrenci Bakiye</th>
            <th>İşlemler</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ID") %></td>
                        <td><%#Eval("AD") %></td>
                        <td><%#Eval("SOYAD") %></td>
                        <td><%#Eval("NUMARA") %></td>
                        <td><%#Eval("SIFRE") %></td>
                        <td><%#Eval("FOTOGRAF") %></td>
                        <td><%#Eval("BAKIYE") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID=" + Eval("ID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OGRID=" + Eval("ID") %>' CssClass="btn btn-success" runat="server">Guncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
