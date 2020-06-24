using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BlazorQRCode.Data
{
    public class Athlete
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Pin { get; set; }

        public string Date { get
            {
                string dat = TimeStamp.Date.ToString("D");
                return dat;
            }
        }

        public string Time
        {
            get
            {
                string tim = TimeStamp.ToLongTimeString(); 
                return tim;
            }
        }
    }
}
