
using System.Data;
using Newtonsoft.Json;
using PSI_WinForms.DTO;

namespace PSI_WinForms
{
    public partial class ClientsForm
    {
        public ClientsForm()
        {
            InitializeComponent();

            LoadDataOfClientsAsync();
        }

        //private void ClientsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //this.Hide();

        //    var invoiceId = (int)InvoicesDataGrid.Rows[e.RowIndex].Cells[1].Value;

        //    //int.tryparse

        //    InvoiceDetails invoiceDetails = new InvoiceDetails(invoiceId);
        //    invoiceDetails.Show();


        //}

        //============= Buttons actions =================

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();    //  this.Close();
        }

        private void getInvoicesButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.Show();
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

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreationClientForm clientDetails = new CreationClientForm();
            clientDetails.Show();
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

        //============= LoadDataOfClients =================

        private async void LoadDataOfClientsAsync()
        {
            try
            {
                var data = await GetGridDataOfClientsAsync();

                ClientsDataGrid.DataSource = data; // Set the data source after data is retrieved.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<List<ClientsDTO>> GetGridDataOfClientsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync("api/Clients"); // Adjust the URL to match your API's endpoint.
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<ClientsDTO>>(content);

                    return data;
                }
                else
                {
                    throw new Exception("Failed to retrieve data from the API.");
                }
            }
        }

        private void ClientsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();

            var serviceId = (int)ClientsDataGrid.Rows[e.RowIndex].Cells[1].Value;

            UpdateClientForm updateClientForm = new UpdateClientForm(serviceId);
            updateClientForm.Show();

        }

        //==============    END     ==================

    }
}
