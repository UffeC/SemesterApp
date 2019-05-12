using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SemesterApp.Data
{
    class RedCap
    {
        const string Url = "https://open.rsyd.dk/redcap/api/";

        public static async Task<List<BaselineRecord>> GetBaselineRecords()
        {
            // Instantiate new client
            HttpClient client = new HttpClient();

            // Set the form data as a list of key calue pair
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("token", "4DA72F540502C793F5B3458461EAE2EC"),
                new KeyValuePair<string, string>("content", "record"),
                new KeyValuePair<string, string>("format", "json"),
                new KeyValuePair<string, string>("type", "flat"),
                new KeyValuePair<string, string>("fields", "['randomisation_group', 'record_id']"),
                new KeyValuePair<string, string>("forms", "['opstart_intervention_anne_marie_rosager', 'randomisering_anne_marie_rosager']"),
                new KeyValuePair<string, string>("events", "baseline_arm_1"),
                new KeyValuePair<string, string>("returnFormat", "json")
            };

            // Await and receive response from RedCap API
            HttpResponseMessage response = await client.PostAsync(Url,
                new FormUrlEncodedContent(data));

            // Convert response content to JSON string
            string json = await response.Content.ReadAsStringAsync();

            // Convert JSON string to a list of record objects
            List<BaselineRecord> records = JsonConvert.DeserializeObject<List<BaselineRecord>>(json);

            return records;
        }
    }
}
