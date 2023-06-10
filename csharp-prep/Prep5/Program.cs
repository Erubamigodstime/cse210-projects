using System;

class Program
{
    static void Main(string[] args)
    {
         static void DisplayWelcome()
        {

            Console.WriteLine("welcome to the program");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What your favourite number ? ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static int SquareNumber( int number)
        {
            int squareNum = number*number;
            return  squareNum;
        }
        void  DisplayResult ( string name, int numbs)
        {
            Console.WriteLine($"{name}, the square of your number is {numbs}");
        }
        DisplayWelcome();
        string user  = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber( number );
        DisplayResult ( user, square);
    }
}