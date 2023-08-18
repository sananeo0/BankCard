using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public class Unibank_Card:Card
    {
       
        public Unibank_Card(string name, string surname, long cardNumber, int cvv, decimal balance)
            :base(name, surname, cardNumber, cvv, balance)
        {             
        }
        public override void Mexaric(decimal value)
        {
            if (value > Balance) return;
            else if (value < 0) return;
            //decimal faizMexaric = 1.5m;
            Balance -= value + value * 1.5m / 100;
        }

    }
}
