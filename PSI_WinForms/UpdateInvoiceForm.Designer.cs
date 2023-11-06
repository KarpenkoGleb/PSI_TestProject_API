namespace PSI_WinForms
{
    partial class UpdateInvoiceForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InvoicesDetails = new Panel();
            IsPaymentCompletedCheckBox = new CheckBox();
            PayBeforePicker = new DateTimePicker();
            CreationDatePicker = new DateTimePicker();
            PaymentDatePicker = new DateTimePicker();
            ClientOfInvoice = new Label();
            ServiceList = new ComboBox();
            ServiceDescrTextBox = new TextBox();
            ReceiptTextBox = new TextBox();
            InvoiceIdTextBox = new TextBox();
            AmountTextBox = new TextBox();
            ClientTextBox = new TextBox();
            PhoneNumTextBox = new TextBox();
            ServiceName = new Label();
            ClientsList = new ComboBox();
            label2 = new Label();
            SurnameTextBox = new TextBox();
            panel1 = new Panel();
            DeleteInvoiceButton = new Button();
            UpdateInvoiceButton = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            EmailTextBox = new TextBox();
            label3 = new Label();
            InvoicesClient = new Label();
            PatronymicTextBox = new TextBox();
            Patronymic = new Label();
            label4 = new Label();
            ReceiptLabel = new Label();
            CreationDateLabel = new Label();
            PaymentDateLabel = new Label();
            ServiceDescrLabel = new Label();
            PayBeforeLabel = new Label();
            AmountLabel = new Label();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            ClientName = new Label();
            Email = new Label();
            Surname = new Label();
            PhoneNumber = new Label();
            InvoicesDetails.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // InvoicesDetails
            // 
            InvoicesDetails.BackColor = Color.FromArgb(38, 46, 54);
            InvoicesDetails.Controls.Add(IsPaymentCompletedCheckBox);
            InvoicesDetails.Controls.Add(PayBeforePicker);
            InvoicesDetails.Controls.Add(CreationDatePicker);
            InvoicesDetails.Controls.Add(PaymentDatePicker);
            InvoicesDetails.Controls.Add(ClientOfInvoice);
            InvoicesDetails.Controls.Add(ServiceList);
            InvoicesDetails.Controls.Add(ServiceDescrTextBox);
            InvoicesDetails.Controls.Add(ReceiptTextBox);
            InvoicesDetails.Controls.Add(InvoiceIdTextBox);
            InvoicesDetails.Controls.Add(AmountTextBox);
            InvoicesDetails.Controls.Add(ClientTextBox);
            InvoicesDetails.Controls.Add(PhoneNumTextBox);
            InvoicesDetails.Controls.Add(ServiceName);
            InvoicesDetails.Controls.Add(ClientsList);
            InvoicesDetails.Controls.Add(label2);
            InvoicesDetails.Controls.Add(SurnameTextBox);
            InvoicesDetails.Controls.Add(panel1);
            InvoicesDetails.Controls.Add(panel3);
            InvoicesDetails.Controls.Add(panel4);
            InvoicesDetails.Controls.Add(EmailTextBox);
            InvoicesDetails.Controls.Add(label3);
            InvoicesDetails.Controls.Add(InvoicesClient);
            InvoicesDetails.Controls.Add(PatronymicTextBox);
            InvoicesDetails.Controls.Add(Patronymic);
            InvoicesDetails.Controls.Add(label4);
            InvoicesDetails.Controls.Add(ReceiptLabel);
            InvoicesDetails.Controls.Add(CreationDateLabel);
            InvoicesDetails.Controls.Add(PaymentDateLabel);
            InvoicesDetails.Controls.Add(ServiceDescrLabel);
            InvoicesDetails.Controls.Add(PayBeforeLabel);
            InvoicesDetails.Controls.Add(AmountLabel);
            InvoicesDetails.Controls.Add(panel2);
            InvoicesDetails.Controls.Add(ClientName);
            InvoicesDetails.Controls.Add(Email);
            InvoicesDetails.Controls.Add(Surname);
            InvoicesDetails.Controls.Add(PhoneNumber);
            InvoicesDetails.Dock = DockStyle.Fill;
            InvoicesDetails.Location = new Point(0, 0);
            InvoicesDetails.Margin = new Padding(0);
            InvoicesDetails.Name = "InvoicesDetails";
            InvoicesDetails.Size = new Size(1134, 599);
            InvoicesDetails.TabIndex = 2;
            InvoicesDetails.MouseDown += InvoicesDetails_MouseDown;
            InvoicesDetails.MouseMove += InvoicesDetails_MouseMove;
            // 
            // IsPaymentCompletedCheckBox
            // 
            IsPaymentCompletedCheckBox.AutoSize = true;
            IsPaymentCompletedCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IsPaymentCompletedCheckBox.ForeColor = SystemColors.ButtonFace;
            IsPaymentCompletedCheckBox.Location = new Point(34, 336);
            IsPaymentCompletedCheckBox.Name = "IsPaymentCompletedCheckBox";
            IsPaymentCompletedCheckBox.Size = new Size(15, 14);
            IsPaymentCompletedCheckBox.TabIndex = 7;
            IsPaymentCompletedCheckBox.UseVisualStyleBackColor = true;
            IsPaymentCompletedCheckBox.Click += IsPaymentCompletedCheckBox_Click;
            // 
            // PayBeforePicker
            // 
            PayBeforePicker.Location = new Point(254, 262);
            PayBeforePicker.Name = "PayBeforePicker";
            PayBeforePicker.Size = new Size(170, 23);
            PayBeforePicker.TabIndex = 3;
            // 
            // CreationDatePicker
            // 
            CreationDatePicker.Enabled = false;
            CreationDatePicker.Location = new Point(254, 184);
            CreationDatePicker.Name = "CreationDatePicker";
            CreationDatePicker.Size = new Size(170, 23);
            CreationDatePicker.TabIndex = 3;
            // 
            // PaymentDatePicker
            // 
            PaymentDatePicker.Checked = false;
            PaymentDatePicker.Location = new Point(254, 334);
            PaymentDatePicker.Name = "PaymentDatePicker";
            PaymentDatePicker.Size = new Size(170, 23);
            PaymentDatePicker.TabIndex = 3;
            // 
            // ClientOfInvoice
            // 
            ClientOfInvoice.AutoSize = true;
            ClientOfInvoice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientOfInvoice.ForeColor = SystemColors.ButtonFace;
            ClientOfInvoice.Location = new Point(546, 157);
            ClientOfInvoice.Name = "ClientOfInvoice";
            ClientOfInvoice.Size = new Size(120, 21);
            ClientOfInvoice.TabIndex = 4;
            ClientOfInvoice.Text = "Логин клиента";
            // 
            // ServiceList
            // 
            ServiceList.DisplayMember = "Service";
            ServiceList.ForeColor = Color.Black;
            ServiceList.FormattingEnabled = true;
            ServiceList.Location = new Point(546, 474);
            ServiceList.Name = "ServiceList";
            ServiceList.Size = new Size(206, 23);
            ServiceList.TabIndex = 5;
            ServiceList.Text = "Выберите сервис";
            ServiceList.ValueMember = "Id";
            ServiceList.SelectedIndexChanged += ServiceList_SelectedIndexChanged;
            ServiceList.DropDownClosed += ServiceList_DropDownClosed;
            ServiceList.Click += ServiceList_Click;
            // 
            // ServiceDescrTextBox
            // 
            ServiceDescrTextBox.Location = new Point(796, 474);
            ServiceDescrTextBox.Name = "ServiceDescrTextBox";
            ServiceDescrTextBox.ReadOnly = true;
            ServiceDescrTextBox.Size = new Size(309, 23);
            ServiceDescrTextBox.TabIndex = 3;
            // 
            // ReceiptTextBox
            // 
            ReceiptTextBox.Location = new Point(34, 265);
            ReceiptTextBox.Name = "ReceiptTextBox";
            ReceiptTextBox.Size = new Size(144, 23);
            ReceiptTextBox.TabIndex = 3;
            ReceiptTextBox.KeyPress += ReceiptTextBox_KeyPress;
            // 
            // InvoiceIdTextBox
            // 
            InvoiceIdTextBox.BackColor = Color.FromArgb(38, 46, 54);
            InvoiceIdTextBox.BorderStyle = BorderStyle.None;
            InvoiceIdTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            InvoiceIdTextBox.ForeColor = SystemColors.ButtonFace;
            InvoiceIdTextBox.Location = new Point(117, 107);
            InvoiceIdTextBox.Name = "InvoiceIdTextBox";
            InvoiceIdTextBox.Size = new Size(144, 26);
            InvoiceIdTextBox.TabIndex = 3;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(34, 184);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.PlaceholderText = "Укажите сумму";
            AmountTextBox.Size = new Size(144, 23);
            AmountTextBox.TabIndex = 3;
            // 
            // ClientTextBox
            // 
            ClientTextBox.Location = new Point(546, 262);
            ClientTextBox.Name = "ClientTextBox";
            ClientTextBox.ReadOnly = true;
            ClientTextBox.Size = new Size(144, 23);
            ClientTextBox.TabIndex = 3;
            // 
            // PhoneNumTextBox
            // 
            PhoneNumTextBox.Location = new Point(749, 184);
            PhoneNumTextBox.Name = "PhoneNumTextBox";
            PhoneNumTextBox.ReadOnly = true;
            PhoneNumTextBox.Size = new Size(144, 23);
            PhoneNumTextBox.TabIndex = 3;
            // 
            // ServiceName
            // 
            ServiceName.AutoSize = true;
            ServiceName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ServiceName.ForeColor = SystemColors.ButtonFace;
            ServiceName.Location = new Point(546, 441);
            ServiceName.Name = "ServiceName";
            ServiceName.Size = new Size(148, 21);
            ServiceName.TabIndex = 4;
            ServiceName.Text = "Название сервиса";
            // 
            // ClientsList
            // 
            ClientsList.DisplayMember = "Login";
            ClientsList.ForeColor = Color.Black;
            ClientsList.FormattingEnabled = true;
            ClientsList.Location = new Point(546, 184);
            ClientsList.Name = "ClientsList";
            ClientsList.Size = new Size(138, 23);
            ClientsList.TabIndex = 5;
            ClientsList.Tag = "";
            ClientsList.Text = "Выберите логин";
            ClientsList.ValueMember = "Id";
            ClientsList.DropDownClosed += ClientsList_DropDownClosed;
            ClientsList.Click += ClientsList_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(546, 385);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 4;
            label2.Text = "Сервис";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(749, 262);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.ReadOnly = true;
            SurnameTextBox.Size = new Size(144, 23);
            SurnameTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 69, 80);
            panel1.Controls.Add(DeleteInvoiceButton);
            panel1.Controls.Add(UpdateInvoiceButton);
            panel1.Location = new Point(0, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 60);
            panel1.TabIndex = 6;
            // 
            // DeleteInvoiceButton
            // 
            DeleteInvoiceButton.BackColor = Color.FromArgb(33, 33, 34);
            DeleteInvoiceButton.BackgroundImageLayout = ImageLayout.None;
            DeleteInvoiceButton.FlatStyle = FlatStyle.Popup;
            DeleteInvoiceButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteInvoiceButton.ForeColor = SystemColors.ControlLight;
            DeleteInvoiceButton.Location = new Point(12, 13);
            DeleteInvoiceButton.Name = "DeleteInvoiceButton";
            DeleteInvoiceButton.Size = new Size(149, 34);
            DeleteInvoiceButton.TabIndex = 8;
            DeleteInvoiceButton.Text = "Удалить счет";
            DeleteInvoiceButton.UseVisualStyleBackColor = false;
            DeleteInvoiceButton.Click += DeleteInvoiceButton_Click;
            // 
            // UpdateInvoiceButton
            // 
            UpdateInvoiceButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateInvoiceButton.Location = new Point(993, 13);
            UpdateInvoiceButton.Name = "UpdateInvoiceButton";
            UpdateInvoiceButton.Size = new Size(129, 34);
            UpdateInvoiceButton.TabIndex = 2;
            UpdateInvoiceButton.Text = "Сохранить";
            UpdateInvoiceButton.UseVisualStyleBackColor = true;
            UpdateInvoiceButton.Click += UpdateInvoiceButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(58, 69, 80);
            panel3.Location = new Point(484, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 450);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(58, 69, 80);
            panel4.Location = new Point(504, 337);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(629, 20);
            panel4.TabIndex = 6;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(958, 184);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.ReadOnly = true;
            EmailTextBox.Size = new Size(144, 23);
            EmailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(34, 108);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 4;
            label3.Text = "Счет №";
            // 
            // InvoicesClient
            // 
            InvoicesClient.AutoSize = true;
            InvoicesClient.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            InvoicesClient.ForeColor = SystemColors.ButtonFace;
            InvoicesClient.Location = new Point(546, 108);
            InvoicesClient.Name = "InvoicesClient";
            InvoicesClient.Size = new Size(79, 25);
            InvoicesClient.TabIndex = 4;
            InvoicesClient.Text = "Клиент";
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Enabled = false;
            PatronymicTextBox.Location = new Point(958, 262);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.ReadOnly = true;
            PatronymicTextBox.Size = new Size(144, 23);
            PatronymicTextBox.TabIndex = 3;
            // 
            // Patronymic
            // 
            Patronymic.AutoSize = true;
            Patronymic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Patronymic.ForeColor = SystemColors.ButtonFace;
            Patronymic.Location = new Point(958, 235);
            Patronymic.Name = "Patronymic";
            Patronymic.Size = new Size(81, 21);
            Patronymic.TabIndex = 4;
            Patronymic.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(34, 307);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 4;
            label4.Text = "Статус счета";
            label4.UseMnemonic = false;
            // 
            // ReceiptLabel
            // 
            ReceiptLabel.AutoSize = true;
            ReceiptLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ReceiptLabel.ForeColor = SystemColors.ButtonFace;
            ReceiptLabel.Location = new Point(34, 238);
            ReceiptLabel.Name = "ReceiptLabel";
            ReceiptLabel.Size = new Size(148, 21);
            ReceiptLabel.TabIndex = 4;
            ReceiptLabel.Text = "Номер квитанции";
            ReceiptLabel.UseMnemonic = false;
            // 
            // CreationDateLabel
            // 
            CreationDateLabel.AutoSize = true;
            CreationDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreationDateLabel.ForeColor = SystemColors.ButtonFace;
            CreationDateLabel.Location = new Point(254, 157);
            CreationDateLabel.Name = "CreationDateLabel";
            CreationDateLabel.Size = new Size(148, 21);
            CreationDateLabel.TabIndex = 4;
            CreationDateLabel.Text = "Дата выставления";
            CreationDateLabel.UseMnemonic = false;
            // 
            // PaymentDateLabel
            // 
            PaymentDateLabel.AutoSize = true;
            PaymentDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentDateLabel.ForeColor = SystemColors.ButtonFace;
            PaymentDateLabel.Location = new Point(254, 307);
            PaymentDateLabel.Name = "PaymentDateLabel";
            PaymentDateLabel.Size = new Size(104, 21);
            PaymentDateLabel.TabIndex = 4;
            PaymentDateLabel.Text = "Дата оплаты";
            PaymentDateLabel.UseMnemonic = false;
            // 
            // ServiceDescrLabel
            // 
            ServiceDescrLabel.AutoSize = true;
            ServiceDescrLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ServiceDescrLabel.ForeColor = SystemColors.ButtonFace;
            ServiceDescrLabel.Location = new Point(796, 441);
            ServiceDescrLabel.Name = "ServiceDescrLabel";
            ServiceDescrLabel.Size = new Size(151, 21);
            ServiceDescrLabel.TabIndex = 4;
            ServiceDescrLabel.Text = "Описание сервиса";
            ServiceDescrLabel.UseMnemonic = false;
            // 
            // PayBeforeLabel
            // 
            PayBeforeLabel.AutoSize = true;
            PayBeforeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PayBeforeLabel.ForeColor = SystemColors.ButtonFace;
            PayBeforeLabel.Location = new Point(254, 235);
            PayBeforeLabel.Name = "PayBeforeLabel";
            PayBeforeLabel.Size = new Size(103, 21);
            PayBeforeLabel.TabIndex = 4;
            PayBeforeLabel.Text = "Оплатить до";
            PayBeforeLabel.UseMnemonic = false;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.ForeColor = SystemColors.ButtonFace;
            AmountLabel.Location = new Point(34, 157);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(105, 21);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Сумма счета";
            AmountLabel.UseMnemonic = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(8, 24, 70);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1134, 90);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = Color.FromArgb(22, 26, 31);
            closeButton.Cursor = Cursors.Hand;
            closeButton.Dock = DockStyle.Right;
            closeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.AppWorkspace;
            closeButton.Location = new Point(1109, 0);
            closeButton.Margin = new Padding(2, 0, 2, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(22, 26, 31);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1134, 90);
            label1.TabIndex = 0;
            label1.Text = "Детали счета";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientName
            // 
            ClientName.AutoSize = true;
            ClientName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientName.ForeColor = SystemColors.ButtonFace;
            ClientName.Location = new Point(546, 235);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(43, 21);
            ClientName.TabIndex = 4;
            ClientName.Text = "Имя";
            ClientName.UseMnemonic = false;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Email.ForeColor = SystemColors.ButtonFace;
            Email.Location = new Point(958, 157);
            Email.Name = "Email";
            Email.Size = new Size(48, 21);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Surname.ForeColor = SystemColors.ButtonFace;
            Surname.Location = new Point(749, 235);
            Surname.Name = "Surname";
            Surname.Size = new Size(80, 21);
            Surname.TabIndex = 4;
            Surname.Text = "Фамилия";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumber.ForeColor = SystemColors.ButtonFace;
            PhoneNumber.Location = new Point(749, 157);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(140, 21);
            PhoneNumber.TabIndex = 4;
            PhoneNumber.Text = "Номер телефона";
            // 
            // UpdateInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 599);
            Controls.Add(InvoicesDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateInvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateInvoiceForm";
            InvoicesDetails.ResumeLayout(false);
            InvoicesDetails.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel InvoicesDetails;
        private Button UpdateInvoiceButton;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Label ClientName;
        private TextBox ClientTextBox;
        private ComboBox ClientsList;
        private Label ClientOfInvoice;
        private Label InvoicesClient;
        private Label label2;
        private Label Patronymic;
        private Label Email;
        private Label Surname;
        private Label PhoneNumber;
        private TextBox PatronymicTextBox;
        private TextBox EmailTextBox;
        private TextBox SurnameTextBox;
        private TextBox PhoneNumTextBox;
        private Label ServiceName;
        private ComboBox ServiceList;
        private Panel panel4;
        private Panel panel1;
        private TextBox ServiceDescrTextBox;
        private Label ServiceDescrLabel;
        private Panel panel3;
        private Label label3;
        private TextBox AmountTextBox;
        private Label AmountLabel;
        private TextBox ReceiptTextBox;
        private Label ReceiptLabel;
        private Label CreationDateLabel;
        private Label PaymentDateLabel;
        private Label PayBeforeLabel;
        private DateTimePicker PaymentDatePicker;
        private DateTimePicker PayBeforePicker;
        private DateTimePicker CreationDatePicker;
        private CheckBox IsPaymentCompletedCheckBox;
        private Label label4;
        private TextBox InvoiceIdTextBox;
        private Button DeleteInvoiceButton;
    }
}