<%@ Page Async="true" Title="Детали счета" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InvoiceDetails.aspx.cs" Inherits="PSI_WebForms.InvoiceDetails" EnableEventValidation="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <div>
            &nbsp;
        </div>
        <h3>Данные по вашему счету </h3>
        <div>
            &nbsp;
        </div>
        <div>
            <asp:Label ID="ServiceLabel" runat="server" Text ="Услуга"> </asp:Label>
            <asp:TextBox ID="ClientNameTextBox1" runat="server"> </asp:TextBox>
        </div>
        <div>
            <asp:Label ID="AmountLabel" runat="server" Text ="Сумма к оплате"> </asp:Label>
            <asp:TextBox ID="AmountTextBox" runat="server"> </asp:TextBox>
        </div>
        <div>
            <asp:Label ID="CreationDateLabel" runat="server" Text ="Дата выставления"> </asp:Label>
            <asp:TextBox ID="CreationDateTextBox" runat="server"> </asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PayBeforeLabel" runat="server" Text ="Оплатить до"> </asp:Label>
            <asp:TextBox ID="PayBeforeTextBox" runat="server"> </asp:TextBox>
        </div>
        <div>
            <asp:Label ID="ReceiptIdLabel" runat="server" Text ="Номер квитанции об оплате"> </asp:Label>
            <asp:TextBox ID="ReceiptIdTextBox" runat="server"> </asp:TextBox>
        </div>
        <div>
            &nbsp;
        </div>
        <div>
            <asp:Button ID="BackToInvoicesListButton" runat="server" OnClick = "BackToInvoicesListButton_Click" Text = "Вернуться к списку счетов" />
        </div>
    </main>
</asp:Content>
