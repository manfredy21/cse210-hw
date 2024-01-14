using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("what is the magic number?");
        //string magicNumber = Console.ReadLine();
        //int number = int.Parse(magicNumber);
        Random randomNumber = new Random();
        int number = randomNumber.Next(1,101);
        

        int guess = 0;

        while (guess != number){
            Console.Write("Guess the number");
            guess = int.Parse(Console.ReadLine());

            if(number > guess){
                Console.WriteLine("The number is to lower than the magic number");
            }
            else if (number < guess)
            {
                Console.WriteLine("The number is to higher than the magic number");
            }
            else
            {
                Console.WriteLine("You guess the number!");
            }
        }

    }
}