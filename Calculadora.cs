namespace EspacioCalculadora{

    public class Calculadora
    {
        private double numero;

        public double Numero{
            get{ return numero; }
            set{ numero = value; }
        }

        public double Resultado{
            get{ return numero; }
        }

        public Calculadora (double Inicial){
            numero = Inicial;                           //Le doy un valor inicial al numero
        }

        public void sumar(double termino){
            numero += termino;
        }

        public void restar(double termino){
            numero -= termino;
        }
        
        public void multiplicar(double termino){
            numero *= termino;
        }

        public void dividir(double termino){
            if (termino != 0)
            {
                numero /= termino;    
            }
            else
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            
        }

        public void Limpiar(){
            numero = 0;
        }
    }
}

