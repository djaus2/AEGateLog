using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorQRCode.Data
{
    public class DAthlete
    {
        [Key]
        [Column("Id")]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [Column("PhoneNumber")]
        [Required]
        [JsonPropertyName("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Email")]
        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [Column("DTicks")]
        [JsonPropertyName("DTicks")]
        public long DTicks { get; set; }



        [Column("Pin")]
        [JsonPropertyName("Pin")]
        public int Pin { get; set; }

        public DAthlete() {  }

        public DAthlete(DateTime date ) { Date = date; }

        [NotMapped]
        [JsonIgnore]
        public DateTime Date
        {
            get { return new DateTime(DTicks); }
            set { DTicks = value.Ticks; }
        }

        [NotMapped]
        [JsonIgnore]
        public string _Date
        {
            get
            {
                return  Date.ToString("yyyy-MM-dd");
            }
        }
        [NotMapped]
        [JsonIgnore]
        public string _Time
        {
            get
            {
                return Date.TimeOfDay.ToString();
            }
        }

    }
}
