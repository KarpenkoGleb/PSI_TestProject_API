namespace PSI_WinForms
{
    partial class MainForm : Form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            InvoicesDataGrid = new DataGridView();
            GetInvoicesButton = new Button();
            ShowClientsButton = new Button();
            ShowServicesButton = new Button();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            LinkToInvoiceDetails = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            ServiceId = new DataGridViewTextBoxColumn();
            ClientId = new DataGridViewTextBoxColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            ClientLogin = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            PayBefore = new DataGridViewTextBoxColumn();
            PaymentDate = new DataGridViewTextBoxColumn();
            ReceiptId = new DataGridViewTextBoxColumn();
            IsPaymentCompleted = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InvoicesDataGrid).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 46, 54);
            panel1.Controls.Add(InvoicesDataGrid);
            panel1.Controls.Add(GetInvoicesButton);
            panel1.Controls.Add(ShowClientsButton);
            panel1.Controls.Add(ShowServicesButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 500);
            panel1.TabIndex = 1;
            // 
            // InvoicesDataGrid
            // 
            InvoicesDataGrid.BackgroundColor = SystemColors.MenuBar;
            InvoicesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoicesDataGrid.Columns.AddRange(new DataGridViewColumn[] { LinkToInvoiceDetails, Id, ServiceId, ClientId, ServiceName, ClientLogin, Amount, CreationDate, PayBefore, PaymentDate, ReceiptId, IsPaymentCompleted });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            InvoicesDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            InvoicesDataGrid.Location = new Point(12, 183);
            InvoicesDataGrid.Name = "InvoicesDataGrid";
            InvoicesDataGrid.RowTemplate.Height = 25;
            InvoicesDataGrid.Size = new Size(776, 240);
            InvoicesDataGrid.TabIndex = 3;
            InvoicesDataGrid.CellContentClick += InvoicesDataGrid_CellContentClick;
            InvoicesDataGrid.CellContentDoubleClick += InvoicesDataGrid_CellContentClick;
            // 
            // GetInvoicesButton
            // 
            GetInvoicesButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GetInvoicesButton.Location = new Point(0, 89);
            GetInvoicesButton.Name = "GetInvoicesButton";
            GetInvoicesButton.Size = new Size(129, 50);
            GetInvoicesButton.TabIndex = 2;
            GetInvoicesButton.Text = "Счета";
            GetInvoicesButton.UseVisualStyleBackColor = true;
            GetInvoicesButton.Click += getInvoicesButton_Click;
            // 
            // ShowClientsButton
            // 
            ShowClientsButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ShowClientsButton.Location = new Point(135, 89);
            ShowClientsButton.Name = "ShowClientsButton";
            ShowClientsButton.Size = new Size(129, 34);
            ShowClientsButton.TabIndex = 2;
            ShowClientsButton.Text = "Клиенты";
            ShowClientsButton.UseVisualStyleBackColor = true;
            ShowClientsButton.Click += ShowClientsButton_Click;
            // 
            // ShowServicesButton
            // 
            ShowServicesButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ShowServicesButton.Location = new Point(270, 89);
            ShowServicesButton.Name = "ShowServicesButton";
            ShowServicesButton.Size = new Size(129, 34);
            ShowServicesButton.TabIndex = 2;
            ShowServicesButton.Text = "Сервисы";
            ShowServicesButton.UseVisualStyleBackColor = true;
            ShowServicesButton.Click += ShowServicesButton_Click;
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
            label1.Text = "Главный экран";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LinkToInvoiceDetails
            // 
            LinkToInvoiceDetails.HeaderText = "";
            LinkToInvoiceDetails.Image = (Image)resources.GetObject("LinkToInvoiceDetails.Image");
            LinkToInvoiceDetails.ImageLayout = DataGridViewImageCellLayout.Zoom;
            LinkToInvoiceDetails.Name = "LinkToInvoiceDetails";
            LinkToInvoiceDetails.Resizable = DataGridViewTriState.True;
            LinkToInvoiceDetails.SortMode = DataGridViewColumnSortMode.Automatic;
            LinkToInvoiceDetails.Width = 40;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "InvoiceId";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // ServiceId
            // 
            ServiceId.DataPropertyName = "ServiceId";
            ServiceId.HeaderText = "ServiceId";
            ServiceId.Name = "ServiceId";
            ServiceId.Visible = false;
            // 
            // ClientId
            // 
            ClientId.DataPropertyName = "ClientId";
            ClientId.HeaderText = "ClientId";
            ClientId.Name = "ClientId";
            ClientId.Visible = false;
            // 
            // ServiceName
            // 
            ServiceName.DataPropertyName = "ServiceName";
            ServiceName.HeaderText = "Сервис";
            ServiceName.Name = "ServiceName";
            ServiceName.Resizable = DataGridViewTriState.True;
            ServiceName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ClientLogin
            // 
            ClientLogin.DataPropertyName = "ClientLogin";
            ClientLogin.HeaderText = "Клиент";
            ClientLogin.Name = "ClientLogin";
            ClientLogin.Resizable = DataGridViewTriState.True;
            ClientLogin.ToolTipText = "Click to go to Clients";
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Сумма";
            Amount.Name = "Amount";
            // 
            // CreationDate
            // 
            CreationDate.DataPropertyName = "CreationDate";
            CreationDate.HeaderText = "Дата выставления";
            CreationDate.Name = "CreationDate";
            // 
            // PayBefore
            // 
            PayBefore.DataPropertyName = "PayBefore";
            PayBefore.HeaderText = "Оплатить до";
            PayBefore.Name = "PayBefore";
            // 
            // PaymentDate
            // 
            PaymentDate.DataPropertyName = "PaymentDate";
            PaymentDate.HeaderText = "Дата оплаты";
            PaymentDate.Name = "PaymentDate";
            // 
            // ReceiptId
            // 
            ReceiptId.DataPropertyName = "ReceiptId";
            ReceiptId.HeaderText = "Номер квитанции";
            ReceiptId.Name = "ReceiptId";
            // 
            // IsPaymentCompleted
            // 
            IsPaymentCompleted.DataPropertyName = "IsPaymentCompleted";
            IsPaymentCompleted.HeaderText = "Статус оплаты";
            IsPaymentCompleted.Name = "IsPaymentCompleted";
            IsPaymentCompleted.Resizable = DataGridViewTriState.True;
            IsPaymentCompleted.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главный экран";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InvoicesDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Button GetInvoicesButton;
        private DataGridView InvoicesDataGrid;
        private Button button1;
        private Button ShowServicesButton;
        private Button ShowClientsButton;
        private DataGridViewImageColumn LinkToInvoiceDetails;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ServiceId;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn ClientLogin;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewTextBoxColumn PayBefore;
        private DataGridViewTextBoxColumn PaymentDate;
        private DataGridViewTextBoxColumn ReceiptId;
        private DataGridViewCheckBoxColumn IsPaymentCompleted;
    }
}