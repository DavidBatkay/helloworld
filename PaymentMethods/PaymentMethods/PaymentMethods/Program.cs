namespace PaymentMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numele si totalul platii:");
            Order order = new Order
            {
                Customer = Console.ReadLine(),
                Date = DateTime.Now,
                Total = Convert.ToDecimal(Console.ReadLine())
            };
            Console.WriteLine("Introduceti metoda de plata:");
            string PaymentType=Console.ReadLine();
            PaymentSystem paymentSystem;
            switch (PaymentType)
            {
                case "card":
                    paymentSystem = new CardPayment();
                    break;
                case "paypal":
                    paymentSystem = new PayPalPayment();
                    break;
                case "crypto":
                    paymentSystem = new CryptoWalletPayment();
                    break;
                default:
                    Console.WriteLine("Metoda de plata invalida.");
                    return;
            }

            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.FulfillOrder(order, paymentSystem);
            Console.ReadLine();

        }
    }
}