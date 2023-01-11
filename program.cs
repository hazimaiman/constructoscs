using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            //object = a special method in class. same name as the classs name
            //          can be used to assign arguments to fields when creating object

            Car car1 = new Car("Proton", "Axia" , 2023, "Hitam");
            Car car2 = new Car("Honda", "Civil", 2023, "Putih");

            car1.Drive();   
            car2.Drive();


            Console.ReadKey();  
    
        }
        
        }
         class Car
        {
        String make;
        String model;
        int year;
        String color;

        public Car(String make,String model, int year,String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color; 
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model} . ");
        }

        }

    }




/*  Human human1 = new Human("Aiman", 24);
  Human human2 = new Human("Hazim", 25);

  human1.Eat();
  human1.Sleep();

  human2.Eat();
  human2.Sleep();*/


/*  class Human
{
    public String name;
    public int age;

    public Human(String name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Eat()
    {
        Console.WriteLine(name + " is eating");
    }
    public void Sleep()
    {
        Console.WriteLine($"{name} is sleeping for {age}");
    }*/





