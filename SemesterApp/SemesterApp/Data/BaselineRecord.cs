using System;
using System.Collections.Generic;
using System.Text;

namespace SemesterApp.Data
{
    class BaselineRecord
    {
        public string record_id { get; set; }
        public string randomisation_group { get; set; }
        public string redcap_event_name { get; set; }
        public string use_app { get; set; }
        public string date_intervention { get; set; }
        public string traeningsklinik { get; set; }
        public string weekly_survey_stop { get; set; }
        public string opstart_intervention_anne_marie_rosager_complete { get; set; }
    }
}
