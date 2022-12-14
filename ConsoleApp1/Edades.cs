using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Edades
    {
        public static void Edad()
        {
            int edad,mayor=0,menor=0;
            for (int i =0; i<=4; i++ )
            {
                Console.WriteLine("Ingrese su edad");
                edad = int.Parse(Console.ReadLine());
                if(edad>=18)
                {
                    mayor += 1;
                }
                else
                {
                    menor += 1;
                }
            }
            Console.WriteLine("Personas mayores de edad: "+mayor);
            Console.WriteLine("Personas mayores de edad: " + menor);
            Console.ReadKey();
        }
       
    }
}
