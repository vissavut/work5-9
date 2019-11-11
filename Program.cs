using System;
using System.Collections.Generic;
using System.Linq;


namespace test
{
    
   public class Program
    {
        static void Main(string[] args)
        
        {        
            IEnumerable<int> setdata = null;
                                                    
            string result = null;                                          
            string myString = string.Empty;
            int myInt;
           
            Console.WriteLine("Max Numbers");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Key Numbers");
            for (int i = 0; i < max; i++)
            {   
               myString = Console.ReadLine();                                   
               var array = myString.ToCharArray() .Where(x => int.TryParse
                            (x.ToString(), out myInt))
                            .Select(x => int.Parse
                            (x.ToString())).ToArray();                        
                var input = new run();        
                setdata = input.Homework13(array);
                result+=" ";
                foreach (var item in setdata)
                result+=item;
            }
              Console.WriteLine(" Double 99 "); 
              Console.WriteLine(result); 
             
              
        }
    }
}          
          
              

                  
            
                 
        
                

 
                    
                     
                    
                     
                      
              

                     
                     
                    
                 

                   


           
           

            
    
   
           
         
     
          
     
        
    
     
 


