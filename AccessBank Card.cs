using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public class AccessBank_Card:Card 
    {
        public AccessBank_Card(string name, string surname, long cardNumber, int cvv, decimal balance)
            : base(name, surname, cardNumber, cvv,balance)
        {              
        }
        public override void Mexaric(decimal value)
        {
            if (value > Balance) return;
            else if (value < 0) return;
            //decimal faizMexaric = 1.6m;
            Balance -= value + value * 1.6m / 100;
        }
        public override void Medaxil(decimal value)
        {
            if (value <= 0)
            {
                Console.WriteLine("The amount you included is incorrect");
            }
            //decimal faizMedaxil = 0.3m;
            Balance += value - value * 0.3m / 100;
        }
    }
}
