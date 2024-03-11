using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[,] alumnos = new string[100, 2];

        int contadorAlumnos = 0;

        while (true)
        {
            Console.WriteLine("Ingrese el nombre del alumno (o escriba 'fin' para terminar):");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "fin")
            {
                break;
            }

            Console.WriteLine("Ingrese la matrícula del alumno:");
            string matricula = Console.ReadLine();

            alumnos[contadorAlumnos, 0] = nombre;
            alumnos[contadorAlumnos, 1] = matricula;
            contadorAlumnos++;
        }

        GuardarEnArchivo(alumnos, contadorAlumnos);
        Console.WriteLine("Datos guardados en el archivo 'alumnos.txt'.");
    }

    static void GuardarEnArchivo(string[,] datos, int cantidadAlumnos)
    {
        string filePath = "alumnos.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < cantidadAlumnos; i++)
            {
                writer.WriteLine($"Nombre: {datos[i, 0]}, Matrícula: {datos[i, 1]}");
            }
        }
    }
}
