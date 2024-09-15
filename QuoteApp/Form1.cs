using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuoteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form
        }

        private async void btnQuote_Click(object sender, EventArgs e)
        {
            // Await the async method to prevent blocking the UI thread
            string quote = await getRandomQuote();
            MessageBox.Show(quote, "Quote of the day", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task<string> getRandomQuote()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://favqs.com/api/qotd");

                try
                {
                    HttpResponseMessage response = await client.GetAsync(""); // Send GET request
                    response.EnsureSuccessStatusCode(); // Ensure the response is successful

                    string jsonResponse = await response.Content.ReadAsStringAsync(); // Read the response as a string
                    JObject json = JObject.Parse(jsonResponse); // Parse the JSON

                    // Extract the quote from the JSON
                    string quote = json["quote"]["body"].ToString();
                    string author = json["quote"]["author"].ToString();

                    return $"{quote} - {author}";
                }
                catch (HttpRequestException ex)
                {
                    return "Error retrieving quote: " + ex.Message;
                }
            }
        }
    }
}
