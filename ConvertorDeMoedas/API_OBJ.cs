using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorDeMoedas
{
    public class API_Obj
    {
        public string result { get; set; }
        public string time_last_update_unix { get; set; }
        public string time_last_update_utc { get; set; }
        public string time_next_update_unix { get; set; }
        public string time_next_update_utc { get; set; }
        public string base_code { get; set; }
        public ConversionRate conversion_rates { get; set; }

    }
}
