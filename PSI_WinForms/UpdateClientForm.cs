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
    public partial class UpdateClientForm : Form
    {
        private int _ClientId;
        public UpdateClientForm(int ClientId)
        {
            InitializeComponent();

            LoadDataOfClientByAsync(ClientId);

            _ClientId = ClientId;
        }

        private async void LoadDataOfClientByAsync(int ClientId)
        {
            try
            {
                var data = await GetDataOfClientByIdAsync(ClientId);

                LoginTextBox.Text = data?.Login;
                NameTextBox.Text = data?.Name;
                PhoneNumberTextBox.Text = data?.PhoneNumber;
                SurnameTextBox.Text = data?.Surname;
                EmailTextBox.Text = data?.Email;
                PatronymicTextBox.Text = data?.Patronymic;

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


        //============= Close button action =================

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();

            ClientsForm ClientsForm = new ClientsForm();
            ClientsForm.Show();
        }

        //==============    END     ==================


        //============= Update button action =================

        private void UpdateClientButton_Click(object sender, EventArgs e)       // !!!!!!!!!!!!!!!!!!!!!!!!
        {
            ClientsDTO newClient = new ClientsDTO();

            newClient.Id = _ClientId;
            newClient.Login = LoginTextBox.Text;
            newClient.Name = NameTextBox.Text;
            newClient.PhoneNumber = PhoneNumberTextBox.Text;
            newClient.Surname = SurnameTextBox.Text;
            newClient.Email = EmailTextBox.Text;
            newClient.Patronymic = PatronymicTextBox.Text;

            PutClientAsync(newClient, _ClientId);

        }

        private async Task PutClientAsync(ClientsDTO newClient, int ClientId)
        {
            string json = JsonSerializer.Serialize(newClient);


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(string.Format("api/Clients/{0}", ClientId), content);
                //HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    MessageBox.Show("Данные клиента успешно обновлены");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    MessageBox.Show("При изменении данных клиента произошла ошибка. Попробуйте еще раз");
                }
            }
        }

        //==============    END     ==================


        //============= Delete button action =================

        private void DeleteClientButton_Click(object sender, EventArgs e)       // !!!!!!!!!!!!!!!!!!!!!!!!
        {
            DeleteClientAsync(_ClientId);

            this.Close();
            ClientsForm ClientsForm = new ClientsForm();
            ClientsForm.Show();
        }

        private async Task DeleteClientAsync(int ClientId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.DeleteAsync(string.Format("api/Clients/{0}", ClientId));
                //HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    MessageBox.Show("Клиент успешно удален");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    MessageBox.Show("При удалении коиента произошла ошибка. Попробуйте еще раз");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //=============     END     =================
    }
}
