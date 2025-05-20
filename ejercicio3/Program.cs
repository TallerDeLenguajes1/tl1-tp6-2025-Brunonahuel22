// See https://aka.ms/new-console-template for more information
bool respuesta = true;
while (respuesta != false)
{
    int opcion = 0;
     Console.WriteLine("\nCalculadora V2");
            Console.WriteLine("1. El valor absoluto de un número");
            Console.WriteLine("2. El cuadrado");
            Console.WriteLine("3. La raíz cuadradar");
            Console.WriteLine("4. El seno");
            Console.WriteLine("5. El Coseno");
            Console.WriteLine("6. Parte entera tipo float");
            Console.Write("Seleccione una opción: ");

            
















    Console.WriteLine("Desea hacer otra operacion?");
    Console.WriteLine("1) si ");
    Console.WriteLine("2) no");
    int x = int.Parse(Console.ReadLine());

    switch (x)
    {

        case 1:
            respuesta = true;

            break;
        case 2:
            respuesta = false;

            break;
    }


}


