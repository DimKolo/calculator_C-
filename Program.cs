using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            string receiving_variable_01;
            string receiving_variable_02;

            Console.WriteLine("Введите номер фигуры площадь которой будет вычисляться:");
            Console.WriteLine("1. Круг (расчёт происходит по радиусу)");
            Console.WriteLine("2. Треугольник (расчёт происходит по трём сторонам)");

            receiving_variable_01 = Console.ReadLine();

            if (receiving_variable_01 == "1")
            {
                Calcul_circle();

                Offer_to_continue();
            }
            else if (receiving_variable_01 == "2")
            {
                Calcul_triangle();

                Offer_to_continue();
            }
            else
            {
                Console.WriteLine("Вам нужно ввести одно из указанных чисел.");

                Offer_to_continue();

            }

            void Calcul_circle()
            {
                double r;
                double S;

                Console.WriteLine("Введите значение радиуса круга:");
                r = Convert.ToDouble(Console.ReadLine());
                S = Math.PI * Math.Pow(r, 2);

                Console.WriteLine("Площадь круга: {0}", S);
            }

            void Calcul_triangle()
            {
                double value_01;
                double value_02;
                double value_03;
                double p;
                double S;

                Console.WriteLine("Введите значение трёх сторон треугольника(поочерёдно):");
                value_01 = Convert.ToDouble(Console.ReadLine());
                value_02 = Convert.ToDouble(Console.ReadLine());
                value_03 = Convert.ToDouble(Console.ReadLine());
                p = (value_01 + value_02 + value_03) / 2;
                S = Math.Sqrt(p * (p - value_01) * (p - value_02) * (p - value_03));

                Console.WriteLine("Площадь треугольника: {0}", S);
            }

            void Offer_to_continue()
            {
                Console.WriteLine("Хотите продолжить? (Да/Нет)");
                receiving_variable_02 = Console.ReadLine();
                if (receiving_variable_02 == "Да" || receiving_variable_02 == "да")
                {
                    Main();
                }
                else if (receiving_variable_02 == "Нет" || receiving_variable_02 == "нет")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Неккоректный ввод. Завершаю программу");
                    return;
                }
            }
        }


    }
}