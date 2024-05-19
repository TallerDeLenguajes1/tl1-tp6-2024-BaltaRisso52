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


Console.Write("Ingrese el texto: ");
string cadena = Console.ReadLine();
Console.WriteLine($@"La longitud de ""{cadena}"" es: {cadena.Length} ");
Console.Write("Ingrese texto a concatenar: ");
string cadena2 = Console.ReadLine();
Console.WriteLine($"Quedaria: {cadena} {cadena2}");
string subcadena = cadena2.Substring(0, 5);
Console.WriteLine($"Subcadena: {subcadena}");

foreach (char c in cadena2)
{
    Console.WriteLine(c);
}

Console.Write("Ingrese la palabra a buscar: ");
string palabra = Console.ReadLine();
int lugar = cadena2.IndexOf(palabra);
if (lugar != -1)
{
    Console.WriteLine($"La palabra ingresada se encuentra en la posicion: {lugar + 1}");
}
else
{
    Console.WriteLine("No se encontro la palabra");
}



int cant = 0;
string cadenaNueva = cadena2;
while (true)
{
    if (lugar != -1)
    {
        cant++;
    }
    else
    {
        break;
    }
    cadenaNueva = cadenaNueva.Substring(lugar + palabra.Length - 1);
    lugar = cadenaNueva.IndexOf(palabra);
}

if (cant > 0)
{
    Console.WriteLine($"La palabra ingresada se repite: {cant}");
}

Console.WriteLine($"Texto ingresado en mayusculas: {cadena2.ToUpper()}");
Console.WriteLine($"Texto ingresado en minusculas: {cadena2.ToLower()}");

Console.Write(@"Ingrese texto con el separador ""-"": ");
string texto = Console.ReadLine();
string[] arrayTexto = texto.Split('-');
for (int j = 0; j < arrayTexto.Length; j++)
{
    Console.WriteLine($"{j + 1} = {arrayTexto[j]}");
}

char[] operaciones = { '+', '-', '*', '/' };
Console.Write("Ingrese la operacion a realizar: ");
string operacion = Console.ReadLine();
int d = -1;
string[] resolver = new string[0];
for (int h = 0; h < 4; h++)
{
    resolver = operacion.Split(operaciones[h]);
    if (resolver.Length > 1)
    {
        d = h;
        break;
    }
}

if (double.TryParse(resolver[0], out double n1) && double.TryParse(resolver[1], out double n2))
{
    switch (d)
    {
        case 0:
            Console.WriteLine($"La suma entre {n1} y {n2} es igual a {n1 + n2}");
            break;
        case 1:
            Console.WriteLine($"La resta entre {n1} y {n2} es igual a {n1 - n2}");
            break;
        case 2:
            Console.WriteLine($"La multiplicacion de {n1} y {n2} es igual a {n1 * n2}");
            break;
        case 3:
            Console.WriteLine($"La division de {n1} entre {n2} es igual a {n1 / n2}");
            break;
        default:
            break;
    }
}
else
{
    Console.WriteLine("Los operandos son incorrectos");
}



