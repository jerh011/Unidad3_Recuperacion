namespace Unidad3_recuperacion
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Lista _Lista = new Lista();

            Console.WriteLine(_Lista.Longitud());


            do
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1.-Buscar por marca");
                Console.WriteLine("2.-mostras Lista ");
                Console.WriteLine("3.-Ingresar Datos");
                Console.WriteLine("4.-Finalizar");
                string Selecion = Console.ReadLine();
                if (Selecion != "1" && Selecion != "2" && Selecion != "3" && Selecion != "4")
                    Console.WriteLine("parametro no encontrado");
                Console.WriteLine("\n\n\n");
                if (Selecion == "4")
                    break;
                else if (Selecion == "1")
                    _Lista.Buscar();
                else if (Selecion == "2")
                    _Lista.Imprimir();
                else if (Selecion == "3")
                    _Lista.IngresaDatos();
                Console.WriteLine("\n\n\n");
            } while (true);
        }
    }
}