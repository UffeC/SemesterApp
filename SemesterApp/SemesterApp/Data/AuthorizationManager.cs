using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SemesterApp.Data
{
    class AuthorizationManager
    {
        public async Task<bool> Authorize(string enteredId)
        {
            // Set initial authorization status
            bool authorizationStatus = false;

            // Get the list of record objects
            List<BaselineRecord> baselineRecords = await RedCap.GetBaselineRecords();

            // Search for entered id in record list and set authorization status if found
            foreach (BaselineRecord baselineRecord in baselineRecords)
            {
                if (baselineRecord.record_id == enteredId)
                {
                    authorizationStatus = true;
                    break;
                }
            }

            return authorizationStatus;
        }
    }
}
