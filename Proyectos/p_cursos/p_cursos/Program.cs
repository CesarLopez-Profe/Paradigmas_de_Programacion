using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p_Cursos.Clases;

namespace p_Cursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Estudiante e1 = new Estudiante("mpaula", 21, "mpaula@gmail.com");
                Estudiante e2 = new Estudiante("JuanJ", 19, "juanj@gmail.com");

                Profesor p = new Profesor("carlos", 40, "carlos@gmail.com", "Ing de sistemas");

                Modulo m1 = new Modulo("Modulo1_c1", "contenido1");
                Modulo m2 = new Modulo("Modulo2_c1", "contenido2");

                Curso c1 = new Curso("curso1", "ffff", "desc_curso1", 1, new DateTime(2024,11,12), new DateTime(2025,11,12), p);

                //Inscripción de un estudiante al curso
                e1.inscribirse(c1);

                //Inscripción de un segundo estudiante al curso
                if (!e2.inscribirse(c1))
                {
                    Console.WriteLine("\nCupo lleno, el cupo del curso es de: " + c1.Cupo
                    + " y tiene los siguientes estudiantes: ");

                    foreach (Estudiante e in c1.L_estudiantes)
                    {
                        Console.WriteLine(e.Nombre);
                    }
                }

                //Insertar módulos al curso

                c1.insertar_modulo(m1);
                c1.insertar_modulo(m2);

                //Mostrar módulos del curso

                Console.WriteLine("El curso " + c1.Nombre + " tiene los siguientes módulos");

                foreach (Modulo m in c1.L_modulos)
                {
                        Console.WriteLine(m.Titulo);
                }

                //Crear otro curso pero con la lista de módulos

                List<Modulo> l_modulos_c2 = new List<Modulo>();

                Modulo m3 = new Modulo("Modulo1_c2", "contenido1");
                Modulo m4 = new Modulo("Modulo2_c2", "contenido2");

                l_modulos_c2.Add(m1);
                l_modulos_c2.Add(m2);

                Curso c2 = new Curso("curso2", "abcd", "desc_curso2", 1, new DateTime(2024,11,12), new DateTime(2025,11,12), p, l_modulos_c2);

                Console.WriteLine("\nCurso:  " + c2.Nombre + "\nMódulos: ");
                
                foreach (Modulo m in c2.L_modulos)
                {
                        Console.WriteLine(m.Titulo);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

