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




