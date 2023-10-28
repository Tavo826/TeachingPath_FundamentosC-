namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            while (contador <= 100)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }
            Console.ReadLine();
        }
    }
}