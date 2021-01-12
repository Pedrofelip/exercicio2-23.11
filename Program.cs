using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            float quantidadeC;
            float desconto;
            float precoG = 5.3f;
            float precoA = 4.9f;


            Console.WriteLine("Qual tipo de combustivel você deseja?\nG-gasolina\nA-alcool");
            tipo = Console.ReadLine();
            Console.WriteLine("Quantidade de combustivel(litros):");
            quantidadeC = float.Parse(Console.ReadLine());

            

            switch (tipo.ToLower())
            {
                case "g":
                if (quantidadeC <=20)
                {
                    desconto = 0.04f;
                }
                else
                {
                    desconto = 0.06f;
                }
                float total = quantidadeC*precoG;
                float totalPay = total - desconto;
                float totalPay2 = total - totalPay;
                Console.WriteLine($"-------------------------------------");
                Console.WriteLine($"Valor total: {total}\nValor do desconto: {totalPay}\nTotal a pagar{totalPay2}");
                    break;
                case "a":
                if (quantidadeC <=20)
                {
                    desconto = 0.03f;
                }else
                {
                    desconto = 0.05f;
                }
                 total = quantidadeC*precoA;
                 totalPay = total*desconto;
                 totalPay2 = total - totalPay;
                Console.WriteLine($"-------------------------------------");
                Console.WriteLine($"Valor total: {total}\nValor do desconto: {totalPay}\nTotal a pagar{totalPay2}");

                    break;
                default:
                    break;
            }
            
        }
    }
}
