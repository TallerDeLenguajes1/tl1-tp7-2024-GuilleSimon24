namespace EspacioEmpleados
{
    class Empleado
    {
         // Constructor vacío
        public Empleado() { }

        // Constructor con parámetros
        public Empleado(string nombre, string apellido, DateTime fechaDeNac, char estadoCivil, DateTime fechaIngre, double sueldoBase)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNac = fechaDeNac;
            this.estadoCivil = estadoCivil;
            this.fechaIngre = fechaIngre;
            this.sueldoBase = sueldoBase;
        }
        
        private string nombre;
        private string apellido;
        private DateTime fechaDeNac;
        private char estadoCivil;
        private DateTime fechaIngre;
        private double sueldoBase;
        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
        private Cargos cargo;

        // Métodos get y set
        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string value)
        {
            nombre = value;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public void SetApellido(string value)
        {
            apellido = value;
        }

        public DateTime GetFechaDeNac()
        {
            return fechaDeNac;
        }

        public void SetFechaDeNac(DateTime value)
        {
            fechaDeNac = value;
        }

        public char GetEstadoCivil()
        {
            return estadoCivil;
        }

        public void SetEstadoCivil(char value)
        {
            estadoCivil = value;
        }

        public DateTime GetFechaIngre()
        {
            return fechaIngre;
        }

        public void SetFechaIngre(DateTime value)
        {
            fechaIngre = value;
        }

        public double GetSueldoBase()
        {
            return sueldoBase;
        }

        public void SetSueldoBase(double value)
        {
            sueldoBase = value;
        }

        public int antiguedad(){
            DateTime actual;
            actual = DateTime.Now;
            int antiguedad = actual.Year - fechaIngre.Year;
            if (actual.Month > fechaIngre.Month || (actual.Month == fechaIngre.Month && actual.Day < fechaIngre.Day))
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public int edad(){
            DateTime actual;
            actual = DateTime.Now;
            int edad = actual.Year - fechaDeNac.Year;
            if (actual.Month < fechaDeNac.Month || (actual.Month == fechaDeNac.Month && actual.Day < fechaDeNac.Day))
            {
                edad--;
            }
            return edad;
        }

        public int paraJubilarse(){
            DateTime actual = DateTime.Now;
            int edad = actual.Year - fechaDeNac.Year;
            if (actual.Month < fechaDeNac.Month || (actual.Month == fechaDeNac.Month && actual.Day < fechaDeNac.Day))
            {
                edad--;
            }
            int edadJubilarse = 65 - edad;

            return edadJubilarse;
            
        }

        public double salario(){
            double salario;
            salario = sueldoBase;
            salario *= (1+(antiguedad()/100.0));
            switch (cargo)
            {   
                case Cargos.Ingeniero:
                    salario *= 1.5;
                    break;
                case Cargos.Especialista:
                    salario *= 1.5;
                    break;
                default:
                    salario = salario;
                    break;
            }
            if (estadoCivil == 'C'||estadoCivil == 'c')
            {
                salario += 150000;
            }

            return salario;
        }
        
    }
}