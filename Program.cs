using EspacioEmpleados;

Empleado nuevo = new Empleado();

Console.WriteLine("Ingrese el nombre del empleado: ");
string nombre = Console.ReadLine();
nuevo.SetNombre(nombre);
Console.WriteLine("Ingrese el apellido: ");
string apellido = Console.ReadLine();
nuevo.SetApellido(apellido);
Console.WriteLine("Ingrese la fecha de nacimiento formato dd/mm/aaaa: ");
string entrada = Console.ReadLine();
DateTime fechaNac;
bool andaFecha = DateTime.TryParse(entrada, out fechaNac);
if (andaFecha)
{
    nuevo.SetFechaDeNac(fechaNac);
}

Console.WriteLine("Ingrese el estado civil S (soltero), C (Casado), V (Viudo): ");
string estadoCivil = Console.ReadLine();

if (estadoCivil[0] != ' ')
{   
    char eCivil = estadoCivil[0];
    nuevo.SetEstadoCivil(eCivil);
}

Console.WriteLine("Se establecerá la fecha de hoy como ingresante");
nuevo.SetFechaIngre(DateTime.Now);

Console.WriteLine("Sueldo base?");
string cadenaSueldo = Console.ReadLine();
double sueldo;
bool andaSueldo = double.TryParse(cadenaSueldo,out sueldo); 
if (andaSueldo)
{
    nuevo.SetSueldoBase(sueldo);
}

int edad= nuevo.edad();
int antiguedad = nuevo.antiguedad();
int paraJubilarse = nuevo.paraJubilarse();

Console.WriteLine("Nombre: "+nuevo.GetNombre());
Console.WriteLine("Apellido: "+nuevo.GetApellido());
Console.WriteLine("Sueldo: "+nuevo.salario());
Console.WriteLine("Edad: "+edad);