using EspacioCalculadora;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




string cadenaNumero = Console.ReadLine();
double numero;
bool anda = double.TryParse(cadenaNumero, out numero);

if (anda)
{
    Calculadora calc = new Calculadora(numero);

    Console.WriteLine("Valor inicial del numero: "+calc.Resultado);

    calc.sumar(5);
    Console.WriteLine("Sumandole 5: "+calc.Resultado);

    calc.restar(3);
    Console.WriteLine("Restandole 3: "+calc.Resultado);

    calc.multiplicar(4);
    Console.WriteLine("Multiplicando por 2: "+calc.Resultado);

    calc.dividir(2);
    Console.WriteLine("Dividiendo en 2: "+calc.Resultado);
}