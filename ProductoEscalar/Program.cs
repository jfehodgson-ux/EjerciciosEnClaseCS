using System;

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int productoEscalar = 0;

Console.WriteLine("Ingrese los elementos del vector 1:");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        i--; 
        Console.ResetColor();
    }
}

Console.WriteLine("\nIngrese los elementos del vector 2:");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        i--; 
        Console.ResetColor();
    }
}

for (int i = 0; i < vector1.Length; i++)
{
    productoEscalar += vector1[i] * vector2[i];
}

Console.WriteLine($"\nEl producto escalar total es: {productoEscalar}");
