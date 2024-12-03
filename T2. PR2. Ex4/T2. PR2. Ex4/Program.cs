using System;
using System.Security.Cryptography.X509Certificates;

namespace T2._PR2._Ex4
{
    public class Program
    {
        //Constants
        const string MsgWidhtRect = "Introdueix l'amplada del rectangle:";
        const string MsgHeightRect = "Introdueix l'altura del rectangle:";
        const string ResultAreaRect = "L'àrea del rectangle és: ";
        const string MsgRadius = "Introdueix el radi del cercle:";
        const string ResultCircumf = "La circumferència del cercle és: ";
        const string MsgAreaBiggerRange = "L'àrea és més gran de 50";
        const string MsgAreaBetweenRange = "L'àrea és entre 20 i 50";
        const string MsgAreaMinusRange = "L'àrea és menor  a 20";
        const string MsgErrorDades = "Les dades no han sigut introduides correctament";

        public static void Main(string[] args)
        {
            double widht = 0, height = 0, area = 0, radius = 0, circumference = 0;
            // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
            CalculateArea(widht, height, ref area);

            // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
            CalculateCircumf(radius, circumference);

            // Imprimeix un missatge basat en el valor de l'àrea
            WriteMsgArea(area);
        }
        public static void CalculateCircumf(double radius, double circumference)
        {
            radius = AskRadius(radius);

            circumference = 2 * Math.PI * radius;

            Console.WriteLine(ResultCircumf + circumference);
        }
        public static double AskRadius(double radius)
        {
            Console.WriteLine(MsgRadius);
            try
            {
                radius = Convert.ToDouble(Console.ReadLine());
            }
            catch { Console.WriteLine(MsgErrorDades); Console.WriteLine(); }
            return radius;
        }

        public static double AskWidht(double width)
        {
            Console.WriteLine(MsgWidhtRect);
            try
            {
                width = Convert.ToDouble(Console.ReadLine());
            }
            catch { Console.WriteLine(MsgErrorDades); Console.WriteLine(); }
            return width;
        }
        public static double AskHeigh(double height)
        {
            Console.WriteLine(MsgHeightRect);
            try
            {
                height = Convert.ToDouble(Console.ReadLine());
            }
            catch { Console.WriteLine(MsgErrorDades); Console.WriteLine(); }
            return height;
        }
        public static double CalculateArea(double width, double height, ref double area)
        {
            width = AskWidht(width);
            height = AskHeigh(height);
            area = width * height;

            Console.WriteLine(ResultAreaRect + area);

            return area;
        }
        public static void WriteMsgArea(double area)
        {
            if (area > 50)
            {
                Console.WriteLine(MsgAreaBiggerRange);
            }
            else if (area >= 20)
            {
                Console.WriteLine(MsgAreaBetweenRange);
            }
            else
            {
                Console.WriteLine(MsgAreaMinusRange);
            }
        }
    }
}