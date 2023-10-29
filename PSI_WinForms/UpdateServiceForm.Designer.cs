namespace PSI_WinForms
{
    partial class UpdateServiceForm : Form
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
            ServiceDetails = new Panel();
            ServiceDescrTextBox = new TextBox();
            ServiceDescrLabel = new Label();
            ServiceTextBox = new TextBox();
            ServiceName = new Label();
            panel1 = new Panel();
            UpdateServiceButton = new Button();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            DeleteServiceButton = new Button();
            ServiceDetails.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ServiceDetails
            // 
            ServiceDetails.BackColor = Color.FromArgb(38, 46, 54);
            ServiceDetails.Controls.Add(ServiceDescrTextBox);
            ServiceDetails.Controls.Add(ServiceDescrLabel);
            ServiceDetails.Controls.Add(ServiceTextBox);
            ServiceDetails.Controls.Add(ServiceName);
            ServiceDetails.Controls.Add(panel1);
            ServiceDetails.Controls.Add(panel2);
            ServiceDetails.Dock = DockStyle.Fill;
            ServiceDetails.Location = new Point(0, 0);
            ServiceDetails.Margin = new Padding(2);
            ServiceDetails.Name = "ServiceDetails";
            ServiceDetails.Size = new Size(800, 350);
            ServiceDetails.TabIndex = 2;
            ServiceDetails.MouseDown += ServiceDetails_MouseDown;
            ServiceDetails.MouseMove += ServiceDetails_MouseMove;
            // 
            // ServiceDescrTextBox
            // 
            ServiceDescrTextBox.Location = new Point(414, 171);
            ServiceDescrTextBox.Name = "ServiceDescrTextBox";
            ServiceDescrTextBox.PlaceholderText = "Укажите описание сервиса";
            ServiceDescrTextBox.Size = new Size(337, 23);
            ServiceDescrTextBox.TabIndex = 10;
            // 
            // ServiceDescrLabel
            // 
            ServiceDescrLabel.AutoSize = true;
            ServiceDescrLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ServiceDescrLabel.ForeColor = SystemColors.ButtonFace;
            ServiceDescrLabel.Location = new Point(414, 137);
            ServiceDescrLabel.Name = "ServiceDescrLabel";
            ServiceDescrLabel.Size = new Size(151, 21);
            ServiceDescrLabel.TabIndex = 11;
            ServiceDescrLabel.Text = "Описание сервиса";
            ServiceDescrLabel.UseMnemonic = false;
            // 
            // ServiceTextBox
            // 
            ServiceTextBox.Location = new Point(41, 171);
            ServiceTextBox.Name = "ServiceTextBox";
            ServiceTextBox.PlaceholderText = "Введите название сервиса";
            ServiceTextBox.Size = new Size(281, 23);
            ServiceTextBox.TabIndex = 7;
            // 
            // ServiceName
            // 
            ServiceName.AutoSize = true;
            ServiceName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ServiceName.ForeColor = SystemColors.ButtonFace;
            ServiceName.Location = new Point(41, 137);
            ServiceName.Name = "ServiceName";
            ServiceName.Size = new Size(148, 21);
            ServiceName.TabIndex = 4;
            ServiceName.Text = "Название сервиса";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 69, 80);
            panel1.Controls.Add(DeleteServiceButton);
            panel1.Controls.Add(UpdateServiceButton);
            panel1.Location = new Point(0, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 6;
            // 
            // UpdateServiceButton
            // 
            UpdateServiceButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateServiceButton.Location = new Point(659, 13);
            UpdateServiceButton.Name = "UpdateServiceButton";
            UpdateServiceButton.Size = new Size(129, 34);
            UpdateServiceButton.TabIndex = 2;
            UpdateServiceButton.Text = "Сохранить";
            UpdateServiceButton.UseVisualStyleBackColor = true;
            UpdateServiceButton.Click += UpdateServiceButton_Click;
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
            label1.Text = "Редактирование данных сервиса";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // DeleteServiceButton
            // 
            DeleteServiceButton.BackColor = Color.FromArgb(33, 33, 34);
            DeleteServiceButton.BackgroundImageLayout = ImageLayout.None;
            DeleteServiceButton.FlatStyle = FlatStyle.Popup;
            DeleteServiceButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteServiceButton.ForeColor = SystemColors.ControlLight;
            DeleteServiceButton.Location = new Point(12, 14);
            DeleteServiceButton.Name = "DeleteServiceButton";
            DeleteServiceButton.Size = new Size(129, 34);
            DeleteServiceButton.TabIndex = 2;
            DeleteServiceButton.Text = "Удалить сервис";
            DeleteServiceButton.UseVisualStyleBackColor = false;
            DeleteServiceButton.Click += DeleteServiceButton_Click;
            // 
            // UpdateServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 350);
            Controls.Add(ServiceDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateServiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceDetails";
            ServiceDetails.ResumeLayout(false);
            ServiceDetails.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ServiceDetails;
        private Button UpdateServiceButton;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Label ServiceName;
        private Panel panel1;
        private TextBox ServiceTextBox;
        private TextBox ServiceDescrTextBox;
        private Label ServiceDescrLabel;
        private Button DeleteServiceButton;
    }
}