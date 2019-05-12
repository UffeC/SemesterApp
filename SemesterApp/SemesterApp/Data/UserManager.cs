using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace SemesterApp.Data
{
    class UserManager
    {
        const string Url = "http://sdubackend.azurewebsites.net/Umbraco/Api/User/";

        public async Task<bool> Create(string enteredId)
        {            
            HttpClient client = new HttpClient();

            // Get the list of record objects
            List<BaselineRecord> baselineRecords = await RedCap.GetBaselineRecords();

            User user = new User();

            // Search for entered id in record list and set authorization status if found
            foreach (BaselineRecord baselineRecord in baselineRecords)
            {
                if (baselineRecord.record_id == enteredId)
                {
                    user.Name = baselineRecord.record_id;
                    user.AuthenticationCode = Convert.ToInt32(baselineRecord.record_id);
                    user.Group = baselineRecord.randomisation_group;
                    break;
                }
            }

            HttpResponseMessage response = await client.PostAsync(Url + "Create",
                new StringContent(
                    JsonConvert.SerializeObject(user),
                    Encoding.UTF8, "application/json"));

            bool status = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false;

            return status;
        }
    }
}
