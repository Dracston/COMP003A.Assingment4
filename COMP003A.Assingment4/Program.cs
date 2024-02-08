namespace COMP003A.Assingment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop section \n Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Enter a positive whole number: ") ;
           
            int limit = Convert.ToInt32(Console.ReadLine());
            string[] output = new string[] { "#"};
            for (int i = 0; i < limit; i++)
            {
               for(int symbol=1; symbol<=limit; symbol++)
                {
                    Console.WriteLine($"{output}");
                }
                Console.WriteLine();

            }

        }
    }
}
