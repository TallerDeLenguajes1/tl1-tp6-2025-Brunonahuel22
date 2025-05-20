// See https://aka.ms/new-console-template for more information

Console.Write("Ingrese su numero: ");
int numero = int.Parse(Console.ReadLine());
int invertido = 0;

if (numero > 0)
{
    while (numero > 0)
    {
        int digito = numero % 10;

        invertido = invertido * 10 + digito;
        numero = numero / 10;
    }

    Console.WriteLine($"Numero Invertido {invertido}");

}
else
{
    Console.WriteLine("El numero ingresado debe ser mayor que 0");
}

