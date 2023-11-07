using Newtonsoft.Json;
using PSI_WebForms.DTO;
using System;
using System.Collections.Generic;
//using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
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
    }
}