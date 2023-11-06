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

        protected void LoginButton_Click(object sender, EventArgs e)
        {            
            string login = LoginTextBox.Text;

            AuthorizationByLoginAsync(login);
        }


        private async void AuthorizationByLoginAsync(string login)
        {
            try
            {
                var data = await GetDataOfClientByLoginAsync(login);

                StaticClass.ClientObject = data;

                Response.Redirect("ClientsInvoices.aspx");

                //------------

                Session["clientObject"] = JsonSerializer.Serialize(data);

                string jsonDto = Session["clientObject"] as string;

                ClientsDTO reconvertData = JsonSerializer.Deserialize<ClientsDTO>(jsonDto);

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
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
                    throw new Exception("Failed to retrieve data from the API.");
                }
            }
        }
    }
}