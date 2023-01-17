using System.Collections.Generic;

namespace TesteTarget
{
    public class Fibonacci
    {
        public static string CalcFibonacci(int n)
        {
            string response = "";
            int a = 0;
            int b = 1;
            List<int> listNum = new();
            
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                listNum.Add(b);
            }
            bool result = listNum.Contains(n);

            if (result)
                response = $"Numero {n} informado pertence a sequência Fibonacci.";
            else
                response = $"Numero {n} informado não pertence a sequência Fibonacci.";

            return response;
        }
    }
}
