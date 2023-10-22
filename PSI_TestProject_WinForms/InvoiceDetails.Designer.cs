namespace PSI_TestProject_WinForms
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
            panel1 = new Panel();
            ClientsList = new ComboBox();
            ClientOfInvoice = new Label();
            ClientLogin = new Label();
            textBox1 = new TextBox();
            GetInvoicesButton = new Button();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 46, 54);
            panel1.Controls.Add(ClientsList);
            panel1.Controls.Add(ClientOfInvoice);
            panel1.Controls.Add(ClientLogin);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(GetInvoicesButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // ClientsList
            // 
            ClientsList.DisplayMember = "Name";
            ClientsList.FormattingEnabled = true;
            ClientsList.Location = new Point(511, 161);
            ClientsList.Name = "ClientsList";
            ClientsList.Size = new Size(121, 23);
            ClientsList.TabIndex = 5;
            ClientsList.ValueMember = "Id";
            // 
            // ClientOfInvoice
            // 
            ClientOfInvoice.AutoSize = true;
            ClientOfInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientOfInvoice.ForeColor = SystemColors.ButtonFace;
            ClientOfInvoice.Location = new Point(511, 134);
            ClientOfInvoice.Name = "ClientOfInvoice";
            ClientOfInvoice.Size = new Size(67, 21);
            ClientOfInvoice.TabIndex = 4;
            ClientOfInvoice.Text = "Клиент";
            // 
            // ClientLogin
            // 
            ClientLogin.AutoSize = true;
            ClientLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ClientLogin.ForeColor = SystemColors.ButtonFace;
            ClientLogin.Location = new Point(73, 134);
            ClientLogin.Name = "ClientLogin";
            ClientLogin.Size = new Size(127, 21);
            ClientLogin.TabIndex = 4;
            ClientLogin.Text = "Логин клиента";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 3;
            // 
            // GetInvoicesButton
            // 
            GetInvoicesButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GetInvoicesButton.Location = new Point(318, 391);
            GetInvoicesButton.Name = "GetInvoicesButton";
            GetInvoicesButton.Size = new Size(129, 34);
            GetInvoicesButton.TabIndex = 2;
            GetInvoicesButton.Text = "Get invoices";
            GetInvoicesButton.UseVisualStyleBackColor = true;
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
            label1.Text = "Детали счетов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InvoiceDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "InvoiceDetails";
            Text = "InvoiceDetails";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button GetInvoicesButton;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Label ClientLogin;
        private TextBox textBox1;
        private ComboBox ClientsList;
        private Label ClientOfInvoice;
    }
}