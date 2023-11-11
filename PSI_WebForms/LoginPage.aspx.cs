using Newtonsoft.Json;
using PSI_WebForms.DTO;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PSI_WebForms
{
    public partial class LoginPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            //LoginButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#0a7b4c");
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {            
            string login = LoginTextBox.Text;

            if(login != null && login != "")
            {
                AuthorizationByLoginAsync(login);
            }
        }

        private async void AuthorizationByLoginAsync(string login)
        {
            try
            {
                var data = await GetDataOfClientByLoginAsync(login);

                StaticClass.ClientObject = data;

                //------------

                Session["clientObject"] = JsonSerializer.Serialize(data);

                string jsonDto = Session["clientObject"] as string;

                ClientsDTO reconvertData = JsonSerializer.Deserialize<ClientsDTO>(jsonDto);

                try
                {
                    Response.Redirect("ClientsInvoices.aspx");
                }
                catch
                {
                    Server.ClearError();
                }

            }
            catch (Exception ex)
            {
                // Assume there is a problem, and you want to inform the user
                string message = ex.Message;    //"There was a problem processing your request. Please try again.";

                // RegisterStartupScript is used to inject JavaScript into the page
                // The JavaScript here displays an alert with the specified message
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showMessage", $"alert('{message}');", true);
            }
        }

        private async Task<ClientsDTO> GetDataOfClientByLoginAsync(string login)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7168/");

                HttpResponseMessage response = await client.GetAsync(string.Format("api/Clients/byLogin/{0}", login)); // Adjust the URL to match your API's endpoint.
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<ClientsDTO>(content);

                    return data;
                }
                else
                {
                    throw new Exception("Login is incorrect or we faced with problem while trying to retrieve data from the API.");
                }
            }
        }
    }
}