using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("please enter the first number:");
            int a=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int b=Int32.Parse(Console.ReadLine());

           Console.WriteLine("What you want to do? Add:press 1; Substract: press 2; Multiply: press 3; Divide: Press 4.");
            int c=Int32.Parse(Console.ReadLine());
            if(c==1){Add(a,b);}
            else if(c==2){Subtract(a,b);}
             else if(c==3){Multiply(a,b);}
                    
            else{Divide(a,b);}
        }
    
        public static void Add(int a, int b){
  
        Console.WriteLine($"The sum is:{a+b}");

         }



         public static void Subtract(int a, int b){

        Console.WriteLine($"The result of subtraction is:{a-b}");

         }

         public static void Multiply(int a, int b){
 
        Console.WriteLine($"The production is:{a*b}");

         }

        public static void Divide(int a,int b){
        int result=0;
         
           try{
               result= a/b;
}
            catch(DivideByZeroException e){
                 Console.WriteLine("Exception caught: {0}", e);

}
            finally{
                Console.WriteLine($"The result is {result}");

}                  
         }
    }
}
