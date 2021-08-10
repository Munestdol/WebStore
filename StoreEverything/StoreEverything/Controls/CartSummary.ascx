<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartSummary.ascx.cs" 
   Inherits="StoreEverything.Controls.CartSummary" %>

<div id="cartSummary">
    <span class="caption">
        <b>In the basket:</b>
        <span id="csQuantity" runat="server"></span> goods,
        <span id="csTotal" runat="server"></span>
    </span>
    <a id="csLink" runat="server">Basket</a>
</div>