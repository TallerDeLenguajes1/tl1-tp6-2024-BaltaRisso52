// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);


Console.Write("Ingrese el numero a invertir: ");
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


float numero;
Console.Write("Ingrese un numero: ");
string numero1 = Console.ReadLine();

if (float.TryParse(numero1, out numero))
{
    Console.WriteLine($"El valor absoluto de {numero} es: {Math.Abs(numero)}");
    Console.WriteLine($"El cuadrado de {numero} es: {numero * numero}");
    Console.WriteLine($"La raiz cuadrada de {numero} es: {Math.Sqrt(numero)}");
    Console.WriteLine($"El seno de {numero} es: {Math.Sin(numero)}");
    Console.WriteLine($"El coseno de {numero} es: {Math.Cos(numero)}");
    Console.WriteLine($"La parte entera de {numero} es: {Convert.ToInt32(numero)}");
}
else
{
    Console.WriteLine("El numero ingresado es incorrecto");
}

Console.WriteLine("Ingrese 2 numeros: ");
Console.Write("1ero: ");
if (float.TryParse(Console.ReadLine(), out float num1))
{
    Console.Write("2do: ");
    if (float.TryParse(Console.ReadLine(), out float num2))
    {
        if (num1 < num2)
        {
            Console.WriteLine($"Mayor: {num2}, Menor: {num1}");
        }
        else
        {
            Console.WriteLine($"Mayor: {num1}, Menor: {num2}");
        }
    }
    else
    {
        Console.WriteLine("ERROR");
    }
}
else
{
    Console.WriteLine("ERROR");
}

