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
    public class D2Athlete
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

        [Column("Mode")]
        [JsonPropertyName("Mode")]
        public int Mode { get; set; } = 1;

        //MS SQL serer truncates decimal to 2 decimal digits
        //Ref: https://mattferderer.com/entity-framework-no-type-was-specified-for-the-decimal-column
        //Note stored decimals here hae been multipled by 1000000

        [Column("Latitude",TypeName = "decimal(18,2)")]
        [JsonPropertyName("Latitude")]
        public decimal? Latitude { get; set; } = 1;

        [Column("Longitude", TypeName = "decimal(18,2)")]
        [JsonPropertyName("Longitude")]
        public decimal? Longitude { get; set; } = 1;

        [Column("Accuracy", TypeName = "decimal(18,2)")]
        [JsonPropertyName("Accuracy")]
        public decimal? Accuracy { get; set; } = 1;



        [Column("Pin")]
        [JsonPropertyName("Pin")]
        public int Pin { get; set; }

        public D2Athlete() {  }

        public D2Athlete(DateTime date ) { Date = date; }

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
