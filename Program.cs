using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorFinanciamento;
            int parcela;
            double resultado;

            
            DateTime DiaAtual = DateTime.Now;
            Console.WriteLine();

            Console.Write($"{DiaAtual}, digite o valor total do financiamento: ");
            valorFinanciamento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Por favor, digite o número de parcelas: ");
            Console.ResetColor();
            parcela = Convert.ToInt32(Console.ReadLine());

            DateTime DiaFinal = DateTime.Today.AddMonths(parcela);
            Console.WriteLine();

            resultado = valorFinanciamento / parcela;

            Console.WriteLine($"O valor das parcelas em {parcela} vezes, será de {resultado:C} até dia {DiaFinal}");


        }
    }
}
