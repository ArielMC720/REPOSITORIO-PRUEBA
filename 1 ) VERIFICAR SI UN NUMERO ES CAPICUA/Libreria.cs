using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Libreria
{
    // Módulos de Miscelaneo

    public void pausa()
    {
        //Console.WriteLine();
        mostrarMensaje("\nPRESIONE CUALQUIER TECLA,...");
        Console.ReadKey();
    }

    // Módulos de entrada
    public int leerNumEnt(string mensaje)
    {
        int n;

        mostrarMensaje(mensaje + " ");
        n = int.Parse(Console.ReadLine());
        return n;
    }

    public int leerNumEntPos(string mensaje)
    {
        int n;
        do
        {
            Console.Write(mensaje + " ");
            n = int.Parse(Console.ReadLine());
        } while (n < 0);
        return n;
    }
    public void dividir(int a, int b, ref int cos, ref int res)
    {
        cos = 0;
        while (a > b)
        {
            a -= b;
            cos++;
        }
        res = a;

    }
    public int leerDigito(string mensaje)
    {
        int n;
        do
        {
            Console.Write(mensaje + " ");
            n = int.Parse(Console.ReadLine());
        } while (n > 9 && n < 0);
        return n;
    }
    public bool existdiDigito(int a, int d)
    {
        while((a!=0) &&  (a % 10!= d))
        
            a /= 10;
            return a!=0;
        

    }

    public void leerNumEntPosSC(ref int n, string mensaje)
    {
        
        do
        {
            Console.Write(mensaje + " ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);
        
    }
    public void leerNumEntPos(ref int n, string mensaje)
    {

        do
        {
            Console.Write(mensaje + " ");
            n = int.Parse(Console.ReadLine());
        } while (n < 0);

    }
    public int leerNumEnPosSC(string mensaje)

    {
        int n;
        do
        {
            Console.Write(mensaje + " ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);
        return n;

    }


    


    public void leerNumEntL(ref long n, string mensaje)
    {
        do
        {
            Console.Write(mensaje+" ");
            n = long.Parse(Console.ReadLine());
        } while (n<0);
    }

    // Módulos de proceso

    public int mcm(int a, int b)
    {
        int x, y;
        x = a;
        y = b;
        while (a != b)
            if (a < b)
                a += x;
            else
                b += y;
        return a;
    }
    public int mcd(int a, int b)
    {
        while (a!=b)
            if (a > b)
                a -= b;  // a=a-b;
            else
                b -= a;
        return a;
    }
    public int mayorDigito(int n)
    {
        int d, m;

        m = 0;
        while (n != 0)
        {
            d = n % 10;
            if (d > m)
                m = d;
            n /= 10;
        }
        return m;
    }
    public int contarDigitos(long n)
    {
        int c;
        c = 0;
        while (n>0)
        {
            c++; // c=c+1;
            n /= 10; // n = n / 10;
        }
        return c;

    }

    

    public int multiplicaSumando(int a, int b)
    {
        int c,m;
        c = 0;
        m = 0;
        while (c < a)
        {
            m = m + b;
            c = c + 1;
        }
        return m;

    }
    public int invertir(int a )
    {
        int d;
        d = a % 10;
        a /= 10;
        while(a!=0)
        {
            d = a % 10 + d * 10;
            a /= 10;

        }
        return d;


    }
    public bool esCapicua(int a)
    {
        return invertir(a) == a;
    }
    public int sumar(int a, int b)
    {
        return a + b;
    }
    
    // Módulos de salida
        public void mostrarMensaje(string mensaje)
        {
            Console.Write(mensaje);
        }
    }

