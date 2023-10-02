using helloworld;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int i = 10;
            //Console.WriteLine(i);

            Person p1= new Person();
            p1.ReadName();
            p1.SayHello();

        }
    }
}
