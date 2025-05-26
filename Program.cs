// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string continuar = "S";

while (continuar.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("===== Calculadora =====");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Seleccione una opción: ");
    
    int opcion;
    if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
    {
        Console.WriteLine("Opción inválida, intente de nuevo.");
        continue;
    }

    Console.Write("Ingrese el primer número: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Entrada inválida, intente de nuevo.");
        continue;
    }

    Console.Write("Ingrese el segundo número: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Entrada inválida, intente de nuevo.");
        continue;
    }

    double resultado = 0;
    switch (opcion)
    {
        case 1: resultado = num1 + num2; break;
        case 2: resultado = num1 - num2; break;
        case 3: resultado = num1 * num2; break;
        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                continue;
            }
            resultado = num1 / num2;
            break;
    }

    Console.WriteLine($"Resultado: {resultado}");

    Console.Write("\n¿Desea realizar otro cálculo? (S/N): ");
    continuar = Console.ReadLine();
}

Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
