namespace PSI_WinForms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            panel1 = new Panel();
            CreateClientButton = new Button();
            ClientsDataGrid = new DataGridView();
            Settings = new DataGridViewImageColumn();
            Id = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            ClientName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Patronymic = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ShowClientsButton = new Button();
            ShowServicesButton = new Button();
            GetInvoicesButton = new Button();
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
            panel1.Controls.Add(CreateClientButton);
            panel1.Controls.Add(ClientsDataGrid);
            panel1.Controls.Add(ShowClientsButton);
            panel1.Controls.Add(ShowServicesButton);
            panel1.Controls.Add(GetInvoicesButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 500);
            panel1.TabIndex = 1;
            // 
            // CreateClientButton
            // 
            CreateClientButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateClientButton.Location = new Point(12, 454);
            CreateClientButton.Name = "CreateClientButton";
            CreateClientButton.Size = new Size(161, 34);
            CreateClientButton.TabIndex = 4;
            CreateClientButton.Text = "Добавить клиента";
            CreateClientButton.UseVisualStyleBackColor = true;
            CreateClientButton.Click += CreateClientButton_Click;
            // 
            // ClientsDataGrid
            // 
            ClientsDataGrid.BackgroundColor = SystemColors.MenuBar;
            ClientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientsDataGrid.Columns.AddRange(new DataGridViewColumn[] { Settings, Id, Login, ClientName, Surname, Patronymic, PhoneNumber, Email });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ClientsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            ClientsDataGrid.Location = new Point(12, 183);
            ClientsDataGrid.Name = "ClientsDataGrid";
            ClientsDataGrid.RowTemplate.Height = 25;
            ClientsDataGrid.Size = new Size(776, 240);
            ClientsDataGrid.TabIndex = 3;
            ClientsDataGrid.CellClick += ClientsDataGrid_CellClick;
            // 
            // Settings
            // 
            Settings.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Settings.HeaderText = "Детали";
            Settings.Image = (Image)resources.GetObject("Settings.Image");
            Settings.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Settings.Name = "Settings";
            Settings.Width = 52;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Login
            // 
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Логин";
            Login.Name = "Login";
            Login.Resizable = DataGridViewTriState.True;
            Login.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ClientName
            // 
            ClientName.DataPropertyName = "Name";
            ClientName.HeaderText = "Имя";
            ClientName.Name = "ClientName";
            ClientName.Resizable = DataGridViewTriState.True;
            ClientName.ToolTipText = "Click to go to Clients";
            // 
            // Surname
            // 
            Surname.DataPropertyName = "Surname";
            Surname.HeaderText = "Фамилия";
            Surname.Name = "Surname";
            // 
            // Patronymic
            // 
            Patronymic.DataPropertyName = "Patronymic";
            Patronymic.HeaderText = "Отчество";
            Patronymic.Name = "Patronymic";
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Номер телефона";
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // ShowClientsButton
            // 
            ShowClientsButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ShowClientsButton.Location = new Point(135, 89);
            ShowClientsButton.Name = "ShowClientsButton";
            ShowClientsButton.Size = new Size(129, 50);
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
            // GetInvoicesButton
            // 
            GetInvoicesButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GetInvoicesButton.Location = new Point(0, 89);
            GetInvoicesButton.Name = "GetInvoicesButton";
            GetInvoicesButton.Size = new Size(129, 34);
            GetInvoicesButton.TabIndex = 2;
            GetInvoicesButton.Text = "Счета";
            GetInvoicesButton.UseVisualStyleBackColor = true;
            GetInvoicesButton.Click += getInvoicesButton_Click;
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
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главный экран";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClientsDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private Button ShowClientsButton;
        private Button ShowServicesButton;
        private Button GetInvoicesButton;
        private DataGridView ClientsDataGrid;
        private Button button1;
        private Button CreateClientButton;
        private DataGridViewImageColumn Settings;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Patronymic;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Email;
    }
}