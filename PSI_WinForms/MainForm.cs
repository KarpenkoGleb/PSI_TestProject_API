
using System.Data;
using Newtonsoft.Json;
using PSI_WinForms.DTO;

namespace PSI_WinForms
{
    public partial class MainForm
    {
        public MainForm()
        {
            InitializeComponent();

            LoadDataOfInvoicesAsync();
        }

        private void InvoicesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Hide();

            var invoiceId = (int)InvoicesDataGrid.Rows[e.RowIndex].Cells[1].Value;

            //int.tryparse

            UpdateInvoiceForm invoiceDetails = new UpdateInvoiceForm(invoiceId);
            invoiceDetails.Show();


        }

        //============= Buttons actions =================

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();    //  this.Close();
        }

        private void getInvoicesButton_Click(object sender, EventArgs e)
        {
            LoadDataOfInvoicesAsync();
        }

        private void ShowClientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }
        private void ShowServicesButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();
        }

        //==============    END     ==================


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://localhost:7168/"); 
        //    // https://localhost:7168/swagger/index.html      https://localhost:7168/api/Services

        //    HttpResponseMessage response = client.GetAsync("api/Services").Result;

        //    var content = await response.Content.ReadAsStringAsync<IEnumerable<ServicesDTO>>().Result;

        //    dataGridView1.DataSource = services;
        //}

        //============= LoadDataOfInvoices =================

        private async void LoadDataOfInvoicesAsync()
        {
            try
            {
                var data = await GetGridDataOfInvoicesAsync();
                var customDataView = data.Select(dto => new InvoicesDTO_GridView
                {
                    Id = dto.Id,
                    ServiceId = dto.ServiceId,
                    ServiceName = dto.Service.Service,
                    ClientLogin = dto.Client.Login,
                    ClientId = dto.ClientId,
                    Amount = dto.Amount,
                    CreationDate = dto.CreationDate,
                    PayBefore = dto.PayBefore,
                    PaymentDate = dto.PaymentDate,
                    receiptId = dto.receiptId,
                    IsPaymentCompleted = dto.IsPaymentCompleted

                }).ToList();

                InvoicesDataGrid.DataSource = customDataView; // Set the data source after data is retrieved.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<List<InvoicesDTO>> GetGridDataOfInvoicesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync("api/Invoices"); // Adjust the URL to match your API's endpoint.
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<InvoicesDTO>>(content);

                    return data;
                }
                else
                {
                    throw new Exception("Failed to retrieve data from the API.");
                }
            }
        }

        //==============    END     ==================

    }
}
