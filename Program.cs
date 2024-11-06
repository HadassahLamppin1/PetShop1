using System;
using System.Text.Json;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("press 1 to add a product");
            Console.WriteLine("type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {

                if (Int32.Parse(userInput.ToLower()) == 1)
                {
                    Console.WriteLine("hurray you selected 1, Lets create a new product object! Do you want to create a dogleash or catfood product?");
                    string productChoice = Console.ReadLine();
                    if (productChoice.ToLower() == "dogleash")
                    {
                        Console.WriteLine("We are making a new dogLeash product, what is the length in inches?");
                        DogLeash dogleash = new DogLeash();
                        dogleash.LengthInches = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("what kind of material?");
                        dogleash.material = Console.ReadLine();
                        Console.WriteLine("what price would you like to make this dogleash for?");
                        dogleash.Price = Decimal.Parse(Console.ReadLine()); 
                        Console.WriteLine($"the dog leash is {dogleash.LengthInches} long and is made of {dogleash.material} and the price is {dogleash.Price}");
                       // Console.WriteLine(JsonSerializer.Serialize(dogleash));
                        Console.WriteLine("now that we have made a product, do you wish to make another?");
                        
                    }
                    else if (productChoice.ToLower() == "catfood")
                    {
                        Console.WriteLine("we are making catfood! How many weight in lbs should the cat food be?");
                        CatFood catfood = new CatFood();
                        catfood.WeightPounds = double.Parse(Console.ReadLine());
                        Console.WriteLine("Is this food specifically meant for kittens? true or false"); // how to make this work with yes or no? if statement? 
                        catfood.KittenFood = bool.Parse(Console.ReadLine());
                        Console.WriteLine("what is the Name of this cat food?");
                        catfood.Name = Console.ReadLine();
                        Console.WriteLine($"congrats! you have made a new cat food product with {catfood.WeightPounds} for weight, and it is {catfood.KittenFood} kitten food and the name is {catfood.Name}");
                    }
                    else
                        Console.WriteLine("please try again and input dogleash or catfood"); 

                }
                else
                {
                    Console.WriteLine("please input either a 1 or type 'exit'");
                }


                Console.WriteLine("press 1 to add a product");
                Console.WriteLine("type 'exit' to quit");

                userInput = Console.ReadLine();
            }

        }
    }
}