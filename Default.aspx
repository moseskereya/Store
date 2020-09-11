<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Store._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card">
        <h1 class="Display-4 text-center" style="margin-bottom: 30px">Store</h1>
        <p class="lead">This is an online store to buy the suff you was looking for</p>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <img src="Content/images/myimg.jpg" class="img-reponsive img-thumbnail" alt="img" />
        </div>
        <div class="col-sm-4">
            <img src="Content/images/img2.jpg" class="img-responsive img-thumbnail" alt="img" />
        </div>
        <div class="col-sm-4">
            <img src="Content/images/img1.jpg" class="img-reponsive img-thumbnail" alt="img" />
        </div>
    </div> 
</asp:Content>
