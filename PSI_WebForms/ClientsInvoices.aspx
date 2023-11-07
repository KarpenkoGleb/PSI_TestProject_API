<%@ Page Async="true" Title="Ваши данные" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientsInvoices.aspx.cs" Inherits="PSI_WebForms.ClientsInvoices" EnableEventValidation="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <div>
            &nbsp;
        </div>
        <h3>Данные по вашим счетам</h3>
        <div>
            &nbsp;
        </div>
        <div>
            <asp:TextBox ID="ClientNameTextBox" Label = "Имя" runat="server"> </asp:TextBox>
            <asp:TextBox ID="ClientSurnameTextBox" Label = "Фамилия" runat="server"> </asp:TextBox>
            <asp:TextBox ID="ClientPatronymicTextBox" runat="server"> </asp:TextBox>
        </div>
        <div>
            &nbsp;
        </div>
        <asp:GridView ID="InvoicesGridView" runat="server" OnRowCommand="GridView_RowCommand" DataKeyNames="Id" AutoGenerateColumns="false" CssClass="table table-striped table-bordered">
           <Columns>           
               <asp:ButtonField Text="Детали счета" CommandName="ViewDetails" ButtonType="Button" />
               <asp:BoundField DataField="Id" HeaderText="Id счета" Visible = "false"/>
               <asp:BoundField DataField="Service.Service" HeaderText="Сервис" />
               <asp:BoundField DataField="Client.Login" HeaderText="Логин клиента" />
               <asp:BoundField DataField="Amount" HeaderText="Сумма" />
               <asp:BoundField DataField="CreationDate" HeaderText="Дата создания счета" />
               <asp:BoundField DataField="PayBefore" HeaderText="Оплатить до" />
               <asp:BoundField DataField="PaymentDate" HeaderText="Дата оплаты" />
               <asp:BoundField DataField="receiptId" HeaderText="Квитанция (N)" />
               <asp:BoundField DataField="IsPaymentCompleted" HeaderText="Оплачено" />
           </Columns>
        </asp:GridView>
    </main>
</asp:Content>
