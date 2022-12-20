namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLEASE ENTER THE FIRST NUMBER"); 
            int num1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("PLEASE ENTER THE SECOND NUMBER");
            int num2= int.Parse(Console.ReadLine());
            Console.WriteLine();
            int counter = 0;
            for (int i = num1; i <= num2; i++) 
            {
                for (int x = 1; x <= i; x++)  
                {
                    if (i % x == 0) 
                        counter++;
                }
                if (counter == 2)
                {
                    Console.WriteLine(i);
                    counter = 0;
                }
                else
                {
                    counter = 0;
                  
                }
            }

        }
    }
}