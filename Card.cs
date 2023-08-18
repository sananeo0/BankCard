using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    public abstract class Card
    {
        public Card(string name,string surname ,long cardNumber ,int cvv,decimal balance)
        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            CVV= cvv;
            Balance = balance;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public long CardNumber { get;private  set; }
        public int CVV { get; private set; }
        public decimal Balance { get;private protected set; }

        public virtual void Medaxil(decimal value)
        {
            if (value <= 0) 
            {
                Console.WriteLine("The amount you included is incorrect");               
            }
         
            Balance += value;
        }
        public virtual void Mexaric(decimal value )
        {
            if (value > Balance) return;
            else if (value < 0) return;
            Balance -= value;
        }
        
        
                                                                             
    }
}
