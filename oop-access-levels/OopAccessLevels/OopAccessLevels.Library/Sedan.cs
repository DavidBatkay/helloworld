namespace OopAccessLevels.Library
{
    public class SedanCar : Car
    {
        void SedanPrintManufacturer()
        {
            //Car private field not accessible in child class
            //from within the same project
            //Console.WriteLine(manufactuer);
            
            Console.WriteLine(model);
        }
    }
}
