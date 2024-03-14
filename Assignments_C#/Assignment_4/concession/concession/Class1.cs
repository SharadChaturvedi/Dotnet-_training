using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concession
{
    public class TicketConcession
    {
        const int TOTAL_FARE = 1000;
        public void CalculateConcession(string name, int age)
        {



            if (age <= 5)
            {
                Console.WriteLine($"{name} - Age: {age} - Little Champs- Free Ticket");
            }
            else if (age > 60)
            {
                double concessionAmount = 0.3 * TOTAL_FARE;
                double calculatedFare = TOTAL_FARE - concessionAmount;
                Console.WriteLine($"{name} - Age: {age} - Senior Citizen - Calculated Fare: {calculatedFare}");
            }
            else
            {
                Console.WriteLine($"{name} - Age: {age} - Ticket Booked - Fare: {TOTAL_FARE}");
            }
        }
    }
}
