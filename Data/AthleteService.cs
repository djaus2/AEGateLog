using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorQRCode.Data
{
    public class AthleteService
    {
        public List<Athlete> Athletes = new List<Athlete>();

        public void AddAthlete (string name, string phone, int pin)
        {
            Athlete athlete = new Athlete { Name = name, PhoneNumber = phone, TimeStamp = DateTime.Now , Pin = pin};
            Athletes.Add(athlete);
        }
        public Athlete[] GetAthletes()
        {
            return Athletes.ToArray<Athlete>();
            //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Athlete
            //{
   
            //}).ToArray());
        }
    }
}
