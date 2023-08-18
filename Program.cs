using System.Security.Cryptography.X509Certificates;

namespace BankCard
{
    public class Program
    {
        static void Main(string[] args)
        {

            PashaBank_Card pasha =new PashaBank_Card("Senan", "Orucov", 1234567890123456, 996, 10);
            pasha.Medaxil(10);
            pasha.Mexaric(5);
            Console.WriteLine(pasha.Balance);


            AccessBank_Card access = new AccessBank_Card("Senan", "Orucov", 1234567890123456, 996, 10);
            access.Medaxil(10);
            access.Mexaric(5);
            Console.WriteLine(access.Balance);

            LeoBank_Card leo = new LeoBank_Card("Senan", "Orucov", 1234567890123456, 996, 10);
            leo.Medaxil(10);
            leo.Mexaric(5);
            Console.WriteLine(leo.Balance);



            Unibank_Card uni = new Unibank_Card("Senan", "Orucov", 1234567890123456, 996, 10);
            uni.Medaxil(10);
            uni.Mexaric(5);
            Console.WriteLine(uni.Balance);


        }
    }
}