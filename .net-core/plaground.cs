// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;
public class HelloWorld
{
    private static string naam = "ash";
    public class Person{
        string Name="";
        int age;
        public Person(string Name,int age){
            this.Name = Name;
            this.age = age;
        }
        public void breathe(){
            Console.WriteLine("person is breathing");
        }
    }
    
    public class SoftwareEngineer:Person{
         string Name="";
        int age;
        public SoftwareEngineer(string Name,int age):base(Name,age){
            this.Name = Name;
            this.age = age;
        }
        public void code(){
            Console.WriteLine("software engineer is coding");
        }
        public void breathe(){
            Console.WriteLine("swe is breathing");
        }
    }
    public static void Main(string[] args)
    {
        Person p = new Person("ash",26);
        p.breathe();
        
        SoftwareEngineer swe = new SoftwareEngineer("ashutosh",25);
        swe.code();
        swe.breathe();
        
        Console.WriteLine(naam);
        List<int> lst = new List<int>{4};
        Dictionary<int,string>dct = new Dictionary<int,string>();
        lst.Add(7);
        dct.Add(7,"Thala");
        Console.WriteLine(dct[7]);
        foreach(KeyValuePair<int,string> entry in dct){
            Console.WriteLine("{0},{1}",entry.Key,entry.Value);
        }
        
        Console.WriteLine ("Try programiz.pro");
    }
}

---------------------
  person is breathing
software engineer is coding
swe is breathing
ash
Thala
7,Thala
Try programiz.pro
