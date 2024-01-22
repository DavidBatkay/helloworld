namespace play
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a single character: ");
            string x=Console.ReadLine();
            if (x.Length == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{x} ");
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == 0 || j == 2)
                        {
                            Console.Write($"{x} ");
                        }
                        else
                            Console.Write("  ");
                    }
                    Console.WriteLine();
                }
            }
            else throw new ArgumentException("Input was not a single character");

            Console.ReadLine();
        }
    }
}