using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias, categoria, desayuno;
            float pago, pago_total;
            Console.WriteLine("Cantidad de dias de estancia en el hotel: ");
            dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la categoria del hotel (3/5) estrellas: ");
            categoria = int.Parse(Console.ReadLine());
            pago = 0f;

            switch (categoria)
            {
                case 3:
                    if (dias >= 1 && dias <= 5)
                    {
                        pago = 100f;
                    }
                    else if (dias >= 6 && dias <= 10)
                    {
                        pago = 85f;
                    }
                    else
                    {
                        pago = 70f;
                    }
                    break;
                case 5:
                    if (dias >= 1 && dias <= 5)
                    {
                        pago = 300f;
                    }
                    else if (dias >= 6 && dias <= 10)
                    {
                        pago = 270f;
                    }
                    else
                    {
                        pago = 250f;
                    }
                    break;
            }
            desayuno = dias * 7;
            pago_total = (pago * dias) + desayuno;
            Console.WriteLine("El pago total será: S/" + pago_total.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
