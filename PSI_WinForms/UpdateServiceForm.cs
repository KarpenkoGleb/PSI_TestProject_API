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
    public partial class UpdateServiceForm : Form
    {
        private int _serviceId;
        public UpdateServiceForm(int serviceId)
        {
            InitializeComponent();

            LoadDataOfServiceByAsync(serviceId);

            _serviceId = serviceId;
        }

        private async void LoadDataOfServiceByAsync(int serviceId)
        {
            try
            {
                var data = await GetDataOfServiceByIdAsync(serviceId);

                ServiceTextBox.Text = data?.Service; // Set the data source after data is retrieved.

                ServiceDescrTextBox.Text = data?.Service_Descr; // Set the data source after data is retrieved.

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private async Task<ServicesDTO> GetDataOfServiceByIdAsync(int serviceId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync(string.Format("api/Services/{0}", serviceId)); // Adjust the URL to match your API's endpoint.
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<ServicesDTO>(content);

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

            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();
        }

        //==============    END     ==================


        //============= Update button action =================

        private void UpdateServiceButton_Click(object sender, EventArgs e)       // !!!!!!!!!!!!!!!!!!!!!!!!
        {
            ServicesDTO newService = new ServicesDTO();

            newService.Id = _serviceId;
            newService.Service = ServiceTextBox.Text;
            newService.Service_Descr = ServiceDescrTextBox.Text;

            PutServiceAsync(newService, _serviceId);

        }

        private async Task PutServiceAsync(ServicesDTO newService, int serviceId)
        {
            string json = JsonSerializer.Serialize(newService);

            string apiUrl = "https://localhost:7168/api/Services/{0}";


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(string.Format("api/Services/{0}", serviceId), content);
                //HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    MessageBox.Show("Данные сервиса успешно обновлены");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    MessageBox.Show("При изменении данных сервиса произошла ошибка. Попробуйте еще раз");
                }
            }
        }

        //==============    END     ==================


        //============= Delete button action =================

        private void DeleteServiceButton_Click(object sender, EventArgs e)       // !!!!!!!!!!!!!!!!!!!!!!!!
        {
            DeleteServiceAsync(_serviceId);

            this.Close();
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();
        }

        private async Task DeleteServiceAsync(int serviceId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage? response = null;

                try
                {
                    response = await client.DeleteAsync(string.Format("api/Services/{0}", serviceId));
                    //HttpResponseMessage response = await client.PutAsync(apiUrl, content);
                }

                catch (HttpRequestException ex)
                {
                    // Handle HTTP request exceptions (e.g., network issues).
                    MessageBox.Show($"HTTP Request Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle other exceptions, including the one with the exception message from your API.
                    MessageBox.Show($"Error: {ex.Message}");
                }

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    MessageBox.Show("Сервис успешно удален");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    var errorMessage = await response.Content.ReadAsStringAsync();

                    MessageBox.Show(errorMessage);        //"При удалении сервиса произошла ошибка. Попробуйте еще раз");
                }
            }
        }

        //==============    END     ==================




        //============= Moving Screen =================

        Point lastPoint;
        private void ServiceDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ServiceDetails_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //=============     END     =================
    }
}
