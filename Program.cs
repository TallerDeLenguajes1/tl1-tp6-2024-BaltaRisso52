// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);


Console.WriteLine("Ingrese el numero a invertir: ");
int i = 0;
string s = Console.ReadLine();
int invertido = 0;
int divisor = 1;

if (int.TryParse(s, out i))
{
    if (i >= 0)
    {
        while (i > 0)
        {

            while (i / divisor > 10)
            {
                divisor *= 10;
            }
            invertido += (i % 10) * divisor;
            divisor /= 10;
            i /= 10;
        }
        Console.WriteLine(invertido);


    }
}

int seguir = 1;
while (seguir == 1)
{
    Console.WriteLine("---Menu---");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.WriteLine("Ingrese la opcion: ");
    int opcion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese los numeros: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int z = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine($"{x} + {z} = {x + z}");
            break;
        case 2:
            Console.WriteLine($"{x} - {z} = {x - z}");
            break;
        case 3:
            Console.WriteLine($"{x} * {z} = {x * z}");
            break;
        case 4:
            Console.WriteLine($"{x} / {z} = {x / z}");
            break;

        default:
            break;
    }
    Console.WriteLine("Seguir usando calculadora?");
    Console.WriteLine("1.si");
    Console.WriteLine("2.no");
    Console.WriteLine("Respuesta: ");
    seguir = Convert.ToInt32(Console.ReadLine());
    if (seguir != 1)
    {
        Console.WriteLine("Gracias por usar la calculadora, Hasta Luego");
    }

}


