using Newtonsoft.Json;
using PSI_WinForms.DTO;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using Windows.Web.Http;
using HttpClient = System.Net.Http.HttpClient;
using HttpResponseMessage = System.Net.Http.HttpResponseMessage;

namespace PSI_WinForms
{
    public partial class CreationServiceForm : Form
    {
        public CreationServiceForm()
        {
            InitializeComponent();
        }

        private async void LoadDataOfServiceByAsync(int serviceId)
        {
            try
            {
                var data = await GetDataOfServiceByIdAsync(serviceId);

                ServiceTextBox.Text = data?.Service; // Set the data source after data is retrieved.

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();
        }




        //============= Buttons actions =================

        private void UpdateInvoiceButton_Click(object sender, EventArgs e)
        {
            ServicesDTO newService = new ServicesDTO();

            newService.Id = 0;
            newService.Service = ServiceTextBox.Text;

            //PostNewServiceAsync(newService);

        }

        //private async Task<HttpResponseMessage> PostNewServiceAsync(ServicesDTO newService)
        //{
            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:7168/");


            //    //string serviceByString = newService.ToString();

            //    //HttpContent c = new StringContent(serviceByString, Encoding.UTF8, "application/json")

            //    //var serviceContent = JsonSerializer.Serialize(newService);

            //    JsonContent content = JsonContent.Create(newService);
            //    using var response = await client.PostAsync("api/Services/", content);
            //    ServicesDTO? person = await response.Content.ReadFromJsonAsync<ServicesDTO>();
            //    Console.WriteLine($"{person?.Id} - {person?.Service}");

            //    //HttpResponseMessage response = await client.PostAsync(string.Format("api/Services/", c)); // Adjust the URL to match your API's endpoint.
            //    //if (response.IsSuccessStatusCode)
            //    //{
            //    //    var content = await response.Content.ReadAsStringAsync();
            //    //    var data = JsonConvert.DeserializeObject<InvoicesDTO>(content);

            //    //    return data;

            //    //}
            //    //else
            //    //{
            //    //    throw new Exception("Failed to retrieve data from the API.");
            //    //}

            //}
        //}



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

        //=============     END     =================
    }
}
