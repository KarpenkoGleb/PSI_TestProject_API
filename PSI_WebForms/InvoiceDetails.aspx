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
        
        <%--<form id="myForm" runat="server" class="container">--%>
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="ServiceNameTextBox">Услуга</label>
                        <asp:TextBox ID="ServiceNameTextBox" runat="server" CssClass="form-control" Enabled ="false"/> 
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="AmountTextBox">Сумма к оплате</label>
                        <asp:TextBox ID="AmountTextBox" runat="server" CssClass="form-control" Enabled ="false"/> 
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="CreationDateTextBox">Дата выставления</label>
                        <asp:TextBox ID="CreationDateTextBox" runat="server" CssClass="form-control" Enabled ="false"/> 
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label for="PayBeforeTextBox">Оплатить до</label>
                        <asp:TextBox ID="PayBeforeTextBox" runat="server" CssClass="form-control" Enabled ="false"/> 
                    </div>
                </div>
            </div>     
            <div class="row">
                <div class="col-md-6">
                     <div class="form-group">
                         <label for="ReceiptIdTextBox">Номер квитанции об оплате</label>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:TextBox ID="ReceiptIdTextBox" runat="server" CssClass="form-control" OnTextChanged="ReceiptIdTextBox_TextChanged" AutoPostBack="true"/> 
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ReceiptIdTextBox" EventName="TextChanged" />
                                </Triggers>
                            </asp:UpdatePanel>
                     </div>
                </div>
            </div>           
        
            <div>
                &nbsp;
            </div>

            
            <div class="row">
                <div class="col-md-6">
                    <div>
                        <asp:Button ID="PayButton" runat="server" OnClick = "PayButton_Click" Text = "Оплатить" style="color: white;"/>
                    </div>
                </div>
                <div class="col-md-6">
                    <div>
                        <asp:Button ID="BackToInvoicesListButton" runat="server" OnClick = "BackToInvoicesListButton_Click" Text = "Вернуться к списку счетов" />
                    </div>
                </div>
            </div>    
        <%--</form>--%>
    </main>
</asp:Content>
