using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorQRCode.Data
{
    public static class Settings
    {
        public const string BaseURL = "https://localhost:44362";
        public static string baseURL = $"{BaseURL}/api/DAthletes";
        public const int ManagementPin = 137;
        public const int QrcodePin = 549;
        public const int FetchDataPin = 787;
    }
}
