using Newtonsoft.Json;
using PSI_WebForms.DTO;
using System;
using System.Collections.Generic;
//using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PSI_WebForms
{
    public partial class ClientsInvoices : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            ClientNameTextBox.Text = StaticClass.ClientObject.Name;
            ClientSurnameTextBox.Text = StaticClass.ClientObject.Surname;
            ClientPatronymicTextBox.Text = StaticClass.ClientObject.Patronymic;

            int clientId = StaticClass.ClientObject.Id;

            LoadDataOfInvoiceByFiltersAsync(clientId);     

        }
        private async void LoadDataOfInvoiceByFiltersAsync(int clientId)
        {
            try
            {
                var data = await GetDataOfInvoiceByFiltersAsync(clientId);

                InvoicesGridView.DataSource = data;
                InvoicesGridView.DataBind();

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async Task<List<InvoicesDTO>> GetDataOfInvoiceByFiltersAsync(int clientId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync(string.Format("api/Invoices/byfilters?clientId={0}&serviceId={1}&creationDate={2}&paymentDate={3}&isPaymentCompleted={4}"
                                                                                    , clientId
                                                                                    , null
                                                                                    , null
                                                                                    , null
                                                                                    , null
                                                                                    )); // Adjust the URL to match your API's endpoint.
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<InvoicesDTO>>(content);

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