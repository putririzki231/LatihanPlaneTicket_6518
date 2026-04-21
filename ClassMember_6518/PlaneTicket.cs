using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember_6518
{
    internal class PlaneTicket
    {
        
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Cost { get; set; }
        public string Currency { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine($"Origin: {Origin}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Cost: {Cost} ({Currency})");

            if (Currency.ToUpper() == "USD")
            {
                double convertToRupiah = Cost * 15000;
                Console.WriteLine($"Convert to Rupiah: {convertToRupiah}");
            }
            else if (Currency.ToUpper() == "IDR")
            {
                double convertToDollar = Cost / 15000;
                Console.WriteLine($"Convert to Dollar: {convertToDollar}");
            }
            Console.WriteLine("-------------------------------");
        }
    }
}