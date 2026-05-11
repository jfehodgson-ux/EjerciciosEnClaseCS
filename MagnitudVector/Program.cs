using System;

int[] vector = new int[5];
double sumaCuadrados = 0;
  
for (int i = 0; i < vector.Length; i++)
{   try
    {
        Console.Write($"Ingrese el valor para la dirección {i + 1}: ");
        vector[i] = int.Parse(Console.ReadLine()!);
         sumaCuadrados += Math.Pow(vector[i], 2);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        i--; // Decrementar el indicee para volver a solicitar el mismo elemento
        Console.ResetColor();
    }
  
    
   
}

double magnitud = Math.Sqrt(sumaCuadrados);

Console.WriteLine($"\nLa magnitud total del vector es: {magnitud:F2}");