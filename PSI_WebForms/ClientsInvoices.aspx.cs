using Newtonsoft.Json;
using PSI_WebForms.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private DateTime? creationDate;
        private DateTime? paymentDate;
        private bool? isPaymentCompleted;
        private int? serviceId;

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
        protected void InvoicesGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Assuming you have columns named "Column1" and "Column2"
                int columnIndex1 = InvoicesGridView.Columns.IndexOf(InvoicesGridView.Columns.OfType<DataControlField>().FirstOrDefault(c => c.HeaderText == "Оплатить до"));
                int columnIndex2 = InvoicesGridView.Columns.IndexOf(InvoicesGridView.Columns.OfType<DataControlField>().FirstOrDefault(c => c.HeaderText == "Дата оплаты"));

                if (columnIndex1 != -1 && columnIndex2 != -1)
                {

                    if (e.Row.Cells[columnIndex2].Text != null && e.Row.Cells[columnIndex2].Text != "")
                    {
                        // Assuming values are integers, modify this based on your actual data type
                        DateTime value1 = DateTime.Parse(e.Row.Cells[columnIndex1].Text);
                        DateTime? value2 = DateTime.Parse(e.Row.Cells[columnIndex2].Text);

                        // Check your condition, for example, if value1 is less than value2, change the color

                        if (value1 < value2)
                        {
                            e.Row.Cells[columnIndex2].ForeColor = System.Drawing.Color.Red;
                            // You can also set other style properties like BackColor, Font, etc.
                        }
                        else
                        {
                            e.Row.BackColor = System.Drawing.Color.LightGreen;
                        }
                    }
                }
            }
        }

        protected void RefreshButton_Click(object sender, EventArgs e)
        {
            int clientId = StaticClass.ClientObject.Id;

            LoadDataOfInvoiceByFiltersAsync(clientId,null, null, null, null);
        }

        protected void FilterButton_Click(object sender, EventArgs e)
        {
            int clientId = StaticClass.ClientObject.Id;

            if (ddlServiceFilter.SelectedValue == "null")
                serviceId = null;
            else
                serviceId = Convert.ToInt32(ddlServiceFilter.SelectedValue);

            if(txtCreationDateFilter.Text == "" || txtCreationDateFilter.Text == null)
                creationDate = null;
            else
                creationDate = DateTime.ParseExact(txtCreationDateFilter.Text, "M/d/yyyy", CultureInfo.InvariantCulture);   

            if (PaymentDateFilter.Text == "" || PaymentDateFilter.Text == null)
                paymentDate = null;
            else
                paymentDate = DateTime.ParseExact(PaymentDateFilter.Text, "M/d/yyyy", CultureInfo.InvariantCulture);

            if (ddlIsPaymentCompletedFilter.SelectedValue == "null")
                isPaymentCompleted = null;
            else
                isPaymentCompleted = bool.Parse(ddlIsPaymentCompletedFilter.SelectedValue);


            LoadDataOfInvoiceByFiltersAsync(clientId, serviceId, creationDate, paymentDate, isPaymentCompleted);
        }

        private async void LoadDataOfInvoiceByFiltersAsync(int clientId, int? serviceId, DateTime? creationDate, DateTime? paymentDate, bool? isPaymentCompleted)
        {
            try
            {
                var data = await GetDataOfInvoiceByFiltersAsync(clientId, serviceId, creationDate, paymentDate, isPaymentCompleted);

                if(serviceId == null && creationDate == null && paymentDate == null && isPaymentCompleted == null)
                {
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

                        ddlServiceFilter.Items.Insert(0, new ListItem("Не выбрана", "null"));
                    }
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

                string creationDateStr = string.Format("{0:yyyy-MM-dd HH:mm:ss}", creationDate);
                string paymentDateStr = string.Format("{0:yyyy-MM-dd HH:mm:ss}", paymentDate);

                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync(string.Format("api/Invoices/byfilters?clientId={0}&serviceId={1}&creationDate={2}&paymentDate={3}&isPaymentCompleted={4}"
                                                                                    , clientId
                                                                                    , serviceId
                                                                                    , creationDateStr
                                                                                    , paymentDateStr
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