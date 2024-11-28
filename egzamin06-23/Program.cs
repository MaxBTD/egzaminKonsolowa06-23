namespace egzamin06_23
{
    internal class Program
    {
        private static void tableFill(bool[] A)
        {
            for (int i = 0; i < A.Count(); i++)
                A[i] = true;
        }

        static void Main(string[] args)
        {
            const int n = 100;
            bool[] A = new bool[n];
            tableFill(A);
            
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (A[i]) {
                    for(int j = 2; j < n; j++)
                    {
                        if(j*i < n)
                            A[j * i] = false;
                    }
                }
            }

            for(int i = 2; i < A.Count(); i++)
            {
                if (A[i]) {
                    Console.WriteLine($"{i} - Liczba jest pierwsza");
                } else
                {
                    Console.WriteLine($"{i} - Liczba nie jest pierwsza");
                }
                
            }
        }
    }
}
