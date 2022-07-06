using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Juan", "Pablo", "Pedro", "Pepe2", "Ana", "Esteban", "Daniel", "Mariano",
                "Carolina", "Silvia", "Roberto", "Juanito", "Juana"};

            print(order(nombres));
            Console.WriteLine("\n");
            Console.WriteLine(search(nombres,"Pablo")+"\n");

            print(contains(nombres));
            Console.WriteLine("\n");

            print(add(nombres));
        }

        static void print(string[] array)
        {
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
        }

        static string[] order(string[] array)
        {
            IEnumerable<string> aux =
                from names in array
                orderby names descending
                select names;

            return aux.ToArray();
        }

        static bool search(string[] array, string key)
        {
            IEnumerable<string> aux =
                from names in array
                where names == key
                select names;
            if (aux.Any()==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string[] contains(string[] array)
        {
            IEnumerable<string> aux =
                from names in array
                where names.Contains("Juan")
                select names;

            return aux.ToArray();
        }

        static string[] add(string[] array)
        {
            IEnumerable<string> aux =
                from names in array
                select "Hola "+ names;

            return aux.ToArray(); 
        }
    }
}
