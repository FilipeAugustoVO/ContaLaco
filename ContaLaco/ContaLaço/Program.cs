using System;

namespace ContaLaço
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 102; i++)
            {
                int val = i % 2 == 1 ? i * -1 : i;
                Console.WriteLine(val);
                // integral val igual i divido por 2, resto é igual 1, condição se i multiplocado por - 1 ou condição é igual i; 
                // pergunta pro programa se o resto da conta é igual um, e ai se i é i multiplocado por -1 ou se i é i
            }
        }
    }
}
