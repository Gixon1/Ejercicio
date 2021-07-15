using System;

namespace ProductoTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        public static bool Producto(string nombre, string codigo) =>
            nombre == "Palmolive" && codigo == "15091994" ? true:false;
    }
}
