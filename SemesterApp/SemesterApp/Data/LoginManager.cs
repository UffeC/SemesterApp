using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SemesterApp.Data
{
    class LoginManager
    {
        const string Url = "http://sdubackend.azurewebsites.net/Umbraco/Api/Login/GetContent";

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();

            return client;
        }

        public async Task<LoginContent> GetContent()
        {
            // TODO: use GET to retrieve books
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            LoginContent loginContent = JsonConvert.DeserializeObject<LoginContent>(result);
            return loginContent;
        }

    }
}
