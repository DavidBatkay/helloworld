using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PaymentMethods
{
    public abstract class PaymentSystem
    {
        public abstract void MakePayment(decimal total);
        
       
        
    }
    public class CardPayment : PaymentSystem
    {
        public override void MakePayment(decimal amount)
        {
            Console.WriteLine($"Plata online cu cardul: {amount} RON");
        }
    }

    public class PayPalPayment : PaymentSystem
    {
        public override void MakePayment(decimal amount)
        {
            Console.WriteLine($"Plata prin PayPal: {amount} RON");
        }
    }

    public class CryptoWalletPayment : PaymentSystem
    {
        public override void MakePayment(decimal amount)
        {
            Console.WriteLine($"Plata folosind un wallet crypto: {amount} RON");
        }
    }
}
