namespace PSI_TestProject_WinForms
{
    partial class RegisterForm
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
            panel1 = new Panel();
            authorisationLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonRegister = new Button();
            userSurnameField = new TextBox();
            passField = new TextBox();
            userNameField = new TextBox();
            loginField = new TextBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 8, 24);
            panel1.Controls.Add(authorisationLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(userSurnameField);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 321);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // authorisationLabel
            // 
            authorisationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            authorisationLabel.AutoSize = true;
            authorisationLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authorisationLabel.ForeColor = SystemColors.AppWorkspace;
            authorisationLabel.Location = new Point(210, 293);
            authorisationLabel.Margin = new Padding(2, 0, 2, 0);
            authorisationLabel.Name = "authorisationLabel";
            authorisationLabel.Size = new Size(109, 19);
            authorisationLabel.TabIndex = 2;
            authorisationLabel.Text = "Авторизоваться";
            authorisationLabel.Click += authorisationLabel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(307, 168);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 21);
            label5.TabIndex = 2;
            label5.Text = "Пароль (Password)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(50, 168);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 2;
            label4.Text = "Логин (Login)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(307, 102);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 2;
            label3.Text = "Фамилия (Surname)";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(50, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 2;
            label2.Text = "Имя (Name)";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(37, 117, 43);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderColor = Color.FromArgb(5, 48, 8);
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 48, 8);
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 61, 7);
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegister.ForeColor = SystemColors.ButtonFace;
            buttonRegister.Location = new Point(153, 244);
            buttonRegister.Margin = new Padding(2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(234, 34);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // userSurnameField
            // 
            userSurnameField.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userSurnameField.Location = new Point(307, 126);
            userSurnameField.Margin = new Padding(2);
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(192, 35);
            userSurnameField.TabIndex = 3;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(307, 196);
            passField.Margin = new Padding(2);
            passField.Name = "passField";
            passField.Size = new Size(192, 35);
            passField.TabIndex = 3;
            passField.UseSystemPasswordChar = true;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userNameField.Location = new Point(50, 126);
            userNameField.Margin = new Padding(2);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(192, 30);
            userNameField.TabIndex = 3;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(50, 196);
            loginField.Margin = new Padding(2);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(192, 30);
            loginField.TabIndex = 3;
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
            panel2.Size = new Size(560, 90);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Dock = DockStyle.Right;
            closeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.AppWorkspace;
            closeButton.Location = new Point(535, 0);
            closeButton.Margin = new Padding(2, 0, 2, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(560, 90);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 321);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRegister;
        private TextBox passField;
        private TextBox loginField;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox userSurnameField;
        private TextBox userNameField;
        private Label authorisationLabel;
    }
}