namespace KnapsackProblem
{
    using System;
using System.Collections.Generic;
using System.Linq;

    public class Program
    {
        private const int M = 20;
        private static readonly HashSet<Product> usedProducts = new HashSet<Product>();
        private static readonly Product[] products =
            {
                new Product("Beer", 3, 2),
                new Product("Vodka", 8, 12),
                new Product("Cheese", 4, 5),
                new Product("Nuts", 1, 4),
                new Product("Ham", 2, 3),
                new Product("Whiskey", 8, 13),
            };
        
        private static Product[] knapsack;
        private static int maxCost;
        
        public static void Main()
        {
            int index = 0;
            int currentCost = 0;
            int currentWeight = 0;
            int totalCosts = products.Sum(x => x.Cost);

            FindSolution(index, currentCost, currentWeight, totalCosts);

            PrintSolution();
        }

        private static void FindSolution(int index, int currentCost, int currentWeight, int totalCosts)
        {
            // When knapsack weight limit exceeded
            if (currentWeight > M)
            {
                return;
            }

            // When current knapsack products cost + sum of available products is less than maxCost
            if (currentCost + totalCosts < maxCost)
            {
                return;
            }

            // When reach to last available product
            if (index == products.Length)
            {
                if (currentCost > maxCost)
                {
                    maxCost = currentCost;

                    // Save current used products to knapsack
                    knapsack = usedProducts.ToArray();
                }

                return;
            }

            // Add product to used products
            usedProducts.Add(products[index]);

            // Add cost of current product to currentCost
            currentCost += products[index].Cost;

            // Add weight of current product to currentWeight
            currentWeight += products[index].Weight;

            // Remove cost of current product from sum of available products
            totalCosts -= products[index].Cost;

            // Try with next product
            FindSolution(index + 1, currentCost, currentWeight, totalCosts);

            // Remove current product from used products
            usedProducts.Remove(products[index]);

            // Remove cost of current product from currentCost
            currentCost -= products[index].Cost;

            // Remove weight of current product from currentWeight
            currentWeight -= products[index].Weight;

            // Try again after remove last added product
            FindSolution(index + 1, currentCost, currentWeight, totalCosts);

            // Add cost of current product to sum of available products
            totalCosts += products[index].Cost;
        }

        private static void PrintSolution()
        {
            Console.WriteLine("Optimal solution: \n");
            Console.WriteLine(string.Join("\n", knapsack.Select(x => x)));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Total Weight: {0}, Total Cost: {1:C}", knapsack.Sum(x => x.Weight), maxCost);
            Console.WriteLine();
        }
    }
}
