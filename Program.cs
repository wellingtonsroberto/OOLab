using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLab
{
    class Program
    {
        static void Main(string[] args)  // Main seguinifica "metodo" isso "string[] args" são parametros.
        {

            Lampada l = new Lampada();

            l.Instalar("Sala");
            l.Ligar();
            l.Desligar();
            l.Ligar();

            

        
        }
    }
}
