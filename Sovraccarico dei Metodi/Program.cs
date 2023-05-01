using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            int risultato = FaiSomma(10, 20);
            int risultato2 = FaiSomma(10, 20, 30);
        }

        static int FaiSomma(int num1, int num2)
        {
            return num1+ num2;
        }
        static int FaiSomma(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
