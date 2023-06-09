using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("============== Grade program ==============");
        Console.Write(" Enter your Grade Percentage ");
        string userPercentage = Console.ReadLine();
        int percentage  = int.Parse(userPercentage);

        string letter = "";        
        if( percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"your percentage is  {percentage}");
        Console.WriteLine("your grade is " +  letter);
        if (percentage >= 70)
        {
           Console.WriteLine("Congratulations you did well and you passed your exams");
        }
        else
        {
            Console.WriteLine("you failed this Exam try again later ");
        }
      

       
       









    }
}