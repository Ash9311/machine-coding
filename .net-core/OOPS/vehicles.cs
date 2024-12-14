// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public class Car{
        public string Name {get; set;}
        public string Company {get;set;}
        
        public Car(string name,string company){
            this.Name = name;
            this.Company = company;
        }
    public void startEngine(){
        Console.WriteLine($"Engine of {Name} started");
    }
    }
    
    public class Suv:Car{
        public Suv(string name,string company):base(name,company){
            
        }
        
        public void startEngine(){
            Console.WriteLine($"{Name} engine started");
        }
        
        public void OpenSunroof(){
            Console.WriteLine("sunroof opened");
        }
    }
    
    public static void Main(string[] args)
    {
        Car indica = new Car("Indica","Tata");
        indica.startEngine();
        Suv fortuner = new Suv("Fortuner","Toyota");
        fortuner.OpenSunroof();
        fortuner.startEngine();
        Console.WriteLine ("Try programiz.pro");
    }
}
