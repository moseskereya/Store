<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="ProductDetails.aspx.cs" Inherits="Store.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="Store.Models.Product" SelectMethod ="getProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %></h1>
            </div>
            <br />

            <div class="row">
                <div class="col-sm-6">
                        <img src="<%#:Item.ImagePath %>" class="img-responsive" alt="<%#:Item.ProductName %>"/>
                </div>
                <div class="col-sm-6">
                    <div>
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />
                          <br />  <br />
                          <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Product Number:</b>&nbsp;<%#:Item.ProductID %></span>
                        <p></p>
                        <br/>
                            <a href="Products.aspx">Back</a> | 
                        <a class="btn btn-danger" href="/AddToCart.aspx?productID=<%#:Item.ProductID %>">               
                            <span class="ProductListItem">
                                <b>Add To Cart<b>
                            </span>           
                            </a>
                        </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>