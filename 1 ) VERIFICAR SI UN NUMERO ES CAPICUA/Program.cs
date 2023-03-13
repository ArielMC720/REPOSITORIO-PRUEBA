using System;

namespace _1___VERIFICAR_SI_UN_NUMERO_ES_CAPICUA
{
    internal class Program
    {
        private static Libreria l = new Libreria();
        static void Main(string[] args)
        {
            int n;
            n = l.leerNumEnPosSC(" introduzca un numero");
            if (l.esCapicua(n))
            {
                l.mostrarMensaje("el numero " + n + " es capicua");

            }
            else
                l.mostrarMensaje("el numero " + n + "  no es capicua");
            l.pausa();

        }
    }
}
