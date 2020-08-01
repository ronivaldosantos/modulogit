using System;

namespace Composition.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValeuPerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        { 
        }

        public HourContract(DateTime date, double valueperhour, int hours)
        {
            Date = date;
            ValeuPerHour = valueperhour;
            Hours = hours;        
        }

        public Double TotalValue()        
        {
            return Hours * ValeuPerHour;        
        }
        
    }
}
