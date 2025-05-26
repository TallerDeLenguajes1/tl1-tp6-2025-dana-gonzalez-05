// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/
/*Console.Write("Ingrese un numero: ");
    string numIng = Console.ReadLine();

    if (int.TryParse(numIng, out int numero))//ingresa un string y sale (out) un tipo int
        {
            if (numero > 0)
            {
                int numeroInvertido = 0;
                while (numero > 0)
                {
                    int digito = numero % 10;
                    numeroInvertido = numeroInvertido * 10 + digito;
                    numero /= 10;
                }

                Console.WriteLine($"Numero invertido: {numeroInvertido}");
            }
            else
            {
                Console.WriteLine("El numero debe ser mayor a 0.");
            }
        }
        else
        {
            Console.WriteLine("Entrada invalida, por favor ingrese un numero.");
        }*/

Console.Write("Ingrese un numero: ");
if (!double.TryParse(Console.ReadLine(), out double num))
{
    Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
    return;
}

Console.WriteLine($"Valor absoluto: {Math.Abs(num)}");
Console.WriteLine($"Cuadrado: {Math.Pow(num, 2)}");
Console.WriteLine($"Raiz cuadrada: {Math.Sqrt(num)}");
Console.WriteLine($"Seno: {Math.Sin(num)}");
Console.WriteLine($"Coseno: {Math.Cos(num)}");
Console.WriteLine($"Parte entera: {Math.Truncate(num)}");

Console.Write("\nIngrese el primer numero: ");
if (!double.TryParse(Console.ReadLine(), out double num1))
{
    Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
    return;
}

Console.Write("Ingrese el segundo numero: ");
if (!double.TryParse(Console.ReadLine(), out double num2))
{
    Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
    return;
}

Console.WriteLine($"Maximo entre {num1} y {num2}: {Math.Max(num1, num2)}");
Console.WriteLine($"Minimo entre {num1} y {num2}: {Math.Min(num1, num2)}");

Console.WriteLine("\n¡Gracias por usar la CalculadoraV2!");