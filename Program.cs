using System;

namespace AulaRecursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();

            rec.GerarSeqFibonnacci(0, 1, 20);

            System.Console.WriteLine( rec.GerarFatorial(2) );

        }
    
    }
}
