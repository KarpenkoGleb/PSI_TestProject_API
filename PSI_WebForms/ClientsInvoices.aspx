<%@ Page Async="true"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="ClientsInvoices.aspx.cs" Inherits="PSI_WebForms.ClientsInvoices" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%--Title="Ваши данные"--%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2>Ваши данные</h2>
        <div>
            &nbsp;
        </div>
        <h5>Доброго пожаловать, </h5>
        <div>
            <asp:TextBox ID="ClientNameTextBox" runat="server" Enabled ="false"> </asp:TextBox>
            <asp:TextBox ID="ClientSurnameTextBox" runat="server" Enabled ="false"> </asp:TextBox>
            <asp:TextBox ID="ClientPatronymicTextBox" runat="server" Enabled ="false"> </asp:TextBox>
        </div>
        <div>
            &nbsp;
        </div>
        <h5>Фильтры</h5>
        <div class="row">
            <div class="col-md-2">
                <div class="form-group">
                    <label for="ServiceNameLabel">Услуга</label>
                    <asp:TextBox ID="ServiceFilter1" runat="server" CssClass="form-control"/> 
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="LoginLabel">Логин</label>
                    <asp:TextBox ID="LoginFilter" runat="server" CssClass="form-control"/> 
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="IsPaymentCompletedLabel">Оплачено</label>
                    <asp:DropDownList ID="ddlIsPaymentCompletedFilter" runat="server" CssClass="form-control"> 
                        <asp:ListItem Text="Не выбрано" Value=null> </asp:ListItem> 
                        <asp:ListItem Text="Оплачено" Value=true> </asp:ListItem> 
                        <asp:ListItem Text="Не оплачено" Value=fasle> </asp:ListItem> 
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="CreationDateLabel">Дата создания счета</label>
                    <asp:TextBox ID="txtCreationDateFilter" runat="server" CssClass="form-control"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="calCreationDateExtender" runat="server" TargetControlID="txtCreationDateFilter"></ajaxToolkit:CalendarExtender>
                </div>
            </div>
            <div class="col-md-2">
                <div class="form-group">
                    <label for="PaymentDateLabel">Дата оплаты</label>
                    <asp:TextBox ID="PaymentDateFilter" runat="server" CssClass="form-control"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="calPaymentDateExtender" runat="server" TargetControlID="PaymentDateFilter"></ajaxToolkit:CalendarExtender>
                </div>
            </div>
        </div>
        <div>
            &nbsp;
        </div>
        <div>
            <asp:Button ID="FilterButton" runat="server" OnClick = "FilterButton_Click" Text = "Применить фильтры"/>
        </div>
        <div>
            &nbsp;
        </div> 
        <h5>Данные по вашим счетам</h5>
        <asp:GridView ID="InvoicesGridView" runat="server" OnRowCommand="GridView_RowCommand" DataKeyNames="Id" AutoGenerateColumns="false" 
                    CssClass="table table-striped table-bordered">
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
        <div>
            &nbsp;
        </div>
        <div>
            <asp:Button ID="RefreshButton" runat="server" OnClick = "RefreshButton_Click" Text = "Обновить"/>
        </div>
    </main>
</asp:Content>
