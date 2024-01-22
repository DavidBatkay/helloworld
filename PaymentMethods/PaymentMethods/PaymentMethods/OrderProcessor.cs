using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethods
{
    public class OrderProcessor
    {
        public void FulfillOrder(Order order, PaymentSystem paymentSystem)
        {
            Console.WriteLine($"Comanda pentru {order.Customer}, in data de {order.Date}, in valoare de {order.Total} RON.");

            paymentSystem.MakePayment(order.Total);

            Console.WriteLine("Comanda a fost procesata cu succes!");
        }
    }
}