//Leer 5 edades y mostrar la edad promedio 

using System;

int[] edades = new int[5];
int suma = 0;
double promedio;

for (int i = 0; i < edades.Length; i++)
{
    try
    {
         Console.WriteLine("Ingrese la edad " + (i + 1) + ":");
         edades[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un Decrementar el índice para volver a solicitar la edadnúmero entero.");
            i--; // 
    }
    Console.WriteLine("Ingrese la edad " + (i + 1) + ":");
    edades[i] = int.Parse(Console.ReadLine()!);
    
}
foreach (int edad in edades)
{
    suma += edad;
}
promedio = (double)suma / edades.Length;

Console.WriteLine("La edad promedio es: " + promedio);