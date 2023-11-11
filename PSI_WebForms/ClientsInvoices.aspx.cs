using Newtonsoft.Json;
using PSI_WebForms.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.IO;
using System.Net.Http;
using System.Threading;
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

            LoadDataOfInvoiceByFiltersAsync(clientId, null, null, null, null);

        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetails")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument); // Get the row index

                StaticClass.InvoiceId = Convert.ToInt32(InvoicesGridView.DataKeys[rowIndex]["Id"]); // Get the value from the ID column

                // Redirect to another page with the value from the row

                try
                {
                    Response.Redirect("InvoiceDetails.aspx");
                }
                catch (ThreadAbortException ex)
                {
                    Server.ClearError();
                }
            }
        }
        protected void ddlServiceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void RefreshButton_Click(object sender, EventArgs e)
        {
            int clientId = StaticClass.ClientObject.Id;

            LoadDataOfInvoiceByFiltersAsync(clientId,null, null, null, null);
        }

        protected void FilterButton_Click(object sender, EventArgs e)
        {

        }

        private async void LoadDataOfInvoiceByFiltersAsync(int clientId, int? serviceId, DateTime? creationDate, DateTime? paymentDate, bool? isPaymentCompleted)
        {
            try
            {
                var data = await GetDataOfInvoiceByFiltersAsync(clientId, serviceId, creationDate, paymentDate, isPaymentCompleted);

                StaticClass.Invoices = data;

                StaticClass.ClientsFromInvoices = data
                    .Select(parent => parent.Client)
                    .Distinct()
                    .ToList();

                StaticClass.ServicesFromInvoices = data
                    .Select(parent => parent.Service)
                    .Distinct()
                    .ToList();

                if (StaticClass.ServicesFromInvoices != null)
                {
                    ddlServiceFilter.DataSource = StaticClass.ServicesFromInvoices;
                    ddlServiceFilter.DataTextField = "Service"; // Set the property for text
                    ddlServiceFilter.DataValueField = "Id"; // Set the property for value
                    ddlServiceFilter.DataBind();
                }

                if (StaticClass.ClientsFromInvoices != null)
                {
                    ddlLoginFilter.DataSource = StaticClass.ClientsFromInvoices;
                    ddlLoginFilter.DataTextField = "Login"; // Set the property for text
                    ddlLoginFilter.DataValueField = "Id"; // Set the property for value
                    ddlLoginFilter.DataBind();
                }

                InvoicesGridView.DataSource = data;
                InvoicesGridView.DataBind();

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async Task<List<InvoicesDTO>> GetDataOfInvoiceByFiltersAsync(int clientId, int? serviceId, DateTime? creationDate, DateTime? paymentDate, bool? isPaymentCompleted)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync(string.Format("api/Invoices/byfilters?clientId={0}&serviceId={1}&creationDate={2}&paymentDate={3}&isPaymentCompleted={4}"
                                                                                    , clientId
                                                                                    , serviceId
                                                                                    , creationDate
                                                                                    , paymentDate
                                                                                    , isPaymentCompleted
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