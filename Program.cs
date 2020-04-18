using System;

namespace PR1_Backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            // - [C] Cuerda: 1Kg
            // - [A] Botella de agua: 1.1Kg
            // - [M] Manzana: 250g
            // - [P] Pan: 70g
            // - [B] Brújula: 300g -> 350g (*)
            // - [PB] Papel de baño: 320g
            // - [PL] Plátano: 80g

            Backpack backpack = new Backpack();

            BackpackItem rope = new BackpackItem("C", "Rope", 1000);
            rope.SetVerticalSize(2);
            BackpackItem waterBottle = new BackpackItem("A", "Water bottle", 1100);
            waterBottle.SetVerticalSize(2);
            BackpackItem apple = new BackpackItem("M", "Apple", 250);
            BackpackItem bread = new BackpackItem("P", "Bread", 70);
            BackpackItem compass = new BackpackItem("B", "Compass", 350);
            BackpackItem toiletPaper = new BackpackItem("PB", "Toilet paper", 320);
            BackpackItem banana = new BackpackItem("PL", "Banana", 80);
            banana.SetVerticalSize(2);

            backpack.AddItemAtPosition(rope, 2, 0);

            backpack.AddItemAtPosition(bread, 0, 1);
            backpack.AddItemAtPosition(apple, 1, 1);
            backpack.AddItemAtPosition(compass, 2, 1);

            backpack.AddItemAtPosition(banana, 1, 2);
            backpack.AddItemAtPosition(toiletPaper, 2, 2);

            backpack.AddItemAtPosition(waterBottle, 2, 3);

            Console.WriteLine(backpack.CheckWeights());
            backpack.PrintContent();

        }
    }
}
