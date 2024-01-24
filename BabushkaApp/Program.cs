
namespace Babushka
{
    class Program
    {

        public static void babushka(int BabushkaNumber)
        {
            Console.WriteLine("I opened babushka number "+BabushkaNumber);
            if (BabushkaNumber == 1) // תנאי עצירה
            {
                Console.WriteLine("Found the smallest babushka!");
                Console.WriteLine("I closed the smallest babushka!");
                return;
            }
            babushka(BabushkaNumber - 1); // קריאה רקורסיבית
            Console.WriteLine("I closed babushka number " + BabushkaNumber);
        }

        static void Main(string[] args)
        {
            int SetSize = 7;
            babushka(SetSize);
        }
    }
}
