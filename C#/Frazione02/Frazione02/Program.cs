using System;

namespace Frazione02
{
    class Program
    {
        static void Main(string[] args)
        {
            CFrazione f1, f2, f3, f4, f5, r;
            f1 = new CFrazione();
            f2 = new CFrazione(7, 8);
            f3 = new CFrazione(4, 9);
            f4 = new CFrazione(34, 78);
            f5 = new CFrazione(1, 5);
            r = CFrazione.somma(f1, f2);
            r = f1.somma(f2);

            r = ((f1 + f2) * f3) / (f4 - f5);

            Console.WriteLine("Il risultato è: {0}", r);           
                
            Console.WriteLine("Hello World!");
        }
    }
}
