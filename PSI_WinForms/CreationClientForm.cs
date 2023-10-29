using Newtonsoft.Json;
using PSI_WinForms.DTO;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PSI_WinForms
{
    public partial class CreationClientForm : Form
    {
        public CreationClientForm()
        {
            InitializeComponent();
        }

        private async void LoadDataOfClientByAsync(int ClientId)
        {
            try
            {
                var data = await GetDataOfClientByIdAsync(ClientId);

                LoginTextBox.Text = data?.Login; // Set the data source after data is retrieved.

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private async Task<ClientsDTO> GetDataOfClientByIdAsync(int ClientId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync(string.Format("api/Clients/{0}", ClientId)); // Adjust the URL to match your API's endpoint.
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<ClientsDTO>(content);

                    return data;
                }
                else
                {
                    throw new Exception("Failed to retrieve data from the API.");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ClientsForm ClientsForm = new ClientsForm();
            ClientsForm.Show();
        }




        //============= Buttons actions =================

        private void UpdateInvoiceButton_Click(object sender, EventArgs e)
        {
            ClientsDTO newClient = new ClientsDTO();

            newClient.Id = 0;
            newClient.Login = LoginTextBox.Text;
            newClient.Name = NameTextBox.Text;
            newClient.PhoneNumber = PhoneNumberTextBox.Text;
            newClient.Surname = SurnameTextBox.Text;
            newClient.Email = EmailTextBox.Text;
            newClient.Patronymic = PatronymicTextBox.Text;

            PostNewClientAsync(newClient);

            LoginTextBox.Text = null;
            NameTextBox.Text = null;
            PhoneNumberTextBox.Text = null;
            SurnameTextBox.Text = null;
            EmailTextBox.Text = null;
            PatronymicTextBox.Text = null;
        }

        private async Task PostNewClientAsync(ClientsDTO newClient)
        {
            string json = JsonSerializer.Serialize(newClient);

            string apiUrl = "https://localhost:7168/api/Clients/";


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    MessageBox.Show("Новый клиент успешно создан");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    MessageBox.Show("При создании клиента произошла ошибка. Попробуйте еще раз");
                }
            }
        }



        //==============    END     ==================

        //============= Moving Screen =================

        Point lastPoint;
        private void ClientDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ClientDetails_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //=============     END     =================
    }
}
