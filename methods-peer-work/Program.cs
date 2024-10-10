using System;

namespace methods_peer_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int presleyFavoriteNumber = 0;
                int pearlFavoriteNumber = 0;
                
                //initialize favorite numbers
                pearlFavoriteNumber = 27;
                presleyFavoriteNumber = 0;

                //Start of the actual program
                Console.WriteLine("Pearl's favorite number is " + pearlFavoriteNumber + ".");
                Console.WriteLine("Presley's favorite number is " + presleyFavoriteNumber + ".");


                //Create partner B Subtract method
                static int Subtract(int num1, int num2)
                {
                    int answer = 0;
                    answer = num1 - num2;
                    return answer;
                }
                //Call Add method
                int sum = Add(pearlFavoriteNumber, presleyFavoriteNumber);
                Console.WriteLine("When you add Pearl's favorite number and Presley's favorite number, you get " + sum + "!");
            }


            //Create partner A Add method
            static int Add(int num1, int num2)
            {
                int answer = 0;
                answer = num1 + num2;
                return answer;
                }
        }
    }

