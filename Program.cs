using System;
using System.Collections.Generic;


namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            CoinToss();
            TossMultipleCoins(50);
            Names();
        }

        public static void RandomArray(){

            Random random = new Random();

            int[] numarray = new int[10];

            int i = 0;

            while(i < 10){
                numarray[i] = random.Next(5, 25);
                i++;
            }

            int min = numarray[0];
            int max = numarray[0];
            int sum = 0;

            foreach(int j in numarray){
                sum += j;
                if(j > max){
                    max = j;
                }
                if(j < min){
                    min = j;
                }
            }

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Sum: " + sum);
        }

        public static string CoinToss(){

            Random random = new Random();
            int toss = random.Next(1,3);

            string result = null;
            Console.WriteLine("Flipping a coin!");

            if(toss == 1){
                result = "heads";
            }
            else{
                result = "tails";
            }
            
            Console.WriteLine(result);
            return result;
        }

        public static double TossMultipleCoins(int number){

            int i = 0;
            int headscount = 0;

            while(i < number){

                string toss = CoinToss();

                if(toss == "heads"){
                    headscount++;
                }
                i++;
            }

            double outcome = ((double)headscount / (double)number);
            Console.WriteLine("Ratio of heads: " + outcome);
            return outcome;
        }

        public static List<string> Names(){

            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            Random random = new Random();

            void Shuffle(){

                for(int i = 0; i < names.Count; i++){
                    string store = names[i];
                    int roll = random.Next(0,5);
                    names[i] = names[roll];
                    names[roll] = store;
                }
            }


            int j = 0;
            while(j < 10){
            Shuffle();
            j++;
            }

            int k = 0;
            while(k < names.Count){
                Console.Write(k + ": " + names[k] + " ");

                k++;
            }


            for(int lengthcheck = 0; lengthcheck < names.Count; lengthcheck++){
                if(names[lengthcheck].Length > 5){
                    names.Remove(names[lengthcheck]);
                    lengthcheck--;
                }
            }
            Console.WriteLine("Names longer than 5 letters removed.");
            return names;
        }

// Names
// Build a function Names that returns a list of strings.In this function:
// Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
// Shuffle the list and print the values in the new order
// Return a list that only includes names longer than 5 characters
    }
}
