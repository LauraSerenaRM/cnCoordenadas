using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnCoordenadas
{   // <summary>
    /// Nombre: Laura Serena Rivera Mejía
    /// Fecha: 24-02-2023
    /// Descripción: Este programa recibe 2 valores de coordenadas en el plano (x,y) y determina según su signo a que
    /// cuadrante pertenece el par ordenado (Concepto matemático)
    /// </summary>
    internal class ClsCoordenada
    {
        //Declaración de variables
        int CoordenadaX;
        int CoordenadaY;
        static void Main(string[] args)
        {
            //Se crea un objeto de la Clase Coordenada.
            ClsCoordenada oCoordenada = new ClsCoordenada();
            // Se llaman los métodos a partir del objeto coordenada
            oCoordenada.SolicitarDatosCoordenadas();
            oCoordenada.EvaluarCuadrante();
            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();
        }

        //Método 1 
        public void SolicitarDatosCoordenadas()
        {
            //Mensajes de salida y captura datos de entrada
            Console.WriteLine("Ingresar el valor de la coordenada en X");
            CoordenadaX = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el valor de la coordenada en Y");
            CoordenadaY = int.Parse(Console.ReadLine());

        }

        //Método 2
        public void EvaluarCuadrante()
        {
            //Ciclo lógico
            if (CoordenadaX > 0 & CoordenadaY > 0)
            {
                Console.WriteLine("El par ordenado (" + CoordenadaX + "," + CoordenadaY + ") se encuentra en el primer cuadrante" +
                    " del plano cartesiano");
            }
            else if (CoordenadaX < 0 & CoordenadaY > 0)
            {
                Console.WriteLine("El par ordenado (" + CoordenadaX + "," + CoordenadaY + ") se encuentra en el segundo cuadrante" +
                    " del plano cartesiano");
            }
            else if (CoordenadaX < 0 & CoordenadaY < 0)
            {
                Console.WriteLine("El par ordenado (" + CoordenadaX + "," + CoordenadaY + ") se encuentra en el tercer cuadrante" +
                    " del plano cartesiano");
            }
            else if (CoordenadaX > 0 & CoordenadaY < 0)
            {
                Console.WriteLine("El par ordenado (" + CoordenadaX + "," + CoordenadaY + ") se encuentra en el cuarto cuadrante" +
                    " del plano cartesiano");
            }





        }


    }
}
