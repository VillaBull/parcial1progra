int numero;

do
{
    Console.WriteLine("Por favor ingrese un número entero positivo:");
} while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

bool detener = false;

while (!detener)
{
    Console.WriteLine("1. Calcular el factorial del número.");
    Console.WriteLine("2. Calcular la raíz cuadrada del número.");
    Console.WriteLine("3. Salir del programa.");

    Console.WriteLine("\nPor favor seleccione una opción (1, 2 o 3):");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            long factorial = CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
            break;
        case "2":
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"La raíz cuadrada de {numero} es: {raiz}");
            break;
        case "3":
            detener = true;
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor seleccione 1, 2 o 3.");
            break;
    }
}

static long CalcularFactorial(int n)
{
    if (n == 0)
        return 1;

    long factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    return factorial;
}