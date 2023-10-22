namespace PSI_TestProject_WinForms
{
    partial class ClientsForm : Form
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
            ClientsDataGrid = new DataGridView();
            ClientLogin = new DataGridViewLinkColumn();
            BackToInvoices = new Button();
            GetClientsButton = new Button();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientsDataGrid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 46, 54);
            panel1.Controls.Add(ClientsDataGrid);
            panel1.Controls.Add(BackToInvoices);
            panel1.Controls.Add(GetClientsButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // ClientsDataGrid
            // 
            ClientsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            ClientsDataGrid.BackgroundColor = SystemColors.MenuBar;
            ClientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientsDataGrid.Columns.AddRange(new DataGridViewColumn[] { ClientLogin });
            ClientsDataGrid.Location = new Point(38, 126);
            ClientsDataGrid.Name = "ClientsDataGrid";
            ClientsDataGrid.RowTemplate.Height = 25;
            ClientsDataGrid.Size = new Size(720, 220);
            ClientsDataGrid.TabIndex = 3;
            ClientsDataGrid.CellContentClick += ClientsDataGrid_CellContentClick;
            // 
            // ClientLogin
            // 
            ClientLogin.DataPropertyName = "ClientLogin";
            ClientLogin.HeaderText = "ClientLogin";
            ClientLogin.LinkBehavior = LinkBehavior.HoverUnderline;
            ClientLogin.Name = "ClientLogin";
            ClientLogin.Resizable = DataGridViewTriState.True;
            ClientLogin.SortMode = DataGridViewColumnSortMode.Automatic;
            ClientLogin.Text = "AppearanceText";
            ClientLogin.ToolTipText = "Click to go to Clients";
            ClientLogin.Width = 93;
            // 
            // BackToInvoices
            // 
            BackToInvoices.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackToInvoices.Location = new Point(38, 382);
            BackToInvoices.Name = "BackToInvoices";
            BackToInvoices.Size = new Size(129, 34);
            BackToInvoices.TabIndex = 2;
            BackToInvoices.Text = "Back to invoices";
            BackToInvoices.UseVisualStyleBackColor = true;
            BackToInvoices.Click += BackToInvoices_Click;
            // 
            // GetClientsButton
            // 
            GetClientsButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GetClientsButton.Location = new Point(316, 382);
            GetClientsButton.Name = "GetClientsButton";
            GetClientsButton.Size = new Size(157, 34);
            GetClientsButton.TabIndex = 2;
            GetClientsButton.Text = "Get clients";
            GetClientsButton.UseVisualStyleBackColor = true;
            GetClientsButton.Click += GetClientsButton_Click;
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
            label1.Text = "Клиенты";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientsForm";
            Load += ClientsForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClientsDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView ClientsDataGrid;
        private DataGridViewLinkColumn ClientLogin;
        private Button GetClientsButton;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Button BackToInvoices;
    }
}