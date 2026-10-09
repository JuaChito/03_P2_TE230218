using System;

// Clase: EvaluadorTemperaturaMotor
class EvaluadorTemperaturaMotor
{
    // Propiedad
    public double[] Lecturas { get; set; } = new double[5];

    // Método para calcular el promedio de las temperaturas
    public double CalcularPromedio()
    {
        double suma = 0;
        foreach (double temp in Lecturas)
        {
            suma += temp;
        }
        return suma / Lecturas.Length;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Ejercicio 3: Promedio de Temperatura ---");

        // Objeto creado a partir de la clase EvaluadorTemperaturaMotor
        EvaluadorTemperaturaMotor evaluador = new EvaluadorTemperaturaMotor();

        for (int i = 0; i < evaluador.Lecturas.Length; i++)
        {
            Console.Write($"Ingrese la lectura #{i + 1} (°C): ");
            evaluador.Lecturas[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Llamada al método
        double promedio = evaluador.CalcularPromedio();
        Console.WriteLine($"Promedio: {promedio} °C");

        if (promedio <= 70)
        {
            Console.WriteLine("Estado: NORMAL");
        }
        else
        {
            Console.WriteLine("Estado: ALERTA DE TEMPERATURA");
        }
    }
}