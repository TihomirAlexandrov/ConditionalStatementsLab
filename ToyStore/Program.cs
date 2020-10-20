using System;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            double doll = 3;
            double teddyBear = 4.10;
            double minion = 8.20;
            double truck = 2;

            double priceOfVacation = double.Parse(Console.ReadLine());
            int amountOfPuzzles = int.Parse(Console.ReadLine());
            int amountOfDolls = int.Parse(Console.ReadLine());
            int amountOfTeddyBears = int.Parse(Console.ReadLine());
            int amountOfMinions = int.Parse(Console.ReadLine());
            int amountOfTrucks = int.Parse(Console.ReadLine());

            int amountOfOrderedToys = amountOfDolls + amountOfMinions + amountOfPuzzles + amountOfTeddyBears + amountOfTrucks;

            double priceOfPuzzles = amountOfPuzzles * puzzle;
            double priceOfDolls = amountOfDolls * doll;
            double priceOfTeddyBears = amountOfTeddyBears * teddyBear;
            double priceOfMinions = amountOfMinions * minion;
            double priceOfTrucks = amountOfTrucks * truck;

            double totalPrice = priceOfDolls + priceOfMinions + priceOfPuzzles + priceOfTeddyBears + priceOfTrucks;

            double discount = 0;
            
            if (amountOfOrderedToys >= 50)
            {
                discount = totalPrice * 0.25;
            }
            
            double totalSum = totalPrice - discount;
            double rent = totalSum * 0.1;
            double profit = totalSum - rent;
            double finalSum = profit - priceOfVacation;

            if (profit >= priceOfVacation)
            {
                Console.WriteLine($"Yes! {finalSum:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(finalSum):f2} lv needed.");
            }
      
        }
    }
}