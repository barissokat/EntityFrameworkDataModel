<%@ Page Title="" Language="C#" MasterPageFile="~/layout/masterpage/Main2.master" AutoEventWireup="true" CodeBehind="Suppliers.aspx.cs" Inherits="EntityFrameworkDataModel.Suppliers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder" runat="server">
    <h2 class="sub-header">Suppliers title</h2>
    <asp:ListView ID="SupplierList" runat="server">
        <LayoutTemplate>
            <div class="table-responsive">
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Supplier Name</th>
                            <th>Desciption</th>
                            <th>Address</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td></td>
                <td><%#Eval("SupplierName") %></td>
                <td><%#Eval("Description") %></td>
                <td><%#Eval("Address") %></td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
