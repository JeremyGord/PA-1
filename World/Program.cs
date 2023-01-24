//Jeremy Gordon
//1/24/23
//World
//To show inheritance, abstract and concrete class implementation. Allow the user to add animals
//age animals make animals make noise then allow the user to exit. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace World
{
    public class Menu
    {//Provide a class to call the menu
        public void DisplayMenu()
        {
            Console.WriteLine("Input 1 to Add a Animal");
            Console.WriteLine("Input 2 to Display Animal Info");
            Console.WriteLine("Input 3 To Age up the Animal");
            Console.WriteLine("Input 4 to Make Animal Noise");
            Console.WriteLine("Input 5 to Quit");
        }
    }
    public class World
    {
        static void Main(string[] args)
        {//Declare public varibles
            Menu m = new Menu();
            int Choice, animalChoice;
            string animalName;
            int animalAge;
            double animalWeight;
            m.DisplayMenu();
            Choice = Convert.ToInt32(Console.ReadLine());
            List<Animal> myList = new List<Animal>();
            while (Choice != 5)
            {
                if (Choice == 1)
                {
                    Console.WriteLine("Input Name of Animal");
                    animalName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Input Age of Animal");
                    animalAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Weight of Animal");
                    animalWeight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter 1 for  Cat, 2 for Cassowary, 3 for Frog");
                    animalChoice = Convert.ToInt32(Console.ReadLine());
                    if (animalChoice == 1)
                    {
                        myList.Add(new Cat(animalName, animalAge, animalWeight));
                    }
                    else if (animalChoice == 2)
                    {
                        myList.Add(new Cassowary(animalName, animalAge, animalWeight));
                    }
                    else if (animalChoice == 3)
                    {
                        myList.Add(new Frog(animalName, animalAge, animalWeight));
                    }
                    else
                    {
                        Console.WriteLine("Animal is not found, restarting menu!");
                    }
                    m.DisplayMenu();
                    Choice = Convert.ToInt32(Console.ReadLine());
                }
                else if (Choice == 2)
                {
                    foreach (Animal d in myList)
                    {
                        d.Printinfo();
                    }
                    m.DisplayMenu();
                    Choice = Convert.ToInt32(Console.ReadLine());
                }
                else if (Choice == 3)
                {
                    foreach (Animal d in myList)
                    {
                        d.AgeUp();
                    }
                    m.DisplayMenu();
                    Choice = Convert.ToInt32(Console.ReadLine());
                }
                else if (Choice == 4)
                {
                    foreach (Animal d in myList)
                    {
                        d.MakeNoise();
                    }
                    m.DisplayMenu();
                    Choice = Convert.ToInt32(Console.ReadLine());
                }
                else if (Choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect Choice\nPlease try again.");
                    m.DisplayMenu();
                    Choice = Convert.ToInt32(Console.ReadLine());
                }

            }


        }
    }
    abstract class Animal
    {
        protected int Age;
        protected string Name;
        protected double Weight;
        protected string Noise;
        public abstract void Printinfo();
        public abstract int AgeUp();
        public abstract void MakeNoise();
    }
    class Cat : Animal
    {
        public Cat()
        {
            this.Name = "NA";
            this.Age = 99;
            this.Weight = 99.99;
            this.Noise = "Meow";
        }
        public Cat(string n, int a, double w)
        {
            this.Name = n;
            this.Age = a;
            this.Weight = w;
            this.Noise = "Meow";
        }

        public override int AgeUp()
        {
            return this.Age++;
        }
        public override void MakeNoise()
        {

            Console.WriteLine(this.Name + " makes the noise " + this.Noise);
        }
        public override void Printinfo()
        {
            Console.WriteLine("Name: " + this.Name + "\nage: " + this.Age + "\nWeight In Pounds: " + this.Weight);
        }
    }
    class Cassowary : Animal
    {
        public Cassowary()
        {
            this.Name = "NA";
            this.Age = 99;
            this.Weight = 99.99;
            this.Noise = "Booming Rumble";
        }
        public Cassowary(string n, int a, double w)
        {
            this.Name = n;
            this.Age = a;
            this.Weight = w;
            this.Noise = "Booming Rumble";
        }
        public override int AgeUp()
        {
            return this.Age++;
        }
        public override void MakeNoise()
        {

            Console.WriteLine(this.Name + " makes the noise " + this.Noise);
        }
        public override void Printinfo()
        {
            Console.WriteLine("Name: " + this.Name + "\nage: " + this.Age + "\nWeight In Pounds: " + this.Weight);

        }
    }
    class Frog : Animal
    {
        public Frog()
        {
            this.Name = "NA";
            this.Age = 99;
            this.Weight = 99.99;
            this.Noise = "Ribbit Ribbit";
        }
        public Frog(string n, int a, double w)
        {
            this.Name = n;
            this.Age = a;
            this.Weight = w;
            this.Noise = "Ribbit Ribbit";
        }
        public override int AgeUp()
        {
            return this.Age++;
        }
        public override void MakeNoise()
        {

            Console.WriteLine(this.Name + " makes the noise " + this.Noise);
        }
        public override void Printinfo()
        {
            Console.WriteLine("Name: " + this.Name + "\nage: " + this.Age + "\nWeight In Pounds: " + this.Weight);

        }
    }
}
