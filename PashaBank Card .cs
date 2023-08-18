using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public class PashaBank_Card:Card
    {
        public PashaBank_Card(string name, string surname, long cardNumber, int cvv, decimal balance)
            :base(name, surname, cardNumber, cvv, balance)
        {         
        }
        public override void Mexaric(decimal value)
        {
            if (value > Balance) return;
            else if (value < 0) return;
            Balance -= value - value * 0.011m;
        }
        public override void Medaxil(decimal value)
        {
            if (value <= 0)
            {
                Console.WriteLine("The amount you included is incorrect");
            }
           
            Balance += value - value * 0.006m;
        }
    }
}
