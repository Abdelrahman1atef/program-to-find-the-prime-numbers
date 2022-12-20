using System;

    public class Program
    {
        public static void Main()
        {

            int SN, EN, num, i, ctr;

            Console.Write("\n\n");
            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input starting number of range: ");
            SN = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            EN = int.Parse(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", SN, EN);

            for (num = SN; num <= EN; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                      if (num % i == 0)
                      {
                          ctr++;
                          break;
                      }
                 }

                 if (ctr == 0 && num != 1)
                 Console.Write( "{0} ",num);
                
             }
                Console.Write("\n");

                Console.ReadKey();

            

        }
    }


            


        
    

