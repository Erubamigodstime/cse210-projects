using System;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        int magNumb = 100;
        int number = 400;
        Random randomGenerator = new Random();
        number = randomGenerator.Next(0, 5);
        
        while (magNumb != number)
        {            
            Console.Write("What is the Magic Number? ");
            magNumb = int.Parse(Console.ReadLine());

            if (magNumb > number)
            {
                Console.WriteLine("guess lower");
            }
            else if (magNumb < number)
            {
                Console.WriteLine("guess higher");
            }
            else
            {
                Console.WriteLine("you guessd right");
                Console.WriteLine($"you guesed {magNumb} ");
                Console.WriteLine($" and the magic number is  {number} ");
            }
            Console.WriteLine("");
            Console.WriteLine($"{number}");
            counter ++;

        }
       
       Console.WriteLine("");
       Console.WriteLine($"it took you {counter} times to guess right ");

    }
}