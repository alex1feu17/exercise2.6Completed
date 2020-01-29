using System;

namespace exercise2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau1 = new int[] { 1,3,-5,4 };
            int[] tableau2 = new int[] { 1,-4,-5,-2};

            int[] tableaureponse = {0,0,0,0 };


            for (int i = 0; i < 4; i++)
            {
                tableaureponse[i] = tableau1[i] * tableau2[i];
                Console.WriteLine(tableaureponse[i]);
            }

           
        }
    }
}
