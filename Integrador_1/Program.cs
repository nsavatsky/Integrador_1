using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integrador_1.DAL;

namespace Integrador_1
{
   class Program
   {
      static void Main(string[] args)
      {
         using (var clinicaDb = new CLINICA())
         {
            while (true)
            {
               int menuChoice;

               Console.WriteLine("1- Ver Pacientes");
               Console.WriteLine("2- Agregar Pacientes\n");

               Console.Write("Seleccione opcion: ");
               menuChoice = int.Parse(Console.ReadLine());

               if (menuChoice == 1)
                  ViewPatients(clinicaDb);
               else if (menuChoice == 2)
                  CreatePatient(clinicaDb);
               else
                  break;
            }
            
         }
      }

      private static void ViewPatients(CLINICA context)
      {
         if (context.PACIENTES.Count() == 0)
         {
            Console.WriteLine("** no hay pacientes cargados ** \n");
            return;
         }

       foreach(var p in context.PACIENTES)
         {
            Console.WriteLine("{0}-{1}\n", p.id_paciente, p.ToString());
         }
      }

      static void CreatePatient(CLINICA context)
      {
         
         string name, apellido, email, calle;
         int barrio, nroCalle, tipoDoc, idObraSocial, genero;
         long dni, telefono;


         Console.Write("Ingrese nombre del paciente: ");
         name = Console.ReadLine();

         Console.Write("Ingrese el apellido del paciente: ");
         apellido = Console.ReadLine();

         Console.WriteLine("Ingrese el tipo de documento\n");
         
         foreach(var td in context.TIPOS_DOC)
         {
            Console.WriteLine("{0}- {1}", td.id_tipo_doc, td.desc_tipo_doc);
         }

         Console.Write("\nSeleccione: ");
         tipoDoc = int.Parse(Console.ReadLine());

         Console.Write("Ingrese DNI: ");
         dni = long.Parse(Console.ReadLine());

         Console.WriteLine("Ingrese genero:\n ");

         foreach(var g in context.GENEROS)
         {
            Console.WriteLine("{0}- {1}", g.id_genero, g.desc_genero);
         }

         Console.Write("\nSeleccione: ");
         genero = int.Parse(Console.ReadLine());

         Console.WriteLine("Ingrese Obra Social: \n");

         foreach(var os in context.OBRAS_SOCIALES)
         {
            Console.WriteLine("{0}- {1}", os.id_obra_social, os.nombre);
         }

         Console.Write("\nSeleccione: ");
         idObraSocial = int.Parse(Console.ReadLine());

         Console.Write("Ingrese domicilio: ");
         calle = Console.ReadLine();

         Console.Write("Ingrese nro calle: ");
         nroCalle = int.Parse(Console.ReadLine());

         Console.WriteLine("Ingrese barrio:\n");

         foreach (var b in context.BARRIOS)
         {
            Console.WriteLine("{0}- {1}", b.id_barrio, b.ToString());
         }

         Console.Write("\nSeleccione: ");
         barrio = int.Parse(Console.ReadLine());

         Console.Write("Ingrese telefono: ");
         telefono = long.Parse(Console.ReadLine());

         Console.Write("Ingrese email: ");
         email = Console.ReadLine();

         var pac = new PACIENTES
         {
            nom_paciente = name,
            apellido = apellido,
            tipo_doc = tipoDoc,
            email = email,
            id_barrio = barrio,
            calle = calle,
            id_genero = genero,
            telefono = telefono,
            nro_doc = dni,
            id_paciente = context.PACIENTES.Count()+1,
            nro_dom = nroCalle,
            id_obra_social = idObraSocial

         };

         context.PACIENTES.Add(pac);
         context.SaveChanges();


      }
   }
}
