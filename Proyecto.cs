using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    class Proyecto
    {
        public List<Proyecto> proyectos = new List<Proyecto>();

        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        //public List<Proyecto> AgregarProyecto()
        //{
        //    Console.WriteLine("Escriba (Y) para ingresar");
        //    var res = Console.ReadLine();
        //    while (res == "Y")
        //    {
        //        Console.WriteLine("Escriba el nombre del proyecto");
        //        var nom = Console.ReadLine();
        //        Console.WriteLine("Escriba el codigo del proyecto");
        //        var cod = Console.ReadLine();
        //        var miProyecto = new Proyecto()
        //        {

        //        };
        //        proyectos.Add(miProyecto);
        //        Console.WriteLine("Escriba (Y) para ingresar");
        //        res = Console.ReadLine();
        //    }
        //    return proyectos;
        //}

        public List<Proyecto> AgregarProyecto2()
        {
            var proys = new List<Proyecto>()
            {
                new Proyecto()
                {
                    Nombre = "Bancaria",
                    Codigo = 23,
                    Area = "Comercio",
                    Duracion = 9
                },

                new Proyecto()
                {
                    Nombre = "Mercadeo",
                    Codigo = 23,
                    Area = "Talento Humano",
                    Duracion = 6
                },

                new Proyecto()
                {
                    Nombre = "Atención Primaria",
                    Codigo = 23,
                    Area = "AIPI",
                    Duracion = 8
                },

                new Proyecto()
                {
                    Nombre = "Analisis y Desarrollo de Sistemas de Información",
                    Codigo = 27,
                    Area = "Sistemas",
                    Duracion = 24
                },

                new Proyecto()
                {
                    Nombre = "Producción Multimedia",
                    Codigo = 7,
                    Area = "Sistemas",
                    Duracion = 18
                },

                new Proyecto()
                {
                    Nombre = "Producción Multimedia",
                    Codigo = 27,
                    Area = "Sistemas",
                    Duracion = 18
                }

            };
            return proys;
        }

        public void Imprimir(List<Proyecto> proy)
        {
            Console.WriteLine("-----------Lista de Proyectos-----------");
 
            foreach (var item in proy)
            {
                Console.WriteLine($"    Nombre {item.Nombre}");
                Console.WriteLine($"    Codigo {item.Codigo}");
                Console.WriteLine($"    Area {item.Area}");
                Console.WriteLine($"    Duracion {item.Duracion}");
                Console.WriteLine("---------------------------------------");

            }
        }
    }
}
