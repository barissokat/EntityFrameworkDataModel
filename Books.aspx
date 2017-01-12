﻿<%@ Page Title="" Language="C#" MasterPageFile="~/layout/masterpage/Main2.master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="EntityFrameworkDataModel.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder" runat="server">
    <h1 class="page-header">Books</h1>
    <div class="row placeholders">
        <asp:Repeater ID="BookList" runat="server">
            <ItemTemplate>
                <div class="col-xs-6 col-sm-3 placeholder">
                    <img src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" width="200" height="200" class="img-responsive" alt="Generic placeholder thumbnail" />
                    <h4><%#Eval("BookName") %></h4>
                    <span class="text-muted"><%#Eval("Price") %><span> TL</span></span>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
