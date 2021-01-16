using System;
using static System.Console;

namespace Bme121
{
    static class Program
    {
        static void Main( )
        {
            Write ( "Enter an integer of 3 or more: "); 
            int number=int.Parse( ReadLine( ) );
            
            
            for (int index = 2; index < number; index++)
            {
                int [] array = Calc(index, number);
                bool check = true;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i-1]) 
                    {
                    check = false;
                    }
                }
                if (check==true)
                {
                    Write ( " The base-10 number " + number + " expressed in base " + index + " is "  );
                
                    for ( int a = array.Length-1; a>= 0; a--)  
                    {
                        Write( array [a] );
                    
                        if (index > 9)
                        {
                            if ( a > 0)
                            {
                                Write (",");
                            }
                        }
                    }
                
                    WriteLine();
            
                }
            }
            
        }    
            

            
            
            static int[] Calc(int numberBase, int number)
            {
            
                if ( number < 0 )
                {
                    throw new ArgumentOutOfRangeException( nameof( number ),
                    "The number must be nonnegative." );
                }
            
                if (numberBase < 2 )
                {
                    throw new ArgumentOutOfRangeException( nameof( numberBase ),
                    "The base must be two or more." );
                }
                
                int numTwo= number;
                int counter=0;
                
                for(int index = number; index > 0; index = index/numberBase)
                {
                    counter++;
                }
            
                int[] array= new int[counter];
            
            
                for(int index = 0; index < array.Length; index++)
                {
                    array [index] = number % numberBase;
                    number = number / numberBase;
                }
            
            
                return array; 
            
            
            
            
            }
    }
}
