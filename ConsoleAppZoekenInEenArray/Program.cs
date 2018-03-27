using System;

namespace ConsoleAppZoekenInEenArray
{
    class Program
    {
        enum SearchState
        {
            StillSearching,
            NotFound,
            Found
        }

        static Random rndGen = new Random();
        const int aantalGetallen = 25;
        static int[] getallen = new int[aantalGetallen];
        


        static void Main(string[] args)
        {
            string invoer;
            
            Console.WriteLine("Geef een getal van 1-100:");
            invoer = Console.ReadLine();
            Console.WriteLine();

            VulGetallenArray();
            foreach (int getal in getallen)
            {
                Console.WriteLine(getal);
            }

            ZoekGetal(Convert.ToInt32(invoer));
            
        }

        static void VulGetallenArray()
        {
            for (int i = 0; i < aantalGetallen; i++)
            {
                getallen[i] = rndGen.Next(1, 100);
            }
        }

        static int? ZoekGetal(int x)
        {           
            int? index = null;
            SearchState state = SearchState.StillSearching;

            for (int i = 0; i < aantalGetallen; i++)
            {
                if (getallen[i] == x)
                {                   
                    index = i;                    
                }                               
            }            
        

            if (index != null)
            {
                state = SearchState.Found;
                Console.WriteLine($"Het getal {x} staat op index {index}.");
                Console.WriteLine($"Zoek staat: {state}.");
            }
            else
            {
                state = SearchState.NotFound;
                Console.WriteLine($"Het getal {x} staat niet in de array.");
                Console.WriteLine($"Zoek staat: {state}.");
            }

            return index;
        }
        


    }    

}     

    


