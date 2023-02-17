using System;

namespace metoder
{

    class program
    {

        static void Main(string[]args)
        {
            
            Console.WriteLine("skriv in höjden");
            int höjden =int.Parse(Console.ReadLine());

            Console.WriteLine("skriv in bredden");
            int bredden =int.Parse(Console.ReadLine());

            int area = Area(bredden, höjden);

            Console.WriteLine("Area är" + area);
            
           
        }

        static int Area(int bredden, int höjden)
        {
            return bredden * höjden;
        }
    }
}
