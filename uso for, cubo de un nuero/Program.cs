using System;


namespace uso_for__cubo_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("introduce el " + i + " numero: ");
                num = double.Parse(Console.ReadLine());
                num = Math.Pow(num, 3);
                Console.WriteLine("el cubo es: " + num);
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();


        }
    }
}
