﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseñoClaseContacto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contacto c1 = new Contacto("Unai", new DateTime(0199,11,1));
            //c1.CambiarNombre("unai");
            //Console.WriteLine(c1.GetNombre());
            //Console.WriteLine(c1.ObtenerEdad());
            //c1.CambiarTelefono("3333");
            //c1.DevolverTelefono();
            //Console.WriteLine(c1.Felicitara() + " " + c1.ObtenerEdad() + "!");
            //Console.WriteLine(c1.GetNombre() + " " + c1.ObtenerEdad() + " " + c1.DevolverTelefono());

            //Contacto[] contactos = new Contacto[5];
            //contactos[0] = c1;
            //contactos[1] = new Contacto("Miren", "944123456", new DateTime(1990,4,2));
            //contactos[2] = new Contacto("Jon", "931212123");
            //contactos[3] = new Contacto("Ane", new DateTime(1995, 5, 5));
            //contactos[4] = new Contacto("Julen", "944123321", new DateTime(1992,4,2));

            //for (int i = 0; i < contactos.Length; i++)
            //{
            //    Console.WriteLine(contactos[i].ContactInfo());

            //}

            //// edad
            //Console.WriteLine(contactos [1].ObtenerEdad());
            //Console.WriteLine(contactos[3].ObtenerEdad());
            //Console.WriteLine(contactos[4].ObtenerEdad());

            ////felicitar
            //Console.WriteLine(contactos[1].Felicitara() + " " + contactos[1].ObtenerEdad() + "!");
            //Console.WriteLine(contactos[3].Felicitara() + " " + contactos[3].ObtenerEdad() + "!");
            //Console.WriteLine(contactos[4].Felicitara() + " " + contactos[4].ObtenerEdad() + "!");

            //CLASE CONTACTO 2

            Contacto2 c1 = new Contacto2("Miren", "944123456", new DateTime (1990, 03, 6),"friend" );
            Contacto2 c2 = new Contacto2("Jon", "931212123", "colleague");
            Contacto2 c3 = new Contacto2("Ane", " ", new DateTime(1995, 05, 5), "family");
            Contacto2 c4 = new Contacto2("Julen", "944123321", new DateTime(1992, 02, 12), "uni mate");
            Contacto2 c5 = new Contacto2("Mikel"," " ,new DateTime(1997, 07, 7), "family");

            
            //Console.WriteLine(c1.ObtenerNumContactos());
            Console.WriteLine(c1.MostrarDatos());
            Console.WriteLine(c2.MostrarDatos());
            Console.WriteLine(c3.MostrarDatos());
            Console.WriteLine(c4.MostrarDatos());
            Console.WriteLine(c5.MostrarDatos());

            Console.ReadLine();
        }
    }
}
