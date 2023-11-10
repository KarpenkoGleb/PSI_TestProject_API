using Newtonsoft.Json;
using PSI_WebForms.DTO;
using System;
using System.Collections.Generic;
//using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PSI_WebForms
{
    public partial class InvoiceDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  

        }

        protected void Page_Init(object sender, EventArgs e)
        {

            int invoiceId = StaticClass.InvoiceId;

            LoadDataOfInvoiceByIdAsync(invoiceId);

        }

        protected void BackToInvoicesListButton_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("ClientsInvoices.aspx");
            }
            catch (ThreadAbortException ex)
            {
                Server.ClearError();
            }
        }
        protected void ReceiptIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ReceiptIdTextBox.Text == StaticClass.InvoiceObject.receiptId.ToString() || ReceiptIdTextBox.Text == null || ReceiptIdTextBox.Text == "")
            {
                //PayButton.Enabled = false;
                //PayButton.ForeColor = System.Drawing.Color.Gray;

                //PayButton.BackColor = System.Drawing.Color.DarkGray;
            }
            else
            {
                ReceiptIdTextBox.BorderColor = System.Drawing.Color.Gray;
                ReceiptIdTextBox.BorderWidth = 1;

                PayButton.Enabled = true;
                PayButton.ForeColor = System.Drawing.Color.Black; // = System.Drawing.ColorTranslator.FromHtml("#0a7b4c");
            }               
            
        }

        protected void PayButton_Click(object sender, EventArgs e)
        {
            if(ReceiptIdTextBox.Text != null && ReceiptIdTextBox.Text != "")
            {
                try
                {
                    UpdateInvoiceAsync();

                    Response.Redirect("ClientsInvoices.aspx");
                }
                catch (ThreadAbortException ex)
                {
                    Server.ClearError();
                }
            }
            else
            {
                ReceiptIdTextBox.BorderColor = System.Drawing.Color.DarkRed;
                ReceiptIdTextBox.BorderWidth = 3;
            }
        }



        //=============     END     =================


        private async void LoadDataOfInvoiceByIdAsync(int invoiceId)
        {
            try
            {
                StaticClass.InvoiceObject = await GetDataOfInvoiceByIdAsync(invoiceId);

                ServiceNameTextBox.Text = StaticClass.InvoiceObject.Service.Service;
                AmountTextBox.Text = StaticClass.InvoiceObject.Amount.ToString();
                CreationDateTextBox.Text = StaticClass.InvoiceObject.CreationDate.ToString();
                PayBeforeTextBox.Text = StaticClass.InvoiceObject.PayBefore.ToString();
                ReceiptIdTextBox.Text = StaticClass.InvoiceObject.receiptId.ToString();
                if (ReceiptIdTextBox.Text != null && ReceiptIdTextBox.Text != "")
                {
                    ReceiptIdTextBox.Enabled = false;

                    PayButton.Visible = false;  //System.Drawing.ColorTranslator.FromHtml("#373737");
                    //PayButton.BackColor = System.Drawing.Color.DarkGray;
                }
                else
                {
                    PayButton.ForeColor = System.Drawing.Color.White;
                    PayButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#0a7b4c");

                    PayButton.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
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



        //============= Send request of updating invoice data =================

        private async void UpdateInvoiceAsync()
        {
            StaticClass.InvoiceObject.receiptId = Int32.Parse(ReceiptIdTextBox.Text);
            StaticClass.InvoiceObject.PaymentDate = DateTime.Now;
            StaticClass.InvoiceObject.IsPaymentCompleted = true;

            InvoicesDTO updatedInvoice = StaticClass.InvoiceObject;

            int InvoiceId = StaticClass.InvoiceId;

            await PutInvoiceAsync(updatedInvoice, InvoiceId);
        }

        private async Task PutInvoiceAsync(InvoicesDTO updatedInvoice, int InvoiceId)
        {
            string json = JsonSerializer.Serialize(updatedInvoice);


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(string.Format("api/Invoices/{0}", InvoiceId), content);
                //HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response: " + responseContent);

                    //MessageBox.Show("Данные счета успешно обновлены");
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);

                    //MessageBox.Show("При изменении данных счета произошла ошибка. Попробуйте еще раз");
                }
            }
        }

        //=============     END     =================
    }
}