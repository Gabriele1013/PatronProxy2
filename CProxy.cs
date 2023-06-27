using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se implementa el uso de clases anidadas
public class CProxy
{
    //Clase que funcionará como intermediario 
    public interface ISujeto
    {
        void Peticion(int pOpcion);
    }

    public class ProxySencillo : ISujeto
    {
        private CCocina cocina;
        public void Peticion (int pOpcion)
        {
            if (cocina == null)
            {
                Console.WriteLine("Activando el sujeto");
                cocina = new CCocina();
            }
            if (pOpcion == 1)
            {cocina.RecetaSecreta();}
            if (pOpcion == 2)
            {cocina.Cocinar(5);}
        }
    }

    public class ProxySeguro : ISujeto
    {
        private CCocina cocina;

        public void Peticion(int pOpcion)
        {
            string password = "";

            Console.WriteLine("Ingrese la contraseña: ");
            password = Console.ReadLine();

            if (password == "1234")
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new CCocina();
                }
                if (pOpcion == 1)
                    {cocina.RecetaSecreta();}
                if (pOpcion == 2)
                    {cocina.Cocinar(5);}
            }
            else
            {
                Console.WriteLine("Acceso Denegado");
            }
        }
    }

    private class CCocina
    {
        public void RecetaSecreta()
        {
            Console.WriteLine("Pan");
            Console.WriteLine("Aceite de oliva");
            Console.WriteLine("Especias");
            Console.WriteLine("Jamón");
            Console.WriteLine("Queso");
        }
        public void Cocinar(int n)
        {
            Console.WriteLine("Cocinando {0} recetas", n);
        }
    }
}