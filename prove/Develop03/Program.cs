using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference reference = new Reference("Alma", 2, 6, 7);
        Scripture scripture = new Scripture( reference, "And it came to pass that the avoice of the people came against Amlici, that he was not made king over the people. Now this did cause much joy in the hearts of those who were against him; but Amlici did stir up those who were in his favor to anger against those who were not in his favor.");
                                            
        
        while (userInput!= "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(" ");
            
            Console.WriteLine("Press Enter to continue or type 'quit' to finish ");
            userInput = Console.ReadLine();

            if(scripture.IsCompletelyHidden())
                break;

            for(int i = 0; i < 3; i++)
            {
                scripture.HideWords();
                if(scripture.IsCompletelyHidden())
                    break;
            }
        }
    }
}