using System;

namespace DP3_Comportamental_04_Interator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate agg = new Aggregate();
            agg[0] = "Item 01";
            agg[1] = "Item 02";
            agg[2] = "Item 03";
            agg[3] = "Item 04";
            agg[4] = "Item 05";

            IIterator interador = agg.CreateIterator();
            
            Console.WriteLine("Interagindo com a coleção");

            object item = interador.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = interador.Next();
            }

        }
    }
}