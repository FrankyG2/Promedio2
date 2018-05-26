using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranciscoBravo
{
    class CocinarChaufa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Qué clase de chaufa prepararemos esta vez?");
            Console.WriteLine("¿De chancho o de pollo?");
            Console.ReadLine();

           string SeleccionarCarne(string animal, bool esComestible, string texto)
            {
                animal = Console.ReadLine();
                esComestible = false;

                while (!esComestible)
                {
                    if (animal == "pollo")
                    {
                        texto = "Chaufa de pollo, ¿eh? Un clásico.";
                        esComestible = true;
                    }
                    else if (animal == "chancho")
                    {
                        texto = "Chaufa de chancho, ¿eh? Qué delicia.";
                        esComestible = true;
                    }
                    else
                    {
                        texto = "Mmmmmh no creo que podamos hacer un chaufa de eso.";
                    }
                }

                return texto;
            }





        }        
    }
}
