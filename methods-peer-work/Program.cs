using System;

namespace methods_peer_work
{
    internal class Program
    {
        //partner A add method
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        //partner B subtract method
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static void Main(string[] args)
        {
            //initialize numbers
            int presleyFavoriteNumber = 4;
            int pearlFavoriteNumber = 27;


            //Start of the actual program
            Console.WriteLine("Pearl's favorite number is " + pearlFavoriteNumber + ".");
            Console.WriteLine("Presley's favorite number is " + presleyFavoriteNumber + ".");



            //Call Add method
            int sum = Add(pearlFavoriteNumber, presleyFavoriteNumber);
            Console.WriteLine("When you add Pearl's favorite number and Presley's favorite number, you get " + sum + "!");

            //Call Subtract Method
            int answer = Subtract(pearlFavoriteNumber, presleyFavoriteNumber);
            Console.WriteLine("When you subtract Pearl's Favorite number and Presleys Favorite Number, you get " + answer + "!");

        }
    }
}

