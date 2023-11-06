using Newtonsoft.Json;
using PSI_WinForms.DTO;
using System.Text;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PSI_WinForms
{
    public partial class UpdateInvoiceForm : Form
    {
        private int _InvoiceId;

        private int _createdInvoiceId = 0;

        public UpdateInvoiceForm(int invoiceId)
        {
            if (invoiceId == -1)
            {
                InitializeComponent();

                DeleteInvoiceButton.Visible = false;
                DeleteInvoiceButton.Enabled = false;

                CreationDatePicker.Enabled = true;
                IsPaymentCompletedCheckBox.Checked = false;
                ChangeTextOfIsPaymentCompletedCheckBox();
                PaymentDatePicker.Enabled = IsPaymentCompletedCheckBox.Checked;

                ClientsList.ForeColor = SystemColors.WindowFrame;
                ServiceList.ForeColor = SystemColors.WindowFrame;

                InvoiceIdTextBox.Text = "_";

            }
            else
            {
                InitializeComponent();
                LoadDataOfInvoiceByAsync(invoiceId);

                LoadListDataOfClientsAsync();
                LoadListDataOfServicesAsync();

                InvoiceIdTextBox.Text = invoiceId.ToString();
            }

            _InvoiceId = invoiceId;

        }

        //=============     Loading data for text boxes     =================

        private async void LoadDataOfInvoiceByAsync(int invoiceId)
        {
            try
            {
                var data = await GetDataOfInvoiceByIdAsync(invoiceId);


                AmountTextBox.Text = data?.Amount.ToString();

                CreationDatePicker.Text = data?.CreationDate.ToString();

                PayBeforePicker.Text = data?.PayBefore.ToString();

                PaymentDatePicker.Text = data?.PaymentDate.ToString();

                ReceiptTextBox.Text = data?.receiptId.ToString();

                IsPaymentCompletedCheckBox.Checked = Convert.ToBoolean(data?.IsPaymentCompleted);

                ChangeTextOfIsPaymentCompletedCheckBox();

                PaymentDatePicker.Enabled = IsPaymentCompletedCheckBox.Checked;

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

        private void ClientsList_Click(object sender, EventArgs e)
        {
            if (ClientsList.DataSource == null)
            {
                LoadListDataOfClientsAsync();

                ClientsList.ForeColor = Color.Black;
            }
        }


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

        private void ServiceList_Click(object sender, EventArgs e)
        {
            if (ServiceList.DataSource == null)
            {
                LoadListDataOfServicesAsync();

                ServiceList.ForeColor = Color.Black;
            }

        }

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
            if (ClientsList.SelectedValue != null)
            {
                var clientId = (int)ClientsList.SelectedValue;
                LoadDataOfClientByAsync(clientId);
            }
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
            if (ServiceList.SelectedValue != null)
            {
                var serviceId = (int)ServiceList.SelectedValue;
                LoadDataOfServiceByAsync(serviceId);
            }
        }

        //=============     END     =================


        //============= BUTTON action =================

        private async void UpdateInvoiceButton_Click(object sender, EventArgs e)
        {
            InvoicesDTO newInvoice = new InvoicesDTO();

            newInvoice.ServiceId = (int)ServiceList.SelectedValue;
            newInvoice.ClientId = (int)ClientsList.SelectedValue;
            newInvoice.Amount = Int32.Parse(AmountTextBox.Text);
            newInvoice.CreationDate = DateTime.Parse(CreationDatePicker.Text);        //CreationDatePicker.Text;
            newInvoice.PayBefore = DateTime.Parse(PayBeforePicker.Text);     //PayBeforePicker.Text;
            newInvoice.PaymentDate = IsPaymentCompletedCheckBox.Checked ? DateTime.Parse(PaymentDatePicker.Text) : null;
            newInvoice.receiptId = ReceiptTextBox.Text == "" ? null : Int32.Parse(ReceiptTextBox.Text);
            newInvoice.IsPaymentCompleted = Convert.ToBoolean(IsPaymentCompletedCheckBox.Checked);

            if (_InvoiceId == -1)
            {
                newInvoice.Id = 0;
                PostInvoiceAsync(newInvoice);
            }
            else
            {
                newInvoice.Id = _InvoiceId;
                PutInvoiceAsync(newInvoice, _InvoiceId);
            }
        }

        private async Task PostInvoiceAsync(InvoicesDTO newInvoice)
        {
            string json = JsonSerializer.Serialize(newInvoice);


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(string.Format("api/Invoices/"), content);
                //HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Created invoice Id: " + responseContent);

                    MessageBox.Show("Счет успешно создан");

                    _createdInvoiceId = Convert.ToInt32(responseContent);
                    this.Close();
                    UpdateInvoiceForm updateInvoiceForm = new UpdateInvoiceForm(_createdInvoiceId);
                    updateInvoiceForm.Show();
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    MessageBox.Show("При создании счета произошла ошибка. Попробуйте еще раз");
                }
            }
        }

        private async Task PutInvoiceAsync(InvoicesDTO newInvoice, int invoiceId)
        {
            string json = JsonSerializer.Serialize(newInvoice);


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(string.Format("api/Invoices/{0}", invoiceId), content);
                //HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    MessageBox.Show("Данные счета успешно обновлены");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    MessageBox.Show("При изменении данных счета произошла ошибка. Попробуйте еще раз");
                }
            }
        }

        private void ReceiptTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void ChangeTextOfIsPaymentCompletedCheckBox()
        {
            if (IsPaymentCompletedCheckBox.Checked == true)
                IsPaymentCompletedCheckBox.Text = "Оплачен";
            else
                IsPaymentCompletedCheckBox.Text = "Не оплачен";
        }

        private void IsPaymentCompletedCheckBox_Click(object sender, EventArgs e)
        {
            ChangeTextOfIsPaymentCompletedCheckBox();
            PaymentDatePicker.Enabled = IsPaymentCompletedCheckBox.Checked;
        }

        //=============     END     =================


        //============= DELETE invoice =================

        private void DeleteInvoiceButton_Click(object sender, EventArgs e)
        {
            DeleteInvoiceAsync(_InvoiceId);

            this.Close();
            //MainForm mainForm = new MainForm();
            //mainForm.Show();

        }

        private async Task DeleteInvoiceAsync(int invoiceId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.DeleteAsync(string.Format("api/Invoices/{0}", invoiceId));

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    MessageBox.Show("Счет успешно удален");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    MessageBox.Show("При удалении счета произошла ошибка. Попробуйте еще раз");
                }
            }
        }


        //=============     END     =================


    }
}
