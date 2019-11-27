using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEvaluativa_1
{
   public class Operacion
    {
        //Creamos un metodo para buscar persona
        public Persona BuscarPersona(int id)
        {
            //se crea una variable que llamara al metodo obtenerPersona
            var personas = ObtenerPersonas();
            //Se hace la condicion para buscar la id y compararla
            var n = (from persona in personas
                     where persona.Id == id
                     select persona).First();
            return n;
        }

        //creamos una lista 
        public List<Persona> ObtenerPersonas()
        {
            //creamos una variable que llamara al metodo ObtenerLineas
            var datos = ObtenerLineas();

            //Instanciamos una lista de tipo persona
            List<Persona> personas = new List<Persona>();

            //un foreach parqa buscar datos 
            foreach (var item in datos)
            {
                string[] info = item.Split(',');
                Persona Pe = new Persona
                {
                    Id = int.Parse(info[0]),
                    Nombre = info[1],
                    Profesion = info[2],
                    Edad = int.Parse(info[3])
                };
                personas.Add(Pe);
            }
            return personas;
        }

        //Creamos una lista para ObtenerLineas
        public List<String> ObtenerLineas()
        {
            //Aqui creamos el try catch para que nos de seguimiento o un aviso al no escribir bien un dato y este mande un error
            
            try
            {
                List<String> lineas = new List<string>();
                string[] info = null;
                if (File.Exists("Datos.txt"))
                {
                    info = File.ReadAllLines("Datos.txt");
                }

                foreach (string item in info)
                {
                    lineas.Add(item);
                }
                return lineas;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Numero ingresado incorrecto");
            }
            return null;
        }

    }
}
