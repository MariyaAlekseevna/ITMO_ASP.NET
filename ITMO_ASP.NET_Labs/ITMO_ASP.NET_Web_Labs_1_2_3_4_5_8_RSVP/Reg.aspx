<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs"
    Inherits="ITMO_ASP.NET_Web_Labs_1_2_3_4_5_8_RSVP.Reg" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Приглашаем на семинар</h1>
            <p></p>
            <asp:ValidationSummary ID="ValidationSummary" runat="server" />
            <div>
                <label>Ваше имя:</label>
                <asp:TextBox ID="name" runat="server">
                </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="name" ErrorMessage="Заполните поле имени"
                    ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
            </div>
            <div>
                <label>Ваш email:</label>
                <asp:TextBox ID="email" runat="server">
                </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="email" ErrorMessage="Заполните поле адреса"
                    ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                    ControlToValidate="email" Display="Dynamic" ErrorMessage="E-mail is not in a valid format"
                    ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                    Адрес введен неверно!!!
                </asp:RegularExpressionValidator>
            </div>
            <div>
                <label>Ваш телефон:</label>
                <asp:TextBox ID="phone" runat="server">
                </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ControlToValidate="phone" ErrorMessage="Заполните поле ввода телефона"
                    ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
            </div>
            <div>
                <label>Вы будете делать доклад?</label>
                <asp:CheckBox ID="CheckBoxYN" runat="server" />
            </div>
            <div>
                Введите название доклада:
                <asp:TextBox ID="TextBoxTitle" runat="server" Width="345px"></asp:TextBox>
            </div>
            <div>
                Введите аннотацию доклада:
                <asp:TextBox ID="TextBoxTextAnnot" runat="server" Width="345px"></asp:TextBox>
            </div>
            <div>Введите название доклада:
                <asp:TextBox ID="TextBoxTitle2" runat="server" Width="345px"></asp:TextBox>
            </div>
            <div>Введите аннотацию доклада:
                <asp:TextBox ID="TextBoxTextAnnot2" runat="server" Width="345px"></asp:TextBox>
            </div>
            <div>
                <button type="submit">
                    Отправить ответ на приглашение RSVP</button>
            </div>
        </div>
    </form>
</body>
</html>
