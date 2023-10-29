using Newtonsoft.Json;
using PSI_WinForms.DTO;
using System.Text;

namespace PSI_WinForms
{
    public partial class UpdateInvoiceForm : Form
    {
        private int _InvoiceId;
        public UpdateInvoiceForm(int invoiceId)
        {
            InitializeComponent();
            LoadDataOfInvoiceByAsync(invoiceId);

            LoadListDataOfClientsAsync();
            LoadListDataOfServicesAsync();

            _InvoiceId = invoiceId;

        }

        //=============     Loading data for text boxes     =================

        private async void LoadDataOfInvoiceByAsync(int invoiceId)
        {
            try
            {
                var data = await GetDataOfInvoiceByIdAsync(invoiceId);

                AmountTextBox.Text = data?.Amount.ToString();

                CreationDateTextBox.Text = data?.CreationDate.ToString();

                PayBeforeTextBox.Text = data?.PayBefore.ToString();

                PaymentDateTextBox.Text = data?.PaymentDate.ToString();

                ReceiptTextBox.Text = data?.receiptId.ToString();

                IsPaymentCompletedTextBox.Text = data?.IsPaymentCompleted.ToString();

                ClientsList.SelectedValue = data?.ClientId;

                ClientTextBox.Text = data?.Client.Name; // Set the data source after data is retrieved.

                PhoneNumTextBox.Text = data?.Client.PhoneNumber;

                EmailTextBox.Text = data?.Client.Email;

                SurnameTextBox.Text = data?.Client.Surname;

                PatronymicTextBox.Text = data?.Client.Patronymic;

                ServiceList.SelectedValue = data?.ServiceId;

                ServiceDescrTextBox.Text = data?.Service.Service_Descr;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private async Task<InvoicesDTO> GetDataOfInvoiceByIdAsync(int invoiceId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync(string.Format("api/Invoices/{0}", invoiceId)); // Adjust the URL to match your API's endpoint.
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<InvoicesDTO>(content);

                    return data;
                }
                else
                {
                    throw new Exception("Failed to retrieve data from the API.");
                }
            }
        }

        //====================     END     ====================

        //=============     Loading dropdown list of Clients        =================

        private async void LoadListDataOfClientsAsync()
        {
            try
            {
                var data = await GetListDataOfClientsAsync();

                ClientsList.DataSource = data; // Set the data source after data is retrieved.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<List<ClientsDTO>> GetListDataOfClientsAsync()
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

        //====================     END     ====================


        //=============     Loading dropdown list of Services    =============

        private async void LoadListDataOfServicesAsync()
        {
            try
            {
                var data = await GetListDataOfServicesAsync();

                ServiceList.DataSource = data; // Set the data source after data is retrieved.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<List<ServicesDTO>> GetListDataOfServicesAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await httpClient.GetAsync("api/Services"); // Adjust the URL to match your API's endpoint.
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

        //=============     END     =================

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();       //this.Close();
        }

        //============= Moving Screen =================

        Point lastPoint;
        private void InvoicesDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void InvoicesDetails_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ServiceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //=============     END     =================

        //============= Renew textboxes for client =================
        private async void LoadDataOfClientByAsync(int clientId)
        {
            try
            {
                var data = await GetDataOfClientByIdAsync(clientId);

                //ClientsList.SelectedValue = data?.Id;

                ClientTextBox.Text = data?.Name; // Set the data source after data is retrieved.

                PhoneNumTextBox.Text = data?.PhoneNumber;

                EmailTextBox.Text = data?.Email;

                SurnameTextBox.Text = data?.Surname;

                PatronymicTextBox.Text = data?.Patronymic;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private async Task<ClientsDTO> GetDataOfClientByIdAsync(int clientId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync(string.Format("api/Clients/{0}", clientId)); // Adjust the URL to match your API's endpoint.
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

        private void ClientsList_DropDownClosed(object sender, EventArgs e)
        {
            var clientId = (int)ClientsList.SelectedValue;

            LoadDataOfClientByAsync(clientId);
        }

        //=============     END     =================

        //============= Renew textboxes for service =================
        private async void LoadDataOfServiceByAsync(int clientId)
        {
            try
            {
                var data = await GetDataOfServiceByIdAsync(clientId);

                //ClientsList.SelectedValue = data?.Id;

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

        private void ServiceList_DropDownClosed(object sender, EventArgs e)
        {
            var serviceId = (int)ServiceList.SelectedValue;

            LoadDataOfServiceByAsync(serviceId);

        }

        //=============     END     =================


        //============= BUTTON action =================

        //private void UpdateInvoiceButton_Click(object sender, EventArgs e)
        //{
        //    InvoicesDTO newInvoice = new InvoicesDTO();

        //    newInvoice.Id = _InvoiceId;
        //    newInvoice.ServiceId = (int)ServiceList.SelectedValue;
        //    newInvoice.ServiceId = (int)ClientsList.SelectedValue;
        //    newInvoice.Amount = AmountTextBox.Text;
        //    newInvoice.CreationDate = CreationDateTextBox.Text;
        //    newInvoice.Surname = SurnameTextBox.Text;
        //    newInvoice.Email = EmailTextBox.Text;
        //    newInvoice.Patronymic = PatronymicTextBox.Text;

        //    PutClientAsync(newInvoice, _InvoiceId);
        //}

        //private async Task PutClientAsync(ClientsDTO newInvoice, int ClientId)
        //{
        //    string json = JsonSerializer.Serialize(newInvoice);


        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://localhost:7168/");

        //        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

        //        HttpResponseMessage response = await client.PutAsync(string.Format("api/Clients/{0}", ClientId), content);
        //        //HttpResponseMessage response = await client.PutAsync(apiUrl, content);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            string responseContent = await response.Content.ReadAsStringAsync();
        //            Console.WriteLine("Response: " + responseContent);

        //            MessageBox.Show("Данные клиента успешно обновлены");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Error: " + response.StatusCode);

        //            MessageBox.Show("При изменении данных клиента произошла ошибка. Попробуйте еще раз");
        //        }
        //    }
        //}
        //=============     END     =================


    }
}
