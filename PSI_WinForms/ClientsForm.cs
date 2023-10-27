using Newtonsoft.Json;
using PSI_WinForms.DTO;

namespace PSI_WinForms
{
    public partial class ClientsForm
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackToInvoices_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void GetClientsButton_Click(object sender, EventArgs e)
        {
            LoadDataOfClientsAsync();
        }

        //==================================================
        //============= LoadDataOfClients =================
        //==================================================

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
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await httpClient.GetAsync("api/Clients"); // Adjust the URL to match your API's endpoint.
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
    }
}
