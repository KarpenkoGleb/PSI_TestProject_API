<%@ Page Async="true" Title="Страница входа" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PSI_WebForms.LoginPage" EnableEventValidation="false"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2> 
        <%-- without EnableEventValidation="false" application falls with exception "System.InvalidOperationException: 'RegisterForEventValidation can only be called during Render();'" --%>
        <div>
            &nbsp;
        </div>
        <h3>Укажите ваш логин, чтобы войти в профиль</h3>
        <div>
            &nbsp;
        </div>
        <div>
            <asp:TextBox ID="LoginTextBox" Label = "Поле для ввода логина" runat="server"> </asp:TextBox>
        </div>
        <div>
            &nbsp;
        </div>
        <div>
            <asp:Button ID="LoginButton" runat="server" OnClick = "LoginButton_Click" Text = "Войти" />
        </div>
        <div>
            &nbsp;
        </div>
    </main>
</asp:Content>
