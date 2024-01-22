namespace clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                var date = DateTime.Now;
                Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop/2);
                Console.WriteLine($"{date:HH:mm:ss}");
                Thread.Sleep( 1000 );
                
            }
        }
    }
}