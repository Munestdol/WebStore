<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="StoreEverything.Pages.Checkout"
    MasterPageFile="~/Pages/Store.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">

        <div id="checkoutForm" class="checkout" runat="server">
            <h2>Checkout</h2>
            Please enter your details and we will ship your item right now!

        <div id="errors" data-valmsg-summary="true">
            <ul>
                <li style="display:none"></li>
            </ul>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>

            <h3>Customer</h3>
            <div>
                <label for="name">Name:</label>
                <SX:VInput Property="Name" runat="server" />
            </div>

            <h3>Delivery address</h3>
            <div>
                <label for="line1">Address 1:</label>
                <SX:VInput Property="Line1" runat="server" />
            </div>
            <div>
                <label for="line2">Address 2:</label>
                <SX:VInput Property="Line2" runat="server" />
            </div>
            <div>
                <label for="line3">Address 3:</label>
                <SX:VInput Property="Line3" runat="server" />
            </div>
            <div>
                <label for="city">City:</label>
                <SX:VInput Property="City" runat="server" />
            </div>

            <h3>Order details</h3>
            <input type="checkbox" id="giftwrap" name="giftwrap" value="true" />
            Use gift wrapping?
        
        <p class="actionButtons">
            <button class="actionButtons" type="submit">Process order</button>
        </p>
        </div>
        <div id="checkoutMessage" runat="server">
            <h2>Thank!</h2>
            Thank you for choosing our store! We will try to send your order as quickly as possible.  
        </div>
    </div>
</asp:Content>