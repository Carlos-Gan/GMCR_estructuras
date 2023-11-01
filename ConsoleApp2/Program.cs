﻿using System;


public class Registro3
{
    struct ITD
    {
        public int semestre;
        public string carrera;
        public string actExtra;
    }

    struct estudiante
    {
        public string nombre;
        public int edad;
        public float promedio;
        public char inicial;
        public ITD Carre;
    }


    public static void Main()
    {
        int i, cantidadEstudiantes;
        estudiante[] estudiantes = new estudiante[100];
        Console.Write("\tIngrese el numero de estudiantes a ingresar: ");
        cantidadEstudiantes = int.Parse(Console.ReadLine());

        for (i = 0; i < cantidadEstudiantes; i++)
        {
            Console.Write("\nIngrese el nombre de el {0} estudiante: ", i + 1);
            estudiantes[i].nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del estudiante: ");
            estudiantes[i].edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el promedio general del {0} estudiante: ", i + 1);
            estudiantes[i].promedio = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la carrera del {0} estudiante: ", i + 1);
            estudiantes[i].Carre.carrera = Console.ReadLine();
            Console.Write("Ingrese el semestre del estudiante: ");
            estudiantes[i].Carre.semestre = int.Parse(Console.ReadLine());
        }

        Console.Write("\nIngrese el numero de estudiante a mostrar: ");
        int estudianteAMostrar = int.Parse(Console.ReadLine()) - 1;

        Console.Write("{0} tiene {1} y actualmente esta cursando el {2} semestre de la carrera de {3} con un promedio de {4}",
                estudiantes[estudianteAMostrar].nombre, estudiantes[estudianteAMostrar].edad, estudiantes[estudianteAMostrar].Carre.semestre, estudiantes[estudianteAMostrar].Carre.carrera, estudiantes[estudianteAMostrar].promedio);

        Console.Write("\nPress any key to continue . . . ");
        Console.ReadKey(true);
    }
}
