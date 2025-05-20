// See https://aka.ms/new-console-template for more information

while (true)
        {
            Console.WriteLine("\nCalculadora Básica");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opción inválida, intente nuevamente.");
                continue;
            }

            if (opcion == 5)
            {
                Console.WriteLine("Saliendo...");
                break;
            }

            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
            }

            Console.Write("¿Desea realizar otro cálculo? (s/n): ");
            string continuar = Console.ReadLine().ToLower();
            if (continuar != "s") break;
        }