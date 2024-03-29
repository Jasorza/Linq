﻿using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** EJERCICIO **");
            Proyecto project = new Proyecto();
            project.proyectos = project.AgregarProyecto2();
            var proy = project.proyectos;
            Console.ReadLine();

            Console.WriteLine("-----------Obtener todos los proyectos cuya duración sea superior a 6 y inferior a 12-----------");
            var supinf = proy.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            project.Imprimir(supinf);
            Console.ReadLine();

            Console.WriteLine("-----------Obtener todos los proyectos que empiecen por (B) -----------");
            var proyectosb = from p in proy
                             where (p.Nombre.StartsWith("B"))
                             select p;
            project.Imprimir(proyectosb.ToList());
            Console.ReadLine();


            Console.WriteLine("-----------Obtener todos los proyectos cuyo codigo sea multiplo de 7-----------");
            var proyectosmult = proy.Where(x => x.Codigo % 7 == 0).ToList();
            project.Imprimir(proyectosmult);
            Console.ReadLine();

            Console.WriteLine("----------Agrupar los proyectos que tenga una duracion superior a 6 y inferior a 10 y los que sean mayor a 10----------");
            var gruposProys = proy.GroupBy(x =>
            {
                if (x.Duracion < 10)
                {
                    return "Son menores que 10";
                }
                else if (x.Duracion > 6)
                {
                    return "Son mayores de 6";
                }
                else
                {
                    return "son mayores de 10";
                }
            });
            foreach (var grupoProy in gruposProys)
            {
                Console.WriteLine($"Grupo de proyectos {grupoProy.Key}-----Cantidad-----{grupoProy.Count()}");
                foreach (var item in grupoProy)
                {
                    Console.WriteLine($"El nombre del proyecto {item.Nombre} \r\n Codigo Proyecto {item.Codigo}");
                }
            }
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("-----------Obtener el promedio de la duracion de todos los proyectos-----------");
            var avgDura = proy.Average(x => x.Duracion);
            Console.WriteLine($"El promedio de la duracion de todos los proyectos es de: {avgDura}");
            Console.ReadLine();

            Console.WriteLine("-----------Obtener el nombre del proyecto con mas duracion-----------");
            var maxdura = proy.Max(x => x.Duracion);
            var nom = (from p in proy
                      where (p.Duracion == maxdura)
                      select p.Nombre).FirstOrDefault();
            Console.WriteLine($"El proyecto con mas duracion es: {nom} con una duracion de {maxdura}");
            Console.ReadLine();

            Console.WriteLine("-----------Selecionar el nombre y area del proyecto con duracion mayor a 6-----------");
            var proanoni = proy.Where(x => x.Duracion > 6).Select(x =>
            new 
            {
                nombre = x.Nombre,
                area = x.Area
            }).FirstOrDefault();
            Console.WriteLine($"El proyecto {proanoni.nombre} del area: {proanoni.area} es el curso con duracion de mas de 6");
            Console.ReadLine();

            Console.WriteLine("-----------Verificar si hay un proyecto con una duracion superior a 24-----------");
            var proany = proy.Any(x => x.Duracion > 24);
            Console.WriteLine($"Al menos un proyecto tiene una dracion de mas de 24 {proany}");

            Console.WriteLine("-----------Sumar las duraciones de los proyectos cuyo codigo sea superior a 20-----------");
            var prosum = proy.Where(x => x.Codigo > 20).Sum(x => x.Duracion);
            Console.WriteLine($"La suma de la duración de los proyecto con codigo superior a 20 es: {prosum}");
            Console.ReadLine();

            Console.WriteLine("-----------Tomar los dos primeros proyectos cuyo codigo sea superior a 30-----------");
            
            Console.ReadLine();
        }
    }
}
