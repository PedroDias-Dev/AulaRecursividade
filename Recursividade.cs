using System;

namespace AulaRecursividade
{
    public class Recursividade
    {
        public void GerarSeqFibonnacci(int num1, int num2, int vezes){
            if(vezes > 0){
                System.Console.WriteLine(num1);
                GerarSeqFibonnacci(num2, num1 + num2, vezes - 1);
            }
        }
        public int GerarFatorial(int numero){
            if (numero == 1){
                return 1;
            }
            else{
                return numero * GerarFatorial(numero - 1);
            }
        }
    }
}