﻿using Newtonsoft.Json;
using PSI_WinForms.DTO;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
            newService.Service_Descr = ServiceDescrTextBox.Text;

            PostNewServiceAsync(newService);

            ServiceTextBox.Text = null;
            ServiceDescrTextBox.Text = null;



        }

        private async Task PostNewServiceAsync(ServicesDTO newService)
        {
            string json = JsonSerializer.Serialize(newService);

            string apiUrl = "https://localhost:7168/api/Services/";


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    MessageBox.Show("Новый сервис успешно создан");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    MessageBox.Show("При создании сервиса произошла ошибка. Попробуйте еще раз");
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

        //=============     END     =================
    }
}
