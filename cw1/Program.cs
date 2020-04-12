using System;


namespace cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            var recursionService = new RecursionOps();

            int[] example = new int[]{2,20,4,6,12};  
             
            Console.WriteLine(" Sum: " + recursionService.Sum(example));
            Console.WriteLine("Count: " + recursionService.Count(example));
            Console.WriteLine("Find biggest: " + recursionService.FindBiggest(example));

        }
    
        
    }
}
