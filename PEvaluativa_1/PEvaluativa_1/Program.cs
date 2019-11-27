using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEvaluativa_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciamos la clase operacion
            Operacion Op = new Operacion();
            Menu();

            //Creamos un metodo menu
            void Menu()
            {
                //se le pide al usuario que ingrese el id de la persona y asi buscarlo
                Console.WriteLine("Bienvenido a mi programa");
                Console.WriteLine("Escribe la Id de la persona a buscar");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Op.BuscarPersona(n);
        }
    }
}
