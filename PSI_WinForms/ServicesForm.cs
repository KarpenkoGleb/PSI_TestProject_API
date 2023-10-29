
using System.Data;
using Newtonsoft.Json;
using PSI_WinForms.DTO;

namespace PSI_WinForms
{
    public partial class ServicesForm
    {
        public ServicesForm()
        {
            InitializeComponent();

            LoadDataOfServicesAsync();
        }


        private void ServicesDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();

            var serviceId = (int)ServicesDataGrid.Rows[e.RowIndex].Cells[2].Value;

            UpdateServiceForm updateServiceForm = new UpdateServiceForm(serviceId);
            updateServiceForm.Show();

        }

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
        private void CreationServiceFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreationServiceForm serviceDetails = new CreationServiceForm();
            serviceDetails.Show();
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

        //============= LoadDataOfServices =================

        private async void LoadDataOfServicesAsync()
        {
            try
            {
                var data = await GetGridDataOfServicesAsync();

                ServicesDataGrid.DataSource = data; // Set the data source after data is retrieved.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<List<ServicesDTO>> GetGridDataOfServicesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync("api/Services"); // Adjust the URL to match your API's endpoint.
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<ServicesDTO>>(content);

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
