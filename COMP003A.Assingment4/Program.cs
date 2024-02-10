namespace COMP003A.Assingment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop section \n Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Enter a positive whole number: ");

            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i = 0; i < limit; i++)
            {

                Console.Write($"{output}");

                Console.WriteLine();
                output += "#";

            }
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach section \n Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            foreach (string f in friends)
            {
                Console.WriteLine($"\t{f}\n");
            }
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while section \n Output 1-20 \n If the number is divisible by 2, output Foo \n If the number is divisible by 5, output Bar \n If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));
            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 % 2== 0)
                {
                    if(counter2 % 5 == 0)
                    {
                        Console.WriteLine("FooBar");
                    }
                    else {
                        Console.WriteLine("Foo");
                    }
                    
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                
                
                   
                
                else { Console.WriteLine($"{counter2}"); }
                counter2++;

            }



        }
    }
}
