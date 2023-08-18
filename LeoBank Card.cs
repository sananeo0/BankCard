using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public class LeoBank_Card:Card
    {
        public LeoBank_Card( string name,string surname, long cardNumber, int cvv, decimal balance) 
            :base(name, surname, cardNumber, cvv, balance)
        {
        }


    }
}
