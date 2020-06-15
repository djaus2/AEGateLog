using System;
using System.Data;

namespace BlazorQRCode.Data
{
    public class Athlete
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Pin { get; set; }
    }
}
