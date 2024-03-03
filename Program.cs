using System;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IMC pesoMasaCorporal = new IMC();

            Console.WriteLine("Ingrese su altura en metros");
            double alturaUsuario = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su peso en Kilogramos");
            double pesoUsuario = double.Parse(Console.ReadLine());

            Console.WriteLine(pesoMasaCorporal.totalIMC(alturaUsuario, pesoUsuario));
            
            Console.ReadKey();
        }

    }

    class IMC
    {
        public String totalIMC (double alturaMetro,  double pesoKg)
        {
            double indiceMC = pesoKg / (Math.Pow(alturaMetro, 2));

            indiceMC = Math.Round(indiceMC, 2); //Redondeando el Índice de Masa Corporal a dos decimales

            if (indiceMC < 18.5) 
            {
                return "IMC: " + indiceMC + " Bajo peso"; 
            }
            else if (indiceMC >= 18.5 && indiceMC <= 24.9)
            {
                return "IMC: " + indiceMC + " Peso normal/saludable.";
            }
            else if (indiceMC >= 25 && indiceMC <= 29.9)
            {
                return "IMC: " + indiceMC + " Sobrepeso";
            }
            else
            {
                return "IMC: " + indiceMC + " Obesidad";
            }
        }             

    }
}
