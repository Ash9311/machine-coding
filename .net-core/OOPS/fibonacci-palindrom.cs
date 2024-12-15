// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public void something(){
        Console.WriteLine("something");
    }
    
    
    public bool isPalindrome(string str){
          int j = str.Length-1;
          something();
        for(int i=0;i<str.Length/2;i++){
            if(str[i]!=str[j]){
                return false;
            }
            j--;
        }
        return true;
    }
    
    public static void fibonacci(int n){
        int[] fib = new int[n];
        fib[0]=0;
        fib[1]=1;
        for(int i=2;i<n;i++){
            fib[i] = fib[i-1]+fib[i-2];
        }
        foreach(var i in fib){
            Console.WriteLine(i);
        }
        
    }
    
    public static void Main(string[] args)
    {
        HelloWorld hw = new HelloWorld();
        hw.something();
        string str = "racecar";
        fibonacci(7);
        if(hw.isPalindrome(str)){
            Console.WriteLine("palindrome");
        }
        else{
            Console.WriteLine("not a palindrome");
        }
    }
}
