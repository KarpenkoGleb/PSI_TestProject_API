namespace PSI_WinForms
{
    partial class UpdateClientForm : Form
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
            ClientDetails = new Panel();
            PatronymicTextBox = new TextBox();
            label5 = new Label();
            SurnameTextBox = new TextBox();
            label4 = new Label();
            EmailTextBox = new TextBox();
            label3 = new Label();
            PhoneNumberTextBox = new TextBox();
            label2 = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            LoginTextBox = new TextBox();
            Login = new Label();
            panel1 = new Panel();
            DeleteClientButton = new Button();
            UpdateClientButton = new Button();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            ClientDetails.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ClientDetails
            // 
            ClientDetails.BackColor = Color.FromArgb(38, 46, 54);
            ClientDetails.Controls.Add(PatronymicTextBox);
            ClientDetails.Controls.Add(label5);
            ClientDetails.Controls.Add(SurnameTextBox);
            ClientDetails.Controls.Add(label4);
            ClientDetails.Controls.Add(EmailTextBox);
            ClientDetails.Controls.Add(label3);
            ClientDetails.Controls.Add(PhoneNumberTextBox);
            ClientDetails.Controls.Add(label2);
            ClientDetails.Controls.Add(NameTextBox);
            ClientDetails.Controls.Add(NameLabel);
            ClientDetails.Controls.Add(LoginTextBox);
            ClientDetails.Controls.Add(Login);
            ClientDetails.Controls.Add(panel1);
            ClientDetails.Controls.Add(panel2);
            ClientDetails.Dock = DockStyle.Fill;
            ClientDetails.Location = new Point(0, 0);
            ClientDetails.Margin = new Padding(2);
            ClientDetails.Name = "ClientDetails";
            ClientDetails.Size = new Size(800, 480);
            ClientDetails.TabIndex = 2;
            ClientDetails.MouseDown += ClientDetails_MouseDown;
            ClientDetails.MouseMove += ClientDetails_MouseMove;
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.Location = new Point(408, 332);
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.PlaceholderText = "Введите отчество клиента";
            PatronymicTextBox.Size = new Size(309, 23);
            PatronymicTextBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(408, 298);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 18;
            label5.Text = "Отчество";
            label5.UseMnemonic = false;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(408, 251);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.PlaceholderText = "Введите фамилию клиента";
            SurnameTextBox.Size = new Size(309, 23);
            SurnameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(408, 217);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 19;
            label4.Text = "Фамилия";
            label4.UseMnemonic = false;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(41, 332);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Введите email клиента";
            EmailTextBox.Size = new Size(285, 23);
            EmailTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(41, 298);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(41, 251);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.PlaceholderText = "Введите логин клиента";
            PhoneNumberTextBox.Size = new Size(285, 23);
            PhoneNumberTextBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(41, 217);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 13;
            label2.Text = "Номер телефона";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(408, 171);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Введите имя клиента";
            NameTextBox.Size = new Size(309, 23);
            NameTextBox.TabIndex = 10;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.ForeColor = SystemColors.ButtonFace;
            NameLabel.Location = new Point(408, 137);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(43, 21);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Имя";
            NameLabel.UseMnemonic = false;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(41, 171);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Введите логин клиента";
            LoginTextBox.Size = new Size(281, 23);
            LoginTextBox.TabIndex = 7;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = SystemColors.ButtonFace;
            Login.Location = new Point(41, 137);
            Login.Name = "Login";
            Login.Size = new Size(120, 21);
            Login.TabIndex = 4;
            Login.Text = "Логин клиента";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 69, 80);
            panel1.Controls.Add(DeleteClientButton);
            panel1.Controls.Add(UpdateClientButton);
            panel1.Location = new Point(0, 420);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 6;
            // 
            // DeleteClientButton
            // 
            DeleteClientButton.BackColor = Color.FromArgb(33, 33, 34);
            DeleteClientButton.BackgroundImageLayout = ImageLayout.None;
            DeleteClientButton.FlatStyle = FlatStyle.Popup;
            DeleteClientButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteClientButton.ForeColor = SystemColors.ControlLight;
            DeleteClientButton.Location = new Point(12, 14);
            DeleteClientButton.Name = "DeleteClientButton";
            DeleteClientButton.Size = new Size(149, 34);
            DeleteClientButton.TabIndex = 2;
            DeleteClientButton.Text = "Удалить клиента";
            DeleteClientButton.UseVisualStyleBackColor = false;
            DeleteClientButton.Click += DeleteClientButton_Click;
            // 
            // UpdateClientButton
            // 
            UpdateClientButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateClientButton.Location = new Point(659, 13);
            UpdateClientButton.Name = "UpdateClientButton";
            UpdateClientButton.Size = new Size(129, 34);
            UpdateClientButton.TabIndex = 2;
            UpdateClientButton.Text = "Сохранить";
            UpdateClientButton.UseVisualStyleBackColor = true;
            UpdateClientButton.Click += UpdateClientButton_Click;
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
            label1.Text = "Редактирование данных клиента";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // UpdateClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(ClientDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceDetails";
            ClientDetails.ResumeLayout(false);
            ClientDetails.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ClientDetails;
        private Button UpdateClientButton;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Label Login;
        private Panel panel1;
        private TextBox LoginTextBox;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Button DeleteClientButton;
        private TextBox PatronymicTextBox;
        private Label label5;
        private TextBox SurnameTextBox;
        private Label label4;
        private TextBox EmailTextBox;
        private Label label3;
        private TextBox PhoneNumberTextBox;
        private Label label2;
    }
}