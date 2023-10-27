namespace PSI_WinForms
{
    partial class InvoiceDetails : Form
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
            ClientOfInvoice = new Label();
            ServiceList = new ComboBox();
            ClientTextBox = new TextBox();
            PhoneNumTextBox = new TextBox();
            ServiceName = new Label();
            ClientsList = new ComboBox();
            label2 = new Label();
            SurnameTextBox = new TextBox();
            panel1 = new Panel();
            UpdateInvoiceButton = new Button();
            panel4 = new Panel();
            EmailTextBox = new TextBox();
            InvoicesClient = new Label();
            PatronymicTextBox = new TextBox();
            Patronymic = new Label();
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
            InvoicesDetails.Controls.Add(ClientOfInvoice);
            InvoicesDetails.Controls.Add(ServiceList);
            InvoicesDetails.Controls.Add(ClientTextBox);
            InvoicesDetails.Controls.Add(PhoneNumTextBox);
            InvoicesDetails.Controls.Add(ServiceName);
            InvoicesDetails.Controls.Add(ClientsList);
            InvoicesDetails.Controls.Add(label2);
            InvoicesDetails.Controls.Add(SurnameTextBox);
            InvoicesDetails.Controls.Add(panel1);
            InvoicesDetails.Controls.Add(panel4);
            InvoicesDetails.Controls.Add(EmailTextBox);
            InvoicesDetails.Controls.Add(InvoicesClient);
            InvoicesDetails.Controls.Add(PatronymicTextBox);
            InvoicesDetails.Controls.Add(Patronymic);
            InvoicesDetails.Controls.Add(panel2);
            InvoicesDetails.Controls.Add(ClientName);
            InvoicesDetails.Controls.Add(Email);
            InvoicesDetails.Controls.Add(Surname);
            InvoicesDetails.Controls.Add(PhoneNumber);
            InvoicesDetails.Dock = DockStyle.Fill;
            InvoicesDetails.Location = new Point(0, 0);
            InvoicesDetails.Margin = new Padding(2);
            InvoicesDetails.Name = "InvoicesDetails";
            InvoicesDetails.Size = new Size(800, 600);
            InvoicesDetails.TabIndex = 2;
            InvoicesDetails.MouseDown += InvoicesDetails_MouseDown;
            InvoicesDetails.MouseMove += InvoicesDetails_MouseMove;
            // 
            // ClientOfInvoice
            // 
            ClientOfInvoice.AutoSize = true;
            ClientOfInvoice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientOfInvoice.ForeColor = SystemColors.ButtonFace;
            ClientOfInvoice.Location = new Point(35, 163);
            ClientOfInvoice.Name = "ClientOfInvoice";
            ClientOfInvoice.Size = new Size(120, 21);
            ClientOfInvoice.TabIndex = 4;
            ClientOfInvoice.Text = "Логин клиента";
            // 
            // ServiceList
            // 
            ServiceList.DisplayMember = "Service";
            ServiceList.FormattingEnabled = true;
            ServiceList.Location = new Point(41, 457);
            ServiceList.Name = "ServiceList";
            ServiceList.Size = new Size(245, 23);
            ServiceList.TabIndex = 5;
            ServiceList.ValueMember = "Id";
            // 
            // ClientTextBox
            // 
            ClientTextBox.Location = new Point(35, 268);
            ClientTextBox.Name = "ClientTextBox";
            ClientTextBox.Size = new Size(144, 23);
            ClientTextBox.TabIndex = 3;
            // 
            // PhoneNumTextBox
            // 
            PhoneNumTextBox.Location = new Point(302, 190);
            PhoneNumTextBox.Name = "PhoneNumTextBox";
            PhoneNumTextBox.Size = new Size(144, 23);
            PhoneNumTextBox.TabIndex = 3;
            // 
            // ServiceName
            // 
            ServiceName.AutoSize = true;
            ServiceName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ServiceName.ForeColor = SystemColors.ButtonFace;
            ServiceName.Location = new Point(41, 424);
            ServiceName.Name = "ServiceName";
            ServiceName.Size = new Size(148, 21);
            ServiceName.TabIndex = 4;
            ServiceName.Text = "Название сервиса";
            // 
            // ClientsList
            // 
            ClientsList.DisplayMember = "Login";
            ClientsList.FormattingEnabled = true;
            ClientsList.Location = new Point(35, 190);
            ClientsList.Name = "ClientsList";
            ClientsList.Size = new Size(138, 23);
            ClientsList.TabIndex = 5;
            ClientsList.ValueMember = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(35, 374);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 4;
            label2.Text = "Сервис";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(302, 268);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(144, 23);
            SurnameTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 69, 80);
            panel1.Controls.Add(UpdateInvoiceButton);
            panel1.Location = new Point(0, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 6;
            // 
            // UpdateInvoiceButton
            // 
            UpdateInvoiceButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateInvoiceButton.Location = new Point(659, 13);
            UpdateInvoiceButton.Name = "UpdateInvoiceButton";
            UpdateInvoiceButton.Size = new Size(129, 34);
            UpdateInvoiceButton.TabIndex = 2;
            UpdateInvoiceButton.Text = "Сохранить";
            UpdateInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(58, 69, 80);
            panel4.Location = new Point(3, 327);
            panel4.Name = "panel4";
            panel4.Size = new Size(797, 20);
            panel4.TabIndex = 6;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(564, 190);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(144, 23);
            EmailTextBox.TabIndex = 3;
            // 
            // InvoicesClient
            // 
            InvoicesClient.AutoSize = true;
            InvoicesClient.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            InvoicesClient.ForeColor = SystemColors.ButtonFace;
            InvoicesClient.Location = new Point(28, 114);
            InvoicesClient.Name = "InvoicesClient";
            InvoicesClient.Size = new Size(79, 25);
            InvoicesClient.TabIndex = 4;
            InvoicesClient.Text = "Клиент";
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Location = new Point(564, 268);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(144, 23);
            PatronymicTextBox.TabIndex = 3;
            // 
            // Patronymic
            // 
            Patronymic.AutoSize = true;
            Patronymic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Patronymic.ForeColor = SystemColors.ButtonFace;
            Patronymic.Location = new Point(564, 241);
            Patronymic.Name = "Patronymic";
            Patronymic.Size = new Size(81, 21);
            Patronymic.TabIndex = 4;
            Patronymic.Text = "Отчество";
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
            panel2.Size = new Size(800, 90);
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
            closeButton.Location = new Point(775, 0);
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
            label1.Size = new Size(800, 90);
            label1.TabIndex = 0;
            label1.Text = "Детали счета";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientName
            // 
            ClientName.AutoSize = true;
            ClientName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientName.ForeColor = SystemColors.ButtonFace;
            ClientName.Location = new Point(35, 241);
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
            Email.Location = new Point(564, 163);
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
            Surname.Location = new Point(302, 241);
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
            PhoneNumber.Location = new Point(302, 163);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(140, 21);
            PhoneNumber.TabIndex = 4;
            PhoneNumber.Text = "Номер телефона";
            // 
            // InvoiceDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(InvoicesDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InvoiceDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceDetails";
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
    }
}